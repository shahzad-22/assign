using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            PositiveAndNegtive();
          
              
        }
        #region
        //Question#6 input array and sum 
        static void PositiveAndNegtive()
        {
            int add = 0, positive = 0, negative = 0, total = 0, Zero=0;

            float average;
            //int[] number = new int[5];
            //Console.WriteLine("Enter the number: ");

            //for (int i = 0; i < number.Length; i++)
            //{
            //    number[i] = int.Parse(Console.ReadLine());
           
            //}
            int[] number = { 10, 20,0, -30, 40,80,0 };
            total = number.Length;
             for (int k = 0; k < number.Length; k++)
              
                {
                    add +=number[k];
                    

                    if (number[k] > 0)
                    {
                        positive++;
                    }

                    else if (number[k] < 0)
                    {
                        negative++;
                    }
                    else if (number[k] == 0)
                    {
                         
                        Zero++;
                    }
                }

                    average = add / total;
                    Console.WriteLine("The total Number in array " + total);
                    Console.WriteLine("The number of positives is " + positive);
                    Console.WriteLine("The number of negatives is " + negative);
                    Console.WriteLine("The number of Zero is " + Zero);
                    Console.WriteLine("The average is " + average);

                Console.ReadKey();

        }
        #endregion
        #region
        //Question 7
        static void vowelsAppears()
        {
            String str = "eutopia";
            conVowUpp(str.ToCharArray());
             int N = str.Length;
 
                  for (int i = 0; i < N; i++)
                  {
                    if (str[i] == 'a' || str[i] == 'e' ||
                        str[i] == 'i' || str[i] == 'o' ||
                        str[i] == 'u')
                    {
                      char c = char.ToUpperInvariant(str[i]);

                      str[i] = c;
                    }
                  }
                  foreach(char c in str)
                    Console.Write(c);
                }
 
              
        }
        #endregion

    }
    

