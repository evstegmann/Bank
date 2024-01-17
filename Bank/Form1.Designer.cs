namespace Bank
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleText = new System.Windows.Forms.TextBox();
            balanceText = new System.Windows.Forms.TextBox();
            numberText = new System.Windows.Forms.TextBox();
            valueText = new System.Windows.Forms.TextBox();
            depositButton = new System.Windows.Forms.Button();
            withdrawButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            searchTitleButton = new System.Windows.Forms.Button();
            searchTitleText = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            accountCombo = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            transferButton = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            transferCombo = new System.Windows.Forms.ComboBox();
            newAccountButton = new System.Windows.Forms.Button();
            taxableButton = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // titleText
            // 
            titleText.Location = new System.Drawing.Point(164, 22);
            titleText.Name = "titleText";
            titleText.Size = new System.Drawing.Size(121, 23);
            titleText.TabIndex = 0;
            // 
            // balanceText
            // 
            balanceText.Location = new System.Drawing.Point(164, 57);
            balanceText.Name = "balanceText";
            balanceText.Size = new System.Drawing.Size(121, 23);
            balanceText.TabIndex = 1;
            // 
            // numberText
            // 
            numberText.Location = new System.Drawing.Point(164, 93);
            numberText.Name = "numberText";
            numberText.Size = new System.Drawing.Size(121, 23);
            numberText.TabIndex = 2;
            // 
            // valueText
            // 
            valueText.Location = new System.Drawing.Point(164, 128);
            valueText.Name = "valueText";
            valueText.Size = new System.Drawing.Size(121, 23);
            valueText.TabIndex = 3;
            // 
            // depositButton
            // 
            depositButton.Location = new System.Drawing.Point(132, 170);
            depositButton.Name = "depositButton";
            depositButton.Size = new System.Drawing.Size(75, 23);
            depositButton.TabIndex = 4;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // withdrawButton
            // 
            withdrawButton.Location = new System.Drawing.Point(224, 170);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new System.Drawing.Size(75, 23);
            withdrawButton.TabIndex = 5;
            withdrawButton.Text = "Withdraw";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(49, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(29, 15);
            label1.TabIndex = 6;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(49, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 15);
            label2.TabIndex = 7;
            label2.Text = "Balance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(49, 98);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(49, 131);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(35, 15);
            label4.TabIndex = 9;
            label4.Text = "Value";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(titleText);
            groupBox1.Controls.Add(withdrawButton);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(depositButton);
            groupBox1.Controls.Add(balanceText);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numberText);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(valueText);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(22, 258);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(353, 214);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(searchTitleButton);
            groupBox2.Controls.Add(searchTitleText);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(accountCombo);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new System.Drawing.Point(22, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(353, 100);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search Account";
            // 
            // searchTitleButton
            // 
            searchTitleButton.Location = new System.Drawing.Point(266, 56);
            searchTitleButton.Name = "searchTitleButton";
            searchTitleButton.Size = new System.Drawing.Size(75, 23);
            searchTitleButton.TabIndex = 16;
            searchTitleButton.Text = "Search";
            searchTitleButton.UseVisualStyleBackColor = true;
            searchTitleButton.Click += searchTitleButton_Click;
            // 
            // searchTitleText
            // 
            searchTitleText.Location = new System.Drawing.Point(164, 56);
            searchTitleText.Name = "searchTitleText";
            searchTitleText.Size = new System.Drawing.Size(81, 23);
            searchTitleText.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(7, 59);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(85, 15);
            label7.TabIndex = 15;
            label7.Text = "Search for Title";
            // 
            // accountCombo
            // 
            accountCombo.FormattingEnabled = true;
            accountCombo.Location = new System.Drawing.Point(164, 24);
            accountCombo.Name = "accountCombo";
            accountCombo.Size = new System.Drawing.Size(177, 23);
            accountCombo.TabIndex = 14;
            accountCombo.SelectedIndexChanged += accountCombo_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(7, 27);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(115, 15);
            label5.TabIndex = 13;
            label5.Text = "Choose the Account";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(transferButton);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(transferCombo);
            groupBox3.Location = new System.Drawing.Point(22, 118);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(353, 122);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Transfer Account";
            // 
            // transferButton
            // 
            transferButton.Location = new System.Drawing.Point(164, 76);
            transferButton.Name = "transferButton";
            transferButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            transferButton.Size = new System.Drawing.Size(75, 23);
            transferButton.TabIndex = 15;
            transferButton.Text = "Transfer";
            transferButton.UseVisualStyleBackColor = true;
            transferButton.Click += transferButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(7, 39);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(138, 15);
            label6.TabIndex = 14;
            label6.Text = "Account Destiny Transfer";
            // 
            // transferCombo
            // 
            transferCombo.FormattingEnabled = true;
            transferCombo.Location = new System.Drawing.Point(163, 36);
            transferCombo.Name = "transferCombo";
            transferCombo.Size = new System.Drawing.Size(121, 23);
            transferCombo.TabIndex = 13;
            transferCombo.SelectedIndexChanged += transferCombo_SelectedIndexChanged;
            // 
            // newAccountButton
            // 
            newAccountButton.Location = new System.Drawing.Point(12, 484);
            newAccountButton.Name = "newAccountButton";
            newAccountButton.Size = new System.Drawing.Size(113, 23);
            newAccountButton.TabIndex = 13;
            newAccountButton.Text = "New Account";
            newAccountButton.UseVisualStyleBackColor = true;
            newAccountButton.Click += newAccountButton_Click;
            // 
            // taxableButton
            // 
            taxableButton.Location = new System.Drawing.Point(142, 484);
            taxableButton.Name = "taxableButton";
            taxableButton.Size = new System.Drawing.Size(113, 23);
            taxableButton.TabIndex = 14;
            taxableButton.Text = "Calculate Taxable";
            taxableButton.UseVisualStyleBackColor = true;
            taxableButton.Click += taxableButton_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(270, 484);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(113, 23);
            button1.TabIndex = 15;
            button1.Text = "Report";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(395, 519);
            Controls.Add(button1);
            Controls.Add(taxableButton);
            Controls.Add(newAccountButton);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox balanceText;
        private System.Windows.Forms.TextBox numberText;
        private System.Windows.Forms.TextBox valueText;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox accountCombo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox transferCombo;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.Button newAccountButton;
        private System.Windows.Forms.Button taxableButton;
        private System.Windows.Forms.TextBox searchTitleText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button searchTitleButton;
        private System.Windows.Forms.Button button1;
    }
}
