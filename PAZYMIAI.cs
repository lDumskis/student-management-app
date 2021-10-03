using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ManagementBook
{
    class PAZYMIAI
    {
        MY_DB mydb = new MY_DB();

        public bool pridetiPazymi(int studentoid, int kursoid, double pazymioSkc, string aprasymas)
        {
            SqlCommand query = new SqlCommand("INSERT INTO pazymiai (studentoId, kursoid, pazymys, aprasymas) VALUES (@sid, @kid, @paz, @apra)",mydb.getConnection);

            query.Parameters.AddWithValue("@sid", studentoid);
            query.Parameters.AddWithValue("@kid", kursoid);
            query.Parameters.AddWithValue("@paz", pazymioSkc);
            query.Parameters.AddWithValue("@apra", aprasymas);

            mydb.openConnection();

            if(query.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool studentScoreExists(int studentoid, int kursoid)
        {
            SqlCommand query = new SqlCommand("SELECT * FROM pazymiai WHERE studentoid=@sid AND kursoid=@kid", mydb.getConnection);

            query.Parameters.AddWithValue("@sid", studentoid);
            query.Parameters.AddWithValue("@kid", kursoid);

            SqlDataAdapter adapter = new SqlDataAdapter(query);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public DataTable getStudentsScore()
        {
            SqlCommand query = new SqlCommand();
            query.Connection = mydb.getConnection;
                
               query.CommandText = ("SELECT pazymiai.studentoId, Studentai.vardas, Studentai.pavarde, pazymiai.kursoid, kursas.pavadinimas, pazymiai.pazymys FROM Studentai INNER JOIN pazymiai ON Studentai.Id = pazymiai.studentoId INNER JOIN kursas ON pazymiai.kursoid = kursas.Id");

            SqlDataAdapter adapter = new SqlDataAdapter(query);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public bool deletePazimys(int studentoId, int kursoid)
        {
            SqlCommand query = new SqlCommand("DELETE FROM pazymiai WHERE studentoId = @sid AND kursoid = @kursid", mydb.getConnection);

            query.Parameters.AddWithValue("@sid", studentoId);
            query.Parameters.AddWithValue("@kursid", kursoid);

            mydb.openConnection();

            if (query.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public DataTable avgScoreByCourse()
        {
            SqlCommand query = new SqlCommand();
            query.Connection = mydb.getConnection;

            query.CommandText = ("SELECT kursas.pavadinimas, avg(pazymiai.pazymys) AS 'Pažymių vidurkis' FROM kursas, pazymiai WHERE kursas.Id = pazymiai.kursoid GROUP BY kursas.pavadinimas");

            SqlDataAdapter adapter = new SqlDataAdapter(query);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

    }
}
