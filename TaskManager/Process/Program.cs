﻿//#define SINGLE_PROCESS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Process
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if SINGLE_PROCESS
			Console.WriteLine("введите имя проограммы: ");
			string process_name = Console.ReadLine();
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			process.StartInfo.FileName = process_name;
			process.Start();

			Console.WriteLine(process.ProcessName);
			Console.WriteLine(process.Id);
			Console.WriteLine(process.MainModule.FileName);

			IntPtr handle = IntPtr.Zero;
			OpenProcessToken(process.Handle, 8, out handle);
			System.Security.Principal.WindowsIdentity wi = new System.Security.Principal.WindowsIdentity(handle);
			CloseHandle(handle);
			Console.WriteLine($"username:{wi.Name}");

			Console.WriteLine($"SessionID: {process.SessionId}");
			Console.WriteLine($"Threads: {process.Threads}");
			Console.WriteLine($"Priority class: {process.PriorityClass}");
#endif

				System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcesses();
				for (int i = 0; i < processes.Length; i++) 
				{
				Console.WriteLine($"{processes[i].Id}\t {processes[i].MainModule.FileName}");
					//Console.Write($"Name:{processes[i].ProcessName}\t");
					//Console.Write($"PID:{processes[i].Id}\t");
					Console.Write($"Path:{processes[i].MainModule.FileName}\t");
					//Console.WriteLine();
				}
		}
		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern bool OpenProcessToken(IntPtr processHandle, uint desiredAcsess, out IntPtr handle);
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CloseHandle(IntPtr handle);
	}
}
