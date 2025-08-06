namespace Demo_session_4
{
    internal class Program
    {
        #region Method OverLoading
        //public static int SumNumbers(int x,int y)
        //{
        //    return x + y;
        //}
        //public static double SumNumbers(double x, int y)
        //{
        //    return x + y;
        //}
        //public static int SumNumbers(int x, int y,int z)
        //{
        //    return x + y +z;
        //}
        //public static double SumNumbers(double x, double y)
        //{
        //    return x + y;
        //}
        #endregion
        static void Main(string[] args)
        {
            // int a = 10, b = 20;
            //int result= SumNumbers(a, b);
            // result = SumNumbers(10,20,30);
            // SumNumbers(1.2, 10);
            // Console.WriteLine(result);
            //Complex c1 = new Complex() { real = 10, imaginary = 5 };
            //Complex c2 = new Complex() { real = 6, imaginary = 2 };
            //Complex? c3 = default;
            //c3 = c1 + c2;
            //Console.WriteLine($"c1: {c1}");
            //Console.WriteLine($"c2: {c2}");
            //Console.WriteLine("----------------");
            //Console.WriteLine($"c3: {c3}");
            //c3--;
            //Console.WriteLine($"c3: {c3}");
            //if (c1 >c2)
            //    Console.WriteLine("c1>c2");
            //else if (c1<c2)
            //    Console.WriteLine("c2>c1");
            //else
            //    Console.WriteLine("c1==c2");

            //TypeB typeBObj = new TypeB(1,2);
            //typeBObj.A = 10;
            //typeBObj.B = 20;
            //typeBObj.MyFun01();
            //typeBObj.MyFun02();

            #region Binding
            //TypeA refBase = new TypeB(1,2);
            //refBase.A = 10;
            //refBase.MyFun01(); //Static Polymorphism -static binding - early binding
            ////compilation time
            ////overriding using new
            ////resolve at compile time based on reference type


            //refBase.MyFun02(); //Dynamic Polymorphism -dynamic binding - late binding
            ////runtime time
            ////overriding using override
            ////resolve at run timebased on object type

            #endregion
        }
    }
}
