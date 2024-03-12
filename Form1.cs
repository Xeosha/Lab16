using FontAwesome.Sharp;
using Guna.UI2.WinForms.Helpers;
using System.Windows.Forms;
using System.Windows.Input;
using System.Runtime.InteropServices;
using System.Reflection.Metadata;

namespace Lab16
{
    public partial class Form1 : Form
    {
        #region Local variables/constants

        bool dragging = false;
        Point dragCursorPoint, dragFormPoint;

        private readonly Color activeBackgroundColor = Color.FromArgb(52, 52, 52);
        private readonly Color activeForegroundColor = Color.FromArgb(134, 200, 103);

        private readonly Color defaultBackgroundColor = Color.FromArgb(46, 46, 50);
        private readonly Color defaultForegroundColor = Color.FromArgb(200, 200, 200);

        private readonly Dictionary<IconButton, Panel> subMenuPanels;

        private Form? activeForm = null;
        private IconButton activeBtn;
        private readonly Panel leftBorderPanel;
        private Panel activeMenu;

        #endregion

        #region Init

        public Form1()
        {
            InitializeComponent();

            subMenuPanels = new();

            activeBtn = CloseBtn;
            leftBorderPanel = greenLabel;
            activeMenu = AddSubMenuPanel;

            Init();

            // убираем верхнюю панель
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void Init()
        {
            InitPanels();
            VisibleMenuFalse();
        }

        private void InitPanels()
        {
            subMenuPanels.Add(AddSubMenuBtn, AddSubMenuPanel);
            subMenuPanels.Add(SaveSubMenuBtn, SaveSubmenuPanel);
        }

        private void VisibleMenuFalse()
        {
            foreach (var item in subMenuPanels.Values)
            {
                item.Visible = false;
            }
        }

        #endregion

        #region Green panel + submenu

        private static void SetButtonColors(IconButton button, Color backColor, Color foreColor)
        {
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.IconColor = foreColor;
        }

        private void ActiveMenu()
        {
            if (subMenuPanels.TryGetValue(activeBtn, out Panel? panel) && !panel.Visible)
            {
                activeMenu.Visible = false;
                activeMenu = panel;
                activeMenu.Visible = true;

            }
            else
            {
                DisableActiveBtn();
                activeMenu.Visible = false;
            }
        }

        private void DisableActiveBtn()
        {
            SetButtonColors(activeBtn, defaultBackgroundColor, defaultForegroundColor);
            leftBorderPanel.Visible = false;
        }

        private void ActiveBtn(object senderBtn, EventArgs e)
        {
            var curBtn = (IconButton)senderBtn;

            if (curBtn != activeBtn || leftBorderPanel.Visible == false)
            {
                DisableActiveBtn();

                activeBtn = curBtn;

                SetButtonColors(activeBtn, activeBackgroundColor, activeForegroundColor);

                activeBtn.Parent?.Controls.Add(leftBorderPanel);

                leftBorderPanel.Visible = true;
                leftBorderPanel.Location = new Point(0, activeBtn.Location.Y);
                leftBorderPanel.BringToFront();

            }
            else
            {
                DisableActiveBtn();
            }
        }

        #endregion

        #region Open/Close Form
        private void OpenForm(Form childForm)
        {
            CloseActiveForm();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelWindow.Controls.Add(childForm);
            PanelWindow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void CloseActiveForm() => activeForm?.Close();
        #endregion

        #region Кнопки справа сверху и передвижение окна
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
            //dragging = true;
            //dragCursorPoint = System.Windows.Forms.Cursor.Position;
            //dragFormPoint = this.Location;
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        [LibraryImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static partial void ReleaseCapture();

        [LibraryImport("user32.dll", EntryPoint = "SendMessage")]
        private static partial void SendMessage(System.IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

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

        #endregion

        #region Нажатие кнопок меню
        private void AddSubMenuBtn_Click(object sender, EventArgs e)
        {
            //ShowInfoBtn((IconButton)sender);

            ActiveBtn(sender, e);

            ActiveMenu();

            CloseActiveForm();
        }

        private void SaveSubMenuBtn_Click(object sender, EventArgs e)
        {
            //ShowInfoBtn((IconButton)sender);

            ActiveBtn(sender, e);

            ActiveMenu();

            CloseActiveForm();

        }

        private void ManuallyBtn_Click(object sender, EventArgs e)
        {
            //ShowInfoBtn((IconButton)sender);

            ActiveBtn(sender, e);

            OpenForm(new AddManuallyForm());
        }

        private void RandomBtn_Click(object sender, EventArgs e)
        {
            //ShowInfoBtn((IconButton)sender);
            ActiveBtn(sender, e);
        }


        private void BinBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);
        }

        private void XmlBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);
        }

        private void JsonBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);
        }

        private void UnloadFileBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);

            ActiveMenu();
        }

        private void RqstBtn1_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);
        }

        private void RqstBtn2_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);
        }

        private void RqstBtn3_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);
        }

        #endregion
    }
}