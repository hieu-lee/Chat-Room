
namespace Chat_Room
{
    partial class NewRoom
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
            try
            {
                base.Dispose(disposing);
            }
            catch (System.Exception)
            {
                System.Threading.Thread.Sleep(200);
                base.Dispose(disposing);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewRoom));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.infoButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.buttonImage = new FontAwesome.Sharp.IconButton();
            this.buttonSend = new Bunifu.UI.WinForms.BunifuImageButton();
            this.textBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.emojiContainer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.infoButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 104);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(110, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(109, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AllowFocused = false;
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.AutoSizeHeight = true;
            this.pictureBox1.BorderRadius = 50;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Chat_Room.Properties.Resources.shinobu;
            this.pictureBox1.IsCircle = true;
            this.pictureBox1.Location = new System.Drawing.Point(5, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // infoButton
            // 
            this.infoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infoButton.FlatAppearance.BorderSize = 0;
            this.infoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.infoButton.IconColor = System.Drawing.Color.DimGray;
            this.infoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.infoButton.Location = new System.Drawing.Point(673, 9);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(39, 47);
            this.infoButton.TabIndex = 5;
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            this.infoButton.MouseLeave += new System.EventHandler(this.infoButton_MouseLeave);
            this.infoButton.MouseHover += new System.EventHandler(this.infoButton_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bob Lee\'s chatroom";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(217)))), ((int)(((byte)(231)))));
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.buttonImage);
            this.panel2.Controls.Add(this.buttonSend);
            this.panel2.Controls.Add(this.textBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 125);
            this.panel2.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.GrinBeam;
            this.iconButton1.IconColor = System.Drawing.Color.DimGray;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 45;
            this.iconButton1.Location = new System.Drawing.Point(65, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(39, 41);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            this.iconButton1.MouseLeave += new System.EventHandler(this.iconButton1_MouseLeave);
            this.iconButton1.MouseHover += new System.EventHandler(this.iconButton1_MouseHover);
            // 
            // buttonImage
            // 
            this.buttonImage.FlatAppearance.BorderSize = 0;
            this.buttonImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImage.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.buttonImage.IconColor = System.Drawing.Color.DimGray;
            this.buttonImage.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonImage.Location = new System.Drawing.Point(12, 6);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(47, 36);
            this.buttonImage.TabIndex = 10;
            this.buttonImage.UseVisualStyleBackColor = false;
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
            this.buttonImage.MouseLeave += new System.EventHandler(this.buttonImage_MouseLeave);
            this.buttonImage.MouseHover += new System.EventHandler(this.buttonImage_MouseHover);
            // 
            // buttonSend
            // 
            this.buttonSend.ActiveImage = null;
            this.buttonSend.AllowAnimations = true;
            this.buttonSend.AllowBuffering = false;
            this.buttonSend.AllowToggling = false;
            this.buttonSend.AllowZooming = true;
            this.buttonSend.AllowZoomingOnFocus = false;
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.BackColor = System.Drawing.Color.Transparent;
            this.buttonSend.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonSend.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonSend.ErrorImage")));
            this.buttonSend.FadeWhenInactive = false;
            this.buttonSend.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonSend.Image = ((System.Drawing.Image)(resources.GetObject("buttonSend.Image")));
            this.buttonSend.ImageActive = null;
            this.buttonSend.ImageLocation = null;
            this.buttonSend.ImageMargin = 10;
            this.buttonSend.ImageSize = new System.Drawing.Size(40, 34);
            this.buttonSend.ImageZoomSize = new System.Drawing.Size(50, 44);
            this.buttonSend.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonSend.InitialImage")));
            this.buttonSend.Location = new System.Drawing.Point(662, 56);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Rotation = 0;
            this.buttonSend.ShowActiveImage = true;
            this.buttonSend.ShowCursorChanges = true;
            this.buttonSend.ShowImageBorders = true;
            this.buttonSend.ShowSizeMarkers = false;
            this.buttonSend.Size = new System.Drawing.Size(50, 44);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.ToolTipText = "";
            this.buttonSend.WaitOnLoad = false;
            this.buttonSend.Zoom = 10;
            this.buttonSend.ZoomSpeed = 10;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBox
            // 
            this.textBox.AcceptsReturn = false;
            this.textBox.AcceptsTab = false;
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.AnimationSpeed = 200;
            this.textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBox.BackColor = System.Drawing.Color.Transparent;
            this.textBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBox.BackgroundImage")));
            this.textBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.textBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.textBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(217)))), ((int)(((byte)(231)))));
            this.textBox.BorderRadius = 25;
            this.textBox.BorderThickness = 2;
            this.textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox.DefaultFont = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox.DefaultText = "";
            this.textBox.FillColor = System.Drawing.Color.White;
            this.textBox.HideSelection = true;
            this.textBox.IconLeft = null;
            this.textBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox.IconPadding = 10;
            this.textBox.IconRight = null;
            this.textBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox.Lines = new string[0];
            this.textBox.Location = new System.Drawing.Point(12, 45);
            this.textBox.MaxLength = 32767;
            this.textBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBox.Modified = false;
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(217)))), ((int)(((byte)(231)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBox.OnIdleState = stateProperties4;
            this.textBox.Padding = new System.Windows.Forms.Padding(3);
            this.textBox.PasswordChar = '\0';
            this.textBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.textBox.PlaceholderText = "Aa";
            this.textBox.ReadOnly = false;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox.SelectedText = "";
            this.textBox.SelectionLength = 0;
            this.textBox.SelectionStart = 0;
            this.textBox.ShortcutsEnabled = true;
            this.textBox.Size = new System.Drawing.Size(626, 68);
            this.textBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.textBox.TabIndex = 8;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox.TextMarginBottom = 0;
            this.textBox.TextMarginLeft = 3;
            this.textBox.TextMarginTop = 0;
            this.textBox.TextPlaceholder = "Aa";
            this.textBox.UseSystemPasswordChar = false;
            this.textBox.WordWrap = true;
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            // 
            // emojiContainer
            // 
            this.emojiContainer.AutoScroll = true;
            this.emojiContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(217)))), ((int)(((byte)(231)))));
            this.emojiContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.emojiContainer.Location = new System.Drawing.Point(0, 391);
            this.emojiContainer.Name = "emojiContainer";
            this.emojiContainer.Size = new System.Drawing.Size(720, 50);
            this.emojiContainer.TabIndex = 2;
            this.emojiContainer.Visible = false;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(217)))), ((int)(((byte)(231)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(720, 287);
            this.panel3.TabIndex = 3;
            // 
            // NewRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 566);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.emojiContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewRoom";
            this.Text = "NewRoom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Room_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Room_FormClosed);
            this.Load += new System.EventHandler(this.Room_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton infoButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuTextBox textBox;
        private Bunifu.UI.WinForms.BunifuImageButton buttonSend;
        private FontAwesome.Sharp.IconButton buttonImage;
        private FontAwesome.Sharp.IconButton iconButton1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel emojiContainer;
        private System.Windows.Forms.Panel panel3;
    }
}