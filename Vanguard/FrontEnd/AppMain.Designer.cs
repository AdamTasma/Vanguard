namespace Vanguard.FrontEnd
{
    partial class AppMain
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
            this.DbVersionLbl = new System.Windows.Forms.Label();
            this.savedCharacterBtn = new System.Windows.Forms.Button();
            this.newCharacterBtn = new System.Windows.Forms.Button();
            this.savedCharactersUC1 = new Vanguard.FrontEnd.SavedCharactersUC();
            this.characterCreationUC1 = new Vanguard.FrontEnd.CharacterCreationUC();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuPanel.Controls.Add(this.DbVersionLbl);
            this.MenuPanel.Controls.Add(this.savedCharacterBtn);
            this.MenuPanel.Controls.Add(this.newCharacterBtn);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 450);
            this.MenuPanel.TabIndex = 0;
            // 
            // DbVersionLbl
            // 
            this.DbVersionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DbVersionLbl.AutoSize = true;
            this.DbVersionLbl.Location = new System.Drawing.Point(4, 434);
            this.DbVersionLbl.Name = "DbVersionLbl";
            this.DbVersionLbl.Size = new System.Drawing.Size(59, 13);
            this.DbVersionLbl.TabIndex = 2;
            this.DbVersionLbl.Text = "DbVersion:";
            // 
            // savedCharacterBtn
            // 
            this.savedCharacterBtn.Location = new System.Drawing.Point(43, 229);
            this.savedCharacterBtn.Name = "savedCharacterBtn";
            this.savedCharacterBtn.Size = new System.Drawing.Size(142, 23);
            this.savedCharacterBtn.TabIndex = 1;
            this.savedCharacterBtn.Text = "Saved Character List";
            this.savedCharacterBtn.UseVisualStyleBackColor = true;
            this.savedCharacterBtn.Click += new System.EventHandler(this.savedCharacterBtn_Click);
            // 
            // newCharacterBtn
            // 
            this.newCharacterBtn.Location = new System.Drawing.Point(43, 144);
            this.newCharacterBtn.Name = "newCharacterBtn";
            this.newCharacterBtn.Size = new System.Drawing.Size(142, 23);
            this.newCharacterBtn.TabIndex = 0;
            this.newCharacterBtn.Text = "Create a New Characater";
            this.newCharacterBtn.UseVisualStyleBackColor = true;
            this.newCharacterBtn.Click += new System.EventHandler(this.newCharacterBtn_Click);
            // 
            // savedCharactersUC1
            // 
            this.savedCharactersUC1.Location = new System.Drawing.Point(207, 189);
            this.savedCharactersUC1.Name = "savedCharactersUC1";
            this.savedCharactersUC1.Size = new System.Drawing.Size(564, 261);
            this.savedCharactersUC1.TabIndex = 2;
            // 
            // characterCreationUC1
            // 
            this.characterCreationUC1.Location = new System.Drawing.Point(207, 13);
            this.characterCreationUC1.Name = "characterCreationUC1";
            this.characterCreationUC1.Size = new System.Drawing.Size(581, 136);
            this.characterCreationUC1.TabIndex = 1;
            // 
            // AppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.savedCharactersUC1);
            this.Controls.Add(this.characterCreationUC1);
            this.Controls.Add(this.MenuPanel);
            this.Name = "AppMain";
            this.Text = "AppMain";
            this.Load += new System.EventHandler(this.AppMain_Load);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button savedCharacterBtn;
        private System.Windows.Forms.Button newCharacterBtn;
        private CharacterCreationUC characterCreationUC1;
        private SavedCharactersUC savedCharactersUC1;
        private System.Windows.Forms.Label DbVersionLbl;
    }
}