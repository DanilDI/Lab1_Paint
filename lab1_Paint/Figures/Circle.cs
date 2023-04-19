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
	class Circle:FilledFigure
	{
		public int x;
		public int y;
		public int r;
		public Circle( Color borderColor, Color fillColor, int x, int y, int r)
			:base(borderColor,  fillColor)
		{
			this.x = x;
			this.y = y;
			this.r = r;
			this.type = "Circle";
		}
		public void setCenterPosition(int x, int y )
		{
			
			this.x = x;
			this.y = y;
		}

		public void setRadius(int r)
		{
			
			this.r = r;
		}
		public int getX()
		{
			return x;
		}
		public int getY()
		{
			return y;
		}
		public int getR()
		{
			return r;
		}
	}
}
