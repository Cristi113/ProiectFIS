using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Hotel_Management_System
{
    public partial class RequestServicesForm : Form
    {
        RequestServicesClass requests = new RequestServicesClass();

        public RequestServicesForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton_yes_roomService_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton_no_roomService_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton_yes_cleanService_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton_no_cleanService_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton_yes_extraTowels_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton_no_extraTowels_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton_yes_extraBed_CheckedChanged(object sender, EventArgs e)
        {
          

        }

        private void radioButton_no_extraBed_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            radioButton_no_cleanService.Checked = true;
            radioButton_no_extraBed.Checked = true;
            radioButton_no_extraTowels.Checked = true;
            radioButton_no_roomService.Checked = true;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                string roomService = radioButton_yes_roomService.Checked ? "Yes" : "No";
                string cleanService = radioButton_yes_cleanService.Checked ? "Yes" : "No";
                string extraTowels = radioButton_yes_extraTowels.Checked ? "Yes" : "No";
                string extraBed = radioButton_yes_extraBed.Checked ? "Yes" : "No";

                    if (requests.SaveGuestRequests(roomService,cleanService,extraTowels,extraBed))
                    {
                        MessageBox.Show("Extra Services Requested Successfully", "Request Extra Services", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Extra Services Requested Successfully", "Error Extra Services", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Extra Services Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
