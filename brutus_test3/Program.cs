using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace brutus_test3
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ミューテックス作成
            Mutex app_mutex = new Mutex(false, "MYSOFTWARE_001");

            //ミューテックスの所有権を要求する
            if (app_mutex.WaitOne(0, false) == false)
            {
                MessageBox.Show("このアプリケーションは多重起動できません。");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new title_screen());
        }
    }
}
