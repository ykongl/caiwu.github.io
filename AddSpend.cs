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
    public partial class AddSpend : Form
    {
        public AddSpend()
        {
            InitializeComponent();
        }

        private void AddSpend_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlParameter[] ps =
           {

                new SqlParameter("@name",txtName.Text),
                new SqlParameter("@num",Convert.ToInt32(txtNum.Text)),
                new SqlParameter("@dep",txtDep.Text),
                new SqlParameter("@receive",txtreceive.Text),
                new SqlParameter("@add",txtAdd.Text),
                new SqlParameter("@date",txtDate.Value.Date)
             };
            if (txtName.ReadOnly == false)
            {
                string sql = "insert into Spend values(@name,@num,@dep,@receive,@add,@date,0)";

                int res = DBHelper.ExecuteNonQuery(sql, ps);
                if (res > 0)
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            txtName.ReadOnly = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            main.Show();
            this.Hide();
        }
    }
}
