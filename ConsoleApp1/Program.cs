using System;
using System.Collections.Generic;
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
            track.Num = int.Parse(Console.ReadLine());

            inv.InsertData(crew);
            inv.InsertData(track);

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
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 100;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@City";
                    param.Value = c.City;
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 30;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@Car";
                    param.Value = c.Car;
                    param.SqlDbType = SqlDbType.VarChar;
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
            using (SqlConnection con = new SqlConnection(
            ConsoleApp1.Properties.Settings.Default.Database1ConnectionString))
            {
                con.Open();
                // Оператор SQL
                string sql = string.Format("INSERT INTO [Race]" +
                "([Id], [Title], [DateBegin], [DateEnd], [PointRate], [CountST], [PenaltyLate]," +
                "[PenaltyHold], [PenaltyKP], [PenaltyKS])" +
                "Values(@Id,@Title,@DateBegin,@DateEnd,@PointRate,@CountST,@PenaltyLate," +
                "@PenaltyHold,@PenaltyKP,@PenaltyKS)");
                // Параметризованная команд
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@Id";
                    param.Value = r.Id;
                    param.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@Title";
                    param.Value = r.Title;
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 50;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@DateBegin";
                    param.Value = r.DateBegin;
                    param.SqlDbType = SqlDbType.DateTime;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@DateEnd";
                    param.Value = r.DateEnd;
                    param.SqlDbType = SqlDbType.DateTime;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@PointRate";
                    param.Value = r.PointRate;
                    param.SqlDbType = SqlDbType.Float;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@CountST";
                    param.Value = r.CountST;
                    param.SqlDbType = SqlDbType.Int;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@PenaltyLate";
                    param.Value = r.PenaltyToLate;
                    param.SqlDbType = SqlDbType.Int;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@PenaltyHold";
                    param.Value = r.PenaltyToHold;
                    param.SqlDbType = SqlDbType.Int;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@PenaltyKP";
                    param.Value = r.PenaltyKP;
                    param.SqlDbType = SqlDbType.Int;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@PenaltyKS";
                    param.Value = r.PenaltyKS;
                    param.SqlDbType = SqlDbType.Int;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void InsertData(Track s)
        {
            using (SqlConnection con = new SqlConnection(
            ConsoleApp1.Properties.Settings.Default.Database1ConnectionString))
            {
                con.Open();
                // Оператор SQL
                string sql = string.Format("INSERT INTO [Track]" +
                "([Num], [CountKP], [CountKPpass], [PenaltyTimeKP], [CountKS], [CountKSpass]," +
                "[PenaltyTimeKS], [ArrivePlan], [ArriveFact], [PenaltyTimeLate], [StartPlan]," +
                "[StartFact], [PenaltyTimeHold], [TimeFinish], [TimePass], [PenaltyTimeAll]," +
                "[TimeFinally])" +
                "Values(@Num,@CountKP,@CountKPpass,@PenaltyTimeKP,@CountKS,@CountKSpass," +
                "@PenaltyTimeKS,@ArrivePlan,@ArriveFact,@PenaltyTimeLate,@StartPlan," +
                "@StartFact,PenaltyTimeHold,@TimeFinish,@TimePass,@PenaltyTimeAll,@TimeFinally)");
                // Параметризованная команда
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@Num";
                    param.Value = s.Num;
                    param.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@CountKP";
                    param.Value = s.CountKP;
                    param.SqlDbType = SqlDbType.Int;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@CountKPpass";
                    param.Value = s.CountKPpass;
                    param.SqlDbType = SqlDbType.Int;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@PenaltyTimeKP";
                    param.Value = s.PenaltyTimeKP;
                    param.SqlDbType = SqlDbType.DateTime;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@CountKS";
                    param.Value = s.CountKS;
                    param.SqlDbType = SqlDbType.Int;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@CountKSpass";
                    param.Value = s.CountKSpass;
                    param.SqlDbType = SqlDbType.Int;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@PenaltyTimeKS";
                    param.Value = s.PenaltyTimeKS;
                    param.SqlDbType = SqlDbType.DateTime;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@ArrivePlan";
                    param.Value = s.ArrivePlan;
                    param.SqlDbType = SqlDbType.DateTime;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@ArriveFact";
                    param.Value = s.ArriveFact;
                    param.SqlDbType = SqlDbType.DateTime;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@PenaltyTimeLate";
                    param.Value = s.PenaltyTimeLate;
                    param.SqlDbType = SqlDbType.DateTime;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@StartPlan";
                    param.Value = s.StartPlan;
                    param.SqlDbType = SqlDbType.DateTime;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@StartFact";
                    param.Value = s.StartFact;
                    param.SqlDbType = SqlDbType.DateTime;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@PenaltyTimeHold";
                    param.Value = s.PenaltyTimeHold;
                    param.SqlDbType = SqlDbType.DateTime;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@TimeFinish";
                    param.Value = s.TimeFinish;
                    param.SqlDbType = SqlDbType.DateTime;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@TimePass";
                    param.Value = s.TimeToPass;
                    param.SqlDbType = SqlDbType.DateTime;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@PenaltyTimeAll";
                    param.Value = s.PenaltyTimeAll;
                    param.SqlDbType = SqlDbType.DateTime;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@TimeFinally";
                    param.Value = s.TimeFinally;
                    param.SqlDbType = SqlDbType.DateTime;
                    param.Size = 10;
                    cmd.Parameters.Add(param);

                    cmd.ExecuteNonQuery();
            }
        }

    }

        public void SelectData()
        {

        }

        public void ChangeData()
        {

        }

        public void DeleteData()
        {

        }

        IList<IEnumerable<object>> a;
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
        public int      Num;               // стартовый номер экипажа
        public int      CountKP;           // количество КП
        public int      CountKPpass;       // количество пройденных КП
        public DateTime PenaltyTimeKP;     // штрафное время за непройденные КП
        public int      CountKS;           // количество КС
        public int      CountKSpass;       // количество пройденных КС
        public DateTime PenaltyTimeKS;     // штрафное время за непройденные КС
        public DateTime ArrivePlan;        // время прибытия на старт плановое
        public DateTime ArriveFact;        // время прибытия на старт фактическое
        public DateTime PenaltyTimeLate;   // штрафное время за опоздание на старт
        public DateTime StartPlan;         // время старта плановое
        public DateTime StartFact;         // время старта фактическое
        public DateTime PenaltyTimeHold;   // штрафное время за задержку старта
        public DateTime TimeFinish;        // время финиша
        public DateTime TimeToPass;        // время, потраченное на спецучасток
        public DateTime PenaltyTimeAll;    // сумма штрафов
        public DateTime TimeFinally;       // итоговое время с учетом штрафов
    }

    struct Race
    {
        public int      Id;            // идентификатор гонки
        public string   Title;         // наименование гонки
        public DateTime DateBegin;     // дата начала
        public DateTime DateEnd;       // дата конца
        public double PointRate;     // коэффициент очков
        public int CountST;       // количество спец участков
        public int PenaltyToLate; // штраф за опоздание
        public int PenaltyToHold; // штраф за задержку старта
        public int PenaltyKP;     // штраф за пропуск КП
        public int PenaltyKS;     // штраф за пропуск КС
    }
}
