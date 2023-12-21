namespace FamilyTree
{
    partial class Form1
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.lblGen = new System.Windows.Forms.Label();
            this.txtWorkPlace = new System.Windows.Forms.TextBox();
            this.lblWorkPlace = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lalMail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtHomePlace = new System.Windows.Forms.TextBox();
            this.lblHomePlace = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtPassDate = new System.Windows.Forms.TextBox();
            this.lblPassDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtIdFather = new System.Windows.Forms.TextBox();
            this.lblIdFather = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnMoFile = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCount = new System.Windows.Forms.Button();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ExpadClose = new System.Windows.Forms.Button();
            this.txtDongHo = new System.Windows.Forms.TextBox();
            this.btnThemDongHo = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(1184, 761);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 761);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(713, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 761);
            this.panel2.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtSex);
            this.panel8.Controls.Add(this.rtbNote);
            this.panel8.Controls.Add(this.lblNote);
            this.panel8.Controls.Add(this.txtGen);
            this.panel8.Controls.Add(this.lblGen);
            this.panel8.Controls.Add(this.txtWorkPlace);
            this.panel8.Controls.Add(this.lblWorkPlace);
            this.panel8.Controls.Add(this.txtPosition);
            this.panel8.Controls.Add(this.lblPosition);
            this.panel8.Controls.Add(this.txtMail);
            this.panel8.Controls.Add(this.lalMail);
            this.panel8.Controls.Add(this.txtPhone);
            this.panel8.Controls.Add(this.lblPhone);
            this.panel8.Controls.Add(this.txtHomePlace);
            this.panel8.Controls.Add(this.lblHomePlace);
            this.panel8.Controls.Add(this.lblSex);
            this.panel8.Controls.Add(this.txtPassDate);
            this.panel8.Controls.Add(this.lblPassDate);
            this.panel8.Controls.Add(this.txtDate);
            this.panel8.Controls.Add(this.lblDate);
            this.panel8.Controls.Add(this.txtName);
            this.panel8.Controls.Add(this.lblName);
            this.panel8.Controls.Add(this.txtIdFather);
            this.panel8.Controls.Add(this.lblIdFather);
            this.panel8.Controls.Add(this.txtId);
            this.panel8.Controls.Add(this.lblId);
            this.panel8.Location = new System.Drawing.Point(16, 499);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(443, 259);
            this.panel8.TabIndex = 7;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(112, 139);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 20);
            this.txtSex.TabIndex = 5;
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(310, 145);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(118, 96);
            this.rtbNote.TabIndex = 12;
            this.rtbNote.Text = "";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(237, 145);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(44, 13);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "Ghi chú";
            // 
            // txtGen
            // 
            this.txtGen.Location = new System.Drawing.Point(310, 112);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(100, 20);
            this.txtGen.TabIndex = 11;
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Location = new System.Drawing.Point(237, 119);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(41, 13);
            this.lblGen.TabIndex = 0;
            this.lblGen.Text = "Đời thứ";
            // 
            // txtWorkPlace
            // 
            this.txtWorkPlace.Location = new System.Drawing.Point(310, 86);
            this.txtWorkPlace.Name = "txtWorkPlace";
            this.txtWorkPlace.Size = new System.Drawing.Size(100, 20);
            this.txtWorkPlace.TabIndex = 10;
            // 
            // lblWorkPlace
            // 
            this.lblWorkPlace.AutoSize = true;
            this.lblWorkPlace.Location = new System.Drawing.Point(237, 93);
            this.lblWorkPlace.Name = "lblWorkPlace";
            this.lblWorkPlace.Size = new System.Drawing.Size(65, 13);
            this.lblWorkPlace.TabIndex = 0;
            this.lblWorkPlace.Text = "Nơi làm việc";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(310, 60);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(100, 20);
            this.txtPosition.TabIndex = 9;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(237, 67);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(47, 13);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "Chức vụ";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(310, 34);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 8;
            // 
            // lalMail
            // 
            this.lalMail.AutoSize = true;
            this.lalMail.Location = new System.Drawing.Point(237, 41);
            this.lalMail.Name = "lalMail";
            this.lalMail.Size = new System.Drawing.Size(32, 13);
            this.lalMail.TabIndex = 0;
            this.lalMail.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(310, 8);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(237, 15);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 13);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // txtHomePlace
            // 
            this.txtHomePlace.Location = new System.Drawing.Point(112, 164);
            this.txtHomePlace.Name = "txtHomePlace";
            this.txtHomePlace.Size = new System.Drawing.Size(100, 20);
            this.txtHomePlace.TabIndex = 6;
            // 
            // lblHomePlace
            // 
            this.lblHomePlace.AutoSize = true;
            this.lblHomePlace.Location = new System.Drawing.Point(19, 171);
            this.lblHomePlace.Name = "lblHomePlace";
            this.lblHomePlace.Size = new System.Drawing.Size(59, 13);
            this.lblHomePlace.TabIndex = 0;
            this.lblHomePlace.Text = "Thường trú";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(19, 145);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(47, 13);
            this.lblSex.TabIndex = 0;
            this.lblSex.Text = "Giới tính";
            // 
            // txtPassDate
            // 
            this.txtPassDate.Location = new System.Drawing.Point(112, 112);
            this.txtPassDate.Name = "txtPassDate";
            this.txtPassDate.Size = new System.Drawing.Size(100, 20);
            this.txtPassDate.TabIndex = 4;
            // 
            // lblPassDate
            // 
            this.lblPassDate.AutoSize = true;
            this.lblPassDate.Location = new System.Drawing.Point(19, 119);
            this.lblPassDate.Name = "lblPassDate";
            this.lblPassDate.Size = new System.Drawing.Size(52, 13);
            this.lblPassDate.TabIndex = 0;
            this.lblPassDate.Text = "Ngày mất";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(112, 86);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(19, 93);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Ngày sinh";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ và tên";
            // 
            // txtIdFather
            // 
            this.txtIdFather.Location = new System.Drawing.Point(112, 34);
            this.txtIdFather.Name = "txtIdFather";
            this.txtIdFather.Size = new System.Drawing.Size(100, 20);
            this.txtIdFather.TabIndex = 1;
            // 
            // lblIdFather
            // 
            this.lblIdFather.AutoSize = true;
            this.lblIdFather.Location = new System.Drawing.Point(19, 41);
            this.lblIdFather.Name = "lblIdFather";
            this.lblIdFather.Size = new System.Drawing.Size(40, 13);
            this.lblIdFather.TabIndex = 0;
            this.lblIdFather.Text = "ID Cha";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(112, 8);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(19, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnLamMoi);
            this.panel7.Controls.Add(this.btnIn);
            this.panel7.Controls.Add(this.btnXuatFile);
            this.panel7.Controls.Add(this.btnThoat);
            this.panel7.Controls.Add(this.btnMoFile);
            this.panel7.Location = new System.Drawing.Point(16, 449);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(443, 44);
            this.panel7.TabIndex = 6;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(185, 11);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click_2);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(268, 11);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "In gia phả";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Location = new System.Drawing.Point(102, 11);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(75, 23);
            this.btnXuatFile.TabIndex = 1;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(351, 11);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnMoFile
            // 
            this.btnMoFile.Location = new System.Drawing.Point(19, 11);
            this.btnMoFile.Name = "btnMoFile";
            this.btnMoFile.Size = new System.Drawing.Size(75, 23);
            this.btnMoFile.TabIndex = 0;
            this.btnMoFile.Text = "Mở file";
            this.btnMoFile.UseVisualStyleBackColor = true;
            this.btnMoFile.Click += new System.EventHandler(this.btnMoFile_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnThem);
            this.panel6.Controls.Add(this.btnLuu);
            this.panel6.Controls.Add(this.btnXoa);
            this.panel6.Controls.Add(this.btnSua);
            this.panel6.Controls.Add(this.btnHuy);
            this.panel6.Location = new System.Drawing.Point(16, 400);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(443, 43);
            this.panel6.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(23, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(347, 11);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(185, 11);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(104, 11);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(266, 11);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(19, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(440, 57);
            this.panel5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Swiss Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(19, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ GIA PHẢ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCount);
            this.panel4.Controls.Add(this.treeView2);
            this.panel4.Controls.Add(this.txtTim);
            this.panel4.Controls.Add(this.btnTim);
            this.panel4.Location = new System.Drawing.Point(16, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(443, 263);
            this.panel4.TabIndex = 2;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(343, 12);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // treeView2
            // 
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeView2.Location = new System.Drawing.Point(0, 50);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(443, 213);
            this.treeView2.TabIndex = 2;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(126, 12);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(150, 20);
            this.txtTim.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(19, 12);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(101, 23);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ExpadClose);
            this.panel3.Controls.Add(this.txtDongHo);
            this.panel3.Controls.Add(this.btnThemDongHo);
            this.panel3.Location = new System.Drawing.Point(16, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 58);
            this.panel3.TabIndex = 1;
            // 
            // ExpadClose
            // 
            this.ExpadClose.Location = new System.Drawing.Point(343, 22);
            this.ExpadClose.Name = "ExpadClose";
            this.ExpadClose.Size = new System.Drawing.Size(75, 23);
            this.ExpadClose.TabIndex = 2;
            this.ExpadClose.Text = "Expad-Close";
            this.ExpadClose.UseVisualStyleBackColor = true;
            this.ExpadClose.Click += new System.EventHandler(this.ExpadClose_Click);
            // 
            // txtDongHo
            // 
            this.txtDongHo.Location = new System.Drawing.Point(126, 22);
            this.txtDongHo.Name = "txtDongHo";
            this.txtDongHo.Size = new System.Drawing.Size(150, 20);
            this.txtDongHo.TabIndex = 1;
            // 
            // btnThemDongHo
            // 
            this.btnThemDongHo.Location = new System.Drawing.Point(19, 22);
            this.btnThemDongHo.Name = "btnThemDongHo";
            this.btnThemDongHo.Size = new System.Drawing.Size(101, 23);
            this.btnThemDongHo.TabIndex = 0;
            this.btnThemDongHo.Text = "Thêm ông tổ";
            this.btnThemDongHo.UseVisualStyleBackColor = true;
            this.btnThemDongHo.Click += new System.EventHandler(this.btnThemDongHo_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM CÂY PHẢ HỆ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnMoFile;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.TextBox txtWorkPlace;
        private System.Windows.Forms.Label lblWorkPlace;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lalMail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtHomePlace;
        private System.Windows.Forms.Label lblHomePlace;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtPassDate;
        private System.Windows.Forms.Label lblPassDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtIdFather;
        private System.Windows.Forms.Label lblIdFather;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TreeView treeView2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnThemDongHo;
        private System.Windows.Forms.TextBox txtDongHo;
        private System.Windows.Forms.Button ExpadClose;
    }
}

