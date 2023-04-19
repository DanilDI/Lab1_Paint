using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace lab1_Paint.Figures
{
	[Serializable]
	abstract class FilledFigure :Figure
	{
		private Color fillColor;
		protected FilledFigure( Color borderColor, Color fillColor)
			:base ( borderColor)
		{
			this.fillColor = fillColor;
		}
		public void setFillColor(Color color)
		{
			this.fillColor = color;
		}
		public Color getFillColor()
		{
			return this.fillColor;
		}
	}

}
