namespace interfax_client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ifDG = new System.Windows.Forms.DataGridView();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateLabel = new System.Windows.Forms.Label();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LoggerType = new System.Windows.Forms.Label();
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
            this.ifDG.Location = new System.Drawing.Point(8, 21);
            this.ifDG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ifDG.Name = "ifDG";
            this.ifDG.RowHeadersWidth = 62;
            this.ifDG.RowTemplate.Height = 28;
            this.ifDG.Size = new System.Drawing.Size(517, 264);
            this.ifDG.TabIndex = 0;
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
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(8, 6);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(28, 13);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "date";
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Location = new System.Drawing.Point(150, 6);
            this.memoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(43, 13);
            this.memoryLabel.TabIndex = 2;
            this.memoryLabel.Text = "memory";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(372, 2);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(153, 17);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Обновить таблицу";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoggerType
            // 
            this.LoggerType.AutoSize = true;
            this.LoggerType.Location = new System.Drawing.Point(283, 6);
            this.LoggerType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoggerType.Name = "LoggerType";
            this.LoggerType.Size = new System.Drawing.Size(27, 13);
            this.LoggerType.TabIndex = 4;
            this.LoggerType.Text = "type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.LoggerType);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.memoryLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.ifDG);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ifDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ifDG;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoryColumn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LoggerType;
    }
}

