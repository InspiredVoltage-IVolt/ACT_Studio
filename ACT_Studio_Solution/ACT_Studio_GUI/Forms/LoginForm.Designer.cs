namespace ACT.Studio.GUI
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.GunaBorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.GunaShadowActionsPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ForgotPasswordGunaButton = new Guna.UI2.WinForms.Guna2Button();
            this.LoginGunaButton = new Guna.UI2.WinForms.Guna2Button();
            this.CloseFormGunaControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ACTEmailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ACTPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TeamInvitationCodeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GunaShadowActionsPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GunaBorderlessForm
            // 
            this.GunaBorderlessForm.AnimateWindow = true;
            this.GunaBorderlessForm.AnimationInterval = 1000;
            this.GunaBorderlessForm.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.GunaBorderlessForm.BorderRadius = 8;
            this.GunaBorderlessForm.ContainerControl = this;
            this.GunaBorderlessForm.DockForm = false;
            this.GunaBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.GunaBorderlessForm.DragForm = false;
            this.GunaBorderlessForm.HasFormShadow = false;
            this.GunaBorderlessForm.ResizeForm = false;
            this.GunaBorderlessForm.ShadowColor = System.Drawing.Color.DarkGray;
            this.GunaBorderlessForm.TransparentWhileDrag = true;
            // 
            // GunaShadowActionsPanel
            // 
            this.GunaShadowActionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.GunaShadowActionsPanel.Controls.Add(this.ForgotPasswordGunaButton);
            this.GunaShadowActionsPanel.Controls.Add(this.LoginGunaButton);
            this.GunaShadowActionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GunaShadowActionsPanel.FillColor = System.Drawing.Color.White;
            this.GunaShadowActionsPanel.Location = new System.Drawing.Point(0, 203);
            this.GunaShadowActionsPanel.Margin = new System.Windows.Forms.Padding(8);
            this.GunaShadowActionsPanel.Name = "GunaShadowActionsPanel";
            this.GunaShadowActionsPanel.Padding = new System.Windows.Forms.Padding(8);
            this.GunaShadowActionsPanel.ShadowColor = System.Drawing.Color.DarkGray;
            this.GunaShadowActionsPanel.Size = new System.Drawing.Size(365, 64);
            this.GunaShadowActionsPanel.TabIndex = 0;
            // 
            // ForgotPasswordGunaButton
            // 
            this.ForgotPasswordGunaButton.Animated = true;
            this.ForgotPasswordGunaButton.AutoRoundedCorners = true;
            this.ForgotPasswordGunaButton.BorderRadius = 19;
            this.ForgotPasswordGunaButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ForgotPasswordGunaButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ForgotPasswordGunaButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ForgotPasswordGunaButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ForgotPasswordGunaButton.FillColor = System.Drawing.Color.Teal;
            this.ForgotPasswordGunaButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForgotPasswordGunaButton.ForeColor = System.Drawing.Color.White;
            this.ForgotPasswordGunaButton.HoverState.FillColor = System.Drawing.Color.Teal;
            this.ForgotPasswordGunaButton.HoverState.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForgotPasswordGunaButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ForgotPasswordGunaButton.Location = new System.Drawing.Point(12, 12);
            this.ForgotPasswordGunaButton.Name = "ForgotPasswordGunaButton";
            this.ForgotPasswordGunaButton.Size = new System.Drawing.Size(140, 40);
            this.ForgotPasswordGunaButton.TabIndex = 1;
            this.ForgotPasswordGunaButton.Text = "Forgot Password";
            this.ForgotPasswordGunaButton.Click += new System.EventHandler(this.ForgotPasswordGunaButton_Click);
            // 
            // LoginGunaButton
            // 
            this.LoginGunaButton.Animated = true;
            this.LoginGunaButton.AutoRoundedCorners = true;
            this.LoginGunaButton.BorderRadius = 19;
            this.LoginGunaButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginGunaButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginGunaButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginGunaButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginGunaButton.FillColor = System.Drawing.Color.Teal;
            this.LoginGunaButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginGunaButton.ForeColor = System.Drawing.Color.White;
            this.LoginGunaButton.HoverState.FillColor = System.Drawing.Color.Teal;
            this.LoginGunaButton.HoverState.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginGunaButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoginGunaButton.Location = new System.Drawing.Point(213, 12);
            this.LoginGunaButton.Name = "LoginGunaButton";
            this.LoginGunaButton.Size = new System.Drawing.Size(140, 40);
            this.LoginGunaButton.TabIndex = 0;
            this.LoginGunaButton.Text = "Login";
            this.LoginGunaButton.Click += new System.EventHandler(this.LoginGunaButton_Click);
            // 
            // CloseFormGunaControlBox
            // 
            this.CloseFormGunaControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseFormGunaControlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.CloseFormGunaControlBox.IconColor = System.Drawing.Color.White;
            this.CloseFormGunaControlBox.Location = new System.Drawing.Point(337, 3);
            this.CloseFormGunaControlBox.Name = "CloseFormGunaControlBox";
            this.CloseFormGunaControlBox.Size = new System.Drawing.Size(25, 23);
            this.CloseFormGunaControlBox.TabIndex = 1;
            this.CloseFormGunaControlBox.Click += new System.EventHandler(this.CloseFormGunaControlBox_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.Controls.Add(this.CloseFormGunaControlBox);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.TeamInvitationCodeTextBox);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.ACTPasswordTextBox);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.ACTEmailTextBox);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(365, 203);
            this.guna2Panel1.TabIndex = 2;
            // 
            // ACTEmailTextBox
            // 
            this.ACTEmailTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ACTEmailTextBox.Location = new System.Drawing.Point(12, 64);
            this.ACTEmailTextBox.Name = "ACTEmailTextBox";
            this.ACTEmailTextBox.PlaceholderText = "Enter Your ACT Email Address";
            this.ACTEmailTextBox.Size = new System.Drawing.Size(341, 26);
            this.ACTEmailTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "ACT Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "ACT Password";
            // 
            // ACTPasswordTextBox
            // 
            this.ACTPasswordTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ACTPasswordTextBox.Location = new System.Drawing.Point(12, 115);
            this.ACTPasswordTextBox.Name = "ACTPasswordTextBox";
            this.ACTPasswordTextBox.PasswordChar = '%';
            this.ACTPasswordTextBox.PlaceholderText = "Enter Your ACT Password";
            this.ACTPasswordTextBox.Size = new System.Drawing.Size(341, 26);
            this.ACTPasswordTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Team Invitation Code";
            // 
            // TeamInvitationCodeTextBox
            // 
            this.TeamInvitationCodeTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TeamInvitationCodeTextBox.Location = new System.Drawing.Point(12, 166);
            this.TeamInvitationCodeTextBox.Name = "TeamInvitationCodeTextBox";
            this.TeamInvitationCodeTextBox.PlaceholderText = "Enter a Team Invitation Code";
            this.TeamInvitationCodeTextBox.Size = new System.Drawing.Size(341, 26);
            this.TeamInvitationCodeTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "ACT Studio Login Form";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(365, 267);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.GunaShadowActionsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.GunaShadowActionsPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm GunaBorderlessForm;
        private Guna.UI2.WinForms.Guna2ShadowPanel GunaShadowActionsPanel;
        private Guna.UI2.WinForms.Guna2Button LoginGunaButton;
        private Guna.UI2.WinForms.Guna2ControlBox CloseFormGunaControlBox;
        private Guna.UI2.WinForms.Guna2Button ForgotPasswordGunaButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label3;
        private TextBox TeamInvitationCodeTextBox;
        private Label label2;
        private TextBox ACTPasswordTextBox;
        private Label label1;
        private TextBox ACTEmailTextBox;
        private Label label4;
    }
}