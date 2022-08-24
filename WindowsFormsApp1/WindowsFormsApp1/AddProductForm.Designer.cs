
namespace WindowsFormsApp1
{
	partial class AddProductForm
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
			this.txt_code = new System.Windows.Forms.TextBox();
			this.txt_price = new System.Windows.Forms.TextBox();
			this.cmb_Country = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.txt_ProductName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txt_code
			// 
			this.txt_code.Location = new System.Drawing.Point(139, 47);
			this.txt_code.Name = "txt_code";
			this.txt_code.Size = new System.Drawing.Size(268, 22);
			this.txt_code.TabIndex = 0;
			// 
			// txt_price
			// 
			this.txt_price.Location = new System.Drawing.Point(139, 117);
			this.txt_price.Name = "txt_price";
			this.txt_price.Size = new System.Drawing.Size(268, 22);
			this.txt_price.TabIndex = 2;
			// 
			// cmb_Country
			// 
			this.cmb_Country.FormattingEnabled = true;
			this.cmb_Country.Location = new System.Drawing.Point(139, 162);
			this.cmb_Country.Name = "cmb_Country";
			this.cmb_Country.Size = new System.Drawing.Size(268, 24);
			this.cmb_Country.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "კოდი";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "დასახელება";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "ფასი";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "ქვეყანა";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 236);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 17);
			this.label5.TabIndex = 8;
			this.label5.Text = "თარიღიდან";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(239, 236);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 17);
			this.label6.TabIndex = 9;
			this.label6.Text = "თარიღამდე";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(75, 236);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(142, 22);
			this.dateTimePicker1.TabIndex = 10;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(292, 235);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker2.TabIndex = 11;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.SeaGreen;
			this.button1.Location = new System.Drawing.Point(12, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 33);
			this.button1.TabIndex = 12;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Firebrick;
			this.button2.Location = new System.Drawing.Point(113, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 33);
			this.button2.TabIndex = 13;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// txt_ProductName
			// 
			this.txt_ProductName.Location = new System.Drawing.Point(139, 79);
			this.txt_ProductName.Name = "txt_ProductName";
			this.txt_ProductName.Size = new System.Drawing.Size(268, 22);
			this.txt_ProductName.TabIndex = 0;
			// 
			// AddProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 291);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmb_Country);
			this.Controls.Add(this.txt_price);
			this.Controls.Add(this.txt_ProductName);
			this.Controls.Add(this.txt_code);
			this.Name = "AddProductForm";
			this.Text = "AddProduct";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_code;
		private System.Windows.Forms.TextBox txt_price;
		private System.Windows.Forms.ComboBox cmb_Country;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txt_ProductName;
	}
}