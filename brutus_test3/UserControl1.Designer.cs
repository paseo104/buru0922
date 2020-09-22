namespace brutus_test3
{
    partial class UserControl1
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.home_button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.home_button)).BeginInit();
            this.SuspendLayout();
            // 
            // home_button
            // 
            this.home_button.BackColor = System.Drawing.Color.Transparent;
            this.home_button.Image = ((System.Drawing.Image)(resources.GetObject("home_button.Image")));
            this.home_button.Location = new System.Drawing.Point(185, 199);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(130, 71);
            this.home_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.home_button.TabIndex = 3;
            this.home_button.TabStop = false;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.home_button);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(500, 300);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.home_button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox home_button;
    }
}
