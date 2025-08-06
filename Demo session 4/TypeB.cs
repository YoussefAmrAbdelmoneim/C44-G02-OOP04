namespace Demo_session_4
{
    internal class TypeB:TypeA
    {
        public int B { get; set; }
        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }
        new public void MyFun01()
        {
            Console.WriteLine("This is MyFun01 from Derived and iam Child");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"This is MyFun02 from Derived and TypeB: A={A} , B={B}");
        }
    }
}
