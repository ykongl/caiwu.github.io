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
    public partial class FormIncome : Form
    {
        public FormIncome()
        {
            InitializeComponent();
        }
        public void LoadList()
        {

            string sql = "select * from Income";
            DataTable dt = new DataTable();
            dt = DBHelper.ExecuteQuery(sql);
            dgvList.AutoGenerateColumns = false;
            dgvList.DataSource = dt;
        }

        private void FormIncome_Load(object sender, EventArgs e)
        {
            LoadList();
        }

      

        private void btnchange_Click(object sender, EventArgs e)
        {
            SqlParameter[] ps =
             {
                new SqlParameter("@id",txtId.Text),
                new SqlParameter("@name",txtName2.Text),
                new SqlParameter("@num",Convert.ToInt32(txtNum.Text)),
                new SqlParameter("@source",txtSource.Text),
                new SqlParameter("@date",txtDate.Value.Date)
             };
            string sql = "update Income set Name=@name,IncomeNum=@num,IncomeSource=@source,IncomeDate=@date where Id=@id";
            int res = DBHelper.ExecuteNonQuery(sql, ps);
            if (res > 0)
            {
                MessageBox.Show("修改成功");
                LoadList();
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            main.Show();
            this.Hide();
        }

        private void btndel_Click(object sender, EventArgs e)
        {

            DialogResult dialogRes = MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.OK);
            if (dialogRes == DialogResult.OK)
            {
                int id = Convert.ToInt32(dgvList.SelectedRows[0].Cells[0].Value);
                string sql = "delete from Income where Id=@id";
                SqlParameter p = new SqlParameter("@id", id);
                int res = DBHelper.ExecuteNonQuery(sql, p);
                if (res > 0)
                {
                    LoadList();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            else
            {
                return;
            }
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取当前行的信息并显示在相应的位置
            int id = Convert.ToInt32(dgvList.SelectedRows[0].Cells[0].Value);
            string name = dgvList.SelectedRows[0].Cells[1].Value.ToString();
            int num = Convert.ToInt32(dgvList.SelectedRows[0].Cells[2].Value);
            string source = dgvList.SelectedRows[0].Cells[3].Value.ToString();
            DateTime date = Convert.ToDateTime(dgvList.SelectedRows[0].Cells[4].Value.ToString());
            //显示
            txtId.Text = id.ToString();
            txtName2.Text = name;
            txtNum.Text = num.ToString();
            txtSource.Text = source;
            txtDate.Value = date;
        }
    }
}
