namespace BilibiliLiveAccompanyRecord {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CookieInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.UidInputBox = new System.Windows.Forms.TextBox();
            this.QueryButton = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.MedalCountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LightedCountLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BlackoutCountLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TotalExpenseLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TotalSendBarLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TotalWatchTimeLabel = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalWatchDayTimeLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FullIntimacyLabel = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medal_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medal_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intimacy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.today_intimacy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receive_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_lighted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guard_extra_gold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.watch_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.send_bar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CookieInputBox
            // 
            this.CookieInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.CookieInputBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CookieInputBox.Location = new System.Drawing.Point(145, 74);
            this.CookieInputBox.Multiline = true;
            this.CookieInputBox.Name = "CookieInputBox";
            this.CookieInputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CookieInputBox.Size = new System.Drawing.Size(816, 80);
            this.CookieInputBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(22, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cookie：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.index, this.name, this.medal_name, this.level, this.medal_id, this.intimacy, this.today_intimacy, this.receive_time, this.score, this.is_lighted, this.guard_extra_gold, this.watch_time, this.send_bar });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.WindowText;
            this.dataGridView1.Location = new System.Drawing.Point(22, 381);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(939, 350);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dataGridView1_SortCompare);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(22, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "UID：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UidInputBox
            // 
            this.UidInputBox.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UidInputBox.Location = new System.Drawing.Point(145, 21);
            this.UidInputBox.Multiline = true;
            this.UidInputBox.Name = "UidInputBox";
            this.UidInputBox.Size = new System.Drawing.Size(270, 32);
            this.UidInputBox.TabIndex = 14;
            // 
            // QueryButton
            // 
            this.QueryButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.QueryButton.Location = new System.Drawing.Point(432, 21);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(120, 32);
            this.QueryButton.TabIndex = 15;
            this.QueryButton.Text = "点击查询";
            this.QueryButton.UseVisualStyleBackColor = true;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameLabel.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.UsernameLabel.ForeColor = System.Drawing.Color.Blue;
            this.UsernameLabel.Location = new System.Drawing.Point(761, 21);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(200, 32);
            this.UsernameLabel.TabIndex = 17;
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MedalCountLabel
            // 
            this.MedalCountLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MedalCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MedalCountLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.MedalCountLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MedalCountLabel.Location = new System.Drawing.Point(172, 226);
            this.MedalCountLabel.Name = "MedalCountLabel";
            this.MedalCountLabel.Size = new System.Drawing.Size(90, 32);
            this.MedalCountLabel.TabIndex = 18;
            this.MedalCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(22, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "总勋章数：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(272, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "点亮勋章数：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LightedCountLabel
            // 
            this.LightedCountLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LightedCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LightedCountLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.LightedCountLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LightedCountLabel.Location = new System.Drawing.Point(422, 226);
            this.LightedCountLabel.Name = "LightedCountLabel";
            this.LightedCountLabel.Size = new System.Drawing.Size(90, 32);
            this.LightedCountLabel.TabIndex = 20;
            this.LightedCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(525, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 32);
            this.label7.TabIndex = 23;
            this.label7.Text = "熄灭勋章数：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BlackoutCountLabel
            // 
            this.BlackoutCountLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BlackoutCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BlackoutCountLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.BlackoutCountLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BlackoutCountLabel.Location = new System.Drawing.Point(675, 226);
            this.BlackoutCountLabel.Name = "BlackoutCountLabel";
            this.BlackoutCountLabel.Size = new System.Drawing.Size(90, 32);
            this.BlackoutCountLabel.TabIndex = 22;
            this.BlackoutCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(272, 278);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 32);
            this.label13.TabIndex = 25;
            this.label13.Text = "总计消费电池：";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalExpenseLabel
            // 
            this.TotalExpenseLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TotalExpenseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalExpenseLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.TotalExpenseLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotalExpenseLabel.Location = new System.Drawing.Point(422, 278);
            this.TotalExpenseLabel.Name = "TotalExpenseLabel";
            this.TotalExpenseLabel.Size = new System.Drawing.Size(90, 32);
            this.TotalExpenseLabel.TabIndex = 24;
            this.TotalExpenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(525, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 32);
            this.label9.TabIndex = 27;
            this.label9.Text = "总计发送弹幕：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalSendBarLabel
            // 
            this.TotalSendBarLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TotalSendBarLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalSendBarLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.TotalSendBarLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotalSendBarLabel.Location = new System.Drawing.Point(675, 278);
            this.TotalSendBarLabel.Name = "TotalSendBarLabel";
            this.TotalSendBarLabel.Size = new System.Drawing.Size(90, 32);
            this.TotalSendBarLabel.TabIndex = 26;
            this.TotalSendBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(22, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 32);
            this.label11.TabIndex = 29;
            this.label11.Text = "总计观看时间：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalWatchTimeLabel
            // 
            this.TotalWatchTimeLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TotalWatchTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalWatchTimeLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.TotalWatchTimeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotalWatchTimeLabel.Location = new System.Drawing.Point(172, 329);
            this.TotalWatchTimeLabel.Name = "TotalWatchTimeLabel";
            this.TotalWatchTimeLabel.Size = new System.Drawing.Size(250, 32);
            this.TotalWatchTimeLabel.TabIndex = 28;
            this.TotalWatchTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExportButton
            // 
            this.ExportButton.Enabled = false;
            this.ExportButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExportButton.Location = new System.Drawing.Point(22, 173);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(240, 32);
            this.ExportButton.TabIndex = 30;
            this.ExportButton.Text = "将数据导出为Excel表格";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(432, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 32);
            this.label8.TabIndex = 33;
            this.label8.Text = "大约折合天数：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalWatchDayTimeLabel
            // 
            this.TotalWatchDayTimeLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TotalWatchDayTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalWatchDayTimeLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.TotalWatchDayTimeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotalWatchDayTimeLabel.Location = new System.Drawing.Point(591, 329);
            this.TotalWatchDayTimeLabel.Name = "TotalWatchDayTimeLabel";
            this.TotalWatchDayTimeLabel.Size = new System.Drawing.Size(174, 32);
            this.TotalWatchDayTimeLabel.TabIndex = 34;
            this.TotalWatchDayTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(281, 178);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(170, 27);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "导出时带上序号";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(22, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 32);
            this.label10.TabIndex = 37;
            this.label10.Text = "今日满亲密度：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FullIntimacyLabel
            // 
            this.FullIntimacyLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.FullIntimacyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullIntimacyLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.FullIntimacyLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FullIntimacyLabel.Location = new System.Drawing.Point(172, 278);
            this.FullIntimacyLabel.Name = "FullIntimacyLabel";
            this.FullIntimacyLabel.Size = new System.Drawing.Size(90, 32);
            this.FullIntimacyLabel.TabIndex = 36;
            this.FullIntimacyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox2
            // 
            this.checkBox2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.checkBox2.Location = new System.Drawing.Point(568, 25);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(187, 27);
            this.checkBox2.TabIndex = 39;
            this.checkBox2.Text = "仅查询粉丝勋章墙";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // index
            // 
            this.index.HeaderText = "序号";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.index.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "主播昵称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // medal_name
            // 
            this.medal_name.HeaderText = "勋章名";
            this.medal_name.Name = "medal_name";
            this.medal_name.ReadOnly = true;
            this.medal_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // level
            // 
            this.level.HeaderText = "等级";
            this.level.Name = "level";
            this.level.ReadOnly = true;
            this.level.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.level.Width = 80;
            // 
            // medal_id
            // 
            this.medal_id.HeaderText = "勋章ID";
            this.medal_id.Name = "medal_id";
            this.medal_id.ReadOnly = true;
            this.medal_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // intimacy
            // 
            this.intimacy.HeaderText = "亲密度";
            this.intimacy.Name = "intimacy";
            this.intimacy.ReadOnly = true;
            this.intimacy.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.intimacy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.intimacy.Width = 120;
            // 
            // today_intimacy
            // 
            this.today_intimacy.HeaderText = "今日亲密度";
            this.today_intimacy.Name = "today_intimacy";
            this.today_intimacy.ReadOnly = true;
            this.today_intimacy.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.today_intimacy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.today_intimacy.Width = 140;
            // 
            // receive_time
            // 
            this.receive_time.HeaderText = "获得时间";
            this.receive_time.Name = "receive_time";
            this.receive_time.ReadOnly = true;
            this.receive_time.Width = 180;
            // 
            // score
            // 
            this.score.HeaderText = "积分";
            this.score.Name = "score";
            this.score.ReadOnly = true;
            // 
            // is_lighted
            // 
            this.is_lighted.HeaderText = "勋章状态";
            this.is_lighted.Name = "is_lighted";
            this.is_lighted.ReadOnly = true;
            // 
            // guard_extra_gold
            // 
            this.guard_extra_gold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.guard_extra_gold.HeaderText = "累计消费电池";
            this.guard_extra_gold.Name = "guard_extra_gold";
            this.guard_extra_gold.ReadOnly = true;
            this.guard_extra_gold.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.guard_extra_gold.Width = 124;
            // 
            // watch_time
            // 
            this.watch_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.watch_time.HeaderText = "累计发送弹幕";
            this.watch_time.Name = "watch_time";
            this.watch_time.ReadOnly = true;
            this.watch_time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.watch_time.Width = 124;
            // 
            // send_bar
            // 
            this.send_bar.HeaderText = "累计观看时间";
            this.send_bar.Name = "send_bar";
            this.send_bar.ReadOnly = true;
            this.send_bar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.send_bar.Width = 140;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FullIntimacyLabel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TotalWatchDayTimeLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TotalWatchTimeLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TotalSendBarLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TotalExpenseLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BlackoutCountLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LightedCountLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MedalCountLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.QueryButton);
            this.Controls.Add(this.UidInputBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CookieInputBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B站直播间陪伴记录查询工具";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox checkBox2;

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label FullIntimacyLabel;

        private System.Windows.Forms.CheckBox checkBox1;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TotalWatchDayTimeLabel;

        private System.Windows.Forms.Button ExportButton;

        private System.Windows.Forms.Label MedalCountLabel;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label BlackoutCountLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TotalSendBarLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TotalWatchTimeLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label TotalExpenseLabel;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LightedCountLabel;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.DataGridViewTextBoxColumn index;

        private System.Windows.Forms.DataGridViewTextBoxColumn is_lighted;

        private System.Windows.Forms.DataGridViewTextBoxColumn receive_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;

        private System.Windows.Forms.Label UsernameLabel;

        private System.Windows.Forms.Button QueryButton;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UidInputBox;

        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn medal_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn medal_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn intimacy;
        private System.Windows.Forms.DataGridViewTextBoxColumn today_intimacy;
        private System.Windows.Forms.DataGridViewTextBoxColumn guard_extra_gold;
        private System.Windows.Forms.DataGridViewTextBoxColumn watch_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn send_bar;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.TextBox CookieInputBox;
        private System.Windows.Forms.Label label1;

        #endregion

    }
}