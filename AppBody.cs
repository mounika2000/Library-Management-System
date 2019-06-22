using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LibraryManagementSystem
{
    public partial class AppBody : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public AppBody()
        {
            InitializeComponent();
            //initializations for sliding pannel
            isSlidingPanelExpanded = true;
            expandSlidingPanelGUI();
        }

        private void AppBody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            Log_in_Timer.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.25;
            }
            else
            {
                Log_in_Timer.Start();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void expandSlidingPanelGUI()
        {
            BooksTabButton.Text = "BOOKS";
            BorrowersTabButton.Text = "BORROWERS";
            TransactionTabButton.Text = "TRANSACTION";
            SettingButton.Text = "SETTINGS";
            AboutTabButton.Text = "ABOUT";
            SlidingPanel_ToggleButton.Image = Properties.Resources.left2;
            BooksTabButton.Image = null;
            BorrowersTabButton.Image = null;
            TransactionTabButton.Image = null;
            SettingButton.Image = null;
            AboutTabButton.Image = null;

        }
        public void retractSlidingPanelGUI()
        {
            BooksTabButton.Text = "";
            BorrowersTabButton.Text = "";
            TransactionTabButton.Text = "";
            SettingButton.Text = "";
            AboutTabButton.Text = "";
            SlidingPanel_ToggleButton.Image = Properties.Resources.right2;
            BooksTabButton.Image = Properties.Resources.book;
            BorrowersTabButton.Image = Properties.Resources.people;
            TransactionTabButton.Image = Properties.Resources.trans;
            SettingButton.Image = Properties.Resources.set;
            AboutTabButton.Image = Properties.Resources.info;

        }
        //sliding panel toggele button function
        bool isSlidingPanelExpanded;
        const int MaxSliderWidth=200;
        const int MinSliderWidth=69;

        private void SlidingPanel_ToggleButton_Click(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                //restrict panel
                retractSlidingPanelGUI();
            }
            slidingpanneltimer.Start();
        }

        private void slidingpanneltimer_Tick(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                //restrict panel
                SlidingPanel.Width -= 30;
                if (SlidingPanel.Width <= MinSliderWidth)
                {
                    //stop retract
                    isSlidingPanelExpanded = false;
                    slidingpanneltimer.Stop();
                    this.Refresh();
                }

            }
            else
            {
                //expand the panel
                SlidingPanel.Width += 30;
                if (SlidingPanel.Width >= MaxSliderWidth)
                {
                    //stop expanding
                    isSlidingPanelExpanded = true;
                    slidingpanneltimer.Stop();
                    expandSlidingPanelGUI();
                    this.Refresh();
                }
            }
        }


        private void BooksTabButton_Click(object sender, EventArgs e)
        {
            if(!ContentPanel.Controls.Contains(Books_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Books_UserControl.Instance);
                Books_UserControl.Instance.Dock = DockStyle.Fill;
                Books_UserControl.Instance.BringToFront();
            }
            else
            {
                Books_UserControl.Instance.BringToFront();
            }
        }

        private void BorrowersTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Borrowers_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Borrowers_UserControl.Instance);
                Borrowers_UserControl.Instance.Dock = DockStyle.Fill;
                Borrowers_UserControl.Instance.BringToFront();
            }
            else
            {
                Borrowers_UserControl.Instance.BringToFront();
            }
        }

        private void TransactionTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Transactions_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Transactions_UserControl.Instance);
                Transactions_UserControl.Instance.Dock = DockStyle.Fill;
                Transactions_UserControl.Instance.BringToFront();
            }
            else
            {
                Transactions_UserControl.Instance.BringToFront();
            }

        }

       private void SettingButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Settings_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Settings_UserControl.Instance);
                Settings_UserControl.Instance.Dock = DockStyle.Fill;
                Settings_UserControl.Instance.BringToFront();
            }
            else
            {
                Settings_UserControl.Instance.BringToFront();
            }
        }
        
        private void AbortButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(About_UserControl.Instance))
            {
                ContentPanel.Controls.Add(About_UserControl.Instance);
                About_UserControl.Instance.Dock = DockStyle.Fill;
                About_UserControl.Instance.BringToFront();
            }
            else
            {
                About_UserControl.Instance.BringToFront();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SettingButton_Click_1(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Settings_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Settings_UserControl.Instance);
                Settings_UserControl.Instance.Dock = DockStyle.Fill;
                Settings_UserControl.Instance.BringToFront();
            }
            else
            {
                Settings_UserControl.Instance.BringToFront();
            }
        }
    }
}
