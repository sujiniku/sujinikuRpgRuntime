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
    public partial class UserControl3 : UserControl
    {
        int selecting_command = 1;

        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            selecting_command = 1;

            label1.BackColor = Color.Pink;
            label2.BackColor = Color.Transparent;

            label6.Text = "コマンド" + selecting_command.ToString() + "を選択中。";

        }



        private void UserControl3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            // 左右の矢印キーが押されたら選択コマンド番号を増減させる
            if (e.KeyData == Keys.Right && selecting_command < 5)
            {
                selecting_command = selecting_command  + 1;
            }

            else if (e.KeyData == Keys.Left && selecting_command > 1)
            {
                selecting_command = selecting_command - 1;
            }

            if (selecting_command == 1)
            {
                label1.BackColor = Color.Pink;
                label2.BackColor = Color.Transparent;
            }

            else if (selecting_command == 2)
            {
                label1.BackColor = Color.Transparent;
                label2.BackColor = Color.Pink;
                label3.BackColor = Color.Transparent;
            }

            else if (selecting_command == 3)
            {
                label2.BackColor = Color.Transparent;
                label3.BackColor = Color.Pink;
                label4.BackColor = Color.Transparent;
            }

            else if (selecting_command == 4)
            {
                label3.BackColor = Color.Transparent;
                label4.BackColor = Color.Pink;
                label5.BackColor = Color.Transparent;
            }

            else if (selecting_command == 5)
            {
                label4.BackColor = Color.Transparent;
                label5.BackColor = Color.Pink;
            }

            label6.Text = "コマンド" + selecting_command.ToString() + "を選択中。";

            // エスケープキーでマップ画面に戻る
            if (e.KeyData == Keys.Escape)
            {
                Form1.ctr1.Visible = false;
                Form1.ctr2.Visible = true;
                Form1.ctr3.Visible = false;
            }



        }
    }
}
