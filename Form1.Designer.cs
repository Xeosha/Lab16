namespace Lab16
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            HeaderPanel = new Panel();
            pictureBox1 = new PictureBox();
            WindowMinimazeBtn = new FontAwesome.Sharp.IconButton();
            WindowRestoreBtn = new FontAwesome.Sharp.IconButton();
            CloseBtn = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel2 = new Panel();
            SaveSubmenuPanel = new Panel();
            panel14 = new Panel();
            JsonBtn = new FontAwesome.Sharp.IconButton();
            green4 = new Panel();
            panel22 = new Panel();
            XmlBtn = new FontAwesome.Sharp.IconButton();
            green3 = new Panel();
            panel16 = new Panel();
            BinBtn = new FontAwesome.Sharp.IconButton();
            green2 = new Panel();
            SavePanel = new Panel();
            SaveSubMenuBtn = new FontAwesome.Sharp.IconButton();
            green1 = new Panel();
            AddSubMenuPanel = new Panel();
            panel11 = new Panel();
            RandomBtn = new FontAwesome.Sharp.IconButton();
            green7 = new Panel();
            panel6 = new Panel();
            ManuallyBtn = new FontAwesome.Sharp.IconButton();
            green6 = new Panel();
            AddPanel = new Panel();
            AddSubMenuBtn = new FontAwesome.Sharp.IconButton();
            green5 = new Panel();
            PanelLogo = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            PanelWindow = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SaveSubmenuPanel.SuspendLayout();
            panel14.SuspendLayout();
            panel22.SuspendLayout();
            panel16.SuspendLayout();
            SavePanel.SuspendLayout();
            AddSubMenuPanel.SuspendLayout();
            panel11.SuspendLayout();
            panel6.SuspendLayout();
            AddPanel.SuspendLayout();
            PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PanelWindow.SuspendLayout();
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
            HeaderPanel.Size = new Size(1090, 40);
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
            WindowMinimazeBtn.Location = new Point(980, 6);
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
            WindowRestoreBtn.Location = new Point(1010, 6);
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
            CloseBtn.Location = new Point(1041, 6);
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
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.FromArgb(46, 46, 50);
            panel2.Controls.Add(SaveSubmenuPanel);
            panel2.Controls.Add(SavePanel);
            panel2.Controls.Add(AddSubMenuPanel);
            panel2.Controls.Add(AddPanel);
            panel2.Controls.Add(PanelLogo);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(287, 525);
            panel2.TabIndex = 4;
            // 
            // SaveSubmenuPanel
            // 
            SaveSubmenuPanel.Controls.Add(panel14);
            SaveSubmenuPanel.Controls.Add(panel22);
            SaveSubmenuPanel.Controls.Add(panel16);
            SaveSubmenuPanel.Dock = DockStyle.Top;
            SaveSubmenuPanel.Location = new Point(0, 297);
            SaveSubmenuPanel.Name = "SaveSubmenuPanel";
            SaveSubmenuPanel.Size = new Size(287, 129);
            SaveSubmenuPanel.TabIndex = 5;
            // 
            // panel14
            // 
            panel14.Controls.Add(JsonBtn);
            panel14.Controls.Add(green4);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 86);
            panel14.Name = "panel14";
            panel14.Size = new Size(287, 43);
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
            JsonBtn.Location = new Point(10, 0);
            JsonBtn.Name = "JsonBtn";
            JsonBtn.Padding = new Padding(20, 0, 0, 0);
            JsonBtn.Size = new Size(277, 43);
            JsonBtn.TabIndex = 1;
            JsonBtn.Text = "                           JSON";
            JsonBtn.TextAlign = ContentAlignment.MiddleLeft;
            JsonBtn.UseVisualStyleBackColor = true;
            JsonBtn.Click += JsonBtn_Click;
            // 
            // green4
            // 
            green4.BackColor = Color.FromArgb(134, 200, 103);
            green4.Dock = DockStyle.Left;
            green4.Location = new Point(0, 0);
            green4.Name = "green4";
            green4.Size = new Size(10, 43);
            green4.TabIndex = 1;
            // 
            // panel22
            // 
            panel22.Controls.Add(XmlBtn);
            panel22.Controls.Add(green3);
            panel22.Dock = DockStyle.Top;
            panel22.Location = new Point(0, 43);
            panel22.Name = "panel22";
            panel22.Size = new Size(287, 43);
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
            XmlBtn.Location = new Point(10, 0);
            XmlBtn.Name = "XmlBtn";
            XmlBtn.Padding = new Padding(20, 0, 0, 0);
            XmlBtn.Size = new Size(277, 43);
            XmlBtn.TabIndex = 1;
            XmlBtn.Text = "                           XML";
            XmlBtn.TextAlign = ContentAlignment.MiddleLeft;
            XmlBtn.UseVisualStyleBackColor = true;
            XmlBtn.Click += XmlBtn_Click;
            // 
            // green3
            // 
            green3.BackColor = Color.FromArgb(134, 200, 103);
            green3.Dock = DockStyle.Left;
            green3.Location = new Point(0, 0);
            green3.Name = "green3";
            green3.Size = new Size(10, 43);
            green3.TabIndex = 1;
            // 
            // panel16
            // 
            panel16.Controls.Add(BinBtn);
            panel16.Controls.Add(green2);
            panel16.Dock = DockStyle.Top;
            panel16.Location = new Point(0, 0);
            panel16.Name = "panel16";
            panel16.Size = new Size(287, 43);
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
            BinBtn.Location = new Point(10, 0);
            BinBtn.Name = "BinBtn";
            BinBtn.Padding = new Padding(20, 0, 0, 0);
            BinBtn.Size = new Size(277, 43);
            BinBtn.TabIndex = 1;
            BinBtn.Text = "                           BIN";
            BinBtn.TextAlign = ContentAlignment.MiddleLeft;
            BinBtn.UseVisualStyleBackColor = true;
            BinBtn.Click += BinBtn_Click;
            // 
            // green2
            // 
            green2.BackColor = Color.FromArgb(134, 200, 103);
            green2.Dock = DockStyle.Left;
            green2.Location = new Point(0, 0);
            green2.Name = "green2";
            green2.Size = new Size(10, 43);
            green2.TabIndex = 1;
            // 
            // SavePanel
            // 
            SavePanel.Controls.Add(SaveSubMenuBtn);
            SavePanel.Controls.Add(green1);
            SavePanel.Dock = DockStyle.Top;
            SavePanel.Location = new Point(0, 254);
            SavePanel.Name = "SavePanel";
            SavePanel.Size = new Size(287, 43);
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
            SaveSubMenuBtn.Location = new Point(10, 0);
            SaveSubMenuBtn.Name = "SaveSubMenuBtn";
            SaveSubMenuBtn.Size = new Size(277, 43);
            SaveSubMenuBtn.TabIndex = 1;
            SaveSubMenuBtn.Text = "                Сохранить в файл";
            SaveSubMenuBtn.TextAlign = ContentAlignment.MiddleLeft;
            SaveSubMenuBtn.UseVisualStyleBackColor = true;
            SaveSubMenuBtn.Click += SaveSubMenuBtn_Click;
            // 
            // green1
            // 
            green1.BackColor = Color.FromArgb(134, 200, 103);
            green1.Dock = DockStyle.Left;
            green1.Location = new Point(0, 0);
            green1.Name = "green1";
            green1.Size = new Size(10, 43);
            green1.TabIndex = 1;
            // 
            // AddSubMenuPanel
            // 
            AddSubMenuPanel.Controls.Add(panel11);
            AddSubMenuPanel.Controls.Add(panel6);
            AddSubMenuPanel.Dock = DockStyle.Top;
            AddSubMenuPanel.Location = new Point(0, 168);
            AddSubMenuPanel.Name = "AddSubMenuPanel";
            AddSubMenuPanel.Size = new Size(287, 86);
            AddSubMenuPanel.TabIndex = 3;
            // 
            // panel11
            // 
            panel11.Controls.Add(RandomBtn);
            panel11.Controls.Add(green7);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 43);
            panel11.Name = "panel11";
            panel11.Size = new Size(287, 43);
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
            RandomBtn.Location = new Point(10, 0);
            RandomBtn.Name = "RandomBtn";
            RandomBtn.Padding = new Padding(20, 0, 0, 0);
            RandomBtn.Size = new Size(277, 43);
            RandomBtn.TabIndex = 1;
            RandomBtn.Text = "                           ДСЧ";
            RandomBtn.TextAlign = ContentAlignment.MiddleLeft;
            RandomBtn.UseVisualStyleBackColor = true;
            RandomBtn.Click += RandomBtn_Click;
            // 
            // green7
            // 
            green7.BackColor = Color.FromArgb(134, 200, 103);
            green7.Dock = DockStyle.Left;
            green7.Location = new Point(0, 0);
            green7.Name = "green7";
            green7.Size = new Size(10, 43);
            green7.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(ManuallyBtn);
            panel6.Controls.Add(green6);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(287, 43);
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
            ManuallyBtn.Location = new Point(10, 0);
            ManuallyBtn.Name = "ManuallyBtn";
            ManuallyBtn.Padding = new Padding(20, 0, 0, 0);
            ManuallyBtn.Size = new Size(277, 43);
            ManuallyBtn.TabIndex = 1;
            ManuallyBtn.Text = "                           Вручную";
            ManuallyBtn.TextAlign = ContentAlignment.MiddleLeft;
            ManuallyBtn.UseVisualStyleBackColor = true;
            ManuallyBtn.Click += ManuallyBtn_Click;
            // 
            // green6
            // 
            green6.BackColor = Color.FromArgb(134, 200, 103);
            green6.Dock = DockStyle.Left;
            green6.Location = new Point(0, 0);
            green6.Name = "green6";
            green6.Size = new Size(10, 43);
            green6.TabIndex = 1;
            // 
            // AddPanel
            // 
            AddPanel.Controls.Add(AddSubMenuBtn);
            AddPanel.Controls.Add(green5);
            AddPanel.Dock = DockStyle.Top;
            AddPanel.Location = new Point(0, 125);
            AddPanel.Name = "AddPanel";
            AddPanel.Size = new Size(287, 43);
            AddPanel.TabIndex = 1;
            // 
            // AddSubMenuBtn
            // 
            AddSubMenuBtn.Dock = DockStyle.Fill;
            AddSubMenuBtn.FlatAppearance.BorderSize = 0;
            AddSubMenuBtn.FlatStyle = FlatStyle.Flat;
            AddSubMenuBtn.ForeColor = SystemColors.ScrollBar;
            AddSubMenuBtn.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            AddSubMenuBtn.IconColor = SystemColors.ScrollBar;
            AddSubMenuBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddSubMenuBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AddSubMenuBtn.Location = new Point(10, 0);
            AddSubMenuBtn.Name = "AddSubMenuBtn";
            AddSubMenuBtn.Size = new Size(277, 43);
            AddSubMenuBtn.TabIndex = 1;
            AddSubMenuBtn.Text = "                Добавить элемент";
            AddSubMenuBtn.TextAlign = ContentAlignment.MiddleLeft;
            AddSubMenuBtn.UseVisualStyleBackColor = true;
            AddSubMenuBtn.Click += AddSubMenuBtn_Click;
            // 
            // green5
            // 
            green5.BackColor = Color.FromArgb(134, 200, 103);
            green5.Dock = DockStyle.Left;
            green5.Location = new Point(0, 0);
            green5.Name = "green5";
            green5.Size = new Size(10, 43);
            green5.TabIndex = 1;
            // 
            // PanelLogo
            // 
            PanelLogo.BackColor = Color.FromArgb(46, 46, 50);
            PanelLogo.Controls.Add(label2);
            PanelLogo.Controls.Add(pictureBox2);
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(287, 125);
            PanelLogo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(121, 45);
            label2.Name = "label2";
            label2.Size = new Size(99, 32);
            label2.TabIndex = 1;
            label2.Text = "ФАЙЛЫ";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // PanelWindow
            // 
            PanelWindow.BackColor = Color.FromArgb(52, 52, 52);
            PanelWindow.Controls.Add(label3);
            PanelWindow.Controls.Add(pictureBox3);
            PanelWindow.Controls.Add(panel2);
            PanelWindow.Dock = DockStyle.Fill;
            PanelWindow.Location = new Point(0, 40);
            PanelWindow.Name = "PanelWindow";
            PanelWindow.Size = new Size(1090, 525);
            PanelWindow.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ScrollBar;
            label3.Location = new Point(375, 297);
            label3.Name = "label3";
            label3.Size = new Size(656, 45);
            label3.TabIndex = 5;
            label3.Text = "ЛАБОРАТОРНАЯ 16 | РАБОТА С ФАЙЛАМИ";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(512, 108);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(340, 186);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 565);
            Controls.Add(PanelWindow);
            Controls.Add(HeaderPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            SaveSubmenuPanel.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel16.ResumeLayout(false);
            SavePanel.ResumeLayout(false);
            AddSubMenuPanel.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel6.ResumeLayout(false);
            AddPanel.ResumeLayout(false);
            PanelLogo.ResumeLayout(false);
            PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PanelWindow.ResumeLayout(false);
            PanelWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel HeaderPanel;
        private Label label1;
        private Panel panel2;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton WindowMinimazeBtn;
        private FontAwesome.Sharp.IconButton WindowRestoreBtn;
        private FontAwesome.Sharp.IconButton CloseBtn;
        private Panel PanelWindow;
        private Panel PanelLogo;
        private Panel AddSubMenuPanel;
        private Panel panel11;
        private FontAwesome.Sharp.IconButton RandomBtn;
        private Panel green7;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton ManuallyBtn;
        private Panel green6;
        private Panel SaveSubmenuPanel;
        private Panel panel14;
        private FontAwesome.Sharp.IconButton JsonBtn;
        private Panel green4;
        private Panel panel22;
        private FontAwesome.Sharp.IconButton XmlBtn;
        private Panel green3;
        private Panel panel16;
        private FontAwesome.Sharp.IconButton BinBtn;
        private Panel green2;
        private Panel SavePanel;
        private FontAwesome.Sharp.IconButton SaveSubMenuBtn;
        private Panel green1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel AddPanel;
        private FontAwesome.Sharp.IconButton AddSubMenuBtn;
        private Panel green5;
        private Label label3;
        private PictureBox pictureBox3;
    }
}