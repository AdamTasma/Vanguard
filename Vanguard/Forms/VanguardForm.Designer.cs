namespace Vanguard.Forms
{
    partial class VanguardForm
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.CreateCharacterBtn = new System.Windows.Forms.Button();
            this.SavedCharacterListBtn = new System.Windows.Forms.Button();
            this.creatorControlForm1 = new Vanguard.Forms.CreatorControlForm();
            this.savedCharactersControlForm1 = new Vanguard.Forms.SavedCharactersControlForm();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuPanel.Controls.Add(this.CreateCharacterBtn);
            this.MenuPanel.Controls.Add(this.SavedCharacterListBtn);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 674);
            this.MenuPanel.TabIndex = 0;
            // 
            // CreateCharacterBtn
            // 
            this.CreateCharacterBtn.Location = new System.Drawing.Point(12, 212);
            this.CreateCharacterBtn.Name = "CreateCharacterBtn";
            this.CreateCharacterBtn.Size = new System.Drawing.Size(165, 23);
            this.CreateCharacterBtn.TabIndex = 0;
            this.CreateCharacterBtn.Text = "Create New Character";
            this.CreateCharacterBtn.UseVisualStyleBackColor = true;
            this.CreateCharacterBtn.Click += new System.EventHandler(this.CreateCharacterBtn_Click);
            // 
            // SavedCharacterListBtn
            // 
            this.SavedCharacterListBtn.Location = new System.Drawing.Point(12, 283);
            this.SavedCharacterListBtn.Name = "SavedCharacterListBtn";
            this.SavedCharacterListBtn.Size = new System.Drawing.Size(165, 23);
            this.SavedCharacterListBtn.TabIndex = 1;
            this.SavedCharacterListBtn.Text = "Saved Character List";
            this.SavedCharacterListBtn.UseVisualStyleBackColor = true;
            this.SavedCharacterListBtn.Click += new System.EventHandler(this.SavedCharacterListBtn_Click);
            // 
            // creatorControlForm1
            // 
            this.creatorControlForm1.Location = new System.Drawing.Point(284, 62);
            this.creatorControlForm1.Name = "creatorControlForm1";
            this.creatorControlForm1.Size = new System.Drawing.Size(578, 221);
            this.creatorControlForm1.TabIndex = 1;
            // 
            // savedCharactersControlForm1
            // 
            this.savedCharactersControlForm1.Location = new System.Drawing.Point(313, 341);
            this.savedCharactersControlForm1.Name = "savedCharactersControlForm1";
            this.savedCharactersControlForm1.Size = new System.Drawing.Size(681, 205);
            this.savedCharactersControlForm1.TabIndex = 2;
            // 
            // VanguardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 674);
            this.Controls.Add(this.savedCharactersControlForm1);
            this.Controls.Add(this.creatorControlForm1);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VanguardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VanguardForm";
            this.Load += new System.EventHandler(this.VanguardForm_Load);
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button CreateCharacterBtn;
        private System.Windows.Forms.Button SavedCharacterListBtn;
        private CreatorControlForm creatorControlForm1;
        private SavedCharactersControlForm savedCharactersControlForm1;
    }
}