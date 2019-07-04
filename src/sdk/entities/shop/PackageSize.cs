namespace ZaloDotNetSDK.entities.shop
{
    public class PackageSize
    {
        private double weight;
        private double length;
        private double width;
        private double height;

        public PackageSize(double weight, double length, double width, double height)
        {
            Weight = weight;
            Length = length;
            Width = width;
            Height = height;
        }

        public PackageSize()
        {
        }

        public double Weight { get => weight; set => weight = value; }
        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }
    }
}