namespace SliderProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            var exts = new String[] { ".png", ".jpg", ".jpeg", ".gif" };//kieu dinh dang
            FolderBrowserDialog dialog = new FolderBrowserDialog();//cho phep chon 1 thu muc trong may tinh
            var rs = dialog.ShowDialog();
            if(rs == DialogResult.OK)//kiem tra xem ho bam nut nao
            {
                txtFolderPath.Text = dialog.SelectedPath;//chon file
                lsvListFile.Items.Clear();//xoa sach iteams trong list view

                DirectoryInfo directory = new DirectoryInfo(dialog.SelectedPath);//lay thong tin thu muc
                var listFile = directory.GetFiles();// lay toan bo file
                foreach(var file in listFile)
                {
                    if (exts.Contains(file.Extension.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(file.Name);
                        item.SubItems.Add(file.FullName);
                        item.SubItems.Add(file.Length.ToString());
                        lsvListFile.Items.Add(item);
                    }
                }
            }
        }

        private void lsvListFile_MouseDoubleClick(object sender, MouseEventArgs e)//mousedouble click trong phan event
        {
            var selectedItem = lsvListFile.SelectedItems[0];
            var imagePath = selectedItem.SubItems[1].ToString();
            ImageForm f = new ImageForm(imagePath);
            f.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void lsvListFile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}