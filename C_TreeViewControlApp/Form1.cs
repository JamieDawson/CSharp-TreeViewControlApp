using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_TreeViewControlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            treeView1.Nodes.Add("People");           
            treeView1.Nodes.Add("Animals");
            treeView1.Nodes[0].Nodes.Add("Jamie");
            treeView1.Nodes[0].Nodes.Add("Dan");
            treeView1.Nodes[0].Nodes.Add("Steve");
            treeView1.Nodes[0].Nodes.Add("Joe");
            treeView1.Nodes[1].Nodes.Add("Dog");
            treeView1.Nodes[1].Nodes.Add("Cat");
            treeView1.Nodes[1].Nodes[0].Nodes.Add("Spot");
        }

        //Removes what is checked
        private void button2_Click(object sender, EventArgs e)
        {
            RemoveChecked(treeView1.Nodes);
        }
        List<TreeNode> tnlist = new List<TreeNode>();
        void RemoveChecked(TreeNodeCollection tnc)
        {
            foreach (TreeNode tn in tnc)
                if (tn.Checked) tnlist.Add(tn);
                else if (tn.Nodes.Count != 0) RemoveChecked(tn.Nodes);
            foreach (TreeNode tn in tnlist)
                treeView1.Nodes.Remove(tn);
        }
    }
}
