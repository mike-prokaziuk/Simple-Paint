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
            this.clearMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.loadMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitMI = new System.Windows.Forms.ToolStripMenuItem();
            this.effectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.PencilBtn = new System.Windows.Forms.ToolStripButton();
            this.LineBtn = new System.Windows.Forms.ToolStripButton();
            this.RectangleBtn = new System.Windows.Forms.ToolStripButton();
            this.CircleBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.changeMainColorBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FillColorDDB = new System.Windows.Forms.ToolStripDropDownButton();
            this.ChangeFillColorTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.EmptyFillColorTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lineWidthDDB = new System.Windows.Forms.ToolStripDropDownButton();
            this.OnePointTSMI = new SimplePaint.ValuedToolStripMenuItem();
            this.TwoPointTSMI = new SimplePaint.ValuedToolStripMenuItem();
            this.FourPointTSMI = new SimplePaint.ValuedToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.CanvasControl = new System.Windows.Forms.PictureBox();
            this.substratePanel = new System.Windows.Forms.Panel();
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
            this.clearMI,
            this.toolStripSeparator4,
            this.loadMI,
            this.saveMI,
            this.toolStripSeparator,
            this.exitMI});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearMI
            // 
            this.clearMI.Name = "clearMI";
            this.clearMI.Size = new System.Drawing.Size(152, 22);
            this.clearMI.Text = "Clear";
            this.clearMI.Click += new System.EventHandler(this.clearMI_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // loadMI
            // 
            this.loadMI.Name = "loadMI";
            this.loadMI.Size = new System.Drawing.Size(152, 22);
            this.loadMI.Text = "Load";
            this.loadMI.Click += new System.EventHandler(this.loadMI_Click);
            // 
            // saveMI
            // 
            this.saveMI.Name = "saveMI";
            this.saveMI.Size = new System.Drawing.Size(152, 22);
            this.saveMI.Text = "Save";
            this.saveMI.Click += new System.EventHandler(this.saveMI_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // exitMI
            // 
            this.exitMI.Name = "exitMI";
            this.exitMI.Size = new System.Drawing.Size(152, 22);
            this.exitMI.Text = "Exit";
            this.exitMI.Click += new System.EventHandler(this.exitMI_Click);
            // 
            // effectsToolStripMenuItem
            // 
            this.effectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertMI});
            this.effectsToolStripMenuItem.Name = "effectsToolStripMenuItem";
            this.effectsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.effectsToolStripMenuItem.Text = "Effects";
            // 
            // invertMI
            // 
            this.invertMI.Name = "invertMI";
            this.invertMI.Size = new System.Drawing.Size(152, 22);
            this.invertMI.Text = "Invert";
            this.invertMI.Click += new System.EventHandler(this.invertMI_Click);
            // 
            // ToolBar
            // 
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PencilBtn,
            this.LineBtn,
            this.RectangleBtn,
            this.CircleBtn,
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
            // 
            // PencilBtn
            // 
            this.PencilBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PencilBtn.Image = ((System.Drawing.Image)(resources.GetObject("PencilBtn.Image")));
            this.PencilBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PencilBtn.Name = "PencilBtn";
            this.PencilBtn.Size = new System.Drawing.Size(23, 22);
            this.PencilBtn.Text = "Pencil";
            this.PencilBtn.Click += new System.EventHandler(this.brushControls_Click);
            // 
            // LineBtn
            // 
            this.LineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineBtn.Image = ((System.Drawing.Image)(resources.GetObject("LineBtn.Image")));
            this.LineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(23, 22);
            this.LineBtn.Text = "Line";
            this.LineBtn.Click += new System.EventHandler(this.brushControls_Click);
            // 
            // RectangleBtn
            // 
            this.RectangleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RectangleBtn.Image = ((System.Drawing.Image)(resources.GetObject("RectangleBtn.Image")));
            this.RectangleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RectangleBtn.Name = "RectangleBtn";
            this.RectangleBtn.Size = new System.Drawing.Size(23, 22);
            this.RectangleBtn.Text = "Rectangle";
            this.RectangleBtn.Click += new System.EventHandler(this.brushControls_Click);
            // 
            // CircleBtn
            // 
            this.CircleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CircleBtn.Image = ((System.Drawing.Image)(resources.GetObject("CircleBtn.Image")));
            this.CircleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(23, 22);
            this.CircleBtn.Text = "Circle";
            this.CircleBtn.Click += new System.EventHandler(this.brushControls_Click);
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
            this.ChangeFillColorTSMI.Click += new System.EventHandler(this.changeFillColorMI_Click);
            // 
            // EmptyFillColorTSMI
            // 
            this.EmptyFillColorTSMI.Name = "EmptyFillColorTSMI";
            this.EmptyFillColorTSMI.Size = new System.Drawing.Size(161, 22);
            this.EmptyFillColorTSMI.Text = "Empty fill color";
            this.EmptyFillColorTSMI.Click += new System.EventHandler(this.changeToEmptyFillColorMI_Click);
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
            // OnePointTSMI
            // 
            this.OnePointTSMI.Checked = true;
            this.OnePointTSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OnePointTSMI.Name = "OnePointTSMI";
            this.OnePointTSMI.Size = new System.Drawing.Size(152, 22);
            this.OnePointTSMI.Text = "1 Point";
            this.OnePointTSMI.Value = 1;
            this.OnePointTSMI.Click += new System.EventHandler(this.changeOfWidthLineMI_Click);
            // 
            // TwoPointTSMI
            // 
            this.TwoPointTSMI.Name = "TwoPointTSMI";
            this.TwoPointTSMI.Size = new System.Drawing.Size(152, 22);
            this.TwoPointTSMI.Text = "2 Point";
            this.TwoPointTSMI.Value = 2;
            this.TwoPointTSMI.Click += new System.EventHandler(this.changeOfWidthLineMI_Click);
            // 
            // FourPointTSMI
            // 
            this.FourPointTSMI.Name = "FourPointTSMI";
            this.FourPointTSMI.Size = new System.Drawing.Size(152, 22);
            this.FourPointTSMI.Text = "4 Point";
            this.FourPointTSMI.Value = 4;
            this.FourPointTSMI.Click += new System.EventHandler(this.changeOfWidthLineMI_Click);
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
            this.CanvasControl.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasControl_Paint);
            this.CanvasControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvasControl_MouseDown);
            this.CanvasControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvasControl_MouseMove);
            this.CanvasControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvasControl_MouseUp);
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
        private System.Windows.Forms.ToolStripButton PencilBtn;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripButton LineBtn;
        private System.Windows.Forms.ToolStripButton RectangleBtn;
        private System.Windows.Forms.ToolStripButton CircleBtn;
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
        private System.Windows.Forms.ToolStripMenuItem clearMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem loadMI;
        private System.Windows.Forms.ToolStripMenuItem saveMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitMI;
        private System.Windows.Forms.ToolStripMenuItem effectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertMI;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.PictureBox CanvasControl;
        private System.Windows.Forms.Panel substratePanel;
    }
}

