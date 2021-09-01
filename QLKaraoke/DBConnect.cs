using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLKaraoke
{
    public class DBConnect
    {
        SqlConnection con;

        public SqlConnection Con
        {
            get { return con; }
            set { con = value; }
        }
        string strCon;
        public string StrCon
        {
            get { return strCon; }
            set { strCon = value; }
        }

        public DBConnect()
        {
            StrCon = @"Data Source=NGUYENDETHUONGV;Initial Catalog=QuanLyQuanKaraoke;Persist Security Info=True;User ID=sa;Password=sql2012";
            Con = new SqlConnection(StrCon);
        }

        public void openConnection()
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
        }

        public void closeConnection()
        {
            if (Con.State == ConnectionState.Open)
                Con.Close();
        }

        public void disposeConnection()
        {
            if (Con.State == ConnectionState.Open)
                Con.Close();
        }

        public void updateToDB(string strSQL)
        {
            openConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = strSQL;
            cmd.Connection = Con;
            cmd.ExecuteNonQuery();

            closeConnection();
        }

        public int getCount(string strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = strSQL;
            cmd.Connection = Con;
            int count = (int)cmd.ExecuteScalar();
            closeConnection();
            return count;
        }

        public bool checkForExits(string strSQL)
        {
            if (getCount(strSQL) > 0)
                return true;
            return false;
        }

        public SqlDataReader getDataReader(string strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = strSQL;
            cmd.Connection = Con;
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;

        }

        public DataTable getTable(string sql)
        {
            openConnection();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            closeConnection();
            return dt;
        }

        public string getSum(string strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = strSQL;
            cmd.Connection = Con;
            int count = (int)cmd.ExecuteScalar();
            string kq = count.ToString();
            return kq;
        }
        private DataSet dSet;
        public DataSet DSet
        {
            get { return dSet; }
            set { dSet = value; }
        }


        //public DBConnect(string dataBaseName)
        //{
        //    StrCon = @"Data Source=A202PC36\SQL2012;Initial Catalog=QLSanPham;Persist Security Info=True;User ID=sa;Password=sa2012";

        //    Con = new SqlConnection(StrCon);
        //    DSet = new DataSet(dataBaseName);
        //}
        private string strSQL;

        public string StrSQL
        {
            get { return strSQL; }
            set { strSQL = value; }
        }

        public DBConnect(string strSQL, string databaseName)
        {
            StrSQL = @strSQL;
            Con = new SqlConnection(strSQL);
            DSet = new DataSet(databaseName);
        }


        public DataTable getTable(string strSQL, string tblName)
        {
            openConnection();
            SqlDataAdapter da = new SqlDataAdapter(strSQL, Con);
            DataTable dt = new DataTable();
            da.Fill(DSet, tblName);
            closeConnection();
            return DSet.Tables[tblName];
        }


        public SqlDataAdapter getDataAdapter(string strSQL, string tblName)
        {
            openConnection();

            SqlDataAdapter da = new SqlDataAdapter(strSQL, Con);
            da.Fill(DSet, tblName);

            closeConnection();
            return da;

        }
    }
}
