namespace UchuWindowsForms_1
{
	partial class visitCentr
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
			this.cardID = new System.Windows.Forms.Label();
			this.buttonVisit = new System.Windows.Forms.Button();
			this.cardIdField = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.closeButton = new System.Windows.Forms.Label();
			this.topPanel = new System.Windows.Forms.Label();
			this.back = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.Silver;
			this.mainPanel.Controls.Add(this.back);
			this.mainPanel.Controls.Add(this.cardID);
			this.mainPanel.Controls.Add(this.buttonVisit);
			this.mainPanel.Controls.Add(this.cardIdField);
			this.mainPanel.Controls.Add(this.panel2);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(594, 252);
			this.mainPanel.TabIndex = 1;
			// 
			// cardID
			// 
			this.cardID.AutoSize = true;
			this.cardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cardID.Location = new System.Drawing.Point(58, 114);
			this.cardID.Name = "cardID";
			this.cardID.Size = new System.Drawing.Size(57, 20);
			this.cardID.TabIndex = 7;
			this.cardID.Text = "cardID";
			// 
			// buttonVisit
			// 
			this.buttonVisit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(156)))), ((int)(((byte)(47)))));
			this.buttonVisit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonVisit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(219)))), ((int)(((byte)(58)))));
			this.buttonVisit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(30)))));
			this.buttonVisit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(179)))), ((int)(((byte)(32)))));
			this.buttonVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonVisit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonVisit.ForeColor = System.Drawing.Color.White;
			this.buttonVisit.Location = new System.Drawing.Point(301, 156);
			this.buttonVisit.Name = "buttonVisit";
			this.buttonVisit.Size = new System.Drawing.Size(157, 41);
			this.buttonVisit.TabIndex = 6;
			this.buttonVisit.Text = "Посетить";
			this.buttonVisit.UseVisualStyleBackColor = false;
			this.buttonVisit.Click += new System.EventHandler(this.buttonVisit_Click);
			// 
			// cardIdField
			// 
			this.cardIdField.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cardIdField.ForeColor = System.Drawing.Color.Black;
			this.cardIdField.Location = new System.Drawing.Point(32, 137);
			this.cardIdField.Multiline = true;
			this.cardIdField.Name = "cardIdField";
			this.cardIdField.Size = new System.Drawing.Size(245, 64);
			this.cardIdField.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Gray;
			this.panel2.Controls.Add(this.closeButton);
			this.panel2.Controls.Add(this.topPanel);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(594, 75);
			this.panel2.TabIndex = 0;
			// 
			// closeButton
			// 
			this.closeButton.AutoSize = true;
			this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.closeButton.ForeColor = System.Drawing.Color.White;
			this.closeButton.Location = new System.Drawing.Point(570, 0);
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
			this.topPanel.Size = new System.Drawing.Size(594, 60);
			this.topPanel.TabIndex = 0;
			this.topPanel.Text = "Посещение центра";
			this.topPanel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// back
			// 
			this.back.AutoSize = true;
			this.back.Location = new System.Drawing.Point(3, 230);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(39, 13);
			this.back.TabIndex = 10;
			this.back.Text = "Назад";
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// visitCentr
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 252);
			this.Controls.Add(this.mainPanel);
			this.Name = "visitCentr";
			this.Text = "visitCentr";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Button buttonVisit;
		private System.Windows.Forms.TextBox cardIdField;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label closeButton;
		private System.Windows.Forms.Label topPanel;
		private System.Windows.Forms.Label cardID;
		private System.Windows.Forms.Label back;
	}
}