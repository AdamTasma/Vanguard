namespace Vanguard.Forms
{
    partial class Vanguard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnP3Previous = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnP1Next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnP2Next = new System.Windows.Forms.Button();
            this.btnP2Previous = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnP1Next);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 187);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnP3Previous);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 164);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // btnP3Previous
            // 
            this.btnP3Previous.Location = new System.Drawing.Point(33, 129);
            this.btnP3Previous.Name = "btnP3Previous";
            this.btnP3Previous.Size = new System.Drawing.Size(75, 23);
            this.btnP3Previous.TabIndex = 1;
            this.btnP3Previous.Text = "Previous";
            this.btnP3Previous.UseVisualStyleBackColor = true;
            this.btnP3Previous.Click += new System.EventHandler(this.btnP3Previous_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "page 3";
            // 
            // btnP1Next
            // 
            this.btnP1Next.Location = new System.Drawing.Point(165, 129);
            this.btnP1Next.Name = "btnP1Next";
            this.btnP1Next.Size = new System.Drawing.Size(75, 23);
            this.btnP1Next.TabIndex = 2;
            this.btnP1Next.Text = "Next";
            this.btnP1Next.UseVisualStyleBackColor = true;
            this.btnP1Next.Click += new System.EventHandler(this.btnP1Next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "page 1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnP2Next);
            this.panel2.Controls.Add(this.btnP2Previous);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 203);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // btnP2Next
            // 
            this.btnP2Next.Location = new System.Drawing.Point(162, 113);
            this.btnP2Next.Name = "btnP2Next";
            this.btnP2Next.Size = new System.Drawing.Size(75, 23);
            this.btnP2Next.TabIndex = 2;
            this.btnP2Next.Text = "Next";
            this.btnP2Next.UseVisualStyleBackColor = true;
            this.btnP2Next.Click += new System.EventHandler(this.btnP2Next_Click);
            // 
            // btnP2Previous
            // 
            this.btnP2Previous.Location = new System.Drawing.Point(30, 113);
            this.btnP2Previous.Name = "btnP2Previous";
            this.btnP2Previous.Size = new System.Drawing.Size(75, 23);
            this.btnP2Previous.TabIndex = 1;
            this.btnP2Previous.Text = "previous";
            this.btnP2Previous.UseVisualStyleBackColor = true;
            this.btnP2Previous.Click += new System.EventHandler(this.btnP2Previous_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "page 2";
            // 
            // Vanguard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Vanguard";
            this.Text = "Vanguard";
            this.Load += new System.EventHandler(this.Vanguard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnP1Next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnP2Next;
        private System.Windows.Forms.Button btnP2Previous;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnP3Previous;
        private System.Windows.Forms.Label label4;
    }
}