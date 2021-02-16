namespace UchuWindowsForms_1
{
	partial class useServise
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
			this.useServisebutton = new System.Windows.Forms.Button();
			this.servisIdFieldBotm = new System.Windows.Forms.TextBox();
			this.serviseIdLabelBotm = new System.Windows.Forms.Label();
			this.cardIdLabelBotm = new System.Windows.Forms.Label();
			this.cardIdFieldBotm = new System.Windows.Forms.TextBox();
			this.useServiseLable = new System.Windows.Forms.Label();
			this.cardIdLabel = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idServise = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.used = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CanBeUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idCardСolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.back = new System.Windows.Forms.Label();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.cardIdField = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.closeButton = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			this.topPanel.Size = new System.Drawing.Size(752, 60);
			this.topPanel.TabIndex = 0;
			this.topPanel.Text = "Список услуг клиентов";
			this.topPanel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.Silver;
			this.mainPanel.Controls.Add(this.useServisebutton);
			this.mainPanel.Controls.Add(this.servisIdFieldBotm);
			this.mainPanel.Controls.Add(this.serviseIdLabelBotm);
			this.mainPanel.Controls.Add(this.cardIdLabelBotm);
			this.mainPanel.Controls.Add(this.cardIdFieldBotm);
			this.mainPanel.Controls.Add(this.useServiseLable);
			this.mainPanel.Controls.Add(this.cardIdLabel);
			this.mainPanel.Controls.Add(this.dataGridView1);
			this.mainPanel.Controls.Add(this.back);
			this.mainPanel.Controls.Add(this.buttonSearch);
			this.mainPanel.Controls.Add(this.cardIdField);
			this.mainPanel.Controls.Add(this.panel2);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(752, 451);
			this.mainPanel.TabIndex = 3;
			// 
			// useServisebutton
			// 
			this.useServisebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(156)))), ((int)(((byte)(47)))));
			this.useServisebutton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.useServisebutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(219)))), ((int)(((byte)(58)))));
			this.useServisebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(30)))));
			this.useServisebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(179)))), ((int)(((byte)(32)))));
			this.useServisebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.useServisebutton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.useServisebutton.ForeColor = System.Drawing.Color.White;
			this.useServisebutton.Location = new System.Drawing.Point(469, 371);
			this.useServisebutton.Name = "useServisebutton";
			this.useServisebutton.Size = new System.Drawing.Size(277, 54);
			this.useServisebutton.TabIndex = 19;
			this.useServisebutton.Text = "Использовать услугу";
			this.useServisebutton.UseVisualStyleBackColor = false;
			this.useServisebutton.Click += new System.EventHandler(this.useServisebutton_Click);
			// 
			// servisIdFieldBotm
			// 
			this.servisIdFieldBotm.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.servisIdFieldBotm.ForeColor = System.Drawing.Color.Black;
			this.servisIdFieldBotm.Location = new System.Drawing.Point(17, 371);
			this.servisIdFieldBotm.Multiline = true;
			this.servisIdFieldBotm.Name = "servisIdFieldBotm";
			this.servisIdFieldBotm.Size = new System.Drawing.Size(184, 54);
			this.servisIdFieldBotm.TabIndex = 18;
			// 
			// serviseIdLabelBotm
			// 
			this.serviseIdLabelBotm.AutoSize = true;
			this.serviseIdLabelBotm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.serviseIdLabelBotm.Location = new System.Drawing.Point(13, 345);
			this.serviseIdLabelBotm.Name = "serviseIdLabelBotm";
			this.serviseIdLabelBotm.Size = new System.Drawing.Size(111, 20);
			this.serviseIdLabelBotm.TabIndex = 17;
			this.serviseIdLabelBotm.Text = "Номер услуги";
			// 
			// cardIdLabelBotm
			// 
			this.cardIdLabelBotm.AutoSize = true;
			this.cardIdLabelBotm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cardIdLabelBotm.Location = new System.Drawing.Point(251, 345);
			this.cardIdLabelBotm.Name = "cardIdLabelBotm";
			this.cardIdLabelBotm.Size = new System.Drawing.Size(109, 20);
			this.cardIdLabelBotm.TabIndex = 16;
			this.cardIdLabelBotm.Text = "Номер карты";
			// 
			// cardIdFieldBotm
			// 
			this.cardIdFieldBotm.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cardIdFieldBotm.ForeColor = System.Drawing.Color.Black;
			this.cardIdFieldBotm.Location = new System.Drawing.Point(242, 371);
			this.cardIdFieldBotm.Multiline = true;
			this.cardIdFieldBotm.Name = "cardIdFieldBotm";
			this.cardIdFieldBotm.Size = new System.Drawing.Size(184, 54);
			this.cardIdFieldBotm.TabIndex = 15;
			// 
			// useServiseLable
			// 
			this.useServiseLable.AutoSize = true;
			this.useServiseLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.useServiseLable.Location = new System.Drawing.Point(12, 306);
			this.useServiseLable.Name = "useServiseLable";
			this.useServiseLable.Size = new System.Drawing.Size(211, 25);
			this.useServiseLable.TabIndex = 14;
			this.useServiseLable.Text = "Используйте услугу";
			// 
			// cardIdLabel
			// 
			this.cardIdLabel.AutoSize = true;
			this.cardIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cardIdLabel.Location = new System.Drawing.Point(558, 81);
			this.cardIdLabel.Name = "cardIdLabel";
			this.cardIdLabel.Size = new System.Drawing.Size(185, 20);
			this.cardIdLabel.TabIndex = 13;
			this.cardIdLabel.Text = "Поиск по номеру карты";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServise,
            this.nameSer,
            this.used,
            this.CanBeUsed,
            this.idCardСolumn});
			this.dataGridView1.Location = new System.Drawing.Point(10, 81);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(546, 213);
			this.dataGridView1.TabIndex = 10;
			// 
			// idServise
			// 
			this.idServise.HeaderText = "Номер услуги";
			this.idServise.Name = "idServise";
			// 
			// nameSer
			// 
			this.nameSer.HeaderText = "Название услуги";
			this.nameSer.Name = "nameSer";
			// 
			// used
			// 
			this.used.HeaderText = "Использаванно";
			this.used.Name = "used";
			// 
			// CanBeUsed
			// 
			this.CanBeUsed.HeaderText = "Осталось использований";
			this.CanBeUsed.Name = "CanBeUsed";
			// 
			// idCardСolumn
			// 
			this.idCardСolumn.HeaderText = "Номер карты клиента";
			this.idCardСolumn.Name = "idCardСolumn";
			// 
			// back
			// 
			this.back.AutoSize = true;
			this.back.Location = new System.Drawing.Point(3, 429);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(39, 13);
			this.back.TabIndex = 9;
			this.back.Text = "Назад";
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// buttonSearch
			// 
			this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(156)))), ((int)(((byte)(47)))));
			this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(219)))), ((int)(((byte)(58)))));
			this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(30)))));
			this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(179)))), ((int)(((byte)(32)))));
			this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSearch.ForeColor = System.Drawing.Color.White;
			this.buttonSearch.Location = new System.Drawing.Point(562, 164);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(184, 41);
			this.buttonSearch.TabIndex = 6;
			this.buttonSearch.Text = "Найти";
			this.buttonSearch.UseVisualStyleBackColor = false;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// cardIdField
			// 
			this.cardIdField.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cardIdField.ForeColor = System.Drawing.Color.Black;
			this.cardIdField.Location = new System.Drawing.Point(562, 104);
			this.cardIdField.Multiline = true;
			this.cardIdField.Name = "cardIdField";
			this.cardIdField.Size = new System.Drawing.Size(184, 54);
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
			this.panel2.Size = new System.Drawing.Size(752, 75);
			this.panel2.TabIndex = 0;
			// 
			// closeButton
			// 
			this.closeButton.AutoSize = true;
			this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.closeButton.ForeColor = System.Drawing.Color.White;
			this.closeButton.Location = new System.Drawing.Point(728, 0);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(24, 29);
			this.closeButton.TabIndex = 1;
			this.closeButton.Text = "x";
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// useServise
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(752, 451);
			this.Controls.Add(this.mainPanel);
			this.Name = "useServise";
			this.Text = "useServise";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label topPanel;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Label cardIdLabel;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label back;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.TextBox cardIdField;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label closeButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn idServise;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameSer;
		private System.Windows.Forms.DataGridViewTextBoxColumn used;
		private System.Windows.Forms.DataGridViewTextBoxColumn CanBeUsed;
		private System.Windows.Forms.DataGridViewTextBoxColumn idCardСolumn;
		private System.Windows.Forms.Button useServisebutton;
		private System.Windows.Forms.TextBox servisIdFieldBotm;
		private System.Windows.Forms.Label serviseIdLabelBotm;
		private System.Windows.Forms.Label cardIdLabelBotm;
		private System.Windows.Forms.TextBox cardIdFieldBotm;
		private System.Windows.Forms.Label useServiseLable;
	}
}