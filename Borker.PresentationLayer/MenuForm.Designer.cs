namespace Borker.PresentationLayer
{
    partial class MenuForm
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnAvailableBorkers = new System.Windows.Forms.Button();
            this.panelAppLogo = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelSidebar.Controls.Add(this.btnSignOut);
            this.panelSidebar.Controls.Add(this.btnSignIn);
            this.panelSidebar.Controls.Add(this.btnInfo);
            this.panelSidebar.Controls.Add(this.btnProfile);
            this.panelSidebar.Controls.Add(this.btnAvailableBorkers);
            this.panelSidebar.Controls.Add(this.panelAppLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 627);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(92)))), ((int)(((byte)(90)))));
            this.btnSignOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(130)))), ((int)(((byte)(127)))));
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.ForeColor = System.Drawing.Color.Silver;
            this.btnSignOut.Image = global::Borker.PresentationLayer.Properties.Resources.sign_out;
            this.btnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.Location = new System.Drawing.Point(0, 319);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(250, 45);
            this.btnSignOut.TabIndex = 4;
            this.btnSignOut.Text = "  Sign Out";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(92)))), ((int)(((byte)(90)))));
            this.btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(130)))), ((int)(((byte)(127)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.ForeColor = System.Drawing.Color.Silver;
            this.btnSignIn.Image = global::Borker.PresentationLayer.Properties.Resources.sign_in;
            this.btnSignIn.Location = new System.Drawing.Point(0, 274);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(250, 45);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "  Sign In";
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(92)))), ((int)(((byte)(90)))));
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(130)))), ((int)(((byte)(127)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.Color.Silver;
            this.btnInfo.Image = global::Borker.PresentationLayer.Properties.Resources.info;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 229);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(250, 45);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "  Info";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(92)))), ((int)(((byte)(90)))));
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(130)))), ((int)(((byte)(127)))));
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.ForeColor = System.Drawing.Color.Silver;
            this.btnProfile.Image = global::Borker.PresentationLayer.Properties.Resources.profile;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 184);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(250, 45);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "  Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnAvailableBorkers
            // 
            this.btnAvailableBorkers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvailableBorkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAvailableBorkers.FlatAppearance.BorderSize = 0;
            this.btnAvailableBorkers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(92)))), ((int)(((byte)(90)))));
            this.btnAvailableBorkers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(130)))), ((int)(((byte)(127)))));
            this.btnAvailableBorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvailableBorkers.ForeColor = System.Drawing.Color.Silver;
            this.btnAvailableBorkers.Image = global::Borker.PresentationLayer.Properties.Resources.borker;
            this.btnAvailableBorkers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvailableBorkers.Location = new System.Drawing.Point(0, 139);
            this.btnAvailableBorkers.Name = "btnAvailableBorkers";
            this.btnAvailableBorkers.Size = new System.Drawing.Size(250, 45);
            this.btnAvailableBorkers.TabIndex = 0;
            this.btnAvailableBorkers.Text = "  Available Borkers";
            this.btnAvailableBorkers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvailableBorkers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAvailableBorkers.UseVisualStyleBackColor = true;
            this.btnAvailableBorkers.Click += new System.EventHandler(this.btnAvailableBorkers_Click);
            // 
            // panelAppLogo
            // 
            this.panelAppLogo.BackgroundImage = global::Borker.PresentationLayer.Properties.Resources.borker_logo;
            this.panelAppLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAppLogo.Location = new System.Drawing.Point(0, 0);
            this.panelAppLogo.Name = "panelAppLogo";
            this.panelAppLogo.Size = new System.Drawing.Size(250, 139);
            this.panelAppLogo.TabIndex = 0;
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(250, 0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(814, 627);
            this.panelData.TabIndex = 1;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(92)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1064, 627);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnAvailableBorkers;
        private System.Windows.Forms.Panel panelAppLogo;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel panelData;
    }
}