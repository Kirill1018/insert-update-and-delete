using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_and_update_and_delete
{
    internal class Program
    {
        static void Main(string[] args) => new Program().Code();
        public void Code()
        {
            string sql = "insert into artists(author)" + "values('beyonce'), ('the rasmus'), (N'анита цой')", sql_ = "delete from artists where id=3";
            IDbConnection idc = new SqlConnection(@"Data Source=(localdb)\.;Integrated Security=True");
            idc.Open();
            IDbCommand command = idc.CreateCommand();
            command.CommandText = sql;
            IDataReader idr = command.ExecuteReader(), idr_;
            while (idr.Read()) Console.WriteLine(idr.GetString(0));
            idr.Close();
            command.CommandText = sql_;
            idr_ = command.ExecuteReader();
            while (idr_.Read()) Console.WriteLine(idr_.GetString(0));
            idr_.Close();
        }
}