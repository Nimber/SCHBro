using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebKit;
using System.Runtime.InteropServices;
using System.Web;

namespace SCHBro
{

    public partial class Form1 : Form
    {
        WebKit.WebKitBrowser browser = new WebKitBrowser();
        public Form1()
        {
            
            InitializeComponent();
        }
   
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedIndex = 2;
            //browser.Dock = DockStyle.Fill;
            browser.Top = 45;
            browser.Font = new Font("黑体", browser.Font.Size);
            browser.AllowDownloads = true;
            menuStrip1.Dock = DockStyle.Top;
            this.Controls.Add(browser);
            browser.Navigate("http://www.google.com");
            notifyIcon1.BalloonTipText = "You can click notification icon to directly search in the box with anything in your clipboard.";
            notifyIcon1.BalloonTipTitle = "SCHBro Started";
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            // Automatically paste whatever in the clipboard and sellect them all
            if (Clipboard.GetText() != ""&& Clipboard.GetText()!=toolStripTextBox1.Text)
            {
                toolStripTextBox1.Text = Clipboard.GetText();
                toolStripTextBox1.Focus();
                toolStripTextBox1.SelectAll();
            }
        }
        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (toolStripComboBox1.Text != "")
                {
                    byte[] buffer = Encoding.Default.GetBytes(toolStripTextBox1.Text);
                    switch (toolStripComboBox1.SelectedIndex)
                    {
                        case 0:
                            browser.Navigate("https://scholar.google.com/scholar?hl=en&q=" + System.Web.HttpUtility.UrlEncode(toolStripTextBox1.Text));
                            break;
                        case 1:
                            browser.Navigate("https://en.wikipedia.org/wiki/" + System.Web.HttpUtility.UrlEncode(toolStripTextBox1.Text));
                            break;
                        case 2:
                            browser.Navigate("http://www.google.com/search?&q=" + System.Web.HttpUtility.UrlEncode(toolStripTextBox1.Text));
                            break;
                        case 3:
                            browser.Navigate("https://www.baidu.com/s?wd=" + System.Web.HttpUtility.UrlEncode(toolStripTextBox1.Text));
                            break;
                        case 4:
                            browser.Navigate(System.Web.HttpUtility.UrlEncode(toolStripTextBox1.Text));
                            break;
                    }
                }
                else
                {
                    browser.Navigate("http://www.google.com/");
                }
            }
        }

        private void tOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
        }

        private void gOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text != "")
            {
                byte[] buffer = Encoding.Default.GetBytes(toolStripTextBox1.Text);
                switch (toolStripComboBox1.SelectedIndex)
                {
                    case 0:
                        browser.Navigate("https://scholar.google.com/scholar?hl=en&q=" + System.Web.HttpUtility.UrlEncode(toolStripTextBox1.Text));
                        break;
                    case 1:
                        browser.Navigate("https://en.wikipedia.org/wiki/" + System.Web.HttpUtility.UrlEncode(toolStripTextBox1.Text));
                        break;
                    case 2:
                        browser.Navigate("http://www.google.com/search?&q=" + System.Web.HttpUtility.UrlEncode(toolStripTextBox1.Text));
                        break;
                    case 3:
                        browser.Navigate("https://www.baidu.com/s?wd=" + System.Web.HttpUtility.UrlEncode(toolStripTextBox1.Text));
                        break;
                    case 4:
                        browser.Navigate(System.Web.HttpUtility.UrlEncode(toolStripTextBox1.Text));
                        break;
                }
            }
            else
            {
                browser.Navigate("http://www.google.com/");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            browser.Width = this.Width-30;
            browser.Height = this.Height - 120;
        }
        private void Form1_GotFocus(object sender, EventArgs e)
        {
            
        }

        private void Form1_LostFocus(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_MouseMove(object sender, EventArgs e)
        {
            
        }

        private void DllImport(string v, object p1, object p2)
        {
            throw new NotImplementedException();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void openOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(browser.Url.ToString());
        }

        private void Browser_DownloadBegin(object sender, WebKit.FileDownloadBeginEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
        private void toolStripComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (toolStripComboBox1.Text != "")
                {
                    byte[] buffer = Encoding.Default.GetBytes(toolStripTextBox1.Text);
                    switch (toolStripComboBox1.SelectedIndex)
                    {
                        case 0:
                            browser.Navigate("https://scholar.google.com/scholar?hl=en&q=" + System.Web.HttpUtility.UrlEncode(toolStripTextBox1.Text));
                            break;
                        case 1:
                            browser.Navigate("https://en.wikipedia.org/wiki/" + System.Web.HttpUtility.UrlEncode(toolStripTextBox1.Text));
                            break;
                        case 2:
                            browser.Navigate("http://www.google.com/search?&q=" + System.Web.HttpUtility.UrlEncode(toolStripTextBox1.Text));
                            break;
                        case 3:
                            browser.Navigate("https://www.baidu.com/s?wd=" + System.Web.HttpUtility.UrlEncode(toolStripTextBox1.Text));
                            break;
                        case 4:
                            browser.Navigate(System.Web.HttpUtility.UrlEncode(toolStripTextBox1.Text));
                            break;
                    }
                }
                else
                {
                    browser.Navigate("http://www.google.com/");
                }
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Left = MousePosition.X;
            contextMenuStrip1.Top = MousePosition.Y;
            contextMenuStrip1.Show();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            toolStripTextBox1_Click(null, null);
            gOToolStripMenuItem_Click(null, null);
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clipboardSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBox1_Click(null, null);
            gOToolStripMenuItem_Click(null, null);
        }

        private void clearClickboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }
    }
}
