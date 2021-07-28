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
using Microsoft.Office.Interop.Excel;
using System.IO;
namespace 财务管理
{
    public partial class SelectSpend : Form
    {
        public SelectSpend()
        {
            InitializeComponent();
        }
        public void LoadList()
        {
            //"select sno,sname,gender,student.Classid,Age,ClassName from student join Classinfo on student.Classid=Classinfo.Classid"
            string sql = "select * from Spend";
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = DBHelper.ExecuteQuery(sql);
            dgvList.AutoGenerateColumns = false;
            dgvList.DataSource = dt;
        }

       

        public void LoadSearch()
        {
            string sql = "select spendId,spendName,spendNum,spendDep,receiveName,expenditure,spendDate from Spend where sDelete=0";
            List<SqlParameter> list = new List<SqlParameter>();
            SqlParameter p = new SqlParameter("@name", txtName.Text);
            SqlParameter p2 = new SqlParameter("@date", txtDate.Text);
            if (txtName.Text != "" && txtDate.Text == "")
            {
                sql += "and spendName like '%' + @name + '%'";
                list.Clear();
                list.Add(p);
            }
            if (txtName.Text == "" && txtDate.Text != "")
            {
                sql += "and spendDate like '%' + @date + '%'";
                list.Clear();
                list.Add(p2);
            }
            if (txtName.Text != "" && txtDate.Text != "")
            {
                sql += "and spendName like '%' + @name + '%'and spendDate like '%' + @date + '%'";
                list.Clear();
                list.Add(p);
                list.Add(p2);
            }
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = DBHelper.ExecuteQuery(sql, list.ToArray());
            dgvList.AutoGenerateColumns = false;
            dgvList.DataSource = dt;
        }
       

       
       

       

        private void SelectSpend_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void txtName_TextChanged_1(object sender, EventArgs e)
        {
            LoadSearch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            main.Show();
            this.Hide();
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            LoadSearch();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();   //实例化一个SaveFileDialog保存文件对话框
            dlg.Filter = "Excel files (*.xls)|*.xls";
            dlg.FilterIndex = 0;
            dlg.RestoreDirectory = true;
            dlg.CreatePrompt = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Stream myStream;
                myStream = dlg.OpenFile();
                StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding(-0));
                string columnTitle = "";
                try
                {
                    //写入列标题
                    for (int i = 0; i < dgvList.ColumnCount; i++)
                    {
                        if (i > 0)
                        {
                            columnTitle += "\t";
                        }
                        columnTitle += dgvList.Columns[i].HeaderText;
                    }
                    sw.WriteLine(columnTitle);

                    //写入列内容
                    for (int j = 0; j < dgvList.Rows.Count; j++)
                    {
                        string columnValue = "";
                        for (int k = 0; k < dgvList.Columns.Count; k++)
                        {
                            if (k > 0)
                            {
                                columnValue += "\t";
                            }
                            if (dgvList.Rows[j].Cells[k].Value == null)
                                columnValue += "";
                            else
                                columnValue += dgvList.Rows[j].Cells[k].Value.ToString().Trim();
                        }
                        sw.WriteLine(columnValue);
                    }
                    sw.Close();
                    myStream.Close();
                }
                catch
                {
                    MessageBox.Show("导出不成功");
                }
                finally
                {
                    sw.Close();
                    myStream.Close();
                }
            }
        }
    }
}
