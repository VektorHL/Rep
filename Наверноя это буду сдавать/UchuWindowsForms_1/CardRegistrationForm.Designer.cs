namespace UchuWindowsForms_1
{
	partial class CardRegistrationForm
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
			this.mainPanel = new System.Windows.Forms.Panel();
			this.back = new System.Windows.Forms.Label();
			this.cardPrice = new System.Windows.Forms.Label();
			this.clientId = new System.Windows.Forms.Label();
			this.cardPriceTop = new System.Windows.Forms.Label();
			this.card_VIP_check = new System.Windows.Forms.CheckBox();
			this.buttonRegistr = new System.Windows.Forms.Button();
			this.customerPhoneField = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.closeButton = new System.Windows.Forms.Label();
			this.topPanel = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.Silver;
			this.mainPanel.Controls.Add(this.back);
			this.mainPanel.Controls.Add(this.cardPrice);
			this.mainPanel.Controls.Add(this.clientId);
			this.mainPanel.Controls.Add(this.cardPriceTop);
			this.mainPanel.Controls.Add(this.card_VIP_check);
			this.mainPanel.Controls.Add(this.buttonRegistr);
			this.mainPanel.Controls.Add(this.customerPhoneField);
			this.mainPanel.Controls.Add(this.panel2);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(837, 391);
			this.mainPanel.TabIndex = 2;
			// 
			// back
			// 
			this.back.AutoSize = true;
			this.back.Location = new System.Drawing.Point(7, 369);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(39, 13);
			this.back.TabIndex = 9;
			this.back.Text = "Назад";
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// cardPrice
			// 
			this.cardPrice.AutoSize = true;
			this.cardPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cardPrice.Location = new System.Drawing.Point(563, 187);
			this.cardPrice.Name = "cardPrice";
			this.cardPrice.Size = new System.Drawing.Size(237, 39);
			this.cardPrice.TabIndex = 11;
			this.cardPrice.Text = "15000 рублей";
			// 
			// clientId
			// 
			this.clientId.AutoSize = true;
			this.clientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.clientId.Location = new System.Drawing.Point(12, 120);
			this.clientId.Name = "clientId";
			this.clientId.Size = new System.Drawing.Size(341, 31);
			this.clientId.TabIndex = 10;
			this.clientId.Text = "Номер телефона Клиента";

			// 
			// cardPriceTop
			// 
			this.cardPriceTop.AutoSize = true;
			this.cardPriceTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cardPriceTop.Location = new System.Drawing.Point(602, 120);
			this.cardPriceTop.Name = "cardPriceTop";
			this.cardPriceTop.Size = new System.Drawing.Size(165, 31);
			this.cardPriceTop.TabIndex = 9;
			this.cardPriceTop.Text = "Цена Карты";
			// 
			// card_VIP_check
			// 
			this.card_VIP_check.AutoSize = true;
			this.card_VIP_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.card_VIP_check.Location = new System.Drawing.Point(317, 187);
			this.card_VIP_check.Name = "card_VIP_check";
			this.card_VIP_check.Size = new System.Drawing.Size(196, 43);
			this.card_VIP_check.TabIndex = 8;
			this.card_VIP_check.Text = "VIP Карта";
			this.card_VIP_check.UseVisualStyleBackColor = true;
			this.card_VIP_check.CheckedChanged += new System.EventHandler(this.card_VIP_check_CheckedChanged);
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
			this.buttonRegistr.Location = new System.Drawing.Point(217, 338);
			this.buttonRegistr.Name = "buttonRegistr";
			this.buttonRegistr.Size = new System.Drawing.Size(373, 41);
			this.buttonRegistr.TabIndex = 6;
			this.buttonRegistr.Text = "Привязать карту";
			this.buttonRegistr.UseVisualStyleBackColor = false;
			this.buttonRegistr.Click += new System.EventHandler(this.buttonRegistr_Click);
			// 
			// customerPhoneField
			// 
			this.customerPhoneField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.customerPhoneField.ForeColor = System.Drawing.Color.Black;
			this.customerPhoneField.Location = new System.Drawing.Point(10, 187);
			this.customerPhoneField.Multiline = true;
			this.customerPhoneField.Name = "customerPhoneField";
			this.customerPhoneField.Size = new System.Drawing.Size(276, 44);
			this.customerPhoneField.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Gray;
			this.panel2.Controls.Add(this.closeButton);
			this.panel2.Controls.Add(this.topPanel);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(837, 75);
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
			// 
			// topPanel
			// 
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Font = new System.Drawing.Font("Comic Sans MS", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.topPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(837, 60);
			this.topPanel.TabIndex = 0;
			this.topPanel.Text = "Регистрация и привязка карты";
			this.topPanel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
			this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
			// 
			// CardRegistrationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 391);
			this.Controls.Add(this.mainPanel);
			this.Name = "CardRegistrationForm";
			this.Text = "cardRegistration";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Button buttonRegistr;
		private System.Windows.Forms.TextBox customerPhoneField;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label closeButton;
		private System.Windows.Forms.Label topPanel;
		private System.Windows.Forms.Label clientId;
		private System.Windows.Forms.Label cardPriceTop;
		private System.Windows.Forms.CheckBox card_VIP_check;
		private System.Windows.Forms.Label cardPrice;
		private System.Windows.Forms.Label back;
	}
}