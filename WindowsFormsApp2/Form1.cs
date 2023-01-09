using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load the user's profile information and display it on the form
            string username = "";
            string fullName = "";
            string email = "";
            string phone = "";
            string address = "";

            lblUsername.Text = username;
            lblFullName.Text = fullName;
            lblEmail.Text = email;
            lblPhone.Text = phone;
            lblAddress.Text = address;


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Open the EditProfileForm to allow the user to edit their profile information
            EditProfileForm editProfileForm = new EditProfileForm();
            editProfileForm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save the user's profile information
            







        }
    }
}
