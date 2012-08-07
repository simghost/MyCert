using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ChapterEOCEx1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] driveInfo = DriveInfo.GetDrives();

            foreach (DriveInfo item in driveInfo)
            {
                treeView1.Nodes.Add(item.Name);
            }

            String selectedText = treeView1.Nodes[0].Text;

            string[] directories = Directory.GetDirectories(selectedText);
            string[] files = Directory.GetFiles(selectedText);

            foreach (string item in directories)
            {
                treeView2.Nodes.Add(item);
            }

            foreach (string item in files)
            {
                treeView2.Nodes.Add(item);
            }


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            
        }
    }
}
