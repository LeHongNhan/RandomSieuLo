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
    public partial class RandomName : Form
    {
        public RandomName()
        {
            InitializeComponent();
        }

        private void RandomName_Load(object sender, EventArgs e)
        {

        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void lblNhapTen_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapTen_Enter(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDSTen.Items.Count; i++)
            {
                if (txtNhapTen.Text == "" + lstDSTen.Items[i])
                {
                    DialogResult ret = MessageBox.Show("Tên này đã có trong danh sách, có muốn thêm tiếp không?", "hỏi muốn thêm", MessageBoxButtons.YesNo);
                    if (ret == DialogResult.Yes)
                    {
                        lstDSTen.Items.Add(txtNhapTen.Text);
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            lstDSTen.Items.Add(txtNhapTen.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDSTen.Items.Count; i++)
            {
                if (txtNhapTen.Text == "" + lstDSTen.Items[i])
                {
                    DialogResult ret = MessageBox.Show("Tên này đã có trong danh sách, có muốn thêm tiếp không?", "hỏi muốn thêm", MessageBoxButtons.YesNo);
                    if (ret == DialogResult.Yes)
                    {
                        lstDSTen.Items.Add(txtNhapTen.Text);
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            lstDSTen.Items.Add(txtNhapTen.Text);
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRandomDelete_Click(object sender, EventArgs e)
        {
            if(lstDSTen.Items.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu ");
                return;
            }
            Random R = new Random();
            MessageBox.Show("Kết quả: " + lstDSTen.Items[R.Next(0, lstDSTen.Items.Count)]);
        }

        private void btnCapnhatTen_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNhapTen, "");
            if (txtNhapTen.Text == "")
            {
                errorProvider1.SetError(txtNhapTen, "Chưa nhập!");
            }
            for (int i = 0; i < lstDSTen.Items.Count; i++)
            {
                if (txtNhapTen.Text == "" + lstDSTen.Items[i])
                {
                    DialogResult ret = MessageBox.Show("Tên này đã có trong danh sách, có muốn thêm tiếp không?", "hỏi muốn thêm", MessageBoxButtons.YesNo);
                    if (ret == DialogResult.Yes)
                    {
                        lstDSTen.Items.Add(txtNhapTen.Text);
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            lstDSTen.Items.Add(txtNhapTen.Text);
        }

        private void txtNhapTen_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (lstDSTen.Items.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu ");
                return;
            }
            Random R = new Random();
            int random = R.Next(0, lstDSTen.Items.Count);
            MessageBox.Show("Kết quả: " + lstDSTen.Items[random]);
            lstDSTen.Items.RemoveAt(random);
        }

        private void txtNhapTen_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
