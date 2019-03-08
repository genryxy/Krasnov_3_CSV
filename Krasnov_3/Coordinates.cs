namespace Krasnov_3
{
    public class Coordinates
    {
        public string District { get; private set; }
        public string X_WGS { get; private set; }
        public string Y_WGS { get; private set; }

        public Coordinates() { }
        /*public Coordinates(string x_WGS, string y_WGS)
        {
            X_WGS = x_WGS;
            Y_WGS = y_WGS;
        }*/

        public Coordinates(string district, string x_WGS, string y_WGS)
        {
            District = district;
            X_WGS = x_WGS;
            Y_WGS = y_WGS;
        }

        public override string ToString()
        {
            return $"   Coord: District:{District}, X:{X_WGS}, Y:{Y_WGS}";
        }
    }
}