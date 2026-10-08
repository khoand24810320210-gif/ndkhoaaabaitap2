using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ndkhoaaabt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtpDate.Value = DateTime.Now;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Dispose existing image if any
                        if (pbScreenshot.Image != null)
                        {
                            var old = pbScreenshot.Image;
                            pbScreenshot.Image = null;
                            old.Dispose();
                        }

                        using (var fs = File.OpenRead(dlg.FileName))
                        {
                            var img = Image.FromStream(fs);
                            pbScreenshot.Image = new Bitmap(img);
                            img.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string ticketId = txtTicketId.Text.Trim();
            string requester = txtRequester.Text.Trim();
            string date = dtpDate.Value.ToShortDateString();

            string priority = rbLow.Checked ? "Thấp" : rbMedium.Checked ? "Trung bình" : "Khẩn cấp";

            string issueType = cmbIssueType.SelectedItem != null ? cmbIssueType.SelectedItem.ToString() : "(Chưa chọn)";

            var devices = new System.Collections.Generic.List<string>();
            if (cbDesktop.Checked) devices.Add("Máy tính bàn");
            if (cbLaptop.Checked) devices.Add("Laptop");
            if (cbPrinter.Checked) devices.Add("Máy in");
            if (cbPhone.Checked) devices.Add("Điện thoại");

            string devicesText = devices.Count > 0 ? string.Join(", ", devices) : "(Không có)";

            string summary = $"Mã phiếu: {ticketId}\nNgười yêu cầu: {requester}\nNgày: {date}\nMức độ ưu tiên: {priority}\nLoại sự cố: {issueType}\nThiết bị ảnh hưởng: {devicesText}";

            MessageBox.Show(summary, "Tóm tắt phiếu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTicketId.Text = string.Empty;
            txtRequester.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
            rbLow.Checked = true;
            cmbIssueType.SelectedIndex = -1;
            cbDesktop.Checked = cbLaptop.Checked = cbPrinter.Checked = cbPhone.Checked = false;

            if (pbScreenshot.Image != null)
            {
                var img = pbScreenshot.Image;
                pbScreenshot.Image = null;
                img.Dispose();
            }
        }
    }
}
