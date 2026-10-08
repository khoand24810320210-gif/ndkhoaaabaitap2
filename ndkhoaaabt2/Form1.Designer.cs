namespace ndkhoaaabt2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtTicketId = new System.Windows.Forms.TextBox();
            this.txtRequester = new System.Windows.Forms.TextBox();
            this.lblTicketId = new System.Windows.Forms.Label();
            this.lblRequester = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.groupPriority = new System.Windows.Forms.GroupBox();
            this.rbHigh = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLow = new System.Windows.Forms.RadioButton();
            this.lblIssueType = new System.Windows.Forms.Label();
            this.cmbIssueType = new System.Windows.Forms.ComboBox();
            this.groupDevices = new System.Windows.Forms.GroupBox();
            this.cbPhone = new System.Windows.Forms.CheckBox();
            this.cbPrinter = new System.Windows.Forms.CheckBox();
            this.cbLaptop = new System.Windows.Forms.CheckBox();
            this.cbDesktop = new System.Windows.Forms.CheckBox();
            this.lblScreenshot = new System.Windows.Forms.Label();
            this.pbScreenshot = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            // 
            // Labels and TextBoxes
            // 
            this.lblTicketId.AutoSize = true;
            this.lblTicketId.Location = new System.Drawing.Point(12, 15);
            this.lblTicketId.Name = "lblTicketId";
            this.lblTicketId.Size = new System.Drawing.Size(70, 15);
            this.lblTicketId.Text = "Mã phiếu:";

            this.txtTicketId.Location = new System.Drawing.Point(110, 12);
            this.txtTicketId.Name = "txtTicketId";
            this.txtTicketId.Size = new System.Drawing.Size(200, 23);

            this.lblRequester.AutoSize = true;
            this.lblRequester.Location = new System.Drawing.Point(12, 50);
            this.lblRequester.Name = "lblRequester";
            this.lblRequester.Size = new System.Drawing.Size(86, 15);
            this.lblRequester.Text = "Người yêu cầu:";

            this.txtRequester.Location = new System.Drawing.Point(110, 47);
            this.txtRequester.Name = "txtRequester";
            this.txtRequester.Size = new System.Drawing.Size(200, 23);

            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 85);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(78, 15);
            this.lblDate.Text = "Ngày ghi nhận:";

            this.dtpDate.Location = new System.Drawing.Point(110, 80);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 23);

            // 
            // Priority group
            // 
            this.groupPriority.Location = new System.Drawing.Point(12, 120);
            this.groupPriority.Name = "groupPriority";
            this.groupPriority.Size = new System.Drawing.Size(298, 60);
            this.groupPriority.Text = "Mức độ ưu tiên";

            this.rbLow.Location = new System.Drawing.Point(10, 22);
            this.rbLow.Name = "rbLow";
            this.rbLow.Size = new System.Drawing.Size(80, 19);
            this.rbLow.Text = "Thấp";
            this.rbLow.Checked = true;

            this.rbMedium.Location = new System.Drawing.Point(100, 22);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(100, 19);
            this.rbMedium.Text = "Trung bình";

            this.rbHigh.Location = new System.Drawing.Point(210, 22);
            this.rbHigh.Name = "rbHigh";
            this.rbHigh.Size = new System.Drawing.Size(80, 19);
            this.rbHigh.Text = "Khẩn cấp";

            this.groupPriority.Controls.Add(this.rbLow);
            this.groupPriority.Controls.Add(this.rbMedium);
            this.groupPriority.Controls.Add(this.rbHigh);

            // 
            // Issue type
            // 
            this.lblIssueType.AutoSize = true;
            this.lblIssueType.Location = new System.Drawing.Point(12, 195);
            this.lblIssueType.Name = "lblIssueType";
            this.lblIssueType.Size = new System.Drawing.Size(90, 15);
            this.lblIssueType.Text = "Loại sự cố:";

            this.cmbIssueType.Location = new System.Drawing.Point(110, 192);
            this.cmbIssueType.Name = "cmbIssueType";
            this.cmbIssueType.Size = new System.Drawing.Size(200, 23);
            this.cmbIssueType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssueType.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });

            // 
            // Devices group
            // 
            this.groupDevices.Location = new System.Drawing.Point(12, 230);
            this.groupDevices.Name = "groupDevices";
            this.groupDevices.Size = new System.Drawing.Size(298, 100);
            this.groupDevices.Text = "Thiết bị ảnh hưởng";

            this.cbDesktop.Location = new System.Drawing.Point(10, 22);
            this.cbDesktop.Name = "cbDesktop";
            this.cbDesktop.Size = new System.Drawing.Size(100, 19);
            this.cbDesktop.Text = "Máy tính bàn";

            this.cbLaptop.Location = new System.Drawing.Point(120, 22);
            this.cbLaptop.Name = "cbLaptop";
            this.cbLaptop.Size = new System.Drawing.Size(80, 19);
            this.cbLaptop.Text = "Laptop";

            this.cbPrinter.Location = new System.Drawing.Point(10, 50);
            this.cbPrinter.Name = "cbPrinter";
            this.cbPrinter.Size = new System.Drawing.Size(80, 19);
            this.cbPrinter.Text = "Máy in";

            this.cbPhone.Location = new System.Drawing.Point(120, 50);
            this.cbPhone.Name = "cbPhone";
            this.cbPhone.Size = new System.Drawing.Size(120, 19);
            this.cbPhone.Text = "Điện thoại";

            this.groupDevices.Controls.Add(this.cbDesktop);
            this.groupDevices.Controls.Add(this.cbLaptop);
            this.groupDevices.Controls.Add(this.cbPrinter);
            this.groupDevices.Controls.Add(this.cbPhone);

            // 
            // Screenshot / PictureBox
            // 
            this.lblScreenshot.AutoSize = true;
            this.lblScreenshot.Location = new System.Drawing.Point(340, 15);
            this.lblScreenshot.Name = "lblScreenshot";
            this.lblScreenshot.Size = new System.Drawing.Size(88, 15);
            this.lblScreenshot.Text = "Ảnh chụp lỗi:";

            this.pbScreenshot.Location = new System.Drawing.Point(340, 40);
            this.pbScreenshot.Name = "pbScreenshot";
            this.pbScreenshot.Size = new System.Drawing.Size(420, 300);
            this.pbScreenshot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.btnLoadImage.Location = new System.Drawing.Point(340, 350);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(120, 30);
            this.btnLoadImage.Text = "Tải ảnh lỗi";
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);

            // 
            // Buttons Send / Reset
            // 
            this.btnSend.Location = new System.Drawing.Point(620, 350);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(140, 30);
            this.btnSend.Text = "Gửi yêu cầu";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            this.btnReset.Location = new System.Drawing.Point(470, 350);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 30);
            this.btnReset.Text = "Nhập lại";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(780, 400);
            this.Controls.Add(this.lblTicketId);
            this.Controls.Add(this.txtTicketId);
            this.Controls.Add(this.lblRequester);
            this.Controls.Add(this.txtRequester);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.groupPriority);
            this.Controls.Add(this.lblIssueType);
            this.Controls.Add(this.cmbIssueType);
            this.Controls.Add(this.groupDevices);
            this.Controls.Add(this.lblScreenshot);
            this.Controls.Add(this.pbScreenshot);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnReset);
            this.Name = "Form1";
            this.Text = "Form Tiếp nhận & Phân loại sự cố IT";
        }

        private System.Windows.Forms.TextBox txtTicketId;
        private System.Windows.Forms.TextBox txtRequester;
        private System.Windows.Forms.Label lblTicketId;
        private System.Windows.Forms.Label lblRequester;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox groupPriority;
        private System.Windows.Forms.RadioButton rbHigh;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLow;
        private System.Windows.Forms.Label lblIssueType;
        private System.Windows.Forms.ComboBox cmbIssueType;
        private System.Windows.Forms.GroupBox groupDevices;
        private System.Windows.Forms.CheckBox cbPhone;
        private System.Windows.Forms.CheckBox cbPrinter;
        private System.Windows.Forms.CheckBox cbLaptop;
        private System.Windows.Forms.CheckBox cbDesktop;
        private System.Windows.Forms.Label lblScreenshot;
        private System.Windows.Forms.PictureBox pbScreenshot;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReset;

        #endregion
    }
}
