namespace Assignment_4
{
    internal class Rectangle
    {
        private int width;
        private int height;

        public Rectangle()
        {
           width = 0;
           height = 0;
        }
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle(int value)
        {
            this.width = value;
            this.height = value;
        }
    }
}
