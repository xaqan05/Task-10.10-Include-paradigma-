// 1.Verilen 2 ededin yerini deyisdiren metod

namespace Task__10._10_
{
    /*    internal class Program
        {
            static void Main(string[] args)
            {

                int num1 = int.Parse(Console.ReadLine());
                ChangeNumbers(ref num1);
                Console.WriteLine(num1);
            }

            static void ChangeNumbers(ref int num1)
            {
                int num2 = int.Parse(Console.ReadLine());
                num1 = num2;    
            }
        }
    }*/










    // 2.Ededlerden ibaret arrayin menfi elementlerini musbete ceviren metod yazin. (array assign olmadan gonderile bilmesin)


    /*   internal class Program
       {
           static void Main(string[] args)
           {
               int[] arr = { 5, 2, -3, -1, 9, -10 };

               setPositive(ref arr);

           }

           static void setPositive(ref int[] arr)
           {
               for (int i = 0; i < arr.Length; i++)
               {
                   if (arr[i] < 0)
                   {
                       arr[i] = -arr[i];
                   }

                   Console.WriteLine(arr[i]);
               }
           }

       }
   }*/



    // 3. 2 int parametr qebul eden bir method yazirsiniz.Bu ededleri consoleden daxil edirsiniz ve eger int'e cevrile bilirse cemini qaytarirsiniz.
    // (Ededler mutleq sekilde method daxilinde assign olunmalidir.)

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1ci ededi daxil edin:");
            string input1 = Console.ReadLine();
            Console.WriteLine("2ci ededi daxil edin:");
            string input2 = Console.ReadLine();
            checkNumbers(input1, input2); 
        }

        static void checkNumbers(string s1, string s2)
        {
            int num1;
            int num2;

            bool result1 = int.TryParse(s1, out num1);
            bool result2 = int.TryParse(s2, out num2);
            if (result1 && result2)
            {
                int sum = 0;
                sum = num1 + num2;
                Console.WriteLine("Cevrilme ugurlu oldugu ucun daxil etdiyiniz ededlerin cemi:" + sum);
            }
            else
            {
                Console.WriteLine("Cevrilme ugursuz oldu");
            }
        }

    }
}