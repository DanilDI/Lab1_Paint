using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;
using System.Drawing;
using System.Text.Json.Serialization;

namespace lab1_Paint.Figures
{
	[Serializable]
	class Polygon: FilledFigure
	{
		public (int, int)[] vertices;
		public Polygon() { }
		[JsonConstructor]
		public Polygon( Color borderColor, Color fillColor, (int, int)[] vertices)
			:base ( borderColor, fillColor)
		{
			this.vertices= vertices;
			this.type = "Polygon";
		}
		public (int, int)[]  getVertices()
		{
			return this.vertices;
		}
}

}
