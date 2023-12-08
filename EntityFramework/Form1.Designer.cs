namespace EntityFramework
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Connect = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShowAuthors = new System.Windows.Forms.Button();
            this.ShowBooks = new System.Windows.Forms.Button();
            this.ShowPublishers = new System.Windows.Forms.Button();
            this.AddAuthor = new System.Windows.Forms.Button();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.AddBook = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.IdAuthorBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PagesBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IdPublisherBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddPublisher = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.PublisherNameBox = new System.Windows.Forms.TextBox();
            this.AdresBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.TableForDeleteComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.IdForDeleteBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Edit = new System.Windows.Forms.Button();
            this.TableForEditComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.IdForEditBox = new System.Windows.Forms.TextBox();
            this.ColumnForEditComboBox = new System.Windows.Forms.ComboBox();
            this.NewValueBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.FilterValue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Surch = new System.Windows.Forms.Button();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FloppaStyle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Connect.Location = new System.Drawing.Point(12, 12);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(580, 43);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Disconnect.Location = new System.Drawing.Point(598, 12);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(610, 43);
            this.Disconnect.TabIndex = 1;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = false;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 191);
            this.dataGridView1.TabIndex = 2;
            // 
            // ShowAuthors
            // 
            this.ShowAuthors.Location = new System.Drawing.Point(12, 61);
            this.ShowAuthors.Name = "ShowAuthors";
            this.ShowAuthors.Size = new System.Drawing.Size(358, 23);
            this.ShowAuthors.TabIndex = 3;
            this.ShowAuthors.Text = "Show Authors";
            this.ShowAuthors.UseVisualStyleBackColor = true;
            this.ShowAuthors.Click += new System.EventHandler(this.ShowAuthors_Click);
            // 
            // ShowBooks
            // 
            this.ShowBooks.Location = new System.Drawing.Point(376, 61);
            this.ShowBooks.Name = "ShowBooks";
            this.ShowBooks.Size = new System.Drawing.Size(412, 23);
            this.ShowBooks.TabIndex = 4;
            this.ShowBooks.Text = "Show Books";
            this.ShowBooks.UseVisualStyleBackColor = true;
            this.ShowBooks.Click += new System.EventHandler(this.ShowBooks_Click);
            // 
            // ShowPublishers
            // 
            this.ShowPublishers.Location = new System.Drawing.Point(794, 61);
            this.ShowPublishers.Name = "ShowPublishers";
            this.ShowPublishers.Size = new System.Drawing.Size(414, 23);
            this.ShowPublishers.TabIndex = 5;
            this.ShowPublishers.Text = "Show Publishers";
            this.ShowPublishers.UseVisualStyleBackColor = true;
            this.ShowPublishers.Click += new System.EventHandler(this.ShowPublishers_Click);
            // 
            // AddAuthor
            // 
            this.AddAuthor.Location = new System.Drawing.Point(9, 26);
            this.AddAuthor.Name = "AddAuthor";
            this.AddAuthor.Size = new System.Drawing.Size(87, 23);
            this.AddAuthor.TabIndex = 6;
            this.AddAuthor.Text = "Add Author";
            this.AddAuthor.UseVisualStyleBackColor = true;
            this.AddAuthor.Click += new System.EventHandler(this.AddAuthor_Click);
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(170, 28);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(244, 20);
            this.FirstNameBox.TabIndex = 7;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(503, 29);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(244, 20);
            this.LastNameBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "First name*";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(441, 32);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(60, 13);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Last name*";
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(9, 55);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(87, 23);
            this.AddBook.TabIndex = 11;
            this.AddBook.Text = "Add Book";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Title*";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(145, 58);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(150, 20);
            this.TitleBox.TabIndex = 13;
            // 
            // IdAuthorBox
            // 
            this.IdAuthorBox.Location = new System.Drawing.Point(383, 58);
            this.IdAuthorBox.Name = "IdAuthorBox";
            this.IdAuthorBox.Size = new System.Drawing.Size(145, 20);
            this.IdAuthorBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "IdAuthor*";
            // 
            // PagesBox
            // 
            this.PagesBox.Location = new System.Drawing.Point(606, 58);
            this.PagesBox.Name = "PagesBox";
            this.PagesBox.Size = new System.Drawing.Size(141, 20);
            this.PagesBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Pages";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(815, 58);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(142, 20);
            this.PriceBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(778, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Price";
            // 
            // IdPublisherBox
            // 
            this.IdPublisherBox.Location = new System.Drawing.Point(1063, 54);
            this.IdPublisherBox.Name = "IdPublisherBox";
            this.IdPublisherBox.Size = new System.Drawing.Size(142, 20);
            this.IdPublisherBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(998, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "IdPublisher*";
            // 
            // AddPublisher
            // 
            this.AddPublisher.Location = new System.Drawing.Point(9, 84);
            this.AddPublisher.Name = "AddPublisher";
            this.AddPublisher.Size = new System.Drawing.Size(87, 23);
            this.AddPublisher.TabIndex = 22;
            this.AddPublisher.Text = "Add Publisher";
            this.AddPublisher.UseVisualStyleBackColor = true;
            this.AddPublisher.Click += new System.EventHandler(this.AddPublisher_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "PublisherName";
            // 
            // PublisherNameBox
            // 
            this.PublisherNameBox.Location = new System.Drawing.Point(193, 91);
            this.PublisherNameBox.Name = "PublisherNameBox";
            this.PublisherNameBox.Size = new System.Drawing.Size(244, 20);
            this.PublisherNameBox.TabIndex = 24;
            // 
            // AdresBox
            // 
            this.AdresBox.Location = new System.Drawing.Point(503, 94);
            this.AdresBox.Name = "AdresBox";
            this.AdresBox.Size = new System.Drawing.Size(244, 20);
            this.AdresBox.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(463, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Adres";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(9, 19);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(87, 23);
            this.Delete.TabIndex = 27;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // TableForDeleteComboBox
            // 
            this.TableForDeleteComboBox.FormattingEnabled = true;
            this.TableForDeleteComboBox.Items.AddRange(new object[] {
            "Author",
            "Book",
            "Publisher"});
            this.TableForDeleteComboBox.Location = new System.Drawing.Point(115, 19);
            this.TableForDeleteComboBox.Name = "TableForDeleteComboBox";
            this.TableForDeleteComboBox.Size = new System.Drawing.Size(158, 21);
            this.TableForDeleteComboBox.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Id*";
            // 
            // IdForDeleteBox
            // 
            this.IdForDeleteBox.Location = new System.Drawing.Point(319, 19);
            this.IdForDeleteBox.Name = "IdForDeleteBox";
            this.IdForDeleteBox.Size = new System.Drawing.Size(48, 20);
            this.IdForDeleteBox.TabIndex = 29;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1220, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.FirstNameBox);
            this.groupBox1.Controls.Add(this.AddAuthor);
            this.groupBox1.Controls.Add(this.LastNameBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.AdresBox);
            this.groupBox1.Controls.Add(this.AddBook);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PublisherNameBox);
            this.groupBox1.Controls.Add(this.TitleBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AddPublisher);
            this.groupBox1.Controls.Add(this.IdAuthorBox);
            this.groupBox1.Controls.Add(this.IdPublisherBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.PagesBox);
            this.groupBox1.Controls.Add(this.PriceBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(0, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1220, 132);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(9, 44);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(87, 23);
            this.Edit.TabIndex = 33;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // TableForEditComboBox
            // 
            this.TableForEditComboBox.FormattingEnabled = true;
            this.TableForEditComboBox.Items.AddRange(new object[] {
            "Author",
            "Book",
            "Publisher"});
            this.TableForEditComboBox.Location = new System.Drawing.Point(115, 45);
            this.TableForEditComboBox.Name = "TableForEditComboBox";
            this.TableForEditComboBox.Size = new System.Drawing.Size(158, 21);
            this.TableForEditComboBox.TabIndex = 34;
            this.TableForEditComboBox.SelectedIndexChanged += new System.EventHandler(this.TableForEditComboBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Id*";
            // 
            // IdForEditBox
            // 
            this.IdForEditBox.Location = new System.Drawing.Point(319, 46);
            this.IdForEditBox.Name = "IdForEditBox";
            this.IdForEditBox.Size = new System.Drawing.Size(48, 20);
            this.IdForEditBox.TabIndex = 35;
            // 
            // ColumnForEditComboBox
            // 
            this.ColumnForEditComboBox.FormattingEnabled = true;
            this.ColumnForEditComboBox.Location = new System.Drawing.Point(383, 45);
            this.ColumnForEditComboBox.Name = "ColumnForEditComboBox";
            this.ColumnForEditComboBox.Size = new System.Drawing.Size(158, 21);
            this.ColumnForEditComboBox.TabIndex = 37;
            // 
            // NewValueBox
            // 
            this.NewValueBox.Location = new System.Drawing.Point(675, 46);
            this.NewValueBox.Name = "NewValueBox";
            this.NewValueBox.Size = new System.Drawing.Size(170, 20);
            this.NewValueBox.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(611, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "New value*";
            // 
            // FilterValue
            // 
            this.FilterValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FilterValue.Location = new System.Drawing.Point(342, 22);
            this.FilterValue.Name = "FilterValue";
            this.FilterValue.Size = new System.Drawing.Size(123, 20);
            this.FilterValue.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(303, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "value";
            // 
            // Surch
            // 
            this.Surch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Surch.Location = new System.Drawing.Point(4, 20);
            this.Surch.Name = "Surch";
            this.Surch.Size = new System.Drawing.Size(87, 23);
            this.Surch.TabIndex = 44;
            this.Surch.Text = "Surch book";
            this.Surch.UseVisualStyleBackColor = true;
            this.Surch.Click += new System.EventHandler(this.Surch_Click);
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "Title",
            "IdAuthor",
            "IdPublisher"});
            this.FilterComboBox.Location = new System.Drawing.Point(116, 21);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(158, 21);
            this.FilterComboBox.TabIndex = 46;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.Delete);
            this.groupBox2.Controls.Add(this.TableForDeleteComboBox);
            this.groupBox2.Controls.Add(this.IdForDeleteBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Edit);
            this.groupBox2.Controls.Add(this.TableForEditComboBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.IdForEditBox);
            this.groupBox2.Controls.Add(this.NewValueBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.ColumnForEditComboBox);
            this.groupBox2.Location = new System.Drawing.Point(0, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1220, 76);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete && Edit";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.Surch);
            this.groupBox3.Controls.Add(this.FilterValue);
            this.groupBox3.Controls.Add(this.FilterComboBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(12, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(642, 49);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Book filter";
            // 
            // FloppaStyle
            // 
            this.FloppaStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FloppaStyle.Image = global::EntityFramework.Properties.Resources.maxresdefault;
            this.FloppaStyle.Location = new System.Drawing.Point(660, 310);
            this.FloppaStyle.Name = "FloppaStyle";
            this.FloppaStyle.Size = new System.Drawing.Size(554, 246);
            this.FloppaStyle.TabIndex = 49;
            this.FloppaStyle.UseVisualStyleBackColor = true;
            this.FloppaStyle.Click += new System.EventHandler(this.FloppaStyle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 566);
            this.Controls.Add(this.FloppaStyle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ShowPublishers);
            this.Controls.Add(this.ShowBooks);
            this.Controls.Add(this.ShowAuthors);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Book shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ShowAuthors;
        private System.Windows.Forms.Button ShowBooks;
        private System.Windows.Forms.Button ShowPublishers;
        private System.Windows.Forms.Button AddAuthor;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox IdAuthorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PagesBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdPublisherBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddPublisher;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PublisherNameBox;
        private System.Windows.Forms.TextBox AdresBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ComboBox TableForDeleteComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IdForDeleteBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.ComboBox TableForEditComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox IdForEditBox;
        private System.Windows.Forms.ComboBox ColumnForEditComboBox;
        private System.Windows.Forms.TextBox NewValueBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox FilterValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Surch;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button FloppaStyle;
    }
}

