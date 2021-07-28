
namespace 财务管理
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.收支查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收入查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.支出查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收支添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收入录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.支出录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收支管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收入管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.支出管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn2 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::财务管理.Properties.Resources.menuBg;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.收支查询ToolStripMenuItem,
            this.收支添加ToolStripMenuItem,
            this.收支管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.退出ToolStripMenuItem1.Text = "退出系统";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // 收支查询ToolStripMenuItem
            // 
            this.收支查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.收入查询ToolStripMenuItem,
            this.支出查询ToolStripMenuItem});
            this.收支查询ToolStripMenuItem.Name = "收支查询ToolStripMenuItem";
            this.收支查询ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.收支查询ToolStripMenuItem.Text = "收支查询";
            // 
            // 收入查询ToolStripMenuItem
            // 
            this.收入查询ToolStripMenuItem.Name = "收入查询ToolStripMenuItem";
            this.收入查询ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.收入查询ToolStripMenuItem.Text = "收入查询";
            this.收入查询ToolStripMenuItem.Click += new System.EventHandler(this.收入查询ToolStripMenuItem_Click);
            // 
            // 支出查询ToolStripMenuItem
            // 
            this.支出查询ToolStripMenuItem.Name = "支出查询ToolStripMenuItem";
            this.支出查询ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.支出查询ToolStripMenuItem.Text = "支出查询";
            this.支出查询ToolStripMenuItem.Click += new System.EventHandler(this.支出查询ToolStripMenuItem_Click);
            // 
            // 收支添加ToolStripMenuItem
            // 
            this.收支添加ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.收入录入ToolStripMenuItem,
            this.支出录入ToolStripMenuItem});
            this.收支添加ToolStripMenuItem.Name = "收支添加ToolStripMenuItem";
            this.收支添加ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.收支添加ToolStripMenuItem.Text = "收支录入";
            // 
            // 收入录入ToolStripMenuItem
            // 
            this.收入录入ToolStripMenuItem.Name = "收入录入ToolStripMenuItem";
            this.收入录入ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.收入录入ToolStripMenuItem.Text = "收入录入";
            this.收入录入ToolStripMenuItem.Click += new System.EventHandler(this.收入录入ToolStripMenuItem_Click);
            // 
            // 支出录入ToolStripMenuItem
            // 
            this.支出录入ToolStripMenuItem.Name = "支出录入ToolStripMenuItem";
            this.支出录入ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.支出录入ToolStripMenuItem.Text = "支出录入";
            this.支出录入ToolStripMenuItem.Click += new System.EventHandler(this.支出录入ToolStripMenuItem_Click);
            // 
            // 收支管理ToolStripMenuItem
            // 
            this.收支管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.收入管理ToolStripMenuItem,
            this.支出管理ToolStripMenuItem});
            this.收支管理ToolStripMenuItem.Name = "收支管理ToolStripMenuItem";
            this.收支管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.收支管理ToolStripMenuItem.Text = "收支管理";
            // 
            // 收入管理ToolStripMenuItem
            // 
            this.收入管理ToolStripMenuItem.Name = "收入管理ToolStripMenuItem";
            this.收入管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.收入管理ToolStripMenuItem.Text = "收入管理";
            this.收入管理ToolStripMenuItem.Click += new System.EventHandler(this.收入管理ToolStripMenuItem_Click);
            // 
            // 支出管理ToolStripMenuItem
            // 
            this.支出管理ToolStripMenuItem.Name = "支出管理ToolStripMenuItem";
            this.支出管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.支出管理ToolStripMenuItem.Text = "支出管理";
            this.支出管理ToolStripMenuItem.Click += new System.EventHandler(this.支出管理ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // Chart1
            // 
            this.Chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.Chart1.Legends.Add(legend5);
            this.Chart1.Location = new System.Drawing.Point(179, 68);
            this.Chart1.Name = "Chart1";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Series2";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Series3";
            this.Chart1.Series.Add(series13);
            this.Chart1.Series.Add(series14);
            this.Chart1.Series.Add(series15);
            this.Chart1.Size = new System.Drawing.Size(743, 474);
            this.Chart1.TabIndex = 4;
            this.Chart1.Text = "chart1";
            title5.BackColor = System.Drawing.Color.White;
            title5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title5.Name = "收支情况柱状图";
            title5.Text = "收支情况柱状图";
            this.Chart1.Titles.Add(title5);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2.Location = new System.Drawing.Point(12, 165);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(116, 42);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "收支差额";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 545);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(934, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1.Location = new System.Drawing.Point(12, 78);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(116, 37);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "收支情况";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::财务管理.Properties.Resources._7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 571);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMain";
            this.Text = "财务管理系统";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 收支查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收入查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 支出查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收支添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收入录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 支出录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收支管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收入管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 支出管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btn1;
    }
}