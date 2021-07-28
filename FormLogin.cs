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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string pwd = txtPwd.Text;
            if(name.Equals("")||pwd.Equals(""))
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            else
            {
                //查找用户数据

                string sql = "select * from users where UserName =@username";                
                SqlParameter p = new SqlParameter("@username", txtName.Text);
                DataTable dt = new DataTable();
                dt = DBHelper.ExecuteQuery(sql, p);
          
                if (dt.Rows.Count>0)
                {
                    Register register = new Register();
                    register.UserName = dt.Rows[0][1].ToString();
                    register.Password = dt.Rows[0][2].ToString();
                    // register.Password2 = dt.Rows[0][3].ToString();
                    //register.Juese = dt.Rows[0][4].ToString();
                   
                    
                    if(txtPwd.Text==register.Password)
                    {
                        MessageBox.Show("登录成功！");
                        FormMain main = new FormMain();
                        main.Tag = register;
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("密码错误！");
                        txtPwd.Text = "";
                      
                    }
                   
                   
                }
                else
                {
                    MessageBox.Show("用户名错误！");
                    txtName.Text = "";
                }
            
             
            }
           

        }

        private void linkLabel_Regist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
