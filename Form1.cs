using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using System.Data.Common;

//Работу выполнили Волков и Кочаров

namespace TRBD_LR_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            //строка подключения:

            SqlConnection connection = GetDBConnection();
            try
            {
                connection.Open();
                //DropTable(connection);
                //CreateTable(connection);
                FillTable(connection);
               // SelectFromTable(connection, "");

            }
            finally
            {
                connection.Close();
            }
        }

        public static SqlConnection GetDBConnection()
        {
            string connnectionInfo = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connnectionInfo);
            return connection;
        }
        private void DropTable(SqlConnection connection)
        {
            string sql = "DROP TABLE workshop";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        private void CreateTable(SqlConnection connection)
        {
            string sql = "CREATE TABLE workshop(" + "ContractNumber INT PRIMARY KEY ," +
                "CarBrand NVARCHAR(100)," + "CarModel NVARCHAR(100)," + "Name NVARCHAR(100)," +
                "SurName NVARCHAR(100)," + "OrderData DATE," + "ExecutionData DATE" + ")";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        private void FillTable(SqlConnection connection)
        {

            Random rnd = new Random();
            string CarBrand, CarModel, Name, SurName, OrderData, ExecutionData;
            int ContractNumber;

            string[] CarBrands = { "Lada", "Toyota", "Chevrolet", "Nissan", "Ford" };
            string[,] Models = { { "Granta", "Vesta" },
                                 { "Rav_4", "Mark_2" },
                                 { "Camaro", "Corvette" },
                                 { "GTR_R34", "Qashqai" },
                                 { "Focus", "Mustang" } };
            //считавание файлов с фамилиями и именами

            string filename = "C:/Users/ThinkBook/source/repos/TRBD_LR_4/Names.txt";
            string filename2 = "C:/Users/ThinkBook/source/repos/TRBD_LR_4/Surnames.txt";

            //string[,] Names = new string[51529, 3];
            //string[,] SurNames = new string[318474, 3];
            List<string[]> Names = new List<string[]>();
            List<string[]> SurNames = new List<string[]>();
            // читаем файл в строку
            try
            {
                string fileText = System.IO.File.ReadAllText(filename);
                using (StreamReader sr = new StreamReader(filename, Encoding.Default))
                {
                    string[] headers = sr.ReadLine().Split(';');//чтобы не брать во внимание заголовок
                    int k = 0;
                    while (!sr.EndOfStream)
                    {
                        string[] temp = sr.ReadLine().Split(';');
                        Names.Add(temp);
                        k++;
                    }
                    sr.Close();
                }
                fileText = System.IO.File.ReadAllText(filename2);
                using (StreamReader sr = new StreamReader(filename2, Encoding.Default))
                {
                    string[] headers = sr.ReadLine().Split(';');//чтобы не брать во внимание заголовок
                    int k = 0;
                    while (!sr.EndOfStream)
                    {
                        string[] temp = sr.ReadLine().Split(';');
                        SurNames.Add(temp);
                        k++;
                    }
                    sr.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DateTime curDate = DateTime.Now;
            curDate += new TimeSpan(-10, 0, 0, 0);

            for (int i = 1; i <= 10; i++)
            {
                ContractNumber = i;
                int brand = rnd.Next(0, 5); CarBrand = CarBrands[brand];
                CarModel = Models[brand, rnd.Next(0, 2)];

                int nameRand = rnd.Next(0, 51529);//второе число - номер последней строки файла с именами
                Name = Names[nameRand][1];
                int surnameRand = rnd.Next(0, 318474);
                SurName = SurNames[surnameRand][1];
                bool ReCreate = true;
                while (ReCreate)
                { //чтобы имена и фамилии совпадали по полу
                    if (Names[nameRand][2] == SurNames[surnameRand][2] || Names[nameRand][2] == "МЖ" || SurNames[surnameRand][2] == "МЖ")
                    {
                        SurName = SurNames[surnameRand][1];
                        ReCreate = false;
                    }
                    else surnameRand = rnd.Next(0, 318474);
                }

                int day = rnd.Next(0, 30);
                OrderData = curDate.ToString("yyyy-MM-dd");
                curDate += new TimeSpan(day, 0, 0, 0);
                ExecutionData = curDate.ToString("yyyy-MM-dd");


                string sql = "Insert into workshop" +
                    "( CarBrand, CarModel, Name, SurName, OrderData, ExecutionData) " +
                    $"VALUES (N'{CarBrand}', N'{CarModel}', N'{Name}', N'{SurName}', N'{OrderData}', N'{ExecutionData}')";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
        }

        private void SelectFromTable(SqlConnection connection, string question)
        {
            dataGridView1.AutoGenerateColumns = true;
            string sql = "SELECT * FROM workshop " + question; // ORDER BY ContractNumber
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = sql;
            List<string[]> data = new List<string[]>();
            SqlDataReader reader = cmd.ExecuteReader();

            DataGridViewTextBoxColumn[] column = new DataGridViewTextBoxColumn[7];
            string[] header = { "ContractNumber", "CarBrand", "CarModel", "Name", "SurName", "OrderData", "ExecutionData" };

            while (reader.Read())
            {
                data.Add(new string[7]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = ((DateTime)reader[5]).ToShortDateString();
                data[data.Count - 1][6] = ((DateTime)reader[6]).ToShortDateString();
            }
            reader.Close();
            connection.Close();
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }



        //7.1.	Оставить записи, в которых марка и модель автомобиля соответствуют указанным;
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SqlConnection connection = GetDBConnection();
            connection.Open();
            string brand = BrandText.Text, model = ModelText.Text;

            SelectFromTable(connection, "WHERE ( CarBrand = N'" + brand + "' AND CarModel = N'" + model + "')");
        }
        //7.2.	Оставить записи, в которых договор был заключён после указанной даты;
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SqlConnection connection = GetDBConnection();
            connection.Open();
            DateTime Date = dateTimePicker1.Value;
            SelectFromTable(connection, "WHERE OrderData >= N'" + Date.ToString("yyyy-MM-dd") + "'");
        }
        //7.3.	Оставить записи, в которых автомобиль ещё находится на этапе ремонта.
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SqlConnection connection = GetDBConnection();
            connection.Open();
            string curDate = DateTime.Now.ToString("yyyy-MM-dd");
            SelectFromTable(connection, "WHERE ExecutionData > N'" + curDate + "'");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
