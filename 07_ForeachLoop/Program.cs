using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            // Foreach(1;2;3;4)
            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //4:Liste,Koleksiyon,Dizi

            //string[] cities = { "adana", "bursa", "denizli", "ankara", "kars", "tunceli" };

            //foreach (string city in cities )
            //{
            //    Console.WriteLine(city);
            //}
            //int[] numbers = { 14, 19, 42, 74, 53, 52, 91 };
            //foreach (int number in numbers )
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine("------------");
            //// çift sayılar
            //foreach (int number in numbers )
            //{
            //    if(number %2==0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            //Console.WriteLine("------------");
            //// tek sayılar
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 1)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            //int[] numbers1 = { 14, 19, 42, 74, 53, 52, 91 };
            //int sum = 0;
            //foreach (int number in numbers1)
            //{
            //    sum += number;
            //}
            //Console.WriteLine("Sayılaın toplamı: "+sum);


            //List<int> numbers= new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            ////hatalı yazma  
            //Console.WriteLine(numbers);

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //// foreach döngüsü diziler ve listelerde kullanılabilir

            //string word = "Kitaplik";

            //foreach (char c in word)
            //{
            //    Console.Write(c+"  ");
            //}
            #endregion

            #region Örnek Sınav Sistemi Uygulaması
            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            // Öğrenci sayısını kullanıcıdan alma
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount= int.Parse(Console.ReadLine());


            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin adını giriniz: ");
                studentNames[i] = Console.ReadLine();

                Console.WriteLine() ;
                Console.WriteLine();
                double totalExamResults = 0;
                // Her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}.sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResults += value;
                }
                studentExamAvg[i] = totalExamResults/3;
            }
            Console.WriteLine();
            Console.WriteLine();

            // Sınav ortalamaları 
            for (int i = 0;i < studentCount;i++)
            {
                Console.WriteLine("---------------------------");
                Console.Write($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
                
                Console.WriteLine() ;
                // Öğrencilerin ortalamalarına göre geçip kalma durumu
                if (studentExamAvg[i] >=50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı."); 
                }
                Console.WriteLine("--------------------------");
            }


            #endregion
            Console.Read();
        }
    }
}
