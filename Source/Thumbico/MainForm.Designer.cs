namespace Thumbico
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.fileMenuItem = new System.Windows.Forms.MenuItem();
            this.fileOpenMenuItem = new System.Windows.Forms.MenuItem();
            this.fileSaveAsMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.fileExitMenuItem = new System.Windows.Forms.MenuItem();
            this.editMenuItem = new System.Windows.Forms.MenuItem();
            this.editCopyMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.imageSizeMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.imageResizeToFitMenuItem = new System.Windows.Forms.MenuItem();
            this.imageBiggerSizeOkMenuItem = new System.Windows.Forms.MenuItem();
            this.imageMemoryOnlyMenuItem = new System.Windows.Forms.MenuItem();
            this.imageIconOnlyMenuItem = new System.Windows.Forms.MenuItem();
            this.imageThumbnailOnlyMenuItem = new System.Windows.Forms.MenuItem();
            this.imageInCacheOnlyMenuItem = new System.Windows.Forms.MenuItem();
            this.imageCropToSquareMenuItem = new System.Windows.Forms.MenuItem();
            this.imageWideThumbnailsMenuItem = new System.Windows.Forms.MenuItem();
            this.imageIconBackgroundMenuItem = new System.Windows.Forms.MenuItem();
            this.imageScaleUpMenuItem = new System.Windows.Forms.MenuItem();
            this.viewMenuItem = new System.Windows.Forms.MenuItem();
            this.viewBackgroundColorMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.desiredSizeStatusBarPanel = new System.Windows.Forms.StatusBarPanel();
            this.actualSizeStatusBarPanel = new System.Windows.Forms.StatusBarPanel();
            this.thumbiconPictureBox = new System.Windows.Forms.PictureBox();
            this.thumbiconPanel = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desiredSizeStatusBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualSizeStatusBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbiconPictureBox)).BeginInit();
            this.thumbiconPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.menuItem6,
            this.viewMenuItem,
            this.menuItem8});
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.Index = 0;
            this.fileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileOpenMenuItem,
            this.fileSaveAsMenuItem,
            this.menuItem3,
            this.fileExitMenuItem});
            this.fileMenuItem.Text = "&File";
            // 
            // fileOpenMenuItem
            // 
            this.fileOpenMenuItem.Index = 0;
            this.fileOpenMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.fileOpenMenuItem.Text = "&Open...";
            this.fileOpenMenuItem.Click += new System.EventHandler(this.FileOpenMenuItem_Click);
            // 
            // fileSaveAsMenuItem
            // 
            this.fileSaveAsMenuItem.Index = 1;
            this.fileSaveAsMenuItem.Text = "Save &As...";
            this.fileSaveAsMenuItem.Click += new System.EventHandler(this.FileSaveAsMenuItem_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "-";
            // 
            // fileExitMenuItem
            // 
            this.fileExitMenuItem.Index = 3;
            this.fileExitMenuItem.Text = "E&xit";
            this.fileExitMenuItem.Click += new System.EventHandler(this.FileExitMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.Index = 1;
            this.editMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.editCopyMenuItem});
            this.editMenuItem.Text = "&Edit";
            // 
            // editCopyMenuItem
            // 
            this.editCopyMenuItem.Index = 0;
            this.editCopyMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.editCopyMenuItem.Text = "&Copy";
            this.editCopyMenuItem.Click += new System.EventHandler(this.EditCopyMenuItem_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 2;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.imageSizeMenuItem,
            this.menuItem2,
            this.imageResizeToFitMenuItem,
            this.imageBiggerSizeOkMenuItem,
            this.imageMemoryOnlyMenuItem,
            this.imageIconOnlyMenuItem,
            this.imageThumbnailOnlyMenuItem,
            this.imageInCacheOnlyMenuItem,
            this.imageCropToSquareMenuItem,
            this.imageWideThumbnailsMenuItem,
            this.imageIconBackgroundMenuItem,
            this.imageScaleUpMenuItem});
            this.menuItem6.Text = "&Image";
            // 
            // imageSizeMenuItem
            // 
            this.imageSizeMenuItem.Index = 0;
            this.imageSizeMenuItem.Text = "Size....";
            this.imageSizeMenuItem.Click += new System.EventHandler(this.ImageSizeMenuItem_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // imageResizeToFitMenuItem
            // 
            this.imageResizeToFitMenuItem.Checked = true;
            this.imageResizeToFitMenuItem.Index = 2;
            this.imageResizeToFitMenuItem.Text = "Resize To Fit";
            this.imageResizeToFitMenuItem.Click += new System.EventHandler(this.ImageFlagsMenuItems_Click);
            // 
            // imageBiggerSizeOkMenuItem
            // 
            this.imageBiggerSizeOkMenuItem.Index = 3;
            this.imageBiggerSizeOkMenuItem.Text = "Bigger Size Ok";
            this.imageBiggerSizeOkMenuItem.Click += new System.EventHandler(this.ImageFlagsMenuItems_Click);
            // 
            // imageMemoryOnlyMenuItem
            // 
            this.imageMemoryOnlyMenuItem.Index = 4;
            this.imageMemoryOnlyMenuItem.Text = "Memory Only";
            this.imageMemoryOnlyMenuItem.Click += new System.EventHandler(this.ImageFlagsMenuItems_Click);
            // 
            // imageIconOnlyMenuItem
            // 
            this.imageIconOnlyMenuItem.Index = 5;
            this.imageIconOnlyMenuItem.Text = "Icon Only";
            this.imageIconOnlyMenuItem.Click += new System.EventHandler(this.ImageFlagsMenuItems_Click);
            // 
            // imageThumbnailOnlyMenuItem
            // 
            this.imageThumbnailOnlyMenuItem.Index = 6;
            this.imageThumbnailOnlyMenuItem.Text = "Thumbnail Only";
            this.imageThumbnailOnlyMenuItem.Click += new System.EventHandler(this.ImageFlagsMenuItems_Click);
            // 
            // imageInCacheOnlyMenuItem
            // 
            this.imageInCacheOnlyMenuItem.Index = 7;
            this.imageInCacheOnlyMenuItem.Text = "In Cache Only";
            this.imageInCacheOnlyMenuItem.Click += new System.EventHandler(this.ImageFlagsMenuItems_Click);
            // 
            // imageCropToSquareMenuItem
            // 
            this.imageCropToSquareMenuItem.Index = 8;
            this.imageCropToSquareMenuItem.Text = "Crop To Square";
            this.imageCropToSquareMenuItem.Click += new System.EventHandler(this.ImageFlagsMenuItems_Click);
            // 
            // imageWideThumbnailsMenuItem
            // 
            this.imageWideThumbnailsMenuItem.Index = 9;
            this.imageWideThumbnailsMenuItem.Text = "Wide Thumbnails";
            this.imageWideThumbnailsMenuItem.Click += new System.EventHandler(this.ImageFlagsMenuItems_Click);
            // 
            // imageIconBackgroundMenuItem
            // 
            this.imageIconBackgroundMenuItem.Index = 10;
            this.imageIconBackgroundMenuItem.Text = "Icon Background";
            this.imageIconBackgroundMenuItem.Click += new System.EventHandler(this.ImageFlagsMenuItems_Click);
            // 
            // imageScaleUpMenuItem
            // 
            this.imageScaleUpMenuItem.Index = 11;
            this.imageScaleUpMenuItem.Text = "Scale Up";
            this.imageScaleUpMenuItem.Click += new System.EventHandler(this.ImageFlagsMenuItems_Click);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.Index = 3;
            this.viewMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.viewBackgroundColorMenuItem});
            this.viewMenuItem.Text = "&View";
            // 
            // viewBackgroundColorMenuItem
            // 
            this.viewBackgroundColorMenuItem.Index = 0;
            this.viewBackgroundColorMenuItem.Text = "&Background Color...";
            this.viewBackgroundColorMenuItem.Click += new System.EventHandler(this.ViewBackgroundColorMenuItem_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 4;
            this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem9,
            this.menuItem10,
            this.menuItem11});
            this.menuItem8.Text = "&Help";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 0;
            this.menuItem9.Text = "View &Help";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 1;
            this.menuItem10.Text = "-";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 2;
            this.menuItem11.Text = "&About Thumbico";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 428);
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.desiredSizeStatusBarPanel,
            this.actualSizeStatusBarPanel});
            this.statusBar.ShowPanels = true;
            this.statusBar.Size = new System.Drawing.Size(800, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusBar1";
            this.statusBar.PanelClick += new System.Windows.Forms.StatusBarPanelClickEventHandler(this.StatusBar_PanelClick);
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Width = 763;
            // 
            // desiredSizeStatusBarPanel
            // 
            this.desiredSizeStatusBarPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.desiredSizeStatusBarPanel.Name = "desiredSizeStatusBarPanel";
            this.desiredSizeStatusBarPanel.Width = 10;
            // 
            // actualSizeStatusBarPanel
            // 
            this.actualSizeStatusBarPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.actualSizeStatusBarPanel.Name = "actualSizeStatusBarPanel";
            this.actualSizeStatusBarPanel.Width = 10;
            // 
            // thumbiconPictureBox
            // 
            this.thumbiconPictureBox.Location = new System.Drawing.Point(0, 0);
            this.thumbiconPictureBox.Name = "thumbiconPictureBox";
            this.thumbiconPictureBox.Size = new System.Drawing.Size(256, 256);
            this.thumbiconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.thumbiconPictureBox.TabIndex = 1;
            this.thumbiconPictureBox.TabStop = false;
            // 
            // thumbiconPanel
            // 
            this.thumbiconPanel.AutoScroll = true;
            this.thumbiconPanel.Controls.Add(this.thumbiconPictureBox);
            this.thumbiconPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thumbiconPanel.Location = new System.Drawing.Point(0, 0);
            this.thumbiconPanel.Name = "thumbiconPanel";
            this.thumbiconPanel.Size = new System.Drawing.Size(800, 428);
            this.thumbiconPanel.TabIndex = 2;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.thumbiconPanel);
            this.Controls.Add(this.statusBar);
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.Text = "Thumbico";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desiredSizeStatusBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualSizeStatusBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbiconPictureBox)).EndInit();
            this.thumbiconPanel.ResumeLayout(false);
            this.thumbiconPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem fileMenuItem;
        private System.Windows.Forms.MenuItem fileOpenMenuItem;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem fileExitMenuItem;
        private System.Windows.Forms.MenuItem editMenuItem;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem viewMenuItem;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem imageResizeToFitMenuItem;
        private System.Windows.Forms.MenuItem imageBiggerSizeOkMenuItem;
        private System.Windows.Forms.MenuItem imageMemoryOnlyMenuItem;
        private System.Windows.Forms.MenuItem imageIconOnlyMenuItem;
        private System.Windows.Forms.MenuItem imageThumbnailOnlyMenuItem;
        private System.Windows.Forms.MenuItem imageInCacheOnlyMenuItem;
        private System.Windows.Forms.MenuItem imageCropToSquareMenuItem;
        private System.Windows.Forms.MenuItem imageWideThumbnailsMenuItem;
        private System.Windows.Forms.MenuItem imageIconBackgroundMenuItem;
        private System.Windows.Forms.MenuItem imageScaleUpMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.PictureBox thumbiconPictureBox;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.StatusBarPanel actualSizeStatusBarPanel;
        private System.Windows.Forms.MenuItem imageSizeMenuItem;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Panel thumbiconPanel;
        private System.Windows.Forms.MenuItem editCopyMenuItem;
        private System.Windows.Forms.MenuItem viewBackgroundColorMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.StatusBarPanel desiredSizeStatusBarPanel;
        private System.Windows.Forms.MenuItem fileSaveAsMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

