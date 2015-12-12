namespace gates_test
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
            this.not_button1 = new gates_test.not_button();
            this.and_button1 = new gates_test.and_button();
            this.userControl11 = new gates_test.UserControl1();
            this.SuspendLayout();
            // 
            // not_button1
            // 
            this.not_button1.Location = new System.Drawing.Point(332, 23);
            this.not_button1.Name = "not_button1";
            this.not_button1.Size = new System.Drawing.Size(461, 260);
            this.not_button1.TabIndex = 1;
            // 
            // and_button1
            // 
            this.and_button1.Location = new System.Drawing.Point(29, 12);
            this.and_button1.Name = "and_button1";
            this.and_button1.Size = new System.Drawing.Size(157, 112);
            this.and_button1.TabIndex = 0;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(240, 97);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(252, 186);
            this.userControl11.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 345);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.not_button1);
            this.Controls.Add(this.and_button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private and_button and_button1;
        private not_button not_button1;
        private UserControl1 userControl11;
    }
}

