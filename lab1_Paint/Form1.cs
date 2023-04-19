﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Drawing.Imaging;

namespace lab1_Paint
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}
		private string figureType = "";
		private (int,int)[] reservedPoints = new (int,int)[100];
		private int currentPointNumber = 0;
		private Data.Data data = new Data.Data();  
		//начало отрисовки фигуры
		private void buttonCircle_Click(object sender, EventArgs e)
		{
			figureType = "Circle";
			currentPointNumber = 0;
		}
		private void buttonTriangle_Click(object sender, EventArgs e)
		{
			figureType = "Triangle";
			currentPointNumber = 0;
		}
		private void buttonSquare_Click(object sender, EventArgs e)
		{
			figureType = "Square";
			currentPointNumber = 0;
		}
		private void buttonPolygon_Click(object sender, EventArgs e)
		{
			figureType = "Polygon";
			currentPointNumber = 0;
		}
		private void buttonEllipse_Click(object sender, EventArgs e)
		{
			figureType = "Ellipse";
			currentPointNumber = 0;

		}
		private void buttonLine_Click(object sender, EventArgs e)
		{
			figureType = "Line";
			currentPointNumber = 0;
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			
			reservedPoints[currentPointNumber] = (e.X, e.Y);
			currentPointNumber++;


		}

		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			if (figureType == "Circle")
			{
				if (e.Button == MouseButtons.Right)
				{
					return;
				}
				reservedPoints[1] = (e.X, e.Y);
				int x1 = reservedPoints[0].Item1;
				int x2= reservedPoints[1].Item1;
				int y1= reservedPoints[0].Item2;
				int y2= reservedPoints[1].Item2;
				
				int r = (int)Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
				var picture = new PictureBox();
				picture.ContextMenuStrip = contextMenuStrip1;
				int tag = data.addFigure(new Figures.Circle(pictureBoxLine.BackColor, pictureBoxFill.BackColor,x1,y1,r));
				picture.Tag = tag;
				
				drawCircle(picture,x1, y1, r, pictureBoxLine.BackColor, pictureBoxFill.BackColor);
				
				panel1.Controls.Add(picture);
				figureType = "";
			}
			if(figureType=="Triangle")
			{
				if(currentPointNumber!=3 || e.Button == MouseButtons.Right)
				{
					return;
				}
				var picture = new PictureBox();
				picture.ContextMenuStrip = contextMenuStrip1;
				(int, int)[] tmp = new (int, int)[3];
				Array.Copy(reservedPoints, tmp, 3);
				int tag = data.addFigure(new Figures.Triangle(pictureBoxLine.BackColor, pictureBoxFill.BackColor,tmp));
				picture.Tag = tag;

				drawPolygon(picture, tmp, pictureBoxLine.BackColor, pictureBoxFill.BackColor);

				panel1.Controls.Add(picture);
				figureType = "";
			}
			if (figureType == "Square")
			{
				if (currentPointNumber != 2 || e.Button==MouseButtons.Right)
				{
					return;
				}
				var picture = new PictureBox();
				picture.ContextMenuStrip = contextMenuStrip1;
				(int, int)[] tmp = new (int, int)[4];

				int x1 = reservedPoints[0].Item1;
				int x2 = reservedPoints[1].Item1;
				int y1 = reservedPoints[0].Item2;
				int y2 = reservedPoints[1].Item2;
				int r = Math.Max(Math.Abs(x2 - x1), Math.Abs(y2 - y1));
				tmp[0] = (x1 - r, y1 - r);
				tmp[1] = (x1 + r, y1 - r);
				tmp[2] = (x1 + r, y1 + r);
				tmp[3] = (x1 - r, y1 + r);
				int tag = data.addFigure(new Figures.Square(pictureBoxLine.BackColor, pictureBoxFill.BackColor, tmp));
				picture.Tag = tag;

				drawPolygon(picture, tmp, pictureBoxLine.BackColor, pictureBoxFill.BackColor);

				panel1.Controls.Add(picture);
				figureType = "";
			}
			
		}

		

		private void drawCircle(PictureBox picture,int x, int y,int r, Color line, Color fill)
		{
			
			Pen myPen = new Pen(line);
			Brush myBrush = new SolidBrush(fill);
			picture.Location = new Point(x - r-1, y - r-1);
			picture.Width = r * 2 + 2;
			picture.Height = r * 2 + 2;
			var MyImage = new Bitmap(picture.Width, picture.Height);
			
			Graphics.FromImage(MyImage).FillEllipse(myBrush, 1, 1, r * 2, r * 2);
			Graphics.FromImage(MyImage).DrawEllipse(myPen, 1, 1, r * 2, r * 2);
			
			picture.BackgroundImage = MyImage;
			
			
		}
		private (int,int) findLeftTop((int, int)[] points)
		{
			int left = 10000, top = 10000;
			foreach ((int, int) point in points)
			{
				left = Math.Min(left, point.Item1);
				top = Math.Min(top, point.Item2);
			}
			return (left, top);
		}
		private (int, int) findWidthHeight((int, int)[] points)
		{
			int left = 10000, top = 10000, right = 0, bottom = 0; ;
			foreach ((int, int) point in points)
			{
				left = Math.Min(left, point.Item1);
				top = Math.Min(top, point.Item2);
				right = Math.Max(right, point.Item1);
				bottom = Math.Max(bottom, point.Item2);

			}
			return (right-left, bottom-top);
		}
		private Point[] numbersToPoints((int, int)[] points)
		{
			Point[] newPoints = new Point[points.Length];
			int i = 0;
			foreach ((int, int) point in points)
			{
				newPoints[i] = new Point(point.Item1, point.Item2);
				i++; ;
			}
			return newPoints;
		}
		private Point[] transferPoints(Point[] points, int left, int top)
		{
			Point[] newPoints = new Point[points.Length];
			int i = 0;
			foreach (Point point in points)
			{
				newPoints[i] = new Point(point.X-left, point.Y - top);
				i++; ;
			}
			return newPoints;
		}
		private void drawPolygon(PictureBox picture, (int, int)[] points , Color line, Color fill)
		{

			Pen myPen = new Pen(line);
			Brush myBrush = new SolidBrush(fill);
			(int,int) leftTop = findLeftTop(points);
			(int, int) widthHeight = findWidthHeight(points);
			picture.Location = new Point(leftTop.Item1-1, leftTop.Item2-1);
			picture.Width = widthHeight.Item1 + 2;
			picture.Height = widthHeight.Item2 + 2;
			var MyImage = new Bitmap(picture.Width, picture.Height);
			Point[] newPoints = transferPoints(numbersToPoints(points), leftTop.Item1, leftTop.Item2);
			
			Graphics.FromImage(MyImage).FillPolygon(myBrush, newPoints);
			Graphics.FromImage(MyImage).DrawPolygon(myPen, newPoints);

			picture.BackgroundImage = MyImage;


		}
		private void delelteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var location = panel1.PointToClient(new System.Drawing.Point(((ToolStripMenuItem)sender).Owner.Left, ((ToolStripMenuItem)sender).Owner.Top));
			var target = panel1.GetChildAtPoint(location);
			data.removeFigure((int)target.Tag);
			
			target.Dispose();
		}

		private void changeLineColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var location = panel1.PointToClient(new System.Drawing.Point(((ToolStripMenuItem)sender).Owner.Left, ((ToolStripMenuItem)sender).Owner.Top));
			var target = panel1.GetChildAtPoint(location);
			int tag = (int)target.Tag;
			Figures.Figure f = data.getFigure(tag);

			ColorDialog MyDialog = new ColorDialog();
			MyDialog.Color = f.getBorderColor();
			Color newColor;
			if (MyDialog.ShowDialog() == DialogResult.OK)
			{
				newColor = MyDialog.Color;
			}
			else
			{
				return;
			}

			if (f.getType()=="Circle")
			{
				Figures.Circle c = (Figures.Circle) f;
				drawCircle((PictureBox)target, c.getX(), c.getY(), c.getR(), newColor, c.getFillColor());
			}
			if (f.getType() == "Triangle" || f.getType() == "Square" || f.getType() == "Polygon")
			{
				Figures.Polygon p = (Figures.Polygon)f;
				drawPolygon((PictureBox)target, p.getVertices(), newColor, p.getFillColor());
			}
			f.setBorderColor(newColor);
			data.refreshFigure(tag, f);
		}

		private void changeFillColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var location = panel1.PointToClient(new System.Drawing.Point(((ToolStripMenuItem)sender).Owner.Left, ((ToolStripMenuItem)sender).Owner.Top));
			var target = panel1.GetChildAtPoint(location);
			int tag = (int)target.Tag;
			Figures.FilledFigure f = (Figures.FilledFigure)data.getFigure(tag);

			ColorDialog MyDialog = new ColorDialog();
			MyDialog.Color = f.getFillColor();
			Color newColor;
			if (MyDialog.ShowDialog() == DialogResult.OK)
			{
				newColor = MyDialog.Color;
			}
			else
			{
				return;
			}

			if (f.getType() == "Circle")
			{
				Figures.Circle c = (Figures.Circle)f;
				drawCircle((PictureBox)target, c.getX(), c.getY(), c.getR(), c.getBorderColor(), newColor);
			}
			if (f.getType() == "Triangle"|| f.getType() == "Square"|| f.getType() == "Polygon")
			{
				Figures.Polygon p = (Figures.Polygon)f;
				drawPolygon((PictureBox)target, p.getVertices(), p.getBorderColor(), newColor);
			}
			f.setFillColor(newColor);
			data.refreshFigure(tag, f);
		}

		private void pictureBoxLine_Click(object sender, EventArgs e)
		{
			ColorDialog MyDialog = new ColorDialog();
			MyDialog.Color = pictureBoxLine.BackColor;
			if (MyDialog.ShowDialog() == DialogResult.OK)
			{
				pictureBoxLine.BackColor = MyDialog.Color;
			}
			else
			{
				return;
			}
		}

		private void pictureBoxFill_Click(object sender, EventArgs e)
		{
			ColorDialog MyDialog = new ColorDialog();
			MyDialog.Color = pictureBoxFill.BackColor;
			if (MyDialog.ShowDialog() == DialogResult.OK)
			{
				pictureBoxFill.BackColor = MyDialog.Color;
			}
			else
			{
				return;
			}
		}


		//сохранение и загрузка
		private void buttonSave_Click(object sender, EventArgs e)
		{

		}
		private void buttonLoad_Click(object sender, EventArgs e)
		{

		}

		
	}
}
