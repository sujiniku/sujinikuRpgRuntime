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
    public partial class tool_panel : UserControl
    {
        public tool_panel()
        {
            InitializeComponent();
        }

        private void tool_panel_Load(object sender, EventArgs e)
        {


        }

        private void tool_panel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Escで前画面に戻る // Keys.Escape
            if (e.KeyData == Keys.Escape || e.KeyData == Keys.B || e.KeyData == Keys.C ) 
            {
            
            MessageBox.Show("bb");
            
            
                // Form1.ctr_menu.panel1_menu.BackColor = Color.Azure;
                UserControl3_menu.menu_kaisou = 1;
                Form1.ctr_menu.Visible = true;
                UserControl3_menu.ctr_tool.Visible = false;
            }
            
            
            // Zボタンでアイテム1個の使用のテスト // Keys.Escape
            if (e.KeyData == Keys.Z   ) 
            {
            
            MessageBox.Show("aaaa");
                // Form1.ctr_menu.panel1_menu.BackColor = Color.Azure;
               UserControl1_opening.item1kosuu = UserControl1_opening.item1kosuu -1;
               
               this.kosuu1.Text = UserControl1_opening.item1kosuu.ToString(); //"kosuu1";
               Invalidate();
               
               
               
            }



            if (UserControl1_opening.item1kosuu == 24 )
            {

                MessageBox.Show("一時的に 24  ");
                // Form1.ctr_menu.panel1_menu.BackColor = Color.Azure;
               // Program.item1kosuu = Program.item1kosuu - 1;
               
               
               
            }

            if (UserControl1_opening.item1kosuu == 22 )
            {

                MessageBox.Show("22 一時的に 22  ");
                // Form1.ctr_menu.panel1_menu.BackColor = Color.Azure;
               // Program.item1kosuu = Program.item1kosuu - 1;
            }



        }

        private void kosuu1_Click(object sender, EventArgs e)
        {

        }
    }
}
