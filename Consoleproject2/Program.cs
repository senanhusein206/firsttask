namespace Consoleproject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array verilir  ve n ededi daxil olunurçeger n ədədi arrayin icerisendikiistenilen bir ededden boyukdurse true,deyilse falsr qaytarsin
            int n = 5;
            int[] arr = { 1, 2, 3, 4, 5, 6, n  };
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (n > arr[i])
                {
                    Console.WriteLine("True");
                    break;
                }
              
            }






            
            //ededlerden ibaret bir array verilir, bu arreyin icerisindeki en boyuk elementi tapin
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int enBig = arr1[0];
            for (int i = 0; i < arr1.Length; i++)
            {
                if (enBig < arr1[i])
                {
                    enBig = arr1[i];
                }
            }

            Console.WriteLine(enBig);



            //verilmis ededin polindrom olub olmadigini yoxlayan proqram yazin
            int number = 12321;
            int qaliq;
            int reverse = 0;
            while (number!=0)
            {
                qaliq=number%10;
                reverse = (reverse * 10) + qaliq;
                number -= qaliq;
                number /= 10;
            }
            Console.WriteLine("Sizizn reqemin polidromu " + reverse);

            //verilmis ededin faktorialini tapin
            int number1 = 5;
            int fac = 1;
            for (int i = number1-1; i > 0; i--)
            {
                fac *= i;
            }
            Console.WriteLine(fac);


            //verilmis ededin reqemlerinin hasilini tapan proqram yazin
            int number2 = 1234;
            int hasil = 1;
            int qaliq1;

            while (number2>0)
            {
                qaliq1 = number2 % 10;
                hasil *= qaliq1;
                number2 /= 10;
            }
            Console.WriteLine(hasil);



            //verilmis ededin sade ve ya murekkeb oldugunu tapan alqoritm yazin
             int number3 = 7;

            for (int i =2; i<number3; i++)
            { if(number3%i==0)
                {
                    Console.WriteLine("Murekkeb");
                    break;
                }
                else
                {
                    Console.WriteLine("sadedir");
                    break;
                } 
                        }

            //sozlerden ibaret arrayin icerisinde verilen sozu tapin
            string[] arr2 = { "Galatasaray", "Real MAdrid", "Liverpool", "Inter", "Bayer Leverkusen" };
            string word = "Galatasaray";
            for (int i = 0; i < arr2.Length; i++)
            {
               if (arr2[i] ==word)
                {
                    Console.WriteLine(arr2[i]);
                }
            }



            //soz ve herf evrilib , sozun icerisinde verilen herfin olub olmadigini yoxlayan proqram yazin
            string word1 = "Hello";
            char sad = 'e';
            for (int i = 0; i <word1.Length; i++)
            {
                if (word1[i]==sad)
                {
                    Console.WriteLine("herf var");
                    break;
                }
                
            }

            //array icerisuindeki sozleri tersine cevirin
            string[] arrrr = { "Baki", "Semkir", "Sumqayit", "Gence" };



            foreach (var i in arrrr)
            {
                for (int j = i.Length-1; j >=0; j--)
                {
                    Console.Write(i[j]);
                }
                Console.WriteLine(" ");
            }




            //array icerisuindeki sozlerin sirasini   tersine cevirin

            string[] array = { "Baki", "Semkir", "Sumqayit", "Gence" };

          
            Console.WriteLine("Tersten Ekrana Yaz");
            Array.Reverse(array);

            foreach (string i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.ReadLine();




           
            }
        }
    }
}
