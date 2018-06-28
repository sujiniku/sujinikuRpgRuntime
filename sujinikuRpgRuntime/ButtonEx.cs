using System;
using System.Windows.Forms;

public class ButtonEx : Button
{
    protected override bool IsInputKey(Keys keyData)
    {
        //Altキーが押されているか確認する
        if ((keyData & Keys.Alt) != Keys.Alt)
        {
            //矢印キーが押されたときは、trueを返す
            Keys kcode = keyData & Keys.KeyCode;
            if (kcode == Keys.Up || kcode == Keys.Down ||
                kcode == Keys.Left || kcode == Keys.Right)
            {
                return true;
            }
        }
        return base.IsInputKey(keyData);
    }
}