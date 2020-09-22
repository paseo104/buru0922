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
    public partial class title_screen : Form
    {
        public title_screen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            //自分自身のフォームを閉じる
            this.Close();
        }

        private void ENTER_Click(object sender, EventArgs e)
        {
            // モーダルで子フォームを表示
            radio_button Form4Obj; // 子ﾌｫｰﾑ
            Form4Obj = new radio_button(); // 子ﾌｫｰﾑ生成
            Form4Obj.ShowDialog(); // 子ﾌｫｰﾑを表示
        }

        private void RULEBOOK_Click(object sender, EventArgs e)
        {
            // Form3 form3 = new Form3();
            // form3.Show();
            // モーダルで子フォームを表示
            Form3 Form3Obj; // 子ﾌｫｰﾑ
            Form3Obj = new Form3(); // 子ﾌｫｰﾑ生成
            Form3Obj.ShowDialog(); // 子ﾌｫｰﾑを表示
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 質問ダイアログを表示する
            DialogResult result = MessageBox.Show("ソフトウエアを終了させますか？", "終了確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                // はいボタンをクリックしたときはウィンドウを閉じる
                e.Cancel = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}