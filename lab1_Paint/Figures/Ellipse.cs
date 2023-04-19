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
	class Ellipse : FilledFigure
	{
		public int left;
		public int top;
		public int a;
		public int b;
		[JsonConstructor]
		public Ellipse(Color borderColor, Color fillColor, int left, int top, int a, int b)
			: base(borderColor, fillColor)
		{
			this.left = left;
			this.top = top;
			this.a = a;
			this.b = b;
			this.type = "Ellipse";
		}
		public Ellipse() { }


		public int getLeft()
		{
			return left;
		}
		public int getTop()
		{
			return top;
		}
		public int getA()
		{
			return a;
		}
		public int getB()
		{
			return b;
		}
	}
}
