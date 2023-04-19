using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

using lab1_Paint.Figures;
using System.IO;
using System.Text.Json.Serialization;
using System.Drawing;

namespace lab1_Paint.Data
{
	[Serializable]
	class Data
	{
		public Dictionary<int, object> figures;
		[JsonConstructor]
		public Data()
		{
			figures = new Dictionary<int, object>();
		}
		
		public Data(string fileName)
		{
			figures = new Dictionary<int, object>();
			var options = new JsonSerializerOptions { IncludeFields = true, WriteIndented = true };
			var figuresRaw = JsonSerializer.Deserialize<Data>(File.ReadAllText(fileName), options).figures;
			foreach(KeyValuePair<int,object> f in figuresRaw)
			{
				
				string type =((JsonElement)f.Value).GetProperty("type").GetString();
				int A = ((JsonElement)f.Value).GetProperty("borderColor").GetProperty("A").GetInt32();
				int R = ((JsonElement)f.Value).GetProperty("borderColor").GetProperty("R").GetInt32();
				int G = ((JsonElement)f.Value).GetProperty("borderColor").GetProperty("G").GetInt32();
				int B = ((JsonElement)f.Value).GetProperty("borderColor").GetProperty("B").GetInt32();
				Color borderColor=Color.FromArgb(A, R, G, B);
				Color fillColor=Color.White;
				if (type != "Line")
				{
					A = ((JsonElement)f.Value).GetProperty("fillColor").GetProperty("A").GetInt32();
					R = ((JsonElement)f.Value).GetProperty("fillColor").GetProperty("R").GetInt32();
					G = ((JsonElement)f.Value).GetProperty("fillColor").GetProperty("G").GetInt32();
					B = ((JsonElement)f.Value).GetProperty("fillColor").GetProperty("B").GetInt32();
					fillColor = Color.FromArgb(A, R, G, B);
				}
				if (type == "Circle")
				{
					int x = ((JsonElement)f.Value).GetProperty("x").GetInt32();
		
					int y = ((JsonElement)f.Value).GetProperty("y").GetInt32();
					int r = ((JsonElement)f.Value).GetProperty("r").GetInt32();
					this.refreshFigure(f.Key, new Circle(borderColor, fillColor, x, y, r));

				}
				(int, int)[] points = null;
				if (type == "Triangle"|| type == "Square"|| type == "Polygon")
				{
					int lenght = ((JsonElement)f.Value).GetProperty("vertices").GetArrayLength();
					points = new (int, int)[lenght];
					for(int i=0;i<lenght;i++)
					{
						int x=((JsonElement)f.Value).GetProperty("vertices")[i].GetProperty("Item1").GetInt32();
						int y=((JsonElement)f.Value).GetProperty("vertices")[i].GetProperty("Item2").GetInt32();
						points[i] = (x, y);
					}
				}
				if (type == "Triangle")
				{
					this.refreshFigure(f.Key, new Triangle(borderColor, fillColor,  points));
				}
				if (type == "Square")
				{
					this.refreshFigure(f.Key, new Square(borderColor, fillColor, points));
				}
				if (type == "Polygon")
				{
					this.refreshFigure(f.Key, new Polygon(borderColor, fillColor, points));
				}
				if (type == "Ellipse")
				{
					int left = ((JsonElement)f.Value).GetProperty("left").GetInt32();
					int top = ((JsonElement)f.Value).GetProperty("top").GetInt32();
					int a = ((JsonElement)f.Value).GetProperty("a").GetInt32();
					int b = ((JsonElement)f.Value).GetProperty("b").GetInt32();
					this.refreshFigure(f.Key, new Ellipse(borderColor, fillColor, left,top,a,b));
				}
				if (type == "Line")
				{
					int x1 = ((JsonElement)f.Value).GetProperty("x1").GetInt32();
					int y1 = ((JsonElement)f.Value).GetProperty("y1").GetInt32();
					int x2 = ((JsonElement)f.Value).GetProperty("x2").GetInt32();
					int y2 = ((JsonElement)f.Value).GetProperty("y2").GetInt32();
					this.refreshFigure(f.Key, new Line(borderColor, x1,y1,x2,y2));
				}
			}

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
			return (Figure)figures[index];
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
		public void serialize(string path)
		{
			var options = new JsonSerializerOptions { IncludeFields = true, WriteIndented = true };
			string jsonString = JsonSerializer.Serialize<object>(this, options);

			File.WriteAllText(path, jsonString);
			
		}
	}
}
