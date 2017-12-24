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
            this.txtBoxUrl = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.treeViewList = new System.Windows.Forms.TreeView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblDownload = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblDownloadSpeed = new System.Windows.Forms.Label();
            this.lblDownloadSize = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxUrl
            // 
            this.txtBoxUrl.Location = new System.Drawing.Point(3, 4);
            this.txtBoxUrl.Margin = new System.Windows.Forms.Padding(0);
            this.txtBoxUrl.Name = "txtBoxUrl";
            this.txtBoxUrl.Size = new System.Drawing.Size(587, 23);
            this.txtBoxUrl.TabIndex = 1;
            this.txtBoxUrl.Text = "http://bitcore.net/stuff/";
            this.txtBoxUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(592, 3);
            this.btnList.Margin = new System.Windows.Forms.Padding(4);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(66, 25);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // treeViewList
            // 
            this.treeViewList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewList.HideSelection = false;
            this.treeViewList.Location = new System.Drawing.Point(3, 31);
            this.treeViewList.Margin = new System.Windows.Forms.Padding(0);
            this.treeViewList.Name = "treeViewList";
            this.treeViewList.Size = new System.Drawing.Size(587, 639);
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
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(593, 535);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(500, 22);
            this.progressBar.TabIndex = 4;
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Location = new System.Drawing.Point(590, 559);
            this.lblDownload.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(101, 16);
            this.lblDownload.TabIndex = 5;
            this.lblDownload.Text = "labelDownload";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentage.Location = new System.Drawing.Point(828, 538);
            this.lblPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(37, 16);
            this.lblPercentage.TabIndex = 6;
            this.lblPercentage.Text = "50%";
            // 
            // lblDownloadSpeed
            // 
            this.lblDownloadSpeed.AutoSize = true;
            this.lblDownloadSpeed.Location = new System.Drawing.Point(590, 575);
            this.lblDownloadSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDownloadSpeed.Name = "lblDownloadSpeed";
            this.lblDownloadSpeed.Size = new System.Drawing.Size(142, 16);
            this.lblDownloadSpeed.TabIndex = 7;
            this.lblDownloadSpeed.Text = "labelDownloadSpeed";
            // 
            // lblDownloadSize
            // 
            this.lblDownloadSize.AutoSize = true;
            this.lblDownloadSize.Location = new System.Drawing.Point(590, 591);
            this.lblDownloadSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDownloadSize.Name = "lblDownloadSize";
            this.lblDownloadSize.Size = new System.Drawing.Size(128, 16);
            this.lblDownloadSize.TabIndex = 8;
            this.lblDownloadSize.Text = "labelDownloadSize";
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Location = new System.Drawing.Point(660, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(408, 23);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Image = global::WebExplorer.Properties.Resources.search_icon;
            this.btnSearch.Location = new System.Drawing.Point(1070, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(24, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(593, 31);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 500);
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // WebExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 673);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblDownloadSize);
            this.Controls.Add(this.lblDownloadSpeed);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.treeViewList);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtBoxUrl);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WebExplorerForm";
            this.Text = "WebExplorer";
            this.Load += new System.EventHandler(this.WebExplorerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxUrl;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TreeView treeViewList;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblDownloadSpeed;
        private System.Windows.Forms.Label lblDownloadSize;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}

