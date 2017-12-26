namespace WebExplorer
{
    partial class WebExplorerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebExplorerForm));
            this.treeViewList = new System.Windows.Forms.TreeView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lblDownload = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblDownloadSpeed = new System.Windows.Forms.Label();
            this.lblDownloadSize = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnList = new MetroFramework.Controls.MetroButton();
            this.txtBoxUrl = new MetroFramework.Controls.MetroTextBox();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.progressSpin = new MetroFramework.Controls.MetroProgressSpinner();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewList
            // 
            this.treeViewList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewList.HideSelection = false;
            this.treeViewList.Location = new System.Drawing.Point(21, 96);
            this.treeViewList.Margin = new System.Windows.Forms.Padding(0);
            this.treeViewList.Name = "treeViewList";
            this.treeViewList.Size = new System.Drawing.Size(479, 633);
            this.treeViewList.TabIndex = 3;
            this.treeViewList.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeViewList_AfterExpand);
            this.treeViewList.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewList_BeforeSelect);
            this.treeViewList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewList_MouseDown);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "folder.gif");
            this.imageList.Images.SetKeyName(1, "image.gif");
            this.imageList.Images.SetKeyName(2, "sound.gif");
            this.imageList.Images.SetKeyName(3, "binary.gif");
            this.imageList.Images.SetKeyName(4, "movie.gif");
            this.imageList.Images.SetKeyName(5, "text.gif");
            this.imageList.Images.SetKeyName(6, "unknown.gif");
            this.imageList.Images.SetKeyName(7, "layout.gif");
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Location = new System.Drawing.Point(505, 581);
            this.lblDownload.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(95, 17);
            this.lblDownload.TabIndex = 5;
            this.lblDownload.Text = "labelDownload";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentage.Location = new System.Drawing.Point(720, 557);
            this.lblPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(33, 17);
            this.lblPercentage.TabIndex = 6;
            this.lblPercentage.Text = "50%";
            // 
            // lblDownloadSpeed
            // 
            this.lblDownloadSpeed.AutoSize = true;
            this.lblDownloadSpeed.Location = new System.Drawing.Point(505, 598);
            this.lblDownloadSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDownloadSpeed.Name = "lblDownloadSpeed";
            this.lblDownloadSpeed.Size = new System.Drawing.Size(132, 17);
            this.lblDownloadSpeed.TabIndex = 7;
            this.lblDownloadSpeed.Text = "labelDownloadSpeed";
            // 
            // lblDownloadSize
            // 
            this.lblDownloadSize.AutoSize = true;
            this.lblDownloadSize.Location = new System.Drawing.Point(505, 615);
            this.lblDownloadSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDownloadSize.Name = "lblDownloadSize";
            this.lblDownloadSize.Size = new System.Drawing.Size(118, 17);
            this.lblDownloadSize.TabIndex = 8;
            this.lblDownloadSize.Text = "labelDownloadSize";
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(506, 96);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(453, 453);
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(506, 67);
            this.btnList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(66, 24);
            this.btnList.TabIndex = 10;
            this.btnList.Text = "List";
            this.btnList.UseSelectable = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtBoxUrl
            // 
            // 
            // 
            // 
            this.txtBoxUrl.CustomButton.Image = null;
            this.txtBoxUrl.CustomButton.Location = new System.Drawing.Point(458, 2);
            this.txtBoxUrl.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxUrl.CustomButton.Name = "";
            this.txtBoxUrl.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtBoxUrl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxUrl.CustomButton.TabIndex = 1;
            this.txtBoxUrl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxUrl.CustomButton.UseSelectable = true;
            this.txtBoxUrl.CustomButton.Visible = false;
            this.txtBoxUrl.Lines = new string[] {
        "http://bitcore.net/stuff/"};
            this.txtBoxUrl.Location = new System.Drawing.Point(21, 67);
            this.txtBoxUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxUrl.MaxLength = 32767;
            this.txtBoxUrl.Name = "txtBoxUrl";
            this.txtBoxUrl.PasswordChar = '\0';
            this.txtBoxUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxUrl.SelectedText = "";
            this.txtBoxUrl.SelectionLength = 0;
            this.txtBoxUrl.SelectionStart = 0;
            this.txtBoxUrl.ShortcutsEnabled = true;
            this.txtBoxUrl.Size = new System.Drawing.Size(480, 24);
            this.txtBoxUrl.TabIndex = 11;
            this.txtBoxUrl.Text = "http://bitcore.net/stuff/";
            this.txtBoxUrl.UseSelectable = true;
            this.txtBoxUrl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxUrl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(287, 2);
            this.txtSearch.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(578, 67);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(309, 24);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(893, 67);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(66, 24);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Search";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Location = new System.Drawing.Point(362, 188);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(507, 554);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(452, 24);
            this.progressBar.TabIndex = 16;
            // 
            // progressSpin
            // 
            this.progressSpin.Location = new System.Drawing.Point(508, 635);
            this.progressSpin.Maximum = 100;
            this.progressSpin.Name = "progressSpin";
            this.progressSpin.Size = new System.Drawing.Size(18, 18);
            this.progressSpin.Speed = 3F;
            this.progressSpin.Spinning = false;
            this.progressSpin.TabIndex = 17;
            this.progressSpin.UseSelectable = true;
            this.progressSpin.Visible = false;
            // 
            // WebExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 750);
            this.Controls.Add(this.progressSpin);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtBoxUrl);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblDownloadSize);
            this.Controls.Add(this.lblDownloadSpeed);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.treeViewList);
            this.Controls.Add(this.progressBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "WebExplorerForm";
            this.Padding = new System.Windows.Forms.Padding(18, 64, 18, 21);
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "WebExplorer";
            this.Load += new System.EventHandler(this.WebExplorerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeViewList;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblDownloadSpeed;
        private System.Windows.Forms.Label lblDownloadSize;
        private System.Windows.Forms.PictureBox pictureBox;
        private MetroFramework.Controls.MetroButton btnList;
        private MetroFramework.Controls.MetroTextBox txtBoxUrl;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroProgressBar progressBar;
        private MetroFramework.Controls.MetroProgressSpinner progressSpin;
    }
}

