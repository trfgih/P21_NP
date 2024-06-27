using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TaskManager
{
	internal class Comparer: IComparer //реализуем интерфейс IComparer
	{
		public int Index { get; set; }
		public SortOrder Direction { get; set; }
		public enum ValueType
		{ 
			String,
			Integer,
			Memory
		};
		public ValueType Type { get; set; }

		public Comparer(int column = 0)
		{ 
			this.Index = column;
			Direction = SortOrder.None;
		}
		public int Compare(object x, object y) 
		{
			ListViewItem lviX = x as ListViewItem;
			ListViewItem lviY = y as ListViewItem;
			if(lviX == null && lviY == null) return 0;
			if(lviY == null) return -1;
			if(lviY == null) return 1;


			//MessageBox(lviY.SubItems[Index].GetType().ToString(), "CilumnType", MessageBoxButtons.OK);
			int result = 0;
			int x_value = 0;
			int y_value = 0;

			switch (Type)
			{
				case ValueType.Integer:
					{
						Int32.TryParse(lviY.SubItems[Index].Text, out y_value);
						Int32.TryParse(lviX.SubItems[Index].Text, out x_value);
						result = x_value.CompareTo(y_value);
					}
					break;
				case ValueType.Memory:
					{
						double x_memory, y_memory;
						Double.TryParse(lviX.SubItems[Index].Text.Split(' ')[0], out x_memory);
						Double.TryParse(lviY.SubItems[Index].Text.Split(' ')[0], out y_memory);
						result = x_memory.CompareTo(y_memory);
					}
					break;
				case ValueType.String:
					{
						result = String.Compare
						(
						((ListViewItem)x).SubItems[Index].Text,
						((ListViewItem)y).SubItems[Index].Text
						);
					}
					break;
			}
			return Direction == SortOrder.Ascending ? result : -result;

		}
			
			
			

			//return String.Compare
			//	(
			//	((ListViewItem)x).SubItems[Index].Text,
			//	((ListViewItem)y).SubItems[Index].Text
			//	);

			//public string GetColumnType(ListViewItem item) 
			//{
			//	int value = 0;
			//	if (Int32.TryParse(item.Text, out value)) return "int";
			//}


		}
	}
}
