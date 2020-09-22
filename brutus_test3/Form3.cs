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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

 
        private void Home_Click(object sender, EventArgs e)
        {
            //自分自身のフォームを閉じる
            this.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 質問ダイアログを表示する
            DialogResult result = MessageBox.Show("ウィンドウを閉じますか？", "終了確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                // はいボタンをクリックしたときはウィンドウを閉じる
                e.Cancel = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Nextpage_Click(object sender, EventArgs e)
        {

        }
    }
}
