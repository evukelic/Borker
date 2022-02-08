namespace Borker.PresentationLayer
{
    partial class ProfileForm
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnApplied = new System.Windows.Forms.Button();
            this.buttonMyBorkers = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.buttonMyBorkers);
            this.panel1.Controls.Add(this.btnApplied);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 65);
            this.panel1.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelUsername.Location = new System.Drawing.Point(60, 26);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(0, 17);
            this.labelUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 65);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(798, 523);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // btnApplied
            // 
            this.btnApplied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(92)))), ((int)(((byte)(90)))));
            this.btnApplied.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplied.FlatAppearance.BorderSize = 0;
            this.btnApplied.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(92)))), ((int)(((byte)(90)))));
            this.btnApplied.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(130)))), ((int)(((byte)(127)))));
            this.btnApplied.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplied.ForeColor = System.Drawing.Color.Silver;
            this.btnApplied.Location = new System.Drawing.Point(691, 20);
            this.btnApplied.Name = "btnApplied";
            this.btnApplied.Size = new System.Drawing.Size(75, 23);
            this.btnApplied.TabIndex = 16;
            this.btnApplied.Text = "Applied For";
            this.btnApplied.UseVisualStyleBackColor = false;
            this.btnApplied.Click += new System.EventHandler(this.btnApplied_Click);
            // 
            // buttonMyBorkers
            // 
            this.buttonMyBorkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(92)))), ((int)(((byte)(90)))));
            this.buttonMyBorkers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMyBorkers.FlatAppearance.BorderSize = 0;
            this.buttonMyBorkers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(92)))), ((int)(((byte)(90)))));
            this.buttonMyBorkers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(130)))), ((int)(((byte)(127)))));
            this.buttonMyBorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyBorkers.ForeColor = System.Drawing.Color.Silver;
            this.buttonMyBorkers.Location = new System.Drawing.Point(597, 20);
            this.buttonMyBorkers.Name = "buttonMyBorkers";
            this.buttonMyBorkers.Size = new System.Drawing.Size(75, 23);
            this.buttonMyBorkers.TabIndex = 16;
            this.buttonMyBorkers.Text = "My Borkers";
            this.buttonMyBorkers.UseVisualStyleBackColor = false;
            this.buttonMyBorkers.Click += new System.EventHandler(this.buttonMyBorkers_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(798, 588);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button buttonMyBorkers;
        private System.Windows.Forms.Button btnApplied;
    }
}