using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ManagementBook
{
    class KURSAS
    {
        MY_DB mydb = new MY_DB();

        public bool insertCourse(string pavadinimas, int valandos, string aprasymas)
        {
            SqlCommand query = new SqlCommand("INSERT INTO Kursas (pavadinimas, valandos, aprasymas) VALUES (@pavadinimas, @valandos, @aprasymas)", mydb.getConnection);

            query.Parameters.AddWithValue("@pavadinimas", pavadinimas);
            query.Parameters.AddWithValue("@valandos", valandos);
            query.Parameters.AddWithValue("@aprasymas", aprasymas);

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

        public bool tikrintiKursoPav(string pavadinimas, int courseId = 0)
        {
            SqlCommand query = new SqlCommand("SELECT * FROM kursas WHERE pavadinimas=@pavadinimas AND id!=@cid",mydb.getConnection);

            query.Parameters.AddWithValue("@cid", courseId);
            query.Parameters.AddWithValue("@pavadinimas", pavadinimas);

            SqlDataAdapter adapter = new SqlDataAdapter(query);

            DataTable table = new DataTable();

            adapter.Fill(table);


            // kursas jau egzistuoja
            if(table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }

        // istrinti kursa pagal ID
        public bool deleteKursas(int id)
        {
            SqlCommand query = new SqlCommand("DELETE FROM kursas WHERE id = @id", mydb.getConnection);
            query.Parameters.AddWithValue("@id", id);

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

        // gauti visus kursus
        public DataTable gautiVisusKursus()
        {
            SqlCommand query = new SqlCommand("SELECT * FROM kursas", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(query);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }


        // gauti kursa pagal id
        public DataTable gautiKursusId(int courseID)
        {
            SqlCommand query = new SqlCommand("SELECT * FROM kursas WHERE id =@id", mydb.getConnection);

            query.Parameters.AddWithValue("@id", courseID);

            SqlDataAdapter adapter = new SqlDataAdapter(query);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        // redaguoti pasirinkta elementa
        public bool redaguotiKursa(int courseId, string pavadinimas, int valandos, string aprasymas)
        {
            SqlCommand query = new SqlCommand("UPDATE kursas SET pavadinimas=@kursoPav, valandos=@val, aprasymas=@apra WHERE id=@kid", mydb.getConnection);

            query.Parameters.AddWithValue("@kid", courseId);
            query.Parameters.AddWithValue("@kursoPav", pavadinimas);
            query.Parameters.AddWithValue("@val", valandos);
            query.Parameters.AddWithValue("@apra", aprasymas);


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


                // funkcija apskaiciuoti uzklausas
        public string execCount(string command)
        {
            SqlCommand query = new SqlCommand(command, mydb.getConnection);
            mydb.openConnection();
            string count = query.ExecuteScalar().ToString();
            mydb.closeConnection();

            return count;
        }

        // visus kursus
        public string visiKursai()
        {
            return execCount("SELECT COUNT(*) FROM kursas");
        }


    }
}
