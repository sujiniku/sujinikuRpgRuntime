using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    { //staticで宣言することでインスタンスを固定
        public static UserControl1 ctr1;
        public static UserControl2 ctr2;


        public Form1()
        {
            InitializeComponent();
            ctr1 = new UserControl1();
            ctr2 = new UserControl2();

            //パネルにコントロール１、２を追加
            panel1.Controls.Add(ctr1);
            panel1.Controls.Add(ctr2);

            //コントロール1のみを見えるようにする
            ctr1.Visible = true;
            ctr2.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
