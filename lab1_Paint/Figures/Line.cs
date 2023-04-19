using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.Json.Serialization;

namespace lab1_Paint.Figures
{
	[Serializable]
	class Line:Figure
	{
		public int x1;
		public int x2;
		public int y1;
		public int y2;
		public Line() { }
		[JsonConstructor]
		public Line( Color borderColor,  int x1, int y1, int x2, int y2)
			: base( borderColor)
		{
			this.x1 = x1;
			this.x2 = x2;
			this.y1 = y1;
			this.y2 = y2;
			this.type = "Line";
		}
		public int getX1()
		{
			return x1;
		}
		public int getY1()
		{
			return y1;
		}
		public int getX2()
		{
			return x2;
		}
		public int getY2()
		{
			return y2;
		}
	}
}
