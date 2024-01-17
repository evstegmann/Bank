namespace Bank
{
    partial class FormRegisterAccount
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            numberText = new System.Windows.Forms.TextBox();
            titleText = new System.Windows.Forms.TextBox();
            registerButton = new System.Windows.Forms.Button();
            typeCombo = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(27, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(27, 62);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // numberText
            // 
            numberText.Location = new System.Drawing.Point(128, 30);
            numberText.Name = "numberText";
            numberText.Size = new System.Drawing.Size(121, 23);
            numberText.TabIndex = 2;
            // 
            // titleText
            // 
            titleText.Location = new System.Drawing.Point(128, 59);
            titleText.Name = "titleText";
            titleText.Size = new System.Drawing.Size(121, 23);
            titleText.TabIndex = 3;
            // 
            // registerButton
            // 
            registerButton.Location = new System.Drawing.Point(128, 142);
            registerButton.Name = "registerButton";
            registerButton.Size = new System.Drawing.Size(75, 22);
            registerButton.TabIndex = 4;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // typeCombo
            // 
            typeCombo.FormattingEnabled = true;
            typeCombo.Location = new System.Drawing.Point(128, 90);
            typeCombo.Name = "typeCombo";
            typeCombo.Size = new System.Drawing.Size(121, 23);
            typeCombo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(27, 93);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 15);
            label3.TabIndex = 6;
            label3.Text = "Account Type";
            // 
            // FormRegisterAccount
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(264, 176);
            Controls.Add(label3);
            Controls.Add(typeCombo);
            Controls.Add(registerButton);
            Controls.Add(titleText);
            Controls.Add(numberText);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegisterAccount";
            Text = "FormRegisterAccount";
            Load += FormRegisterAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberText;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.Label label3;
    }
}