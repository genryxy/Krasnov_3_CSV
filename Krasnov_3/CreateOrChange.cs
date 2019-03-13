﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;


namespace Krasnov_3
{
    public partial class CreateOrChangeForm : Form
    {
        /// <summary>
        /// Строка, в котороую нужно внести изменения.
        /// </summary>
        public int RowNum { get; set; } = 0;

        /// <summary>
        /// Множество ошибок.
        /// </summary>
        private readonly HashSet<Component> _errorComponents = new HashSet<Component>();

        /// <summary>
        /// Корректность данных.
        /// </summary>
        private bool _isCorrect;

        /// <summary>
        /// Текущий объект информации о штабе.
        /// </summary>
        private Headquarter _currentHeadInfo;

        /// <summary>
        /// Таблица из DataGridview
        /// </summary>
        private List<Headquarter> LstHead { get; set; }

        /// <summary>
        /// Подсказки об ошибках.
        /// </summary>
        private readonly Dictionary<TextBox, ToolTip> _errorToolTips = new Dictionary<TextBox, ToolTip>();

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="headInfo">изменяемый объект</param>
        public CreateOrChangeForm(Headquarter headInfo, List<Headquarter> lstActiveHeads)
        {
            InitializeComponent();
            ShowIcon = false;
            LstHead = lstActiveHeads;
            InitElementsByHead(headInfo);
        }

        /// <summary>
        /// Текущий объект информации о штабе.
        /// </summary>
        public Headquarter CurrentHeadInfo
        {
            get => _isCorrect ? _currentHeadInfo : null;
            private set => _currentHeadInfo = value;
        }

        /// <summary>
        /// Задаёт значения элементам в зависимости от преданной информации о штабе
        /// </summary>
        /// <param name="headInfo">информация о штабе</param>
        private void InitElementsByHead(Headquarter headInfo)
        {            
            if (headInfo == null)
            {
                Text = "Новая запись";
                CurrentHeadInfo = new Headquarter();
                textBoxRowNum.Text = RowNum.ToString();

            }
            else
            {
                Text = "Изменить запись";
                CurrentHeadInfo = headInfo;

                textBoxRowNum.Text = RowNum.ToString();
                textBoxName.Text = _currentHeadInfo.Name;
                textBoxAdmArea.Text = _currentHeadInfo.GeoLocation.AdmArea;
                textBoxDistrict.Text = _currentHeadInfo.GeoLocation.District;
                textBoxAddress.Text = _currentHeadInfo.Address;
                textBoxPublicPhone.Text = _currentHeadInfo.PublicPhone;
                textBoxExtraInfo.Text = _currentHeadInfo.ExtraInfo;
                textBoxX_WGS.Text = _currentHeadInfo.GeoLocation.X_WGS;
                textBoxY_WGS.Text = _currentHeadInfo.GeoLocation.Y_WGS;
                textBoxGLOBALID.Text = _currentHeadInfo.GLOBALID;
            }
            
            RowNumIntTextBoxCheck(textBoxRowNum, EventArgs.Empty);
            NotNullTextBoxCheck(textBoxName, EventArgs.Empty);
            NotNullTextBoxCheck(textBoxAdmArea, EventArgs.Empty);
            NotNullTextBoxCheck(textBoxDistrict, EventArgs.Empty);
            NotNullTextBoxCheck(textBoxAddress, EventArgs.Empty);
            DoubleLongtitudeTextBoxCheck(textBoxX_WGS, EventArgs.Empty);
            DoubleLatitudeTextBoxCheck(textBoxY_WGS, EventArgs.Empty);
            LongNotNullTextBoxCheck(textBoxGLOBALID, EventArgs.Empty);
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку ОК. Если все поля заполнены правильно,
        /// то выходит. В противном случае выводит сообщение об ошибке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            RowNumIntTextBoxCheck(textBoxRowNum, EventArgs.Empty);
            NotNullTextBoxCheck(textBoxName, EventArgs.Empty);
            NotNullTextBoxCheck(textBoxAdmArea, EventArgs.Empty);
            NotNullTextBoxCheck(textBoxDistrict, EventArgs.Empty);
            NotNullTextBoxCheck(textBoxAddress, EventArgs.Empty);
            DoubleLongtitudeTextBoxCheck(textBoxX_WGS, EventArgs.Empty);
            DoubleLatitudeTextBoxCheck(textBoxY_WGS, EventArgs.Empty);
            LongNotNullTextBoxCheck(textBoxGLOBALID, EventArgs.Empty);

            if (_errorComponents.Count == 0)
            {
                RowNum = int.Parse(textBoxRowNum.Text);
                _currentHeadInfo.Name = textBoxName.Text;
                _currentHeadInfo.Address = textBoxAddress.Text;
                _currentHeadInfo.PublicPhone = textBoxPublicPhone.Text;
                _currentHeadInfo.ExtraInfo = textBoxExtraInfo.Text;
                _currentHeadInfo.GLOBALID = textBoxGLOBALID.Text;

                _currentHeadInfo.GeoLocation = new LocationClass
                {
                    AdmArea = textBoxAdmArea.Text,
                    District = textBoxDistrict.Text,
                    X_WGS = textBoxX_WGS.Text,
                    Y_WGS = textBoxY_WGS.Text
                };

                Close();
            }
            else
            {
                MessageBox.Show("Введите корректные значения!", "Некорректные значения", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Создаёт ToolTip и добавляет его к TextBox. И связывает их в словаре.
        /// </summary>
        /// <param name="textBox">TextBox</param>
        /// <param name="message">Сообщение</param>
        private void AddTextBoxErrorToolTip(TextBox textBox, string message)
        {
            RemoveTextBoxErrorToolTip(textBox);
            var toolTip = new ToolTip
            {
                ToolTipTitle = "Error!",
                ToolTipIcon = ToolTipIcon.Error,
                InitialDelay = 150
            };
            _errorToolTips[textBox] = toolTip;
            toolTip.SetToolTip(textBox, message);
        }

        /// <summary>
        /// Удаляет ToolTip у переданного TextBox
        /// </summary>
        /// <param name="textBox">Объект TextBox, у которого надо удалить ToolTip</param>
        private void RemoveTextBoxErrorToolTip(TextBox textBox)
        {
            if (!_errorToolTips.ContainsKey(textBox))
                return;
            _errorToolTips[textBox].Dispose();
            _errorToolTips.Remove(textBox);
        }

        /// <summary>
        /// Проверяет значение TextBox на принадлежность типу long(больше 0) и на не пустоту. 
        /// Если результат неправильный, то добавляет ToolTip и меняет цвет текста или фона на красный.
        /// </summary>
        /// <param name="sender">Объект TextBox</param>
        /// <param name="e">Аргументы события</param>
        private void LongNotNullTextBoxCheck(object sender, EventArgs e)
        {
            var currentTextBox = (TextBox)sender;

            if (!long.TryParse(currentTextBox.Text, out var val) || val < 0)
            {
                if (currentTextBox.Text != "")
                {
                    currentTextBox.ForeColor = Color.Red;
                    AddTextBoxErrorToolTip(currentTextBox, "Wrong number format!");
                }
                else
                {
                    currentTextBox.BackColor = Color.Red;
                    AddTextBoxErrorToolTip(currentTextBox, "Obligatory field!");
                }
                _errorComponents.Add(currentTextBox);
            }
            else
            {
                _errorComponents.Remove(currentTextBox);
                RemoveTextBoxErrorToolTip(currentTextBox);
            }
        }

        /// <summary>
        /// Обработчик события входа в TextBox
        /// </summary>
        /// <param name="sender">Объект</param>
        /// <param name="e">Аргументы события</param>
        private void TextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
            ((TextBox)sender).BackColor = SystemColors.Window;
        }

        /// <summary>
        /// Проверяет значение TextBox на принадлежность типу int(больше 0).
        ///  Если результат неправильный, то добавляет ToolTip и меняет цвет текста на красный.
        /// </summary>
        /// <param name="sender">Объект TextBox</param>
        /// <param name="e">Аргументы события</param>
        private void RowNumIntTextBoxCheck(object sender, EventArgs e)
        {
            var currentTextBox = (TextBox)sender;
            var count = 0;
            if (LstHead != null)
            {
                count = LstHead.Count;
            }

            if (!int.TryParse(currentTextBox.Text, out var val) || val < 0 || val >= count)
            {
                currentTextBox.ForeColor = Color.Red;
                _errorComponents.Add(currentTextBox);
                AddTextBoxErrorToolTip(currentTextBox, $"You need a positive integer < {(count == 0 ? 1 : count)}");
            }
            else
            {
                _errorComponents.Remove(currentTextBox);
                RemoveTextBoxErrorToolTip(currentTextBox);
            }
        }

        /// <summary>
        /// Проверяет значение TextBox на не пустоту.
        ///  Если результат неправильный, то добавляет ToolTip и меняет цвет текста на красный.
        /// </summary>
        /// <param name="sender">Объект TextBox</param>
        /// <param name="e">Аргументы события</param>
        private void NotNullTextBoxCheck(object sender, EventArgs e)
        {
            var currentTextBox = (TextBox)sender;

            if (currentTextBox.Text == "")
            {
                currentTextBox.BackColor = Color.Red;
                _errorComponents.Add(currentTextBox);
                AddTextBoxErrorToolTip(currentTextBox, "Obligatory field!");
            }
            else
            {
                _errorComponents.Remove(currentTextBox);
                RemoveTextBoxErrorToolTip(currentTextBox);
            }
        }

        /// <summary>
        /// Проверяет значение TextBox на принадлежность типу double и диапазону долготы. 
        /// Если ошибка, то добавляет ToolTip и меняет цвет текста на красный.
        /// </summary>
        /// <param name="sender">Объект TextBox</param>
        /// <param name="e"></param>
        private void DoubleLongtitudeTextBoxCheck(object sender, EventArgs e)
        {
            var currentTextBox = (TextBox)sender;

            if (!double.TryParse(currentTextBox.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign,
                CultureInfo.InvariantCulture, out double longtit) || longtit < -180 || longtit > 180)
            {
                if (currentTextBox.Text != "")
                {
                    currentTextBox.ForeColor = Color.Red;
                    AddTextBoxErrorToolTip(currentTextBox, "Wrong input! The number must be out of range [-180, 180].");
                }
                else
                {
                    currentTextBox.BackColor = Color.Red;
                    AddTextBoxErrorToolTip(currentTextBox, "Obligatory field!");
                }

                _errorComponents.Add(currentTextBox);
            }
            else
            {
                _errorComponents.Remove(currentTextBox);
                RemoveTextBoxErrorToolTip(currentTextBox);
            }
        }

        /// <summary>
        /// Проверяет значение TextBox на принадлежность типу double и диапазону широты. 
        /// Если ошибка, то добавляет ToolTip и меняет фона на красный.
        /// </summary>
        /// <param name="sender">Объект TextBox</param>
        /// <param name="e"></param>
        private void DoubleLatitudeTextBoxCheck(object sender, EventArgs e)
        {
            var currentTextBox = (TextBox)sender;

            if (!double.TryParse(currentTextBox.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign,
                CultureInfo.InvariantCulture, out double longtit) || longtit < -90 || longtit > 90)
            {
                if (currentTextBox.Text != "")
                {
                    currentTextBox.ForeColor = Color.Red;
                    AddTextBoxErrorToolTip(currentTextBox, "Wrong input! The number must be out of range [-90, 90].");
                }
                else
                {
                    currentTextBox.BackColor = Color.Red;
                    AddTextBoxErrorToolTip(currentTextBox, "Obligatory field!");
                }

                _errorComponents.Add(currentTextBox);
            }
            else
            {
                _errorComponents.Remove(currentTextBox);
                RemoveTextBoxErrorToolTip(currentTextBox);
            }
        }
       
        /// <summary>
        /// Обработчик события, вызываемого после закрытия формы
        /// </summary>
        /// <param name="sender">Объект</param>
        /// <param name="e">Аргументы события</param>
        private void CreateOrChangeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _isCorrect = _errorComponents.Count == 0;
            if (_errorComponents.Count != 0)
                CurrentHeadInfo = null;
        }
    }
}