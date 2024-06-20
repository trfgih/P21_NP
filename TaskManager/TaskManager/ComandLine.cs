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

namespace TaskManager
{
	public partial class ComandLine : Form
	{
		public ComandLine()
		{
			InitializeComponent();
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo(comboBoxFileName.Text);
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			process.StartInfo = startInfo;
			process.Start();
			this.Close();
		}
	}
}
