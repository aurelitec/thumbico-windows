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
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.FileOpenMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.ImageResizeToFitMenuItem = new System.Windows.Forms.MenuItem();
            this.ImageBiggerSizeOkMenuItem = new System.Windows.Forms.MenuItem();
            this.ImageMemoryOnlyMenuItem = new System.Windows.Forms.MenuItem();
            this.ImageIconOnlyMenuItem = new System.Windows.Forms.MenuItem();
            this.ImageThumbnailOnlyMenuItem = new System.Windows.Forms.MenuItem();
            this.ImageInCacheOnlyMenuItem = new System.Windows.Forms.MenuItem();
            this.ImageCropToSquareMenuItem = new System.Windows.Forms.MenuItem();
            this.ImageWideThumbnailsMenuItem = new System.Windows.Forms.MenuItem();
            this.ImageIconBackgroundMenuItem = new System.Windows.Forms.MenuItem();
            this.ImageScaleUpMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.thumbiconPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.thumbiconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem5,
            this.menuItem6,
            this.menuItem7,
            this.menuItem8});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FileOpenMenuItem,
            this.menuItem3,
            this.menuItem4});
            this.menuItem1.Text = "&File";
            // 
            // FileOpenMenuItem
            // 
            this.FileOpenMenuItem.Index = 0;
            this.FileOpenMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.FileOpenMenuItem.Text = "&Open...";
            this.FileOpenMenuItem.Click += new System.EventHandler(this.FileOpenMenuItem_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "-";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "E&xit";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "&Edit";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 2;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ImageResizeToFitMenuItem,
            this.ImageBiggerSizeOkMenuItem,
            this.ImageMemoryOnlyMenuItem,
            this.ImageIconOnlyMenuItem,
            this.ImageThumbnailOnlyMenuItem,
            this.ImageInCacheOnlyMenuItem,
            this.ImageCropToSquareMenuItem,
            this.ImageWideThumbnailsMenuItem,
            this.ImageIconBackgroundMenuItem,
            this.ImageScaleUpMenuItem});
            this.menuItem6.Text = "&Image";
            // 
            // ImageResizeToFitMenuItem
            // 
            this.ImageResizeToFitMenuItem.Checked = true;
            this.ImageResizeToFitMenuItem.Index = 0;
            this.ImageResizeToFitMenuItem.Text = "Resize To Fit";
            this.ImageResizeToFitMenuItem.Click += new System.EventHandler(this.ImageFlagsMenuItems_Click);
            // 
            // ImageBiggerSizeOkMenuItem
            // 
            this.ImageBiggerSizeOkMenuItem.Index = 1;
            this.ImageBiggerSizeOkMenuItem.Text = "Bigger Size Ok";
            this.ImageBiggerSizeOkMenuItem.Click += new System.EventHandler(this.ImageFlagsMenuItems_Click);
            // 
            // ImageMemoryOnlyMenuItem
            // 
            this.ImageMemoryOnlyMenuItem.Index = 2;
            this.ImageMemoryOnlyMenuItem.Text = "Memory Only";
            this.ImageMemoryOnlyMenuItem.Click += new System.EventHandler(this.ImageFlagsMenuItems_Click);
            // 
            // ImageIconOnlyMenuItem
            // 
            this.ImageIconOnlyMenuItem.Index = 3;
            this.ImageIconOnlyMenuItem.Text = "Icon Only";
            this.ImageIconOnlyMenuItem.Click += new System.EventHandler(this.ImageFlagsMenuItems_Click);
            // 
            // ImageThumbnailOnlyMenuItem
            // 
            this.ImageThumbnailOnlyMenuItem.Index = 4;
            this.ImageThumbnailOnlyMenuItem.Text = "Thumbnail Only";
            this.ImageThumbnailOnlyMenuItem.Click += new System.EventHandler(this.ImageFlagsMenuItems_Click);
            // 
            // ImageInCacheOnlyMenuItem
            // 
            this.ImageInCacheOnlyMenuItem.Index = 5;
            this.ImageInCacheOnlyMenuItem.Text = "In Cache Only";
            this.ImageInCacheOnlyMenuItem.Click += new System.EventHandler(this.ImageFlagsMenuItems_Click);
            // 
            // ImageCropToSquareMenuItem
            // 
            this.ImageCropToSquareMenuItem.Index = 6;
            this.ImageCropToSquareMenuItem.Text = "Crop To Square";
            this.ImageCropToSquareMenuItem.Click += new System.EventHandler(this.ImageFlagsMenuItems_Click);
            // 
            // ImageWideThumbnailsMenuItem
            // 
            this.ImageWideThumbnailsMenuItem.Index = 7;
            this.ImageWideThumbnailsMenuItem.Text = "Wide Thumbnails";
            this.ImageWideThumbnailsMenuItem.Click += new System.EventHandler(this.ImageFlagsMenuItems_Click);
            // 
            // ImageIconBackgroundMenuItem
            // 
            this.ImageIconBackgroundMenuItem.Index = 8;
            this.ImageIconBackgroundMenuItem.Text = "Icon Background";
            this.ImageIconBackgroundMenuItem.Click += new System.EventHandler(this.ImageFlagsMenuItems_Click);
            // 
            // ImageScaleUpMenuItem
            // 
            this.ImageScaleUpMenuItem.Index = 9;
            this.ImageScaleUpMenuItem.Text = "Scale Up";
            this.ImageScaleUpMenuItem.Click += new System.EventHandler(this.ImageFlagsMenuItems_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 3;
            this.menuItem7.Text = "&View";
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
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 428);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(800, 22);
            this.statusBar1.TabIndex = 0;
            this.statusBar1.Text = "statusBar1";
            // 
            // thumbiconPictureBox
            // 
            this.thumbiconPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thumbiconPictureBox.Location = new System.Drawing.Point(0, 0);
            this.thumbiconPictureBox.Name = "thumbiconPictureBox";
            this.thumbiconPictureBox.Size = new System.Drawing.Size(800, 428);
            this.thumbiconPictureBox.TabIndex = 1;
            this.thumbiconPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.thumbiconPictureBox);
            this.Controls.Add(this.statusBar1);
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.Text = "Thumbico";
            ((System.ComponentModel.ISupportInitialize)(this.thumbiconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem FileOpenMenuItem;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem ImageResizeToFitMenuItem;
        private System.Windows.Forms.MenuItem ImageBiggerSizeOkMenuItem;
        private System.Windows.Forms.MenuItem ImageMemoryOnlyMenuItem;
        private System.Windows.Forms.MenuItem ImageIconOnlyMenuItem;
        private System.Windows.Forms.MenuItem ImageThumbnailOnlyMenuItem;
        private System.Windows.Forms.MenuItem ImageInCacheOnlyMenuItem;
        private System.Windows.Forms.MenuItem ImageCropToSquareMenuItem;
        private System.Windows.Forms.MenuItem ImageWideThumbnailsMenuItem;
        private System.Windows.Forms.MenuItem ImageIconBackgroundMenuItem;
        private System.Windows.Forms.MenuItem ImageScaleUpMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.PictureBox thumbiconPictureBox;
    }
}

