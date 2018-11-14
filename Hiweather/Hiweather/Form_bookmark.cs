﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hiweather
{
    public partial class Form_bookmark : Form
    {
        public Form_bookmark()
        {
            InitializeComponent();

            Load += Form_bookmark_Load;
            //MessageBox.Show("테스트");
        }

        private void Form_bookmark_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
            MainLabelCreate();
            //TableLayoutPanelCreate();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Controls.Add(pn_create(i, j));
                }
            }
        }
        private void MainLabelCreate()
        {
            Label label;
            label = new Label();
            label.Name = "label";
            label.Text = "즐겨찾기";
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Location = new Point(0, 0);
            label.Size = new Size(100, 20);
            label.Font = new Font(label.Font, FontStyle.Bold);
            //label.Font.Bold = true;
            //label.Font.Size = 10;
            //label.Size=new Size(1000,200);

            Controls.Add(label);
        }
        private Panel pn_create(int i, int j)
        {
            Panel p = new Panel();
            Label label = new Label();
            Label label1 = new Label();
            PictureBox picture = new PictureBox();

            p.Name = "panel" + (i * 2 + j + 1);
            p.Location = new Point(20 + i * 435, 30 + j * 140);
            p.Size = new Size(405, 120);
            p.BorderStyle = BorderStyle.FixedSingle;

            label.Text = "금천구, 서울특별시";
            label.Location = new Point(120, 10);
            label.Size = new Size(300, 30);
            label.Font = new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Bold);

            label1.Text = (13).ToString() + "˚C";
            label1.Location = new Point(150, 50);
            label1.Size = new Size(100, 20);
            label1.Font = new Font(FontFamily.GenericSerif, 14.0F);

            picture.Image = Bitmap.FromFile(@"image\dust1.png");
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Location = new Point(5,20);
            picture.Size = new Size(50,50);
            //picture.Image = 

            p.Controls.Add(label);
            p.Controls.Add(label1);
            p.Controls.Add(picture);
            return p;
        }
        //private void TableLayoutPanelCreate()
        //{
        //    tableLayoutPanel1 = new TableLayoutPanel();

        //    tableLayoutPanel1.ColumnCount = 2;
        //    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        //    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        //    //tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        //    tableLayoutPanel1.Location = new Point(20,30);
        //    tableLayoutPanel1.Name = "tableLayoutPanel1";
        //    tableLayoutPanel1.RowCount = 3;
        //    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        //    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        //    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        //    tableLayoutPanel1.Size = new Size(720,300);
        //    tableLayoutPanel1.TabIndex = 0;
        //    tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
        //    tableLayoutPanel1.BackColor = Color.AntiqueWhite;

        //    Controls.Add(tableLayoutPanel1);
        //}

        //private void TableLayoutPanelDataInsert()
        //{
        //    //tableLayoutPanel1
        //}

    }
}
