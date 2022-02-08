namespace Borker.PresentationLayer
{
    partial class AddBorkerForm
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
            this.labelAddBorker = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBreed = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBreed = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.btnAddBorker = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelErr = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddBorker
            // 
            this.labelAddBorker.AutoSize = true;
            this.labelAddBorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddBorker.ForeColor = System.Drawing.Color.Silver;
            this.labelAddBorker.Location = new System.Drawing.Point(237, 67);
            this.labelAddBorker.Name = "labelAddBorker";
            this.labelAddBorker.Size = new System.Drawing.Size(89, 20);
            this.labelAddBorker.TabIndex = 0;
            this.labelAddBorker.Text = "Add Borker";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Silver;
            this.labelName.Location = new System.Drawing.Point(237, 103);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelBreed
            // 
            this.labelBreed.AutoSize = true;
            this.labelBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBreed.ForeColor = System.Drawing.Color.Silver;
            this.labelBreed.Location = new System.Drawing.Point(237, 156);
            this.labelBreed.Name = "labelBreed";
            this.labelBreed.Size = new System.Drawing.Size(40, 15);
            this.labelBreed.TabIndex = 2;
            this.labelBreed.Text = "Breed";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.ForeColor = System.Drawing.Color.Silver;
            this.labelLocation.Location = new System.Drawing.Point(237, 209);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(183, 15);
            this.labelLocation.TabIndex = 3;
            this.labelLocation.Text = "Location (City / District / Address)";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.Silver;
            this.labelDate.Location = new System.Drawing.Point(237, 262);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 15);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Date";
            this.labelDate.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.ForeColor = System.Drawing.Color.Silver;
            this.labelDuration.Location = new System.Drawing.Point(237, 318);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(72, 15);
            this.labelDuration.TabIndex = 5;
            this.labelDuration.Text = "Duration (h)";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Silver;
            this.labelTime.Location = new System.Drawing.Point(419, 262);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(35, 15);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "Time";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.ForeColor = System.Drawing.Color.Silver;
            this.labelSalary.Location = new System.Drawing.Point(237, 373);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(105, 15);
            this.labelSalary.TabIndex = 7;
            this.labelSalary.Text = "Offered Salary (/h)";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(240, 121);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(320, 20);
            this.textBoxName.TabIndex = 8;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxBreed
            // 
            this.textBoxBreed.Location = new System.Drawing.Point(240, 174);
            this.textBoxBreed.Name = "textBoxBreed";
            this.textBoxBreed.Size = new System.Drawing.Size(320, 20);
            this.textBoxBreed.TabIndex = 9;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(240, 227);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(320, 20);
            this.textBoxLocation.TabIndex = 10;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(240, 391);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(320, 20);
            this.textBoxSalary.TabIndex = 11;
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd.MM.yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(240, 280);
            this.datePicker.MinDate = new System.DateTime(2022, 1, 11, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(173, 20);
            this.datePicker.TabIndex = 12;
            this.datePicker.Value = new System.DateTime(2022, 1, 13, 0, 0, 0, 0);
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "hh:mm tt";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(422, 280);
            this.timePicker.MinDate = new System.DateTime(2022, 1, 11, 0, 0, 0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(138, 20);
            this.timePicker.TabIndex = 13;
            this.timePicker.Value = new System.DateTime(2022, 1, 13, 13, 50, 25, 0);
            // 
            // numericUpDownDuration
            // 
            this.numericUpDownDuration.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownDuration.Location = new System.Drawing.Point(241, 336);
            this.numericUpDownDuration.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownDuration.Name = "numericUpDownDuration";
            this.numericUpDownDuration.Size = new System.Drawing.Size(320, 20);
            this.numericUpDownDuration.TabIndex = 14;
            this.numericUpDownDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.btnAddBorker.Location = new System.Drawing.Point(392, 442);
            this.btnAddBorker.Name = "btnAddBorker";
            this.btnAddBorker.Size = new System.Drawing.Size(75, 23);
            this.btnAddBorker.TabIndex = 15;
            this.btnAddBorker.Text = "Add Borker";
            this.btnAddBorker.UseVisualStyleBackColor = false;
            this.btnAddBorker.Click += new System.EventHandler(this.btnAddBorker_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(482, 442);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelErr
            // 
            this.labelErr.AutoSize = true;
            this.labelErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErr.ForeColor = System.Drawing.Color.Maroon;
            this.labelErr.Location = new System.Drawing.Point(325, 490);
            this.labelErr.Name = "labelErr";
            this.labelErr.Size = new System.Drawing.Size(41, 15);
            this.labelErr.TabIndex = 17;
            this.labelErr.Text = "label1";
            this.labelErr.Visible = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.Maroon;
            this.buttonDelete.Location = new System.Drawing.Point(468, 67);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(93, 23);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete Borker";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // AddBorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(782, 491);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelErr);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddBorker);
            this.Controls.Add(this.numericUpDownDuration);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxBreed);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelBreed);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAddBorker);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddBorkerForm";
            this.Text = "AddBorkerForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddBorker;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBreed;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBreed;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.NumericUpDown numericUpDownDuration;
        private System.Windows.Forms.Button btnAddBorker;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelErr;
        private System.Windows.Forms.Button buttonDelete;
    }
}