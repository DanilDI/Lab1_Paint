using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace lab1_Paint.Figures
{
	[Serializable]
	class Line:Figure
	{
		private int x1;
		private int x2;
		private int y1;
		private int y2;
		public Line( Color borderColor,  int x1, int y1, int x2, int y2)
			: base( borderColor)
		{
			this.x1 = x1;
			this.x2 = x2;
			this.y1 = y1;
			this.y2 = y2;
			this.type = "Line";
		}
		public void moveFirst(int x1, int y1)
		{
			this.x1 = x1;
			this.y1 = y1;
		}
		public void moveSecond(int x2, int y2)
		{
			this.x2 = x2;
			this.y2 = y2;
		}
	}
}
