﻿using System;
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
    public partial class UserControl2_map : UserControl
    {
        public static UserControl3_menu ctr_menu; // メニュー画面
        

        int chx;
        int chy;

        int saisyo_x = 3;
        int saisyo_y = 4;

        public UserControl2_map()
        {
            chx = saisyo_x;
            chy = saisyo_y;

            InitializeComponent();
            debug_label2.Text = "x座標= " + chx.ToString() + ",  " + "y座標= " + chy.ToString();
            debug_label5.Text = "今、UserControl2";





        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

            chx = saisyo_x;
            chy = saisyo_y;

            debug_label5.Text = "今、UserControl2_Load";

            ctr_menu = new UserControl3_menu(); // 消す予定
        }

        // マップ上での主人公の画像を読み込み。こいつが移動する
        Image hero_mapchip = Image.FromFile("hero_dot.png ");

        // シーン遷移のため。 
        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ctr_opening.Visible = true;
            Form1.ctr_map.Visible = false;
        }

        private void UserControl2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        // 使用してない？ マップのサイズの変数
        int map_x_size = 10;
        int map_y_size = 7;

        // マップのデータ
        int[,] maptable = new int[7, 10] // [y.x]
        {
             {  1,1,1,1,1,1,1,1,1,1}, //0 x
	         {  1,0,0,0,0,0,0,0,0,1}, //1
	         {  1,0,0,0,0,0,0,0,0,1}, //2
	         {  1,0,0,0,0,0,0,0,0,1}, //3
	         {  1,0,0,0,0,0,0,0,0,1}, //4
	         {  1,0,0,0,0,0,0,0,0,1}, //5
	         {  1,1,1,1,1,1,1,1,1,1}  //6
        };


        // 進行先の壁判定のアルゴリズム
        int desti_x; // 進行先の壁判定のためのx座標変数
        int desti_y; // 進行先の壁判定のためのx座標変数

        private void UserControl2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            debug_label4.Text = "何かキーが押されました。";
                                
            // 進行先の座標に一時的に主人公の座標を代入
            desti_x = chx;
            desti_y = chy;

            // 矢印キーが押されたら移動判定モードに遷移
            if (e.KeyData == Keys.Right || e.KeyData == Keys.Left
                || e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                switch (e.KeyData)
                {
                    // 押された矢印キーに応じて、移動先座標を代入
                    case Keys.Right:
                        debug_label4.Text = "右キーが押されました。";
                        desti_x = chx + 1;
                        break;
                    case Keys.Left:
                        debug_label4.Text = "左キーが押されました。";
                        desti_x = chx - 1;
                        break;
                    case Keys.Up:
                        debug_label4.Text = "上キーが押されました。";
                        desti_y = chy - 1;
                        break;
                    case Keys.Down:
                        debug_label4.Text = "下キーが押されました。";
                        desti_y = chy + 1;
                        break;
                }

                // 押された矢印キーに応じて、移動先座標を代入
                if (desti_x >= 0 && desti_x < map_x_size && desti_y >= 0 && desti_y < map_y_size)
                {
                    if (maptable[desti_y, desti_x] == 1) // 進行先が壁
                    {
                        debug_label3.Text = "行き止まり。進行先の x座標= " + desti_x.ToString() + ",  " + "y座標= " + desti_y.ToString();
                        desti_x = chx; // 移動先の破棄
                        desti_y = chy;
                    }

                    else if (maptable[desti_y, desti_x] != 1) // 進行先に移動可能
                    {
                        chx = desti_x;
                        chy = desti_y;
                        debug_label3.Text = "1歩、進んだ。";
                    }

                    debug_label2.Text = "x座標= " + chx.ToString() + ",  " + "y座標= " + chy.ToString();
                }
                Invalidate();
            }

            // メニュー画面に移行
            if (e.KeyData == Keys.M || e.KeyData == Keys.Escape)
            {
                // debug_label4.Text = "キーが押されました。"; // マップ画面が消えるので、これはメッセージ表示されない
                Form1.ctr_opening.Visible = false;
                Form1.ctr_map.Visible = false;
                Form1.ctr_menu.Visible = true;
            }
        }

        private void UserControl2_Paint(object sender, PaintEventArgs e)
        {

            debug_label5.Text = "今、Paintに居る。x座標= " + chx.ToString();

            // マップを描画
            Image mapchip_image = Image.FromFile("mapchip_grass.png "); // 

            for (int x = 0; x <= 9; ++x)
            {
                for (int y = 0; y <= 6; ++y)
                {
                    switch (maptable[y, x])
                    {
                        case (0):
                            mapchip_image = Image.FromFile("mapchip_grass.png ");
                            break;

                        case (1):
                            mapchip_image = Image.FromFile("mapchip_wall.png ");
                            break;
                    }
                    e.Graphics.DrawImage(mapchip_image, 225 + x * 32, 140 + y * 32, 32, 32);

                }
            }
            
            // 主人公の位置を表示
            e.Graphics.DrawImage(hero_mapchip, 320 + (chx - saisyo_x) * 32, 270 + (chy - saisyo_y) * (32), hero_mapchip.Width, hero_mapchip.Height);

        }
    }
}
