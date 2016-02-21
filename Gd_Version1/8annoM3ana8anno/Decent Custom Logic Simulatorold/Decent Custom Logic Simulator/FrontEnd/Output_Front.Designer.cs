namespace Decent_Custom_Logic_Simulator.FrontEnd
{
    partial class Output_Front
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
            this.nodeFront5 = new Node_Front();
            this.SuspendLayout();
            // 
            // Node_Front5
            // 
            //this.nodeFront5.BorderColor = System.Drawing.SystemColors.Control;
            //this.nodeFront5.FillColor = System.Drawing.Color.Crimson;
            //this.nodeFront5.FillGradientColor = System.Drawing.Color.DeepPink;
            //this.nodeFront5.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central;
            //this.nodeFront5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.nodeFront5.Location = new System.Drawing.Point(2, 20);
            this.nodeFront5.Name = "nodeFront5";
            this.nodeFront5.Size = new System.Drawing.Size(7, 7);
            this.nodeFront5.BackColor = System.Drawing.Color.Black;
            this.nodeFront5.DragDrop += new System.Windows.Forms.DragEventHandler(this.nodeFront5_DragDrop);
            this.nodeFront5.DragEnter += new System.Windows.Forms.DragEventHandler(this.nodeFront5_DragEnter);
            this.nodeFront5.AllowDrop = true;
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
            this.shapeContainer1.Size = new System.Drawing.Size(50, 79);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.SystemColors.Control;
            this.rectangleShape1.Enabled = false;
            this.rectangleShape1.FillColor = System.Drawing.Color.LightGray;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(0, 18);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(12, 10);
            this.rectangleShape1.MouseHover += new System.EventHandler(this.rectangleShape1_MouseHover);
            // 
            // ovalShapeInner
            // 
            this.ovalShapeInner.BackColor = System.Drawing.Color.Gainsboro;
            this.ovalShapeInner.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShapeInner.Location = new System.Drawing.Point(15, 13);
            this.ovalShapeInner.Name = "ovalShapeInner";
            this.ovalShapeInner.Size = new System.Drawing.Size(25, 25);
            // 
            // ovalShapeOuter
            // 
            this.ovalShapeOuter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ovalShapeOuter.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShapeOuter.Location = new System.Drawing.Point(12,10);
            this.ovalShapeOuter.Name = "ovalShapeOuter";
            this.ovalShapeOuter.Size = new System.Drawing.Size(30, 30);
            // 
            // Output_Front
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nodeFront5);
            this.Controls.Add(this.shapeContainer1);

            this.Name = "Output_Front";
            this.Size = new System.Drawing.Size(50, 50);

            this.ResumeLayout(false);
        }

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShapeOuter;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShapeInner;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Node_Front nodeFront5;



        #endregion

    }
}
