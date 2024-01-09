using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Models.Entities;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BaseNetCoreApi.Helper
{
    public static class SqlHelper
    {
        public static string getConnectString(string server, string schema, string user, string pass)
        {
            return string.Format(@"Data Source={0};Initial Catalog={1};User ID={2};Password={3}; Max Pool Size=20000;Connection Timeout=13000", server, schema, user, pass);
        }
        public static DataTable getDB(string strQuery, string strCon)
        {
            var m_table = new DataTable();
            try
            {
                var m_Conn1 = new SqlConnection(strCon);
                var m_Cmd = new SqlCommand();
                var m_DataSet = new DataSet();
                m_Cmd.Connection = m_Conn1;
                m_Cmd.CommandType = CommandType.Text;
                m_Cmd.CommandText = strQuery;
                m_Conn1.Open();
                m_Cmd.CommandTimeout = 999999;
                var data = new SqlDataAdapter(m_Cmd);
                m_DataSet.Clear();
                data.Fill(m_DataSet);
                m_table = m_DataSet.Tables[0];
                m_Conn1.Close();
            }
            catch
            {
            }
            return m_table;
        }
        public static DataTable getdbByParame(string strQuery, List<SqlParameter> lst, string strCon)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(strCon))
            using (SqlCommand cmd = new SqlCommand(strQuery, con))
            {
                con.Open();
                cmd.CommandTimeout = 999999;
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(lst.ToArray());
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                    dt = ds.Tables[0];
                    return dt;
                }
            }
        }
        public static DataTable getdbByParame(string strQuery, List<SqlParameter> lst, string strCon, CommandType commandType)
        {
            DataTable dt = new DataTable();
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection con = new SqlConnection(strCon))
                using (SqlCommand cmd = new SqlCommand(strQuery, con))
                {
                    con.Open();
                    cmd.CommandTimeout = 999999;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddRange(lst.ToArray());

                    cmd.CommandType = commandType;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                        dt = ds.Tables[0];
                        return dt;
                    }
                }
            }
            catch
            {
            }
            return dt;
        }
        public static bool runDB(string strQuery, List<SqlParameter> lst, string strCon)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            using (SqlCommand cmd = new SqlCommand(strQuery, con))
            {
                con.Open();
                cmd.CommandTimeout = 999999;
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(lst.ToArray());
                cmd.ExecuteNonQuery();
            }
            return true;

        }
        public static bool runDB(string strQuery, string strCon)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            using (SqlCommand cmd = new SqlCommand(strQuery, con))
            {
                con.Open();
                cmd.CommandTimeout = 999999;
                cmd.Parameters.Clear();
                cmd.ExecuteNonQuery();
            }
            return true;

        }
        public static List<DanhMucEntity> getDanhMuc(string strCon, string tableName, string columnGet, string columnCheck, string columnwhere, string valuewhere)
        {
            List<DanhMucEntity> data = new List<DanhMucEntity>();
            var QICache = new QiCache();
            string strKeyCache = QICache.BuildCachedKey("SqlHelper", "getDanhMuc", AuthHelper.EncryptString(strCon, ConfigurationHelper.CookieSecret), tableName, columnGet, columnCheck);
            if (!QICache.IsSet(strKeyCache))
            {
                DataTable dt = new DataTable();
                string strQuery = string.Format(@"select {0} as MA, {1} as VALUE  from {2} where 1=1 {3} {4}", columnGet, columnCheck, tableName
                                                 , !string.IsNullOrEmpty(columnwhere) && !string.IsNullOrEmpty(valuewhere) ? " and " + columnwhere + "='" + valuewhere + "'" : ""
                                                 , !string.IsNullOrEmpty(columnwhere) && string.IsNullOrEmpty(valuewhere) ? " and ( " + columnwhere + " )" : "");
                dt = getDB(strQuery, strCon);
                foreach (DataRow row in dt.Rows)
                {
                    try
                    {
                        DanhMucEntity item = new DanhMucEntity();
                        try { item.Value = row["MA"].ToString(); } catch { }
                        try { item.Text = row["VALUE"].ToString(); } catch { }
                        data.Add(item);
                    }
                    catch { }
                }
                QICache.Set(strKeyCache, data, 300000);
            }
            else
            {
                try
                {
                    data = QICache.Get(strKeyCache) as List<DanhMucEntity>;
                }
                catch
                {
                    QICache.Invalidate(strKeyCache);
                }
            }
            return data;

        }
    }
}
