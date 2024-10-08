﻿using Lab16.CustomControl;

namespace Lab16
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            HeaderPanel = new Panel();
            pictureBox1 = new PictureBox();
            WindowMinimazeBtn = new FontAwesome.Sharp.IconButton();
            WindowRestoreBtn = new FontAwesome.Sharp.IconButton();
            CloseBtn = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            MenuPanel = new Panel();
            RequestSubMenuPanel = new Panel();
            panel9 = new Panel();
            RqstBtn3 = new IconMenuButton();
            panel10 = new Panel();
            RqstBtn2 = new IconMenuButton();
            panel12 = new Panel();
            RqstBtn1 = new IconMenuButton();
            panel7 = new Panel();
            RequestBtn = new IconMenuButton();
            panel3 = new Panel();
            ShowBtn = new IconMenuButton();
            UnloadMenuPanel = new Panel();
            panel15 = new Panel();
            JSONLoadBtn = new IconMenuButton();
            panel17 = new Panel();
            XMLoadBtn = new IconMenuButton();
            panel18 = new Panel();
            BinLoadBtn = new IconMenuButton();
            panel5 = new Panel();
            UnloadFileBtn = new IconMenuButton();
            SaveSubmenuPanel = new Panel();
            panel14 = new Panel();
            JsonBtn = new IconMenuButton();
            panel22 = new Panel();
            XmlBtn = new IconMenuButton();
            panel16 = new Panel();
            BinBtn = new IconMenuButton();
            SavePanel = new Panel();
            SaveSubMenuBtn = new IconMenuButton();
            panel8 = new Panel();
            ClearBtn = new IconMenuButton();
            panel2 = new Panel();
            ChangeBtn = new IconMenuButton();
            panel1 = new Panel();
            DeleteBtn = new IconMenuButton();
            AddSubMenuPanel = new Panel();
            panel11 = new Panel();
            RandomBtn = new IconMenuButton();
            panel6 = new Panel();
            ManuallyBtn = new IconMenuButton();
            AddPanel = new Panel();
            AddSubMenuBtn = new IconMenuButton();
            greenLabel = new Panel();
            PanelLogo = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            PanelWindow = new Panel();
            panel4 = new Panel();
            BinaryTreeText = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MenuPanel.SuspendLayout();
            RequestSubMenuPanel.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel12.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            UnloadMenuPanel.SuspendLayout();
            panel15.SuspendLayout();
            panel17.SuspendLayout();
            panel18.SuspendLayout();
            panel5.SuspendLayout();
            SaveSubmenuPanel.SuspendLayout();
            panel14.SuspendLayout();
            panel22.SuspendLayout();
            panel16.SuspendLayout();
            SavePanel.SuspendLayout();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            AddSubMenuPanel.SuspendLayout();
            panel11.SuspendLayout();
            panel6.SuspendLayout();
            AddPanel.SuspendLayout();
            PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PanelWindow.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = Color.FromArgb(46, 46, 50);
            HeaderPanel.Controls.Add(pictureBox1);
            HeaderPanel.Controls.Add(WindowMinimazeBtn);
            HeaderPanel.Controls.Add(WindowRestoreBtn);
            HeaderPanel.Controls.Add(CloseBtn);
            HeaderPanel.Controls.Add(label1);
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.Location = new Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(1215, 40);
            HeaderPanel.TabIndex = 0;
            HeaderPanel.MouseDoubleClick += HeaderPanel_MouseDoubleClick;
            HeaderPanel.MouseDown += HeaderPanel_MouseDown;
            HeaderPanel.MouseMove += HeaderPanel_MouseMove;
            HeaderPanel.MouseUp += HeaderPanel_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // WindowMinimazeBtn
            // 
            WindowMinimazeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            WindowMinimazeBtn.BackColor = Color.FromArgb(46, 46, 50);
            WindowMinimazeBtn.Cursor = Cursors.Hand;
            WindowMinimazeBtn.FlatAppearance.BorderSize = 0;
            WindowMinimazeBtn.FlatStyle = FlatStyle.Flat;
            WindowMinimazeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            WindowMinimazeBtn.IconColor = SystemColors.ScrollBar;
            WindowMinimazeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            WindowMinimazeBtn.IconSize = 36;
            WindowMinimazeBtn.Location = new Point(1105, 6);
            WindowMinimazeBtn.Name = "WindowMinimazeBtn";
            WindowMinimazeBtn.Size = new Size(34, 34);
            WindowMinimazeBtn.TabIndex = 4;
            WindowMinimazeBtn.UseVisualStyleBackColor = false;
            WindowMinimazeBtn.Click += WindowMinimazeBtn_Click;
            // 
            // WindowRestoreBtn
            // 
            WindowRestoreBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            WindowRestoreBtn.BackColor = Color.FromArgb(46, 46, 50);
            WindowRestoreBtn.Cursor = Cursors.Hand;
            WindowRestoreBtn.FlatAppearance.BorderSize = 0;
            WindowRestoreBtn.FlatStyle = FlatStyle.Flat;
            WindowRestoreBtn.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            WindowRestoreBtn.IconColor = SystemColors.ScrollBar;
            WindowRestoreBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            WindowRestoreBtn.IconSize = 36;
            WindowRestoreBtn.Location = new Point(1135, 6);
            WindowRestoreBtn.Name = "WindowRestoreBtn";
            WindowRestoreBtn.Size = new Size(34, 34);
            WindowRestoreBtn.TabIndex = 3;
            WindowRestoreBtn.UseVisualStyleBackColor = false;
            WindowRestoreBtn.Click += WindowRestoreBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseBtn.BackColor = Color.FromArgb(46, 46, 50);
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.FlatAppearance.BorderSize = 0;
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            CloseBtn.IconColor = SystemColors.ScrollBar;
            CloseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CloseBtn.IconSize = 36;
            CloseBtn.Location = new Point(1166, 6);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(34, 34);
            CloseBtn.TabIndex = 2;
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ScrollBar;
            label1.Location = new Point(77, 9);
            label1.Name = "label1";
            label1.Size = new Size(321, 21);
            label1.TabIndex = 2;
            label1.Text = "ЛАБОРАТОРНАЯ 16 | РАБОТА С ФАЙЛАМИ";
            // 
            // MenuPanel
            // 
            MenuPanel.AutoScroll = true;
            MenuPanel.BackColor = Color.FromArgb(46, 46, 50);
            MenuPanel.Controls.Add(RequestSubMenuPanel);
            MenuPanel.Controls.Add(panel7);
            MenuPanel.Controls.Add(panel3);
            MenuPanel.Controls.Add(UnloadMenuPanel);
            MenuPanel.Controls.Add(panel5);
            MenuPanel.Controls.Add(SaveSubmenuPanel);
            MenuPanel.Controls.Add(SavePanel);
            MenuPanel.Controls.Add(panel8);
            MenuPanel.Controls.Add(panel2);
            MenuPanel.Controls.Add(panel1);
            MenuPanel.Controls.Add(AddSubMenuPanel);
            MenuPanel.Controls.Add(AddPanel);
            MenuPanel.Controls.Add(PanelLogo);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(248, 622);
            MenuPanel.TabIndex = 4;
            // 
            // RequestSubMenuPanel
            // 
            RequestSubMenuPanel.Controls.Add(panel9);
            RequestSubMenuPanel.Controls.Add(panel10);
            RequestSubMenuPanel.Controls.Add(panel12);
            RequestSubMenuPanel.Dock = DockStyle.Top;
            RequestSubMenuPanel.Location = new Point(0, 813);
            RequestSubMenuPanel.Name = "RequestSubMenuPanel";
            RequestSubMenuPanel.Size = new Size(231, 129);
            RequestSubMenuPanel.TabIndex = 6;
            RequestSubMenuPanel.Visible = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(RqstBtn3);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 86);
            panel9.Name = "panel9";
            panel9.Size = new Size(231, 43);
            panel9.TabIndex = 4;
            // 
            // RqstBtn3
            // 
            RqstBtn3.Dock = DockStyle.Fill;
            RqstBtn3.FlatAppearance.BorderSize = 0;
            RqstBtn3.FlatStyle = FlatStyle.Flat;
            RqstBtn3.ForeColor = SystemColors.ScrollBar;
            RqstBtn3.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            RqstBtn3.IconColor = SystemColors.ScrollBar;
            RqstBtn3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            RqstBtn3.ImageAlign = ContentAlignment.MiddleLeft;
            RqstBtn3.Label = null;
            RqstBtn3.Location = new Point(0, 0);
            RqstBtn3.Name = "RqstBtn3";
            RqstBtn3.Padding = new Padding(20, 0, 0, 0);
            RqstBtn3.Size = new Size(231, 43);
            RqstBtn3.TabIndex = 1;
            RqstBtn3.Text = "                           Запрос3";
            RqstBtn3.TextAlign = ContentAlignment.MiddleLeft;
            RqstBtn3.UseVisualStyleBackColor = true;
            RqstBtn3.Click += RqstBtn3_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(RqstBtn2);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 43);
            panel10.Name = "panel10";
            panel10.Size = new Size(231, 43);
            panel10.TabIndex = 5;
            // 
            // RqstBtn2
            // 
            RqstBtn2.Dock = DockStyle.Fill;
            RqstBtn2.FlatAppearance.BorderSize = 0;
            RqstBtn2.FlatStyle = FlatStyle.Flat;
            RqstBtn2.ForeColor = SystemColors.ScrollBar;
            RqstBtn2.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            RqstBtn2.IconColor = SystemColors.ScrollBar;
            RqstBtn2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            RqstBtn2.ImageAlign = ContentAlignment.MiddleLeft;
            RqstBtn2.Label = null;
            RqstBtn2.Location = new Point(0, 0);
            RqstBtn2.Name = "RqstBtn2";
            RqstBtn2.Padding = new Padding(20, 0, 0, 0);
            RqstBtn2.Size = new Size(231, 43);
            RqstBtn2.TabIndex = 1;
            RqstBtn2.Text = "                           Запрос2";
            RqstBtn2.TextAlign = ContentAlignment.MiddleLeft;
            RqstBtn2.UseVisualStyleBackColor = true;
            RqstBtn2.Click += RqstBtn2_Click;
            // 
            // panel12
            // 
            panel12.Controls.Add(RqstBtn1);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(231, 43);
            panel12.TabIndex = 2;
            // 
            // RqstBtn1
            // 
            RqstBtn1.Dock = DockStyle.Fill;
            RqstBtn1.FlatAppearance.BorderSize = 0;
            RqstBtn1.FlatStyle = FlatStyle.Flat;
            RqstBtn1.ForeColor = SystemColors.ScrollBar;
            RqstBtn1.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            RqstBtn1.IconColor = SystemColors.ScrollBar;
            RqstBtn1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            RqstBtn1.ImageAlign = ContentAlignment.MiddleLeft;
            RqstBtn1.Label = null;
            RqstBtn1.Location = new Point(0, 0);
            RqstBtn1.Name = "RqstBtn1";
            RqstBtn1.Padding = new Padding(20, 0, 0, 0);
            RqstBtn1.Size = new Size(231, 43);
            RqstBtn1.TabIndex = 1;
            RqstBtn1.Text = "                           Запрос1";
            RqstBtn1.TextAlign = ContentAlignment.MiddleLeft;
            RqstBtn1.UseVisualStyleBackColor = true;
            RqstBtn1.Click += RqstBtn1_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(RequestBtn);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 770);
            panel7.Name = "panel7";
            panel7.Size = new Size(231, 43);
            panel7.TabIndex = 2;
            // 
            // RequestBtn
            // 
            RequestBtn.Dock = DockStyle.Fill;
            RequestBtn.FlatAppearance.BorderSize = 0;
            RequestBtn.FlatStyle = FlatStyle.Flat;
            RequestBtn.ForeColor = SystemColors.ScrollBar;
            RequestBtn.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            RequestBtn.IconColor = SystemColors.ScrollBar;
            RequestBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            RequestBtn.ImageAlign = ContentAlignment.MiddleLeft;
            RequestBtn.Label = RequestSubMenuPanel;
            RequestBtn.Location = new Point(0, 0);
            RequestBtn.Name = "RequestBtn";
            RequestBtn.Padding = new Padding(5, 0, 0, 0);
            RequestBtn.Size = new Size(231, 43);
            RequestBtn.TabIndex = 1;
            RequestBtn.Text = "                Запросы";
            RequestBtn.TextAlign = ContentAlignment.MiddleLeft;
            RequestBtn.UseVisualStyleBackColor = true;
            RequestBtn.Click += RequestBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(ShowBtn);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 727);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 43);
            panel3.TabIndex = 7;
            // 
            // ShowBtn
            // 
            ShowBtn.Dock = DockStyle.Fill;
            ShowBtn.FlatAppearance.BorderSize = 0;
            ShowBtn.FlatStyle = FlatStyle.Flat;
            ShowBtn.ForeColor = SystemColors.ScrollBar;
            ShowBtn.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            ShowBtn.IconColor = SystemColors.ScrollBar;
            ShowBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ShowBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ShowBtn.Label = null;
            ShowBtn.Location = new Point(0, 0);
            ShowBtn.Name = "ShowBtn";
            ShowBtn.Padding = new Padding(5, 0, 0, 0);
            ShowBtn.Size = new Size(231, 43);
            ShowBtn.TabIndex = 1;
            ShowBtn.Text = "                Печать с сортировкой";
            ShowBtn.TextAlign = ContentAlignment.MiddleLeft;
            ShowBtn.UseVisualStyleBackColor = true;
            ShowBtn.Click += ShowBtn_Click;
            // 
            // UnloadMenuPanel
            // 
            UnloadMenuPanel.Controls.Add(panel15);
            UnloadMenuPanel.Controls.Add(panel17);
            UnloadMenuPanel.Controls.Add(panel18);
            UnloadMenuPanel.Dock = DockStyle.Top;
            UnloadMenuPanel.Location = new Point(0, 598);
            UnloadMenuPanel.Name = "UnloadMenuPanel";
            UnloadMenuPanel.Size = new Size(231, 129);
            UnloadMenuPanel.TabIndex = 6;
            UnloadMenuPanel.Visible = false;
            // 
            // panel15
            // 
            panel15.Controls.Add(JSONLoadBtn);
            panel15.Dock = DockStyle.Top;
            panel15.Location = new Point(0, 86);
            panel15.Name = "panel15";
            panel15.Size = new Size(231, 43);
            panel15.TabIndex = 4;
            // 
            // JSONLoadBtn
            // 
            JSONLoadBtn.Dock = DockStyle.Fill;
            JSONLoadBtn.FlatAppearance.BorderSize = 0;
            JSONLoadBtn.FlatStyle = FlatStyle.Flat;
            JSONLoadBtn.ForeColor = SystemColors.ScrollBar;
            JSONLoadBtn.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            JSONLoadBtn.IconColor = SystemColors.ScrollBar;
            JSONLoadBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            JSONLoadBtn.ImageAlign = ContentAlignment.MiddleLeft;
            JSONLoadBtn.Label = null;
            JSONLoadBtn.Location = new Point(0, 0);
            JSONLoadBtn.Name = "JSONLoadBtn";
            JSONLoadBtn.Padding = new Padding(20, 0, 0, 0);
            JSONLoadBtn.Size = new Size(231, 43);
            JSONLoadBtn.TabIndex = 1;
            JSONLoadBtn.Text = "                           JSON";
            JSONLoadBtn.TextAlign = ContentAlignment.MiddleLeft;
            JSONLoadBtn.UseVisualStyleBackColor = true;
            JSONLoadBtn.Click += JSONLoadBtn_Click;
            // 
            // panel17
            // 
            panel17.Controls.Add(XMLoadBtn);
            panel17.Dock = DockStyle.Top;
            panel17.Location = new Point(0, 43);
            panel17.Name = "panel17";
            panel17.Size = new Size(231, 43);
            panel17.TabIndex = 5;
            // 
            // XMLoadBtn
            // 
            XMLoadBtn.Dock = DockStyle.Fill;
            XMLoadBtn.FlatAppearance.BorderSize = 0;
            XMLoadBtn.FlatStyle = FlatStyle.Flat;
            XMLoadBtn.ForeColor = SystemColors.ScrollBar;
            XMLoadBtn.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            XMLoadBtn.IconColor = SystemColors.ScrollBar;
            XMLoadBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            XMLoadBtn.ImageAlign = ContentAlignment.MiddleLeft;
            XMLoadBtn.Label = null;
            XMLoadBtn.Location = new Point(0, 0);
            XMLoadBtn.Name = "XMLoadBtn";
            XMLoadBtn.Padding = new Padding(20, 0, 0, 0);
            XMLoadBtn.Size = new Size(231, 43);
            XMLoadBtn.TabIndex = 1;
            XMLoadBtn.Text = "                           XML";
            XMLoadBtn.TextAlign = ContentAlignment.MiddleLeft;
            XMLoadBtn.UseVisualStyleBackColor = true;
            XMLoadBtn.Click += XMLoadBtn_Click;
            // 
            // panel18
            // 
            panel18.Controls.Add(BinLoadBtn);
            panel18.Dock = DockStyle.Top;
            panel18.Location = new Point(0, 0);
            panel18.Name = "panel18";
            panel18.Size = new Size(231, 43);
            panel18.TabIndex = 2;
            // 
            // BinLoadBtn
            // 
            BinLoadBtn.Dock = DockStyle.Fill;
            BinLoadBtn.FlatAppearance.BorderSize = 0;
            BinLoadBtn.FlatStyle = FlatStyle.Flat;
            BinLoadBtn.ForeColor = SystemColors.ScrollBar;
            BinLoadBtn.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            BinLoadBtn.IconColor = SystemColors.ScrollBar;
            BinLoadBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BinLoadBtn.ImageAlign = ContentAlignment.MiddleLeft;
            BinLoadBtn.Label = null;
            BinLoadBtn.Location = new Point(0, 0);
            BinLoadBtn.Name = "BinLoadBtn";
            BinLoadBtn.Padding = new Padding(20, 0, 0, 0);
            BinLoadBtn.Size = new Size(231, 43);
            BinLoadBtn.TabIndex = 1;
            BinLoadBtn.Text = "                           BIN";
            BinLoadBtn.TextAlign = ContentAlignment.MiddleLeft;
            BinLoadBtn.UseVisualStyleBackColor = true;
            BinLoadBtn.Click += BinLoadBtn_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(UnloadFileBtn);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 555);
            panel5.Name = "panel5";
            panel5.Size = new Size(231, 43);
            panel5.TabIndex = 8;
            // 
            // UnloadFileBtn
            // 
            UnloadFileBtn.Dock = DockStyle.Fill;
            UnloadFileBtn.FlatAppearance.BorderSize = 0;
            UnloadFileBtn.FlatStyle = FlatStyle.Flat;
            UnloadFileBtn.ForeColor = SystemColors.ScrollBar;
            UnloadFileBtn.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            UnloadFileBtn.IconColor = SystemColors.ScrollBar;
            UnloadFileBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            UnloadFileBtn.ImageAlign = ContentAlignment.MiddleLeft;
            UnloadFileBtn.Label = UnloadMenuPanel;
            UnloadFileBtn.Location = new Point(0, 0);
            UnloadFileBtn.Name = "UnloadFileBtn";
            UnloadFileBtn.Padding = new Padding(5, 0, 0, 0);
            UnloadFileBtn.Size = new Size(231, 43);
            UnloadFileBtn.TabIndex = 1;
            UnloadFileBtn.Text = "                Загрузить из файла";
            UnloadFileBtn.TextAlign = ContentAlignment.MiddleLeft;
            UnloadFileBtn.UseVisualStyleBackColor = true;
            UnloadFileBtn.Click += UnloadFileBtn_Click;
            // 
            // SaveSubmenuPanel
            // 
            SaveSubmenuPanel.Controls.Add(panel14);
            SaveSubmenuPanel.Controls.Add(panel22);
            SaveSubmenuPanel.Controls.Add(panel16);
            SaveSubmenuPanel.Dock = DockStyle.Top;
            SaveSubmenuPanel.Location = new Point(0, 426);
            SaveSubmenuPanel.Name = "SaveSubmenuPanel";
            SaveSubmenuPanel.Size = new Size(231, 129);
            SaveSubmenuPanel.TabIndex = 5;
            SaveSubmenuPanel.Visible = false;
            // 
            // panel14
            // 
            panel14.Controls.Add(JsonBtn);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 86);
            panel14.Name = "panel14";
            panel14.Size = new Size(231, 43);
            panel14.TabIndex = 4;
            // 
            // JsonBtn
            // 
            JsonBtn.Dock = DockStyle.Fill;
            JsonBtn.FlatAppearance.BorderSize = 0;
            JsonBtn.FlatStyle = FlatStyle.Flat;
            JsonBtn.ForeColor = SystemColors.ScrollBar;
            JsonBtn.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            JsonBtn.IconColor = SystemColors.ScrollBar;
            JsonBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            JsonBtn.ImageAlign = ContentAlignment.MiddleLeft;
            JsonBtn.Label = null;
            JsonBtn.Location = new Point(0, 0);
            JsonBtn.Name = "JsonBtn";
            JsonBtn.Padding = new Padding(20, 0, 0, 0);
            JsonBtn.Size = new Size(231, 43);
            JsonBtn.TabIndex = 1;
            JsonBtn.Text = "                           JSON";
            JsonBtn.TextAlign = ContentAlignment.MiddleLeft;
            JsonBtn.UseVisualStyleBackColor = true;
            JsonBtn.Click += JsonBtn_Click;
            // 
            // panel22
            // 
            panel22.Controls.Add(XmlBtn);
            panel22.Dock = DockStyle.Top;
            panel22.Location = new Point(0, 43);
            panel22.Name = "panel22";
            panel22.Size = new Size(231, 43);
            panel22.TabIndex = 5;
            // 
            // XmlBtn
            // 
            XmlBtn.Dock = DockStyle.Fill;
            XmlBtn.FlatAppearance.BorderSize = 0;
            XmlBtn.FlatStyle = FlatStyle.Flat;
            XmlBtn.ForeColor = SystemColors.ScrollBar;
            XmlBtn.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            XmlBtn.IconColor = SystemColors.ScrollBar;
            XmlBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            XmlBtn.ImageAlign = ContentAlignment.MiddleLeft;
            XmlBtn.Label = null;
            XmlBtn.Location = new Point(0, 0);
            XmlBtn.Name = "XmlBtn";
            XmlBtn.Padding = new Padding(20, 0, 0, 0);
            XmlBtn.Size = new Size(231, 43);
            XmlBtn.TabIndex = 1;
            XmlBtn.Text = "                           XML";
            XmlBtn.TextAlign = ContentAlignment.MiddleLeft;
            XmlBtn.UseVisualStyleBackColor = true;
            XmlBtn.Click += XmlBtn_Click;
            // 
            // panel16
            // 
            panel16.Controls.Add(BinBtn);
            panel16.Dock = DockStyle.Top;
            panel16.Location = new Point(0, 0);
            panel16.Name = "panel16";
            panel16.Size = new Size(231, 43);
            panel16.TabIndex = 2;
            // 
            // BinBtn
            // 
            BinBtn.Dock = DockStyle.Fill;
            BinBtn.FlatAppearance.BorderSize = 0;
            BinBtn.FlatStyle = FlatStyle.Flat;
            BinBtn.ForeColor = SystemColors.ScrollBar;
            BinBtn.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            BinBtn.IconColor = SystemColors.ScrollBar;
            BinBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BinBtn.ImageAlign = ContentAlignment.MiddleLeft;
            BinBtn.Label = null;
            BinBtn.Location = new Point(0, 0);
            BinBtn.Name = "BinBtn";
            BinBtn.Padding = new Padding(20, 0, 0, 0);
            BinBtn.Size = new Size(231, 43);
            BinBtn.TabIndex = 1;
            BinBtn.Text = "                           BIN";
            BinBtn.TextAlign = ContentAlignment.MiddleLeft;
            BinBtn.UseVisualStyleBackColor = true;
            BinBtn.Click += BinBtn_Click;
            // 
            // SavePanel
            // 
            SavePanel.Controls.Add(SaveSubMenuBtn);
            SavePanel.Dock = DockStyle.Top;
            SavePanel.Location = new Point(0, 383);
            SavePanel.Name = "SavePanel";
            SavePanel.Size = new Size(231, 43);
            SavePanel.TabIndex = 0;
            // 
            // SaveSubMenuBtn
            // 
            SaveSubMenuBtn.Dock = DockStyle.Fill;
            SaveSubMenuBtn.FlatAppearance.BorderSize = 0;
            SaveSubMenuBtn.FlatStyle = FlatStyle.Flat;
            SaveSubMenuBtn.ForeColor = SystemColors.ScrollBar;
            SaveSubMenuBtn.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            SaveSubMenuBtn.IconColor = SystemColors.ScrollBar;
            SaveSubMenuBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SaveSubMenuBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SaveSubMenuBtn.Label = SaveSubmenuPanel;
            SaveSubMenuBtn.Location = new Point(0, 0);
            SaveSubMenuBtn.Name = "SaveSubMenuBtn";
            SaveSubMenuBtn.Padding = new Padding(5, 0, 0, 0);
            SaveSubMenuBtn.Size = new Size(231, 43);
            SaveSubMenuBtn.TabIndex = 1;
            SaveSubMenuBtn.Text = "                Сохранить в файл";
            SaveSubMenuBtn.TextAlign = ContentAlignment.MiddleLeft;
            SaveSubMenuBtn.UseVisualStyleBackColor = true;
            SaveSubMenuBtn.Click += SaveSubMenuBtn_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(ClearBtn);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 340);
            panel8.Name = "panel8";
            panel8.Size = new Size(231, 43);
            panel8.TabIndex = 8;
            // 
            // ClearBtn
            // 
            ClearBtn.Dock = DockStyle.Fill;
            ClearBtn.FlatAppearance.BorderSize = 0;
            ClearBtn.FlatStyle = FlatStyle.Flat;
            ClearBtn.ForeColor = SystemColors.ScrollBar;
            ClearBtn.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            ClearBtn.IconColor = SystemColors.ScrollBar;
            ClearBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ClearBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ClearBtn.Label = null;
            ClearBtn.Location = new Point(0, 0);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Padding = new Padding(5, 0, 0, 0);
            ClearBtn.Size = new Size(231, 43);
            ClearBtn.TabIndex = 1;
            ClearBtn.Text = "                Очистить дерево";
            ClearBtn.TextAlign = ContentAlignment.MiddleLeft;
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(ChangeBtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 297);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 43);
            panel2.TabIndex = 7;
            // 
            // ChangeBtn
            // 
            ChangeBtn.Dock = DockStyle.Fill;
            ChangeBtn.FlatAppearance.BorderSize = 0;
            ChangeBtn.FlatStyle = FlatStyle.Flat;
            ChangeBtn.ForeColor = SystemColors.ScrollBar;
            ChangeBtn.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            ChangeBtn.IconColor = SystemColors.ScrollBar;
            ChangeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ChangeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ChangeBtn.Label = null;
            ChangeBtn.Location = new Point(0, 0);
            ChangeBtn.Name = "ChangeBtn";
            ChangeBtn.Padding = new Padding(5, 0, 0, 0);
            ChangeBtn.Size = new Size(231, 43);
            ChangeBtn.TabIndex = 1;
            ChangeBtn.Text = "                Изменить";
            ChangeBtn.TextAlign = ContentAlignment.MiddleLeft;
            ChangeBtn.UseVisualStyleBackColor = true;
            ChangeBtn.Click += ChangeBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(DeleteBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 254);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 43);
            panel1.TabIndex = 6;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Dock = DockStyle.Fill;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.ForeColor = SystemColors.ScrollBar;
            DeleteBtn.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            DeleteBtn.IconColor = SystemColors.ScrollBar;
            DeleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DeleteBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DeleteBtn.Label = null;
            DeleteBtn.Location = new Point(0, 0);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Padding = new Padding(5, 0, 0, 0);
            DeleteBtn.Size = new Size(231, 43);
            DeleteBtn.TabIndex = 1;
            DeleteBtn.Text = "                Удаление";
            DeleteBtn.TextAlign = ContentAlignment.MiddleLeft;
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // AddSubMenuPanel
            // 
            AddSubMenuPanel.Controls.Add(panel11);
            AddSubMenuPanel.Controls.Add(panel6);
            AddSubMenuPanel.Dock = DockStyle.Top;
            AddSubMenuPanel.Location = new Point(0, 168);
            AddSubMenuPanel.Name = "AddSubMenuPanel";
            AddSubMenuPanel.Size = new Size(231, 86);
            AddSubMenuPanel.TabIndex = 3;
            AddSubMenuPanel.Visible = false;
            // 
            // panel11
            // 
            panel11.Controls.Add(RandomBtn);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 43);
            panel11.Name = "panel11";
            panel11.Size = new Size(231, 43);
            panel11.TabIndex = 4;
            // 
            // RandomBtn
            // 
            RandomBtn.Dock = DockStyle.Fill;
            RandomBtn.FlatAppearance.BorderSize = 0;
            RandomBtn.FlatStyle = FlatStyle.Flat;
            RandomBtn.ForeColor = SystemColors.ScrollBar;
            RandomBtn.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            RandomBtn.IconColor = SystemColors.ScrollBar;
            RandomBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            RandomBtn.ImageAlign = ContentAlignment.MiddleLeft;
            RandomBtn.Label = null;
            RandomBtn.Location = new Point(0, 0);
            RandomBtn.Name = "RandomBtn";
            RandomBtn.Padding = new Padding(20, 0, 0, 0);
            RandomBtn.Size = new Size(231, 43);
            RandomBtn.TabIndex = 1;
            RandomBtn.Text = "                           ДСЧ";
            RandomBtn.TextAlign = ContentAlignment.MiddleLeft;
            RandomBtn.UseVisualStyleBackColor = true;
            RandomBtn.Click += RandomBtn_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(ManuallyBtn);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(231, 43);
            panel6.TabIndex = 2;
            // 
            // ManuallyBtn
            // 
            ManuallyBtn.Dock = DockStyle.Fill;
            ManuallyBtn.FlatAppearance.BorderSize = 0;
            ManuallyBtn.FlatStyle = FlatStyle.Flat;
            ManuallyBtn.ForeColor = SystemColors.ScrollBar;
            ManuallyBtn.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            ManuallyBtn.IconColor = SystemColors.ScrollBar;
            ManuallyBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ManuallyBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ManuallyBtn.Label = null;
            ManuallyBtn.Location = new Point(0, 0);
            ManuallyBtn.Name = "ManuallyBtn";
            ManuallyBtn.Padding = new Padding(20, 0, 0, 0);
            ManuallyBtn.Size = new Size(231, 43);
            ManuallyBtn.TabIndex = 1;
            ManuallyBtn.Text = "                           Вручную";
            ManuallyBtn.TextAlign = ContentAlignment.MiddleLeft;
            ManuallyBtn.UseVisualStyleBackColor = true;
            ManuallyBtn.Click += ManuallyBtn_Click;
            // 
            // AddPanel
            // 
            AddPanel.Controls.Add(AddSubMenuBtn);
            AddPanel.Controls.Add(greenLabel);
            AddPanel.Dock = DockStyle.Top;
            AddPanel.Location = new Point(0, 125);
            AddPanel.Name = "AddPanel";
            AddPanel.Size = new Size(231, 43);
            AddPanel.TabIndex = 1;
            // 
            // AddSubMenuBtn
            // 
            AddSubMenuBtn.Dock = DockStyle.Fill;
            AddSubMenuBtn.FlatAppearance.BorderSize = 0;
            AddSubMenuBtn.FlatStyle = FlatStyle.Flat;
            AddSubMenuBtn.ForeColor = SystemColors.ScrollBar;
            AddSubMenuBtn.IconChar = FontAwesome.Sharp.IconChar.Dailymotion;
            AddSubMenuBtn.IconColor = SystemColors.ScrollBar;
            AddSubMenuBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddSubMenuBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AddSubMenuBtn.Label = AddSubMenuPanel;
            AddSubMenuBtn.Location = new Point(10, 0);
            AddSubMenuBtn.Name = "AddSubMenuBtn";
            AddSubMenuBtn.Padding = new Padding(5, 0, 0, 0);
            AddSubMenuBtn.Size = new Size(221, 43);
            AddSubMenuBtn.TabIndex = 1;
            AddSubMenuBtn.Text = "                Добавить элемент";
            AddSubMenuBtn.TextAlign = ContentAlignment.MiddleLeft;
            AddSubMenuBtn.UseVisualStyleBackColor = true;
            AddSubMenuBtn.Click += AddSubMenuBtn_Click;
            // 
            // greenLabel
            // 
            greenLabel.BackColor = Color.FromArgb(134, 200, 103);
            greenLabel.Dock = DockStyle.Left;
            greenLabel.Location = new Point(0, 0);
            greenLabel.Name = "greenLabel";
            greenLabel.Size = new Size(10, 43);
            greenLabel.TabIndex = 1;
            greenLabel.Visible = false;
            // 
            // PanelLogo
            // 
            PanelLogo.BackColor = Color.FromArgb(46, 46, 50);
            PanelLogo.Controls.Add(label2);
            PanelLogo.Controls.Add(pictureBox2);
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(231, 125);
            PanelLogo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(97, 44);
            label2.Name = "label2";
            label2.Size = new Size(99, 32);
            label2.TabIndex = 1;
            label2.Text = "ФАЙЛЫ";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-13, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // PanelWindow
            // 
            PanelWindow.BackColor = Color.FromArgb(52, 52, 52);
            PanelWindow.Controls.Add(panel4);
            PanelWindow.Controls.Add(label3);
            PanelWindow.Controls.Add(pictureBox3);
            PanelWindow.Controls.Add(MenuPanel);
            PanelWindow.Dock = DockStyle.Fill;
            PanelWindow.Location = new Point(0, 40);
            PanelWindow.Name = "PanelWindow";
            PanelWindow.Size = new Size(1215, 622);
            PanelWindow.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.BackColor = Color.FromArgb(46, 46, 52);
            panel4.Controls.Add(BinaryTreeText);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(248, 419);
            panel4.Name = "panel4";
            panel4.Size = new Size(967, 203);
            panel4.TabIndex = 6;
            // 
            // BinaryTreeText
            // 
            BinaryTreeText.AutoSize = true;
            BinaryTreeText.BackColor = Color.Transparent;
            BinaryTreeText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BinaryTreeText.ForeColor = SystemColors.ControlLightLight;
            BinaryTreeText.Location = new Point(24, 21);
            BinaryTreeText.Name = "BinaryTreeText";
            BinaryTreeText.Size = new Size(54, 21);
            BinaryTreeText.TabIndex = 0;
            BinaryTreeText.Text = "label4";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ScrollBar;
            label3.Location = new Point(408, 297);
            label3.Name = "label3";
            label3.Size = new Size(656, 45);
            label3.TabIndex = 5;
            label3.Text = "ЛАБОРАТОРНАЯ 16 | РАБОТА С ФАЙЛАМИ";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(580, 71);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(340, 186);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 662);
            Controls.Add(PanelWindow);
            Controls.Add(HeaderPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Form1";
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MenuPanel.ResumeLayout(false);
            RequestSubMenuPanel.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            UnloadMenuPanel.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel5.ResumeLayout(false);
            SaveSubmenuPanel.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel16.ResumeLayout(false);
            SavePanel.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            AddSubMenuPanel.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel6.ResumeLayout(false);
            AddPanel.ResumeLayout(false);
            PanelLogo.ResumeLayout(false);
            PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PanelWindow.ResumeLayout(false);
            PanelWindow.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel HeaderPanel;
        private Label label1;
        private Panel MenuPanel;
        private FontAwesome.Sharp.IconButton WindowMinimazeBtn;
        private FontAwesome.Sharp.IconButton WindowRestoreBtn;
        private FontAwesome.Sharp.IconButton CloseBtn;
        private Panel PanelWindow;
        private Panel PanelLogo;
        private Panel AddSubMenuPanel;
        private Panel panel11;
        private IconMenuButton RandomBtn;
        private Panel panel6;
        private IconMenuButton ManuallyBtn;
        private Panel SaveSubmenuPanel;
        private Panel panel14;
        private IconMenuButton JsonBtn;
        private Panel panel22;
        private IconMenuButton XmlBtn;
        private Panel panel16;
        private IconMenuButton BinBtn;
        private Panel SavePanel;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel AddPanel;
        private IconMenuButton AddSubMenuBtn;
        private Panel greenLabel;
        private Label label3;
        private PictureBox pictureBox3;
        private IconMenuButton SaveSubMenuBtn;
        private Panel panel1;
        private IconMenuButton DeleteBtn;
        private Panel RequestSubMenuPanel;
        private Panel panel9;
        private IconMenuButton RqstBtn3;
        private Panel panel10;
        private IconMenuButton RqstBtn2;
        private Panel panel12;
        private IconMenuButton RqstBtn1;
        private Panel panel7;
        private IconMenuButton RequestBtn;
        private Panel panel3;
        private IconMenuButton ShowBtn;
        private Panel panel5;
        private IconMenuButton UnloadFileBtn;
        private Panel panel2;
        private IconMenuButton ChangeBtn;
        private Panel panel4;
        private Label BinaryTreeText;
        private Panel panel8;
        private IconMenuButton ClearBtn;
        private Panel UnloadMenuPanel;
        private Panel panel15;
        private IconMenuButton JSONLoadBtn;
        private Panel panel17;
        private IconMenuButton XMLoadBtn;
        private Panel panel18;
        private IconMenuButton BinLoadBtn;
    }
}