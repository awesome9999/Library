namespace Library
{
    partial class Core
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
            this.bt_addBook = new System.Windows.Forms.Button();
            this.bt_addUser = new System.Windows.Forms.Button();
            this.bt_borrow = new System.Windows.Forms.Button();
            this.bt_deleteBook = new System.Windows.Forms.Button();
            this.bt_deleteUser = new System.Windows.Forms.Button();
            this.bt_showBorrowed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_addBook
            // 
            this.bt_addBook.Location = new System.Drawing.Point(12, 12);
            this.bt_addBook.Name = "bt_addBook";
            this.bt_addBook.Size = new System.Drawing.Size(109, 27);
            this.bt_addBook.TabIndex = 0;
            this.bt_addBook.Text = "Add Book";
            this.bt_addBook.UseVisualStyleBackColor = true;
            this.bt_addBook.Click += new System.EventHandler(this.bt_addBook_Click);
            // 
            // bt_addUser
            // 
            this.bt_addUser.Location = new System.Drawing.Point(13, 46);
            this.bt_addUser.Name = "bt_addUser";
            this.bt_addUser.Size = new System.Drawing.Size(108, 28);
            this.bt_addUser.TabIndex = 1;
            this.bt_addUser.Text = "Add User";
            this.bt_addUser.UseVisualStyleBackColor = true;
            this.bt_addUser.Click += new System.EventHandler(this.bt_addUser_Click);
            // 
            // bt_borrow
            // 
            this.bt_borrow.Location = new System.Drawing.Point(13, 80);
            this.bt_borrow.Name = "bt_borrow";
            this.bt_borrow.Size = new System.Drawing.Size(108, 29);
            this.bt_borrow.TabIndex = 2;
            this.bt_borrow.Text = "Borrow book";
            this.bt_borrow.UseVisualStyleBackColor = true;
            this.bt_borrow.Click += new System.EventHandler(this.bt_borrow_Click);
            // 
            // bt_deleteBook
            // 
            this.bt_deleteBook.Location = new System.Drawing.Point(174, 12);
            this.bt_deleteBook.Name = "bt_deleteBook";
            this.bt_deleteBook.Size = new System.Drawing.Size(118, 27);
            this.bt_deleteBook.TabIndex = 3;
            this.bt_deleteBook.Text = "Delete Book";
            this.bt_deleteBook.UseVisualStyleBackColor = true;
            this.bt_deleteBook.Click += new System.EventHandler(this.bt_deleteBook_Click);
            // 
            // bt_deleteUser
            // 
            this.bt_deleteUser.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.bt_deleteUser.Location = new System.Drawing.Point(174, 46);
            this.bt_deleteUser.Name = "bt_deleteUser";
            this.bt_deleteUser.Size = new System.Drawing.Size(118, 28);
            this.bt_deleteUser.TabIndex = 4;
            this.bt_deleteUser.Text = "Delete User";
            this.bt_deleteUser.UseVisualStyleBackColor = true;
            this.bt_deleteUser.Click += new System.EventHandler(this.bt_deleteUser_Click);
            // 
            // bt_showBorrowed
            // 
            this.bt_showBorrowed.Location = new System.Drawing.Point(12, 192);
            this.bt_showBorrowed.Name = "bt_showBorrowed";
            this.bt_showBorrowed.Size = new System.Drawing.Size(129, 35);
            this.bt_showBorrowed.TabIndex = 5;
            this.bt_showBorrowed.Text = "Show borrowed";
            this.bt_showBorrowed.UseVisualStyleBackColor = true;
            this.bt_showBorrowed.Click += new System.EventHandler(this.bt_showBorrowed_Click);
            // 
            // Core
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 239);
            this.Controls.Add(this.bt_showBorrowed);
            this.Controls.Add(this.bt_deleteUser);
            this.Controls.Add(this.bt_deleteBook);
            this.Controls.Add(this.bt_borrow);
            this.Controls.Add(this.bt_addUser);
            this.Controls.Add(this.bt_addBook);
            this.Name = "Core";
            this.RightToLeftLayout = true;
            this.Text = "Core";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Core_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_addBook;
        private System.Windows.Forms.Button bt_addUser;
        private System.Windows.Forms.Button bt_borrow;
        private System.Windows.Forms.Button bt_deleteBook;
        private System.Windows.Forms.Button bt_deleteUser;
        private System.Windows.Forms.Button bt_showBorrowed;
    }
}