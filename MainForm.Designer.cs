namespace Hotel_Management_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_room = new System.Windows.Forms.Button();
            this.button_reception = new System.Windows.Forms.Button();
            this.button_guest = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_slide = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_logout);
            this.panel2.Controls.Add(this.button_room);
            this.panel2.Controls.Add(this.button_reception);
            this.panel2.Controls.Add(this.button_guest);
            this.panel2.Controls.Add(this.button_home);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 847);
            this.panel2.TabIndex = 0;
            // 
            // button_logout
            // 
            this.button_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.ForeColor = System.Drawing.Color.Red;
            this.button_logout.Image = ((System.Drawing.Image)(resources.GetObject("button_logout.Image")));
            this.button_logout.Location = new System.Drawing.Point(0, 678);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(182, 127);
            this.button_logout.TabIndex = 5;
            this.button_logout.Text = "Logout";
            this.button_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_room
            // 
            this.button_room.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_room.FlatAppearance.BorderSize = 0;
            this.button_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_room.ForeColor = System.Drawing.Color.Red;
            this.button_room.Image = ((System.Drawing.Image)(resources.GetObject("button_room.Image")));
            this.button_room.Location = new System.Drawing.Point(0, 551);
            this.button_room.Name = "button_room";
            this.button_room.Size = new System.Drawing.Size(182, 127);
            this.button_room.TabIndex = 4;
            this.button_room.Text = "Room";
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
            this.button_reception.Location = new System.Drawing.Point(0, 424);
            this.button_reception.Name = "button_reception";
            this.button_reception.Size = new System.Drawing.Size(182, 127);
            this.button_reception.TabIndex = 3;
            this.button_reception.Text = "Reception";
            this.button_reception.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_reception.UseVisualStyleBackColor = true;
            this.button_reception.Click += new System.EventHandler(this.button_reception_Click);
            // 
            // button_guest
            // 
            this.button_guest.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_guest.FlatAppearance.BorderSize = 0;
            this.button_guest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_guest.ForeColor = System.Drawing.Color.Red;
            this.button_guest.Image = ((System.Drawing.Image)(resources.GetObject("button_guest.Image")));
            this.button_guest.Location = new System.Drawing.Point(0, 297);
            this.button_guest.Name = "button_guest";
            this.button_guest.Size = new System.Drawing.Size(182, 127);
            this.button_guest.TabIndex = 2;
            this.button_guest.Text = "Guest";
            this.button_guest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_guest.UseVisualStyleBackColor = true;
            this.button_guest.Click += new System.EventHandler(this.button_guest_Click);
            // 
            // button_home
            // 
            this.button_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.ForeColor = System.Drawing.Color.Red;
            this.button_home.Image = ((System.Drawing.Image)(resources.GetObject("button_home.Image")));
            this.button_home.Location = new System.Drawing.Point(0, 170);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(182, 127);
            this.button_home.TabIndex = 1;
            this.button_home.Text = "Home";
            this.button_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_home.UseVisualStyleBackColor = true;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 170);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_slide);
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(182, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1293, 847);
            this.panel_main.TabIndex = 1;
            // 
            // panel_slide
            // 
            this.panel_slide.BackColor = System.Drawing.Color.Red;
            this.panel_slide.Location = new System.Drawing.Point(0, 170);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(10, 125);
            this.panel_slide.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1243, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(344, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Management System";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1475, 847);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_room;
        private System.Windows.Forms.Button button_reception;
        private System.Windows.Forms.Button button_guest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel_slide;
        private System.Windows.Forms.Button button_logout;
    }
}