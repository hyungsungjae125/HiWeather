using System;
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
        }
        Label label;
        TableLayoutPanel tableLayoutPanel1;
        private void Form_bookmark_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
            MainLabelCreate();
            TableLayoutPanelCreate();
        }
        private void MainLabelCreate()
        {
            label = new Label();
            label.Name = "label";
            label.Text = "즐겨찾기";
            label.Location = new Point(20, 50);
            label.Font = new Font(label.Font, FontStyle.Bold);
            //label.Font.Bold = true;
            //label.Font.Size = 10;
            //label.Size=new Size(1000,200);
            
            
            Controls.Add(label);
        }
        private void TableLayoutPanelCreate()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(50,100);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(900,450);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.BackColor = Color.AntiqueWhite;

            Controls.Add(tableLayoutPanel1);
        }

        private void TableLayoutPanelDataInsert()
        {
            //tableLayoutPanel1
        }

    }
}
