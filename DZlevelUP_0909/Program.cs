using System;


namespace DZlevelUP_0909
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap(a, b);
            {
                int a = 5,
                    b = 7;
                
                Swap(a, b);
            }

            // Swap(ref a, b); 
            {
                int a = 5,
                    b = 7;
                
                Swap(ref a, b); 
            }
            
            // Swap(a, ref b); 
            {
                int a = 5,
                    b = 7;

                Swap(a, ref b); 
            }
            
            // Swap(a, b, out a_);
            {
                int a = 5,
                    b = 7,
                    a_ = 0;
                Swap(a, b, out a_);
            }
            
            // Swap(a, out a_, b);
            {
                int a = 5,
                    b = 7,
                    a_ = 0;
                Swap(a, out a_, b);
            }
            
            // Swap(out a_, a, b);
            {
                int a = 5,
                    b = 7,
                    a_ = 0;
                Swap(out a_, a, b);
            }
            
            // Swap(ref a, b, out a_);
            {
                int a = 5,
                    b = 7,
                    a_ = 0;
                Swap(ref a, b, out a_);
            }
            
            // Swap(a, ref b, out a_);
            {
                int a = 5,
                    b = 7,
                    a_ = 0;
                Swap(a, ref b, out a_);
            }
            
            // Swap(a, b, out a_, out b_);
            {
                int a = 5,
                    b = 7,
                    a_ = 0,
                    b_ = 0;
                Swap(a, b, out a_, out b_);
            }
            
            //Swap(a, out a_, b,  out b_);
            {
                int a = 5,
                    b = 7,
                    a_ = 0,
                    b_ = 0;
                Swap(a, out a_, b,  out b_);
            }
            
            // Swap(ref a, out a_, b, out b_);
            {
                int a = 5,
                    b = 7,
                    a_ = 0,
                    b_ = 0;
                Swap(ref a, out a_, b, out b_);
            }
            
            // Swap(a, out a_, ref b, out b_);
            {
                int a = 5,
                    b = 7,
                    a_ = 0,
                    b_ = 0;
                Swap(a, out a_, ref b, out b_);
            }
            
            // Swap(ref a, out a_, ref b, out b_);
            {
                int a = 5,
                    b = 7,
                    a_ = 0,
                    b_ = 0;
                Swap( ref a, out a_, ref b, out b_);
            }

        }

        static void Swap(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("1");
            Console.WriteLine($"a = {a}, b = {b} \n");
        }

        static void Swap(ref int a, int b)
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("2");
            Console.WriteLine($"a = {a}, b = {b} \n");
        }

        static void Swap(int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("3");
            Console.WriteLine($"a = {a}, b = {b} \n");
        }

        static void Swap(int a, int b, out int a_)
        {
            int c = a;
            a = b;
            b = c;
            a_ = a;
            Console.WriteLine("4");
            Console.WriteLine($"a = {a}, b = {b} \n");
            
        }

        static void Swap(int a, out int a_, int b )
        {
            int c = a;
            a = b;
            b = c;
            a_ = a;
            Console.WriteLine("5");
            Console.WriteLine($"a = {a}, b = {b} \n");

        }

        static void Swap(out int a_, int a, int b)
        {
            int c = a;
            a = b;
            b = c;
            a_ = a;
            Console.WriteLine("6");
            Console.WriteLine($"a = {a}, b = {b} \n");

        }

        static void Swap(ref int a, int b, out int a_)
        {
            int c = a;
            a = b;
            b = c;
            a_ = b;
            Console.WriteLine("7");
            Console.WriteLine($"a = {a}, b = {b} \n");

        }

        static void Swap(int a, ref int b, out int a_)
        {
            int c = a;
            a = b;
            b = c;
            a_ = b;
            Console.WriteLine("8");
            Console.WriteLine($"a = {a}, b = {b} \n");

        }

        static void Swap(int a, int b, out int a_, out int b_)
        {
            int c = a;
            a = b;
            b = c;
            a_ = a;
            b_ = b;
            Console.WriteLine("9");
            Console.WriteLine($"a = {a}, b = {b} \n");

        }

        static void Swap(int a, out int a_, int b,  out int b_)
        {
            int c = a;
            a = b;
            b = c;
            a_ = a;
            b_ = b;
            Console.WriteLine("10");
            Console.WriteLine($"a = {a}, b = {b} \n");

        }

        static void Swap(ref int a, out int a_, int b, out int b_)
        {
            int c = a;
            a = b;
            b = c;
            a_ = a;
            b_ = b;
            Console.WriteLine("11");
            Console.WriteLine($"a = {a}, b = {b} \n");

        }

        static void Swap(int a, out int a_, ref int b, out int b_)
        {
            int c = a;
            a = b;
            b = c;
            a_ = a;
            b_ = b;
            Console.WriteLine("12");
            Console.WriteLine($"a = {a}, b = {b} \n");

        }

        static void Swap(ref int a, out int a_, ref int b, out int b_)
        {
            int c = a;
            a = b;
            b = c;
            a_ = a;
            b_ = b;
            Console.WriteLine("13");
            Console.WriteLine($"a = {a}, b = {b} \n");

        }

    }

}
