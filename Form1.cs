namespace Duplicate_Folder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BrowseSrcFold_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtSrcFold.Text = folderDlg.SelectedPath;
            }
        }

        private void BrowseDesFold_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtDesFold.Text = folderDlg.SelectedPath;
            }
        }
        public void CloneFolder(string src, string des)
        {
            DirectoryInfo dir = new DirectoryInfo(src);
            DirectoryInfo[] dirs = dir.GetDirectories();

            Directory.CreateDirectory(des);

            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(des, subdir.Name);
                CloneFolder(subdir.FullName, temppath);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtSrcFold.Text.Length == 0 || txtDesFold.Text.Length == 0)
            {
                MessageBox.Show("Error");
                return;
            }

            if (!Directory.Exists(txtSrcFold.Text) || !Directory.Exists(txtDesFold.Text))
            {
                MessageBox.Show("Error");
                return;
            }

            string nameFolderDes = @$"{txtDesFold.Text}\{Path.GetFileName(txtSrcFold.Text)}(clone)";
            CloneFolder(txtSrcFold.Text, nameFolderDes);
        }
    }
}
