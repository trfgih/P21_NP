using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TaskManager
{
	public partial class CommandLine : Form
	{
		public ComboBox ComboBoxFileName 
		{
			get { return comboBoxFileName; }
		}
		public CommandLine()
		{
			InitializeComponent();
			Load();
		}
		public void Load() 
		{
			StreamReader sr = new StreamReader("ProgramList.txt");
			while (!sr.EndOfStream) 
			{ 
				string item = sr.ReadLine();
				comboBoxFileName.Items.Add(item);
			}

			sr.Close();
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			try
			{
				string text = comboBoxFileName.Text;
				System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo(comboBoxFileName.Text);
				System.Diagnostics.Process process = new System.Diagnostics.Process();
				process.StartInfo = startInfo;
				process.Start();
				//if(!comboBoxFileName.Items.Contains(comboBoxFileName.Text))
				//	comboBoxFileName.Items.Insert(0,comboBoxFileName.Text);

				comboBoxFileName.Items.Remove(text);
				comboBoxFileName.Text = (text);
				comboBoxFileName.Items.Insert(0, text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			}

			this.Close();			
		}

		private void comboBoxFileName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				buttonOk_Click(sender, e);
			}
		}

		private void CommandLine_FormClosing(object sender, FormClosingEventArgs e)
		{
			comboBoxFileName.Focus();
		}
	}
}
