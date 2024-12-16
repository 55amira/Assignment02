using System.Text;

namespace Demo
{
    internal class Program
    {
        static void Main()
        {




            #region Control Statment: 2.Loops Statment (For,Foreach)
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello Word");
            //}
            //int i = 0;
            //for (Console.WriteLine("Hello 1"); i < 10; Console.WriteLine("Hello 2"))
            //{
            //    Console.WriteLine("Hello Word");
            //    i++;
            //}

            //int[] Numbers = { 1, 2, 3, 4, 5, 6 };
            //for (int i = 0; i < Numbers.Length; i++)
            //{ 
            //     Console.WriteLine(Numbers[i]); 
            //}

            //foreach (int i in Numbers) 
            //{
            //    Console.WriteLine(Numbers[i]);
            //} 
            #endregion

            #region Control Statment: 3.Loops Statment (While,doWhile)

            //while (true) 
            //{
            //    Console.WriteLine("Hello Word");
            //}

            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine("Hello Word");
            //    i++;
            //}
            //Console.WriteLine(i);
            //int i = 1;
            //do 
            //{

            //    Console.WriteLine("Hello Word");
            //     i++;


            //} while (i<=10);

            //int Number;
            //bool Flage;
            //do
            //{
            //    Console.Write("Enter Even Number : ");
            //   Flage=  int.TryParse(Console.ReadLine(), out Number );
            //} while (Number % 2 != 0 || Flage==false);
            //Console.WriteLine(Number);

            #endregion







            #region String

            //string S01;

            ////S01 = new string("Ahmed");
            //S01 = "Ahmed";
            //Console.WriteLine(S01.GetHashCode());

            //S01 = "ali";
            //Console.WriteLine(S01.GetHashCode());

            //S01 = "yassmine";
            //Console.WriteLine(S01.GetHashCode());

            //string Message = "Hello";
            //Console.WriteLine("Message: "+Message); 
            //Console.WriteLine("HashCode= "+Message.GetHashCode());

            //Console.WriteLine();

            //Message += " ahmed";
            //Console.WriteLine("Message: " + Message);
            //Console.WriteLine("HashCode= " + Message.GetHashCode());

            #endregion

            #region StringBuilder
            //StringBuilder Message = new StringBuilder("Hello ");
            //Console.WriteLine("Message: " + Message);
            //Console.WriteLine("HashCode= "+Message.GetHashCode());

            //Console.WriteLine();

            //Message.Append(" ahmed");
            //Console.WriteLine("Message: " + Message);
            //Console.WriteLine("HashCode= " + Message.GetHashCode());

            #endregion

            #region BulidFunctionString
            //string S01 = "Hello Ahmed";
            //string Result = S01.Substring(3);
            //Console.WriteLine(Result);

            //Console.WriteLine(S01.Replace("Hello", "Welcome"));
            //Console.WriteLine(S01.StartsWith("H"));
            //S01.ToCharArray();



            #endregion






















        }
    }
}
