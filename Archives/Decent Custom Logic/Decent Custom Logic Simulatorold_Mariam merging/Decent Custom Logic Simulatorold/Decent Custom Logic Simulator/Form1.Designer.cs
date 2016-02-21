using System;

namespace Decent_Custom_Logic_Simulator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxLocationEnd = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AND = new Decent_Custom_Logic_Simulator.FrontEnd.customControl();
            this.NAND = new Decent_Custom_Logic_Simulator.FrontEnd.customControl();
            this.OR = new Decent_Custom_Logic_Simulator.FrontEnd.customControl();
            this.NOR = new Decent_Custom_Logic_Simulator.FrontEnd.customControl();
            this.XOR = new Decent_Custom_Logic_Simulator.FrontEnd.customControl();
            this.XNOR = new Decent_Custom_Logic_Simulator.FrontEnd.customControl();
            this.NOT = new Decent_Custom_Logic_Simulator.FrontEnd.customControl();
            this.toolStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(815, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(565, 436);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(100, 20);
            this.textBoxLocation.TabIndex = 11;
            // 
            // textBoxLocationEnd
            // 
            this.textBoxLocationEnd.Location = new System.Drawing.Point(683, 436);
            this.textBoxLocationEnd.Name = "textBoxLocationEnd";
            this.textBoxLocationEnd.Size = new System.Drawing.Size(100, 20);
            this.textBoxLocationEnd.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(276, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 402);
            this.panel2.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.AND);
            this.flowLayoutPanel1.Controls.Add(this.NAND);
            this.flowLayoutPanel1.Controls.Add(this.OR);
            this.flowLayoutPanel1.Controls.Add(this.NOR);
            this.flowLayoutPanel1.Controls.Add(this.XOR);
            this.flowLayoutPanel1.Controls.Add(this.XNOR);
            this.flowLayoutPanel1.Controls.Add(this.NOT);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(258, 402);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // AND
            // 
            this.AND.BackColor = System.Drawing.Color.Bisque;
            this.AND.Location = new System.Drawing.Point(3, 3);
            this.AND.Name = "AND";
            this.AND.Size = new System.Drawing.Size(120, 79);
            this.AND.TabIndex = 0;
            this.AND.Text = "customControl2";
            this.AND.Paint += new System.Windows.Forms.PaintEventHandler(this.customControl2_Paint);
            this.AND.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gate_MouseDown);
            // 
            // NAND
            // 
            this.NAND.BackColor = System.Drawing.Color.Bisque;
            this.NAND.Location = new System.Drawing.Point(129, 3);
            this.NAND.Name = "NAND";
            this.NAND.Size = new System.Drawing.Size(120, 79);
            this.NAND.TabIndex = 1;
            this.NAND.Text = "customControl3";
            this.NAND.Paint += new System.Windows.Forms.PaintEventHandler(this.customControl3_Paint);
            this.NAND.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gate_MouseDown);
            // 
            // OR
            // 
            this.OR.BackColor = System.Drawing.Color.Bisque;
            this.OR.Location = new System.Drawing.Point(3, 88);
            this.OR.Name = "OR";
            this.OR.Size = new System.Drawing.Size(120, 79);
            this.OR.TabIndex = 6;
            this.OR.Text = "customControl8";
            this.OR.Paint += new System.Windows.Forms.PaintEventHandler(this.customControl8_Paint);
            this.OR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gate_MouseDown);
            // 
            // NOR
            // 
            this.NOR.BackColor = System.Drawing.Color.Bisque;
            this.NOR.Location = new System.Drawing.Point(129, 88);
            this.NOR.Name = "NOR";
            this.NOR.Size = new System.Drawing.Size(120, 79);
            this.NOR.TabIndex = 5;
            this.NOR.Text = "customControl7";
            this.NOR.Paint += new System.Windows.Forms.PaintEventHandler(this.customControl7_Paint);
            this.NOR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gate_MouseDown);
            // 
            // XOR
            // 
            this.XOR.BackColor = System.Drawing.Color.Bisque;
            this.XOR.Location = new System.Drawing.Point(3, 173);
            this.XOR.Name = "XOR";
            this.XOR.Size = new System.Drawing.Size(120, 79);
            this.XOR.TabIndex = 4;
            this.XOR.Text = "customControl6";
            this.XOR.Paint += new System.Windows.Forms.PaintEventHandler(this.customControl6_Paint);
            this.XOR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gate_MouseDown);
            // 
            // XNOR
            // 
            this.XNOR.BackColor = System.Drawing.Color.Bisque;
            this.XNOR.Location = new System.Drawing.Point(129, 173);
            this.XNOR.Name = "XNOR";
            this.XNOR.Size = new System.Drawing.Size(120, 79);
            this.XNOR.TabIndex = 3;
            this.XNOR.Text = "customControl5";
            this.XNOR.Paint += new System.Windows.Forms.PaintEventHandler(this.customControl5_Paint);
            this.XNOR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gate_MouseDown);
            // 
            // NOT
            // 
            this.NOT.BackColor = System.Drawing.Color.Bisque;
            this.NOT.Location = new System.Drawing.Point(3, 258);
            this.NOT.Name = "NOT";
            this.NOT.Size = new System.Drawing.Size(120, 79);
            this.NOT.TabIndex = 2;
            this.NOT.Text = "customControl4";
            this.NOT.Paint += new System.Windows.Forms.PaintEventHandler(this.customControl4_Paint);
            this.NOT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gate_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(815, 468);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxLocationEnd);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = " ";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

            }
            private System.Windows.Forms.ToolStrip toolStrip1;
            private System.Windows.Forms.ToolStripButton toolStripButton1;
            #endregion

            private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
            public System.Windows.Forms.TextBox textBoxLocation;
            public System.Windows.Forms.TextBox textBoxLocationEnd;
            private System.Windows.Forms.Panel panel2;
            private FrontEnd.customControl OR;
            private FrontEnd.customControl NOR;
            private FrontEnd.customControl XOR;
            private FrontEnd.customControl XNOR;
            private FrontEnd.customControl NOT;
            private FrontEnd.customControl NAND;
            private FrontEnd.customControl AND;
            private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
    }

