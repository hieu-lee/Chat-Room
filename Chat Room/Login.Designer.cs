
namespace Chat_Room
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.passwordBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.buttonSignIn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(440, 335);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 17);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Don\'t have an account?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 45);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bob Lee\'s Chatroom";
            // 
            // usernameBox
            // 
            this.usernameBox.AcceptsReturn = false;
            this.usernameBox.AcceptsTab = false;
            this.usernameBox.AnimationSpeed = 200;
            this.usernameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.usernameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.usernameBox.BackColor = System.Drawing.Color.Transparent;
            this.usernameBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usernameBox.BackgroundImage")));
            this.usernameBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.usernameBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.usernameBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.usernameBox.BorderColorIdle = System.Drawing.Color.Transparent;
            this.usernameBox.BorderRadius = 20;
            this.usernameBox.BorderThickness = 2;
            this.usernameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.usernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.usernameBox.DefaultText = "";
            this.usernameBox.FillColor = System.Drawing.Color.White;
            this.usernameBox.HideSelection = true;
            this.usernameBox.IconLeft = null;
            this.usernameBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameBox.IconPadding = 10;
            this.usernameBox.IconRight = null;
            this.usernameBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameBox.Lines = new string[0];
            this.usernameBox.Location = new System.Drawing.Point(293, 150);
            this.usernameBox.MaxLength = 32767;
            this.usernameBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.usernameBox.Modified = false;
            this.usernameBox.Multiline = false;
            this.usernameBox.Name = "usernameBox";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.usernameBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.usernameBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.usernameBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Transparent;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.usernameBox.OnIdleState = stateProperties4;
            this.usernameBox.Padding = new System.Windows.Forms.Padding(3);
            this.usernameBox.PasswordChar = '\0';
            this.usernameBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.usernameBox.PlaceholderText = "Username";
            this.usernameBox.ReadOnly = false;
            this.usernameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameBox.SelectedText = "";
            this.usernameBox.SelectionLength = 0;
            this.usernameBox.SelectionStart = 0;
            this.usernameBox.ShortcutsEnabled = true;
            this.usernameBox.Size = new System.Drawing.Size(203, 37);
            this.usernameBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.usernameBox.TabIndex = 10;
            this.usernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameBox.TextMarginBottom = 0;
            this.usernameBox.TextMarginLeft = 3;
            this.usernameBox.TextMarginTop = 0;
            this.usernameBox.TextPlaceholder = "Username";
            this.usernameBox.UseSystemPasswordChar = false;
            this.usernameBox.WordWrap = true;
            this.usernameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameBox_KeyDown);
            // 
            // passwordBox
            // 
            this.passwordBox.AcceptsReturn = false;
            this.passwordBox.AcceptsTab = false;
            this.passwordBox.AnimationSpeed = 200;
            this.passwordBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordBox.BackgroundImage")));
            this.passwordBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.passwordBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.passwordBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.passwordBox.BorderColorIdle = System.Drawing.Color.Transparent;
            this.passwordBox.BorderRadius = 20;
            this.passwordBox.BorderThickness = 2;
            this.passwordBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.passwordBox.DefaultText = "";
            this.passwordBox.FillColor = System.Drawing.Color.White;
            this.passwordBox.HideSelection = true;
            this.passwordBox.IconLeft = null;
            this.passwordBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBox.IconPadding = 10;
            this.passwordBox.IconRight = null;
            this.passwordBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBox.Lines = new string[0];
            this.passwordBox.Location = new System.Drawing.Point(293, 209);
            this.passwordBox.MaxLength = 32767;
            this.passwordBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.passwordBox.Modified = false;
            this.passwordBox.Multiline = false;
            this.passwordBox.Name = "passwordBox";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.passwordBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Transparent;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordBox.OnIdleState = stateProperties8;
            this.passwordBox.Padding = new System.Windows.Forms.Padding(3);
            this.passwordBox.PasswordChar = '●';
            this.passwordBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwordBox.PlaceholderText = "Password";
            this.passwordBox.ReadOnly = false;
            this.passwordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordBox.SelectedText = "";
            this.passwordBox.SelectionLength = 0;
            this.passwordBox.SelectionStart = 0;
            this.passwordBox.ShortcutsEnabled = true;
            this.passwordBox.Size = new System.Drawing.Size(203, 37);
            this.passwordBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.passwordBox.TabIndex = 11;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordBox.TextMarginBottom = 0;
            this.passwordBox.TextMarginLeft = 3;
            this.passwordBox.TextMarginTop = 0;
            this.passwordBox.TextPlaceholder = "Password";
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.WordWrap = true;
            this.passwordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordBox_KeyDown);
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
            this.buttonSignIn.ButtonText = "Log In";
            this.buttonSignIn.ButtonTextMarginLeft = 0;
            this.buttonSignIn.ColorContrastOnClick = 45;
            this.buttonSignIn.ColorContrastOnHover = 45;
            this.buttonSignIn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.buttonSignIn.CustomizableEdges = borderEdges1;
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
            this.buttonSignIn.Location = new System.Drawing.Point(340, 272);
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
            this.buttonSignIn.Size = new System.Drawing.Size(110, 39);
            this.buttonSignIn.TabIndex = 12;
            this.buttonSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSignIn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonSignIn.TextMarginLeft = 0;
            this.buttonSignIn.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonSignIn.UseDefaultRadiusAndThickness = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(359, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuTextBox usernameBox;
        private Bunifu.UI.WinForms.BunifuTextBox passwordBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton buttonSignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}