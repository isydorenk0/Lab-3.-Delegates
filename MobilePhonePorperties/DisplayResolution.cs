namespace LabC
{
    public class DisplayResolution
    {
        public DisplayResolution(int horiz, int vert, int dpi, double diagonal)
        {
            Horizontal = horiz;
            Vertical = vert;
            Diagonal = diagonal;
            Dpi = dpi;
        }
         public int Horizontal
        {
            get { return vHorizontal; }
            private set { vHorizontal = value; }
        }
        public int Vertical
        {
            get { return vVertical; }
            private set { vVertical = value; }
        }
        public double Diagonal
        {
            get { return vDiagonal; }
            private set { vDiagonal = value; }
        }
        public int Dpi
        {
            get { return vDpi; }
            private set { vDpi = value; }
        }

        private int vHorizontal;
        private int vVertical;
        private double vDiagonal;
        private int vDpi;

        public string ReturnResolution()
        {
            string resolution;
            resolution = $"{Diagonal.ToString()} inches; {Horizontal.ToString()}x{Vertical.ToString()} pixels; {CalculatePpi(Horizontal, Vertical, Diagonal)} ppi";
            return resolution; 
        }

        private string CalculatePpi(int vertical, int horizontal, double diagonal)
        {            
            var d0 = System.Math.Sqrt((System.Math.Pow(vertical, 2) + System.Math.Pow(horizontal, 2)));
            string ppi = System.Math.Round((d0 / diagonal)).ToString();
            return ppi;
        }
    }
}
