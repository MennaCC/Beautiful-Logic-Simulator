namespace Decent_Custom_Logic_Simulator.FrontEnd
{
    partial class Input_Front
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


            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShapeInner = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShapeOuter = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.nodeFront4 = new Node_Front();

            this.SuspendLayout();
            //
            // nodeFront4
            //
            this.nodeFront4.Location = new System.Drawing.Point(37, 23);
            this.nodeFront4.Name = "nodeFront4";
            this.nodeFront4.Size = new System.Drawing.Size(7, 7);
            this.nodeFront4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rectangleShapeMouseDowmn);
            this.nodeFront4.BringToFront();
            this.nodeFront4.TabIndex = 0;
            //
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1,
            this.ovalShapeInner,
            this.ovalShapeOuter});
            this.shapeContainer1.Size = new System.Drawing.Size(107, 109);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.SystemColors.Control;
            this.rectangleShape1.Enabled = false;
            this.rectangleShape1.FillColor = System.Drawing.Color.LightGray;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(35, 21);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(10, 10);
            this.rectangleShape1.MouseHover += new System.EventHandler(this.rectangleShape1_MouseHover);
            this.rectangleShape1.SendToBack();
            // 
            // ovalShapeInner
            // 
            this.ovalShapeInner.BackColor = System.Drawing.Color.Gainsboro;
            this.ovalShapeInner.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShapeInner.Location = new System.Drawing.Point(8, 13);
            this.ovalShapeInner.Name = "ovalShapeInner";
            this.ovalShapeInner.Size = new System.Drawing.Size(25, 25);
            this.ovalShapeInner.Click += new System.EventHandler(this.ovalShapeInner_Click);
            // 
            // ovalShapeOuter
            // 
            this.ovalShapeOuter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ovalShapeOuter.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShapeOuter.Location = new System.Drawing.Point(5, 10);
            this.ovalShapeOuter.Name = "ovalShapeOuter";
            this.ovalShapeOuter.Size = new System.Drawing.Size(30, 30);
            this.ovalShapeOuter.Click += new System.EventHandler(this.ovalShapeInner_Click);
            // 
            // Input_Front
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nodeFront4);
            this.Controls.Add(this.shapeContainer1);


            this.Name = "Input_Front";
            this.Size = new System.Drawing.Size(50, 50);

            this.ResumeLayout(false);
        }

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShapeOuter;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShapeInner;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Node_Front nodeFront4;


        #endregion

    }
}
