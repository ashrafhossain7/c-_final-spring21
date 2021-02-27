using System;

namespace basicDatatype
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 10;
            bool hasval = true;
            Console.WriteLine(a);
            Console.WriteLine(hasval);
            Console.WriteLine("the value of a id ." + a);
            Console.WriteLine("the value is :" +a+ "and bool value is:" + hasval);
            Console.WriteLine("the value of a id {0} and bool value is {1}",a,hasval);
            */
            byte a = 8;//like a cup of tea
            int b = a;//like an empty kettle

            int c = 8;//a kettle containing a cuo of tea
            byte d = (byte)c;// an empty cup

            double f = 8.5f;
            float g= 8.5f;
            Console.WriteLine("f={0} and g= {1}", f, g);
        }
    }
}
