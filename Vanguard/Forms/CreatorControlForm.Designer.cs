﻿namespace Vanguard.Forms
{
    partial class CreatorControlForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.creatorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // creatorLbl
            // 
            this.creatorLbl.AutoSize = true;
            this.creatorLbl.Location = new System.Drawing.Point(277, 112);
            this.creatorLbl.Name = "creatorLbl";
            this.creatorLbl.Size = new System.Drawing.Size(97, 13);
            this.creatorLbl.TabIndex = 0;
            this.creatorLbl.Text = "CreatorControlForm";
            // 
            // CreatorControlForm
            // 
            this.Controls.Add(this.creatorLbl);
            this.Name = "CreatorControlForm";
            this.Size = new System.Drawing.Size(720, 471);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creatorLbl;
    }
}