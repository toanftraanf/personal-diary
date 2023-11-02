namespace PersonalDiary
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
            label1 = new Label();
            btnSignin = new Button();
            panel4 = new Panel();
            label4 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            txtPassword = new TextBox();
            panel3 = new Panel();
            button2 = new Button();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(-19, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(273, 96);
            label1.TabIndex = 1;
            label1.Text = "Sign in";
            // 
            // btnSignin
            // 
            btnSignin.BackColor = Color.DarkGray;
            btnSignin.FlatAppearance.BorderSize = 0;
            btnSignin.FlatStyle = FlatStyle.Flat;
            btnSignin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignin.ForeColor = Color.FromArgb(40, 40, 40);
            btnSignin.Location = new Point(4, 476);
            btnSignin.Margin = new Padding(4, 5, 4, 5);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(457, 60);
            btnSignin.TabIndex = 3;
            btnSignin.Text = "Sign in";
            btnSignin.UseVisualStyleBackColor = false;
            btnSignin.Click += btnSignin_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txtUsername);
            panel4.Location = new Point(4, 142);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(457, 97);
            panel4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(-10, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(163, 45);
            label4.TabIndex = 5;
            label4.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.DimGray;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Dock = DockStyle.Bottom;
            txtUsername.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(0, 59);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(457, 38);
            txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(123, 558);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 28);
            label2.TabIndex = 8;
            label2.Text = "No account?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(253, 558);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 28);
            label5.TabIndex = 4;
            label5.Text = "Sign up";
            label5.Click += label5_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSignin);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(35, 98);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 673);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtPassword);
            panel2.Location = new Point(4, 302);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(457, 97);
            panel2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(-10, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(153, 45);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.DimGray;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Dock = DockStyle.Bottom;
            txtPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(0, 59);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(457, 38);
            txtPassword.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(539, 48);
            panel3.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(40, 40, 40);
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.DimGray;
            button2.Location = new Point(486, 0);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(53, 48);
            button2.TabIndex = 5;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(539, 843);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.CodeDom.CodeTypeReference guna2AnimateWindow1;
        private Label label1;
        private Button btnSignin;
        private Panel panel4;
        private Label label4;
        private TextBox txtUsername;
        private Label label2;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private TextBox txtPassword;
        private Panel panel3;
        private Button button2;
    }
}