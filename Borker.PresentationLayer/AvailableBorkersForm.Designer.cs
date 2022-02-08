namespace Borker.PresentationLayer
{
    partial class AvailableBorkersForm
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
            this.panelTopbar = new System.Windows.Forms.Panel();
            this.btnAddBorker = new System.Windows.Forms.Button();
            this.panelBorkers = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBorkers.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopbar
            // 
            this.panelTopbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopbar.Location = new System.Drawing.Point(0, 0);
            this.panelTopbar.Name = "panelTopbar";
            this.panelTopbar.Size = new System.Drawing.Size(798, 65);
            this.panelTopbar.TabIndex = 0;
            // 
            // btnAddBorker
            // 
            this.btnAddBorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(92)))), ((int)(((byte)(90)))));
            this.btnAddBorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBorker.FlatAppearance.BorderSize = 0;
            this.btnAddBorker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(92)))), ((int)(((byte)(90)))));
            this.btnAddBorker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(130)))), ((int)(((byte)(127)))));
            this.btnAddBorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBorker.ForeColor = System.Drawing.Color.Silver;
            this.btnAddBorker.Location = new System.Drawing.Point(689, 21);
            this.btnAddBorker.Name = "btnAddBorker";
            this.btnAddBorker.Size = new System.Drawing.Size(97, 23);
            this.btnAddBorker.TabIndex = 16;
            this.btnAddBorker.Text = "Add Borker";
            this.btnAddBorker.UseVisualStyleBackColor = false;
            this.btnAddBorker.Click += new System.EventHandler(this.btnAddBorker_Click);
            // 
            // panelBorkers
            // 
            this.panelBorkers.Controls.Add(this.flowLayoutPanel);
            this.panelBorkers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorkers.Location = new System.Drawing.Point(0, 65);
            this.panelBorkers.Name = "panelBorkers";
            this.panelBorkers.Size = new System.Drawing.Size(798, 530);
            this.panelBorkers.TabIndex = 17;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(798, 530);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // AvailableBorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(798, 595);
            this.Controls.Add(this.panelBorkers);
            this.Controls.Add(this.btnAddBorker);
            this.Controls.Add(this.panelTopbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AvailableBorkersForm";
            this.Text = "AvailableBorkersForm";
            this.panelBorkers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopbar;
        private System.Windows.Forms.Button btnAddBorker;
        private System.Windows.Forms.Panel panelBorkers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}