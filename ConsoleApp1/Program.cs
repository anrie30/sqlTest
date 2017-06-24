using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryDAL inv = new InventoryDAL();

            int id = 1;
            string name = "Dima";
            string city = "Ulyanovsk";

            //inv.InsertData(id, name, city);

            int t = 0;
            Crew crew;
            Track track;
            Race race;

//            crew.Num = 100;
            crew.Drivers = "Bobrov Qwerty";
            crew.City = "Moscow";
            crew.Car = "Lada";
            crew.Class = "moto";
            crew.Group = "gr";

            crew.Num = int.Parse(Console.ReadLine());

            inv.InsertData(crew);
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }

    class InventoryDAL
    {
        public void CreateTable(string title, int type)
        {
            if (type == 0)
            {
/*                using (SqlConnection con = new SqlConnection(
                ConsoleApp1.Properties.Settings.Default.Database1ConnectionString))
                {
                    con.Open();
                    // Оператор SQL
                    string sql = string.Format("CREATE TABLE [dbo].[Table] ( " +
                        "[Id]   INT          NOT NULL," +
                        "[Name] VARCHAR (50) NULL," +
                        "[City] VARCHAR (50) NULL," +
                        "PRIMARY KEY CLUSTERED ([Id] ASC)");
                }*/
            }
            else if (type == 1)
            {

            }
            else
            {

            }
        }

        public void InsertData(Crew c)
        {
            using (SqlConnection con = new SqlConnection(
            ConsoleApp1.Properties.Settings.Default.Database1ConnectionString))
            {
                con.Open();
                // Оператор SQL
                string sql = string.Format("INSERT INTO [Table]" +
                "([Num], [Name], [City], [Car], [Class], [Group])" +
                "Values(@Num,@Name,@City,@Car,@Class,@Group)");
                // Параметризованная команда
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@Num";
                    param.Value = c.Num;
                    param.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@Name";
                    param.Value = c.Drivers;
                    param.SqlDbType = SqlDbType.Char;
                    param.Size = 100;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@City";
                    param.Value = c.City;
                    param.SqlDbType = SqlDbType.Char;
                    param.Size = 30;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@Car";
                    param.Value = c.Car;
                    param.SqlDbType = SqlDbType.Char;
                    param.Size = 20;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@Class";
                    param.Value = c.Class;
                    param.SqlDbType = SqlDbType.Char;
                    param.Size = 8;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@Group";
                    param.Value = c.Group;
                    param.SqlDbType = SqlDbType.Char;
                    param.Size = 5;
                    cmd.Parameters.Add(param);

                    cmd.ExecuteNonQuery();
                }

            }
        }

        public void InsertData(Race r)
        {

        }

        public void InsertData(Track s)
        {
/*            using (SqlConnection con = new SqlConnection(
            ConsoleApp1.Properties.Settings.Default.Database1ConnectionString))
            {
                con.Open();
                // Оператор SQL
                string sql = string.Format("INSERT INTO [Table]" +
                "([Num], [Name], [City], [Car], [Class], [Group])" +
                "Values(@Num,@Name,@City,@Car,@Class,@Group)");
                // Параметризованная команда
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@Num";
                    param.Value = c.Num;
                    param.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@Name";
                    param.Value = c.Drivers;
                    param.SqlDbType = SqlDbType.Char;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@City";
                    param.Value = c.City;
                    param.SqlDbType = SqlDbType.Char;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@Car";
                    param.Value = c.Car;
                    param.SqlDbType = SqlDbType.Char;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@Class";
                    param.Value = c.Class;
                    param.SqlDbType = SqlDbType.Char;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@Group";
                    param.Value = c.Group;
                    param.SqlDbType = SqlDbType.Char;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    cmd.ExecuteNonQuery();
                }

            }
*/        }

        /*        public void InsertData(int id, string name, string city)
                {
                    using (SqlConnection con = new SqlConnection(
                    ConsoleApp1.Properties.Settings.Default.Database1ConnectionString))
                    {
                        con.Open();
                        // Оператор SQL
                        string sql = string.Format("INSERT INTO [Table]" +
                        "([Id], [Name], [City]) Values(@Id,@Name,@City)");

                        // Параметризованная команда
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            SqlParameter param = new SqlParameter();
                            param.ParameterName = "@ID";
                            param.Value = id;
                            param.SqlDbType = SqlDbType.Int;
                            cmd.Parameters.Add(param);

                            param = new SqlParameter();
                            param.ParameterName = "@Name";
                            param.Value = name;
                            param.SqlDbType = SqlDbType.Char;
                            param.Size = 10;
                            cmd.Parameters.Add(param);

                            param = new SqlParameter();
                            param.ParameterName = "@City";
                            param.Value = city;
                            param.SqlDbType = SqlDbType.Char;
                            param.Size = 10;
                            cmd.Parameters.Add(param);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
        */
        public void SelectData()
        {

        }

        public void ChangeData()
        {

        }

        public void DeleteData()
        {

        }
    }

    struct Crew
    {
        public int    Num;     // стартовый номер
        public string Drivers; // водители
        public string City;    // город
        public string Car;     // авто
        public string Group;   // зачетная группа
        public string Class;   // класс
    }

    struct Track
    {
        public int      num;               // стартовый номер экипажа
        public int      countKP;           // количество КП
        public int      countKPpass;       // количество пройденных КП
        public DateTime penaltyTimeKP;     // штрафное время за непройденные КП
        public int      countKS;           // количество КС
        public int      countKSpass;       // количество пройденных КС
        public DateTime penaltyTimeKS;     // штрафное время за непройденные КС
        public DateTime arrivePlan;        // время прибытия на старт плановое
        public DateTime arriveFact;        // время прибытия на старт фактическое
        public DateTime penaltyTimeToLate; // штрафное время за опоздание на старт
        public DateTime startPlan;         // время старта плановое
        public DateTime startFact;         // время старта фактическое
        public DateTime penaltyTimeToHold; // штрафное время за задержку старта
        public DateTime timeFinish;        // время финиша
        public DateTime timeToPass;        // время, потраченное на спецучасток
        public DateTime penaltyTimeAll;    // сумма штрафов
        public DateTime timeFinally;       // итоговое время с учетом штрафов
    }

    struct Race
    {
        int      id;            // идентификатор гонки
        string   title;         // наименование гонки
        DateTime dateBegin;     // дата начала
        DateTime dateEnd;       // дата конца
        double   pointRate;     // коэффициент очков
        int      countST;       // количество спец участков
        int      penaltyToLate; // штраф за опоздание
        int      penaltyToHold; // штраф за задержку старта
        int      penaltyKP;     // штраф за пропуск КП
        int      penaltyKS;     // штраф за пропуск КС
    }
}
