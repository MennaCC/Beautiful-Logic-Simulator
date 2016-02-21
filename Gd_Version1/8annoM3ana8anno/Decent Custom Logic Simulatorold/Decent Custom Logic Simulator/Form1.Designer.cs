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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpenButton = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxLocationEnd = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.output_Front1 = new Decent_Custom_Logic_Simulator.FrontEnd.Output_Front();
            this.input_Front2 = new Decent_Custom_Logic_Simulator.FrontEnd.Input_Front();
            this.input_Front1 = new Decent_Custom_Logic_Simulator.FrontEnd.Input_Front();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AND = new Decent_Custom_Logic_Simulator.FrontEnd.customControl();
            this.label1 = new System.Windows.Forms.Label();
            this.NAND = new Decent_Custom_Logic_Simulator.FrontEnd.customControl();
            this.label2 = new System.Windows.Forms.Label();
            this.OR = new Decent_Custom_Logic_Simulator.FrontEnd.customControl();
            this.label3 = new System.Windows.Forms.Label();
            this.NOR = new Decent_Custom_Logic_Simulator.FrontEnd.customControl();
            this.label4 = new System.Windows.Forms.Label();
            this.XOR = new Decent_Custom_Logic_Simulator.FrontEnd.customControl();
            this.label5 = new System.Windows.Forms.Label();
            this.XNOR = new Decent_Custom_Logic_Simulator.FrontEnd.customControl();
            this.label6 = new System.Windows.Forms.Label();
            this.NOT = new Decent_Custom_Logic_Simulator.FrontEnd.customControl();
            this.label7 = new System.Windows.Forms.Label();
            this.INPUT = new Decent_Custom_Logic_Simulator.FrontEnd.customControl();
            this.label8 = new System.Windows.Forms.Label();
            this.OUTPUT = new Decent_Custom_Logic_Simulator.FrontEnd.customControl();
            this.label9 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.AND.SuspendLayout();
            this.NAND.SuspendLayout();
            this.OR.SuspendLayout();
            this.NOR.SuspendLayout();
            this.XOR.SuspendLayout();
            this.XNOR.SuspendLayout();
            this.NOT.SuspendLayout();
            this.INPUT.SuspendLayout();
            this.OUTPUT.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSaveButton,
            this.toolStripOpenButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(809, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "Menu";
            // 
            // toolStripSaveButton
            // 
            this.toolStripSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveButton.Image")));
            this.toolStripSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveButton.Name = "toolStripSaveButton";
            this.toolStripSaveButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripSaveButton.Text = "Save";
            this.toolStripSaveButton.Click += new System.EventHandler(this.toolStripSaveButton_Click);
            // 
            // toolStripOpenButton
            // 
            this.toolStripOpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpenButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpenButton.Image")));
            this.toolStripOpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpenButton.Name = "toolStripOpenButton";
            this.toolStripOpenButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripOpenButton.Text = "Open";
            this.toolStripOpenButton.Click += new System.EventHandler(this.toolStripOpenButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(450, 375);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(100, 20);
            this.textBoxLocation.TabIndex = 11;
            this.textBoxLocation.TextChanged += new System.EventHandler(this.textBoxLocation_TextChanged);
            // 
            // textBoxLocationEnd
            // 
            this.textBoxLocationEnd.Location = new System.Drawing.Point(556, 375);
            this.textBoxLocationEnd.Name = "textBoxLocationEnd";
            this.textBoxLocationEnd.Size = new System.Drawing.Size(100, 20);
            this.textBoxLocationEnd.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.output_Front1);
            this.panel2.Controls.Add(this.input_Front2);
            this.panel2.Controls.Add(this.input_Front1);
            this.panel2.Controls.Add(this.textBoxLocation);
            this.panel2.Controls.Add(this.textBoxLocationEnd);
            this.panel2.Location = new System.Drawing.Point(153, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 402);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // output_Front1
            // 
            this.output_Front1.BackColor = System.Drawing.Color.Snow;
            this.output_Front1.Location = new System.Drawing.Point(432, 79);
            this.output_Front1.Name = "output_Front1";
            this.output_Front1.Size = new System.Drawing.Size(50, 50);
            this.output_Front1.TabIndex = 15;
            // 
            // input_Front2
            // 
            this.input_Front2.BackColor = System.Drawing.Color.Snow;
            this.input_Front2.Location = new System.Drawing.Point(231, 120);
            this.input_Front2.Name = "input_Front2";
            this.input_Front2.Size = new System.Drawing.Size(50, 50);
            this.input_Front2.TabIndex = 14;
            // 
            // input_Front1
            // 
            this.input_Front1.BackColor = System.Drawing.Color.Snow;
            this.input_Front1.Location = new System.Drawing.Point(231, 31);
            this.input_Front1.Name = "input_Front1";
            this.input_Front1.Size = new System.Drawing.Size(50, 50);
            this.input_Front1.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.AND);
            this.flowLayoutPanel1.Controls.Add(this.NAND);
            this.flowLayoutPanel1.Controls.Add(this.OR);
            this.flowLayoutPanel1.Controls.Add(this.NOR);
            this.flowLayoutPanel1.Controls.Add(this.XOR);
            this.flowLayoutPanel1.Controls.Add(this.XNOR);
            this.flowLayoutPanel1.Controls.Add(this.NOT);
            this.flowLayoutPanel1.Controls.Add(this.INPUT);
            this.flowLayoutPanel1.Controls.Add(this.OUTPUT);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(135, 402);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // AND
            // 
            this.AND.BackColor = System.Drawing.Color.AliceBlue;
            this.AND.Controls.Add(this.label1);
            this.AND.Location = new System.Drawing.Point(3, 3);
            this.AND.Name = "AND";
            this.AND.Size = new System.Drawing.Size(50, 79);
            this.AND.TabIndex = 0;
            this.AND.Text = "AND";
            this.AND.Paint += new System.Windows.Forms.PaintEventHandler(this.customControlAND_Paint);
            this.AND.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gate_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 5.5F);
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 11);
            this.label1.TabIndex = 0;
            this.label1.Text = "AND";
            // 
            // NAND
            // 
            this.NAND.BackColor = System.Drawing.Color.AliceBlue;
            this.NAND.Controls.Add(this.label2);
            this.NAND.Location = new System.Drawing.Point(59, 3);
            this.NAND.Name = "NAND";
            this.NAND.Size = new System.Drawing.Size(50, 79);
            this.NAND.TabIndex = 1;
            this.NAND.Text = "NAND";
            this.NAND.Paint += new System.Windows.Forms.PaintEventHandler(this.customControlNAND_Paint);
            this.NAND.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gate_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 5.5F);
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 11);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAND";
            // 
            // OR
            // 
            this.OR.BackColor = System.Drawing.Color.AliceBlue;
            this.OR.Controls.Add(this.label3);
            this.OR.Location = new System.Drawing.Point(3, 88);
            this.OR.Name = "OR";
            this.OR.Size = new System.Drawing.Size(50, 79);
            this.OR.TabIndex = 6;
            this.OR.Text = "OR";
            this.OR.Paint += new System.Windows.Forms.PaintEventHandler(this.customControlOR_Paint);
            this.OR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gate_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 5.5F);
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 11);
            this.label3.TabIndex = 2;
            this.label3.Text = "OR";
            // 
            // NOR
            // 
            this.NOR.BackColor = System.Drawing.Color.AliceBlue;
            this.NOR.Controls.Add(this.label4);
            this.NOR.Location = new System.Drawing.Point(59, 88);
            this.NOR.Name = "NOR";
            this.NOR.Size = new System.Drawing.Size(50, 79);
            this.NOR.TabIndex = 5;
            this.NOR.Text = "NOR";
            this.NOR.Paint += new System.Windows.Forms.PaintEventHandler(this.customControlNOR_Paint);
            this.NOR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gate_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 5.5F);
            this.label4.Location = new System.Drawing.Point(13, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 11);
            this.label4.TabIndex = 3;
            this.label4.Text = "NOR";
            // 
            // XOR
            // 
            this.XOR.BackColor = System.Drawing.Color.AliceBlue;
            this.XOR.Controls.Add(this.label5);
            this.XOR.Location = new System.Drawing.Point(3, 173);
            this.XOR.Name = "XOR";
            this.XOR.Size = new System.Drawing.Size(50, 79);
            this.XOR.TabIndex = 4;
            this.XOR.Text = "XOR";
            this.XOR.Paint += new System.Windows.Forms.PaintEventHandler(this.customControlXOR_Paint);
            this.XOR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gate_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 5.5F);
            this.label5.Location = new System.Drawing.Point(16, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 11);
            this.label5.TabIndex = 4;
            this.label5.Text = "XOR";
            // 
            // XNOR
            // 
            this.XNOR.BackColor = System.Drawing.Color.AliceBlue;
            this.XNOR.Controls.Add(this.label6);
            this.XNOR.Location = new System.Drawing.Point(59, 173);
            this.XNOR.Name = "XNOR";
            this.XNOR.Size = new System.Drawing.Size(50, 79);
            this.XNOR.TabIndex = 3;
            this.XNOR.Text = "XNOR";
            this.XNOR.Paint += new System.Windows.Forms.PaintEventHandler(this.customControlXNOR_Paint);
            this.XNOR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gate_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 5.5F);
            this.label6.Location = new System.Drawing.Point(12, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 11);
            this.label6.TabIndex = 5;
            this.label6.Text = "XNOR";
            // 
            // NOT
            // 
            this.NOT.BackColor = System.Drawing.Color.AliceBlue;
            this.NOT.Controls.Add(this.label7);
            this.NOT.Location = new System.Drawing.Point(3, 258);
            this.NOT.Name = "NOT";
            this.NOT.Size = new System.Drawing.Size(50, 79);
            this.NOT.TabIndex = 2;
            this.NOT.Text = "NOT";
            this.NOT.Paint += new System.Windows.Forms.PaintEventHandler(this.customControlNOT_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tempus Sans ITC", 5.5F);
            this.label7.Location = new System.Drawing.Point(13, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 11);
            this.label7.TabIndex = 6;
            this.label7.Text = "NOT";
            // 
            // INPUT
            // 
            this.INPUT.BackColor = System.Drawing.Color.AliceBlue;
            this.INPUT.Controls.Add(this.label8);
            this.INPUT.Location = new System.Drawing.Point(59, 258);
            this.INPUT.Name = "INPUT";
            this.INPUT.Size = new System.Drawing.Size(50, 79);
            this.INPUT.TabIndex = 7;
            this.INPUT.Text = "customControl1";
            this.INPUT.Paint += new System.Windows.Forms.PaintEventHandler(this.INPUT_Paint);
            this.INPUT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.INPUT_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tempus Sans ITC", 5.5F);
            this.label8.Location = new System.Drawing.Point(13, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 11);
            this.label8.TabIndex = 7;
            this.label8.Text = "Switch";
            // 
            // OUTPUT
            // 
            this.OUTPUT.BackColor = System.Drawing.Color.AliceBlue;
            this.OUTPUT.Controls.Add(this.label9);
            this.OUTPUT.Location = new System.Drawing.Point(3, 343);
            this.OUTPUT.Name = "OUTPUT";
            this.OUTPUT.Size = new System.Drawing.Size(50, 79);
            this.OUTPUT.TabIndex = 8;
            this.OUTPUT.Text = "customControl2";
            this.OUTPUT.Paint += new System.Windows.Forms.PaintEventHandler(this.OUTPUT_Paint);
            this.OUTPUT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OUTPUT_MouseDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tempus Sans ITC", 5.5F);
            this.label9.Location = new System.Drawing.Point(16, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 11);
            this.label9.TabIndex = 8;
            this.label9.Text = "LED";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(809, 436);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = " ";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.AND.ResumeLayout(false);
            this.AND.PerformLayout();
            this.NAND.ResumeLayout(false);
            this.NAND.PerformLayout();
            this.OR.ResumeLayout(false);
            this.OR.PerformLayout();
            this.NOR.ResumeLayout(false);
            this.NOR.PerformLayout();
            this.XOR.ResumeLayout(false);
            this.XOR.PerformLayout();
            this.XNOR.ResumeLayout(false);
            this.XNOR.PerformLayout();
            this.NOT.ResumeLayout(false);
            this.NOT.PerformLayout();
            this.INPUT.ResumeLayout(false);
            this.INPUT.PerformLayout();
            this.OUTPUT.ResumeLayout(false);
            this.OUTPUT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }
            private System.Windows.Forms.ToolStrip toolStrip1;
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
            private System.Windows.Forms.SaveFileDialog saveFileDialog1;
            private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripSaveButton;
        private System.Windows.Forms.ToolStripButton toolStripOpenButton;
        private FrontEnd.customControl INPUT;
        private FrontEnd.customControl OUTPUT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private FrontEnd.Output_Front output_Front1;
        private FrontEnd.Input_Front input_Front2;
        private FrontEnd.Input_Front input_Front1;
    }
    }

