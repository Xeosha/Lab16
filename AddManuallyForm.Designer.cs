namespace Lab16
{
    partial class AddManuallyForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            AddGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            InfoPanel = new Panel();
            BtnPanel = new Panel();
            infoBtn = new Guna.UI2.WinForms.Guna2Button();
            WeightPanel = new Panel();
            WeightTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            WeightLabel = new Label();
            PricePanel = new Panel();
            PriceLabel = new Label();
            PriceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            NamePanel = new Panel();
            NameLabel = new Label();
            NameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            AddGroupBox.SuspendLayout();
            InfoPanel.SuspendLayout();
            BtnPanel.SuspendLayout();
            WeightPanel.SuspendLayout();
            PricePanel.SuspendLayout();
            NamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddGroupBox
            // 
            AddGroupBox.BorderRadius = 20;
            AddGroupBox.Controls.Add(InfoPanel);
            AddGroupBox.CustomBorderColor = Color.FromArgb(134, 200, 103);
            AddGroupBox.CustomizableEdges = customizableEdges9;
            AddGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddGroupBox.ForeColor = Color.FromArgb(52, 52, 52);
            AddGroupBox.ImeMode = ImeMode.Disable;
            AddGroupBox.Location = new Point(256, 12);
            AddGroupBox.Name = "AddGroupBox";
            AddGroupBox.ShadowDecoration.CustomizableEdges = customizableEdges10;
            AddGroupBox.Size = new Size(367, 402);
            AddGroupBox.TabIndex = 0;
            AddGroupBox.Text = "Добавление товара";
            AddGroupBox.TextAlign = HorizontalAlignment.Center;
            // 
            // InfoPanel
            // 
            InfoPanel.AutoScroll = true;
            InfoPanel.BackColor = Color.White;
            InfoPanel.Controls.Add(BtnPanel);
            InfoPanel.Controls.Add(WeightPanel);
            InfoPanel.Controls.Add(PricePanel);
            InfoPanel.Controls.Add(NamePanel);
            InfoPanel.Dock = DockStyle.Top;
            InfoPanel.Location = new Point(0, 40);
            InfoPanel.Name = "InfoPanel";
            InfoPanel.Size = new Size(367, 337);
            InfoPanel.TabIndex = 8;
            // 
            // BtnPanel
            // 
            BtnPanel.Controls.Add(infoBtn);
            BtnPanel.Dock = DockStyle.Top;
            BtnPanel.Location = new Point(0, 213);
            BtnPanel.Name = "BtnPanel";
            BtnPanel.Size = new Size(367, 121);
            BtnPanel.TabIndex = 10;
            // 
            // infoBtn
            // 
            infoBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            infoBtn.BackColor = Color.Transparent;
            infoBtn.BorderRadius = 10;
            infoBtn.Cursor = Cursors.Hand;
            infoBtn.CustomizableEdges = customizableEdges1;
            infoBtn.DisabledState.BorderColor = Color.DarkGray;
            infoBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            infoBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            infoBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            infoBtn.FillColor = Color.FromArgb(134, 200, 103);
            infoBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            infoBtn.ForeColor = Color.White;
            infoBtn.Location = new Point(86, 27);
            infoBtn.Name = "infoBtn";
            infoBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            infoBtn.Size = new Size(201, 55);
            infoBtn.TabIndex = 2;
            infoBtn.Text = "Сохранить";
            infoBtn.Click += infoBtn_Click;
            // 
            // WeightPanel
            // 
            WeightPanel.Controls.Add(WeightTextBox);
            WeightPanel.Controls.Add(WeightLabel);
            WeightPanel.Dock = DockStyle.Top;
            WeightPanel.Location = new Point(0, 142);
            WeightPanel.Name = "WeightPanel";
            WeightPanel.Size = new Size(367, 71);
            WeightPanel.TabIndex = 9;
            // 
            // WeightTextBox
            // 
            WeightTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WeightTextBox.BackColor = Color.Transparent;
            WeightTextBox.BorderRadius = 10;
            WeightTextBox.CustomizableEdges = customizableEdges3;
            WeightTextBox.DefaultText = "";
            WeightTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            WeightTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            WeightTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            WeightTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            WeightTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            WeightTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            WeightTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            WeightTextBox.Location = new Point(17, 21);
            WeightTextBox.Name = "WeightTextBox";
            WeightTextBox.PasswordChar = '\0';
            WeightTextBox.PlaceholderText = "";
            WeightTextBox.SelectedText = "";
            WeightTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            WeightTextBox.Size = new Size(335, 36);
            WeightTextBox.TabIndex = 5;
            // 
            // WeightLabel
            // 
            WeightLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WeightLabel.AutoSize = true;
            WeightLabel.BackColor = Color.Transparent;
            WeightLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            WeightLabel.Location = new Point(17, 3);
            WeightLabel.Name = "WeightLabel";
            WeightLabel.Size = new Size(26, 15);
            WeightLabel.TabIndex = 6;
            WeightLabel.Text = "Вес";
            // 
            // PricePanel
            // 
            PricePanel.Controls.Add(PriceLabel);
            PricePanel.Controls.Add(PriceTextBox);
            PricePanel.Dock = DockStyle.Top;
            PricePanel.Location = new Point(0, 71);
            PricePanel.Name = "PricePanel";
            PricePanel.Size = new Size(367, 71);
            PricePanel.TabIndex = 8;
            // 
            // PriceLabel
            // 
            PriceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PriceLabel.AutoSize = true;
            PriceLabel.BackColor = Color.Transparent;
            PriceLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PriceLabel.Location = new Point(17, 3);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(35, 15);
            PriceLabel.TabIndex = 4;
            PriceLabel.Text = "Цена";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PriceTextBox.BackColor = Color.Transparent;
            PriceTextBox.BorderRadius = 10;
            PriceTextBox.CustomizableEdges = customizableEdges5;
            PriceTextBox.DefaultText = "";
            PriceTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PriceTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PriceTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PriceTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PriceTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PriceTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PriceTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PriceTextBox.Location = new Point(17, 21);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.PasswordChar = '\0';
            PriceTextBox.PlaceholderText = "";
            PriceTextBox.SelectedText = "";
            PriceTextBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            PriceTextBox.Size = new Size(335, 35);
            PriceTextBox.TabIndex = 3;
            // 
            // NamePanel
            // 
            NamePanel.Controls.Add(NameLabel);
            NamePanel.Controls.Add(NameTextBox);
            NamePanel.Dock = DockStyle.Top;
            NamePanel.Location = new Point(0, 0);
            NamePanel.Name = "NamePanel";
            NamePanel.Size = new Size(367, 71);
            NamePanel.TabIndex = 7;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NameLabel.AutoSize = true;
            NameLabel.BackColor = Color.Transparent;
            NameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(17, 9);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(102, 15);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Название товара";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.BackColor = Color.Transparent;
            NameTextBox.BorderRadius = 10;
            NameTextBox.CustomizableEdges = customizableEdges7;
            NameTextBox.DefaultText = "";
            NameTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            NameTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            NameTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            NameTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            NameTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            NameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            NameTextBox.Location = new Point(17, 27);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PasswordChar = '\0';
            NameTextBox.PlaceholderText = "";
            NameTextBox.SelectedText = "";
            NameTextBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            NameTextBox.Size = new Size(335, 36);
            NameTextBox.TabIndex = 0;
            // 
            // AddManuallyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 52, 52);
            ClientSize = new Size(911, 593);
            Controls.Add(AddGroupBox);
            Name = "AddManuallyForm";
            Text = "AddManuallyForm";
            AddGroupBox.ResumeLayout(false);
            InfoPanel.ResumeLayout(false);
            BtnPanel.ResumeLayout(false);
            WeightPanel.ResumeLayout(false);
            WeightPanel.PerformLayout();
            PricePanel.ResumeLayout(false);
            PricePanel.PerformLayout();
            NamePanel.ResumeLayout(false);
            NamePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox AddGroupBox;
        private Panel InfoPanel;
        private Panel BtnPanel;
        private Guna.UI2.WinForms.Guna2Button infoBtn;
        private Guna.UI2.WinForms.Guna2TextBox WeightTextBox;
        private Label WeightLabel;
        private Guna.UI2.WinForms.Guna2TextBox PriceTextBox;
        private Label PriceLabel;
        private Panel NamePanel;
        private Guna.UI2.WinForms.Guna2TextBox NameTextBox;
        private Label NameLabel;
        private Panel WeightPanel;
        private Panel PricePanel;
    }
}