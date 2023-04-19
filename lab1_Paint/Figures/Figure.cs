using System;
using System.Drawing;
using System.Windows.Forms;
namespace lab1_Paint.Figures
{
	[Serializable]
	abstract class Figure
	{

		private Color borderColor;
		protected string type;

		 protected Figure( Color borderColor)
		{
			
			this.borderColor = borderColor;

		}


		public void setBorderColor(Color color)
		{
			this.borderColor = color;
		}
		public Color getBorderColor()
		{
			return this.borderColor;
		}
		public string getType()
		{
			return this.type;
		}
	}

}
