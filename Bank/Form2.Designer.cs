namespace Bank
{
    partial class Form2
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
            txtTitle = new System.Windows.Forms.TextBox();
            txtBalance = new System.Windows.Forms.TextBox();
            txtNumber = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtValue = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            btnDeposit = new System.Windows.Forms.Button();
            btnWithdraw = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new System.Drawing.Point(147, 19);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(100, 23);
            txtTitle.TabIndex = 0;
            // 
            // txtBalance
            // 
            txtBalance.Location = new System.Drawing.Point(147, 61);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new System.Drawing.Size(100, 23);
            txtBalance.TabIndex = 1;
            // 
            // txtNumber
            // 
            txtNumber.Location = new System.Drawing.Point(147, 104);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new System.Drawing.Size(100, 23);
            txtNumber.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(46, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Titular";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(46, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Saldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(46, 107);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Número";
            // 
            // txtValue
            // 
            txtValue.Location = new System.Drawing.Point(147, 147);
            txtValue.Name = "txtValue";
            txtValue.Size = new System.Drawing.Size(100, 23);
            txtValue.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(46, 150);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(33, 15);
            label4.TabIndex = 7;
            label4.Text = "Valor";
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new System.Drawing.Point(36, 209);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new System.Drawing.Size(75, 23);
            btnDeposit.TabIndex = 8;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new System.Drawing.Point(157, 209);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new System.Drawing.Size(75, 23);
            btnWithdraw.TabIndex = 9;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(293, 263);
            Controls.Add(btnWithdraw);
            Controls.Add(btnDeposit);
            Controls.Add(label4);
            Controls.Add(txtValue);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumber);
            Controls.Add(txtBalance);
            Controls.Add(txtTitle);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
    }
}