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
    public partial class FormSpend : Form
    {
        public FormSpend()
        {
            InitializeComponent();
        }
        public void LoadList()
        {
            //string sql = "select spendId,spendName,spendNum,spendDep,receiveName,Hid,Spend.expenditure,spendDate from Spend join Exit on Spend.expenditure=Exit.expenditure";
            string sql = "select * from Spend";
            DataTable dt = new DataTable();
            dt = DBHelper.ExecuteQuery(sql);
            dgvList.AutoGenerateColumns = false;
            dgvList.DataSource = dt;
        }
        //public void LoadCombox()
        //{
        //    string sql = "select * from Exit";
        //    DataTable dt = new DataTable();
        //    dt = DBHelper.ExecuteQuery(sql);
        //    txtAdd.DataSource = dt;
        //    txtAdd.DisplayMember = "expenditure";
        //    txtAdd.ValueMember = "Hid";
        //}
        private void FormSpend_Load(object sender, EventArgs e)
        {
            LoadList();
            //LoadCombox();
            //txtAdd.SelectedIndex = 0;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            SqlParameter[] ps =
           {
                new SqlParameter("@id",txtId.Text),
                new SqlParameter("@name",txtName2.Text),
                new SqlParameter("@num",Convert.ToInt32(txtNum.Text)),
                new SqlParameter("@dep",txtDep.Text),
                new SqlParameter("@receive",txtReceive.Text),
                new SqlParameter("@add",txtAdd.Text),
                new SqlParameter("@date",txtDate.Value.Date)
             };
            string sql = "update Spend set spendName=@name,spendNum=@num,spendDep=@dep,receiveName=@receive,expenditure=@add,spendDate=@date where spendId=@id";
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

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取当前行的信息并显示在相应的位置
            int id = Convert.ToInt32(dgvList.SelectedRows[0].Cells[0].Value);
            string name = dgvList.SelectedRows[0].Cells[1].Value.ToString();
            int num = Convert.ToInt32(dgvList.SelectedRows[0].Cells[2].Value);
            string dep = dgvList.SelectedRows[0].Cells[3].Value.ToString();
            string receive = dgvList.SelectedRows[0].Cells[4].Value.ToString();
            string expenditure = dgvList.SelectedRows[0].Cells[5].Value.ToString();
            DateTime date = Convert.ToDateTime(dgvList.SelectedRows[0].Cells[6].Value.ToString());
            //显示
            txtId.Text = id.ToString();
            txtName2.Text = name;
            txtNum.Text = num.ToString();
            txtDep.Text = dep;
            txtReceive.Text = receive;
            txtAdd.Text = expenditure;
            txtDate.Value = date;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            main.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogRes = MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.OK);
            if (dialogRes == DialogResult.OK)
            {
                int spendId = Convert.ToInt32(dgvList.SelectedRows[0].Cells[0].Value);
                string sql = "delete from Spend where spendId=@id";
                SqlParameter p = new SqlParameter("@id", spendId);
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
    }
}
