using Velasco_Arjay_Act_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Velasco_Arjay_Act_GUI
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            // Mock Student Data
            StudentNameLabel.Text = "Arjay Velasco";
            StudentAgeLabel.Text = "21";
            StudentAddressLabel.Text = "321 Street";
            StudentContactLabel.Text = "091512345321";
            StudentEmailLabel.Text = "gmail@sample.com";
            StudentCourseYearLabel.Text = "BSIT Third";
            ParentNameLabel.Text = "Ariane Velasco";
            ParentContactLabel.Text = "09231431234";
            HobbiesLabel.Text = "Coding, Gaming, Exercising";
            NicknameLabel.Text = "Jay";
        }

        private void AddImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditUpdateBtn_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this);
            this.Hide();
            editForm.Show();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}