namespace PEIS.cxbb
{
    partial class Form_jbrstj
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_mb = new System.Windows.Forms.RadioButton();
            this.rb_dx = new System.Windows.Forms.RadioButton();
            this.bt_print = new System.Windows.Forms.Button();
            this.cmb_xb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_select = new System.Windows.Forms.Button();
            this.cmb_rylx = new System.Windows.Forms.ComboBox();
            this.txt_tjdw = new System.Windows.Forms.TextBox();
            this.bt_tjdw = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_begin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.reportView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_wxjb = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lv_yxjb = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_mb);
            this.groupBox1.Controls.Add(this.rb_dx);
            this.groupBox1.Controls.Add(this.bt_print);
            this.groupBox1.Controls.Add(this.cmb_xb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bt_exit);
            this.groupBox1.Controls.Add(this.bt_select);
            this.groupBox1.Controls.Add(this.cmb_rylx);
            this.groupBox1.Controls.Add(this.txt_tjdw);
            this.groupBox1.Controls.Add(this.bt_tjdw);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_end);
            this.groupBox1.Controls.Add(this.dtp_begin);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检索条件";
            // 
            // rb_mb
            // 
            this.rb_mb.AutoSize = true;
            this.rb_mb.Location = new System.Drawing.Point(507, 42);
            this.rb_mb.Name = "rb_mb";
            this.rb_mb.Size = new System.Drawing.Size(100, 19);
            this.rb_mb.TabIndex = 54;
            this.rb_mb.TabStop = true;
            this.rb_mb.Text = "按疾病模板";
            this.rb_mb.UseVisualStyleBackColor = true;
            this.rb_mb.CheckedChanged += new System.EventHandler(this.rb_mb_CheckedChanged);
            // 
            // rb_dx
            // 
            this.rb_dx.AutoSize = true;
            this.rb_dx.Location = new System.Drawing.Point(507, 19);
            this.rb_dx.Name = "rb_dx";
            this.rb_dx.Size = new System.Drawing.Size(100, 19);
            this.rb_dx.TabIndex = 53;
            this.rb_dx.TabStop = true;
            this.rb_dx.Text = "按单项疾病";
            this.rb_dx.UseVisualStyleBackColor = true;
            this.rb_dx.CheckedChanged += new System.EventHandler(this.rb_dx_CheckedChanged);
            // 
            // bt_print
            // 
            this.bt_print.Location = new System.Drawing.Point(700, 29);
            this.bt_print.Name = "bt_print";
            this.bt_print.Size = new System.Drawing.Size(75, 23);
            this.bt_print.TabIndex = 52;
            this.bt_print.Text = "打印(&P)";
            this.bt_print.UseVisualStyleBackColor = true;
            this.bt_print.Click += new System.EventHandler(this.bt_print_Click);
            // 
            // cmb_xb
            // 
            this.cmb_xb.FormattingEnabled = true;
            this.cmb_xb.Location = new System.Drawing.Point(417, 42);
            this.cmb_xb.Name = "cmb_xb";
            this.cmb_xb.Size = new System.Drawing.Size(84, 23);
            this.cmb_xb.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "性    别：";
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(781, 29);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 23);
            this.bt_exit.TabIndex = 49;
            this.bt_exit.Text = "退出(&X)";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(619, 29);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(75, 23);
            this.bt_select.TabIndex = 48;
            this.bt_select.Text = "检索(&S)";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // cmb_rylx
            // 
            this.cmb_rylx.FormattingEnabled = true;
            this.cmb_rylx.Location = new System.Drawing.Point(417, 16);
            this.cmb_rylx.Name = "cmb_rylx";
            this.cmb_rylx.Size = new System.Drawing.Size(84, 23);
            this.cmb_rylx.TabIndex = 45;
            // 
            // txt_tjdw
            // 
            this.txt_tjdw.Location = new System.Drawing.Point(73, 40);
            this.txt_tjdw.Name = "txt_tjdw";
            this.txt_tjdw.Size = new System.Drawing.Size(241, 24);
            this.txt_tjdw.TabIndex = 43;
            // 
            // bt_tjdw
            // 
            this.bt_tjdw.Location = new System.Drawing.Point(319, 40);
            this.bt_tjdw.Name = "bt_tjdw";
            this.bt_tjdw.Size = new System.Drawing.Size(19, 23);
            this.bt_tjdw.TabIndex = 44;
            this.bt_tjdw.Text = "…";
            this.bt_tjdw.UseVisualStyleBackColor = true;
            this.bt_tjdw.Click += new System.EventHandler(this.bt_tjdw_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "体检单位：";
            // 
            // dtp_end
            // 
            this.dtp_end.CustomFormat = "yyyy-MM-dd";
            this.dtp_end.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_end.Location = new System.Drawing.Point(223, 16);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(116, 23);
            this.dtp_end.TabIndex = 39;
            // 
            // dtp_begin
            // 
            this.dtp_begin.CustomFormat = "yyyy-MM-dd";
            this.dtp_begin.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_begin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_begin.Location = new System.Drawing.Point(73, 16);
            this.dtp_begin.Name = "dtp_begin";
            this.dtp_begin.Size = new System.Drawing.Size(116, 23);
            this.dtp_begin.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "体检日期：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 41;
            this.label7.Text = "至";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(345, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 15);
            this.label13.TabIndex = 46;
            this.label13.Text = "人员类型：";
            // 
            // reportView
            // 
            this.reportView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportView.Location = new System.Drawing.Point(2, 314);
            this.reportView.Name = "reportView";
            this.reportView.Size = new System.Drawing.Size(864, 341);
            this.reportView.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_wxjb);
            this.groupBox2.Location = new System.Drawing.Point(2, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 237);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "疾病列表";
            // 
            // lv_wxjb
            // 
            this.lv_wxjb.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_wxjb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_wxjb.Location = new System.Drawing.Point(3, 20);
            this.lv_wxjb.Name = "lv_wxjb";
            this.lv_wxjb.Size = new System.Drawing.Size(424, 214);
            this.lv_wxjb.TabIndex = 1;
            this.lv_wxjb.UseCompatibleStateImageBehavior = false;
            this.lv_wxjb.View = System.Windows.Forms.View.SmallIcon;
            this.lv_wxjb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_wxjb_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 210;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 210;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 210;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lv_yxjb);
            this.groupBox3.Location = new System.Drawing.Point(436, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 234);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "已选疾病";
            // 
            // lv_yxjb
            // 
            this.lv_yxjb.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_yxjb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_yxjb.Location = new System.Drawing.Point(3, 20);
            this.lv_yxjb.Name = "lv_yxjb";
            this.lv_yxjb.Size = new System.Drawing.Size(424, 211);
            this.lv_yxjb.TabIndex = 1;
            this.lv_yxjb.UseCompatibleStateImageBehavior = false;
            this.lv_yxjb.View = System.Windows.Forms.View.SmallIcon;
            this.lv_yxjb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_yxjb_MouseDoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 210;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Width = 210;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Width = 210;
            // 
            // Form_jbrstj
            // 
            this.ClientSize = new System.Drawing.Size(870, 651);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.reportView);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_jbrstj";
            this.Text = "疾病人数统计";
            this.Load += new System.EventHandler(this.Form_yxjghz_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DateTimePicker dtp_begin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tjdw;
        private System.Windows.Forms.Button bt_tjdw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_rylx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_select;
        private Microsoft.Reporting.WinForms.ReportViewer reportView;
        private System.Windows.Forms.Button bt_print;
        private System.Windows.Forms.ComboBox cmb_xb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_mb;
        private System.Windows.Forms.RadioButton rb_dx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lv_wxjb;
        private System.Windows.Forms.ListView lv_yxjb;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
