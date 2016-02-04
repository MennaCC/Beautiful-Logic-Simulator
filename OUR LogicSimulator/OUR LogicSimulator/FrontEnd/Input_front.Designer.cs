namespace OUR_LogicSimulator.FrontEnd
{
    partial class Input_front: OurUserControl
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
           /* this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.ovalShapeInner = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShapeOuter = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.SuspendLayout();
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
            this.rectangleShape1.Location = new System.Drawing.Point(85, 51);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(10, 10);
            this.rectangleShape1.MouseHover += new System.EventHandler(this.rectangleShape1_MouseHover);
            // 
            // ovalShapeInner
            // 
            this.ovalShapeInner.BackColor = System.Drawing.Color.Gainsboro;
            this.ovalShapeInner.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShapeInner.Location = new System.Drawing.Point(16, 26);
            this.ovalShapeInner.Name = "ovalShapeInner";
            this.ovalShapeInner.Size = new System.Drawing.Size(61, 60);
            this.ovalShapeInner.Click += new System.EventHandler(this.ovalShapeInner_Click);
            // 
            // ovalShapeOuter
            // 
            this.ovalShapeOuter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ovalShapeOuter.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShapeOuter.Location = new System.Drawing.Point(9, 18);
            this.ovalShapeOuter.Name = "ovalShapeOuter";
            this.ovalShapeOuter.Size = new System.Drawing.Size(75, 72);
            this.ovalShapeOuter.Click += new System.EventHandler(this.ovalShapeInner_Click);
            */
            // 
            // Input_front
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Input_front";
            this.Size = new System.Drawing.Size(107, 109);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShapeOuter;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShapeInner;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}
