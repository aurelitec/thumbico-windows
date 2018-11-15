// <copyright file="MainForm.cs" company="Aurelitec">
// Copyright (c) Aurelitec (https://www.aurelitec.com)
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace Thumbico
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// The main Thumbico form.
    /// </summary>
    public partial class MainForm : Form
    {
        private string thumbiconFileName;
        //private int thumbiconWidth = 256;
        //private int thumbiconHeight = 256;
        private Size thumbiconSize = new Size(256, 256);
        private ThumbnailFlags thumbiconFlags;

        private SizeForm sizeForm;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // Set the form's font to the default operating system font (Segoe UI on Vista)
            this.Font = SystemFonts.MessageBoxFont;

            // Required method for designer support
            this.InitializeComponent();

            this.imageResizeToFitMenuItem.Tag = ThumbnailFlags.ResizeToFit;
            this.imageBiggerSizeOkMenuItem.Tag = ThumbnailFlags.BiggerSizeOk;
            this.imageMemoryOnlyMenuItem.Tag = ThumbnailFlags.MemoryOnly;
            this.imageIconOnlyMenuItem.Tag = ThumbnailFlags.IconOnly;
            this.imageThumbnailOnlyMenuItem.Tag = ThumbnailFlags.ThumbnailOnly;
            this.imageInCacheOnlyMenuItem.Tag = ThumbnailFlags.InCacheOnly;
            this.imageCropToSquareMenuItem.Tag = ThumbnailFlags.CropToSquare;
            this.imageWideThumbnailsMenuItem.Tag = ThumbnailFlags.WideThumbnails;
            this.imageIconBackgroundMenuItem.Tag = ThumbnailFlags.IconBackground;
            this.imageScaleUpMenuItem.Tag = ThumbnailFlags.ScaleUp;

            this.sizeForm = new SizeForm();
        }

        private string ThumbiconFileName
        {
            get
            {
                return this.thumbiconFileName;
            }

            set
            {
                this.thumbiconFileName = value;
                this.ReloadThumbicon();
            }
        }

        private Size ThumbiconSize
        {
            get
            {
                return this.thumbiconSize;
            }

            set
            {
                this.thumbiconSize = value;
                this.ReloadThumbicon();
            }
        }

        private ThumbnailFlags ThumbiconFlags
        {
            get
            {
                return this.thumbiconFlags;
            }

            set
            {
                this.thumbiconFlags = value;
                this.ReloadThumbicon();
            }
        }

        private void FileOpenMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.ThumbiconFileName = this.openFileDialog.FileName;
            }
        }

        /// <summary>
        /// Reloads the thumbnail or icon of the current file
        /// </summary>
        private void ReloadThumbicon()
        {
            Image oldThumbnail = this.thumbiconPictureBox.Image;

            // Try to get the thumbnail or icon from the Windows Shell
            try
            {
                this.thumbiconPictureBox.Image = ShellThumbnail.GetThumbnail(
                    this.ThumbiconFileName,
                    this.ThumbiconSize.Width,
                    this.ThumbiconSize.Height,
                    this.ThumbiconFlags,
                    out bool isIcon);
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message, "Error loading thumbnail or icon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool haveImage = this.thumbiconPictureBox.Image != null;
            this.sizeStatusBarPanel.Text = haveImage ? $"{this.thumbiconPictureBox.Image.Width} x {this.thumbiconPictureBox.Image.Height}" : string.Empty;

            // Because thumbnail bitmaps can be large, release the memory used by previous thumbnail managed bitmap
            if (oldThumbnail != null)
            {
                oldThumbnail.Dispose();
                GC.Collect();
            }
        }

        private void ImageFlagsMenuItems_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem senderMenuItem)
            {
                senderMenuItem.Checked = !senderMenuItem.Checked;
                ThumbnailFlags flag = (ThumbnailFlags)senderMenuItem.Tag;
                this.ThumbiconFlags = senderMenuItem.Checked ? this.ThumbiconFlags | flag : this.ThumbiconFlags & ~flag;
            }
        }

        // *************************************
        // Drag and Drop
        // *************************************

        /// <summary>
        /// Informs the system that the main form accepts drag and drop operations with file/folder items
        /// </summary>
        /// <param name="sender">The object where the event handler is attached.</param>
        /// <param name="e">The event data.</param>
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
        }

        /// <summary>
        /// Gets the file/folder that was dragged and dropped on the main form and loads its thumbicon.
        /// </summary>
        /// <param name="sender">The object where the event handler is attached.</param>
        /// <param name="e">The event data.</param>
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileItems = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (fileItems.Length > 0)
            {
                this.ThumbiconFileName = fileItems[0];
            }
        }

        private void ImageSizeMenuItem_Click(object sender, EventArgs e)
        {
            if (this.sizeForm.ShowDialog(this) == DialogResult.OK)
            {
                this.ThumbiconSize = new Size(
                    (int)this.sizeForm.widthNumericUpDown.Value,
                    (int)this.sizeForm.heightNumericUpDown.Value);
            }
        }

        private void statusBar_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {
            switch (this.statusBar.Panels.IndexOf(e.StatusBarPanel))
            {
                case 1:
                    this.imageSizeMenuItem.PerformClick();
                    break;
            }
        }
    }
}
