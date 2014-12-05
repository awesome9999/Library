namespace Library
{
    partial class AddBook
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_BookName = new System.Windows.Forms.TextBox();
            this.tb_BookAuthor = new System.Windows.Forms.TextBox();
            this.num_BookCopy = new System.Windows.Forms.NumericUpDown();
            this.tb_isbn = new System.Windows.Forms.TextBox();
            this.cb_BookPublisher = new System.Windows.Forms.ComboBox();
            this.cb_BookCategory = new System.Windows.Forms.ComboBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_BookCopy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Publisher:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "ISBN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number of copy:";
            // 
            // tb_BookName
            // 
            this.tb_BookName.Location = new System.Drawing.Point(129, 26);
            this.tb_BookName.Name = "tb_BookName";
            this.tb_BookName.Size = new System.Drawing.Size(186, 22);
            this.tb_BookName.TabIndex = 6;
            // 
            // tb_BookAuthor
            // 
            this.tb_BookAuthor.Location = new System.Drawing.Point(129, 59);
            this.tb_BookAuthor.Name = "tb_BookAuthor";
            this.tb_BookAuthor.Size = new System.Drawing.Size(186, 22);
            this.tb_BookAuthor.TabIndex = 7;
            // 
            // num_BookCopy
            // 
            this.num_BookCopy.Location = new System.Drawing.Point(129, 193);
            this.num_BookCopy.Name = "num_BookCopy";
            this.num_BookCopy.Size = new System.Drawing.Size(46, 22);
            this.num_BookCopy.TabIndex = 8;
            // 
            // tb_isbn
            // 
            this.tb_isbn.Location = new System.Drawing.Point(129, 155);
            this.tb_isbn.Name = "tb_isbn";
            this.tb_isbn.Size = new System.Drawing.Size(186, 22);
            this.tb_isbn.TabIndex = 9;
            // 
            // cb_BookPublisher
            // 
            this.cb_BookPublisher.FormattingEnabled = true;
            this.cb_BookPublisher.Items.AddRange(new object[] {
            "Grada",
            "CompPub",
            "vydavatelstvi ano",
            "trotlik",
            "anicka",
            "jenicek",
            "marenka"});
            this.cb_BookPublisher.Location = new System.Drawing.Point(129, 91);
            this.cb_BookPublisher.Name = "cb_BookPublisher";
            this.cb_BookPublisher.Size = new System.Drawing.Size(121, 24);
            this.cb_BookPublisher.TabIndex = 10;
            // 
            // cb_BookCategory
            // 
            this.cb_BookCategory.FormattingEnabled = true;
            this.cb_BookCategory.Items.AddRange(new object[] {
            "Horor",
            "komedie",
            "beletrie",
            "novela",
            "basen",
            "drama"});
            this.cb_BookCategory.Location = new System.Drawing.Point(131, 124);
            this.cb_BookCategory.Name = "cb_BookCategory";
            this.cb_BookCategory.Size = new System.Drawing.Size(121, 24);
            this.cb_BookCategory.TabIndex = 11;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(12, 295);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 12;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(316, 295);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 13;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 330);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.cb_BookCategory);
            this.Controls.Add(this.cb_BookPublisher);
            this.Controls.Add(this.tb_isbn);
            this.Controls.Add(this.num_BookCopy);
            this.Controls.Add(this.tb_BookAuthor);
            this.Controls.Add(this.tb_BookName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBook";
            this.Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)(this.num_BookCopy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_BookName;
        private System.Windows.Forms.TextBox tb_BookAuthor;
        private System.Windows.Forms.NumericUpDown num_BookCopy;
        private System.Windows.Forms.TextBox tb_isbn;
        private System.Windows.Forms.ComboBox cb_BookPublisher;
        private System.Windows.Forms.ComboBox cb_BookCategory;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_cancel;
    }
}