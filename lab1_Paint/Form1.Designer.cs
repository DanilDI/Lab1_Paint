
namespace lab1_Paint
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.buttonCircle = new System.Windows.Forms.Button();
			this.buttonTriangle = new System.Windows.Forms.Button();
			this.buttonSquare = new System.Windows.Forms.Button();
			this.buttonPolygon = new System.Windows.Forms.Button();
			this.buttonEllipse = new System.Windows.Forms.Button();
			this.buttonLine = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonLoad = new System.Windows.Forms.Button();
			this.pictureBoxLine = new System.Windows.Forms.PictureBox();
			this.pictureBoxFill = new System.Windows.Forms.PictureBox();
			this.textBoxLine = new System.Windows.Forms.TextBox();
			this.textBoxFill = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.delelteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeLineColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeFillColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFill)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonCircle
			// 
			this.buttonCircle.Location = new System.Drawing.Point(20, 20);
			this.buttonCircle.Name = "buttonCircle";
			this.buttonCircle.Size = new System.Drawing.Size(150, 50);
			this.buttonCircle.TabIndex = 0;
			this.buttonCircle.Text = "Circle";
			this.buttonCircle.UseVisualStyleBackColor = true;
			this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
			// 
			// buttonTriangle
			// 
			this.buttonTriangle.Location = new System.Drawing.Point(20, 100);
			this.buttonTriangle.Name = "buttonTriangle";
			this.buttonTriangle.Size = new System.Drawing.Size(150, 50);
			this.buttonTriangle.TabIndex = 1;
			this.buttonTriangle.Text = "Triangle";
			this.buttonTriangle.UseVisualStyleBackColor = true;
			this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
			// 
			// buttonSquare
			// 
			this.buttonSquare.Location = new System.Drawing.Point(20, 180);
			this.buttonSquare.Name = "buttonSquare";
			this.buttonSquare.Size = new System.Drawing.Size(150, 50);
			this.buttonSquare.TabIndex = 2;
			this.buttonSquare.Text = "Square";
			this.buttonSquare.UseVisualStyleBackColor = true;
			this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
			// 
			// buttonPolygon
			// 
			this.buttonPolygon.Location = new System.Drawing.Point(20, 260);
			this.buttonPolygon.Name = "buttonPolygon";
			this.buttonPolygon.Size = new System.Drawing.Size(150, 50);
			this.buttonPolygon.TabIndex = 3;
			this.buttonPolygon.Text = "Polygon";
			this.buttonPolygon.UseVisualStyleBackColor = true;
			this.buttonPolygon.Click += new System.EventHandler(this.buttonPolygon_Click);
			// 
			// buttonEllipse
			// 
			this.buttonEllipse.Location = new System.Drawing.Point(20, 340);
			this.buttonEllipse.Name = "buttonEllipse";
			this.buttonEllipse.Size = new System.Drawing.Size(150, 50);
			this.buttonEllipse.TabIndex = 4;
			this.buttonEllipse.Text = "Ellipse";
			this.buttonEllipse.UseVisualStyleBackColor = true;
			this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
			// 
			// buttonLine
			// 
			this.buttonLine.Location = new System.Drawing.Point(20, 420);
			this.buttonLine.Name = "buttonLine";
			this.buttonLine.Size = new System.Drawing.Size(150, 50);
			this.buttonLine.TabIndex = 5;
			this.buttonLine.Text = "Line";
			this.buttonLine.UseVisualStyleBackColor = true;
			this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(220, 20);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(700, 700);
			this.panel1.TabIndex = 6;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(20, 505);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(150, 50);
			this.buttonSave.TabIndex = 7;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonLoad
			// 
			this.buttonLoad.Location = new System.Drawing.Point(20, 570);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(150, 50);
			this.buttonLoad.TabIndex = 8;
			this.buttonLoad.Text = "Load";
			this.buttonLoad.UseVisualStyleBackColor = true;
			this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
			// 
			// pictureBoxLine
			// 
			this.pictureBoxLine.BackColor = System.Drawing.Color.Black;
			this.pictureBoxLine.Location = new System.Drawing.Point(20, 640);
			this.pictureBoxLine.Name = "pictureBoxLine";
			this.pictureBoxLine.Size = new System.Drawing.Size(60, 60);
			this.pictureBoxLine.TabIndex = 9;
			this.pictureBoxLine.TabStop = false;
			this.pictureBoxLine.Click += new System.EventHandler(this.pictureBoxLine_Click);
			// 
			// pictureBoxFill
			// 
			this.pictureBoxFill.BackColor = System.Drawing.Color.White;
			this.pictureBoxFill.Location = new System.Drawing.Point(110, 640);
			this.pictureBoxFill.Name = "pictureBoxFill";
			this.pictureBoxFill.Size = new System.Drawing.Size(60, 60);
			this.pictureBoxFill.TabIndex = 10;
			this.pictureBoxFill.TabStop = false;
			this.pictureBoxFill.Click += new System.EventHandler(this.pictureBoxFill_Click);
			// 
			// textBoxLine
			// 
			this.textBoxLine.Location = new System.Drawing.Point(20, 710);
			this.textBoxLine.Name = "textBoxLine";
			this.textBoxLine.ReadOnly = true;
			this.textBoxLine.Size = new System.Drawing.Size(60, 23);
			this.textBoxLine.TabIndex = 11;
			this.textBoxLine.Text = "Line";
			this.textBoxLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxFill
			// 
			this.textBoxFill.Location = new System.Drawing.Point(110, 710);
			this.textBoxFill.Name = "textBoxFill";
			this.textBoxFill.ReadOnly = true;
			this.textBoxFill.Size = new System.Drawing.Size(60, 23);
			this.textBoxFill.TabIndex = 12;
			this.textBoxFill.Text = "Fill";
			this.textBoxFill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delelteToolStripMenuItem,
            this.changeLineColorToolStripMenuItem,
            this.changeFillColorToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(168, 70);
			// 
			// delelteToolStripMenuItem
			// 
			this.delelteToolStripMenuItem.Name = "delelteToolStripMenuItem";
			this.delelteToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.delelteToolStripMenuItem.Text = "Delelte";
			this.delelteToolStripMenuItem.Click += new System.EventHandler(this.delelteToolStripMenuItem_Click);
			// 
			// changeLineColorToolStripMenuItem
			// 
			this.changeLineColorToolStripMenuItem.Name = "changeLineColorToolStripMenuItem";
			this.changeLineColorToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.changeLineColorToolStripMenuItem.Text = "Change line color";
			this.changeLineColorToolStripMenuItem.Click += new System.EventHandler(this.changeLineColorToolStripMenuItem_Click);
			// 
			// changeFillColorToolStripMenuItem
			// 
			this.changeFillColorToolStripMenuItem.Name = "changeFillColorToolStripMenuItem";
			this.changeFillColorToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.changeFillColorToolStripMenuItem.Text = "Change fill color";
			this.changeFillColorToolStripMenuItem.Click += new System.EventHandler(this.changeFillColorToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 761);
			this.Controls.Add(this.textBoxFill);
			this.Controls.Add(this.textBoxLine);
			this.Controls.Add(this.pictureBoxFill);
			this.Controls.Add(this.pictureBoxLine);
			this.Controls.Add(this.buttonLoad);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttonLine);
			this.Controls.Add(this.buttonEllipse);
			this.Controls.Add(this.buttonPolygon);
			this.Controls.Add(this.buttonSquare);
			this.Controls.Add(this.buttonTriangle);
			this.Controls.Add(this.buttonCircle);
			this.Name = "Form1";
			this.Text = "Paint Form";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFill)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCircle;
		private System.Windows.Forms.Button buttonTriangle;
		private System.Windows.Forms.Button buttonSquare;
		private System.Windows.Forms.Button buttonPolygon;
		private System.Windows.Forms.Button buttonEllipse;
		private System.Windows.Forms.Button buttonLine;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonLoad;
		private System.Windows.Forms.PictureBox pictureBoxLine;
		private System.Windows.Forms.PictureBox pictureBoxFill;
		private System.Windows.Forms.TextBox textBoxLine;
		private System.Windows.Forms.TextBox textBoxFill;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem delelteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeLineColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeFillColorToolStripMenuItem;
	}
}

