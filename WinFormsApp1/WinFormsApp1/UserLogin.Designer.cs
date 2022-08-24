namespace WinFormsApp1
{
	partial class UserLogin
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
			this.lbluserName = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.btnEnterLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbluserName
			// 
			this.lbluserName.AutoSize = true;
			this.lbluserName.Location = new System.Drawing.Point(44, 47);
			this.lbluserName.Name = "lbluserName";
			this.lbluserName.Size = new System.Drawing.Size(75, 20);
			this.lbluserName.TabIndex = 0;
			this.lbluserName.Text = "Username";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(44, 106);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(70, 20);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "Password";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(174, 47);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(208, 27);
			this.textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(174, 99);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(208, 27);
			this.textBox2.TabIndex = 4;
			// 
			// btnEnterLogin
			// 
			this.btnEnterLogin.Location = new System.Drawing.Point(330, 164);
			this.btnEnterLogin.Name = "btnEnterLogin";
			this.btnEnterLogin.Size = new System.Drawing.Size(121, 41);
			this.btnEnterLogin.TabIndex = 6;
			this.btnEnterLogin.Text = "Login";
			this.btnEnterLogin.UseVisualStyleBackColor = true;
			// 
			// UserLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(478, 225);
			this.Controls.Add(this.btnEnterLogin);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lbluserName);
			this.Name = "UserLogin";
			this.Text = "User Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbluserName;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button btnEnterLogin;
	}
}
