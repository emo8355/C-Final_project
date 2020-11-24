namespace CS_FinalProject_HL_SZ
{
    partial class LendBooks
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lend = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1237, 110);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lend Book";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.Title,
            this.Language,
            this.categoryName,
            this.Author,
            this.BookStatus,
            this.Lend});
            this.dataGridView1.Location = new System.Drawing.Point(62, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 445);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Verdana", 13.875F);
            this.button1.Location = new System.Drawing.Point(535, 688);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookId
            // 
            this.BookId.HeaderText = "id";
            this.BookId.MinimumWidth = 8;
            this.BookId.Name = "BookId";
            this.BookId.Width = 150;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 8;
            this.Title.Name = "Title";
            this.Title.Width = 150;
            // 
            // Language
            // 
            this.Language.HeaderText = "Language";
            this.Language.MinimumWidth = 8;
            this.Language.Name = "Language";
            this.Language.Width = 150;
            // 
            // categoryName
            // 
            this.categoryName.HeaderText = "Category";
            this.categoryName.MinimumWidth = 8;
            this.categoryName.Name = "categoryName";
            this.categoryName.Width = 150;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 8;
            this.Author.Name = "Author";
            this.Author.Width = 150;
            // 
            // BookStatus
            // 
            this.BookStatus.HeaderText = "Is borrowed";
            this.BookStatus.MinimumWidth = 8;
            this.BookStatus.Name = "BookStatus";
            this.BookStatus.Width = 150;
            // 
            // Lend
            // 
            this.Lend.HeaderText = "Lend Book";
            this.Lend.MinimumWidth = 8;
            this.Lend.Name = "Lend";
            this.Lend.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Lend.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Lend.Text = "Lend";
            this.Lend.UseColumnTextForButtonValue = true;
            this.Lend.Width = 150;
            // 
            // LendBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1237, 795);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "LendBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LendBooks";
            this.Load += new System.EventHandler(this.LendBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookStatus;
        private System.Windows.Forms.DataGridViewButtonColumn Lend;
    }
}