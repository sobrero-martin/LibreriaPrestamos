namespace LibreriaPrestamos.FE
{
    partial class MainMenu
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
            this.btLoans = new System.Windows.Forms.Button();
            this.btBooks = new System.Windows.Forms.Button();
            this.btReaders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLoans
            // 
            this.btLoans.Location = new System.Drawing.Point(494, 326);
            this.btLoans.Name = "btLoans";
            this.btLoans.Size = new System.Drawing.Size(128, 46);
            this.btLoans.TabIndex = 5;
            this.btLoans.Text = "Loans";
            this.btLoans.UseVisualStyleBackColor = true;
            this.btLoans.Click += new System.EventHandler(this.btLoans_Click);
            // 
            // btBooks
            // 
            this.btBooks.Location = new System.Drawing.Point(335, 326);
            this.btBooks.Name = "btBooks";
            this.btBooks.Size = new System.Drawing.Size(128, 46);
            this.btBooks.TabIndex = 4;
            this.btBooks.Text = "Books";
            this.btBooks.UseVisualStyleBackColor = true;
            this.btBooks.Click += new System.EventHandler(this.btBooks_Click);
            // 
            // btReaders
            // 
            this.btReaders.Location = new System.Drawing.Point(172, 326);
            this.btReaders.Name = "btReaders";
            this.btReaders.Size = new System.Drawing.Size(128, 46);
            this.btReaders.TabIndex = 3;
            this.btReaders.Text = "Readers";
            this.btReaders.UseVisualStyleBackColor = true;
            this.btReaders.Click += new System.EventHandler(this.btReaders_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLoans);
            this.Controls.Add(this.btBooks);
            this.Controls.Add(this.btReaders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLoans;
        private System.Windows.Forms.Button btBooks;
        private System.Windows.Forms.Button btReaders;
    }
}