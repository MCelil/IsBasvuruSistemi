namespace BasvuruSistemi
{
    partial class Frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.kullaniciadiTxt = new DevExpress.XtraEditors.TextEdit();
            this.sifreTxt = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciadiTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifreTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // kullaniciadiTxt
            // 
            this.kullaniciadiTxt.Location = new System.Drawing.Point(165, 58);
            this.kullaniciadiTxt.Name = "kullaniciadiTxt";
            this.kullaniciadiTxt.Size = new System.Drawing.Size(152, 20);
            this.kullaniciadiTxt.TabIndex = 1;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(165, 90);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Properties.PasswordChar = '*';
            this.sifreTxt.Size = new System.Drawing.Size(152, 20);
            this.sifreTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // loginBtn
            // 
            this.loginBtn.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginBtn.Appearance.Options.UseFont = true;
            this.loginBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("loginBtn.ImageOptions.SvgImage")));
            this.loginBtn.Location = new System.Drawing.Point(165, 131);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(152, 33);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Giriş Yap";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(438, 276);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kullaniciadiTxt);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoşgeldiniz";
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciadiTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifreTxt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit kullaniciadiTxt;
        private DevExpress.XtraEditors.TextEdit sifreTxt;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton loginBtn;
    }
}