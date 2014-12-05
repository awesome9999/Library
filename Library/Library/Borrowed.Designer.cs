namespace Library
{
    partial class Borrowed
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
            this.lb_books = new System.Windows.Forms.ListBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.UserID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_userID = new System.Windows.Forms.Label();
            this.lbl_PeopleID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_books
            // 
            this.lb_books.FormattingEnabled = true;
            this.lb_books.ItemHeight = 16;
            this.lb_books.Location = new System.Drawing.Point(12, 12);
            this.lb_books.Name = "lb_books";
            this.lb_books.Size = new System.Drawing.Size(195, 372);
            this.lb_books.TabIndex = 0;
            this.lb_books.SelectedIndexChanged += new System.EventHandler(this.lb_books_SelectedIndexChanged);
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(365, 396);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(78, 30);
            this.bt_ok.TabIndex = 1;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Location = new System.Drawing.Point(235, 12);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(55, 17);
            this.UserID.TabIndex = 2;
            this.UserID.Text = "UserID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "PeopleID:";
            // 
            // lbl_userID
            // 
            this.lbl_userID.AutoSize = true;
            this.lbl_userID.Location = new System.Drawing.Point(323, 13);
            this.lbl_userID.Name = "lbl_userID";
            this.lbl_userID.Size = new System.Drawing.Size(16, 17);
            this.lbl_userID.TabIndex = 4;
            this.lbl_userID.Text = "0";
            // 
            // lbl_PeopleID
            // 
            this.lbl_PeopleID.AutoSize = true;
            this.lbl_PeopleID.Location = new System.Drawing.Point(323, 47);
            this.lbl_PeopleID.Name = "lbl_PeopleID";
            this.lbl_PeopleID.Size = new System.Drawing.Size(16, 17);
            this.lbl_PeopleID.TabIndex = 5;
            this.lbl_PeopleID.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "00.00.0000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "00.00.0000";
            // 
            // Borrowed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 438);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_PeopleID);
            this.Controls.Add(this.lbl_userID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.lb_books);
            this.Name = "Borrowed";
            this.Text = "Borrowed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_books;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_userID;
        private System.Windows.Forms.Label lbl_PeopleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}