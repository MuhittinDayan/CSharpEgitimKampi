﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ado .net

            //Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi");
            //Console.WriteLine();
            //string tableNumber;
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("1-Kategoriler");
            //Console.WriteLine("2-Ürünler");
            //Console.WriteLine("3-Siparişler");
            //Console.WriteLine("Çıkış Yap");
            //Console.WriteLine("Lütfen girmek istediğiniz tablo numarasını giriniz");
            //tableNumber = Console.ReadLine();
            //Console.WriteLine("-------------------------------------------------");


            SqlConnection connection = new SqlConnection("Data Source=MDAYAN\\SQLEXPRESS;initial Catalog=EğitimKampıDb;integrated security = true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory",connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
            }


            Console.Read();
            
        }
    }
}
