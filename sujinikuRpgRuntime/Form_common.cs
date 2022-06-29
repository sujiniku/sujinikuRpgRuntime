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
    { 
        // 当フォームではディスプレイ画面全体を管理しますので、
        // オープニングからは直接には行けないメニュー画面や戦闘画面なども
        // 管理します。なので、
        // けっして、下記のメニュー画面などのコントロールは消さないでください。

        public static UserControl1_opening ctr_opening; // オープニング画面
        public static UserControl2_map ctr_map; // マップ画面
        public static UserControl3_menu ctr_menu; // メニュー画面
        // public static tool_panel ctr4; // 道具選択の画面


 public static int item1kosuu =5;

        public Form1()
        {
            InitializeComponent();
            ctr_opening = new UserControl1_opening();
            ctr_map = new UserControl2_map();
            ctr_menu = new UserControl3_menu(); 
            // ctr4 = new tool_panel(); // 消す予定

            // パネルにコントロールを追加
            panel1.Controls.Add(ctr_opening);
            panel1.Controls.Add(ctr_map);
            panel1.Controls.Add(ctr_menu); // 消したら動作しない

            // ゲーム起動後にすぐオープニング画面に移行
            ctr_opening.Visible = true;
            ctr_map.Visible = false; // 念のため、マップ表示を非表示に初期化
            ctr_menu.Visible = false;// 念のため、メニュー表示を非表示に初期化
            // ctr4.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
