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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
		private void AddDirectories(TreeNode tnSubNode)
		{
			
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            /*AddDirectories(e.Node);
            treeView1.SelectedNode.Expand();
            // Thêm file vào listview
            AddFiles(e.Node.FullPath.ToString());
            statusBar1.Text = iDirectories.ToString() + " Thư mục(s)  " */+ iFiles.ToString() + " Tệp(s)";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

			DriveInfo[] drives = DriveInfo.GetDrives();
            
			foreach (DriveInfo d in drives)
            {
				cbbchon.Items.Add(d.Name);
            }
        }
    }
}
