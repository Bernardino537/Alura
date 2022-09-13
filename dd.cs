namespace console_app
{
    class program
    {
        public static float Somar()
        {
            int a =1;
            int b =2;
            int c =a + b;


            return c;
        }
        static void Main(String[] args)
        {
            Console.WriteLine(Somar());
            Console.ReadLine();
        }
    }
}

