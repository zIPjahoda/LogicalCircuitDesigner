namespace LogCirDes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.RasterTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.AddANDButton = new System.Windows.Forms.ToolStripButton();
            this.RenderRefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.ProjectCanvas = new LogCirDes.Canvas();
            this.ToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RasterTextBox,
            this.RefreshButton,
            this.AddANDButton});
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(887, 25);
            this.ToolBar.TabIndex = 0;
            this.ToolBar.Text = "ToolBar";
            // 
            // RasterTextBox
            // 
            this.RasterTextBox.Name = "RasterTextBox";
            this.RasterTextBox.Size = new System.Drawing.Size(35, 25);
            this.RasterTextBox.TextChanged += new System.EventHandler(this.RasterTextBox_TextChanged);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(23, 22);
            this.RefreshButton.Text = "RefreshButton";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // AddANDButton
            // 
            this.AddANDButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddANDButton.Image = ((System.Drawing.Image)(resources.GetObject("AddANDButton.Image")));
            this.AddANDButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddANDButton.Name = "AddANDButton";
            this.AddANDButton.Size = new System.Drawing.Size(23, 22);
            this.AddANDButton.Text = "toolStripButton1";
            this.AddANDButton.ToolTipText = "AND Gate";
            this.AddANDButton.Click += new System.EventHandler(this.AddANDButton_Click);
            // 
            // RenderRefreshTimer
            // 
            this.RenderRefreshTimer.Interval = 1000;
            this.RenderRefreshTimer.Tick += new System.EventHandler(this.RenderRefreshTimer_Tick);
            // 
            // ProjectCanvas
            // 
            this.ProjectCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectCanvas.GridRaster = 10;
            this.ProjectCanvas.Location = new System.Drawing.Point(0, 28);
            this.ProjectCanvas.Name = "ProjectCanvas";
            this.ProjectCanvas.Size = new System.Drawing.Size(887, 524);
            this.ProjectCanvas.TabIndex = 1;
            this.ProjectCanvas.TabStop = false;
            this.ProjectCanvas.MouseMove += ProjectCanvas_MouseMove;
            this.ProjectCanvas.MouseClick += ProjectCanvas_MouseClick;

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 553);
            this.Controls.Add(this.ProjectCanvas);
            this.Controls.Add(this.ToolBar);
            this.Name = "MainForm";
            this.Text = "Logical circuit designer";
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripTextBox RasterTextBox;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton AddANDButton;
        private System.Windows.Forms.Timer RenderRefreshTimer;
        private Canvas ProjectCanvas;
    }
}

