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
            this.label3 = new System.Windows.Forms.Label();
            this.UidInputBox = new System.Windows.Forms.TextBox();
            this.QueryButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.StatisticsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CookieInputBox
            // 
            this.CookieInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.CookieInputBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CookieInputBox.Location = new System.Drawing.Point(130, 75);
            this.CookieInputBox.Multiline = true;
            this.CookieInputBox.Name = "CookieInputBox";
            this.CookieInputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CookieInputBox.Size = new System.Drawing.Size(831, 80);
            this.CookieInputBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(22, 75);
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
            this.dataGridView1.Location = new System.Drawing.Point(22, 232);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(939, 550);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dataGridView1_SortCompare);
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
            this.name.Width = 120;
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
            this.today_intimacy.Width = 150;
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
            this.UidInputBox.Location = new System.Drawing.Point(130, 21);
            this.UidInputBox.Multiline = true;
            this.UidInputBox.Name = "UidInputBox";
            this.UidInputBox.Size = new System.Drawing.Size(261, 32);
            this.UidInputBox.TabIndex = 14;
            // 
            // QueryButton
            // 
            this.QueryButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.QueryButton.Location = new System.Drawing.Point(406, 21);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(188, 32);
            this.QueryButton.TabIndex = 15;
            this.QueryButton.Text = "点击查询";
            this.QueryButton.UseVisualStyleBackColor = true;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(609, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "用户名：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.UsernameLabel.Location = new System.Drawing.Point(702, 21);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(259, 32);
            this.UsernameLabel.TabIndex = 17;
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatisticsLabel
            // 
            this.StatisticsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.StatisticsLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.StatisticsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatisticsLabel.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.StatisticsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StatisticsLabel.Location = new System.Drawing.Point(22, 178);
            this.StatisticsLabel.Name = "StatisticsLabel";
            this.StatisticsLabel.Size = new System.Drawing.Size(939, 32);
            this.StatisticsLabel.TabIndex = 18;
            this.StatisticsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 803);
            this.Controls.Add(this.StatisticsLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QueryButton);
            this.Controls.Add(this.UidInputBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CookieInputBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B站直播陪伴记录查询工具";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label StatisticsLabel;

        private System.Windows.Forms.DataGridViewTextBoxColumn index;

        private System.Windows.Forms.DataGridViewTextBoxColumn is_lighted;

        private System.Windows.Forms.DataGridViewTextBoxColumn receive_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;

        private System.Windows.Forms.Label label4;
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