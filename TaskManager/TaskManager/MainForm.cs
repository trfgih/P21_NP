﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TaskManager
{
	public partial class MainForm : Form
	{
		readonly int rumFactor = 1024;
		readonly string suffix = "kB";
		Dictionary<int, Process> d_processes;
		public MainForm()
		{
			InitializeComponent();
			SetColumns();
			statusStrip1.Items.Add("");
			LoadProcesses();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			AddNewProcesses();
			RemoveOldrocesses();
			UpdatesExistingProcesses();
			statusStrip1.Items[0].Text = ($"количество  процессов: {listViewProcesses.Items.Count}");
		}
		void SetColumns()
		{
			listViewProcesses.Columns.Add("PID");
			listViewProcesses.Columns.Add("Name");
			listViewProcesses.Columns.Add("Working set");
			listViewProcesses.Columns.Add("Peac working set");


		}
		void LoadProcesses()
		{
			//listViewProcesses.Items.Clear();
			//Process[] processes = Process.GetProcesses();
			//for (int i = 0; i < processes.Length; i++) 
			//{
			//    ListViewItem item = new ListViewItem();
			//    item.Text = processes[i].Id.ToString();
			//    item.SubItems.Add(processes[i].ProcessName);
			//    listViewProcesses.Items.Add(item);
			//}
			d_processes = Process.GetProcesses().ToDictionary(item => item.Id, item => item);
			foreach (KeyValuePair<int, Process> i in d_processes)
			{
				//ListViewItem item = new ListViewItem();
				//item.Text = i.Key.ToString();
				//item.SubItems.Add(i.Value.ProcessName);
				//listViewProcesses.Items.Add(item);
				AddProcessToListView(i.Value);
			}
			//statusStrip1.Items[0].Text = ($"количество  процессов: {listViewProcesses.Items.Count}");
		}
		void AddNewProcesses() 
		{
			Dictionary<int, Process> d_processes = Process.GetProcesses().ToDictionary(item => item.Id, item => item);
			foreach (KeyValuePair<int, Process> i in d_processes)
			{
				if (!this.d_processes.ContainsKey(i.Key))
				{
					//this.d_processes.Add(i.Key, i.Value);
					AddProcessToListView(i.Value);
				}
			}
			//statusStrip1.Items[0].Text = ($"количество  процессов: {listViewProcesses.Items.Count}");
		}
		void RemoveOldrocesses() 
		{

			this.d_processes = Process.GetProcesses().ToDictionary(item => item.Id, item => item);
			for (int i = 0; i < listViewProcesses.Items.Count; i++) 
			{
				//string item_name = listViewProcesses.Items[i].Name;
				if (!d_processes.ContainsKey(Convert.ToInt32(listViewProcesses.Items[i].Text)))
				{ 
					listViewProcesses.Items.RemoveAt(i);
				}
			}
		
		}

		void UpdatesExistingProcesses() 
		{
			for(int i = 0; i < listViewProcesses.Items.Count;i++)
			{
				int id = Convert.ToInt32(listViewProcesses.Items[i].Text);
				//Process process = d_processes[id];
				listViewProcesses.Items[i].SubItems[2].Text = $"{d_processes[id].WorkingSet64 / rumFactor} {suffix}";
				listViewProcesses.Items[i].SubItems[3].Text = $"{d_processes[id].PeakWorkingSet64 / rumFactor} {suffix}";

			}
		}
		void AddProcessToListView(Process process)
		{
			
			ListViewItem item = new ListViewItem();
			item.Text = process.Id.ToString();
			item.SubItems.Add(process.ProcessName);
			item.SubItems.Add($"{process.WorkingSet64/rumFactor}{suffix}");
			item.SubItems.Add($"{process.PeakWorkingSet64/rumFactor}{suffix}");
			listViewProcesses.Items.Add(item);
		}
		void RemoveProcessesFromListView(int pid) 
		{
			listViewProcesses.Items.RemoveByKey(pid.ToString());
		}
	}
}
