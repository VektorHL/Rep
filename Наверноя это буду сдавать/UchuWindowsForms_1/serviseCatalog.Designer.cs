namespace UchuWindowsForms_1
{
	partial class serviseCatalog
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
			this.canUsedLabel = new System.Windows.Forms.Label();
			this.surviseIdLabel = new System.Windows.Forms.Label();
			this.cardIdLabel = new System.Windows.Forms.Label();
			this.canUsedField = new System.Windows.Forms.TextBox();
			this.surviseIdField = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priseSev = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.back = new System.Windows.Forms.Label();
			this.buttonAddServise = new System.Windows.Forms.Button();
			this.cardIdField = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.closeButton = new System.Windows.Forms.Label();
			this.topPanel = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.Silver;
			this.mainPanel.Controls.Add(this.canUsedLabel);
			this.mainPanel.Controls.Add(this.surviseIdLabel);
			this.mainPanel.Controls.Add(this.cardIdLabel);
			this.mainPanel.Controls.Add(this.canUsedField);
			this.mainPanel.Controls.Add(this.surviseIdField);
			this.mainPanel.Controls.Add(this.dataGridView1);
			this.mainPanel.Controls.Add(this.back);
			this.mainPanel.Controls.Add(this.buttonAddServise);
			this.mainPanel.Controls.Add(this.cardIdField);
			this.mainPanel.Controls.Add(this.panel2);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(566, 392);
			this.mainPanel.TabIndex = 2;
			// 
			// canUsedLabel
			// 
			this.canUsedLabel.AutoSize = true;
			this.canUsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.canUsedLabel.Location = new System.Drawing.Point(375, 295);
			this.canUsedLabel.Name = "canUsedLabel";
			this.canUsedLabel.Size = new System.Drawing.Size(191, 20);
			this.canUsedLabel.TabIndex = 15;
			this.canUsedLabel.Text = "Колл-во использований";
			// 
			// surviseIdLabel
			// 
			this.surviseIdLabel.AutoSize = true;
			this.surviseIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.surviseIdLabel.Location = new System.Drawing.Point(375, 184);
			this.surviseIdLabel.Name = "surviseIdLabel";
			this.surviseIdLabel.Size = new System.Drawing.Size(79, 20);
			this.surviseIdLabel.TabIndex = 14;
			this.surviseIdLabel.Text = "№ Услуги";
			// 
			// cardIdLabel
			// 
			this.cardIdLabel.AutoSize = true;
			this.cardIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cardIdLabel.Location = new System.Drawing.Point(375, 81);
			this.cardIdLabel.Name = "cardIdLabel";
			this.cardIdLabel.Size = new System.Drawing.Size(109, 20);
			this.cardIdLabel.TabIndex = 13;
			this.cardIdLabel.Text = "Номер карты";
			// 
			// canUsedField
			// 
			this.canUsedField.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.canUsedField.ForeColor = System.Drawing.Color.Black;
			this.canUsedField.Location = new System.Drawing.Point(379, 331);
			this.canUsedField.Multiline = true;
			this.canUsedField.Name = "canUsedField";
			this.canUsedField.Size = new System.Drawing.Size(83, 57);
			this.canUsedField.TabIndex = 12;
			// 
			// surviseIdField
			// 
			this.surviseIdField.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.surviseIdField.ForeColor = System.Drawing.Color.Black;
			this.surviseIdField.Location = new System.Drawing.Point(379, 223);
			this.surviseIdField.Multiline = true;
			this.surviseIdField.Name = "surviseIdField";
			this.surviseIdField.Size = new System.Drawing.Size(83, 57);
			this.surviseIdField.TabIndex = 11;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nameSer,
            this.priseSev});
			this.dataGridView1.Location = new System.Drawing.Point(10, 81);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(346, 211);
			this.dataGridView1.TabIndex = 10;
			// 
			// id
			// 
			this.id.HeaderText = "id";
			this.id.Name = "id";
			// 
			// nameSer
			// 
			this.nameSer.HeaderText = "Название услуги";
			this.nameSer.Name = "nameSer";
			// 
			// priseSev
			// 
			this.priseSev.HeaderText = "Цена услуги";
			this.priseSev.Name = "priseSev";
			// 
			// back
			// 
			this.back.AutoSize = true;
			this.back.Location = new System.Drawing.Point(7, 375);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(39, 13);
			this.back.TabIndex = 9;
			this.back.Text = "Назад";
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// buttonAddServise
			// 
			this.buttonAddServise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(156)))), ((int)(((byte)(47)))));
			this.buttonAddServise.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAddServise.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(219)))), ((int)(((byte)(58)))));
			this.buttonAddServise.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(30)))));
			this.buttonAddServise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(179)))), ((int)(((byte)(32)))));
			this.buttonAddServise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddServise.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAddServise.ForeColor = System.Drawing.Color.White;
			this.buttonAddServise.Location = new System.Drawing.Point(10, 298);
			this.buttonAddServise.Name = "buttonAddServise";
			this.buttonAddServise.Size = new System.Drawing.Size(346, 41);
			this.buttonAddServise.TabIndex = 6;
			this.buttonAddServise.Text = "Добавить услугу";
			this.buttonAddServise.UseVisualStyleBackColor = false;
			this.buttonAddServise.Click += new System.EventHandler(this.buttonAddServise_Click);
			// 
			// cardIdField
			// 
			this.cardIdField.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cardIdField.ForeColor = System.Drawing.Color.Black;
			this.cardIdField.Location = new System.Drawing.Point(379, 104);
			this.cardIdField.Multiline = true;
			this.cardIdField.Name = "cardIdField";
			this.cardIdField.Size = new System.Drawing.Size(83, 57);
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
			this.panel2.Size = new System.Drawing.Size(566, 75);
			this.panel2.TabIndex = 0;
			// 
			// closeButton
			// 
			this.closeButton.AutoSize = true;
			this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.closeButton.ForeColor = System.Drawing.Color.White;
			this.closeButton.Location = new System.Drawing.Point(543, 0);
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
			this.topPanel.Size = new System.Drawing.Size(566, 60);
			this.topPanel.TabIndex = 0;
			this.topPanel.Text = "Каталог услуг";
			this.topPanel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// serviseCatalog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 392);
			this.Controls.Add(this.mainPanel);
			this.Name = "serviseCatalog";
			this.Text = "serviseCatalog";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Button buttonAddServise;
		private System.Windows.Forms.TextBox cardIdField;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label closeButton;
		private System.Windows.Forms.Label topPanel;
		private System.Windows.Forms.Label back;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameSer;
		private System.Windows.Forms.DataGridViewTextBoxColumn priseSev;
		private System.Windows.Forms.Label canUsedLabel;
		private System.Windows.Forms.Label surviseIdLabel;
		private System.Windows.Forms.Label cardIdLabel;
		private System.Windows.Forms.TextBox canUsedField;
		private System.Windows.Forms.TextBox surviseIdField;
	}
}