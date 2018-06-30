namespace sujinikuRpgRuntime
{
    partial class UserControl2_map
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.debug_label5 = new System.Windows.Forms.Label();
            this.debug_label2 = new System.Windows.Forms.Label();
            this.debug_label3 = new System.Windows.Forms.Label();
            this.message_label2 = new System.Windows.Forms.Label();
            this.debug_label1 = new System.Windows.Forms.Label();
            this.debug_label4 = new System.Windows.Forms.Label();
            this.message_label1 = new System.Windows.Forms.Label();
            this.debug_panel1 = new System.Windows.Forms.Panel();
            this.debug_panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // debug_label5
            // 
            this.debug_label5.AutoSize = true;
            this.debug_label5.Location = new System.Drawing.Point(32, 133);
            this.debug_label5.Name = "debug_label5";
            this.debug_label5.Size = new System.Drawing.Size(169, 12);
            this.debug_label5.TabIndex = 0;
            this.debug_label5.Text = "debug_label5 Paintの状態確認用";
            // 
            // debug_label2
            // 
            this.debug_label2.AutoSize = true;
            this.debug_label2.Location = new System.Drawing.Point(14, 36);
            this.debug_label2.Name = "debug_label2";
            this.debug_label2.Size = new System.Drawing.Size(162, 12);
            this.debug_label2.TabIndex = 1;
            this.debug_label2.Text = "debug_label2 主人公のいる座標";
            // 
            // debug_label3
            // 
            this.debug_label3.AutoSize = true;
            this.debug_label3.Location = new System.Drawing.Point(14, 63);
            this.debug_label3.Name = "debug_label3";
            this.debug_label3.Size = new System.Drawing.Size(200, 12);
            this.debug_label3.TabIndex = 2;
            this.debug_label3.Text = "debug_label3 移動先の進行可能を判定";
            // 
            // message_label2
            // 
            this.message_label2.AutoSize = true;
            this.message_label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.message_label2.Location = new System.Drawing.Point(294, 24);
            this.message_label2.Name = "message_label2";
            this.message_label2.Size = new System.Drawing.Size(257, 81);
            this.message_label2.TabIndex = 3;
            this.message_label2.Text = "message_label2 \r\n矢印キーで\r\nキャラを動かしてください";
            // 
            // debug_label1
            // 
            this.debug_label1.AutoSize = true;
            this.debug_label1.Location = new System.Drawing.Point(14, 11);
            this.debug_label1.Name = "debug_label1";
            this.debug_label1.Size = new System.Drawing.Size(200, 12);
            this.debug_label1.TabIndex = 5;
            this.debug_label1.Text = "debug_label1 下記はデバッグ用メッセージ";
            // 
            // debug_label4
            // 
            this.debug_label4.AutoSize = true;
            this.debug_label4.Location = new System.Drawing.Point(14, 92);
            this.debug_label4.Name = "debug_label4";
            this.debug_label4.Size = new System.Drawing.Size(151, 12);
            this.debug_label4.TabIndex = 6;
            this.debug_label4.Text = "debug_label4 キー入力の検出";
            // 
            // message_label1
            // 
            this.message_label1.AutoSize = true;
            this.message_label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.message_label1.Location = new System.Drawing.Point(21, 363);
            this.message_label1.Name = "message_label1";
            this.message_label1.Size = new System.Drawing.Size(576, 54);
            this.message_label1.TabIndex = 7;
            this.message_label1.Text = "message_label1 \r\nMボタン または Escボタン でメニュー画面に移行します";
            // 
            // debug_panel1
            // 
            this.debug_panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.debug_panel1.Controls.Add(this.debug_label4);
            this.debug_panel1.Controls.Add(this.debug_label1);
            this.debug_panel1.Controls.Add(this.debug_label3);
            this.debug_panel1.Controls.Add(this.debug_label5);
            this.debug_panel1.Controls.Add(this.debug_label2);
            this.debug_panel1.Location = new System.Drawing.Point(9, 13);
            this.debug_panel1.Name = "debug_panel1";
            this.debug_panel1.Size = new System.Drawing.Size(245, 155);
            this.debug_panel1.TabIndex = 8;
            // 
            // UserControl2_map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.debug_panel1);
            this.Controls.Add(this.message_label1);
            this.Controls.Add(this.message_label2);
            this.DoubleBuffered = true;
            this.Name = "UserControl2_map";
            this.Size = new System.Drawing.Size(640, 480);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControl2_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserControl2_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.UserControl2_PreviewKeyDown);
            this.debug_panel1.ResumeLayout(false);
            this.debug_panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label debug_label5;
        private System.Windows.Forms.Label debug_label2;
        private System.Windows.Forms.Label debug_label3;
        private System.Windows.Forms.Label message_label2;
        private System.Windows.Forms.Label debug_label1;
        private System.Windows.Forms.Label debug_label4;
        private System.Windows.Forms.Label message_label1;
        private System.Windows.Forms.Panel debug_panel1;
    }
}
