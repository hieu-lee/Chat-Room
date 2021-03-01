
namespace Chat_Room
{
    partial class Room_Join
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room_Join));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelRooms = new System.Windows.Forms.Panel();
            this.roomsBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.avatarBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonSignIn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.boxName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.boxPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.boxId = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panelRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room\'s ID: #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room\'s password:";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(334, 79);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(100, 40);
            this.labelWelcome.TabIndex = 7;
            this.labelWelcome.Text = "Okaeri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Room\'s name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(592, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "*only important if you want to create a room";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(592, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "*6-digit number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(592, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(373, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "*room\'s password must have at least 6 chars and not contain any space";
            // 
            // panelRooms
            // 
            this.panelRooms.AutoScroll = true;
            this.panelRooms.Controls.Add(this.roomsBox);
            this.panelRooms.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRooms.Location = new System.Drawing.Point(45, 253);
            this.panelRooms.Name = "panelRooms";
            this.panelRooms.Size = new System.Drawing.Size(203, 215);
            this.panelRooms.TabIndex = 16;
            // 
            // roomsBox
            // 
            this.roomsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.roomsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomsBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsBox.Location = new System.Drawing.Point(0, 0);
            this.roomsBox.Name = "roomsBox";
            this.roomsBox.ReadOnly = true;
            this.roomsBox.Size = new System.Drawing.Size(203, 215);
            this.roomsBox.TabIndex = 0;
            this.roomsBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Your rooms\' ID:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(435, 364);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(58, 17);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "public";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(510, 364);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(61, 17);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Text = "private";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Click += new System.EventHandler(this.checkBox3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(592, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(236, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "*password is not important to a public room";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(343, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Room\'s state:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(313, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Don\'t have a room yet?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(463, 451);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(137, 17);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Show all public rooms";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton2.IconColor = System.Drawing.Color.DimGray;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.Location = new System.Drawing.Point(952, 12);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(38, 33);
            this.iconButton2.TabIndex = 24;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            this.iconButton2.MouseLeave += new System.EventHandler(this.iconButton2_MouseLeave);
            this.iconButton2.MouseHover += new System.EventHandler(this.iconButton2_MouseHover);
            // 
            // avatarBox
            // 
            this.avatarBox.AllowFocused = false;
            this.avatarBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.avatarBox.AutoSizeHeight = true;
            this.avatarBox.BorderRadius = 50;
            this.avatarBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatarBox.Image = global::Chat_Room.Properties.Resources.default_avatar;
            this.avatarBox.IsCircle = true;
            this.avatarBox.Location = new System.Drawing.Point(54, 12);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(100, 100);
            this.avatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarBox.TabIndex = 25;
            this.avatarBox.TabStop = false;
            this.avatarBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.avatarBox.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(331, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(306, 45);
            this.label12.TabIndex = 26;
            this.label12.Text = "Bob Lee\'s Chatroom";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.AllowAnimations = true;
            this.buttonSignIn.AllowMouseEffects = true;
            this.buttonSignIn.AllowToggling = false;
            this.buttonSignIn.AnimationSpeed = 200;
            this.buttonSignIn.AutoGenerateColors = false;
            this.buttonSignIn.AutoRoundBorders = false;
            this.buttonSignIn.AutoSizeLeftIcon = true;
            this.buttonSignIn.AutoSizeRightIcon = true;
            this.buttonSignIn.BackColor = System.Drawing.Color.Transparent;
            this.buttonSignIn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.buttonSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSignIn.BackgroundImage")));
            this.buttonSignIn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonSignIn.ButtonText = "Browse";
            this.buttonSignIn.ButtonTextMarginLeft = 0;
            this.buttonSignIn.ColorContrastOnClick = 45;
            this.buttonSignIn.ColorContrastOnHover = 45;
            this.buttonSignIn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.buttonSignIn.CustomizableEdges = borderEdges4;
            this.buttonSignIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonSignIn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonSignIn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonSignIn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonSignIn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.buttonSignIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.ForeColor = System.Drawing.Color.White;
            this.buttonSignIn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSignIn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonSignIn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonSignIn.IconMarginLeft = 11;
            this.buttonSignIn.IconPadding = 10;
            this.buttonSignIn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSignIn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonSignIn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonSignIn.IconSize = 25;
            this.buttonSignIn.IdleBorderColor = System.Drawing.Color.Transparent;
            this.buttonSignIn.IdleBorderRadius = 30;
            this.buttonSignIn.IdleBorderThickness = 1;
            this.buttonSignIn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.buttonSignIn.IdleIconLeftImage = null;
            this.buttonSignIn.IdleIconRightImage = null;
            this.buttonSignIn.IndicateFocus = false;
            this.buttonSignIn.Location = new System.Drawing.Point(54, 131);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonSignIn.OnDisabledState.BorderRadius = 30;
            this.buttonSignIn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonSignIn.OnDisabledState.BorderThickness = 1;
            this.buttonSignIn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonSignIn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonSignIn.OnDisabledState.IconLeftImage = null;
            this.buttonSignIn.OnDisabledState.IconRightImage = null;
            this.buttonSignIn.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonSignIn.onHoverState.BorderRadius = 30;
            this.buttonSignIn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonSignIn.onHoverState.BorderThickness = 1;
            this.buttonSignIn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.buttonSignIn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonSignIn.onHoverState.IconLeftImage = null;
            this.buttonSignIn.onHoverState.IconRightImage = null;
            this.buttonSignIn.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonSignIn.OnIdleState.BorderRadius = 30;
            this.buttonSignIn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonSignIn.OnIdleState.BorderThickness = 1;
            this.buttonSignIn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.buttonSignIn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonSignIn.OnIdleState.IconLeftImage = null;
            this.buttonSignIn.OnIdleState.IconRightImage = null;
            this.buttonSignIn.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.buttonSignIn.OnPressedState.BorderRadius = 30;
            this.buttonSignIn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonSignIn.OnPressedState.BorderThickness = 1;
            this.buttonSignIn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.buttonSignIn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonSignIn.OnPressedState.IconLeftImage = null;
            this.buttonSignIn.OnPressedState.IconRightImage = null;
            this.buttonSignIn.Size = new System.Drawing.Size(100, 34);
            this.buttonSignIn.TabIndex = 27;
            this.buttonSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSignIn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonSignIn.TextMarginLeft = 0;
            this.buttonSignIn.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonSignIn.UseDefaultRadiusAndThickness = true;
            this.buttonSignIn.Click += new System.EventHandler(this.button3_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Join";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges5;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.IdleBorderRadius = 30;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(341, 399);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 30;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.onHoverState.BorderRadius = 30;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.OnIdleState.BorderRadius = 30;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.BorderRadius = 30;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(100, 34);
            this.bunifuButton1.TabIndex = 28;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.AllowAnimations = true;
            this.bunifuButton2.AllowMouseEffects = true;
            this.bunifuButton2.AllowToggling = false;
            this.bunifuButton2.AnimationSpeed = 200;
            this.bunifuButton2.AutoGenerateColors = false;
            this.bunifuButton2.AutoRoundBorders = false;
            this.bunifuButton2.AutoSizeLeftIcon = true;
            this.bunifuButton2.AutoSizeRightIcon = true;
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.ButtonText = "Create";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.ColorContrastOnClick = 45;
            this.bunifuButton2.ColorContrastOnHover = 45;
            this.bunifuButton2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.bunifuButton2.CustomizableEdges = borderEdges6;
            this.bunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton2.IconMarginLeft = 11;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton2.IconSize = 25;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.IdleBorderRadius = 30;
            this.bunifuButton2.IdleBorderThickness = 1;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.IndicateFocus = false;
            this.bunifuButton2.Location = new System.Drawing.Point(471, 399);
            this.bunifuButton2.Name = "bunifuButton2";
            this.bunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.OnDisabledState.BorderRadius = 30;
            this.bunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnDisabledState.BorderThickness = 1;
            this.bunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.OnDisabledState.IconLeftImage = null;
            this.bunifuButton2.OnDisabledState.IconRightImage = null;
            this.bunifuButton2.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.onHoverState.BorderRadius = 30;
            this.bunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.onHoverState.BorderThickness = 1;
            this.bunifuButton2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.bunifuButton2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.onHoverState.IconLeftImage = null;
            this.bunifuButton2.onHoverState.IconRightImage = null;
            this.bunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.OnIdleState.BorderRadius = 30;
            this.bunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnIdleState.BorderThickness = 1;
            this.bunifuButton2.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.bunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnIdleState.IconLeftImage = null;
            this.bunifuButton2.OnIdleState.IconRightImage = null;
            this.bunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.bunifuButton2.OnPressedState.BorderRadius = 30;
            this.bunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnPressedState.BorderThickness = 1;
            this.bunifuButton2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.bunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnPressedState.IconLeftImage = null;
            this.bunifuButton2.OnPressedState.IconRightImage = null;
            this.bunifuButton2.Size = new System.Drawing.Size(100, 34);
            this.bunifuButton2.TabIndex = 29;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton2.TextMarginLeft = 0;
            this.bunifuButton2.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton2.UseDefaultRadiusAndThickness = true;
            this.bunifuButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // boxName
            // 
            this.boxName.AcceptsReturn = false;
            this.boxName.AcceptsTab = false;
            this.boxName.AnimationSpeed = 200;
            this.boxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.boxName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.boxName.BackColor = System.Drawing.Color.Transparent;
            this.boxName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boxName.BackgroundImage")));
            this.boxName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.boxName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.boxName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.boxName.BorderColorIdle = System.Drawing.Color.Transparent;
            this.boxName.BorderRadius = 20;
            this.boxName.BorderThickness = 2;
            this.boxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.boxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.boxName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.boxName.DefaultText = "";
            this.boxName.FillColor = System.Drawing.Color.White;
            this.boxName.HideSelection = true;
            this.boxName.IconLeft = null;
            this.boxName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.boxName.IconPadding = 10;
            this.boxName.IconRight = null;
            this.boxName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.boxName.Lines = new string[0];
            this.boxName.Location = new System.Drawing.Point(435, 198);
            this.boxName.MaxLength = 32767;
            this.boxName.MinimumSize = new System.Drawing.Size(1, 1);
            this.boxName.Modified = false;
            this.boxName.Multiline = false;
            this.boxName.Name = "boxName";
            stateProperties13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.boxName.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.boxName.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.boxName.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Transparent;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.boxName.OnIdleState = stateProperties16;
            this.boxName.Padding = new System.Windows.Forms.Padding(3);
            this.boxName.PasswordChar = '\0';
            this.boxName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.boxName.PlaceholderText = "Name";
            this.boxName.ReadOnly = false;
            this.boxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.boxName.SelectedText = "";
            this.boxName.SelectionLength = 0;
            this.boxName.SelectionStart = 0;
            this.boxName.ShortcutsEnabled = true;
            this.boxName.Size = new System.Drawing.Size(151, 37);
            this.boxName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.boxName.TabIndex = 30;
            this.boxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.boxName.TextMarginBottom = 0;
            this.boxName.TextMarginLeft = 3;
            this.boxName.TextMarginTop = 0;
            this.boxName.TextPlaceholder = "Name";
            this.boxName.UseSystemPasswordChar = false;
            this.boxName.WordWrap = true;
            // 
            // boxPassword
            // 
            this.boxPassword.AcceptsReturn = false;
            this.boxPassword.AcceptsTab = false;
            this.boxPassword.AnimationSpeed = 200;
            this.boxPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.boxPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.boxPassword.BackColor = System.Drawing.Color.Transparent;
            this.boxPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boxPassword.BackgroundImage")));
            this.boxPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.boxPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.boxPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.boxPassword.BorderColorIdle = System.Drawing.Color.Transparent;
            this.boxPassword.BorderRadius = 20;
            this.boxPassword.BorderThickness = 2;
            this.boxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.boxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.boxPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.boxPassword.DefaultText = "";
            this.boxPassword.FillColor = System.Drawing.Color.White;
            this.boxPassword.HideSelection = true;
            this.boxPassword.IconLeft = null;
            this.boxPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.boxPassword.IconPadding = 10;
            this.boxPassword.IconRight = null;
            this.boxPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.boxPassword.Lines = new string[0];
            this.boxPassword.Location = new System.Drawing.Point(435, 293);
            this.boxPassword.MaxLength = 32767;
            this.boxPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.boxPassword.Modified = false;
            this.boxPassword.Multiline = false;
            this.boxPassword.Name = "boxPassword";
            stateProperties17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.boxPassword.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.boxPassword.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.boxPassword.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Transparent;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.boxPassword.OnIdleState = stateProperties20;
            this.boxPassword.Padding = new System.Windows.Forms.Padding(3);
            this.boxPassword.PasswordChar = '●';
            this.boxPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.boxPassword.PlaceholderText = "Password";
            this.boxPassword.ReadOnly = false;
            this.boxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.boxPassword.SelectedText = "";
            this.boxPassword.SelectionLength = 0;
            this.boxPassword.SelectionStart = 0;
            this.boxPassword.ShortcutsEnabled = true;
            this.boxPassword.Size = new System.Drawing.Size(151, 37);
            this.boxPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.boxPassword.TabIndex = 31;
            this.boxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.boxPassword.TextMarginBottom = 0;
            this.boxPassword.TextMarginLeft = 3;
            this.boxPassword.TextMarginTop = 0;
            this.boxPassword.TextPlaceholder = "Password";
            this.boxPassword.UseSystemPasswordChar = true;
            this.boxPassword.WordWrap = true;
            // 
            // boxId
            // 
            this.boxId.AcceptsReturn = false;
            this.boxId.AcceptsTab = false;
            this.boxId.AnimationSpeed = 200;
            this.boxId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.boxId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.boxId.BackColor = System.Drawing.Color.Transparent;
            this.boxId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boxId.BackgroundImage")));
            this.boxId.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.boxId.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.boxId.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.boxId.BorderColorIdle = System.Drawing.Color.Transparent;
            this.boxId.BorderRadius = 20;
            this.boxId.BorderThickness = 2;
            this.boxId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.boxId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.boxId.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.boxId.DefaultText = "";
            this.boxId.FillColor = System.Drawing.Color.White;
            this.boxId.HideSelection = true;
            this.boxId.IconLeft = null;
            this.boxId.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.boxId.IconPadding = 10;
            this.boxId.IconRight = null;
            this.boxId.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.boxId.Lines = new string[0];
            this.boxId.Location = new System.Drawing.Point(435, 245);
            this.boxId.MaxLength = 32767;
            this.boxId.MinimumSize = new System.Drawing.Size(1, 1);
            this.boxId.Modified = false;
            this.boxId.Multiline = false;
            this.boxId.Name = "boxId";
            stateProperties21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.boxId.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.boxId.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.boxId.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Transparent;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.Empty;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.boxId.OnIdleState = stateProperties24;
            this.boxId.Padding = new System.Windows.Forms.Padding(3);
            this.boxId.PasswordChar = '\0';
            this.boxId.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.boxId.PlaceholderText = "ID";
            this.boxId.ReadOnly = false;
            this.boxId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.boxId.SelectedText = "";
            this.boxId.SelectionLength = 0;
            this.boxId.SelectionStart = 0;
            this.boxId.ShortcutsEnabled = true;
            this.boxId.Size = new System.Drawing.Size(151, 37);
            this.boxId.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.boxId.TabIndex = 32;
            this.boxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.boxId.TextMarginBottom = 0;
            this.boxId.TextMarginLeft = 3;
            this.boxId.TextMarginTop = 0;
            this.boxId.TextPlaceholder = "ID";
            this.boxId.UseSystemPasswordChar = false;
            this.boxId.WordWrap = true;
            // 
            // Room_Join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1002, 495);
            this.Controls.Add(this.boxId);
            this.Controls.Add(this.boxPassword);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.bunifuButton2);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.avatarBox);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelRooms);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Room_Join";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Join";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Room_Join_FormClosed);
            this.Load += new System.EventHandler(this.Room_Join_Load);
            this.panelRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelRooms;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox roomsBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Bunifu.UI.WinForms.BunifuPictureBox avatarBox;
        private System.Windows.Forms.Label label12;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton buttonSignIn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Bunifu.UI.WinForms.BunifuTextBox boxName;
        private Bunifu.UI.WinForms.BunifuTextBox boxPassword;
        private Bunifu.UI.WinForms.BunifuTextBox boxId;
    }
}