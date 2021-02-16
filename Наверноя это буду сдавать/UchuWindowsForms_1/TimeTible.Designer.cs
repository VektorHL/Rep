namespace UchuWindowsForms_1
{
	partial class TimeTible
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
			this.disciplineSearchLabel = new System.Windows.Forms.Label();
			this.disciplineSearchField = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.discipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.finish = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.trainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dayOfWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.back = new System.Windows.Forms.Label();
			this.disciplineSearchServise = new System.Windows.Forms.Button();
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
			this.mainPanel.Controls.Add(this.disciplineSearchLabel);
			this.mainPanel.Controls.Add(this.disciplineSearchField);
			this.mainPanel.Controls.Add(this.dataGridView1);
			this.mainPanel.Controls.Add(this.back);
			this.mainPanel.Controls.Add(this.disciplineSearchServise);
			this.mainPanel.Controls.Add(this.panel2);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(666, 462);
			this.mainPanel.TabIndex = 3;
			// 
			// disciplineSearchLabel
			// 
			this.disciplineSearchLabel.AutoSize = true;
			this.disciplineSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.disciplineSearchLabel.Location = new System.Drawing.Point(6, 331);
			this.disciplineSearchLabel.Name = "disciplineSearchLabel";
			this.disciplineSearchLabel.Size = new System.Drawing.Size(173, 20);
			this.disciplineSearchLabel.TabIndex = 14;
			this.disciplineSearchLabel.Text = "Поиск по дисциплине";
			// 
			// disciplineSearchField
			// 
			this.disciplineSearchField.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.disciplineSearchField.ForeColor = System.Drawing.Color.Black;
			this.disciplineSearchField.Location = new System.Drawing.Point(10, 354);
			this.disciplineSearchField.Multiline = true;
			this.disciplineSearchField.Name = "disciplineSearchField";
			this.disciplineSearchField.Size = new System.Drawing.Size(234, 57);
			this.disciplineSearchField.TabIndex = 11;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.discipline,
            this.start,
            this.finish,
            this.trainer,
            this.dayOfWeek});
			this.dataGridView1.Location = new System.Drawing.Point(10, 81);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(645, 247);
			this.dataGridView1.TabIndex = 10;
			// 
			// id
			// 
			this.id.HeaderText = "id";
			this.id.Name = "id";
			// 
			// discipline
			// 
			this.discipline.HeaderText = "Дисциплина";
			this.discipline.Name = "discipline";
			// 
			// start
			// 
			this.start.HeaderText = "Начало";
			this.start.Name = "start";
			// 
			// finish
			// 
			this.finish.HeaderText = "Конец";
			this.finish.Name = "finish";
			// 
			// trainer
			// 
			this.trainer.HeaderText = "Ведущий тренер";
			this.trainer.Name = "trainer";
			// 
			// dayOfWeek
			// 
			this.dayOfWeek.HeaderText = "День недели";
			this.dayOfWeek.Name = "dayOfWeek";
			// 
			// back
			// 
			this.back.AutoSize = true;
			this.back.Location = new System.Drawing.Point(3, 440);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(39, 13);
			this.back.TabIndex = 9;
			this.back.Text = "Назад";
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// disciplineSearchServise
			// 
			this.disciplineSearchServise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(156)))), ((int)(((byte)(47)))));
			this.disciplineSearchServise.Cursor = System.Windows.Forms.Cursors.Hand;
			this.disciplineSearchServise.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(219)))), ((int)(((byte)(58)))));
			this.disciplineSearchServise.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(30)))));
			this.disciplineSearchServise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(179)))), ((int)(((byte)(32)))));
			this.disciplineSearchServise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.disciplineSearchServise.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.disciplineSearchServise.ForeColor = System.Drawing.Color.White;
			this.disciplineSearchServise.Location = new System.Drawing.Point(286, 354);
			this.disciplineSearchServise.Name = "disciplineSearchServise";
			this.disciplineSearchServise.Size = new System.Drawing.Size(207, 57);
			this.disciplineSearchServise.TabIndex = 6;
			this.disciplineSearchServise.Text = "Поиск";
			this.disciplineSearchServise.UseVisualStyleBackColor = false;
			this.disciplineSearchServise.Click += new System.EventHandler(this.disciplineSearchServise_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Gray;
			this.panel2.Controls.Add(this.closeButton);
			this.panel2.Controls.Add(this.topPanel);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(666, 75);
			this.panel2.TabIndex = 0;
			// 
			// closeButton
			// 
			this.closeButton.AutoSize = true;
			this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.closeButton.ForeColor = System.Drawing.Color.White;
			this.closeButton.Location = new System.Drawing.Point(639, 0);
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
			this.topPanel.Size = new System.Drawing.Size(666, 60);
			this.topPanel.TabIndex = 0;
			this.topPanel.Text = "Расписание тренеровок";
			this.topPanel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// TimeTible
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 462);
			this.Controls.Add(this.mainPanel);
			this.Name = "TimeTible";
			this.Text = "groupTraining";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Label disciplineSearchLabel;
		private System.Windows.Forms.TextBox disciplineSearchField;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label back;
		private System.Windows.Forms.Button disciplineSearchServise;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label closeButton;
		private System.Windows.Forms.Label topPanel;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn discipline;
		private System.Windows.Forms.DataGridViewTextBoxColumn start;
		private System.Windows.Forms.DataGridViewTextBoxColumn finish;
		private System.Windows.Forms.DataGridViewTextBoxColumn trainer;
		private System.Windows.Forms.DataGridViewTextBoxColumn dayOfWeek;
	}
}