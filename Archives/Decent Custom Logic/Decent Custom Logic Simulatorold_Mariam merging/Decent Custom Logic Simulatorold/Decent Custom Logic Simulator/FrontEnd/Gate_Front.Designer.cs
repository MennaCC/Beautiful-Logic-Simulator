namespace Decent_Custom_Logic_Simulator.FrontEnd
{
    partial class Gate_Front
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape6 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.SuspendLayout();
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape4,
            this.rectangleShape5,
            this.rectangleShape6});
            this.shapeContainer2.Size = new System.Drawing.Size(150, 150);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // rectangleShape4
            // 
            this.rectangleShape4.BorderColor = System.Drawing.SystemColors.Control;
            this.rectangleShape4.FillColor = System.Drawing.Color.SpringGreen;
            this.rectangleShape4.FillGradientColor = System.Drawing.Color.MediumSpringGreen;
            this.rectangleShape4.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central;
            this.rectangleShape4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape4.Location = new System.Drawing.Point(100, 35);
            this.rectangleShape4.Name = "rectangleShape4";
            this.rectangleShape4.Size = new System.Drawing.Size(14, 15);
            this.rectangleShape4.Click += new System.EventHandler(this.rectangleShape4_Click);
            this.rectangleShape4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangleShape4_MouseClick);
            // 
            // rectangleShape5
            // 
            this.rectangleShape5.BorderColor = System.Drawing.SystemColors.Control;
            this.rectangleShape5.FillColor = System.Drawing.Color.Crimson;
            this.rectangleShape5.FillGradientColor = System.Drawing.Color.DeepPink;
            this.rectangleShape5.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central;
            this.rectangleShape5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape5.Location = new System.Drawing.Point(-1, 10);
            this.rectangleShape5.Name = "rectangleShape5";
            this.rectangleShape5.Size = new System.Drawing.Size(14, 15);
            this.rectangleShape5.Click += new System.EventHandler(this.rectangleShape5_Click);
            // 
            // rectangleShape6
            // 
            this.rectangleShape6.BorderColor = System.Drawing.SystemColors.Control;
            this.rectangleShape6.FillColor = System.Drawing.Color.Crimson;
            this.rectangleShape6.FillGradientColor = System.Drawing.Color.DeepPink;
            this.rectangleShape6.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central;
            this.rectangleShape6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape6.Location = new System.Drawing.Point(-1, 50);
            this.rectangleShape6.Name = "rectangleShape6";
            this.rectangleShape6.Size = new System.Drawing.Size(14, 15);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
         //   this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Gate_Front
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.shapeContainer2);
            this.Name = "Gate_Front";
            this.SetBounds(0, 0, 120, 79);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OurUserControl_MouseMove);
         //   this.Paint += new System.Windows.Forms.PaintEventHandler(this.createGateDueToType);
          //  this.Paint += new System.Windows.Forms.PaintEventHandler(this.createGateDueToType);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape6;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape5;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;

        #endregion
    }
}
