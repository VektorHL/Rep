namespace UchuWindowsForms_1
{
	partial class RegistrForm
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
			this.topPanel = new System.Windows.Forms.Label();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.back = new System.Windows.Forms.Label();
			this.customerPhoneField = new System.Windows.Forms.TextBox();
			this.buttonRegistr = new System.Windows.Forms.Button();
			this.customerSurnameField = new System.Windows.Forms.TextBox();
			this.customerNameField = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.closeButton = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Font = new System.Drawing.Font("Comic Sans MS", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.topPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(800, 60);
			this.topPanel.TabIndex = 0;
			this.topPanel.Text = "Регистрация клиента";
			this.topPanel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
			this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.Silver;
			this.mainPanel.Controls.Add(this.back);
			this.mainPanel.Controls.Add(this.customerPhoneField);
			this.mainPanel.Controls.Add(this.buttonRegistr);
			this.mainPanel.Controls.Add(this.customerSurnameField);
			this.mainPanel.Controls.Add(this.customerNameField);
			this.mainPanel.Controls.Add(this.panel2);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(800, 450);
			this.mainPanel.TabIndex = 1;
			this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
			this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
			this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
			// 
			// back
			// 
			this.back.AutoSize = true;
			this.back.Location = new System.Drawing.Point(12, 428);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(39, 13);
			this.back.TabIndex = 8;
			this.back.Text = "Назад";
			this.back.Click += new System.EventHandler(this.back_Click);
			this.back.MouseEnter += new System.EventHandler(this.back_MouseEnter);
			// 
			// customerPhoneField
			// 
			this.customerPhoneField.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.customerPhoneField.ForeColor = System.Drawing.Color.Black;
			this.customerPhoneField.Location = new System.Drawing.Point(89, 267);
			this.customerPhoneField.Multiline = true;
			this.customerPhoneField.Name = "customerPhoneField";
			this.customerPhoneField.Size = new System.Drawing.Size(637, 64);
			this.customerPhoneField.TabIndex = 7;
			this.customerPhoneField.MouseEnter += new System.EventHandler(this.customerPhoneField_MouseEnter);
			this.customerPhoneField.MouseLeave += new System.EventHandler(this.customerPhoneField_MouseLeave);
			// 
			// buttonRegistr
			// 
			this.buttonRegistr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(156)))), ((int)(((byte)(47)))));
			this.buttonRegistr.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonRegistr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(219)))), ((int)(((byte)(58)))));
			this.buttonRegistr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(30)))));
			this.buttonRegistr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(179)))), ((int)(((byte)(32)))));
			this.buttonRegistr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRegistr.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonRegistr.ForeColor = System.Drawing.Color.White;
			this.buttonRegistr.Location = new System.Drawing.Point(213, 384);
			this.buttonRegistr.Name = "buttonRegistr";
			this.buttonRegistr.Size = new System.Drawing.Size(373, 41);
			this.buttonRegistr.TabIndex = 6;
			this.buttonRegistr.Text = "Зарегистрировать";
			this.buttonRegistr.UseVisualStyleBackColor = false;
			this.buttonRegistr.Click += new System.EventHandler(this.buttonRegistr_Click);
			// 
			// customerSurnameField
			// 
			this.customerSurnameField.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.customerSurnameField.Location = new System.Drawing.Point(89, 181);
			this.customerSurnameField.Name = "customerSurnameField";
			this.customerSurnameField.ShortcutsEnabled = false;
			this.customerSurnameField.Size = new System.Drawing.Size(637, 63);
			this.customerSurnameField.TabIndex = 5;
			this.customerSurnameField.MouseEnter += new System.EventHandler(this.customerSurnameField_MouseEnter);
			this.customerSurnameField.MouseLeave += new System.EventHandler(this.customerSurnameField_MouseLeave);
			// 
			// customerNameField
			// 
			this.customerNameField.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.customerNameField.ForeColor = System.Drawing.Color.Black;
			this.customerNameField.Location = new System.Drawing.Point(89, 96);
			this.customerNameField.Multiline = true;
			this.customerNameField.Name = "customerNameField";
			this.customerNameField.Size = new System.Drawing.Size(637, 64);
			this.customerNameField.TabIndex = 3;
			this.customerNameField.MouseEnter += new System.EventHandler(this.customerNameField_MouseEnter);
			this.customerNameField.MouseLeave += new System.EventHandler(this.customerNameField_MouseLeave);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Gray;
			this.panel2.Controls.Add(this.closeButton);
			this.panel2.Controls.Add(this.topPanel);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(800, 75);
			this.panel2.TabIndex = 0;
			// 
			// closeButton
			// 
			this.closeButton.AutoSize = true;
			this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.closeButton.ForeColor = System.Drawing.Color.White;
			this.closeButton.Location = new System.Drawing.Point(776, 0);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(24, 29);
			this.closeButton.TabIndex = 1;
			this.closeButton.Text = "x";
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
			this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
			// 
			// RegistrForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.mainPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RegistrForm";
			this.Text = "RegistrForm";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label topPanel;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Button buttonRegistr;
		private System.Windows.Forms.TextBox customerSurnameField;
		private System.Windows.Forms.TextBox customerNameField;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label closeButton;
		private System.Windows.Forms.TextBox customerPhoneField;
		private System.Windows.Forms.Label back;
	}
}