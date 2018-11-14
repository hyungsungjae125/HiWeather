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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            BackColor = Color.SkyBlue;
            Load += Main_Load;
        }
        FlowLayoutPanel flowLayoutPanel1 = new FlowLayoutPanel();
        Button button;
        
         private void Main_Load(object sender, EventArgs e)
        {
            
           DrawFLP();
           DrawBTN("feedback","피드백",600,0);
           
           flowLayoutPanel1.Controls.Add(button);
          
           Controls.Add(flowLayoutPanel1);
            
        }
        private void DrawFLP()
        {
            BackColor = Color.Blue;
            flowLayoutPanel1.SuspendLayout();
            
            flowLayoutPanel1.Location = new Point(0,0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(692, 391);
            flowLayoutPanel1.TabIndex = 0;
           
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
           AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
        }
        private void DrawBTN(string b_name,string b_text,int x, int y)
        {
            button = new Button();
            button.DialogResult = DialogResult.OK;
            button.Location = new System.Drawing.Point(x, y);
            button.Name = b_name;
            button.Size = new System.Drawing.Size(75, 23);
           button.Text = b_text;
            button.Cursor = Cursors.Hand;
            button.UseVisualStyleBackColor = true;
        }
       
    }
}
