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
            this.newCharacterBtn = new System.Windows.Forms.Button();
            this.SavedCharacterBtn = new System.Windows.Forms.Button();
            this.characterCreationUC1 = new Vanguard.FrontEnd.CharacterCreationUC();
            this.savedCharactersCF1 = new Vanguard.FrontEnd.SavedCharactersCF();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuPanel.Controls.Add(this.SavedCharacterBtn);
            this.MenuPanel.Controls.Add(this.newCharacterBtn);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 450);
            this.MenuPanel.TabIndex = 0;
            // 
            // newCharacterBtn
            // 
            this.newCharacterBtn.Location = new System.Drawing.Point(43, 144);
            this.newCharacterBtn.Name = "newCharacterBtn";
            this.newCharacterBtn.Size = new System.Drawing.Size(142, 23);
            this.newCharacterBtn.TabIndex = 0;
            this.newCharacterBtn.Text = "Create a New Characater";
            this.newCharacterBtn.UseVisualStyleBackColor = true;
            // 
            // SavedCharacterBtn
            // 
            this.SavedCharacterBtn.Location = new System.Drawing.Point(43, 229);
            this.SavedCharacterBtn.Name = "SavedCharacterBtn";
            this.SavedCharacterBtn.Size = new System.Drawing.Size(142, 23);
            this.SavedCharacterBtn.TabIndex = 1;
            this.SavedCharacterBtn.Text = "Saved Character List";
            this.SavedCharacterBtn.UseVisualStyleBackColor = true;
            // 
            // characterCreationUC1
            // 
            this.characterCreationUC1.Location = new System.Drawing.Point(207, 13);
            this.characterCreationUC1.Name = "characterCreationUC1";
            this.characterCreationUC1.Size = new System.Drawing.Size(581, 136);
            this.characterCreationUC1.TabIndex = 1;
            // 
            // savedCharactersCF1
            // 
            this.savedCharactersCF1.Location = new System.Drawing.Point(207, 189);
            this.savedCharactersCF1.Name = "savedCharactersCF1";
            this.savedCharactersCF1.Size = new System.Drawing.Size(564, 261);
            this.savedCharactersCF1.TabIndex = 2;
            // 
            // AppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.savedCharactersCF1);
            this.Controls.Add(this.characterCreationUC1);
            this.Controls.Add(this.MenuPanel);
            this.Name = "AppMain";
            this.Text = "AppMain";
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button SavedCharacterBtn;
        private System.Windows.Forms.Button newCharacterBtn;
        private CharacterCreationUC characterCreationUC1;
        private SavedCharactersCF savedCharactersCF1;
    }
}