// <copyright file="SizeForm.cs" company="Aurelitec">
// Copyright (c) Aurelitec (https://www.aurelitec.com)
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace Thumbico
{
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// The Thumbico size form.
    /// </summary>
    public partial class SizeForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SizeForm"/> class.
        /// </summary>
        public SizeForm()
        {
            // Set the form's font to the default operating system font (Segoe UI on Vista)
            this.Font = SystemFonts.MessageBoxFont;

            // Required method for designer support
            this.InitializeComponent();
        }
    }
}
