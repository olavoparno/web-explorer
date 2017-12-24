using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;

namespace WebExplorer
{
    public partial class WebExplorerForm : Form
    {
        Font boldFont;
        Font normalFont;
        List<TreeNode> selectedNodes;
        TreeNode previousNode;

        public string curDirDown = "";
        public string curDirUp = "";

        public WebExplorerForm()
        {
            InitializeComponent();

            selectedNodes = new List<TreeNode>();
            boldFont = new Font("Arial", 8, FontStyle.Underline);
            normalFont = new Font("Arial", 8, FontStyle.Regular);
        }

        public static string GetDirectoryListingRegexForUrl(string url)
        {
            return "<a href=\".*\">(?<name>.*)</a>";
        }
        
        private string RemoveLastSlash(string value)
        {
            int lastSlash = value.LastIndexOf("/");
            string str = (lastSlash > -1) ? value.Substring(0, lastSlash) : value;

            return str;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            string url = RemoveLastSlash(txtBoxUrl.Text).Trim();
            // The variable that will be holding the url address (making sure it starts with http://)
            Uri urlFormated = url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ? new Uri(url) : new Uri("http://" + url);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlFormated);
            addedNodesSearch.Clear();
            removedNodesSearch.Clear();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    txtBoxUrl.Text = response.ResponseUri.AbsoluteUri;

                    string html = reader.ReadToEnd();
                    Regex regex = new Regex(GetDirectoryListingRegexForUrl(url));
                    MatchCollection matches = regex.Matches(html);
                    if (matches.Count > 0)
                    {
                        btnSearch.Enabled = true;
                        txtSearch.Enabled = true;
                        treeViewList.Nodes.Clear();
                        treeViewList.ImageList = imageList;
                        foreach (Match match in matches)
                        {
                            if (match.Success)
                            {
                                curDirUp = url;
                                curDirDown = url;

                                TreeNode treeNodeDummy = new TreeNode()
                                {
                                    Name = "Dummy",
                                };

                                TreeNode treeNode = new TreeNode()
                                {
                                    Name = match.Value.ToString().TrimStart(),
                                    Text = match.Groups["name"].Value.ToString().TrimStart()
                                };

                                //imageList.Images.Add(treeNode.Text, IconFromFilePath(textBox1.Text + treeNode.Text).ToBitmap());
                                //imageList.Images.Add(treeNode.Text, IconFromFilePath(treeNode.Text).ToBitmap());
                                //treeNode.ImageKey = treeNode.Text;
                                try
                                {
                                    if (System.IO.Path.HasExtension(treeNode.Text))
                                    {
                                        treeNode.NodeFont = normalFont;
                                        treeNode.Tag = "file";

                                        switch (treeNode.Text.ToLower())
                                        {
                                            case string a when a.EndsWith(".exe"):
                                                treeNode.ImageIndex = imageList.Images.IndexOfKey("binary.gif");
                                                break;
                                            case string a when (a.EndsWith(".jpg") || a.EndsWith(".jpeg") || a.EndsWith(".gif") || a.EndsWith(".png") || a.EndsWith(".bmp") || a.EndsWith(".tiff")):
                                                treeNode.ImageIndex = imageList.Images.IndexOfKey("image.gif");
                                                break;
                                            case string a when (a.EndsWith(".txt") || a.EndsWith(".text") || a.EndsWith(".xml")):
                                                treeNode.ImageIndex = imageList.Images.IndexOfKey("text.gif");
                                                break;
                                            case string a when (a.EndsWith(".mp4") || a.EndsWith(".mov") || a.EndsWith(".avi") || a.EndsWith(".mpeg") || a.EndsWith(".xvid") || a.EndsWith(".wmv") || a.EndsWith(".3gp")):
                                                treeNode.ImageIndex = imageList.Images.IndexOfKey("movie.gif");
                                                break;
                                            case string a when (a.EndsWith(".mp3") || a.EndsWith(".flac") || a.EndsWith(".m4a") || a.EndsWith(".aac") || a.EndsWith(".wma") || a.EndsWith(".wav") || a.EndsWith(".3gp")):
                                                treeNode.ImageIndex = imageList.Images.IndexOfKey("sound.gif");
                                                break;
                                            case string a when a.EndsWith(".pdf"):
                                                treeNode.ImageIndex = imageList.Images.IndexOfKey("layout.gif");
                                                break;
                                            default:
                                                treeNode.ImageIndex = imageList.Images.IndexOfKey("unknown.gif");
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        treeNode.NodeFont = boldFont;
                                        treeNode.Tag = "folder";
                                        treeNode.ImageIndex = imageList.Images.IndexOfKey("folder.gif");
                                        treeNode.Nodes.Add(treeNodeDummy);
                                    }
                                }
                                catch (Exception)
                                {
                                    treeNode.NodeFont = boldFont;
                                    treeNode.Tag = "folder";
                                    treeNode.Nodes.Add(treeNodeDummy);
                                }
                                
                                treeViewList.Nodes.Add(treeNode);
                            }
                            else
                            {
                                MessageBox.Show("An error has ocurred.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    response.Close();
                }
                response.Close();
            }
        
        }

        private void treeViewList_AfterExpand(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Nodes.Find("Dummy", false).FirstOrDefault().Name == "Dummy")
                {
                    e.Node.Nodes.Find("Dummy", false).FirstOrDefault().Remove();
                }

                if (e.Node.Tag.ToString() == "folder" && e.Node.Text != "Parent Directory")
                {
                    curDirDown = curDirDown + "/" + e.Node.Text;

                    txtBoxUrl.Text = curDirDown;
                    btnList_Click(sender, e);
                }
                else if (e.Node.Tag.ToString() == "folder" && e.Node.Text == "Parent Directory")
                {
                    curDirUp = curDirUp + "/../";

                    txtBoxUrl.Text = curDirUp;
                    btnList_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void treeViewList_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            // cancel selection, the selection will be handled in MouseDown
            e.Cancel = true;
        }

        private void treeViewList_MouseDown(object sender, MouseEventArgs e)
        {
            TreeNode currentNode = treeViewList.GetNodeAt(e.Location);

            if (currentNode == null) return;
            
            bool control = (ModifierKeys == Keys.Control);
            bool shift = (ModifierKeys == Keys.Shift);

            if (control)
            {
                // the node clicked with control button pressed:
                // invert selection of the current node
                List<TreeNode> addedNodes = new List<TreeNode>();
                List<TreeNode> removedNodes = new List<TreeNode>();
                if (!selectedNodes.Contains(currentNode))
                {
                    addedNodes.Add(currentNode);
                    previousNode = currentNode;
                }
                else
                {
                    removedNodes.Add(currentNode);
                }
                changeSelection(addedNodes, removedNodes);
            }
            else if (shift && previousNode != null)
            {
                if (currentNode.Parent == previousNode.Parent)
                {
                    // the node clicked with shift button pressed:
                    // if current node and previously selected node
                    // belongs to the same parent,
                    // select range of nodes between these two
                    List<TreeNode> addedNodes = new List<TreeNode>();
                    List<TreeNode> removedNodes = new List<TreeNode>();
                    bool selection = false;
                    bool selectionEnd = false;

                    TreeNodeCollection nodes = null;

                    if (previousNode.Parent == null)
                    {
                        nodes = treeViewList.Nodes;
                    }
                    else
                    {
                        nodes = previousNode.Parent.Nodes;
                    }

                    foreach (TreeNode n in nodes)
                    {
                        if (n == currentNode || n == previousNode)
                        {
                            if (selection)
                            {
                                selectionEnd = true;
                            }
                            if (!selection)
                            {
                                selection = true;
                            }
                        }
                        if (selection && !selectedNodes.Contains(n))
                        {
                            addedNodes.Add(n);
                        }
                        if (selectionEnd)
                        {
                            break;
                        }
                    }

                    if (addedNodes.Count > 0)
                    {
                        changeSelection(addedNodes, removedNodes);
                    }
                }
            }
            else
            {
                if (!currentNode.NodeFont.Bold && e.Button == MouseButtons.Left)
                {
                    // single click:
                    // remove all selected nodes
                    // and add current node
                    List<TreeNode> addedNodes = new List<TreeNode>();
                    List<TreeNode> removedNodes = new List<TreeNode>();
                    removedNodes.AddRange(selectedNodes);
                    if (removedNodes.Contains(currentNode))
                    {
                        removedNodes.Remove(currentNode);
                    }
                    else
                    {
                        addedNodes.Add(currentNode);
                    }
                    changeSelection(addedNodes, removedNodes);
                    previousNode = currentNode;
                }
                else if (e.Button == MouseButtons.Right && currentNode.Tag.ToString() != "folder")
                {
                    if (selectedNodes.Count <= 1)
                    {
                        currentNode = treeViewList.GetNodeAt(e.Location);
                    }

                    treeViewList.SelectedNode = currentNode;

                    ContextMenu context = new ContextMenu();
                    MenuItem menuItem = new MenuItem();
                    Point position = new Point(e.X, e.Y + 10);

                    menuItem.Name = "";
                    menuItem.Text = "Download";
                    menuItem.Tag = selectedNodes;
                    menuItem.Click += MenuItem_Click;

                    context.MenuItems.Add(menuItem);
                    context.Show(treeViewList, position);
                }
                else
                {
                    currentNode.TreeView.SelectedNode = currentNode;
                }
            }

            

            if (e.Button == MouseButtons.Left && e.Clicks > 1)
            {
                string itemUrl = txtBoxUrl.Text + currentNode.Text.TrimStart();

                try
                {
                    if (itemUrl.ToUpper().Contains(".JPG")
                     || itemUrl.ToUpper().Contains(".JPEG")
                     || itemUrl.ToUpper().Contains(".BMP")
                     || itemUrl.ToUpper().Contains(".PNG")
                     || itemUrl.ToUpper().Contains(".TIFF")
                     || itemUrl.ToUpper().Contains(".GIF"))
                    {
                        LoadPicture(itemUrl);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void LoadPicture(string url)
        {
            pictureBox.Image = null;
            pictureBox.Tag = url;

            Thread newThread = new Thread(() => {
                try
                {
                    pictureBox.Load(url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while exhibiting PictureBox: \n" + ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            });

        newThread.Start();
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            List<TreeNode> nodeSelection = (List<TreeNode>)menuItem.Tag;

            saveFileDialog.Title = "Choose your path";

            if (nodeSelection.Count == 1)
            {
                saveFileDialog.FileName = nodeSelection[0].Text;
                saveFileDialog.Filter = "All files (*.*)|*.*|MP3 Audio (.mp3)|*.mp3|Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf|Text file (.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DownloadFile(txtBoxUrl.Text + nodeSelection[0].Text, saveFileDialog.FileName);
                }
            }
            else if (nodeSelection.Count > 1)
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    int endCount = 0;
                    foreach (TreeNode item in nodeSelection)
                    {
                        endCount++;
                        DownloadFile(txtBoxUrl.Text + item.Text, folderBrowserDialog.SelectedPath + "\\" + item.Text);
                    }
                }
            }
        }

        WebClient webClient;               // Our WebClient that will be doing the downloading for us
        Stopwatch sw = new Stopwatch();    // The stopwatch which we will be using to calculate the download speed

        public void DownloadFile(string urlAddress, string location)
        {
            using (webClient = new WebClient())
            {
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                // The variable that will be holding the url address (making sure it starts with http://)
                Uri URL = urlAddress.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ? new Uri(urlAddress) : new Uri("http://" + urlAddress);

                // Start the stopwatch which we will be using to calculate the download speed
                sw.Start();

                try
                {
                    // Start downloading the file
                    webClient.DownloadFileAsync(URL, location);
                    lblDownload.Text = "Downloading file: " + urlAddress;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            // Reset the stopwatch.
            sw.Reset();

            if (e.Cancelled == true)
            {
                MessageBox.Show("Download cancelled!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //MessageBox.Show("Download complete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            lblPercentage.Text = "";
            lblDownloadSize.Text = "";
            lblDownloadSpeed.Text = "";
            lblDownload.Text = "";
            progressBar.Value = 0;
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Calculate download speed and output it to labelSpeed.
            lblDownloadSpeed.Text = string.Format("{0} KB/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));

            // Update the progressbar percentage only when the value is not the same.
            progressBar.Value = e.ProgressPercentage;

            // Show the percentage on our label.
            lblPercentage.Text = e.ProgressPercentage.ToString() + "%";

            // Update the label with how much data have been downloaded so far and the total size of the file we are currently downloading
            lblDownloadSize.Text = string.Format("{0} MB / {1} MB",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
        }
        
        protected void changeSelection(List<TreeNode> addedNodes, List<TreeNode> removedNodes)
        {
            foreach (TreeNode n in addedNodes)
            {
                if (!n.NodeFont.Bold)
                {
                    n.BackColor = SystemColors.Highlight;
                    n.ForeColor = SystemColors.HighlightText;
                    selectedNodes.Add(n);
                }
            }
            foreach (TreeNode n in removedNodes)
            {
                n.BackColor = treeViewList.BackColor;
                n.ForeColor = treeViewList.ForeColor;
                selectedNodes.Remove(n);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnList_Click(sender, e);
            }
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && pictureBox.Tag != null)
            {
                ContextMenu context = new ContextMenu();
                MenuItem menuItem = new MenuItem();
                Point position = new Point(e.X, e.Y + 10);

                menuItem.Name = "";
                menuItem.Text = "Download";
                
                menuItem.Click += MenuItem_Click_PictureBox;

                context.MenuItems.Add(menuItem);
                context.Show(pictureBox, position);
            }
        }

        private void MenuItem_Click_PictureBox(object sender, EventArgs e)
        {
            saveFileDialog.FileName = pictureBox.Tag.ToString().Replace(txtBoxUrl.Text, "");
            saveFileDialog.Filter = "All files (*.*)|*.*|MP3 Audio (.mp3)|*.mp3|Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf|Text file (.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DownloadFile(pictureBox.Tag.ToString(), saveFileDialog.FileName);
            }
        }

        private void WebExplorerForm_Load(object sender, EventArgs e)
        {
            lblDownload.Text = "";
            lblDownloadSize.Text = "";
            lblDownloadSpeed.Text = "";
            lblPercentage.Text = "";
        }

        List<TreeNode> addedNodesSearch = new List<TreeNode>();
        List<TreeNode> removedNodesSearch = new List<TreeNode>();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (treeViewList.Nodes.Count > 0 && txtSearch.Text.Length > 2)
            {
                string txtCheck = txtSearch.Text;

                foreach (TreeNode item in treeViewList.Nodes)
                {
                    if (item.Text.ToLower().Contains(txtCheck.ToLower()))
                    {
                        addedNodesSearch.Add(item);
                    }
                    else
                    {
                        removedNodesSearch.Add(item);
                    }
                }

                if (addedNodesSearch.Count > 0)
                {
                    changeSelection(addedNodesSearch, removedNodesSearch);

                    foreach (TreeNode item in removedNodesSearch)
                    {
                        treeViewList.Nodes.Remove(item);
                    }
                }
                else
                {
                    MessageBox.Show("No ocurrence found.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please write at least 3 characters for best results.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
            {
                if (addedNodesSearch.Count > 0 && removedNodesSearch.Count > 0)
                {
                    treeViewList.Nodes.Clear();

                    foreach (TreeNode itemRem in removedNodesSearch)
                    {
                        treeViewList.Nodes.Add(itemRem);
                    }

                    foreach (TreeNode itemAdd in addedNodesSearch)
                    {
                        treeViewList.Nodes.Add(itemAdd);
                    }

                    changeSelection(new List<TreeNode>(), addedNodesSearch);
                }
            }
        }
    }
}
