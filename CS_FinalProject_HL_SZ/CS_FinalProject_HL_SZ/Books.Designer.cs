namespace CS_FinalProject_HL_SZ
{
    partial class Books
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AuthorSelect = new System.Windows.Forms.ComboBox();
            this.CategorySelect = new System.Windows.Forms.ComboBox();
            this.dateInput = new System.Windows.Forms.TextBox();
            this.langinput = new System.Windows.Forms.TextBox();
            this.bookInput = new System.Windows.Forms.TextBox();
            this.publishDate = new System.Windows.Forms.Label();
            this.Authorlabel = new System.Windows.Forms.Label();
            this.Categorylabel = new System.Windows.Forms.Label();
            this.lang = new System.Windows.Forms.Label();
            this.titlelabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Detele = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(1626, 110);
            this.label1.TabIndex = 0;
            this.label1.Text = "Books";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.AuthorSelect);
            this.groupBox1.Controls.Add(this.CategorySelect);
            this.groupBox1.Controls.Add(this.dateInput);
            this.groupBox1.Controls.Add(this.langinput);
            this.groupBox1.Controls.Add(this.bookInput);
            this.groupBox1.Controls.Add(this.publishDate);
            this.groupBox1.Controls.Add(this.Authorlabel);
            this.groupBox1.Controls.Add(this.Categorylabel);
            this.groupBox1.Controls.Add(this.lang);
            this.groupBox1.Controls.Add(this.titlelabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 511);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book";
            // 
            // AuthorSelect
            // 
            this.AuthorSelect.Font = new System.Drawing.Font("Verdana", 12F);
            this.AuthorSelect.FormattingEnabled = true;
            this.AuthorSelect.Location = new System.Drawing.Point(126, 327);
            this.AuthorSelect.Name = "AuthorSelect";
            this.AuthorSelect.Size = new System.Drawing.Size(286, 37);
            this.AuthorSelect.TabIndex = 10;
            // 
            // CategorySelect
            // 
            this.CategorySelect.Font = new System.Drawing.Font("Verdana", 12F);
            this.CategorySelect.FormattingEnabled = true;
            this.CategorySelect.Location = new System.Drawing.Point(126, 233);
            this.CategorySelect.Name = "CategorySelect";
            this.CategorySelect.Size = new System.Drawing.Size(286, 37);
            this.CategorySelect.TabIndex = 9;
            // 
            // dateInput
            // 
            this.dateInput.Font = new System.Drawing.Font("Verdana", 12F);
            this.dateInput.Location = new System.Drawing.Point(24, 446);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(388, 37);
            this.dateInput.TabIndex = 8;
            // 
            // langinput
            // 
            this.langinput.Font = new System.Drawing.Font("Verdana", 12F);
            this.langinput.Location = new System.Drawing.Point(126, 142);
            this.langinput.Name = "langinput";
            this.langinput.Size = new System.Drawing.Size(286, 37);
            this.langinput.TabIndex = 7;
            // 
            // bookInput
            // 
            this.bookInput.Font = new System.Drawing.Font("Verdana", 12F);
            this.bookInput.Location = new System.Drawing.Point(126, 66);
            this.bookInput.Name = "bookInput";
            this.bookInput.Size = new System.Drawing.Size(286, 37);
            this.bookInput.TabIndex = 6;
            // 
            // publishDate
            // 
            this.publishDate.AutoSize = true;
            this.publishDate.Location = new System.Drawing.Point(19, 413);
            this.publishDate.Name = "publishDate";
            this.publishDate.Size = new System.Drawing.Size(143, 29);
            this.publishDate.TabIndex = 4;
            this.publishDate.Text = "PublishDate";
            // 
            // Authorlabel
            // 
            this.Authorlabel.AutoSize = true;
            this.Authorlabel.Location = new System.Drawing.Point(19, 330);
            this.Authorlabel.Name = "Authorlabel";
            this.Authorlabel.Size = new System.Drawing.Size(82, 29);
            this.Authorlabel.TabIndex = 3;
            this.Authorlabel.Text = "Author";
            // 
            // Categorylabel
            // 
            this.Categorylabel.AutoSize = true;
            this.Categorylabel.Location = new System.Drawing.Point(6, 233);
            this.Categorylabel.Name = "Categorylabel";
            this.Categorylabel.Size = new System.Drawing.Size(105, 29);
            this.Categorylabel.TabIndex = 2;
            this.Categorylabel.Text = "category";
            // 
            // lang
            // 
            this.lang.AutoSize = true;
            this.lang.Location = new System.Drawing.Point(6, 146);
            this.lang.Name = "lang";
            this.lang.Size = new System.Drawing.Size(120, 29);
            this.lang.TabIndex = 1;
            this.lang.Text = "Language";
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Location = new System.Drawing.Point(19, 66);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(61, 29);
            this.titlelabel.TabIndex = 0;
            this.titlelabel.Text = "Title";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryId,
            this.Title,
            this.Language,
            this.categoryName,
            this.Author,
            this.Edit,
            this.Detele});
            this.dataGridView1.Location = new System.Drawing.Point(487, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1115, 403);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // categoryId
            // 
            this.categoryId.HeaderText = "id";
            this.categoryId.MinimumWidth = 8;
            this.categoryId.Name = "categoryId";
            this.categoryId.Width = 150;
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
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 150;
            // 
            // Detele
            // 
            this.Detele.HeaderText = "Delete";
            this.Detele.MinimumWidth = 8;
            this.Detele.Name = "Detele";
            this.Detele.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detele.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Detele.Text = "Delete";
            this.Detele.UseColumnTextForButtonValue = true;
            this.Detele.Width = 150;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Verdana", 13.875F);
            this.button1.Location = new System.Drawing.Point(487, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Font = new System.Drawing.Font("Verdana", 13.875F);
            this.button2.Location = new System.Drawing.Point(759, 603);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 65);
            this.button2.TabIndex = 6;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1626, 767);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox AuthorSelect;
        private System.Windows.Forms.ComboBox CategorySelect;
        private System.Windows.Forms.TextBox dateInput;
        private System.Windows.Forms.TextBox langinput;
        private System.Windows.Forms.TextBox bookInput;
        private System.Windows.Forms.Label publishDate;
        private System.Windows.Forms.Label Authorlabel;
        private System.Windows.Forms.Label Categorylabel;
        private System.Windows.Forms.Label lang;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Detele;
        private System.Windows.Forms.Button button2;
    }
}