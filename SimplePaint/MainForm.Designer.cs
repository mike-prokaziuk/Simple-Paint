namespace SimplePaint
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.effectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.Pencil = new System.Windows.Forms.ToolStripButton();
            this.Line = new System.Windows.Forms.ToolStripButton();
            this.Rectangle = new System.Windows.Forms.ToolStripButton();
            this.Circle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.changeMainColorBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FillColorDDB = new System.Windows.Forms.ToolStripDropDownButton();
            this.ChangeFillColorTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.EmptyFillColorTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lineWidthDDB = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.bufferedPanel = new SimplePaint.BufferedPanel();
            this.OnePointTSMI = new SimplePaint.ValuedToolStripMenuItem();
            this.TwoPointTSMI = new SimplePaint.ValuedToolStripMenuItem();
            this.FourPointTSMI = new SimplePaint.ValuedToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.effectsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(641, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearTSMI,
            this.toolStripSeparator4,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearTSMI
            // 
            this.clearTSMI.Name = "clearTSMI";
            this.clearTSMI.Size = new System.Drawing.Size(101, 22);
            this.clearTSMI.Text = "Clear";
            this.clearTSMI.Click += new System.EventHandler(this.clearTSMI_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(98, 6);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(98, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // effectsToolStripMenuItem
            // 
            this.effectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertToolStripMenuItem});
            this.effectsToolStripMenuItem.Name = "effectsToolStripMenuItem";
            this.effectsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.effectsToolStripMenuItem.Text = "Effects";
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.invertToolStripMenuItem.Text = "Invert";
            // 
            // ToolBar
            // 
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pencil,
            this.Line,
            this.Rectangle,
            this.Circle,
            this.toolStripSeparator1,
            this.changeMainColorBtn,
            this.toolStripSeparator2,
            this.FillColorDDB,
            this.toolStripSeparator3,
            this.lineWidthDDB});
            this.ToolBar.Location = new System.Drawing.Point(0, 24);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(641, 25);
            this.ToolBar.TabIndex = 1;
            this.ToolBar.Text = "toolStrip1";
            // 
            // Pencil
            // 
            this.Pencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pencil.Image = global::SimplePaint.Properties.Resources.Pencil;
            this.Pencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pencil.Name = "Pencil";
            this.Pencil.Size = new System.Drawing.Size(23, 22);
            this.Pencil.Click += new System.EventHandler(this.brushControls_Click);
            // 
            // Line
            // 
            this.Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Line.Image = global::SimplePaint.Properties.Resources.Line;
            this.Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(23, 22);
            this.Line.Text = "toolStripButton2";
            this.Line.Click += new System.EventHandler(this.brushControls_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Rectangle.Image = global::SimplePaint.Properties.Resources.Rectange;
            this.Rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(23, 22);
            this.Rectangle.Text = "toolStripButton3";
            this.Rectangle.Click += new System.EventHandler(this.brushControls_Click);
            // 
            // Circle
            // 
            this.Circle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Circle.Image = global::SimplePaint.Properties.Resources.Circle;
            this.Circle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(23, 22);
            this.Circle.Text = "toolStripButton4";
            this.Circle.Click += new System.EventHandler(this.brushControls_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // changeMainColorBtn
            // 
            this.changeMainColorBtn.BackColor = System.Drawing.SystemColors.Control;
            this.changeMainColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.changeMainColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.changeMainColorBtn.Name = "changeMainColorBtn";
            this.changeMainColorBtn.Size = new System.Drawing.Size(70, 22);
            this.changeMainColorBtn.Text = "Main Color";
            this.changeMainColorBtn.Click += new System.EventHandler(this.changeMainColorBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // FillColorDDB
            // 
            this.FillColorDDB.BackColor = System.Drawing.SystemColors.Control;
            this.FillColorDDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FillColorDDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeFillColorTSMI,
            this.EmptyFillColorTSMI});
            this.FillColorDDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillColorDDB.Name = "FillColorDDB";
            this.FillColorDDB.Size = new System.Drawing.Size(67, 22);
            this.FillColorDDB.Text = "Fill Color";
            // 
            // ChangeFillColorTSMI
            // 
            this.ChangeFillColorTSMI.Name = "ChangeFillColorTSMI";
            this.ChangeFillColorTSMI.Size = new System.Drawing.Size(161, 22);
            this.ChangeFillColorTSMI.Text = "Change fill color";
            this.ChangeFillColorTSMI.Click += new System.EventHandler(this.changeFillColorTSMI_Click);
            // 
            // EmptyFillColorTSMI
            // 
            this.EmptyFillColorTSMI.Name = "EmptyFillColorTSMI";
            this.EmptyFillColorTSMI.Size = new System.Drawing.Size(161, 22);
            this.EmptyFillColorTSMI.Text = "Empty fill color";
            this.EmptyFillColorTSMI.Click += new System.EventHandler(this.changeToEmptyFillColorTSMI_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // lineWidthDDB
            // 
            this.lineWidthDDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lineWidthDDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnePointTSMI,
            this.TwoPointTSMI,
            this.FourPointTSMI});
            this.lineWidthDDB.Image = ((System.Drawing.Image)(resources.GetObject("lineWidthDDB.Image")));
            this.lineWidthDDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineWidthDDB.Name = "lineWidthDDB";
            this.lineWidthDDB.Size = new System.Drawing.Size(77, 22);
            this.lineWidthDDB.Text = "Line Width";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip.Location = new System.Drawing.Point(0, 533);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(641, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // bufferedPanel
            // 
            this.bufferedPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bufferedPanel.Location = new System.Drawing.Point(0, 52);
            this.bufferedPanel.Name = "bufferedPanel";
            this.bufferedPanel.Size = new System.Drawing.Size(640, 480);
            this.bufferedPanel.TabIndex = 3;
            this.bufferedPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bufferedPanel_Paint);
            this.bufferedPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bufferedPanel_MouseDown);
            this.bufferedPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bufferedPanel_MouseMove);
            this.bufferedPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bufferedPanel_MouseUp);
            // 
            // OnePointTSMI
            // 
            this.OnePointTSMI.Checked = true;
            this.OnePointTSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OnePointTSMI.Name = "OnePointTSMI";
            this.OnePointTSMI.Size = new System.Drawing.Size(111, 22);
            this.OnePointTSMI.Text = "1 Point";
            this.OnePointTSMI.Value = 1;
            this.OnePointTSMI.Click += new System.EventHandler(this.PointsTSMI_Click);
            // 
            // TwoPointTSMI
            // 
            this.TwoPointTSMI.Name = "TwoPointTSMI";
            this.TwoPointTSMI.Size = new System.Drawing.Size(111, 22);
            this.TwoPointTSMI.Text = "2 Point";
            this.TwoPointTSMI.Value = 2;
            this.TwoPointTSMI.Click += new System.EventHandler(this.PointsTSMI_Click);
            // 
            // FourPointTSMI
            // 
            this.FourPointTSMI.Name = "FourPointTSMI";
            this.FourPointTSMI.Size = new System.Drawing.Size(111, 22);
            this.FourPointTSMI.Text = "4 Point";
            this.FourPointTSMI.Value = 4;
            this.FourPointTSMI.Click += new System.EventHandler(this.PointsTSMI_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 555);
            this.Controls.Add(this.bufferedPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Simple Paint";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton Pencil;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripButton Line;
        private System.Windows.Forms.ToolStripButton Rectangle;
        private System.Windows.Forms.ToolStripButton Circle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton changeMainColorBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private BufferedPanel bufferedPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton lineWidthDDB;
        private ValuedToolStripMenuItem OnePointTSMI;
        private ValuedToolStripMenuItem TwoPointTSMI;
        private ValuedToolStripMenuItem FourPointTSMI;
        private System.Windows.Forms.ColorDialog colorDialog;
        public System.Windows.Forms.ToolStripDropDownButton FillColorDDB;
        private System.Windows.Forms.ToolStripMenuItem ChangeFillColorTSMI;
        private System.Windows.Forms.ToolStripMenuItem EmptyFillColorTSMI;
        private System.Windows.Forms.ToolStripMenuItem clearTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem effectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
    }
}

