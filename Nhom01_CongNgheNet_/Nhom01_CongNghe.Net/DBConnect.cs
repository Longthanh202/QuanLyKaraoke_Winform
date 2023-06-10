using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom01_CongNghe.Net
{
    class DBConnect
    {
        private SqlConnection connect;
        private string StrConnect;
        private DataSet dSet;

        public DataSet DSet
        {
            get { return dSet; }
            set { dSet = value; }
        }
        public SqlConnection Connect
        {
            get { return connect; }
            set { connect = value; }
        }
        public DBConnect()
        {
            StrConnect = @"Data Source=LEVI\SQLEXPRESS ;Initial Catalog=Ql_PHONGKARAOKE;Integrated Security=True";
            Connect = new SqlConnection(StrConnect);
            DSet = new DataSet("Ql_PHONGKARAOKE");
        }

        public void OpenConnect()
        {
            if (Connect.State == ConnectionState.Closed)
                Connect.Open();
        }

        public void CloseConnect()
        {
            if (Connect.State == ConnectionState.Open)
                Connect.Close();
        }

        public void UpdateToDatabase(string query)
        {
            OpenConnect();
            SqlCommand cmd = new SqlCommand(query, Connect);
            cmd.ExecuteNonQuery();
            CloseConnect();
        }
        public int GetCount(string query)
        {
            OpenConnect();
            SqlCommand cmd = new SqlCommand(query, Connect);
            int count = (int)cmd.ExecuteScalar();
            CloseConnect();
            return count;
        }

        public SqlDataReader GetData(string query)
        {
            OpenConnect();
            SqlCommand cmd = new SqlCommand(query, Connect);
            SqlDataReader rd = cmd.ExecuteReader();
            return rd;
        }
        public DataTable ExecuteDataTable(string query)
        {
            DataTable dbtb = new DataTable();
            OpenConnect();
            SqlCommand comman = new SqlCommand(query, Connect);
            SqlDataAdapter da = new SqlDataAdapter(comman);
            da.Fill(dbtb);
            CloseConnect();
            return dbtb;
        }
        public DataSet ExecuteDataSet(string query)
        {
            DataSet dbs = new DataSet();
            OpenConnect();
            SqlCommand comman = new SqlCommand(query, Connect);
            SqlDataAdapter da = new SqlDataAdapter(comman);
            da.Fill(dbs);
            CloseConnect();
            return dbs;
        }
        public object ExecuteScalar(string query)
        {
            object data = 0;
            OpenConnect();
            SqlCommand cmd = new SqlCommand(query, Connect);
            data = cmd.ExecuteScalar();
            return data;
        }
        public SqlDataAdapter getDataAdapter(string query, string tableName)
        {
            OpenConnect();
            SqlDataAdapter ada = new SqlDataAdapter(query, Connect);
            ada.Fill(DSet, tableName);
            CloseConnect();
            return ada;
        }
        public DataTable getDataTable(string query)
        {
            OpenConnect();
            SqlDataAdapter ada = new SqlDataAdapter(query, Connect);
            ada.Fill(DSet);
            CloseConnect();
            return DSet.Tables[0];
        }
        public DataTable getDataTable(string query, string tableName)
        {
            OpenConnect();
            SqlDataAdapter ada = new SqlDataAdapter(query, Connect);
            ada.Fill(DSet, tableName);
            CloseConnect();
            return DSet.Tables[tableName];
        }
        public DataTable getDataTable(string query, string tableName, params string[] keyNames)
        {
            OpenConnect();
            SqlDataAdapter ada = new SqlDataAdapter(query, Connect);
            ada.Fill(DSet, tableName);
            int n = keyNames.Length;
            DataColumn[] pk = new DataColumn[n];
            for (int i = 0; i < n; i++)
            {
                pk[i] = DSet.Tables[tableName].Columns[keyNames[i]];
            }
            DSet.Tables[tableName].PrimaryKey = pk;
            CloseConnect();
            return DSet.Tables[tableName];
        }
        public int TimMax(string query)
        {
            OpenConnect();
            SqlCommand cmd = new SqlCommand(query, Connect);
            int max = (int)cmd.ExecuteScalar();
            CloseConnect();
            return max;
        }
    }
}
