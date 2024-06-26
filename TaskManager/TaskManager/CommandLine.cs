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
			comboBoxFileName.Text = comboBoxFileName.Items[0].ToString();
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

		private void CommandLine_FormClosing(object sender, FormClosingEventArgs e)
		{
			comboBoxFileName.Focus();
		}

		private void comboBoxFileName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == (char)Keys.Enter) buttonOk_Click(sender, e);
			if (e.KeyValue == (char)Keys.Escape) Close();
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Exe files *.exe(*.exe)|*.exe |All files(*.*)|*.*";
			DialogResult result = open.ShowDialog();
			if (result == DialogResult.OK)
			{
				comboBoxFileName.Text = open.FileName;
			}
		}

		//private void CommandLine_KeyPress(object sender, KeyPressEventArgs e)
		//{
		//	if (e.KeyChar == (char)Keys.Enter)
		//	{
		//		buttonOk_Click(sender, e);
		//	}
		//	if (e.KeyChar == (char)Keys.Escape) Close();
		//}
	}
}
