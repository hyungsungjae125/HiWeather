using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Hiweather
{
    public partial class Form_information_bak : Form
    {

        public Form_information_bak()
        {
            InitializeComponent();
            Load += Form_information_Load;
        }


        private Button btn;
        private Label lb;


        private void Form_information_Load(object sender, EventArgs e)
        {
            ArrayList arrList = new ArrayList();

            arrList.Add(new Item("label", 30, 110, "lb_1"));

            for (int i = 0; i < arrList.Count; i++)
            {
                Control_Create((Item)arrList[i]);
            }

        }


        private Control Control_Create(Item item)
        {
            Control ctr = new Control();

            switch (item.getType())
            {
                case "button":
                    Button btn = new Button();
                    btn.DialogResult = DialogResult.OK;
                    btn.Cursor = Cursors.Hand;
                    //btn.Click += btn_click;
                    ctr = btn;
                    break;
                case "label":
                    ctr = new Label();
                    break;
                default:
                    break;
            }

            ctr.Name = item.getTxt();
            ctr.Text = item.getTxt();
            ctr.Size = new Size(100, 50);  // 사이즈 설정
            ctr.Location = new Point(item.getX(), item.getY());  // 위치지정
            Controls.Add(ctr);

            return ctr;
        }


        private Label lb_create(int i)
        {

            lb = new Label();
            lb.Name = string.Format("btn_{0}", (i + 1));
            lb.Text = string.Format("확인 : {0}", (i + 1));
            lb.Size = new Size(100, 50);  // 사이즈 설정
            lb.Location = new Point((100 * i) + 30, 30);  // 위치지정
            return lb;
        }

        // 생성한 버튼에 대한 옵션
        private void btn_click(object o, EventArgs a)
        {
            string names = "";
            foreach (Control ct in Controls)
            {
                // names += ct.Name + " ";
                //if(ct.Name != "btn_3")
                //{
                ct.BackColor = Color.Silver;
                //}                
            }
            // 생성한 버튼 연결
            btn = (Button)o;
            //btn.BackColor = (btn.BackColor == Color.Green) ? btn.BackColor = Color.Silver : btn.BackColor = Color.Green;                     
        }
        // 테스트
    }
 
}
