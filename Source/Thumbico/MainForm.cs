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
        private int thumbiconWidth = 256;
        private int thumbiconHeight = 256;
        private ThumbnailFlags thumbiconFlags;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // Set the form's font to the default operating system font (Segoe UI on Vista)
            this.Font = SystemFonts.MessageBoxFont;

            // Required method for designer support
            this.InitializeComponent();

            this.ImageResizeToFitMenuItem.Tag = ThumbnailFlags.ResizeToFit;
            this.ImageBiggerSizeOkMenuItem.Tag = ThumbnailFlags.BiggerSizeOk;
            this.ImageMemoryOnlyMenuItem.Tag = ThumbnailFlags.MemoryOnly;
            this.ImageIconOnlyMenuItem.Tag = ThumbnailFlags.IconOnly;
            this.ImageThumbnailOnlyMenuItem.Tag = ThumbnailFlags.ThumbnailOnly;
            this.ImageInCacheOnlyMenuItem.Tag = ThumbnailFlags.InCacheOnly;
            this.ImageCropToSquareMenuItem.Tag = ThumbnailFlags.CropToSquare;
            this.ImageWideThumbnailsMenuItem.Tag = ThumbnailFlags.WideThumbnails;
            this.ImageIconBackgroundMenuItem.Tag = ThumbnailFlags.IconBackground;
            this.ImageScaleUpMenuItem.Tag = ThumbnailFlags.ScaleUp;
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

        private int ThumbiconWidth
        {
            get
            {
                return this.thumbiconWidth;
            }

            set
            {
                this.thumbiconWidth = value;
                this.ReloadThumbicon();
            }
        }

        private int ThumbiconHeight
        {
            get
            {
                return this.thumbiconHeight;
            }

            set
            {
                this.thumbiconHeight = value;
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
                bool isIcon;
                this.thumbiconPictureBox.Image = ShellThumbnail.GetThumbnail(
                    this.ThumbiconFileName,
                    this.ThumbiconWidth,
                    this.ThumbiconHeight,
                    this.ThumbiconFlags,
                    out isIcon);
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message, "Error loading thumbnail or icon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
    }
}
