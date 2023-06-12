using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using FamilyTree;
using System.ComponentModel.Design.Serialization;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using LicenseContext = OfficeOpenXml.LicenseContext;
using System.Drawing.Printing;
using System.Security.Cryptography;

namespace FamilyTree
{
    public partial class Form1 : Form
    {
        List <Info> infos = new List <Info> ();
        public Form1()
        {
            InitializeComponent();
            //Create the root node.
            //Info rootNode = new Info();            
            //rootNode.PersonNode.NameNode = "Gia tộc họ";
            //rootNode.PersonNode.IdFather = "0";
            //rootNode.PersonNode.Id = "0";
            //rootNode.Gen = 0;
            //rootNode.NodeTree.Name = rootNode.PersonNode.NameNode;
            //infos.Add(rootNode);
            //Add the root node to the tree view.            
            //treeView1.Nodes.Add(rootNode.NodeTree.Name);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearBox();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            EnableBox();
            txtIdFather.Enabled = false;
            txtGen.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtId.Text == "")
            {
                MessageBox.Show("Chưa có dữ liệu được chọn!");
                return;
            }
            foreach (Info info1 in infos)
            {
                if (txtId.Text == info1.PersonNode.Id)
                {
                    info1.PersonNode.IdFather = txtIdFather.Text;
                    info1.PersonNode.NameNode = txtName.Text;
                    info1.PersonNode.Date = txtDate.Text;
                    info1.PersonNode.PassDate = txtPassDate.Text;
                    info1.PersonNode.Sex = txtSex.Text;
                    info1.PersonNode.Home_place = txtHomePlace.Text;
                    info1.PersonNode.Phone = txtPhone.Text;
                    info1.PersonNode.Email = txtMail.Text;
                    info1.PersonNode.Position = txtPosition.Text;
                    info1.PersonNode.Work_place = txtWorkPlace.Text;
                    info1.PersonNode.Note = rtbNote.Text;
                    info1.NodeTree.Name = txtName.Text;
                    info1.Gen = Int32.Parse(txtGen.Text);
                }
            }
            treeView1.Refresh();
            MessageBox.Show("Sửa thông tin thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {            
            if (txtId.Text == "")
            {
                MessageBox.Show("Chưa có dữ liệu được chọn!");
                return;
            }
            foreach (Info info1 in infos)
            {
                if (CheckName(info1.NodeTree.Name) == 1)
                {
                    infos.Remove(info1);
                    break;
                }
            }
            treeView1.SelectedNode.Remove();
            MessageBox.Show("Đã xóa thông tin thành công!");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearBox();
            treeView1.Refresh();
            DisabledBox();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Chưa nhập ID hoặc dữ liệu!");
                return;
            }
            Info info = new Info();
            info.PersonNode.Id = txtId.Text;
            info.PersonNode.IdFather = txtIdFather.Text;
            info.PersonNode.NameNode = txtName.Text;
            info.PersonNode.Date = txtDate.Text;
            info.PersonNode.PassDate = txtPassDate.Text;
            info.PersonNode.Sex = txtSex.Text;
            info.PersonNode.Home_place = txtHomePlace.Text;
            info.PersonNode.Phone = txtPhone.Text;
            info.PersonNode.Email = txtMail.Text;
            info.PersonNode.Position = txtPosition.Text;
            info.PersonNode.Work_place = txtWorkPlace.Text;
            info.PersonNode.Note = rtbNote.Text;
            info.NodeTree.Name = info.PersonNode.NameNode;
            info.Gen = Int32.Parse(txtGen.Text);
            foreach (Info info1 in infos)
            {
                if (info.PersonNode.Id.Trim() == info1.PersonNode.Id.Trim())
                {
                    MessageBox.Show("ID chưa nhập hoặc đã tồn tại!");
                    return;
                }  
            }
            infos.Add(info);
            treeView1.SelectedNode.Nodes.Add(info.NodeTree.Name);
            treeView1.Refresh();
            ClearBox();
            DisabledBox();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            MessageBox.Show("Đã lưu thông tin thành công!");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            treeView2.Nodes.Clear();
            if (txtTim.Text == "")
            {
                MessageBox.Show("Chưa nhập nội dung tìm kiếm!");
                return;
            }            
            List<Info> infotemp = new List<Info>();           
            foreach (Info info1 in infos)
            {
                if ((txtTim.Text.Contains(info1.PersonNode.NameNode)) || (txtTim.Text.Contains(info1.PersonNode.Date)) 
                    || (txtTim.Text.Contains(info1.PersonNode.PassDate)) || (txtTim.Text.Contains(info1.PersonNode.Sex))
                        || (txtTim.Text.Contains(info1.PersonNode.Home_place)) 
                        || (txtTim.Text.Contains(info1.PersonNode.Position)) || (txtTim.Text.Contains(info1.PersonNode.Work_place)))
                {
                    infotemp.Add(info1);
                    treeView2.Nodes.Add(info1.NodeTree.Name);                    
                    treeView2.Refresh();
                }
            }
            MessageBox.Show("Có " + (treeView2.Nodes.Count - 1) + " dữ liệu phù hợp với điều kiện tìm!");
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() == DialogResult.OK)
            {
                //printDocument1.Print(); 
                printDialog1.ShowDialog(treeView1);
            }
        }

        int AddTreeView(TreeNode temp, string fatherid)
        {
            //TreeNode temp1 = temp;
            int stt = 0;
            int i;
            for (i = 0; i < infos.Count; i++)
            {
                if (infos[i].PersonNode.IdFather == fatherid)
                {
                    //temp = temp1;
                    temp.Nodes.Add(infos[i].PersonNode.NameNode);
                    AddTreeView(temp.Nodes[stt++], infos[i].PersonNode.Id);
                }
            }


            return 1;
        }
        private void btnMoFile_Click(object sender, EventArgs e)
        {
            
            if (infos.Count > 1)
            { 
                MessageBox.Show("Đã có dữ liệu được mở!");
                return;
            }
            
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial; //Nếu ko có dòng này thì sẽ có ex "Please set the ExcelPackage.LicenseContext properties"
                // mở file excel
                var package = new ExcelPackage(new FileInfo("D:\\1. HOC TAP\\1. LOP CNTT12\\11. KY THUAT LAP TRINH\\FamilyTree\\1.xlsx"));

                // lấy ra sheet đầu tiên để thao tác
                ExcelWorksheet workSheet = package.Workbook.Worksheets[0];

                // duyệt tuần tự từ dòng thứ 5 đến dòng cuối cùng của file. lưu ý file excel bắt đầu từ số 1 không phải số 0
                for (int i = workSheet.Dimension.Start.Row + 3; i <= workSheet.Dimension.End.Row; i++)
                {
                    try
                    {
                        // biến j biểu thị cho một column trong file
                        int j = 1;

                        // lấy ra cột ID tương ứng giá trị tại vị trí [i, j++]. i lần đầu = 3, j = 1  // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh
                        string id = workSheet.Cells[i, j++].Value.ToString();                      
                        string idFather = workSheet.Cells[i, j++].Value.ToString();                     
                        string name = workSheet.Cells[i, j++].Value.ToString();                      
                        string date = workSheet.Cells[i, j++].Value.ToString();                    
                        string passDate = workSheet.Cells[i, j++].Value.ToString();                      
                        string sex = workSheet.Cells[i, j++].Value.ToString();                      
                        string homePlace = workSheet.Cells[i, j++].Value.ToString();                       
                        string phone = workSheet.Cells[i, j++].Value.ToString();                       
                        string email = workSheet.Cells[i, j++].Value.ToString();                      
                        string position = workSheet.Cells[i, j++].Value.ToString();                      
                        string workPlace = workSheet.Cells[i, j++].Value.ToString();                      
                        string gen = workSheet.Cells[i, j++].Value.ToString();                      
                        string note = workSheet.Cells[i, j++].Value.ToString();

                        // tạo user từ dữ liệu đã lấy được
                        Info user = new Info();
                        user.PersonNode.Id = id;
                        user.PersonNode.IdFather = idFather;
                        user.PersonNode.NameNode = name;
                        user.PersonNode.Date = date;
                        user.PersonNode.PassDate = passDate;
                        user.PersonNode.Sex = sex;
                        user.PersonNode.Home_place = homePlace;
                        user.PersonNode.Phone = phone;
                        user.PersonNode.Email = email;
                        user.PersonNode.Position = position;
                        user.PersonNode.Work_place = workPlace;
                        user.PersonNode.Note = note;
                        user.Gen = Int32.Parse(gen);
                        user.NodeTree.Name = name;

                        // add user vào danh sách infos
                        
                        infos.Add(user);


                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show(exe.ToString());
                    }                    
                }
                MessageBox.Show("Mở file thành công!");
                treeView1.Refresh();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Lỗi đọc file!");
            }

            //==========================================================
            //treeView1.Nodes.Add(infos[0].PersonNode.NameNode);
            //treeView1.Nodes.Add(infos[1].PersonNode.NameNode);

            //TreeNode temp;
            //temp = treeView1.Nodes[0];
            //temp.Nodes.Add(infos[3].PersonNode.NameNode);
            //temp.Nodes.Add(infos[4].PersonNode.NameNode);
            //temp.Nodes.Add(infos[4].PersonNode.NameNode);

            //temp = temp.Nodes[0];
            //temp.Nodes.Add(infos[3].PersonNode.NameNode);

            //temp = temp.Nodes[0];
            //temp.Nodes.Add(infos[3].PersonNode.NameNode);

            //temp = temp.Nodes[0];
            //temp.Nodes.Add(infos[3].PersonNode.NameNode);


            treeView1.Nodes.Add(infos[0].PersonNode.NameNode);
            AddTreeView(treeView1.Nodes[0], infos[0].PersonNode.Id);
            treeView1.ExpandAll();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
             
        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Refresh();
            treeView1.ExpandAll();
            DisabledBox();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            treeView1.SelectedNode.Expand();
            txtIdFather.Enabled = false;
            txtGen.Enabled = false;
            foreach (Info info1 in infos)
            {
                if (treeView1.SelectedNode.ToString().Substring(10) == info1.NodeTree.Name)
                {
                    txtIdFather.Text = info1.PersonNode.Id;
                    txtGen.Text = (info1.Gen + 1).ToString();
                }
            }
        }
        private void DisplayPerson(Info info)
        {
            txtId.Text = info.PersonNode.Id;
            txtIdFather.Text = info.PersonNode.IdFather;
            txtName.Text = info.PersonNode.NameNode;
            txtDate.Text = info.PersonNode.Date;
            txtPassDate.Text = info.PersonNode.PassDate;
            txtSex.Text = info.PersonNode.Sex;
            txtHomePlace.Text = info.PersonNode.Home_place;
            txtPhone.Text = info.PersonNode.Phone;
            txtMail.Text = info.PersonNode.Email;
            txtPosition.Text = info.PersonNode.Position;
            txtWorkPlace.Text = info.PersonNode.Work_place;
            rtbNote.Text = info.PersonNode.Note;
            txtGen.Text = info.Gen.ToString();
        }
                
        private void ClearBox()
        {
            txtId.Text = "";
            txtIdFather.Text = "";
            txtName.Text = "";
            txtDate.Text = "";
            txtPassDate.Text = "";
            txtSex.Text = "";
            txtHomePlace.Text = "";
            txtPhone.Text = "";
            txtMail.Text = "";
            txtPosition.Text = "";
            txtWorkPlace.Text = "";
            rtbNote.Text = "";
            txtGen.Text = "";
        }
        private void DisabledBox()
        {
            txtId.Enabled = false;
            txtIdFather.Enabled = false;
            txtName.Enabled = false;
            txtDate.Enabled = false;
            txtPassDate.Enabled = false;
            txtSex.Enabled = false;
            txtHomePlace.Enabled = false;
            txtPhone.Enabled = false;
            txtMail.Enabled = false;
            txtPosition.Enabled = false;
            txtWorkPlace.Enabled = false;
            rtbNote.Enabled = false;
            txtGen.Enabled = false;
        }
        private void EnableBox()
        {
            txtId.Enabled = true;
            txtIdFather.Enabled = true;
            txtName.Enabled = true;
            txtDate.Enabled = true;
            txtPassDate.Enabled = true;
            txtSex.Enabled = true;
            txtHomePlace.Enabled = true;
            txtPhone.Enabled = true;
            txtMail.Enabled = true;
            txtPosition.Enabled = true;
            txtWorkPlace.Enabled = true;
            rtbNote.Enabled = true;
            txtGen.Enabled = true;
        }        

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tổng số người: " + infos.Count + " và tổng số node: " + treeView1.GetNodeCount(true));
        }
        private int CheckName(string name)
        {
            if (treeView1.SelectedNode.ToString().Substring(10) == name)
                return 1;
            else
                return 0;
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn không hợp lệ");
                return;
            }

            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial; //Nếu ko có dòng này thì sẽ có ex "Please set the ExcelPackage.LicenseContext properties"
                using (ExcelPackage p = new ExcelPackage())
                {                    
                    //Tạo một sheet để làm việc trên đó với tên tự đặt
                    p.Workbook.Worksheets.Add("Nguyen sheet");

                    // lấy sheet vừa add ra để thao tác
                    ExcelWorksheet ws = p.Workbook.Worksheets[0];
                    
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 11;
                    // font family mặc định cho cả sheet
                    ws.Cells.Style.Font.Name = "Calibri";

                    // Tạo danh sách các column header
                    string[] arrColumnHeader = {"ID", "IDFather", "Họ và tên", "Năm sinh", "Năm mất", "Giới tính", "Thường trú", "SĐT", "Email", "Chức vụ", "Nơi công tác", "Đời thứ", "Ghi chú"};
                    
                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = arrColumnHeader.Count();

                    // merge các column lại từ column 1 đến số column header, // gán giá trị cho cell vừa merge là Thống kê thông tin
                    ws.Cells[1, 1].Value = "Thống kê thông tin " + infos[0].PersonNode.NameNode;
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    // in đậm
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                    // căn giữa
                    ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    int colIndex = 1;
                    int rowIndex = 3;

                    //tạo các header từ column header đã tạo từ bên trên
                    foreach (var item in arrColumnHeader)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];

                        //căn giữa
                        cell.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                        //set màu thành gray
                        var fill = cell.Style.Fill;
                        fill.PatternType = ExcelFillStyle.Solid;
                        fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

                        //căn chỉnh các border
                        var border = cell.Style.Border;
                        border.Bottom.Style =
                            border.Top.Style =
                            border.Left.Style =
                            border.Right.Style = ExcelBorderStyle.Thin;

                        //gán giá trị
                        cell.Value = item;

                        colIndex++;
                    }

                    // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                    foreach (var item in infos)
                    {
                        // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                        colIndex = 1;

                        // rowIndex tương ứng từng dòng dữ liệu
                        rowIndex++;

                        //gán giá trị cho từng cell                      
                        ws.Cells[rowIndex, colIndex++].Value = item.PersonNode.Id;
                        ws.Cells[rowIndex, colIndex++].Value = item.PersonNode.IdFather;
                        ws.Cells[rowIndex, colIndex++].Value = item.PersonNode.NameNode;
                        ws.Cells[rowIndex, colIndex++].Value = item.PersonNode.Date;
                        ws.Cells[rowIndex, colIndex++].Value = item.PersonNode.PassDate;
                        ws.Cells[rowIndex, colIndex++].Value = item.PersonNode.Sex;
                        ws.Cells[rowIndex, colIndex++].Value = item.PersonNode.Home_place;
                        ws.Cells[rowIndex, colIndex++].Value = item.PersonNode.Phone;
                        ws.Cells[rowIndex, colIndex++].Value = item.PersonNode.Email;
                        ws.Cells[rowIndex, colIndex++].Value = item.PersonNode.Position;
                        ws.Cells[rowIndex, colIndex++].Value = item.PersonNode.Work_place;
                        ws.Cells[rowIndex, colIndex++].Value = item.Gen;
                        ws.Cells[rowIndex, colIndex++].Value = item.PersonNode.Note;
                    }

                    //Lưu file lại
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Xuất excel thành công!");
            }
            catch (Exception EE)
            {
                MessageBox.Show("Có lỗi khi lưu file!");
            }
        }

        private void btnLamMoi_Click_2(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Clear();
                infos.Clear();

                //Create the root node.
                Info rootNode = new Info();
                rootNode.PersonNode.NameNode = "Gia tộc họ";
                rootNode.PersonNode.IdFather = "0";
                rootNode.PersonNode.Id = "0";
                rootNode.Gen = 0;
                rootNode.NodeTree.Name = rootNode.PersonNode.NameNode;
                infos.Add(rootNode);
                //Add the root node to the tree view.            
                treeView1.Nodes.Add(rootNode.NodeTree.Name);
                treeView1.Refresh();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
            
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView1.ExpandAll();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            EnableBox();
            txtId.Enabled = false;
            foreach (Info info1 in infos)
            {
                if (treeView1.SelectedNode.ToString().Substring(10) == info1.NodeTree.Name)
                {
                    DisplayPerson(info1);
                }
            }
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeView2.ExpandAll();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            DisabledBox();
            foreach (Info info1 in infos)
            {
                if (treeView2.SelectedNode.ToString().Substring(10) == info1.NodeTree.Name)
                {
                    DisplayPerson(info1);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.treeView1.Width, this.treeView1.Height);
            this.treeView1.DrawToBitmap(bmp, new Rectangle(0, 0, this.treeView1.Width, this.treeView1.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
            MessageBox.Show("Tạo sơ đồ gia phả thành công!");
        }
        private int MaxGen()
        {
            int max = 0;
            int [] generation = new int[100];
            int i = 0;
            foreach (Info info in infos)
            {
                generation[i] = info.Gen;
            }
            for (int j =  0; j < generation.Length; j++)
            {
                for (int k = j + 1; k < generation.Length; k++)
                {
                    if (generation[j] < generation[k])
                    {
                        max = generation[k];
                    }
                    else
                    {
                        max = generation[j];
                    }
                }
            }
            return max;
        }
        private void LoadTree(Info user)
        {
            foreach (Info info1 in infos)
            {
                if (user.PersonNode.IdFather == info1.PersonNode.Id)
                {
                    if (treeView1.SelectedNode != null)
                    {
                        info1.Nodes.Add(user.NodeTree.Name);
                    }
                    else
                    {
                        MessageBox.Show("Không có node được chọn!");
                    }
                }
            }
        }
        private void AddNode(Info user)
        {
            foreach(Info info in infos)
            {                
                for (int i = 0; i < infos.Count; i++)
                {
                    if (user.PersonNode.IdFather == info.PersonNode.Id)
                        treeView1.Nodes.Add(info.NodeTree.Name);
                    for (int j = 0; j < infos.Count; j++)
                    {
                        treeView1.Nodes[i].Nodes.Add(info.NodeTree.Name);
                    }
                }
            }
            
        }

    }
}
