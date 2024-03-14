using FontAwesome.Sharp;
using Guna.UI2.WinForms.Helpers;
using System.Windows.Forms;
using System.Windows.Input;
using System.Runtime.InteropServices;
using System.Reflection.Metadata;
using Lab_10lib;
using Lab16.CustomControl;
using EventBinaryTree;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using Lab16.Serialization;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using BinarySearchTree;
using Lab16.Methods;

namespace Lab16
{
    public partial class MainForm : Form
    {
        #region Local variables/constants

        bool dragging = false;
        Point dragCursorPoint, dragFormPoint;


        private readonly Color activeBackgroundColor = Color.FromArgb(52, 52, 52);
        private readonly Color activeForegroundColor = Color.FromArgb(134, 200, 103);

        private readonly Color defaultBackgroundColor = Color.FromArgb(46, 46, 50);
        private readonly Color defaultForegroundColor = Color.FromArgb(200, 200, 200);

        private Form? activeForm = null;
        private IconButton activeBtn;
        private readonly Panel leftBorderPanel;
        private Panel activeMenu;

        public BinaryTreeEvent<Goods> binaryTree;


        #endregion

        #region Init

        public MainForm()
        {
            InitializeComponent();

            binaryTree = new();
            binaryTree.CollectionChange += CollectionChange;

            binaryTree.Clear();

            activeBtn = AddSubMenuBtn;
            leftBorderPanel = greenLabel;
            activeMenu = AddSubMenuPanel;

            Init();
        }

        private void Init()
        {
            // убираем верхнюю панель
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        #endregion

        // Метод для ивента изменения коллекции
        private void CollectionChange(object? sender, EventArgs e)
            => UpdateTextLabelTree(binaryTree.ToString());

        // Обновление текста снизу
        private void UpdateTextLabelTree(string message)
        {
            BinaryTreeText.Text = message;
        }

        #region Controls

        #region GreenPanel + SubMenu

        private static void SetButtonColors(IconButton button, Color backColor, Color foreColor)
        {
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.IconColor = foreColor;
        }

        private void ActiveMenu()
        {
            var btn = (IconMenuButton)activeBtn;

            if (btn.Label != null && !btn.Label.Visible)
            {
                activeMenu.Visible = false;
                activeMenu = btn.Label;
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

            if (curBtn != null)
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

        #endregion

        #region Click Buttons

        #region SubMenu
        private void AddSubMenuBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);

            ActiveMenu();

            CloseActiveForm();
        }

        private void SaveSubMenuBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);

            ActiveMenu();

            CloseActiveForm();
        }

        private void UnloadFileBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);

            ActiveMenu();

            CloseActiveForm();
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);

            ActiveMenu();

            CloseActiveForm();
        }
        #endregion

        #region Top Right Buttons and Window Movement
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


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

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

        #region Add/Change/Remove

        private void ManuallyBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);

            OpenForm(new AddManuallyForm(this, ActionType.Add, "Добавление товара"));
        }


        private void RandomBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);

            CloseActiveForm();

            binaryTree.Clear();
            binaryTree.Add(Requests.CreateRandomProductArray(new ProductNameComparer()));
            UpdateTextLabelTree(binaryTree.ToString());

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);

            OpenForm(new AddManuallyForm(this, ActionType.Delete, "Удаление товара"));

        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);

            OpenForm(new AddManuallyForm(this, ActionType.Modify, "Изменение атрибутов товара"));
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);

            CloseActiveForm();

            binaryTree.Clear();
        }

        #endregion

        #region Requests
        private void RqstBtn1_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);

            UpdateTextLabelTree(Requests.GetTextFilterByProducts(binaryTree));

            CloseActiveForm();
        }

        private void RqstBtn2_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);

            UpdateTextLabelTree(Requests.GetTextFilterByMilkProducts(binaryTree));

            CloseActiveForm();
        }

        private void RqstBtn3_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);

            UpdateTextLabelTree(Requests.GetTextFilterByToys(binaryTree));

            CloseActiveForm();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);

            var res = Requests.GetTextSortTree(binaryTree);

            if (BinaryTreeText.Text != binaryTree.ToString())
                UpdateTextLabelTree(binaryTree.ToString());
            else
                UpdateTextLabelTree(res);
        }


        #endregion

        #region Save/Load
        private void BinBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);

            binaryTree.SaveDialog(new BinSerializator<List<Goods>>());

        }

        private void XmlBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);

            binaryTree.SaveDialog(new XMLSerializator<List<Goods>>());
        }

        private void JsonBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);

            binaryTree.SaveDialog(new JSONSerializator<List<Goods>>());
        }

        private void XMLoadBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);

            CloseActiveForm();

            binaryTree.LoadDialog(new XMLSerializator<List<Goods>>());
        }

        private void JSONLoadBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);

            CloseActiveForm();

            binaryTree.LoadDialog(new JSONSerializator<List<Goods>>());
        }

        private void BinLoadBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, e);

            CloseActiveForm();

            binaryTree.LoadDialog(new BinSerializator<List<Goods>>());
        }

        #endregion

        #endregion
    }
}