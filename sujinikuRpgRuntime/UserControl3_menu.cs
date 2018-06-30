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
    public partial class UserControl3_menu : UserControl
    {

        public static tool_panel ctr4; // 道具選択の画面

        int selecting_command = 1;

        // 各メニュー専用のコントロールを確保
        public static tool_panel ctr_tool; // 道具選択の画面
                                           // public static equip_panel ctr5; // 装備選択の画面
                                           // public static skill_panel ctr6; // ワザ選択の画面
                                           // public static skill_panel ctr7; // システム選択の画面

        public static int menu_kaisou = 1; // menu_kaisou が1の場合のみ、一番上のメニューを動かせる

        public UserControl3_menu()
        {
            InitializeComponent();
            ctr_tool = new tool_panel();
            ctr4 = new tool_panel();

        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            selecting_command = 1;

            main_menu1.BackColor = Color.Pink;
            main_menu2.BackColor = Color.Transparent;

            debug_label2.Text = "コマンド" + selecting_command.ToString() + "を選択中。";

            ctr_tool.Visible = false;
            ctr4.Visible = false;



        }

        private void UserControl3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (menu_kaisou == 1)
            {
                Form1.ctr_menu.panel1_menu.BackColor = Color.Azure;

                // 左右の矢印キーが押されたら選択コマンド番号を増減させる
                if (e.KeyData == Keys.Right && selecting_command < 10) // 右キーが押された場合
                {
                    selecting_command = selecting_command + 1;
                }
                else if (e.KeyData == Keys.Left && selecting_command > 1) // 左キーが押された場合
                {
                    selecting_command = selecting_command - 1;
                }

                // 上下の矢印キーが押されたら選択コマンド番号を5だけ増減させる
                if (e.KeyData == Keys.Down && selecting_command < 6) // 上キーが押された場合
                {
                    selecting_command = selecting_command + 5;
                }
                else if (e.KeyData == Keys.Up && selecting_command > 5) // 左キーが押された場合
                {
                    selecting_command = selecting_command - 5;
                }

                // メインメニューのカーソル背景色は、いったん透明に
                main_menu1.BackColor = Color.Transparent;
                main_menu2.BackColor = Color.Transparent;
                main_menu3.BackColor = Color.Transparent;
                main_menu4.BackColor = Color.Transparent;
                main_menu5.BackColor = Color.Transparent;
                main_menu6.BackColor = Color.Transparent;
                main_menu7.BackColor = Color.Transparent;
                main_menu8.BackColor = Color.Transparent;
                main_menu10.BackColor = Color.Transparent;
                main_menu9.BackColor = Color.Transparent;


                // コマンド番号に対応するメニューを背景色で強調
                // switch文は使わず、if文で書いた。breakを忘れそうなので。
                if (selecting_command == 1)
                {
                    main_menu1.BackColor = Color.Pink;
                    main_menu2.BackColor = Color.Transparent;
                    main_menu6.BackColor = Color.Transparent;
                }
                else if (selecting_command == 2)
                {
                    main_menu1.BackColor = Color.Transparent;
                    main_menu2.BackColor = Color.Pink;
                    main_menu3.BackColor = Color.Transparent;
                    main_menu7.BackColor = Color.Transparent;
                }
                else if (selecting_command == 3)
                {
                    main_menu2.BackColor = Color.Transparent;
                    main_menu3.BackColor = Color.Pink;
                    main_menu4.BackColor = Color.Transparent;
                    main_menu8.BackColor = Color.Transparent;
                }
                else if (selecting_command == 4)
                {
                    main_menu3.BackColor = Color.Transparent;
                    main_menu4.BackColor = Color.Pink;
                    main_menu5.BackColor = Color.Transparent;
                    main_menu10.BackColor = Color.Transparent;

                }
                else if (selecting_command == 5)
                {
                    main_menu4.BackColor = Color.Transparent;
                    main_menu5.BackColor = Color.Pink;
                    main_menu10.BackColor = Color.Transparent;
                }
                else if (selecting_command == 6)
                {
                    main_menu5.BackColor = Color.Transparent;
                    main_menu6.BackColor = Color.Pink;
                    main_menu9.BackColor = Color.Transparent;
                }
                else if (selecting_command == 7)
                {
                    main_menu7.BackColor = Color.Pink;
                }
                else if (selecting_command == 8)
                {
                    main_menu8.BackColor = Color.Pink;
                }
                else if (selecting_command == 9)
                {
                    main_menu9.BackColor = Color.Pink;
                }
                else if (selecting_command == 10)
                {
                    main_menu10.BackColor = Color.Pink;
                }

                // デバッグ用のメッセージ
                debug_label2.Text = "コマンド" + selecting_command.ToString() + "を選択中。";


                // 決定ボタン（Zなど）が押されたら、選択している各メニューを開く

                // 道具メニューが押された場合
                if ( (e.KeyData == Keys.Z || e.KeyData == Keys.D || e.KeyData == Keys.O) && selecting_command == 1)
                {
                    menu_kaisou = 2;
                    panel1_menu.BackColor = Color.Transparent;
                    panel_display.Controls.Add(ctr_tool);
                    ctr_tool.Visible = true;
                }

                // Escキーなどでマップ画面に戻る
                if (e.KeyData == Keys.Escape || e.KeyData == Keys.B || e.KeyData == Keys.C)
                {
                    menu_kaisou = 1;
                    Form1.ctr_opening.Visible = false;
                    Form1.ctr_map.Visible = true;
                    Form1.ctr_menu.Visible = false;
                }
            }
        }

        private void panel_display_Paint(object sender, PaintEventArgs e)
        {

        }

        private void debug_label2_Click(object sender, EventArgs e)
        {

        }
    }
}
