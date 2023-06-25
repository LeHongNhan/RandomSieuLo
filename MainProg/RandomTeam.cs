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
    public partial class RandomTeam : Form
    {
        public RandomTeam()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCheDo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSoLuongNhom_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lstDanhSachTen.Items.Count; i++)
            {
                if (txtTen.Text == ""+lstDanhSachTen.Items[i])
                {
                    DialogResult ret = MessageBox.Show("Tên này đã có trong danh sách, có muốn thêm tiếp không?", "hỏi muốn thêm", MessageBoxButtons.YesNo);
                    if (ret == DialogResult.Yes)
                    {
                        lstDanhSachTen.Items.Add(txtTen.Text);
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            lstDanhSachTen.Items.Add(txtTen.Text);

        }

        private void radSoLuongNhom_CheckedChanged(object sender, EventArgs e)
        {
            if(radSoLuongNhom.Checked == true)
            {
                txtSoLuong.ReadOnly = false;
            }
            else
            {
                txtSoLuong.ReadOnly = true;
            }
        }

        private void radTVMoiNhom_CheckedChanged(object sender, EventArgs e)
        {
            if (radTVMoiNhom.Checked == true)
            {
                txtSoLuongThanhVien.ReadOnly = false;
            }
            else
            {
                txtSoLuongThanhVien.ReadOnly = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radSoLuongNhom.Checked = true;
        }

        private void btnTaoNgauNhien_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            ListBox lbTemp = new ListBox();
            int soLuong = 0;
            foreach (var item in lstDanhSachTen.Items)
            {
                lbTemp.Items.Add(item);
            }
            if(radSoLuongNhom.Checked == true)
            {
                if(chkTruongNhom.Checked == true)
                {
                    int count = int.Parse(txtSoLuong.Text);
                    for (int i = 0; i < count; i++)
                    {
                        int rand = r.Next(0, lbTemp.Items.Count); //Cho random giá trị từ 0 tới số lượng tên
                        while (lbTemp.Items[rand] + "" == "-1")  //Xét nếu tên = -1 thì không lấy vì nó đã được lấy rồi
                        {
                            rand = r.Next(0, lbTemp.Items.Count);
                        }
                        int nhom = i + 1;
                        lstKetQua.Items.Add("Nhóm thứ " + nhom);
                        lstKetQua.Items.Add("Nhóm trưởng " + lbTemp.Items[rand]);
                        lbTemp.Items[rand] = "-1";      //Sau khi lấy tên thì chỗ tên = -1
                        lstKetQua.Items.Add("Các thành viên ");
                        for (int j = 0; j < lstDanhSachTen.Items.Count/count - 1; j++)
                        {
                            rand = r.Next(0, lbTemp.Items.Count);
                            while (lbTemp.Items[rand] + "" == "-1")  //Xét nếu tên = -1 thì không lấy vì nó đã được lấy rồi
                            {
                                rand = r.Next(0, lbTemp.Items.Count);
                            }
                            lstKetQua.Items.Add(lbTemp.Items[rand]);
                            lbTemp.Items[rand] = "-1";
                        }   
                    }
                }
                else
                {
                    int count = int.Parse(txtSoLuong.Text);
                    for (int i = 0; i < count; i++)
                    {
                        int rand; //Cho random giá trị từ 0 tới số lượng tên
                        int nhom = i + 1;
                        lstKetQua.Items.Add("Nhóm thứ " + nhom);
                        lstKetQua.Items.Add("Các thành viên ");
                        for (int j = 0; j < lstDanhSachTen.Items.Count / count; j++)
                        {
                            rand = r.Next(0, lbTemp.Items.Count);
                            while (lbTemp.Items[rand] + "" == "-1")  //Xét nếu tên = -1 thì không lấy vì nó đã được lấy rồi
                            {
                                rand = r.Next(0, lbTemp.Items.Count);
                            }
                            lstKetQua.Items.Add(lbTemp.Items[rand]);
                            lbTemp.Items[rand] = "-1";
                        }
                    }
                }
            }
            else if(radTVMoiNhom.Checked == true)
            {
                if(chkTruongNhom.Checked == true)
                {
                    int count = int.Parse(txtSoLuongThanhVien.Text); //Khai báo
                    int range = lbTemp.Items.Count;
                    int rand = r.Next(0, lbTemp.Items.Count);
                    int number = 1;
                    while(lbTemp.Items.Count >= count)
                    {                       
                        rand = r.Next(0, lbTemp.Items.Count);
                        lstKetQua.Items.Add("Nhóm thứ " + number);
                        lstKetQua.Items.Add("Nhóm trưởng: " + lbTemp.Items[rand]);
                        lbTemp.Items.RemoveAt(rand);
                        lstKetQua.Items.Add("Các thành viên: ");
                        for (int i = 0; i < count - 1; i++)
                        {
                            rand = r.Next(0, lbTemp.Items.Count);
                            lstKetQua.Items.Add(lbTemp.Items[rand]);
                            lbTemp.Items.RemoveAt(rand);
                        }
                        number++;
                    }
                    if (lbTemp.Items.Count > 0)
                    {
                        lstKetQua.Items.Add("Nhóm thứ " + number);
                        lstKetQua.Items.Add("Nhóm trưởng: " + lbTemp.Items[rand]);
                        lbTemp.Items.RemoveAt(rand);
                        if (lbTemp.Items.Count == 0)
                        {
                            return;
                        }
                        lstKetQua.Items.Add("Các thành viên: ");
                        while (lbTemp.Items.Count != 0)
                        {
                            rand = r.Next(0, lbTemp.Items.Count);
                            lstKetQua.Items.Add(lbTemp.Items[rand]);
                            lbTemp.Items.RemoveAt(rand);
                        }
                    }
                }
                else
                {
                    int count = int.Parse(txtSoLuongThanhVien.Text); //Khai báo
                    int range = lbTemp.Items.Count;
                    int rand = r.Next(0, lbTemp.Items.Count);
                    int number = 1;
                    while (lbTemp.Items.Count >= count)
                    {
                        rand = r.Next(0, lbTemp.Items.Count);
                        lstKetQua.Items.Add("Nhóm thứ " + number);
                        for (int i = 0; i < count; i++)
                        {
                            rand = r.Next(0, lbTemp.Items.Count);
                            lstKetQua.Items.Add(lbTemp.Items[rand]);
                            lbTemp.Items.RemoveAt(rand);
                        }
                        number++;
                    }
                    if (lbTemp.Items.Count > 0)
                    {
                        lstKetQua.Items.Add("Nhóm thứ " + number);
                        if (lbTemp.Items.Count == 0)
                        {
                            return;
                        }
                        while (lbTemp.Items.Count != 0)
                        {
                            rand = r.Next(0, lbTemp.Items.Count);
                            lstKetQua.Items.Add(lbTemp.Items[rand]);
                            lbTemp.Items.RemoveAt(rand);
                        }
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lstDanhSachTen.Items.RemoveAt(lstDanhSachTen.SelectedIndex);
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSoLuong, "");
            int so = 0;
            if(radSoLuongNhom.Checked == true && txtSoLuong.Text == "")
            {
                errorProvider1.SetError(txtSoLuong, "Chưa nhập số lượng nhóm kìa!");
            }
            else if(int.TryParse(txtSoLuong.Text, out so) == false || so <= 0)
            {
                errorProvider1.SetError(txtSoLuong, "Hãy nhập số lớp hơn 0!");
            }
        }

        private void txtSoLuongThanhVien_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSoLuong, "");
            int so = 0;
            if(radSoLuongNhom.Checked == true && txtSoLuong.Text == "")
            {
                errorProvider1.SetError(txtSoLuong, "Chưa nhập số lượng nhóm kìa!");
            }
            else if(int.TryParse(txtSoLuong.Text, out so) == false || so <= 0)
            {
                errorProvider1.SetError(txtSoLuong, "Hãy nhập số lớp hơn 0!");
            }
        }
    }
}
