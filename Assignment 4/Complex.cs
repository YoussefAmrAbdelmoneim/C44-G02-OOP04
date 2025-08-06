namespace Assignment_4
{
    internal class Complex
    {
        public int real { get; set; }
        public int imaginary { get; set; }
        public override string ToString()
        {
            return $"{real} + {imaginary}i";
        }
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {
                real = (left?.real ??0) + (right?.real ?? 0),
                imaginary=(left?.imaginary ?? 0) + (right?.imaginary ?? 0)
            };
        }
        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                real = (left?.real ?? 0) - (right?.real ?? 0),
                imaginary = (left?.imaginary ?? 0) - (right?.imaginary ?? 0)
            };
        }
    }
}
