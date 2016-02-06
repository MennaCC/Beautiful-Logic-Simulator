using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace LogicSimulatorGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {InitializeComponent();}

        private void button1_Click(object sender, EventArgs e){ }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e){ }
        private void toolStripButton10_MouseHover(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e){ }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e){ }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e){ }

        private void knowMoreAboutGatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpFile hf = new HelpFile();
            hf.Show();
            String line;
            String file = "Helpfile.txt";
            StreamReader myFile = new StreamReader();
            while(myFile.EndOfStream==false){
                line = myFile.ReadLine();
                Console.WriteLine(line);
                Console.ReadLine();
            }
            myFile.Close();
        }

        private void aNDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        } }

