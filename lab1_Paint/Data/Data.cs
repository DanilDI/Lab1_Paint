using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab1_Paint.Figures;

namespace lab1_Paint.Data
{
	[Serializable]
	class Data
	{
		private Dictionary<int, Figure> figures;
		
		public Data()
		{
			figures = new Dictionary<int, Figure>();
		}
		public int getFreeIndex()
		{
			int maxIndex = 0;
			foreach (var figure in this.figures)
			{
				maxIndex = Math.Max(maxIndex, figure.Key);
			}
			return maxIndex + 1;
		}
		public Figure getFigure(int index)
		{
			return figures[index];
		}
		public int addFigure(Figure f)
		{
			int index = this.getFreeIndex();
			figures.Add(index, f);
			return index;
		}
		public void removeFigure(int index)
		{
			figures.Remove(index);
		}
		public void refreshFigure(int index, Figure f)
		{
			figures[index] = f;
		}
	}
}
