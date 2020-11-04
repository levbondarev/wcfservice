namespace interfax_webclient
{
    partial class Form2
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
            this.ifDG = new System.Windows.Forms.DataGridView();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoggerType = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ifDG)).BeginInit();
            this.SuspendLayout();
            // 
            // ifDG
            // 
            this.ifDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ifDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ifDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateColumn,
            this.memoryColumn});
            this.ifDG.Location = new System.Drawing.Point(11, 29);
            this.ifDG.Margin = new System.Windows.Forms.Padding(2);
            this.ifDG.Name = "ifDG";
            this.ifDG.RowHeadersWidth = 62;
            this.ifDG.RowTemplate.Height = 28;
            this.ifDG.Size = new System.Drawing.Size(722, 285);
            this.ifDG.TabIndex = 1;
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "Дата";
            this.dateColumn.MinimumWidth = 8;
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            this.dateColumn.Width = 150;
            // 
            // memoryColumn
            // 
            this.memoryColumn.HeaderText = "Память";
            this.memoryColumn.MinimumWidth = 8;
            this.memoryColumn.Name = "memoryColumn";
            this.memoryColumn.ReadOnly = true;
            this.memoryColumn.Width = 150;
            // 
            // LoggerType
            // 
            this.LoggerType.AutoSize = true;
            this.LoggerType.Location = new System.Drawing.Point(287, 9);
            this.LoggerType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoggerType.Name = "LoggerType";
            this.LoggerType.Size = new System.Drawing.Size(27, 13);
            this.LoggerType.TabIndex = 8;
            this.LoggerType.Text = "type";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(580, 5);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(153, 20);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Обновить таблицу";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Location = new System.Drawing.Point(154, 9);
            this.memoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(43, 13);
            this.memoryLabel.TabIndex = 6;
            this.memoryLabel.Text = "memory";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 9);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(28, 13);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "date";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 325);
            this.Controls.Add(this.LoggerType);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.memoryLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.ifDG);
            this.Name = "Form2";
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ifDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ifDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoryColumn;
        private System.Windows.Forms.Label LoggerType;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer1;
    }
}