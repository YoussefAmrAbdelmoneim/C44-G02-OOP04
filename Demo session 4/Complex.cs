namespace Demo_session_4
{
    internal class Complex
    {
        public int real { get; set; }
        public int imaginary { get; set; }
        public override string ToString()
        {
            return $"{real} + {imaginary}i";
        }
        #region Binary operatores
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {
                real = (left?.real ?? 0) + (right?.real ?? 0),
                imaginary = (left?.imaginary ?? 0) + (right?.imaginary ?? 0)
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
        #endregion
        #region Unary Operators
        public static Complex operator ++(Complex c)
        {
            return new Complex()
            {
                real = (c?.real ?? 0) +1,
                imaginary = (c?.imaginary ?? 0)
            };
        }
        public static Complex operator --(Complex c)
        {
            return new Complex()
            {
                real = (c?.real ?? 0) - 1,
                imaginary = (c?.imaginary ?? 0)
            };
        }
        #endregion
        #region Relational Operators
        public static bool operator >(Complex left, Complex right)
        {
            if (left?.real == right?.real)
            {
                return left?.imaginary > right?.imaginary;
            }
            else
            {
                return left?.real > right?.real;
            }
        }
        public static bool operator <(Complex left, Complex right)
        {
            if (left?.real == right?.real)
            {
                return left?.imaginary < right?.imaginary;
            }
            else
            {
                return left?.real < right?.real;
            }
        }
        #endregion
    }
}
