namespace UchuWindowsForms_1
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.closeButton = new System.Windows.Forms.Label();
			this.topPanel = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.loginField = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.passField = new System.Windows.Forms.TextBox();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Gray;
			this.panel2.Controls.Add(this.closeButton);
			this.panel2.Controls.Add(this.topPanel);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(356, 75);
			this.panel2.TabIndex = 0;
			// 
			// closeButton
			// 
			this.closeButton.AutoSize = true;
			this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.closeButton.ForeColor = System.Drawing.Color.White;
			this.closeButton.Location = new System.Drawing.Point(332, 0);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(24, 29);
			this.closeButton.TabIndex = 1;
			this.closeButton.Text = "x";
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
			this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
			// 
			// topPanel
			// 
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Font = new System.Drawing.Font("Comic Sans MS", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.topPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(356, 60);
			this.topPanel.TabIndex = 0;
			this.topPanel.Text = "Авторизация";
			this.topPanel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
			this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::UchuWindowsForms_1.Properties.Resources.user;
			this.pictureBox1.InitialImage = global::UchuWindowsForms_1.Properties.Resources.user;
			this.pictureBox1.Location = new System.Drawing.Point(22, 125);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 64);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// loginField
			// 
			this.loginField.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.loginField.ForeColor = System.Drawing.Color.Black;
			this.loginField.Location = new System.Drawing.Point(84, 125);
			this.loginField.Multiline = true;
			this.loginField.Name = "loginField";
			this.loginField.Size = new System.Drawing.Size(245, 64);
			this.loginField.TabIndex = 3;
			this.loginField.TextChanged += new System.EventHandler(this.loginField_TextChanged);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::UchuWindowsForms_1.Properties.Resources._lock;
			this.pictureBox2.InitialImage = global::UchuWindowsForms_1.Properties.Resources.user;
			this.pictureBox2.Location = new System.Drawing.Point(22, 243);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(64, 64);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// passField
			// 
			this.passField.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.passField.Location = new System.Drawing.Point(84, 243);
			this.passField.Name = "passField";
			this.passField.PasswordChar = '*';
			this.passField.Size = new System.Drawing.Size(245, 63);
			this.passField.TabIndex = 5;
			this.passField.UseSystemPasswordChar = true;
			// 
			// buttonLogin
			// 
			this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(156)))), ((int)(((byte)(47)))));
			this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(219)))), ((int)(((byte)(58)))));
			this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(30)))));
			this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(179)))), ((int)(((byte)(32)))));
			this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLogin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonLogin.ForeColor = System.Drawing.Color.White;
			this.buttonLogin.Location = new System.Drawing.Point(99, 365);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(157, 41);
			this.buttonLogin.TabIndex = 6;
			this.buttonLogin.Text = "Войти";
			this.buttonLogin.UseVisualStyleBackColor = false;
			this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.Silver;
			this.mainPanel.Controls.Add(this.buttonLogin);
			this.mainPanel.Controls.Add(this.passField);
			this.mainPanel.Controls.Add(this.pictureBox2);
			this.mainPanel.Controls.Add(this.loginField);
			this.mainPanel.Controls.Add(this.pictureBox1);
			this.mainPanel.Controls.Add(this.panel2);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(356, 450);
			this.mainPanel.TabIndex = 0;
			this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
			this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 450);
			this.Controls.Add(this.mainPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginForm";
			this.Text = "LginForm";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label closeButton;
		private System.Windows.Forms.Label topPanel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox loginField;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox passField;
		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Panel mainPanel;
	}
}