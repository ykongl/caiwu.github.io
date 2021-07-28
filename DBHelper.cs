using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace 财务管理
{
    class DBHelper
    {
        
        private static SqlCommand cmd = null;
        //private static SqlDataReader sdr = null;
        private static string connstring = "Data Source=DESKTOP-KA0EUTK;Initial Catalog = Finance; Integrated Security = True";
        private static SqlConnection conn = new SqlConnection(connstring);



        /// <summary>
        /// 执行增删改sql语句,返回受影响的行数
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="ps">sql语句携带的参数，参数数组</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, SqlParameter[] ps)
        {
            int res = 0;
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(ps);
            try
            {
                conn.Open();
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return res;
        }

        public static int ExecuteNonQuery(string sql, SqlParameter param)
        {
            int res = 0;
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(param);
            try
            {
                conn.Open();
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return res;
        }

        /// <summary>
        /// 执行查询语句，返回第一行第一列的值
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql)
        {
            object res = null;
            cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                //cmd.Parameters.Add(p);
                res = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return res;
        }

        /// <summary>
        /// 执行带参数查询语句，返回第一行第一列的值
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, SqlParameter p)
        {
            object res = null;
            cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.Add(p);
                res = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return res;
        }

        /// <summary>
        /// 执行不带参数的查询sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable ExecuteQuery(string sql)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        /// <summary>
        /// 执行带一个参数的查询语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static DataTable ExecuteQuery(string sql, SqlParameter param)
        {
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(param);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        /// <summary>
        /// 执行带多个参数的查询语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static DataTable ExecuteQuery(string sql, SqlParameter[] ps)
        {
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(ps);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}

