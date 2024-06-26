namespace TaskManager
{
	partial class CommandLine
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommandLine));
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.comboBoxFileName = new System.Windows.Forms.ComboBox();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(25, 54);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 0;
			this.buttonOk.Text = "ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(106, 54);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Location = new System.Drawing.Point(187, 54);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
			this.buttonBrowse.TabIndex = 2;
			this.buttonBrowse.Text = "browse";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// comboBoxFileName
			// 
			this.comboBoxFileName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.comboBoxFileName.Cursor = System.Windows.Forms.Cursors.Default;
			this.comboBoxFileName.FormattingEnabled = true;
			this.comboBoxFileName.Location = new System.Drawing.Point(25, 123);
			this.comboBoxFileName.Name = "comboBoxFileName";
			this.comboBoxFileName.Size = new System.Drawing.Size(237, 21);
			this.comboBoxFileName.TabIndex = 3;
			this.comboBoxFileName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxFileName_KeyDown);
			// 
			// pictureBox
			// 
			this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox.Image = global::TaskManager.Properties.Resources.cmd;
			this.pictureBox.Location = new System.Drawing.Point(307, 27);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(100, 50);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 4;
			this.pictureBox.TabStop = false;
			// 
			// CommandLine
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 286);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.comboBoxFileName);
			this.Controls.Add(this.buttonBrowse);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "CommandLine";
			this.Text = "Run";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CommandLine_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.ComboBox comboBoxFileName;
		private System.Windows.Forms.PictureBox pictureBox;
	}
}