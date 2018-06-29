using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sujinikuRpgRuntime
{
    public partial class Form1 : Form
    { //staticで宣言することでインスタンスを固定
        public static UserControl1 ctr1;
        public static UserControl2 ctr2;
        public static UserControl3 ctr3;

        public Form1()
        {
            InitializeComponent();
            ctr1 = new UserControl1();
            ctr2 = new UserControl2();
            ctr3 = new UserControl3();

            //パネルにコントロール１、２、３を追加
            panel1.Controls.Add(ctr1);
            panel1.Controls.Add(ctr2);
            panel1.Controls.Add(ctr3);

            //コントロール1のみを見えるようにする
            ctr1.Visible = true;
            ctr2.Visible = false;
            ctr3.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
