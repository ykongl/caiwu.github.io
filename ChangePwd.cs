using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 财务管理
{
    public partial class ChangePwd : Form
    {
        public ChangePwd()
        {
            InitializeComponent();
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            string sql = "select * from users where UserName =@username";
            SqlParameter p = new SqlParameter("@username", txtUser.Text);
            DataTable dt = new DataTable();
            dt = DBHelper.ExecuteQuery(sql, p);
            Register register = new Register();
            register.UserName = dt.Rows[0][1].ToString();
            register.Password = dt.Rows[0][2].ToString();
            
                if(register.Password==txtPwd.Text)
                {
                    SqlParameter[] ps =
                    {
                    new SqlParameter("@user",txtUser.Text),
                    new SqlParameter("@pwd",txtPwd.Text),
                    new SqlParameter("@npwd",txtNewPwd.Text),
                    };

                    string sql2 = "update users set Password=@npwd where UserName=@user";
                    int res = DBHelper.ExecuteNonQuery(sql2, ps);

                    if (res > 0)
                    {
                        
                        MessageBox.Show("修改成功,请重新登录！");
                        FormLogin login = new FormLogin();
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                    }
                }
                else
                {
                    MessageBox.Show("原密码填写错误");
                }
            
           
            

            txtUser.Text = "";
            txtPwd.Text = "";
            txtNewPwd.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            main.Show();
            this.Hide();
        }
    }
}
