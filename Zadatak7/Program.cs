using System;

namespace Zadatak7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           
            int[] sort =new int[2];
            char upis = '0';
            int per = 0, brojac = 2;
            Console.WriteLine("Upisite brojeve i kada biste htijeli prestati pretisnite g: ");



            while (upis != 'g')
            {

                upis = Convert.ToChar(Console.ReadLine());
                if (upis == 'g')
                {
                    per = Convert.ToInt32(upis);
                }

                
               List<string> list = new List<string>();
                    list.Add("one"  );
                    list.Add("two");
                    list.Add("three");

                    int[] array = list.ToArray();
            
            

            
            }


            Array.Sort(sort);

            for (int g=0;g<=sort.Length;g++)
            {
                Console.Write(sort[g]);
                Console.Write(" ");
            }

        }

    }

}



