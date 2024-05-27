namespace Hotel_Management_System
{
    partial class RequestServicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestServicesForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton_yes_roomService = new System.Windows.Forms.RadioButton();
            this.radioButton_yes_extraTowels = new System.Windows.Forms.RadioButton();
            this.radioButton_yes_extraBed = new System.Windows.Forms.RadioButton();
            this.radioButton_no_roomService = new System.Windows.Forms.RadioButton();
            this.radioButton_no_extraTowels = new System.Windows.Forms.RadioButton();
            this.radioButton_no_extraBed = new System.Windows.Forms.RadioButton();
            this.groupBox_roomService = new System.Windows.Forms.GroupBox();
            this.groupBox_extraTowels = new System.Windows.Forms.GroupBox();
            this.groupBox_extraBed = new System.Windows.Forms.GroupBox();
            this.groupBox_cleanService = new System.Windows.Forms.GroupBox();
            this.radioButton_yes_cleanService = new System.Windows.Forms.RadioButton();
            this.radioButton_no_cleanService = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox_roomService.SuspendLayout();
            this.groupBox_extraTowels.SuspendLayout();
            this.groupBox_extraBed.SuspendLayout();
            this.groupBox_cleanService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request Services";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1430, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_clean);
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 704);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1475, 143);
            this.panel1.TabIndex = 2;
            // 
            // button_clean
            // 
            this.button_clean.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_clean.FlatAppearance.BorderSize = 0;
            this.button_clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clean.Font = new System.Drawing.Font("Arial", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clean.Image = ((System.Drawing.Image)(resources.GetObject("button_clean.Image")));
            this.button_clean.Location = new System.Drawing.Point(745, 0);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(724, 143);
            this.button_clean.TabIndex = 1;
            this.button_clean.Text = "Clean";
            this.button_clean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // button_save
            // 
            this.button_save.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Arial", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Image = ((System.Drawing.Image)(resources.GetObject("button_save.Image")));
            this.button_save.Location = new System.Drawing.Point(0, 0);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(745, 143);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Save";
            this.button_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 523);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "Room Service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(814, 634);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 42);
            this.label4.TabIndex = 4;
            this.label4.Text = "Extra Bed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(814, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 42);
            this.label5.TabIndex = 5;
            this.label5.Text = "Clean Service";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 634);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 42);
            this.label6.TabIndex = 6;
            this.label6.Text = "Extra Towels";
            // 
            // radioButton_yes_roomService
            // 
            this.radioButton_yes_roomService.AutoSize = true;
            this.radioButton_yes_roomService.Font = new System.Drawing.Font("Arial", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_yes_roomService.Location = new System.Drawing.Point(6, 42);
            this.radioButton_yes_roomService.Name = "radioButton_yes_roomService";
            this.radioButton_yes_roomService.Size = new System.Drawing.Size(102, 43);
            this.radioButton_yes_roomService.TabIndex = 7;
            this.radioButton_yes_roomService.TabStop = true;
            this.radioButton_yes_roomService.Text = "Yes";
            this.radioButton_yes_roomService.UseVisualStyleBackColor = true;
            this.radioButton_yes_roomService.CheckedChanged += new System.EventHandler(this.radioButton_yes_roomService_CheckedChanged);
            // 
            // radioButton_yes_extraTowels
            // 
            this.radioButton_yes_extraTowels.AutoSize = true;
            this.radioButton_yes_extraTowels.Font = new System.Drawing.Font("Arial", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_yes_extraTowels.Location = new System.Drawing.Point(6, 47);
            this.radioButton_yes_extraTowels.Name = "radioButton_yes_extraTowels";
            this.radioButton_yes_extraTowels.Size = new System.Drawing.Size(102, 43);
            this.radioButton_yes_extraTowels.TabIndex = 9;
            this.radioButton_yes_extraTowels.TabStop = true;
            this.radioButton_yes_extraTowels.Text = "Yes";
            this.radioButton_yes_extraTowels.UseVisualStyleBackColor = true;
            this.radioButton_yes_extraTowels.CheckedChanged += new System.EventHandler(this.radioButton_yes_extraTowels_CheckedChanged);
            // 
            // radioButton_yes_extraBed
            // 
            this.radioButton_yes_extraBed.AutoSize = true;
            this.radioButton_yes_extraBed.Font = new System.Drawing.Font("Arial", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_yes_extraBed.Location = new System.Drawing.Point(6, 52);
            this.radioButton_yes_extraBed.Name = "radioButton_yes_extraBed";
            this.radioButton_yes_extraBed.Size = new System.Drawing.Size(102, 43);
            this.radioButton_yes_extraBed.TabIndex = 10;
            this.radioButton_yes_extraBed.TabStop = true;
            this.radioButton_yes_extraBed.Text = "Yes";
            this.radioButton_yes_extraBed.UseVisualStyleBackColor = true;
            this.radioButton_yes_extraBed.CheckedChanged += new System.EventHandler(this.radioButton_yes_extraBed_CheckedChanged);
            // 
            // radioButton_no_roomService
            // 
            this.radioButton_no_roomService.AutoSize = true;
            this.radioButton_no_roomService.Checked = true;
            this.radioButton_no_roomService.Font = new System.Drawing.Font("Arial", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_no_roomService.Location = new System.Drawing.Point(144, 42);
            this.radioButton_no_roomService.Name = "radioButton_no_roomService";
            this.radioButton_no_roomService.Size = new System.Drawing.Size(88, 43);
            this.radioButton_no_roomService.TabIndex = 11;
            this.radioButton_no_roomService.TabStop = true;
            this.radioButton_no_roomService.Text = "No";
            this.radioButton_no_roomService.UseVisualStyleBackColor = true;
            this.radioButton_no_roomService.CheckedChanged += new System.EventHandler(this.radioButton_no_roomService_CheckedChanged);
            // 
            // radioButton_no_extraTowels
            // 
            this.radioButton_no_extraTowels.AutoSize = true;
            this.radioButton_no_extraTowels.Checked = true;
            this.radioButton_no_extraTowels.Font = new System.Drawing.Font("Arial", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_no_extraTowels.Location = new System.Drawing.Point(144, 45);
            this.radioButton_no_extraTowels.Name = "radioButton_no_extraTowels";
            this.radioButton_no_extraTowels.Size = new System.Drawing.Size(88, 43);
            this.radioButton_no_extraTowels.TabIndex = 13;
            this.radioButton_no_extraTowels.TabStop = true;
            this.radioButton_no_extraTowels.Text = "No";
            this.radioButton_no_extraTowels.UseVisualStyleBackColor = true;
            this.radioButton_no_extraTowels.CheckedChanged += new System.EventHandler(this.radioButton_no_extraTowels_CheckedChanged);
            // 
            // radioButton_no_extraBed
            // 
            this.radioButton_no_extraBed.AutoSize = true;
            this.radioButton_no_extraBed.Checked = true;
            this.radioButton_no_extraBed.Font = new System.Drawing.Font("Arial", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_no_extraBed.Location = new System.Drawing.Point(145, 50);
            this.radioButton_no_extraBed.Name = "radioButton_no_extraBed";
            this.radioButton_no_extraBed.Size = new System.Drawing.Size(88, 43);
            this.radioButton_no_extraBed.TabIndex = 14;
            this.radioButton_no_extraBed.TabStop = true;
            this.radioButton_no_extraBed.Text = "No";
            this.radioButton_no_extraBed.UseVisualStyleBackColor = true;
            this.radioButton_no_extraBed.CheckedChanged += new System.EventHandler(this.radioButton_no_extraBed_CheckedChanged);
            // 
            // groupBox_roomService
            // 
            this.groupBox_roomService.Controls.Add(this.radioButton_yes_roomService);
            this.groupBox_roomService.Controls.Add(this.radioButton_no_roomService);
            this.groupBox_roomService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_roomService.Location = new System.Drawing.Point(444, 477);
            this.groupBox_roomService.Name = "groupBox_roomService";
            this.groupBox_roomService.Size = new System.Drawing.Size(238, 110);
            this.groupBox_roomService.TabIndex = 31;
            this.groupBox_roomService.TabStop = false;
            // 
            // groupBox_extraTowels
            // 
            this.groupBox_extraTowels.Controls.Add(this.radioButton_yes_extraTowels);
            this.groupBox_extraTowels.Controls.Add(this.radioButton_no_extraTowels);
            this.groupBox_extraTowels.Location = new System.Drawing.Point(444, 588);
            this.groupBox_extraTowels.Name = "groupBox_extraTowels";
            this.groupBox_extraTowels.Size = new System.Drawing.Size(238, 107);
            this.groupBox_extraTowels.TabIndex = 32;
            this.groupBox_extraTowels.TabStop = false;
            // 
            // groupBox_extraBed
            // 
            this.groupBox_extraBed.Controls.Add(this.radioButton_yes_extraBed);
            this.groupBox_extraBed.Controls.Add(this.radioButton_no_extraBed);
            this.groupBox_extraBed.Location = new System.Drawing.Point(1115, 584);
            this.groupBox_extraBed.Name = "groupBox_extraBed";
            this.groupBox_extraBed.Size = new System.Drawing.Size(239, 114);
            this.groupBox_extraBed.TabIndex = 34;
            this.groupBox_extraBed.TabStop = false;
            // 
            // groupBox_cleanService
            // 
            this.groupBox_cleanService.BackColor = System.Drawing.SystemColors.WindowText;
            this.groupBox_cleanService.Controls.Add(this.radioButton_yes_cleanService);
            this.groupBox_cleanService.Controls.Add(this.radioButton_no_cleanService);
            this.groupBox_cleanService.Location = new System.Drawing.Point(1115, 477);
            this.groupBox_cleanService.Name = "groupBox_cleanService";
            this.groupBox_cleanService.Size = new System.Drawing.Size(239, 110);
            this.groupBox_cleanService.TabIndex = 35;
            this.groupBox_cleanService.TabStop = false;
            // 
            // radioButton_yes_cleanService
            // 
            this.radioButton_yes_cleanService.AutoSize = true;
            this.radioButton_yes_cleanService.Font = new System.Drawing.Font("Arial", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_yes_cleanService.Location = new System.Drawing.Point(6, 51);
            this.radioButton_yes_cleanService.Name = "radioButton_yes_cleanService";
            this.radioButton_yes_cleanService.Size = new System.Drawing.Size(102, 43);
            this.radioButton_yes_cleanService.TabIndex = 8;
            this.radioButton_yes_cleanService.TabStop = true;
            this.radioButton_yes_cleanService.Text = "Yes";
            this.radioButton_yes_cleanService.UseVisualStyleBackColor = true;
            // 
            // radioButton_no_cleanService
            // 
            this.radioButton_no_cleanService.AutoSize = true;
            this.radioButton_no_cleanService.Checked = true;
            this.radioButton_no_cleanService.Font = new System.Drawing.Font("Arial", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_no_cleanService.Location = new System.Drawing.Point(145, 47);
            this.radioButton_no_cleanService.Name = "radioButton_no_cleanService";
            this.radioButton_no_cleanService.Size = new System.Drawing.Size(88, 43);
            this.radioButton_no_cleanService.TabIndex = 12;
            this.radioButton_no_cleanService.TabStop = true;
            this.radioButton_no_cleanService.Text = "No";
            this.radioButton_no_cleanService.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1196, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // RequestServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(40F, 75F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1475, 847);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_cleanService);
            this.Controls.Add(this.groupBox_extraBed);
            this.Controls.Add(this.groupBox_extraTowels);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_roomService);
            this.Font = new System.Drawing.Font("Arial", 27.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.Name = "RequestServicesForm";
            this.Text = "RequestServicesForm";
            this.panel1.ResumeLayout(false);
            this.groupBox_roomService.ResumeLayout(false);
            this.groupBox_roomService.PerformLayout();
            this.groupBox_extraTowels.ResumeLayout(false);
            this.groupBox_extraTowels.PerformLayout();
            this.groupBox_extraBed.ResumeLayout(false);
            this.groupBox_extraBed.PerformLayout();
            this.groupBox_cleanService.ResumeLayout(false);
            this.groupBox_cleanService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton_yes_roomService;
        private System.Windows.Forms.RadioButton radioButton_yes_extraTowels;
        private System.Windows.Forms.RadioButton radioButton_yes_extraBed;
        private System.Windows.Forms.RadioButton radioButton_no_roomService;
        private System.Windows.Forms.RadioButton radioButton_no_extraTowels;
        private System.Windows.Forms.RadioButton radioButton_no_extraBed;
        private System.Windows.Forms.GroupBox groupBox_roomService;
        private System.Windows.Forms.GroupBox groupBox_extraTowels;
        private System.Windows.Forms.GroupBox groupBox_extraBed;
        private System.Windows.Forms.GroupBox groupBox_cleanService;
        private System.Windows.Forms.RadioButton radioButton_yes_cleanService;
        private System.Windows.Forms.RadioButton radioButton_no_cleanService;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}