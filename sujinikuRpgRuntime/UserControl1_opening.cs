using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sujinikuRpgRuntime
{
    public partial class UserControl1_opening : UserControl
    {

        public static int item1kosuu ;


        public UserControl1_opening()
        {
            
            InitializeComponent();
            item1kosuu = 25;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ctr_opening.Visible = false;
            Form1.ctr_map.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
