using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar
            //()
            // Geriye değer döndürmeyen metotlar
            // Customer --> Lİstele,ekle,si,güncelle
            // Void

            //void customerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Kaya");
            //    Console.WriteLine("Ahemt Balaban");
            //    Console.WriteLine("Melisa Bora");
            //}

            //customerList();

            //void sum()
            //{
            //    int x = 16;
            //    int y = 20;
            //    int z = x+y;
            //    Console.WriteLine(z);

            //}
            //sum();

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void writeMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //writeMethod("ahmet yıldız");

            //void CustomerCard(string customerName, string customerSurname)
            //{
            //    Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //} 
            //CustomerCard("Mehmet", "Evren");
            //CustomerCard("Gamze", "Naz");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(12, 45, 85);

            #endregion

            #region  Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Atmaca";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ahmet";
            //    string surname = "Hayırlı";

            //    return name + surname;
            //}
            //Console.WriteLine(StudentCard());



            #endregion

            #region Geriye Değer Döndüren Parametreli Metotlar

            //string CountryCard (string countryName,string capital,string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;

            //    return cardInfo;
            //}

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            //string c_countryName, c_capital, c_flagColor;
            //Console.WriteLine("Ülke adını giriniz");
            //c_countryName = Console.ReadLine();
            //Console.WriteLine("Başkenti giriniz");
            //c_capital = Console.ReadLine();
            //Console.WriteLine("Bayrak rengi gitiniz");
            //c_flagColor = Console.ReadLine();

            //Console.WriteLine(CountryCard(c_countryName,c_capital,c_flagColor));


            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(23, 45));
            //Console.WriteLine(Sum(21, 47));
            //Console.WriteLine(Sum(10,98));
            //Console.WriteLine(Sum(2,67));

            #endregion

            #region Örnek Uygulama
            string ExamResult(string studentName,int exam1,int exam2,int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;

                if(result >=50)
                {
                    return studentName + " isimli öğrenci dersi geçti " + "Ortalama: " + result;
                }
                else
                {
                    return studentName + " isimli öğrenci dersi geçemedi " + "Ortalama: " + result;
                }
            }

            Console.WriteLine(ExamResult("Hasan", 27, 54, 81));
            Console.WriteLine(ExamResult("Aslı", 75, 86, 89));
            Console.WriteLine(ExamResult("Emre", 20, 45, 39));


            #endregion

            Console.Read();
        }
    }
}
