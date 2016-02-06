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
                this.OR = new System.Windows.Forms.Button();
                this.NOT = new System.Windows.Forms.Button();
                this.AND = new System.Windows.Forms.Button();
                this.NAND = new System.Windows.Forms.Button();
                this.LED = new System.Windows.Forms.Button();
                this.Switch = new System.Windows.Forms.Button();
                this.toolStrip1 = new System.Windows.Forms.ToolStrip();
                this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
                this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
                this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
                this.textBoxLocation = new System.Windows.Forms.TextBox();
                this.textBoxLocationEnd = new System.Windows.Forms.TextBox();
                this.toolStrip1.SuspendLayout();
                this.flowLayoutPanel1.SuspendLayout();
                this.SuspendLayout();
                // 
                // OR
                // 
                this.OR.BackColor = System.Drawing.Color.White;
                this.OR.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                this.OR.FlatAppearance.BorderSize = 2;
                this.OR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Thistle;
                this.OR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
                this.OR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
                this.OR.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F);
                this.OR.ForeColor = System.Drawing.Color.RosyBrown;
                this.OR.Location = new System.Drawing.Point(3, 115);
                this.OR.Name = "OR";
                this.OR.Size = new System.Drawing.Size(156, 50);
                this.OR.TabIndex = 0;
                this.OR.Text = "OR Gate";
                this.OR.UseVisualStyleBackColor = false;
                this.OR.Click += new System.EventHandler(this.buttonGate_Click);
                // 
                // NOT
                // 
                this.NOT.BackColor = System.Drawing.Color.White;
                this.NOT.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                this.NOT.FlatAppearance.BorderSize = 2;
                this.NOT.FlatAppearance.CheckedBackColor = System.Drawing.Color.Thistle;
                this.NOT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
                this.NOT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
                this.NOT.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F);
                this.NOT.ForeColor = System.Drawing.Color.RosyBrown;
                this.NOT.Location = new System.Drawing.Point(3, 171);
                this.NOT.Name = "NOT";
                this.NOT.Size = new System.Drawing.Size(156, 50);
                this.NOT.TabIndex = 1;
                this.NOT.Text = "NOT Gate";
                this.NOT.UseVisualStyleBackColor = false;
                this.NOT.Click += new System.EventHandler(this.buttonGate_Click);
                // 
                // AND
                // 
                this.AND.BackColor = System.Drawing.Color.White;
                this.AND.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                this.AND.FlatAppearance.BorderSize = 2;
                this.AND.FlatAppearance.CheckedBackColor = System.Drawing.Color.Thistle;
                this.AND.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
                this.AND.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
                this.AND.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F);
                this.AND.ForeColor = System.Drawing.Color.RosyBrown;
                this.AND.Location = new System.Drawing.Point(3, 227);
                this.AND.Name = "AND";
                this.AND.Size = new System.Drawing.Size(156, 50);
                this.AND.TabIndex = 2;
                this.AND.Text = "AND Gate";
                this.AND.UseVisualStyleBackColor = false;
                this.AND.Click += new System.EventHandler(this.buttonGate_Click);
                // 
                // NAND
                // 
                this.NAND.BackColor = System.Drawing.Color.White;
                this.NAND.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                this.NAND.FlatAppearance.BorderSize = 2;
                this.NAND.FlatAppearance.CheckedBackColor = System.Drawing.Color.Thistle;
                this.NAND.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
                this.NAND.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
                this.NAND.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F);
                this.NAND.ForeColor = System.Drawing.Color.RosyBrown;
                this.NAND.Location = new System.Drawing.Point(3, 283);
                this.NAND.Name = "NAND";
                this.NAND.Size = new System.Drawing.Size(156, 50);
                this.NAND.TabIndex = 3;
                this.NAND.Text = "NAND Gate";
                this.NAND.UseVisualStyleBackColor = false;
                this.NAND.Click += new System.EventHandler(this.buttonGate_Click);
                // 
                // LED
                // 
                this.LED.BackColor = System.Drawing.Color.White;
                this.LED.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                this.LED.FlatAppearance.BorderSize = 2;
                this.LED.FlatAppearance.CheckedBackColor = System.Drawing.Color.Thistle;
                this.LED.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
                this.LED.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
                this.LED.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F);
                this.LED.ForeColor = System.Drawing.Color.RosyBrown;
                this.LED.Location = new System.Drawing.Point(3, 3);
                this.LED.Name = "LED";
                this.LED.Size = new System.Drawing.Size(156, 50);
                this.LED.TabIndex = 4;
                this.LED.Text = "LED";
                this.LED.UseVisualStyleBackColor = false;
                this.LED.Click += new System.EventHandler(this.LED_Click);
                // 
                // Switch
                // 
                this.Switch.BackColor = System.Drawing.Color.White;
                this.Switch.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                this.Switch.FlatAppearance.BorderSize = 2;
                this.Switch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Thistle;
                this.Switch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
                this.Switch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
                this.Switch.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F);
                this.Switch.ForeColor = System.Drawing.Color.RosyBrown;
                this.Switch.Location = new System.Drawing.Point(3, 59);
                this.Switch.Name = "Switch";
                this.Switch.Size = new System.Drawing.Size(156, 50);
                this.Switch.TabIndex = 5;
                this.Switch.Text = "Switch";
                this.Switch.UseVisualStyleBackColor = false;
                this.Switch.Click += new System.EventHandler(this.Switch_Click);
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
                // flowLayoutPanel1
                // 
                this.flowLayoutPanel1.Controls.Add(this.LED);
                this.flowLayoutPanel1.Controls.Add(this.Switch);
                this.flowLayoutPanel1.Controls.Add(this.OR);
                this.flowLayoutPanel1.Controls.Add(this.NOT);
                this.flowLayoutPanel1.Controls.Add(this.AND);
                this.flowLayoutPanel1.Controls.Add(this.NAND);
                this.flowLayoutPanel1.Location = new System.Drawing.Point(624, 67);
                this.flowLayoutPanel1.Name = "flowLayoutPanel1";
                this.flowLayoutPanel1.Size = new System.Drawing.Size(179, 347);
                this.flowLayoutPanel1.TabIndex = 8;
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
                // Form1
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.MintCream;
                this.ClientSize = new System.Drawing.Size(815, 468);
                this.Controls.Add(this.textBoxLocationEnd);
                this.Controls.Add(this.textBoxLocation);
                this.Controls.Add(this.flowLayoutPanel1);
                this.Controls.Add(this.toolStrip1);
                this.Cursor = System.Windows.Forms.Cursors.Default;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Name = "Form1";
                this.Text = " ";
                this.Load += new System.EventHandler(this.Form1_Load);
                this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
                this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
                this.toolStrip1.ResumeLayout(false);
                this.toolStrip1.PerformLayout();
                this.flowLayoutPanel1.ResumeLayout(false);
                this.ResumeLayout(false);
                this.PerformLayout();

            }

            private System.Windows.Forms.Button OR;
            private System.Windows.Forms.Button NOT;
            private System.Windows.Forms.Button AND;
            private System.Windows.Forms.Button NAND;
            private System.Windows.Forms.Button LED;
            private System.Windows.Forms.Button Switch;
            private System.Windows.Forms.ToolStrip toolStrip1;
            private System.Windows.Forms.ToolStripButton toolStripButton1;
            private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            #endregion

            private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
            public System.Windows.Forms.TextBox textBoxLocation;
            public System.Windows.Forms.TextBox textBoxLocationEnd;
        }
    }

