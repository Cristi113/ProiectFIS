namespace Hotel_Management_System
{
    partial class MainFormClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormClient));
<<<<<<< Updated upstream
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel_main = new System.Windows.Forms.Panel();
=======
            this.button_hotelSearch = new System.Windows.Forms.Button();
>>>>>>> Stashed changes
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_slide = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_cover = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
<<<<<<< Updated upstream
            this.button1 = new System.Windows.Forms.Button();
            this.button_room = new System.Windows.Forms.Button();
            this.button_reception = new System.Windows.Forms.Button();
            this.button_hotelSearch = new System.Windows.Forms.Button();
=======
            this.button_feedback = new System.Windows.Forms.Button();
            this.button_rooms = new System.Windows.Forms.Button();
            this.button_services = new System.Windows.Forms.Button();
>>>>>>> Stashed changes
            this.button_home = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
<<<<<<< Updated upstream
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_cover);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(99, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(692, 424);
            this.panel_main.TabIndex = 5;
=======
            // button_hotelSearch
            // 
            this.button_hotelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_hotelSearch.FlatAppearance.BorderSize = 0;
            this.button_hotelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hotelSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hotelSearch.ForeColor = System.Drawing.Color.Red;
            this.button_hotelSearch.Image = ((System.Drawing.Image)(resources.GetObject("button_hotelSearch.Image")));
            this.button_hotelSearch.Location = new System.Drawing.Point(0, 136);
            this.button_hotelSearch.Margin = new System.Windows.Forms.Padding(2);
            this.button_hotelSearch.Name = "button_hotelSearch";
            this.button_hotelSearch.Size = new System.Drawing.Size(109, 144);
            this.button_hotelSearch.TabIndex = 1;
            this.button_hotelSearch.Text = "Hotel Search";
            this.button_hotelSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_hotelSearch.UseVisualStyleBackColor = true;
            this.button_hotelSearch.Click += new System.EventHandler(this.button_hotelSearch_Click_1);
>>>>>>> Stashed changes
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button_logout);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button_room);
            this.panel2.Controls.Add(this.button_reception);
            this.panel2.Controls.Add(this.button_hotelSearch);
            this.panel2.Controls.Add(this.button_home);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
<<<<<<< Updated upstream
            this.panel2.Size = new System.Drawing.Size(99, 424);
            this.panel2.TabIndex = 4;
            // 
            // panel_slide
            // 
            this.panel_slide.BackColor = System.Drawing.Color.Red;
            this.panel_slide.Location = new System.Drawing.Point(0, 92);
            this.panel_slide.Margin = new System.Windows.Forms.Padding(2);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(5, 68);
            this.panel_slide.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 68);
            this.panel1.TabIndex = 2;
            // 
            // panel_cover
            // 
            this.panel_cover.Controls.Add(this.panel1);
            this.panel_cover.Controls.Add(this.panel_slide);
            this.panel_cover.Controls.Add(this.label2);
            this.panel_cover.Controls.Add(this.label1);
            this.panel_cover.Controls.Add(this.pictureBox3);
            this.panel_cover.Controls.Add(this.pictureBox2);
            this.panel_cover.Controls.Add(this.pictureBox4);
            this.panel_cover.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_cover.Location = new System.Drawing.Point(-13, 0);
            this.panel_cover.Margin = new System.Windows.Forms.Padding(2);
            this.panel_cover.Name = "panel_cover";
            this.panel_cover.Size = new System.Drawing.Size(705, 424);
            this.panel_cover.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(683, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(525, -2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 102);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(205, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Royal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(68, -2);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(110, 102);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(769, -24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label2_Click);
=======
            this.panel2.Size = new System.Drawing.Size(109, 847);
            this.panel2.TabIndex = 2;
>>>>>>> Stashed changes
            // 
            // button_logout
            // 
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.ForeColor = System.Drawing.Color.Red;
            this.button_logout.Image = ((System.Drawing.Image)(resources.GetObject("button_logout.Image")));
<<<<<<< Updated upstream
            this.button_logout.Location = new System.Drawing.Point(0, 347);
            this.button_logout.Margin = new System.Windows.Forms.Padding(2);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(99, 77);
=======
            this.button_logout.Location = new System.Drawing.Point(0, 711);
            this.button_logout.Margin = new System.Windows.Forms.Padding(2);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(109, 136);
>>>>>>> Stashed changes
            this.button_logout.TabIndex = 5;
            this.button_logout.Text = "Logout";
            this.button_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click_1);
            // 
<<<<<<< Updated upstream
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 276);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 69);
            this.button1.TabIndex = 6;
            this.button1.Text = "Feedback";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
=======
            // button_feedback
            // 
            this.button_feedback.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_feedback.FlatAppearance.BorderSize = 0;
            this.button_feedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_feedback.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_feedback.ForeColor = System.Drawing.Color.Red;
            this.button_feedback.Image = ((System.Drawing.Image)(resources.GetObject("button_feedback.Image")));
            this.button_feedback.Location = new System.Drawing.Point(0, 565);
            this.button_feedback.Margin = new System.Windows.Forms.Padding(2);
            this.button_feedback.Name = "button_feedback";
            this.button_feedback.Size = new System.Drawing.Size(109, 146);
            this.button_feedback.TabIndex = 4;
            this.button_feedback.Text = "Feedback";
            this.button_feedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_feedback.UseVisualStyleBackColor = true;
>>>>>>> Stashed changes
            // 
            // button_room
            // 
<<<<<<< Updated upstream
            this.button_room.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_room.FlatAppearance.BorderSize = 0;
            this.button_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_room.ForeColor = System.Drawing.Color.Red;
            this.button_room.Image = ((System.Drawing.Image)(resources.GetObject("button_room.Image")));
            this.button_room.Location = new System.Drawing.Point(0, 207);
            this.button_room.Margin = new System.Windows.Forms.Padding(2);
            this.button_room.Name = "button_room";
            this.button_room.Size = new System.Drawing.Size(99, 69);
            this.button_room.TabIndex = 4;
            this.button_room.Text = "Book Rooms";
            this.button_room.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_room.UseVisualStyleBackColor = true;
=======
            this.button_rooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_rooms.FlatAppearance.BorderSize = 0;
            this.button_rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rooms.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rooms.ForeColor = System.Drawing.Color.Red;
            this.button_rooms.Image = ((System.Drawing.Image)(resources.GetObject("button_rooms.Image")));
            this.button_rooms.Location = new System.Drawing.Point(0, 420);
            this.button_rooms.Margin = new System.Windows.Forms.Padding(2);
            this.button_rooms.Name = "button_rooms";
            this.button_rooms.Size = new System.Drawing.Size(109, 145);
            this.button_rooms.TabIndex = 3;
            this.button_rooms.Text = "Book rooms";
            this.button_rooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_rooms.UseVisualStyleBackColor = true;
>>>>>>> Stashed changes
            // 
            // button_reception
            // 
<<<<<<< Updated upstream
            this.button_reception.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_reception.FlatAppearance.BorderSize = 0;
            this.button_reception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reception.ForeColor = System.Drawing.Color.Red;
            this.button_reception.Image = ((System.Drawing.Image)(resources.GetObject("button_reception.Image")));
            this.button_reception.Location = new System.Drawing.Point(0, 138);
            this.button_reception.Margin = new System.Windows.Forms.Padding(2);
            this.button_reception.Name = "button_reception";
            this.button_reception.Size = new System.Drawing.Size(99, 69);
            this.button_reception.TabIndex = 3;
            this.button_reception.Text = "Request Services";
            this.button_reception.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_reception.UseVisualStyleBackColor = true;
            // 
            // button_hotelSearch
            // 
            this.button_hotelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_hotelSearch.FlatAppearance.BorderSize = 0;
            this.button_hotelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hotelSearch.ForeColor = System.Drawing.Color.Red;
            this.button_hotelSearch.Image = ((System.Drawing.Image)(resources.GetObject("button_hotelSearch.Image")));
            this.button_hotelSearch.Location = new System.Drawing.Point(0, 69);
            this.button_hotelSearch.Margin = new System.Windows.Forms.Padding(2);
            this.button_hotelSearch.Name = "button_hotelSearch";
            this.button_hotelSearch.Size = new System.Drawing.Size(99, 69);
            this.button_hotelSearch.TabIndex = 2;
            this.button_hotelSearch.Text = "Hotel Search";
            this.button_hotelSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_hotelSearch.UseVisualStyleBackColor = true;
            this.button_hotelSearch.Click += new System.EventHandler(this.button_hotelSearch_Click);
            // 
=======
            this.button_services.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_services.FlatAppearance.BorderSize = 0;
            this.button_services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_services.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_services.ForeColor = System.Drawing.Color.Red;
            this.button_services.Image = ((System.Drawing.Image)(resources.GetObject("button_services.Image")));
            this.button_services.Location = new System.Drawing.Point(0, 280);
            this.button_services.Margin = new System.Windows.Forms.Padding(2);
            this.button_services.Name = "button_services";
            this.button_services.Size = new System.Drawing.Size(109, 140);
            this.button_services.TabIndex = 2;
            this.button_services.Text = "Services";
            this.button_services.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_services.UseVisualStyleBackColor = true;
            // 
>>>>>>> Stashed changes
            // button_home
            // 
            this.button_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.ForeColor = System.Drawing.Color.Red;
            this.button_home.Image = ((System.Drawing.Image)(resources.GetObject("button_home.Image")));
            this.button_home.Location = new System.Drawing.Point(0, 0);
            this.button_home.Margin = new System.Windows.Forms.Padding(2);
            this.button_home.Name = "button_home";
<<<<<<< Updated upstream
            this.button_home.Size = new System.Drawing.Size(99, 69);
            this.button_home.TabIndex = 1;
=======
            this.button_home.Size = new System.Drawing.Size(109, 136);
            this.button_home.TabIndex = 0;
>>>>>>> Stashed changes
            this.button_home.Text = "Home";
            this.button_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_home.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 95);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(704, 363);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
<<<<<<< Updated upstream
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(769, -42);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label2_Click);
=======
            this.panel_main.Controls.Add(this.pictureBox1);
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1475, 847);
            this.panel_main.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 92);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1362, 753);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1446, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(708, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Royal Hotel";
>>>>>>> Stashed changes
            // 
            // MainFormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
<<<<<<< Updated upstream
            this.ClientSize = new System.Drawing.Size(791, 424);
            this.Controls.Add(this.panel_main);
=======
            this.ClientSize = new System.Drawing.Size(1475, 847);
>>>>>>> Stashed changes
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainFormClient";
            this.Text = "MainFormClient";
            this.panel_main.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_cover.ResumeLayout(false);
            this.panel_cover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< Updated upstream
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
=======
        private System.Windows.Forms.Button button_hotelSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_feedback;
        private System.Windows.Forms.Button button_rooms;
        private System.Windows.Forms.Button button_services;
        private System.Windows.Forms.Button button_home;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
>>>>>>> Stashed changes
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_cover;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_slide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_room;
        private System.Windows.Forms.Button button_reception;
        private System.Windows.Forms.Button button_hotelSearch;
        private System.Windows.Forms.Button button_home;
    }
}