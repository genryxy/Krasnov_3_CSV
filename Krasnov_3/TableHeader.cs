namespace Krasnov_3
{
    public class TableHeader
    {
        public TableHeader() { }

        public TableHeader(string name, string admArea, string district, string address, 
            string publicPhone, string extraInfo, string x_WGS, string y_WGS, string gLOBALID)
        {
            Name = name;
            AdmArea = admArea;
            District = district;
            Address = address;
            PublicPhone = publicPhone;
            ExtraInfo = extraInfo;
            X_WGS = x_WGS;
            Y_WGS = y_WGS;
            GLOBALID = gLOBALID;
        }
        public string Name { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string PublicPhone { get; set; }
        public string ExtraInfo { get; set; }
        public string X_WGS { get; set; }
        public string Y_WGS { get; set; }
        public string GLOBALID { get; set; }
    }
}
