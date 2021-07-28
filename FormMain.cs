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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public static string conn = "Data Source=DESKTOP-KA0EUTK;Initial Catalog = Finance; Integrated Security = True";

        DataTable CreatData()
        {
            DataTable dt = new DataTable();
            //实例化SqlConnection对象
            SqlConnection sqlCon = new SqlConnection();
            //实例化SqlConnection对象连接数据库的字符串
            sqlCon.ConnectionString = conn;
            //定义SQL语句
            //sql公用部分
            string sqlQ = "select * from pay";

            dt = GetDataTable(sqlQ);

            return dt;
        }
        public static DataTable GetDataTable(string Sqlstr)
        {
            DataTable dt;
            SqlDataAdapter sda;
            SqlConnection sqlCon = new SqlConnection();
            //实例化SqlConnection对象连接数据库的字符串
            sqlCon.ConnectionString = conn;
            sqlCon.Open();
            sda = new SqlDataAdapter(Sqlstr, conn);
            //sda.SelectCommand.CommandTimeout = 120;
            dt = new DataTable();
            sda.Fill(dt);
            sqlCon.Close();
            return dt;
        }
        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePwd change = new ChangePwd();
            change.Show();

            this.Hide();
        }

        private void 收入查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectIncome select = new SelectIncome();
            select.Show();
            this.Hide();
        }

        private void 支出查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectSpend spend = new SelectSpend();
            spend.Show();
            this.Hide();
        }

        private void 收入录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddIncome add = new AddIncome();
            add.Show();
            this.Hide();
        }

        private void 支出录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSpend s = new AddSpend();
            s.Show();
            this.Hide();
        }

        private void 收入管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIncome form = new FormIncome();
            form.Show();
            this.Hide();
        }

        private void 支出管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSpend formSpend = new FormSpend();
            formSpend.Show();
            this.Hide();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conn);

            DataTable dt = CreatData();


            Chart1.DataSource = dt;//绑定数据
            Chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;//设置图表类型
            Chart1.Series["Series2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            Chart1.Series[0].XValueMember = "month";//X轴数据成员列
            Chart1.Series[0].YValueMembers = "income";//Y轴数据成员列
            Chart1.Series[1].XValueMember = "month";
            Chart1.Series[1].YValueMembers = "spend";
            Chart1.ChartAreas["ChartArea1"].AxisX.Title = "时间 /月";//X轴标题
            Chart1.ChartAreas["ChartArea1"].AxisX.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            Chart1.ChartAreas["ChartArea1"].AxisY.Title = "元";//Y轴标题
            Chart1.ChartAreas["ChartArea1"].AxisY.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            Chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;//X轴数据的间距
            Chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;//不显示竖着的分割线
            Chart1.Series[0].IsValueShownAsLabel = true;//显示坐标值
            Chart1.Series[1].IsValueShownAsLabel = true;
            Chart1.Series[0].LegendText = "收入图";
            Chart1.Series[1].LegendText = "支出图";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conn);
            // 折线图
            DataTable dt = CreatData();

            
            Chart1.DataSource = dt;//绑定数据
            Chart1.Series["Series3"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;//设置图表类型
            Chart1.Series[2].XValueMember = "month";//X轴数据成员列
            Chart1.Series[2].YValueMembers = "payment";//Y轴数据成员列

            Chart1.ChartAreas["ChartArea1"].AxisX.Title = "时间 /月";//X轴标题
            Chart1.ChartAreas["ChartArea1"].AxisX.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            Chart1.ChartAreas["ChartArea1"].AxisY.Title = "元";//Y轴标题
            Chart1.ChartAreas["ChartArea1"].AxisY.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            Chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;//X轴数据的间距
            Chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;//不显示竖着的分割线
            Chart1.Series[2].IsValueShownAsLabel = true;//显示坐标值

            Chart1.Series[2].LegendText = "收支差额";
           
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "系统时间：" + DateTime.Now.ToLongTimeString();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            //Register register = new Register();
            //register = (Register)this.Tag;

            //toolStripStatusLabel1.Text = "欢迎：" + register.UserName;
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
