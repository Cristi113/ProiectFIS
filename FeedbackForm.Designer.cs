namespace Hotel_Management_System
{
    partial class FeedbackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedbackForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_rating = new System.Windows.Forms.Label();
            this.guna2RatingStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.label4 = new System.Windows.Forms.Label();
            this.outputRatings = new System.Windows.Forms.Label();
            this.label_staffFrienliness = new System.Windows.Forms.Label();
            this.label_roomCleanliness = new System.Windows.Forms.Label();
            this.label_hotelName = new System.Windows.Forms.Label();
            this.guna2RatingStar_staff = new Guna.UI2.WinForms.Guna2RatingStar();
            this.guna2RatingStar_room = new Guna.UI2.WinForms.Guna2RatingStar();
            this.label_staff0 = new System.Windows.Forms.Label();
            this.label_staffRatings = new System.Windows.Forms.Label();
            this.label_room0 = new System.Windows.Forms.Label();
            this.label_roomRatings = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.comboBox_hotel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(578, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feedback";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1435, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_rating
            // 
            this.label_rating.AutoSize = true;
            this.label_rating.Location = new System.Drawing.Point(160, 453);
            this.label_rating.Name = "label_rating";
            this.label_rating.Size = new System.Drawing.Size(134, 42);
            this.label_rating.TabIndex = 2;
            this.label_rating.Text = "Rating";
            // 
            // guna2RatingStar
            // 
            this.guna2RatingStar.BorderColor = System.Drawing.Color.Red;
            this.guna2RatingStar.BorderThickness = 3;
            this.guna2RatingStar.Location = new System.Drawing.Point(105, 498);
            this.guna2RatingStar.Name = "guna2RatingStar";
            this.guna2RatingStar.RatingColor = System.Drawing.Color.Red;
            this.guna2RatingStar.Size = new System.Drawing.Size(337, 58);
            this.guna2RatingStar.TabIndex = 3;
            this.guna2RatingStar.ValueChanged += new System.EventHandler(this.guna2RatingStar_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 559);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ratings: ";
            // 
            // outputRatings
            // 
            this.outputRatings.AutoSize = true;
            this.outputRatings.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputRatings.Location = new System.Drawing.Point(221, 559);
            this.outputRatings.Name = "outputRatings";
            this.outputRatings.Size = new System.Drawing.Size(30, 32);
            this.outputRatings.TabIndex = 5;
            this.outputRatings.Text = "0";
            // 
            // label_staffFrienliness
            // 
            this.label_staffFrienliness.AutoSize = true;
            this.label_staffFrienliness.Location = new System.Drawing.Point(98, 240);
            this.label_staffFrienliness.Name = "label_staffFrienliness";
            this.label_staffFrienliness.Size = new System.Drawing.Size(329, 42);
            this.label_staffFrienliness.TabIndex = 6;
            this.label_staffFrienliness.Text = "Staff Friendliness";
            // 
            // label_roomCleanliness
            // 
            this.label_roomCleanliness.AutoSize = true;
            this.label_roomCleanliness.Location = new System.Drawing.Point(941, 453);
            this.label_roomCleanliness.Name = "label_roomCleanliness";
            this.label_roomCleanliness.Size = new System.Drawing.Size(341, 42);
            this.label_roomCleanliness.TabIndex = 7;
            this.label_roomCleanliness.Text = "Room Cleanliness";
            // 
            // label_hotelName
            // 
            this.label_hotelName.AutoSize = true;
            this.label_hotelName.Location = new System.Drawing.Point(959, 240);
            this.label_hotelName.Name = "label_hotelName";
            this.label_hotelName.Size = new System.Drawing.Size(158, 42);
            this.label_hotelName.TabIndex = 8;
            this.label_hotelName.Text = "Hotel ID";
            // 
            // guna2RatingStar_staff
            // 
            this.guna2RatingStar_staff.BorderColor = System.Drawing.Color.Red;
            this.guna2RatingStar_staff.BorderThickness = 3;
            this.guna2RatingStar_staff.Location = new System.Drawing.Point(103, 299);
            this.guna2RatingStar_staff.Name = "guna2RatingStar_staff";
            this.guna2RatingStar_staff.RatingColor = System.Drawing.Color.Red;
            this.guna2RatingStar_staff.Size = new System.Drawing.Size(337, 58);
            this.guna2RatingStar_staff.TabIndex = 9;
            this.guna2RatingStar_staff.ValueChanged += new System.EventHandler(this.guna2RatingStar_staff_ValueChanged);
            // 
            // guna2RatingStar_room
            // 
            this.guna2RatingStar_room.BorderColor = System.Drawing.Color.Red;
            this.guna2RatingStar_room.BorderThickness = 3;
            this.guna2RatingStar_room.Location = new System.Drawing.Point(945, 498);
            this.guna2RatingStar_room.Name = "guna2RatingStar_room";
            this.guna2RatingStar_room.RatingColor = System.Drawing.Color.Red;
            this.guna2RatingStar_room.Size = new System.Drawing.Size(337, 58);
            this.guna2RatingStar_room.TabIndex = 11;
            this.guna2RatingStar_room.ValueChanged += new System.EventHandler(this.guna2RatingStar_room_ValueChanged);
            // 
            // label_staff0
            // 
            this.label_staff0.AutoSize = true;
            this.label_staff0.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_staff0.Location = new System.Drawing.Point(217, 360);
            this.label_staff0.Name = "label_staff0";
            this.label_staff0.Size = new System.Drawing.Size(30, 32);
            this.label_staff0.TabIndex = 14;
            this.label_staff0.Text = "0";
            // 
            // label_staffRatings
            // 
            this.label_staffRatings.AutoSize = true;
            this.label_staffRatings.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_staffRatings.Location = new System.Drawing.Point(97, 360);
            this.label_staffRatings.Name = "label_staffRatings";
            this.label_staffRatings.Size = new System.Drawing.Size(134, 32);
            this.label_staffRatings.TabIndex = 13;
            this.label_staffRatings.Text = "Ratings: ";
            // 
            // label_room0
            // 
            this.label_room0.AutoSize = true;
            this.label_room0.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_room0.Location = new System.Drawing.Point(1062, 559);
            this.label_room0.Name = "label_room0";
            this.label_room0.Size = new System.Drawing.Size(30, 32);
            this.label_room0.TabIndex = 16;
            this.label_room0.Text = "0";
            // 
            // label_roomRatings
            // 
            this.label_roomRatings.AutoSize = true;
            this.label_roomRatings.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_roomRatings.Location = new System.Drawing.Point(942, 559);
            this.label_roomRatings.Name = "label_roomRatings";
            this.label_roomRatings.Size = new System.Drawing.Size(134, 32);
            this.label_roomRatings.TabIndex = 15;
            this.label_roomRatings.Text = "Ratings: ";
            // 
            // button_save
            // 
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Arial", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Image = ((System.Drawing.Image)(resources.GetObject("button_save.Image")));
            this.button_save.Location = new System.Drawing.Point(2, 705);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(745, 143);
            this.button_save.TabIndex = 17;
            this.button_save.Text = "Save";
            this.button_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_clean
            // 
            this.button_clean.FlatAppearance.BorderSize = 0;
            this.button_clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clean.Font = new System.Drawing.Font("Arial", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clean.Image = ((System.Drawing.Image)(resources.GetObject("button_clean.Image")));
            this.button_clean.Location = new System.Drawing.Point(753, 705);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(724, 143);
            this.button_clean.TabIndex = 18;
            this.button_clean.Text = "Clean";
            this.button_clean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // comboBox_hotel
            // 
            this.comboBox_hotel.FormattingEnabled = true;
            this.comboBox_hotel.Location = new System.Drawing.Point(945, 299);
            this.comboBox_hotel.Name = "comboBox_hotel";
            this.comboBox_hotel.Size = new System.Drawing.Size(200, 50);
            this.comboBox_hotel.TabIndex = 19;
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1475, 847);
            this.Controls.Add(this.comboBox_hotel);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_room0);
            this.Controls.Add(this.label_roomRatings);
            this.Controls.Add(this.label_staff0);
            this.Controls.Add(this.label_staffRatings);
            this.Controls.Add(this.guna2RatingStar_room);
            this.Controls.Add(this.guna2RatingStar_staff);
            this.Controls.Add(this.label_hotelName);
            this.Controls.Add(this.label_roomCleanliness);
            this.Controls.Add(this.label_staffFrienliness);
            this.Controls.Add(this.outputRatings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2RatingStar);
            this.Controls.Add(this.label_rating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FeedbackForm";
            this.Text = "FeedbackForm";
            this.Load += new System.EventHandler(this.FeedbackForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_rating;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outputRatings;
        private System.Windows.Forms.Label label_staffFrienliness;
        private System.Windows.Forms.Label label_roomCleanliness;
        private System.Windows.Forms.Label label_hotelName;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar_staff;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar_room;
        private System.Windows.Forms.Label label_staff0;
        private System.Windows.Forms.Label label_staffRatings;
        private System.Windows.Forms.Label label_room0;
        private System.Windows.Forms.Label label_roomRatings;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.ComboBox comboBox_hotel;
    }
}