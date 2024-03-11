using FontAwesome.Sharp;
using Guna.UI2.WinForms.Helpers;
using System.Windows.Forms;
using System.Windows.Input;

namespace Lab16
{
    public partial class Form1 : Form
    {
        bool dragging = false;
        Point dragCursorPoint, dragFormPoint;

        private readonly Color activeBackgroundColor = Color.FromArgb(52, 52, 52);
        private readonly Color activeForegroundColor = Color.FromArgb(134, 200, 103);

        private readonly Color defaultBackgroundColor = Color.FromArgb(46, 46, 50);
        private readonly Color defaultForegroundColor = Color.FromArgb(200, 200, 200);

        private readonly Dictionary<IconButton, Panel> iconButtons;
        private readonly Dictionary<IconButton, Panel> subMenuPanels;



        public Form1()
        {
            InitializeComponent();
            iconButtons = new();
            subMenuPanels = new();
            Init();
        }

        private void Init()
        {
            InitButtons();
            InitPanels();
            CustomDezing();
        }

        private void InitButtons()
        {
            iconButtons.Add(SaveSubMenuBtn, green1);
            iconButtons.Add(BinBtn, green2);
            iconButtons.Add(XmlBtn, green3);
            iconButtons.Add(JsonBtn, green4);
            iconButtons.Add(AddSubMenuBtn, green5);
            iconButtons.Add(ManuallyBtn, green6);
            iconButtons.Add(RandomBtn, green7);

        }

        private void InitPanels()
        {
            subMenuPanels.Add(AddSubMenuBtn, AddSubMenuPanel);
            subMenuPanels.Add(SaveSubMenuBtn, SaveSubmenuPanel);
        }


        private void CustomDezing()
        {
            foreach (var item in subMenuPanels.Values)
            {
                item.Visible = false;
            }

            foreach (var key in iconButtons.Keys)
            {
                SetActiveBtn(key, false);
            }
        }

        private void ShowGreenPanel(IconButton btn)
        {

            foreach (var key in iconButtons.Keys)
            {
                SetActiveBtn(key, key == btn);
            }
        }

        private void SetActiveBtn(IconButton btn, bool flag)
        {
            var panel = iconButtons[btn];

            subMenuPanels.TryGetValue(btn, out Panel? panel2);

            if (flag && panel.Visible == false && panel2?.Visible != false)
            {
                SetButtonColors(btn, activeBackgroundColor, activeForegroundColor);
                panel.Visible = true;
            }
            else
            {
                SetButtonColors(btn, defaultBackgroundColor, defaultForegroundColor);
                panel.Visible = false;
            }
        }

        private void ShowSubMenu(Panel panel)
        {
            foreach (var item in subMenuPanels.Values)
            {
                if (item == panel && item.Visible == false)
                    item.Visible = true;
                else
                    item.Visible = false;
            }
        }

        private void ShowInfoBtn(IconButton btn)
        {
            if (subMenuPanels.TryGetValue(btn, out Panel? panel))
            {
                ShowSubMenu(panel);
            }


            ShowGreenPanel(btn);
        }

        private static void SetButtonColors(IconButton button, Color backColor, Color foreColor)
        {
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.IconColor = foreColor;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void WindowRestoreBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void WindowMinimazeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AddSubMenuBtn_Click(object sender, EventArgs e)
        {
            ShowInfoBtn((IconButton)sender);
        }

        private void SaveSubMenuBtn_Click(object sender, EventArgs e)
        {
            ShowInfoBtn((IconButton)sender);

        }

        private void ManuallyBtn_Click(object sender, EventArgs e)
        {
            ShowInfoBtn((IconButton)sender);
        }

        private void RandomBtn_Click(object sender, EventArgs e)
        {
            ShowInfoBtn((IconButton)sender);
        }

        private void HeaderPanel_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            dragging = false;
        }

        private void HeaderPanel_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (dragging)
            {
                var dif = Point.Subtract(System.Windows.Forms.Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void HeaderPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = System.Windows.Forms.Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void HeaderPanel_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void BinBtn_Click(object sender, EventArgs e)
        {
            ShowInfoBtn((IconButton)sender);
        }

        private void XmlBtn_Click(object sender, EventArgs e)
        {
            ShowInfoBtn((IconButton)sender);
        }

        private void JsonBtn_Click(object sender, EventArgs e)
        {
            ShowInfoBtn((IconButton)sender);
        }
    }
}