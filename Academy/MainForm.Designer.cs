namespace Academy
{
	partial class MainForm
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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageStudents = new System.Windows.Forms.TabPage();
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.tabPageDirections = new System.Windows.Forms.TabPage();
			this.dgvDirections = new System.Windows.Forms.DataGridView();
			this.tabPageDisciplins = new System.Windows.Forms.TabPage();
			this.tabPageTeachers = new System.Windows.Forms.TabPage();
			this.dgvStudents = new System.Windows.Forms.DataGridView();
			this.dgvGroups = new System.Windows.Forms.DataGridView();
			this.dgvDisciplins = new System.Windows.Forms.DataGridView();
			this.dgvTeachers = new System.Windows.Forms.DataGridView();
			this.tabControl.SuspendLayout();
			this.tabPageStudents.SuspendLayout();
			this.tabPageGroups.SuspendLayout();
			this.tabPageDirections.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).BeginInit();
			this.tabPageDisciplins.SuspendLayout();
			this.tabPageTeachers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisciplins)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Location = new System.Drawing.Point(0, 318);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(526, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip";
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageStudents);
			this.tabControl.Controls.Add(this.tabPageGroups);
			this.tabControl.Controls.Add(this.tabPageDirections);
			this.tabControl.Controls.Add(this.tabPageDisciplins);
			this.tabControl.Controls.Add(this.tabPageTeachers);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(526, 318);
			this.tabControl.TabIndex = 1;
			// 
			// tabPageStudents
			// 
			this.tabPageStudents.Controls.Add(this.dgvStudents);
			this.tabPageStudents.Location = new System.Drawing.Point(4, 25);
			this.tabPageStudents.Name = "tabPageStudents";
			this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStudents.Size = new System.Drawing.Size(518, 289);
			this.tabPageStudents.TabIndex = 0;
			this.tabPageStudents.Text = "Students";
			this.tabPageStudents.UseVisualStyleBackColor = true;
			// 
			// tabPageGroups
			// 
			this.tabPageGroups.Controls.Add(this.dgvGroups);
			this.tabPageGroups.Location = new System.Drawing.Point(4, 25);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroups.Size = new System.Drawing.Size(518, 289);
			this.tabPageGroups.TabIndex = 1;
			this.tabPageGroups.Text = "Groups";
			this.tabPageGroups.UseVisualStyleBackColor = true;
			// 
			// tabPageDirections
			// 
			this.tabPageDirections.Controls.Add(this.dgvDirections);
			this.tabPageDirections.Location = new System.Drawing.Point(4, 25);
			this.tabPageDirections.Name = "tabPageDirections";
			this.tabPageDirections.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDirections.Size = new System.Drawing.Size(518, 289);
			this.tabPageDirections.TabIndex = 2;
			this.tabPageDirections.Text = "Directions";
			this.tabPageDirections.UseVisualStyleBackColor = true;
			// 
			// dgvDirections
			// 
			this.dgvDirections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDirections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDirections.Location = new System.Drawing.Point(0, 30);
			this.dgvDirections.Name = "dgvDirections";
			this.dgvDirections.RowHeadersWidth = 51;
			this.dgvDirections.RowTemplate.Height = 24;
			this.dgvDirections.Size = new System.Drawing.Size(518, 260);
			this.dgvDirections.TabIndex = 0;
			// 
			// tabPageDisciplins
			// 
			this.tabPageDisciplins.Controls.Add(this.dgvDisciplins);
			this.tabPageDisciplins.Location = new System.Drawing.Point(4, 25);
			this.tabPageDisciplins.Name = "tabPageDisciplins";
			this.tabPageDisciplins.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDisciplins.Size = new System.Drawing.Size(518, 289);
			this.tabPageDisciplins.TabIndex = 3;
			this.tabPageDisciplins.Text = "Disciplins";
			this.tabPageDisciplins.UseVisualStyleBackColor = true;
			// 
			// tabPageTeachers
			// 
			this.tabPageTeachers.Controls.Add(this.dgvTeachers);
			this.tabPageTeachers.Location = new System.Drawing.Point(4, 25);
			this.tabPageTeachers.Name = "tabPageTeachers";
			this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTeachers.Size = new System.Drawing.Size(518, 289);
			this.tabPageTeachers.TabIndex = 4;
			this.tabPageTeachers.Text = "Teachers";
			this.tabPageTeachers.UseVisualStyleBackColor = true;
			// 
			// dgvStudents
			// 
			this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudents.Location = new System.Drawing.Point(0, 31);
			this.dgvStudents.Name = "dgvStudents";
			this.dgvStudents.RowHeadersWidth = 51;
			this.dgvStudents.RowTemplate.Height = 24;
			this.dgvStudents.Size = new System.Drawing.Size(518, 243);
			this.dgvStudents.TabIndex = 1;
			// 
			// dgvGroups
			// 
			this.dgvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGroups.Location = new System.Drawing.Point(0, 29);
			this.dgvGroups.Name = "dgvGroups";
			this.dgvGroups.RowHeadersWidth = 51;
			this.dgvGroups.RowTemplate.Height = 24;
			this.dgvGroups.Size = new System.Drawing.Size(518, 245);
			this.dgvGroups.TabIndex = 1;
			// 
			// dgvDisciplins
			// 
			this.dgvDisciplins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDisciplins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDisciplins.Location = new System.Drawing.Point(0, 29);
			this.dgvDisciplins.Name = "dgvDisciplins";
			this.dgvDisciplins.RowHeadersWidth = 51;
			this.dgvDisciplins.RowTemplate.Height = 24;
			this.dgvDisciplins.Size = new System.Drawing.Size(518, 245);
			this.dgvDisciplins.TabIndex = 1;
			// 
			// dgvTeachers
			// 
			this.dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTeachers.Location = new System.Drawing.Point(0, 32);
			this.dgvTeachers.Name = "dgvTeachers";
			this.dgvTeachers.RowHeadersWidth = 51;
			this.dgvTeachers.RowTemplate.Height = 24;
			this.dgvTeachers.Size = new System.Drawing.Size(518, 242);
			this.dgvTeachers.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 340);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.statusStrip1);
			this.Name = "MainForm";
			this.Text = "AcademyPV_522";
			this.tabControl.ResumeLayout(false);
			this.tabPageStudents.ResumeLayout(false);
			this.tabPageGroups.ResumeLayout(false);
			this.tabPageDirections.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).EndInit();
			this.tabPageDisciplins.ResumeLayout(false);
			this.tabPageTeachers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisciplins)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageStudents;
		private System.Windows.Forms.TabPage tabPageGroups;
		private System.Windows.Forms.TabPage tabPageDirections;
		private System.Windows.Forms.TabPage tabPageDisciplins;
		private System.Windows.Forms.TabPage tabPageTeachers;
		private System.Windows.Forms.DataGridView dgvDirections;
		private System.Windows.Forms.DataGridView dgvStudents;
		private System.Windows.Forms.DataGridView dgvGroups;
		private System.Windows.Forms.DataGridView dgvDisciplins;
		private System.Windows.Forms.DataGridView dgvTeachers;
	}
}

