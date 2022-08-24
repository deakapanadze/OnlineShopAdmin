using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class ProductMainform : Form
	{
		public ProductMainform()
		{
			InitializeComponent();
		}


		private void Createnode(TreeView view, string Text, string type)
		{
			TreeNode node = new TreeNode(Text);

			if (type == "A")
			{
				try
				{
					view.SelectedNode.Nodes.Add(node);
				}catch (Exception ex)
				{
					view.Nodes.Add(node);
				}

		}	else if(type == "E"){
				view.SelectedNode.Text = "Text";
			}
			else
			{
				view.SelectedNode.Remove();
			}
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			
			Createnode(treeView_ProducrGroup, txt_node.Text, "A");
		}

		private void btn_edit_Click(object sender, EventArgs e)
		{
			Createnode(treeView_ProducrGroup, txt_node.Text, "E");

		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("ნამდვილად გსურთ წაშლა", "dea", MessageBoxButtons.YesNo);

			try
			{
				if (result == DialogResult.Yes)
				{
					Createnode(treeView_ProducrGroup, txt_node.Text, "D");
				}
				else
				{
					update();
				}

			}catch (Exception ex)
			{
				
			}


		}

		private void update()
		{
			Application.Run(new ProductMainform());
		}

	}
}
