using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crud --> Create-Read-Update-Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();
            Console.WriteLine("------------------------");

            #region Kategori Ekleme İşlemi


            Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            string categoryName= Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=MDAYAN\\SQLEXPRESS;initial catalog=EgitimKampiDB;integrated security=true");

            connection.Open();

            SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values(@p1)",connection);
            command.Parameters.AddWithValue("@p1", categoryName);

            command.ExecuteNonQuery();

            

            connection.Close();
            Console.WriteLine("Kategori başarılı şekilde eklendi");

            #endregion

            #region Ürün Ekleme İşlemi

            string productName;
            decimal productPrice;
            bool productStatus;

            Console.WriteLine("Ürün Adı: ");
            productName = Console.ReadLine();
            Console.WriteLine("Ürün Fiyatı");
            productPrice= decimal.Parse(Console.ReadLine());

            SqlConnection connection1 = new SqlConnection("Data Source=MDAYAN\\SQLEXPRESS; initial catalog = EgitimKampiDB; integrated security=true");
            connection1.Open(); // bağlantı açma

            // sorgu ekleme
            SqlCommand command1 = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) values(@productName,@productPrice,@productStatus)", connection1);

            command1.Parameters.AddWithValue("@productName", productName);
            command1.Parameters.AddWithValue("@productPrice", productPrice);
            command1.Parameters.AddWithValue("@productStatus", true);

            
            command1.ExecuteNonQuery();
            
            //bağlantıyı kapat
            connection1.Close();

            Console.WriteLine("Ürün başarıyla eklendi");

            #endregion

            #region Ürün Listeleme İşlemi

            SqlConnection connection2 = new SqlConnection("Data Source=MDAYAN\\SQLEXPRESS;initial catalog=EgitimKampiDB;integrated security=true");

            connection2.Open();

            SqlCommand command2 = new SqlCommand("select *from TblProduct", connection2);
            
            // sql den verileri çekerken listeleme sırasında köprü görevi gören komut
            SqlDataAdapter adapter = new SqlDataAdapter(command2);

            // tabloyu geçici belleğe almaya yarayan komut
            DataTable dataTable = new DataTable();

            // tablonun içini doldurma işlemi
            adapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString()+ " ");
                }
            }

            connection2.Close();





            #endregion

            #region Ürün Silme İşlemi

            Console.WriteLine("Silincek Ürün Id: ");
            int productId=int.Parse(Console.ReadLine());

            SqlConnection connection3 = new SqlConnection("Data Source=MDAYAN\\SQLEXPRESS;initial catalog=EgitimKampiDB;integrated security=true");

            connection3.Open();

            SqlCommand command3 = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection3);
            command3.Parameters.AddWithValue("@productId", productId);
            command3.ExecuteNonQuery();

            connection3.Close();

            Console.WriteLine("Silme işlemi tamamlandı!");

            #endregion

            #region Ürün Güncelleme İşlemi

            Console.WriteLine("Güncellenecek Ürün Id: ");
            int productId_1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Güncellenecek Ürün Adı: ");
            string productName_1 = Console.ReadLine();
            
            Console.WriteLine("Güncellenecek Ürün Fiyatı: ");
            decimal productPrice_1 = decimal.Parse(Console.ReadLine());
            

            
            SqlConnection connection4 = new SqlConnection("Data Source=MDAYAN\\SQLEXPRESS;initial catalog=EgitimKampiDB;integrated security=true");

            connection4.Open();

            SqlCommand command4 = new SqlCommand("Update TblProduct Set ProductName=@productName_1,ProductPrice=@productPrice_1,ProductId=@productId_1");

            command4.Parameters.AddWithValue("@productName", productName_1);
            command4.Parameters.AddWithValue("@productPrice", productPrice_1);
            command4.Parameters.AddWithValue("@productId", productId_1);

            command4.ExecuteNonQuery();

            connection4.Close();

            Console.WriteLine("Güncelleme Başarılı");

            #endregion
        }
    }
}
