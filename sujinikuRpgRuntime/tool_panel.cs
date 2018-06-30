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
                // Form1.ctr_menu.panel1_menu.BackColor = Color.Azure;
                UserControl3_menu.menu_kaisou = 1;
                Form1.ctr_menu.Visible = true;
                UserControl3_menu.ctr_tool.Visible = false;
            }
        }
    }
}
