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
            this.loadTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.effectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertTSMI = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.CanvasControl = new System.Windows.Forms.PictureBox();
            this.substratePanel = new System.Windows.Forms.Panel();
            this.OnePointTSMI = new SimplePaint.ValuedToolStripMenuItem();
            this.TwoPointTSMI = new SimplePaint.ValuedToolStripMenuItem();
            this.FourPointTSMI = new SimplePaint.ValuedToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CanvasControl)).BeginInit();
            this.substratePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.effectsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1052, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearTSMI,
            this.toolStripSeparator4,
            this.loadTSMI,
            this.saveTSMI,
            this.toolStripSeparator,
            this.exitTSMI});
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
            // loadTSMI
            // 
            this.loadTSMI.Name = "loadTSMI";
            this.loadTSMI.Size = new System.Drawing.Size(101, 22);
            this.loadTSMI.Text = "Load";
            this.loadTSMI.Click += new System.EventHandler(this.loadTSMI_Click);
            // 
            // saveTSMI
            // 
            this.saveTSMI.Name = "saveTSMI";
            this.saveTSMI.Size = new System.Drawing.Size(101, 22);
            this.saveTSMI.Text = "Save";
            this.saveTSMI.Click += new System.EventHandler(this.saveTSMI_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(98, 6);
            // 
            // exitTSMI
            // 
            this.exitTSMI.Name = "exitTSMI";
            this.exitTSMI.Size = new System.Drawing.Size(101, 22);
            this.exitTSMI.Text = "Exit";
            this.exitTSMI.Click += new System.EventHandler(this.exitTSMI_Click);
            // 
            // effectsToolStripMenuItem
            // 
            this.effectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertTSMI});
            this.effectsToolStripMenuItem.Name = "effectsToolStripMenuItem";
            this.effectsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.effectsToolStripMenuItem.Text = "Effects";
            // 
            // invertTSMI
            // 
            this.invertTSMI.Name = "invertTSMI";
            this.invertTSMI.Size = new System.Drawing.Size(152, 22);
            this.invertTSMI.Text = "Invert";
            this.invertTSMI.Click += new System.EventHandler(this.invertTSMI_Click);
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
            this.ToolBar.Size = new System.Drawing.Size(1052, 25);
            this.ToolBar.TabIndex = 1;
            this.ToolBar.Text = "toolStrip1";
            this.ToolBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolBar_ItemClicked);
            // 
            // Pencil
            // 
            this.Pencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pencil.Image = ((System.Drawing.Image)(resources.GetObject("Pencil.Image")));
            this.Pencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pencil.Name = "Pencil";
            this.Pencil.Size = new System.Drawing.Size(23, 22);
            this.Pencil.Click += new System.EventHandler(this.brushControls_Click);
            // 
            // Line
            // 
            this.Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Line.Image = ((System.Drawing.Image)(resources.GetObject("Line.Image")));
            this.Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(23, 22);
            this.Line.Text = "toolStripButton2";
            this.Line.Click += new System.EventHandler(this.brushControls_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("Rectangle.Image")));
            this.Rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(23, 22);
            this.Rectangle.Text = "toolStripButton3";
            this.Rectangle.Click += new System.EventHandler(this.brushControls_Click);
            // 
            // Circle
            // 
            this.Circle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Circle.Image = ((System.Drawing.Image)(resources.GetObject("Circle.Image")));
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
            this.ProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 837);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1052, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // ProgressBar
            // 
            this.ProgressBar.MarqueeAnimationSpeed = 10;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.ProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // CanvasControl
            // 
            this.CanvasControl.BackColor = System.Drawing.Color.White;
            this.CanvasControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CanvasControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CanvasControl.Location = new System.Drawing.Point(3, 3);
            this.CanvasControl.Name = "CanvasControl";
            this.CanvasControl.Size = new System.Drawing.Size(1024, 768);
            this.CanvasControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CanvasControl.TabIndex = 4;
            this.CanvasControl.TabStop = false;
            this.CanvasControl.Paint += new System.Windows.Forms.PaintEventHandler(this.CanvasControl_Paint);
            this.CanvasControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasControl_MouseDown);
            this.CanvasControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasControl_MouseMove);
            this.CanvasControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CanvasControl_MouseUp);
            // 
            // substratePanel
            // 
            this.substratePanel.AutoScroll = true;
            this.substratePanel.Controls.Add(this.CanvasControl);
            this.substratePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.substratePanel.Location = new System.Drawing.Point(0, 49);
            this.substratePanel.Name = "substratePanel";
            this.substratePanel.Size = new System.Drawing.Size(1052, 788);
            this.substratePanel.TabIndex = 5;
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
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1052, 859);
            this.Controls.Add(this.substratePanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Paint";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CanvasControl)).EndInit();
            this.substratePanel.ResumeLayout(false);
            this.substratePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton Pencil;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripButton Line;
        private System.Windows.Forms.ToolStripButton Rectangle;
        private System.Windows.Forms.ToolStripButton Circle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton changeMainColorBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
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
        private System.Windows.Forms.ToolStripMenuItem loadTSMI;
        private System.Windows.Forms.ToolStripMenuItem saveTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitTSMI;
        private System.Windows.Forms.ToolStripMenuItem effectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertTSMI;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.PictureBox CanvasControl;
        private System.Windows.Forms.Panel substratePanel;
    }
}

