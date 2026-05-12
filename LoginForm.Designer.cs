namespace FormOptions
{
    partial class LoginForm
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
            btnChangeStyles = new Button();
            label1 = new Label();
            lbQuestion = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label11 = new Label();
            label12 = new Label();
            btnVissiblePassword = new Button();
            btnToLogin = new Button();
            btnCheck = new Button();
            btnRestoreRequest = new Button();
            SuspendLayout();
            // 
            // btnChangeStyles
            // 
            btnChangeStyles.BackColor = Color.White;
            btnChangeStyles.FlatAppearance.BorderSize = 0;
            btnChangeStyles.FlatStyle = FlatStyle.Flat;
            btnChangeStyles.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnChangeStyles.Location = new Point(648, 5);
            btnChangeStyles.Name = "btnChangeStyles";
            btnChangeStyles.Size = new Size(85, 35);
            btnChangeStyles.TabIndex = 0;
            btnChangeStyles.Text = "Темна";
            btnChangeStyles.UseVisualStyleBackColor = false;
            btnChangeStyles.Click += btnChangeStyles_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(580, 11);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 2;
            label1.Text = "ТЕМА :";
            // 
            // lbQuestion
            // 
            lbQuestion.AutoSize = true;
            lbQuestion.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lbQuestion.ForeColor = Color.Black;
            lbQuestion.Location = new Point(289, 5);
            lbQuestion.Name = "lbQuestion";
            lbQuestion.Size = new Size(185, 28);
            lbQuestion.TabIndex = 3;
            lbQuestion.Text = "Вхід у застосунок";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(35, 66);
            label5.Name = "label5";
            label5.Size = new Size(76, 28);
            label5.TabIndex = 3;
            label5.Text = "Пошта";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtEmail.Location = new Point(35, 106);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 33);
            txtEmail.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(404, 68);
            label6.Name = "label6";
            label6.Size = new Size(85, 28);
            label6.TabIndex = 3;
            label6.Text = "Пароль";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPassword.Location = new Point(404, 110);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 32);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnLogin.Location = new Point(138, 223);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(116, 43);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Вхід";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(35, 145);
            label11.Name = "label11";
            label11.Size = new Size(159, 20);
            label11.TabIndex = 3;
            label11.Tag = "error";
            label11.Text = "Вкажіть вашу пошту";
            label11.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(404, 145);
            label12.Name = "label12";
            label12.Size = new Size(157, 20);
            label12.TabIndex = 3;
            label12.Tag = "error";
            label12.Text = "Вкажіть ваш пароль";
            label12.Visible = false;
            // 
            // btnVissiblePassword
            // 
            btnVissiblePassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnVissiblePassword.Location = new Point(683, 109);
            btnVissiblePassword.Margin = new Padding(3, 2, 3, 2);
            btnVissiblePassword.Name = "btnVissiblePassword";
            btnVissiblePassword.Size = new Size(29, 29);
            btnVissiblePassword.TabIndex = 6;
            btnVissiblePassword.Text = "👁️";
            btnVissiblePassword.UseVisualStyleBackColor = true;
            btnVissiblePassword.Click += btnVissiblePassword_Click;
            // 
            // btnToLogin
            // 
            btnToLogin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnToLogin.Location = new Point(4, 5);
            btnToLogin.Margin = new Padding(3, 2, 3, 2);
            btnToLogin.Name = "btnToLogin";
            btnToLogin.Size = new Size(174, 35);
            btnToLogin.TabIndex = 7;
            btnToLogin.Text = "Перейти до реєстрації";
            btnToLogin.UseVisualStyleBackColor = true;
            btnToLogin.Click += btnToLogin_Click;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCheck.Location = new Point(289, 223);
            btnCheck.Margin = new Padding(3, 2, 3, 2);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(105, 43);
            btnCheck.TabIndex = 7;
            btnCheck.Text = "Перевірка";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnRestoreRequest
            // 
            btnRestoreRequest.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnRestoreRequest.ForeColor = Color.DarkBlue;
            btnRestoreRequest.Location = new Point(421, 223);
            btnRestoreRequest.Margin = new Padding(3, 2, 3, 2);
            btnRestoreRequest.Name = "btnRestoreRequest";
            btnRestoreRequest.Size = new Size(164, 43);
            btnRestoreRequest.TabIndex = 5;
            btnRestoreRequest.Text = "Відновити пароль";
            btnRestoreRequest.UseVisualStyleBackColor = true;
            btnRestoreRequest.Click += btnRestoreRequest_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(746, 296);
            Controls.Add(btnCheck);
            Controls.Add(btnToLogin);
            Controls.Add(btnVissiblePassword);
            Controls.Add(btnRestoreRequest);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(lbQuestion);
            Controls.Add(label1);
            Controls.Add(btnChangeStyles);
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "Реєстрація користувача";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChangeStyles;
        private Label label1;
        private Label lbQuestion;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label11;
        private Label label12;
        private Button btnVissiblePassword;
        private Button btnToLogin;
        private Button btnCheck;
        private Button btnRestoreRequest;
    }
}
