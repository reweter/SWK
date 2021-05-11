
namespace SWK_Server
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_Users = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_Ip = new System.Windows.Forms.TextBox();
            this.label_Ip = new System.Windows.Forms.Label();
            this.label_Port = new System.Windows.Forms.Label();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.button_StartServer = new System.Windows.Forms.Button();
            this.label_SelectedUser = new System.Windows.Forms.Label();
            this.button_DownLog = new System.Windows.Forms.Button();
            this.button_Active = new System.Windows.Forms.Button();
            this.button_Disable = new System.Windows.Forms.Button();
            this.button_InstallExe = new System.Windows.Forms.Button();
            this.button_Exists = new System.Windows.Forms.Button();
            this.button_InDirectory = new System.Windows.Forms.Button();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.label_Response = new System.Windows.Forms.Label();
            this.textBox_Response = new System.Windows.Forms.TextBox();
            this.label_Status = new System.Windows.Forms.Label();
            this.button_DownloadFile = new System.Windows.Forms.Button();
            this.textBox_FileName = new System.Windows.Forms.TextBox();
            this.panel_Ip = new System.Windows.Forms.Panel();
            this.panel_Port = new System.Windows.Forms.Panel();
            this.panel_Network = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Button();
            this.panel_Status = new System.Windows.Forms.Panel();
            this.button_Copy = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.button_InDirectoryInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).BeginInit();
            this.panel_Ip.SuspendLayout();
            this.panel_Port.SuspendLayout();
            this.panel_Network.SuspendLayout();
            this.panel_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Users
            // 
            this.dataGridView_Users.AllowUserToAddRows = false;
            this.dataGridView_Users.AllowUserToDeleteRows = false;
            this.dataGridView_Users.AllowUserToResizeColumns = false;
            this.dataGridView_Users.AllowUserToResizeRows = false;
            this.dataGridView_Users.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Users.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Ip});
            this.dataGridView_Users.GridColor = System.Drawing.Color.Black;
            this.dataGridView_Users.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Users.MultiSelect = false;
            this.dataGridView_Users.Name = "dataGridView_Users";
            this.dataGridView_Users.ReadOnly = true;
            this.dataGridView_Users.RowHeadersVisible = false;
            this.dataGridView_Users.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Users.Size = new System.Drawing.Size(279, 457);
            this.dataGridView_Users.TabIndex = 0;
            this.dataGridView_Users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Users_CellClick);
            this.dataGridView_Users.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridView_Users_CellValueNeeded);
            // 
            // UserName
            // 
            this.UserName.HeaderText = "User";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Ip
            // 
            this.Ip.HeaderText = "Ip";
            this.Ip.Name = "Ip";
            this.Ip.ReadOnly = true;
            this.Ip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // textBox_Ip
            // 
            this.textBox_Ip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Ip.BackColor = System.Drawing.Color.Black;
            this.textBox_Ip.ForeColor = System.Drawing.Color.Chartreuse;
            this.textBox_Ip.Location = new System.Drawing.Point(31, 4);
            this.textBox_Ip.Name = "textBox_Ip";
            this.textBox_Ip.Size = new System.Drawing.Size(132, 20);
            this.textBox_Ip.TabIndex = 1;
            this.textBox_Ip.Text = "127.0.0.1";
            // 
            // label_Ip
            // 
            this.label_Ip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Ip.AutoSize = true;
            this.label_Ip.ForeColor = System.Drawing.Color.Chartreuse;
            this.label_Ip.Location = new System.Drawing.Point(3, 7);
            this.label_Ip.Name = "label_Ip";
            this.label_Ip.Size = new System.Drawing.Size(22, 13);
            this.label_Ip.TabIndex = 2;
            this.label_Ip.Text = "Ip: ";
            // 
            // label_Port
            // 
            this.label_Port.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Port.AutoSize = true;
            this.label_Port.ForeColor = System.Drawing.Color.Chartreuse;
            this.label_Port.Location = new System.Drawing.Point(6, 7);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(32, 13);
            this.label_Port.TabIndex = 4;
            this.label_Port.Text = "Port: ";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Port.BackColor = System.Drawing.Color.Black;
            this.textBox_Port.ForeColor = System.Drawing.Color.Chartreuse;
            this.textBox_Port.Location = new System.Drawing.Point(44, 4);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(52, 20);
            this.textBox_Port.TabIndex = 3;
            this.textBox_Port.Text = "6420";
            this.textBox_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_StartServer
            // 
            this.button_StartServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_StartServer.BackColor = System.Drawing.Color.Black;
            this.button_StartServer.ForeColor = System.Drawing.Color.Chartreuse;
            this.button_StartServer.Location = new System.Drawing.Point(175, 35);
            this.button_StartServer.Name = "button_StartServer";
            this.button_StartServer.Size = new System.Drawing.Size(96, 23);
            this.button_StartServer.TabIndex = 5;
            this.button_StartServer.Text = "Start";
            this.button_StartServer.UseVisualStyleBackColor = false;
            this.button_StartServer.Click += new System.EventHandler(this.button_StartServer_Click);
            // 
            // label_SelectedUser
            // 
            this.label_SelectedUser.AutoSize = true;
            this.label_SelectedUser.ForeColor = System.Drawing.Color.Chartreuse;
            this.label_SelectedUser.Location = new System.Drawing.Point(300, 80);
            this.label_SelectedUser.Name = "label_SelectedUser";
            this.label_SelectedUser.Size = new System.Drawing.Size(43, 13);
            this.label_SelectedUser.TabIndex = 8;
            this.label_SelectedUser.Text = "USER: ";
            // 
            // button_DownLog
            // 
            this.button_DownLog.BackColor = System.Drawing.Color.Black;
            this.button_DownLog.ForeColor = System.Drawing.Color.Chartreuse;
            this.button_DownLog.Location = new System.Drawing.Point(300, 99);
            this.button_DownLog.Name = "button_DownLog";
            this.button_DownLog.Size = new System.Drawing.Size(89, 23);
            this.button_DownLog.TabIndex = 9;
            this.button_DownLog.Text = "DownLog";
            this.button_DownLog.UseVisualStyleBackColor = false;
            this.button_DownLog.Click += new System.EventHandler(this.button_DownLog_Click);
            // 
            // button_Active
            // 
            this.button_Active.BackColor = System.Drawing.Color.Black;
            this.button_Active.ForeColor = System.Drawing.Color.Chartreuse;
            this.button_Active.Location = new System.Drawing.Point(395, 99);
            this.button_Active.Name = "button_Active";
            this.button_Active.Size = new System.Drawing.Size(149, 23);
            this.button_Active.TabIndex = 10;
            this.button_Active.Text = "Active";
            this.button_Active.UseVisualStyleBackColor = false;
            this.button_Active.Click += new System.EventHandler(this.button_Active_Click);
            // 
            // button_Disable
            // 
            this.button_Disable.BackColor = System.Drawing.Color.Black;
            this.button_Disable.ForeColor = System.Drawing.Color.Chartreuse;
            this.button_Disable.Location = new System.Drawing.Point(550, 99);
            this.button_Disable.Name = "button_Disable";
            this.button_Disable.Size = new System.Drawing.Size(136, 23);
            this.button_Disable.TabIndex = 11;
            this.button_Disable.Text = "Disable";
            this.button_Disable.UseVisualStyleBackColor = false;
            this.button_Disable.Click += new System.EventHandler(this.button_Disable_Click);
            // 
            // button_InstallExe
            // 
            this.button_InstallExe.BackColor = System.Drawing.Color.Black;
            this.button_InstallExe.ForeColor = System.Drawing.Color.Chartreuse;
            this.button_InstallExe.Location = new System.Drawing.Point(300, 128);
            this.button_InstallExe.Name = "button_InstallExe";
            this.button_InstallExe.Size = new System.Drawing.Size(89, 23);
            this.button_InstallExe.TabIndex = 12;
            this.button_InstallExe.Text = "InstallExe";
            this.button_InstallExe.UseVisualStyleBackColor = false;
            this.button_InstallExe.Click += new System.EventHandler(this.button_InstallExe_Click);
            // 
            // button_Exists
            // 
            this.button_Exists.BackColor = System.Drawing.Color.Black;
            this.button_Exists.ForeColor = System.Drawing.Color.Chartreuse;
            this.button_Exists.Location = new System.Drawing.Point(300, 157);
            this.button_Exists.Name = "button_Exists";
            this.button_Exists.Size = new System.Drawing.Size(89, 23);
            this.button_Exists.TabIndex = 13;
            this.button_Exists.Text = "Exists";
            this.button_Exists.UseVisualStyleBackColor = false;
            this.button_Exists.Click += new System.EventHandler(this.button_Exists_Click);
            // 
            // button_InDirectory
            // 
            this.button_InDirectory.BackColor = System.Drawing.Color.Black;
            this.button_InDirectory.ForeColor = System.Drawing.Color.Chartreuse;
            this.button_InDirectory.Location = new System.Drawing.Point(300, 186);
            this.button_InDirectory.Name = "button_InDirectory";
            this.button_InDirectory.Size = new System.Drawing.Size(55, 23);
            this.button_InDirectory.TabIndex = 14;
            this.button_InDirectory.Text = "InDirectory";
            this.button_InDirectory.UseVisualStyleBackColor = false;
            this.button_InDirectory.Click += new System.EventHandler(this.button_InDirectory_Click);
            // 
            // textBox_Path
            // 
            this.textBox_Path.BackColor = System.Drawing.Color.Black;
            this.textBox_Path.ForeColor = System.Drawing.Color.Chartreuse;
            this.textBox_Path.Location = new System.Drawing.Point(395, 128);
            this.textBox_Path.Multiline = true;
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(291, 81);
            this.textBox_Path.TabIndex = 15;
            // 
            // label_Response
            // 
            this.label_Response.AutoSize = true;
            this.label_Response.ForeColor = System.Drawing.Color.Chartreuse;
            this.label_Response.Location = new System.Drawing.Point(300, 225);
            this.label_Response.Name = "label_Response";
            this.label_Response.Size = new System.Drawing.Size(72, 13);
            this.label_Response.TabIndex = 16;
            this.label_Response.Text = "RESPONSE: ";
            // 
            // textBox_Response
            // 
            this.textBox_Response.BackColor = System.Drawing.Color.Black;
            this.textBox_Response.ForeColor = System.Drawing.Color.Chartreuse;
            this.textBox_Response.Location = new System.Drawing.Point(300, 247);
            this.textBox_Response.Multiline = true;
            this.textBox_Response.Name = "textBox_Response";
            this.textBox_Response.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Response.Size = new System.Drawing.Size(386, 165);
            this.textBox_Response.TabIndex = 17;
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.ForeColor = System.Drawing.Color.Red;
            this.label_Status.Location = new System.Drawing.Point(7, 12);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(100, 13);
            this.label_Status.TabIndex = 18;
            this.label_Status.Text = "STATUS: Disabled ";
            // 
            // button_DownloadFile
            // 
            this.button_DownloadFile.BackColor = System.Drawing.Color.Black;
            this.button_DownloadFile.ForeColor = System.Drawing.Color.Chartreuse;
            this.button_DownloadFile.Location = new System.Drawing.Point(395, 215);
            this.button_DownloadFile.Name = "button_DownloadFile";
            this.button_DownloadFile.Size = new System.Drawing.Size(86, 23);
            this.button_DownloadFile.TabIndex = 19;
            this.button_DownloadFile.Text = "Download File";
            this.button_DownloadFile.UseVisualStyleBackColor = false;
            this.button_DownloadFile.Click += new System.EventHandler(this.button_DownloadFile_Click);
            // 
            // textBox_FileName
            // 
            this.textBox_FileName.BackColor = System.Drawing.Color.Black;
            this.textBox_FileName.ForeColor = System.Drawing.Color.Chartreuse;
            this.textBox_FileName.Location = new System.Drawing.Point(487, 217);
            this.textBox_FileName.Name = "textBox_FileName";
            this.textBox_FileName.Size = new System.Drawing.Size(199, 20);
            this.textBox_FileName.TabIndex = 20;
            // 
            // panel_Ip
            // 
            this.panel_Ip.Controls.Add(this.label_Ip);
            this.panel_Ip.Controls.Add(this.textBox_Ip);
            this.panel_Ip.Location = new System.Drawing.Point(3, 4);
            this.panel_Ip.Name = "panel_Ip";
            this.panel_Ip.Size = new System.Drawing.Size(166, 25);
            this.panel_Ip.TabIndex = 21;
            // 
            // panel_Port
            // 
            this.panel_Port.Controls.Add(this.label_Port);
            this.panel_Port.Controls.Add(this.textBox_Port);
            this.panel_Port.Location = new System.Drawing.Point(175, 4);
            this.panel_Port.Name = "panel_Port";
            this.panel_Port.Size = new System.Drawing.Size(100, 25);
            this.panel_Port.TabIndex = 22;
            // 
            // panel_Network
            // 
            this.panel_Network.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_Network.Controls.Add(this.button_Close);
            this.panel_Network.Controls.Add(this.panel_Ip);
            this.panel_Network.Controls.Add(this.panel_Port);
            this.panel_Network.Controls.Add(this.button_StartServer);
            this.panel_Network.Location = new System.Drawing.Point(300, 12);
            this.panel_Network.Name = "panel_Network";
            this.panel_Network.Size = new System.Drawing.Size(278, 65);
            this.panel_Network.TabIndex = 23;
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.BackColor = System.Drawing.Color.Black;
            this.button_Close.ForeColor = System.Drawing.Color.Chartreuse;
            this.button_Close.Location = new System.Drawing.Point(73, 34);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(96, 23);
            this.button_Close.TabIndex = 31;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // panel_Status
            // 
            this.panel_Status.Controls.Add(this.label_Status);
            this.panel_Status.Location = new System.Drawing.Point(581, 4);
            this.panel_Status.Name = "panel_Status";
            this.panel_Status.Size = new System.Drawing.Size(109, 73);
            this.panel_Status.TabIndex = 26;
            // 
            // button_Copy
            // 
            this.button_Copy.BackColor = System.Drawing.Color.Black;
            this.button_Copy.ForeColor = System.Drawing.Color.Chartreuse;
            this.button_Copy.Location = new System.Drawing.Point(300, 418);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(131, 23);
            this.button_Copy.TabIndex = 27;
            this.button_Copy.Text = "Copy";
            this.button_Copy.UseVisualStyleBackColor = false;
            this.button_Copy.Click += new System.EventHandler(this.button_Copy_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.Black;
            this.button_Clear.ForeColor = System.Drawing.Color.Chartreuse;
            this.button_Clear.Location = new System.Drawing.Point(437, 418);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(118, 23);
            this.button_Clear.TabIndex = 28;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Black;
            this.button_Save.ForeColor = System.Drawing.Color.Chartreuse;
            this.button_Save.Location = new System.Drawing.Point(561, 418);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(125, 23);
            this.button_Save.TabIndex = 29;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*\"";
            // 
            // button_InDirectoryInfo
            // 
            this.button_InDirectoryInfo.BackColor = System.Drawing.Color.Black;
            this.button_InDirectoryInfo.ForeColor = System.Drawing.Color.Chartreuse;
            this.button_InDirectoryInfo.Location = new System.Drawing.Point(361, 186);
            this.button_InDirectoryInfo.Name = "button_InDirectoryInfo";
            this.button_InDirectoryInfo.Size = new System.Drawing.Size(28, 23);
            this.button_InDirectoryInfo.TabIndex = 30;
            this.button_InDirectoryInfo.Text = "+";
            this.button_InDirectoryInfo.UseVisualStyleBackColor = false;
            this.button_InDirectoryInfo.Click += new System.EventHandler(this.button_InDirectoryInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(698, 481);
            this.Controls.Add(this.button_InDirectoryInfo);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Copy);
            this.Controls.Add(this.panel_Status);
            this.Controls.Add(this.panel_Network);
            this.Controls.Add(this.textBox_FileName);
            this.Controls.Add(this.button_DownloadFile);
            this.Controls.Add(this.textBox_Response);
            this.Controls.Add(this.label_Response);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.button_InDirectory);
            this.Controls.Add(this.button_Exists);
            this.Controls.Add(this.button_InstallExe);
            this.Controls.Add(this.button_Disable);
            this.Controls.Add(this.button_Active);
            this.Controls.Add(this.button_DownLog);
            this.Controls.Add(this.label_SelectedUser);
            this.Controls.Add(this.dataGridView_Users);
            this.Name = "MainForm";
            this.Text = "SWK Server";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).EndInit();
            this.panel_Ip.ResumeLayout(false);
            this.panel_Ip.PerformLayout();
            this.panel_Port.ResumeLayout(false);
            this.panel_Port.PerformLayout();
            this.panel_Network.ResumeLayout(false);
            this.panel_Status.ResumeLayout(false);
            this.panel_Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Users;
        private System.Windows.Forms.TextBox textBox_Ip;
        private System.Windows.Forms.Label label_Ip;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Button button_StartServer;
        private System.Windows.Forms.Label label_SelectedUser;
        private System.Windows.Forms.Button button_DownLog;
        private System.Windows.Forms.Button button_Active;
        private System.Windows.Forms.Button button_Disable;
        private System.Windows.Forms.Button button_InstallExe;
        private System.Windows.Forms.Button button_Exists;
        private System.Windows.Forms.Button button_InDirectory;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Label label_Response;
        private System.Windows.Forms.TextBox textBox_Response;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Button button_DownloadFile;
        private System.Windows.Forms.TextBox textBox_FileName;
        private System.Windows.Forms.Panel panel_Ip;
        private System.Windows.Forms.Panel panel_Port;
        private System.Windows.Forms.Panel panel_Network;
        private System.Windows.Forms.Panel panel_Status;
        private System.Windows.Forms.Button button_Copy;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button button_InDirectoryInfo;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ip;
    }
}

