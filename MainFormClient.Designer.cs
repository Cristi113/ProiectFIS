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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_cover = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_room = new System.Windows.Forms.Button();
            this.button_reception = new System.Windows.Forms.Button();
            this.button_hotelSearch = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel_cover.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(2458, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1087, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Royal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1410, -78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 49);
            this.label4.TabIndex = 1;
            this.label4.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1410, -44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 49);
            this.label3.TabIndex = 1;
            this.label3.Text = "X";
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
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 1564);
            this.panel2.TabIndex = 6;
            // 
            // panel_cover
            // 
            this.panel_cover.Controls.Add(this.label2);
            this.panel_cover.Controls.Add(this.label1);
            this.panel_cover.Controls.Add(this.pictureBox3);
            this.panel_cover.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_cover.Location = new System.Drawing.Point(73, 0);
            this.panel_cover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_cover.Name = "panel_cover";
            this.panel_cover.Size = new System.Drawing.Size(2515, 1564);
            this.panel_cover.TabIndex = 1;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_cover);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(2588, 1564);
            this.panel_main.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 1028);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 257);
            this.button1.TabIndex = 6;
            this.button1.Text = "Feedback";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_logout
            // 
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.ForeColor = System.Drawing.Color.Red;
            this.button_logout.Image = ((System.Drawing.Image)(resources.GetObject("button_logout.Image")));
            this.button_logout.Location = new System.Drawing.Point(4, 1272);
            this.button_logout.Margin = new System.Windows.Forms.Padding(4);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(182, 345);
            this.button_logout.TabIndex = 5;
            this.button_logout.Text = "Logout";
            this.button_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click_1);
            // 
            // button_room
            // 
            this.button_room.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_room.FlatAppearance.BorderSize = 0;
            this.button_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_room.ForeColor = System.Drawing.Color.Red;
            this.button_room.Image = ((System.Drawing.Image)(resources.GetObject("button_room.Image")));
            this.button_room.Location = new System.Drawing.Point(0, 771);
            this.button_room.Margin = new System.Windows.Forms.Padding(4);
            this.button_room.Name = "button_room";
            this.button_room.Size = new System.Drawing.Size(182, 257);
            this.button_room.TabIndex = 4;
            this.button_room.Text = "Book Rooms";
            this.button_room.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_room.UseVisualStyleBackColor = true;
            this.button_room.Click += new System.EventHandler(this.button_room_Click);
            // 
            // button_reception
            // 
            this.button_reception.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_reception.FlatAppearance.BorderSize = 0;
            this.button_reception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reception.ForeColor = System.Drawing.Color.Red;
            this.button_reception.Image = ((System.Drawing.Image)(resources.GetObject("button_reception.Image")));
            this.button_reception.Location = new System.Drawing.Point(0, 514);
            this.button_reception.Margin = new System.Windows.Forms.Padding(4);
            this.button_reception.Name = "button_reception";
            this.button_reception.Size = new System.Drawing.Size(182, 257);
            this.button_reception.TabIndex = 3;
            this.button_reception.Text = "Request Services";
            this.button_reception.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_reception.UseVisualStyleBackColor = true;
            this.button_reception.Click += new System.EventHandler(this.button_reception_Click);
            // 
            // button_hotelSearch
            // 
            this.button_hotelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_hotelSearch.FlatAppearance.BorderSize = 0;
            this.button_hotelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hotelSearch.ForeColor = System.Drawing.Color.Red;
            this.button_hotelSearch.Image = ((System.Drawing.Image)(resources.GetObject("button_hotelSearch.Image")));
            this.button_hotelSearch.Location = new System.Drawing.Point(0, 257);
            this.button_hotelSearch.Margin = new System.Windows.Forms.Padding(4);
            this.button_hotelSearch.Name = "button_hotelSearch";
            this.button_hotelSearch.Size = new System.Drawing.Size(182, 257);
            this.button_hotelSearch.TabIndex = 2;
            this.button_hotelSearch.Text = "Hotel Search";
            this.button_hotelSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_hotelSearch.UseVisualStyleBackColor = true;
            this.button_hotelSearch.Click += new System.EventHandler(this.button_hotelSearch_Click_1);
            // 
            // button_home
            // 
            this.button_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.ForeColor = System.Drawing.Color.Red;
            this.button_home.Image = ((System.Drawing.Image)(resources.GetObject("button_home.Image")));
            this.button_home.Location = new System.Drawing.Point(0, 0);
            this.button_home.Margin = new System.Windows.Forms.Padding(4);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(182, 257);
            this.button_home.TabIndex = 1;
            this.button_home.Text = "Home";
            this.button_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_home.UseVisualStyleBackColor = true;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 201);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(2508, 1359);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // MainFormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(2588, 1564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainFormClient";
            this.Text = "MainFormClient";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_cover.ResumeLayout(false);
            this.panel_cover.PerformLayout();
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_room;
        private System.Windows.Forms.Button button_reception;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_hotelSearch;
        private System.Windows.Forms.Panel panel_cover;
        private System.Windows.Forms.Panel panel_main;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}