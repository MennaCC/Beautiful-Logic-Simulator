﻿using Decent_Custom_Logic_Simulator.FrontEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decent_Custom_Logic_Simulator
{
    public partial class Form1 : Form
    {
        #region Singleton
        private static Form1 instance;
        private Form1()
        {
            InitializeComponent();
        }

        public static Form1 getInstance()
        {
            if(instance == null)
            {
                instance = new Form1();
            }
            return instance;
        }
        #endregion

        private Point startPoint, endPoint;

         #region Methods that Work with frontEnd 
        
        public void DrawOnForm(Point start, customControl SenderCntrl)
        {
            this.startPoint.X = start.X + SenderCntrl.Location.X;
            this.startPoint.Y = start.Y + SenderCntrl.Location.Y;
            String txt = startPoint.X.ToString() + " " + startPoint.Y.ToString();
            Form1.getInstance().textBoxLocation.Text = txt;

        }
        
        private void buttonGate_Click(object sender, EventArgs e)
        {
            //<summary>
            //// creates Gate_front object that creates a Gate object of type suitable to the name of the button
            //// for example a button Named "OR" will create an OR gate and call its draw function
            //// also that class is responsible for handling interactions with the gate object from the front end.
            //</summary>
            
            Gate_Front newGate = new Gate_Front(ActiveControl.Name);
            this.Controls.Add(newGate);
        }

        private void Switch_Click(object sender, EventArgs e)
        {
            Input_Front s = new Input_Front();
            this.Controls.Add(s);
        }
        #endregion 

        private void LED_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(SystemPens.ControlText, startPoint, endPoint);
        }
        public void DrawWire(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && startPoint != null)
                endPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string txt = e.X.ToString() + " " + e.Y.ToString();
            textBoxLocationEnd.Text = txt;
            DrawWire(e);
            //Microsoft.VisualBasic.PowerPacks.RectangleShape rec;

        }

        private void toolStripSaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName == null)
                {
                    // Need to select an album file
                    //menuSaveAs_Click(sender, e);
                }
             else
             {
                // Save the album in the current file
                //_album.Save();
                //_bAlbumChanged = false;
            }
        }

        private void toolStripOpenButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if(openFileDialog1.FileName != null)
            {
                //Import the circuit
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
