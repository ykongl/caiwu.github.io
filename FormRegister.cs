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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void Regist_Click(object sender, EventArgs e)
        {
            SqlParameter[] ps =
             {
                new SqlParameter("@username",Newuser.Text),
                new SqlParameter("@password",Newpwd.Text),
                new SqlParameter("@password2",Newpwd2.Text),
                new SqlParameter("@juese",txtJuese.Text)
                };
            if(Newuser.Text=="")
            {
                MessageBox.Show("请输入用户名");
            }
            else
            {
                if(Newpwd.Text=="")
                {
                    MessageBox.Show("请输入密码");
                }
                else
                {
                    if(Newpwd.Text != Newpwd2.Text)
                    {
                        MessageBox.Show("请确认重复密码");
                    }
                    else
                    {
                        if (Newuser.ReadOnly == false)
                        {
                            //添加
                            string sql = "insert into users values(@username,@password,@juese)";

                            int res = DBHelper.ExecuteNonQuery(sql, ps);
                            if (res > 0)
                            {
                                MessageBox.Show("注册成功");
                            }
                            else
                            {
                                MessageBox.Show("注册失败");
                            }

                        }
                        else
                        {

                        }
                        Newuser.ReadOnly = false;

                    }
                }
            }
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
