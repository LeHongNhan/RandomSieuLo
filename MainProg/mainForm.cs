using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProg
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private Form currentFormChild;

        private void openChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnRandomTen_Click(object sender, EventArgs e)
        {
            openChildForm(new RandomName());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new RandomTeam());
        }
    }
}
