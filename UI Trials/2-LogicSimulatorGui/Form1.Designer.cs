namespace LogicSimulatorGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aNDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nANDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xNORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wiresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pushButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knowMoreAboutGatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optimizeCircuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.optimizeCircuitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newProjectToolStripMenuItem.Image")));
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openFileToolStripMenuItem.Image")));
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.openFileToolStripMenuItem.Text = "open file";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveAsToolStripMenuItem.Text = "save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.cutToolStripMenuItem.Text = "cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "paste";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gatesToolStripMenuItem,
            this.wiresToolStripMenuItem,
            this.inputToolStripMenuItem,
            this.outputToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // gatesToolStripMenuItem
            // 
            this.gatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aNDToolStripMenuItem,
            this.oRToolStripMenuItem,
            this.nOTToolStripMenuItem,
            this.nANDToolStripMenuItem,
            this.xORToolStripMenuItem,
            this.xNORToolStripMenuItem,
            this.nORToolStripMenuItem});
            this.gatesToolStripMenuItem.Name = "gatesToolStripMenuItem";
            this.gatesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.gatesToolStripMenuItem.Text = "Logic Ports";
            // 
            // aNDToolStripMenuItem
            // 
            this.aNDToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aNDToolStripMenuItem.Image")));
            this.aNDToolStripMenuItem.Name = "aNDToolStripMenuItem";
            this.aNDToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.aNDToolStripMenuItem.Text = "AND";
            // 
            // oRToolStripMenuItem
            // 
            this.oRToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("oRToolStripMenuItem.Image")));
            this.oRToolStripMenuItem.Name = "oRToolStripMenuItem";
            this.oRToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.oRToolStripMenuItem.Text = "OR";
            // 
            // nOTToolStripMenuItem
            // 
            this.nOTToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nOTToolStripMenuItem.Image")));
            this.nOTToolStripMenuItem.Name = "nOTToolStripMenuItem";
            this.nOTToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.nOTToolStripMenuItem.Text = "NOT";
            // 
            // nANDToolStripMenuItem
            // 
            this.nANDToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nANDToolStripMenuItem.Image")));
            this.nANDToolStripMenuItem.Name = "nANDToolStripMenuItem";
            this.nANDToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.nANDToolStripMenuItem.Text = "NAND";
            // 
            // xORToolStripMenuItem
            // 
            this.xORToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xORToolStripMenuItem.Image")));
            this.xORToolStripMenuItem.Name = "xORToolStripMenuItem";
            this.xORToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.xORToolStripMenuItem.Text = "XOR";
            // 
            // xNORToolStripMenuItem
            // 
            this.xNORToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xNORToolStripMenuItem.Image")));
            this.xNORToolStripMenuItem.Name = "xNORToolStripMenuItem";
            this.xNORToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.xNORToolStripMenuItem.Text = "XNOR";
            // 
            // nORToolStripMenuItem
            // 
            this.nORToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nORToolStripMenuItem.Image")));
            this.nORToolStripMenuItem.Name = "nORToolStripMenuItem";
            this.nORToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.nORToolStripMenuItem.Text = "NOR";
            // 
            // wiresToolStripMenuItem
            // 
            this.wiresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nodesToolStripMenuItem});
            this.wiresToolStripMenuItem.Name = "wiresToolStripMenuItem";
            this.wiresToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.wiresToolStripMenuItem.Text = "Wires";
            // 
            // nodesToolStripMenuItem
            // 
            this.nodesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nodesToolStripMenuItem.Image")));
            this.nodesToolStripMenuItem.Name = "nodesToolStripMenuItem";
            this.nodesToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.nodesToolStripMenuItem.Text = "nodes";
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pushButtonToolStripMenuItem,
            this.switchToolStripMenuItem});
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.inputToolStripMenuItem.Text = "Input";
            // 
            // pushButtonToolStripMenuItem
            // 
            this.pushButtonToolStripMenuItem.Name = "pushButtonToolStripMenuItem";
            this.pushButtonToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.pushButtonToolStripMenuItem.Text = "push button";
            // 
            // switchToolStripMenuItem
            // 
            this.switchToolStripMenuItem.Name = "switchToolStripMenuItem";
            this.switchToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.switchToolStripMenuItem.Text = "switch";
            // 
            // outputToolStripMenuItem
            // 
            this.outputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ledToolStripMenuItem,
            this.motorToolStripMenuItem,
            this.segmentToolStripMenuItem});
            this.outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            this.outputToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.outputToolStripMenuItem.Text = "output";
            // 
            // ledToolStripMenuItem
            // 
            this.ledToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ledToolStripMenuItem.Image")));
            this.ledToolStripMenuItem.Name = "ledToolStripMenuItem";
            this.ledToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ledToolStripMenuItem.Text = "Led";
            // 
            // motorToolStripMenuItem
            // 
            this.motorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("motorToolStripMenuItem.Image")));
            this.motorToolStripMenuItem.Name = "motorToolStripMenuItem";
            this.motorToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.motorToolStripMenuItem.Text = "Motor";
            // 
            // segmentToolStripMenuItem
            // 
            this.segmentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("segmentToolStripMenuItem.Image")));
            this.segmentToolStripMenuItem.Name = "segmentToolStripMenuItem";
            this.segmentToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.segmentToolStripMenuItem.Text = "7Segment";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.knowMoreAboutGatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewHelpToolStripMenuItem.Image")));
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.viewHelpToolStripMenuItem.Text = "view help";
            // 
            // knowMoreAboutGatesToolStripMenuItem
            // 
            this.knowMoreAboutGatesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("knowMoreAboutGatesToolStripMenuItem.Image")));
            this.knowMoreAboutGatesToolStripMenuItem.Name = "knowMoreAboutGatesToolStripMenuItem";
            this.knowMoreAboutGatesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.knowMoreAboutGatesToolStripMenuItem.Text = "know more about gates";
            this.knowMoreAboutGatesToolStripMenuItem.Click += new System.EventHandler(this.knowMoreAboutGatesToolStripMenuItem_Click);
            // 
            // optimizeCircuitToolStripMenuItem
            // 
            this.optimizeCircuitToolStripMenuItem.Name = "optimizeCircuitToolStripMenuItem";
            this.optimizeCircuitToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.optimizeCircuitToolStripMenuItem.Text = "Optimize circuit";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton10});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(693, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::LogicSimulatorGui.Properties.Resources.zoom_out;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "toolStripButton7";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "toolStripButton8";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "toolStripButton9";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "toolStripButton10";
            this.toolStripButton10.MouseHover += new System.EventHandler(this.toolStripButton10_MouseHover);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(671, 52);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(1350, 600);
            this.vScrollBar1.TabIndex = 4;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(650, 49);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 345);
            this.vScrollBar2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(447, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 321);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 429);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(693, 476);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logic Simulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aNDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nANDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xNORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wiresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pushButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knowMoreAboutGatesToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ToolStripMenuItem nodesToolStripMenuItem;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.ToolStripMenuItem optimizeCircuitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;

    }
}

