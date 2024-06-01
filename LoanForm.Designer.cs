namespace ClientLoanSystem
{
    partial class LoanForm
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
            this.components = new System.ComponentModel.Container();
            this.currentClientLabel = new System.Windows.Forms.Label();
            this.loanTable = new System.Windows.Forms.DataGridView();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paidBtn = new System.Windows.Forms.Button();
            this.addLoanBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loanTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // currentClientLabel
            // 
            this.currentClientLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.currentClientLabel.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentClientLabel.Location = new System.Drawing.Point(0, 0);
            this.currentClientLabel.Name = "currentClientLabel";
            this.currentClientLabel.Size = new System.Drawing.Size(1041, 56);
            this.currentClientLabel.TabIndex = 0;
            this.currentClientLabel.Text = "Loan of Client ID";
            this.currentClientLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.currentClientLabel.Click += new System.EventHandler(this.currentClientLabel_Click);
            // 
            // loanTable
            // 
            this.loanTable.AllowUserToAddRows = false;
            this.loanTable.AllowUserToDeleteRows = false;
            this.loanTable.AutoGenerateColumns = false;
            this.loanTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loanTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.loanTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loanTable.DataSource = this.loanBindingSource;
            this.loanTable.Location = new System.Drawing.Point(16, 59);
            this.loanTable.Name = "loanTable";
            this.loanTable.ReadOnly = true;
            this.loanTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loanTable.Size = new System.Drawing.Size(1013, 207);
            this.loanTable.TabIndex = 1;
            this.loanTable.SelectionChanged += new System.EventHandler(this.loanTable_SelectionChanged);
            // 
            // paidBtn
            // 
            this.paidBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.paidBtn.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidBtn.Location = new System.Drawing.Point(439, 272);
            this.paidBtn.Name = "paidBtn";
            this.paidBtn.Size = new System.Drawing.Size(85, 53);
            this.paidBtn.TabIndex = 4;
            this.paidBtn.Text = "PAID";
            this.paidBtn.UseVisualStyleBackColor = false;
            this.paidBtn.Click += new System.EventHandler(this.paidBtn_Click);
            // 
            // addLoanBtn
            // 
            this.addLoanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addLoanBtn.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLoanBtn.Location = new System.Drawing.Point(530, 272);
            this.addLoanBtn.Name = "addLoanBtn";
            this.addLoanBtn.Size = new System.Drawing.Size(84, 53);
            this.addLoanBtn.TabIndex = 5;
            this.addLoanBtn.Text = "ADD LOAN";
            this.addLoanBtn.UseVisualStyleBackColor = false;
            this.addLoanBtn.Click += new System.EventHandler(this.addLoanBtn_Click);
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 332);
            this.Controls.Add(this.addLoanBtn);
            this.Controls.Add(this.paidBtn);
            this.Controls.Add(this.loanTable);
            this.Controls.Add(this.currentClientLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1057, 371);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1057, 371);
            this.Name = "LoanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoanForm";
            this.Load += new System.EventHandler(this.LoanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loanTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label currentClientLabel;
        private System.Windows.Forms.DataGridView loanTable;
        private System.Windows.Forms.Button paidBtn;
        private System.Windows.Forms.Button addLoanBtn;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestedAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivableAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPayableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPaidDataGridViewTextBoxColumn;
    }
}