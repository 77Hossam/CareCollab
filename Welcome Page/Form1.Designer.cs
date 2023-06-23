namespace Clinic_System
{
    partial class WelcomePg
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignIn = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Acc_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.Password_icon = new System.Windows.Forms.PictureBox();
            this.Acc_icon = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.WelcomePic = new System.Windows.Forms.PictureBox();
            this.CreateAcc = new ePOSOne.btnProduct.Button_WOC();
            this.Login = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.Password_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Acc_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WelcomePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(229)))));
            this.panel1.Location = new System.Drawing.Point(853, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 722);
            this.panel1.TabIndex = 2;
            // 
            // SignIn
            // 
            this.SignIn.AutoSize = true;
            this.SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(68)))));
            this.SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(229)))));
            this.SignIn.Location = new System.Drawing.Point(923, 65);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(160, 38);
            this.SignIn.TabIndex = 3;
            this.SignIn.Text = "Welcome";
            this.SignIn.Click += new System.EventHandler(this.label1_Click);
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(229)))));
            this.Email.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Email.Location = new System.Drawing.Point(947, 306);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(238, 22);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email address";
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            this.Email.Enter += new System.EventHandler(this.Email_Enter);
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(229)))));
            this.Password.Location = new System.Drawing.Point(947, 405);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(238, 22);
            this.Password.TabIndex = 8;
            this.Password.UseSystemPasswordChar = true;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Acc_Label
            // 
            this.Acc_Label.AutoSize = true;
            this.Acc_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acc_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(68)))));
            this.Acc_Label.Location = new System.Drawing.Point(944, 273);
            this.Acc_Label.Name = "Acc_Label";
            this.Acc_Label.Size = new System.Drawing.Size(82, 22);
            this.Acc_Label.TabIndex = 9;
            this.Acc_Label.Text = "Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(939, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Login your account";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(68)))));
            this.Password_Label.Location = new System.Drawing.Point(947, 372);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(97, 22);
            this.Password_Label.TabIndex = 11;
            this.Password_Label.Text = "Password";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1243, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "O";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Yellow;
            this.btnMinimize.Location = new System.Drawing.Point(1212, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 28);
            this.btnMinimize.TabIndex = 16;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.button3_Click);
            // 
            // Password_icon
            // 
            this.Password_icon.Image = global::Clinic_System.Properties.Resources.Asset_7;
            this.Password_icon.Location = new System.Drawing.Point(911, 399);
            this.Password_icon.Name = "Password_icon";
            this.Password_icon.Size = new System.Drawing.Size(28, 31);
            this.Password_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Password_icon.TabIndex = 13;
            this.Password_icon.TabStop = false;
            // 
            // Acc_icon
            // 
            this.Acc_icon.Image = global::Clinic_System.Properties.Resources.Asset_6;
            this.Acc_icon.Location = new System.Drawing.Point(909, 301);
            this.Acc_icon.Name = "Acc_icon";
            this.Acc_icon.Size = new System.Drawing.Size(30, 30);
            this.Acc_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Acc_icon.TabIndex = 12;
            this.Acc_icon.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Clinic_System.Properties.Resources.Asset_3;
            this.pictureBox2.Location = new System.Drawing.Point(863, 62);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(309, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // WelcomePic
            // 
            this.WelcomePic.Dock = System.Windows.Forms.DockStyle.Left;
            this.WelcomePic.Image = global::Clinic_System.Properties.Resources._8426451_3918491;
            this.WelcomePic.Location = new System.Drawing.Point(0, 0);
            this.WelcomePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WelcomePic.Name = "WelcomePic";
            this.WelcomePic.Size = new System.Drawing.Size(853, 720);
            this.WelcomePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WelcomePic.TabIndex = 0;
            this.WelcomePic.TabStop = false;
            this.WelcomePic.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // CreateAcc
            // 
            this.CreateAcc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(157)))));
            this.CreateAcc.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(157)))));
            this.CreateAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateAcc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(157)))));
            this.CreateAcc.FlatAppearance.BorderSize = 0;
            this.CreateAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(157)))));
            this.CreateAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(157)))));
            this.CreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAcc.Location = new System.Drawing.Point(983, 590);
            this.CreateAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateAcc.Name = "CreateAcc";
            this.CreateAcc.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(157)))));
            this.CreateAcc.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(157)))));
            this.CreateAcc.OnHoverTextColor = System.Drawing.Color.PeachPuff;
            this.CreateAcc.Size = new System.Drawing.Size(171, 28);
            this.CreateAcc.TabIndex = 6;
            this.CreateAcc.Text = "Create Account";
            this.CreateAcc.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(68)))));
            this.CreateAcc.UseVisualStyleBackColor = true;
            this.CreateAcc.Click += new System.EventHandler(this.CreateAcc_Click);
            // 
            // Login
            // 
            this.Login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(157)))));
            this.Login.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(68)))));
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(157)))));
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(157)))));
            this.Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(157)))));
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(157)))));
            this.Login.Location = new System.Drawing.Point(996, 509);
            this.Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login.Name = "Login";
            this.Login.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(157)))));
            this.Login.OnHoverButtonColor = System.Drawing.Color.PeachPuff;
            this.Login.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(229)))));
            this.Login.Size = new System.Drawing.Size(143, 52);
            this.Login.TabIndex = 4;
            this.Login.Text = "Log in";
            this.Login.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(229)))));
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // WelcomePg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(157)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Password_icon);
            this.Controls.Add(this.Acc_icon);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Acc_Label);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.CreateAcc);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.WelcomePic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WelcomePg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Password_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Acc_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WelcomePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WelcomePic;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SignIn;
        private ePOSOne.btnProduct.Button_WOC Login;
        private ePOSOne.btnProduct.Button_WOC CreateAcc;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label Acc_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.PictureBox Acc_icon;
        private System.Windows.Forms.PictureBox Password_icon;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
    }
}

