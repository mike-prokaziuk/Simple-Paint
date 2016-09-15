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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.pencilBtn = new System.Windows.Forms.ToolStripButton();
            this.lineBtn = new System.Windows.Forms.ToolStripButton();
            this.rectangleBtn = new System.Windows.Forms.ToolStripButton();
            this.circleBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.changeMainColorBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.changeFillColorBtn = new System.Windows.Forms.ToolStripButton();
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
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(624, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pencilBtn,
            this.lineBtn,
            this.rectangleBtn,
            this.circleBtn,
            this.toolStripSeparator1,
            this.changeMainColorBtn,
            this.toolStripSeparator2,
            this.changeFillColorBtn,
            this.toolStripSeparator3,
            this.lineWidthDDB});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(624, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // pencilBtn
            // 
            this.pencilBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pencilBtn.Image = global::SimplePaint.Properties.Resources.Pencil;
            this.pencilBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pencilBtn.Name = "pencilBtn";
            this.pencilBtn.Size = new System.Drawing.Size(23, 22);
            // 
            // lineBtn
            // 
            this.lineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineBtn.Image = global::SimplePaint.Properties.Resources.Line;
            this.lineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(23, 22);
            this.lineBtn.Text = "toolStripButton2";
            // 
            // rectangleBtn
            // 
            this.rectangleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectangleBtn.Image = global::SimplePaint.Properties.Resources.Rectange;
            this.rectangleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectangleBtn.Name = "rectangleBtn";
            this.rectangleBtn.Size = new System.Drawing.Size(23, 22);
            this.rectangleBtn.Text = "toolStripButton3";
            // 
            // circleBtn
            // 
            this.circleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.circleBtn.Image = global::SimplePaint.Properties.Resources.Circle;
            this.circleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(23, 22);
            this.circleBtn.Text = "toolStripButton4";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // changeMainColorBtn
            // 
            this.changeMainColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.changeMainColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.changeMainColorBtn.Name = "changeMainColorBtn";
            this.changeMainColorBtn.Size = new System.Drawing.Size(70, 22);
            this.changeMainColorBtn.Text = "Main Color";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // changeFillColorBtn
            // 
            this.changeFillColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.changeFillColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.changeFillColorBtn.Name = "changeFillColorBtn";
            this.changeFillColorBtn.Size = new System.Drawing.Size(58, 22);
            this.changeFillColorBtn.Text = "Fill Color";
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
            this.lineWidthDDB.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip.Location = new System.Drawing.Point(0, 419);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(624, 22);
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
            this.bufferedPanel.Size = new System.Drawing.Size(624, 364);
            this.bufferedPanel.TabIndex = 3;
            // 
            // OnePointTSMI
            // 
            this.OnePointTSMI.Checked = true;
            this.OnePointTSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OnePointTSMI.Name = "OnePointTSMI";
            this.OnePointTSMI.Size = new System.Drawing.Size(152, 22);
            this.OnePointTSMI.Text = "1 Point";
            this.OnePointTSMI.Value = 1;
            this.OnePointTSMI.Click += new System.EventHandler(this.PointsTSMI_Click);
            // 
            // TwoPointTSMI
            // 
            this.TwoPointTSMI.Name = "TwoPointTSMI";
            this.TwoPointTSMI.Size = new System.Drawing.Size(152, 22);
            this.TwoPointTSMI.Text = "2 Point";
            this.TwoPointTSMI.Value = 2;
            this.TwoPointTSMI.Click += new System.EventHandler(this.PointsTSMI_Click);
            // 
            // FourPointTSMI
            // 
            this.FourPointTSMI.Name = "FourPointTSMI";
            this.FourPointTSMI.Size = new System.Drawing.Size(152, 22);
            this.FourPointTSMI.Text = "4 Point";
            this.FourPointTSMI.Value = 4;
            this.FourPointTSMI.Click += new System.EventHandler(this.PointsTSMI_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.bufferedPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Simple Paint";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton pencilBtn;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripButton lineBtn;
        private System.Windows.Forms.ToolStripButton rectangleBtn;
        private System.Windows.Forms.ToolStripButton circleBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton changeMainColorBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton changeFillColorBtn;
        private BufferedPanel bufferedPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton lineWidthDDB;
        private ValuedToolStripMenuItem OnePointTSMI;
        private ValuedToolStripMenuItem TwoPointTSMI;
        private ValuedToolStripMenuItem FourPointTSMI;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

