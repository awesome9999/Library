namespace Library
{
    partial class BorrowBook
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
            this.lb_Book = new System.Windows.Forms.ListBox();
            this.lb_User = new System.Windows.Forms.ListBox();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_People = new System.Windows.Forms.ListBox();
            this.bt_borrow = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Book
            // 
            this.lb_Book.FormattingEnabled = true;
            this.lb_Book.ItemHeight = 16;
            this.lb_Book.Location = new System.Drawing.Point(12, 12);
            this.lb_Book.Name = "lb_Book";
            this.lb_Book.Size = new System.Drawing.Size(161, 404);
            this.lb_Book.TabIndex = 0;
            // 
            // lb_User
            // 
            this.lb_User.FormattingEnabled = true;
            this.lb_User.ItemHeight = 16;
            this.lb_User.Location = new System.Drawing.Point(179, 12);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(166, 404);
            this.lb_User.TabIndex = 1;
            // 
            // dtp_to
            // 
            this.dtp_to.Location = new System.Drawing.Point(680, 113);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(200, 22);
            this.dtp_to.TabIndex = 2;
            // 
            // dtp_from
            // 
            this.dtp_from.Location = new System.Drawing.Point(680, 74);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(200, 22);
            this.dtp_from.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "To:";
            // 
            // lb_People
            // 
            this.lb_People.FormattingEnabled = true;
            this.lb_People.ItemHeight = 16;
            this.lb_People.Location = new System.Drawing.Point(351, 12);
            this.lb_People.Name = "lb_People";
            this.lb_People.Size = new System.Drawing.Size(163, 404);
            this.lb_People.TabIndex = 6;
            // 
            // bt_borrow
            // 
            this.bt_borrow.Location = new System.Drawing.Point(12, 460);
            this.bt_borrow.Name = "bt_borrow";
            this.bt_borrow.Size = new System.Drawing.Size(162, 61);
            this.bt_borrow.TabIndex = 7;
            this.bt_borrow.Text = "Borrow";
            this.bt_borrow.UseVisualStyleBackColor = true;
            this.bt_borrow.Click += new System.EventHandler(this.bt_borrow_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(780, 460);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(100, 61);
            this.bt_cancel.TabIndex = 8;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 533);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_borrow);
            this.Controls.Add(this.lb_People);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_from);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.lb_User);
            this.Controls.Add(this.lb_Book);
            this.Name = "BorrowBook";
            this.Text = "BorrowBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Book;
        private System.Windows.Forms.ListBox lb_User;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_People;
        private System.Windows.Forms.Button bt_borrow;
        private System.Windows.Forms.Button bt_cancel;
    }
}