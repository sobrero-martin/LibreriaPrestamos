namespace LibreriaPrestamos.FE
{
    partial class EditLoans
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
            this.txtReaderDNI = new System.Windows.Forms.TextBox();
            this.lblReaderDNI = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.txtBookISBN = new System.Windows.Forms.TextBox();
            this.lblBookISBN = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.btTruncate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // txtReaderDNI
            // 
            this.txtReaderDNI.Location = new System.Drawing.Point(571, 89);
            this.txtReaderDNI.Name = "txtReaderDNI";
            this.txtReaderDNI.Size = new System.Drawing.Size(100, 20);
            this.txtReaderDNI.TabIndex = 34;
            // 
            // lblReaderDNI
            // 
            this.lblReaderDNI.AutoSize = true;
            this.lblReaderDNI.Location = new System.Drawing.Point(500, 93);
            this.lblReaderDNI.Name = "lblReaderDNI";
            this.lblReaderDNI.Size = new System.Drawing.Size(67, 13);
            this.lblReaderDNI.TabIndex = 33;
            this.lblReaderDNI.Text = "Reader DNI:";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(206, 91);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(68, 13);
            this.lblReturnDate.TabIndex = 31;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(1, 1);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 30;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(700, 143);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 29;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(700, 114);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 28;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(700, 85);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(75, 23);
            this.btInsert.TabIndex = 25;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(56, 85);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 24;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(18, 88);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 13);
            this.lblCode.TabIndex = 23;
            this.lblCode.Text = "Code:";
            // 
            // dgvLoans
            // 
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Location = new System.Drawing.Point(181, 169);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.Size = new System.Drawing.Size(415, 242);
            this.dgvLoans.TabIndex = 22;
            // 
            // txtBookISBN
            // 
            this.txtBookISBN.Location = new System.Drawing.Point(571, 116);
            this.txtBookISBN.Name = "txtBookISBN";
            this.txtBookISBN.Size = new System.Drawing.Size(100, 20);
            this.txtBookISBN.TabIndex = 36;
            // 
            // lblBookISBN
            // 
            this.lblBookISBN.AutoSize = true;
            this.lblBookISBN.Location = new System.Drawing.Point(500, 120);
            this.lblBookISBN.Name = "lblBookISBN";
            this.lblBookISBN.Size = new System.Drawing.Size(63, 13);
            this.lblBookISBN.TabIndex = 35;
            this.lblBookISBN.Text = "Book ISBN:";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(280, 88);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(188, 20);
            this.dtpReturnDate.TabIndex = 37;
            // 
            // btTruncate
            // 
            this.btTruncate.Location = new System.Drawing.Point(700, 172);
            this.btTruncate.Name = "btTruncate";
            this.btTruncate.Size = new System.Drawing.Size(75, 23);
            this.btTruncate.TabIndex = 38;
            this.btTruncate.Text = "Truncate";
            this.btTruncate.UseVisualStyleBackColor = true;
            this.btTruncate.Click += new System.EventHandler(this.btTruncate_Click);
            // 
            // EditLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btTruncate);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.txtBookISBN);
            this.Controls.Add(this.lblBookISBN);
            this.Controls.Add(this.txtReaderDNI);
            this.Controls.Add(this.lblReaderDNI);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.dgvLoans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditLoans";
            this.Text = "EditLoans";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReaderDNI;
        private System.Windows.Forms.Label lblReaderDNI;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.TextBox txtBookISBN;
        private System.Windows.Forms.Label lblBookISBN;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Button btTruncate;
    }
}