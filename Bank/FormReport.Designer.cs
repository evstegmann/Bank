namespace Bank
{
    partial class FormReport
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
            listResult = new System.Windows.Forms.ListBox();
            resultButton = new System.Windows.Forms.Button();
            olderButton = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            labelBiggestBalance = new System.Windows.Forms.Label();
            labelTotalBalance = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listResult
            // 
            listResult.FormattingEnabled = true;
            listResult.ItemHeight = 15;
            listResult.Location = new System.Drawing.Point(12, 12);
            listResult.Name = "listResult";
            listResult.Size = new System.Drawing.Size(234, 139);
            listResult.TabIndex = 0;
            // 
            // resultButton
            // 
            resultButton.Location = new System.Drawing.Point(12, 303);
            resultButton.Name = "resultButton";
            resultButton.Size = new System.Drawing.Size(151, 23);
            resultButton.TabIndex = 1;
            resultButton.Text = "Balance more than 5000";
            resultButton.UseVisualStyleBackColor = true;
            resultButton.Click += resultButton_Click;
            // 
            // olderButton
            // 
            olderButton.Location = new System.Drawing.Point(171, 303);
            olderButton.Name = "olderButton";
            olderButton.Size = new System.Drawing.Size(75, 23);
            olderButton.TabIndex = 2;
            olderButton.Text = "Older";
            olderButton.UseVisualStyleBackColor = true;
            olderButton.Click += olderButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelBiggestBalance);
            groupBox1.Controls.Add(labelTotalBalance);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(12, 171);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(233, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Summary";
            // 
            // labelBiggestBalance
            // 
            labelBiggestBalance.AutoSize = true;
            labelBiggestBalance.Location = new System.Drawing.Point(122, 62);
            labelBiggestBalance.Name = "labelBiggestBalance";
            labelBiggestBalance.Size = new System.Drawing.Size(112, 15);
            labelBiggestBalance.TabIndex = 3;
            labelBiggestBalance.Text = "labelBiggestBalance";
            // 
            // labelTotalBalance
            // 
            labelTotalBalance.AutoSize = true;
            labelTotalBalance.Location = new System.Drawing.Point(122, 28);
            labelTotalBalance.Name = "labelTotalBalance";
            labelTotalBalance.Size = new System.Drawing.Size(98, 15);
            labelTotalBalance.TabIndex = 2;
            labelTotalBalance.Text = "labelTotalBalance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(0, 62);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Biggest Balance";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(0, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Total Balance";
            // 
            // FormReport
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(257, 338);
            Controls.Add(groupBox1);
            Controls.Add(olderButton);
            Controls.Add(resultButton);
            Controls.Add(listResult);
            Name = "FormReport";
            Text = "FormReport";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Button olderButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelBiggestBalance;
        private System.Windows.Forms.Label labelTotalBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}