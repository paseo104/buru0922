using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brutus_test3
{
    public partial class radio_button : Form
    {
        public radio_button()
        {
            InitializeComponent();
        }

        private void radio_button_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = !this.MaximizeBox;
            this.MinimizeBox = !this.MinimizeBox;
            button1.FlatStyle = FlatStyle.Standard;
            // ロード時にフォーカスを設定する
            this.button1.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //自分自身のフォームを閉じる
            // モーダルの場合Disposeを用いる
            this.Dispose();

            //// モーダルで子フォームを表示
            //Form2 Form2Obj; // 子ﾌｫｰﾑ
            //Form2Obj = new Form2(); // 子ﾌｫｰﾑ生成
            //Form2Obj.ShowDialog(); // 子ﾌｫｰﾑを表示

            Brutus.FormBrutus FormGame;  // ブルータスのゲーム画面に遷移。
            FormGame = new Brutus.FormBrutus();
            FormGame.ShowDialog();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
