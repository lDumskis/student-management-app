using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ManagementBook
{
    class STUDENT
    {
        MY_DB db = new MY_DB();

        // prideti nauja studenta
        public bool insertStudent(string vardas, string pavarde, DateTime gimtadienis, string telefonas, string lytis, string adresas, MemoryStream nuotrauka)
        {
            SqlCommand query = new SqlCommand("INSERT INTO Studentai (vardas, pavarde, gimtadienis, lytis, telefonas, adresas, nuotrauka) VALUES (@vardas, @pavarde, @gimtadienis, @lytis, @telefonas, @adresas, @nuotrauka)", db.getConnection);

            query.Parameters.AddWithValue("@vardas", vardas);
            query.Parameters.AddWithValue("@pavarde", pavarde);
            query.Parameters.AddWithValue("@gimtadienis", gimtadienis);
            query.Parameters.AddWithValue("@lytis", lytis);
            query.Parameters.AddWithValue("@telefonas", telefonas);
            query.Parameters.AddWithValue("@adresas", adresas);
            query.Parameters.AddWithValue("@nuotrauka", nuotrauka.ToArray());

            db.openConnection();

            if(query.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public DataTable getStudents(SqlCommand query)
        {
            query.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(query);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }


        // pakeisti studento informacija 
        public bool updateStudent(int id, string vardas, string pavarde, DateTime gimtadienis, string telefonas, string lytis, string adresas, MemoryStream nuotrauka)
        {
            SqlCommand query = new SqlCommand("UPDATE Studentai SET vardas=@vardas, pavarde=@pavarde, gimtadienis=@gimtadienis, lytis=@lytis, telefonas=@telefonas, adresas=@adresas, nuotrauka=@nuotrauka WHERE id=@id", db.getConnection);

            query.Parameters.AddWithValue("@id", id);
            query.Parameters.AddWithValue("@vardas", vardas);
            query.Parameters.AddWithValue("@pavarde", pavarde);
            query.Parameters.AddWithValue("@gimtadienis", gimtadienis);
            query.Parameters.AddWithValue("@lytis", lytis);
            query.Parameters.AddWithValue("@telefonas", telefonas);
            query.Parameters.AddWithValue("@adresas", adresas);
            query.Parameters.AddWithValue("@nuotrauka", nuotrauka.ToArray());

            db.openConnection();

            if (query.ExecuteNonQuery() == 0)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        // istrinti studenta
        public bool deleteStudent(int id)
        {
            SqlCommand query = new SqlCommand("DELETE FROM Studentai WHERE id=@id", db.getConnection);

            query.Parameters.AddWithValue("@id", id);

            db.openConnection();

            if (query.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        // funkcija apskaiciuoti uzklausas
        public string execCount(string command)
        {
            SqlCommand query = new SqlCommand(command, db.getConnection);
            db.openConnection();
            string count = query.ExecuteScalar().ToString();
            db.closeConnection();

            return count;
        }

        // visu studentu skaicius
        public string totalStudent()
        {
            return execCount("SELECT COUNT(*) FROM Studentai");
        }

        // visu vyru studentu skaicius
        public string totalVyruStudent()
        {
            return execCount("SELECT COUNT(*) FROM Studentai WHERE lytis = 'Vyras'");
        }

        // visu moteru studentu skaicius
        public string totalMoteruStudent()
        {
            return execCount("SELECT COUNT(*) FROM Studentai WHERE lytis = 'Moteris'");
        }


    }
}
