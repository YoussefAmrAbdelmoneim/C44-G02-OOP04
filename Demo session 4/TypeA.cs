namespace Demo_session_4
{
    internal class TypeA
    {
        public int A { get; set; }
        public TypeA(int a)
        {
            A = a;
        }
        public void MyFun01()
        {
            Console.WriteLine("This is MyFun01 from Base and iam Base");
        }
        public virtual void MyFun02()
        {
            Console.WriteLine($"This is MyFun02 from Base and TypeA: {A}");
        }
    }
}
