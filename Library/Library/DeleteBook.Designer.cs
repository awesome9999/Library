namespace Library
{
    partial class DeleteBook
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
            this.lb_BookName = new System.Windows.Forms.ListBox();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_BookName
            // 
            this.lb_BookName.FormattingEnabled = true;
            this.lb_BookName.ItemHeight = 16;
            this.lb_BookName.Location = new System.Drawing.Point(12, 12);
            this.lb_BookName.Name = "lb_BookName";
            this.lb_BookName.Size = new System.Drawing.Size(129, 180);
            this.lb_BookName.TabIndex = 0;
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(180, 13);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 1;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(108, 204);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(94, 39);
            this.bt_ok.TabIndex = 2;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // DeleteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.lb_BookName);
            this.Name = "DeleteBook";
            this.Text = "DeleteBook";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_BookName;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_ok;
    }
}