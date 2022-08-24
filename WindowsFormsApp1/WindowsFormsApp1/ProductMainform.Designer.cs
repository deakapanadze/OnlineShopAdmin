namespace WindowsFormsApp1
{
	partial class ProductMainform
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
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("პროდუქტი");
			this.treeView_ProducrGroup = new System.Windows.Forms.TreeView();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_edit = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.txt_node = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// treeView_ProducrGroup
			// 
			this.treeView_ProducrGroup.Location = new System.Drawing.Point(12, 35);
			this.treeView_ProducrGroup.Name = "treeView_ProducrGroup";
			treeNode2.Name = "Node0";
			treeNode2.Text = "პროდუქტი";
			this.treeView_ProducrGroup.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
			this.treeView_ProducrGroup.Size = new System.Drawing.Size(249, 500);
			this.treeView_ProducrGroup.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(267, 35);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(761, 500);
			this.dataGridView1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(267, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(364, 6);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(456, 6);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "button2";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(953, 6);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(12, 6);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(51, 23);
			this.btn_Save.TabIndex = 5;
			this.btn_Save.Text = "button5";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// btn_edit
			// 
			this.btn_edit.Location = new System.Drawing.Point(69, 6);
			this.btn_edit.Name = "btn_edit";
			this.btn_edit.Size = new System.Drawing.Size(61, 23);
			this.btn_edit.TabIndex = 6;
			this.btn_edit.Text = "button6";
			this.btn_edit.UseVisualStyleBackColor = true;
			this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(137, 6);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(64, 23);
			this.btn_delete.TabIndex = 7;
			this.btn_delete.Text = "button7";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// txt_node
			// 
			this.txt_node.Location = new System.Drawing.Point(557, 6);
			this.txt_node.Name = "txt_node";
			this.txt_node.Size = new System.Drawing.Size(100, 22);
			this.txt_node.TabIndex = 8;
			// 
			// ProductMainform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1040, 547);
			this.Controls.Add(this.txt_node);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_edit);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.treeView_ProducrGroup);
			this.Name = "ProductMainform";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView treeView_ProducrGroup;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.Button btn_edit;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.TextBox txt_node;
	}
}

