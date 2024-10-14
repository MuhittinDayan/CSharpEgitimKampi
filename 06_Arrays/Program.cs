using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            // 1,2,3,4,5,6...
            // adana bursa ceyhan denizli edirne

            // Değişken Türü [] DiziAdı =new DeğişkenTürü [eleman sayısı]

            //string[] colors = new string[4];
            //colors[0] = "kirmizi";
            //colors[1] = "sari";
            //colors[2] = "mavi";
            //colors[3] = "beyaz";

            //Console.WriteLine(colors[1]);

            //string[] cities = new string[5];
            //cities[0] = "istanbul";
            //cities[1] = "madrid";
            //cities[2] = "milano";
            //cities[3] = "paris";
            //cities[4] = "berlin";

            //Console.WriteLine(cities[2]);

            //int[] numbers = new int[10];
            //numbers[0] = 4;
            //numbers[1] = 18;
            //numbers[2] = 26;
            //numbers[7] = 80;

            //// dizideki yeri boş olduğu için 0 değerini döndürür
            //Console.WriteLine(numbers[4]);

            //farklı tanımlama şekli
            //string[] cities = { "prag", "roma", "ankara", "atina" };

            //Console.WriteLine(cities[3]);
            #endregion,

            #region Dizideki Tüm Elemanları Listeleme

            // string[] colors = { "kirmizi", "mavi", "sari", "beyaz", "yeşil", "mor" };

            // iki ayrı kullanım
            //for (int i=0;i<=5;i++)
            //    Console.WriteLine(colors[i]);


            //for (int i=0;i<=colors.Length;i++)
            //    Console.WriteLine(colors[i]);

            //int[] numbers = { 14, 5, 3, 784, 21, 56, 485, 432, 291 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%3==0)
            //        Console.WriteLine(numbers[i]);
            //}

            //char[] symbols = {'m','h','t','=','*'};

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            // dizideki en büyük elemanı bulma

            //int[] myArray = { 1, 2, 8, 74, 65, 23, 487, 954, 1021 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i]>maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}

            //Console.WriteLine("En büyük sayı: " + maxNumber);

            //string[] persons = { "ahmet", "mehmet", "ali", "ayşe", "elif", "hasan" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 41, 45, 85, 75, 65, 25, 63, 8, 999 };
            //// dizi karakterlerini küçükten büyüğe doğru sıralama
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 41, 45, 85, 75, 65, 25, 63, 8, 999 };
            //// dizi elemanlarını tersten yazdırma
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotlar

            //// dizideki herhangi bir elemanın index numarasını öğrenme
            //string[] customers = { "ali", "ahmet", "mehmet", "ayşe", "merve", "alper", "nehir" };
            //int index = Array.IndexOf(customers, "merve");

            //Console.WriteLine(index);

            //int[] numbers = { 14, 45, 42, 65, 85, 98, 32 };
            //Console.WriteLine("Dizinin en küçük elemanı: " + numbers.Min());
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max());


            #endregion

            #region kullanıcıdan değer alma

            //string[] cities = new string[5];
            //Console.WriteLine("Lütfen 5 şehir adı giriniz");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    cities[i] = Console.ReadLine();
            //}

            // daha temiz versiyon

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i+1}. Şehri Giriniz");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine("------------------");
            //for (int i = 0;i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 1, 2, 7, 15, 19, 25, 47, 63, 52 };
            //int sum = 0;
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 2, 54, 74, 541, 652, 257, 873, 251 };

            //Console.WriteLine("Çift Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%2==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("Tek Sayılar");
            //for (int i = 0;i < numbers.Length; i++)
            //{
            //    if(numbers[i]%2==1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();

        }
    }
}
