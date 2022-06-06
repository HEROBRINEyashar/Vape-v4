namespace Vape_Launcher
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.buttonAnimation = new System.Windows.Forms.Timer(this.components);
            this.vapeLite = new System.Windows.Forms.PictureBox();
            this.vapeV4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.vapeV4box = new Guna.UI.WinForms.GunaRadioButton();
            this.vapeLiteBox = new Guna.UI.WinForms.GunaRadioButton();
            this.log = new Guna.UI.WinForms.GunaLabel();
            this.loadingGif = new System.Windows.Forms.PictureBox();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vapeLite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vapeV4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 1;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaGradientButton1.Animated = true;
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(102)))));
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(164)))));
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.BorderSize = 3;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gunaGradientButton1.Image = null;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(134, 151);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(102)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(164)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Radius = 2;
            this.gunaGradientButton1.Size = new System.Drawing.Size(128, 33);
            this.gunaGradientButton1.TabIndex = 9;
            this.gunaGradientButton1.Text = "Start";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel1);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(369, 1);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(20, 18);
            this.gunaElipsePanel1.TabIndex = 10;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.gunaLabel1.Location = new System.Drawing.Point(3, 1);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(14, 14);
            this.gunaLabel1.TabIndex = 11;
            this.gunaLabel1.Text = "X";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // buttonAnimation
            // 
            this.buttonAnimation.Tick += new System.EventHandler(this.buttonAnimation_Tick);
            // 
            // vapeLite
            // 
            this.vapeLite.Image = global::Vape_Launcher.Properties.Resources.VapeLiteLogo;
            this.vapeLite.Location = new System.Drawing.Point(223, 20);
            this.vapeLite.Name = "vapeLite";
            this.vapeLite.Size = new System.Drawing.Size(83, 41);
            this.vapeLite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.vapeLite.TabIndex = 6;
            this.vapeLite.TabStop = false;
            // 
            // vapeV4
            // 
            this.vapeV4.Image = global::Vape_Launcher.Properties.Resources.VapeV4Logo;
            this.vapeV4.Location = new System.Drawing.Point(80, 30);
            this.vapeV4.Name = "vapeV4";
            this.vapeV4.Size = new System.Drawing.Size(100, 21);
            this.vapeV4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.vapeV4.TabIndex = 5;
            this.vapeV4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Vape_Launcher.Properties.Resources.black2;
            this.pictureBox3.Location = new System.Drawing.Point(312, 85);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(93, 131);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vape_Launcher.Properties.Resources.black1;
            this.pictureBox2.Location = new System.Drawing.Point(-76, -11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 176);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // vapeV4box
            // 
            this.vapeV4box.BaseColor = System.Drawing.SystemColors.Control;
            this.vapeV4box.CheckedOffColor = System.Drawing.Color.Gray;
            this.vapeV4box.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(102)))));
            this.vapeV4box.FillColor = System.Drawing.Color.White;
            this.vapeV4box.Location = new System.Drawing.Point(118, 57);
            this.vapeV4box.Name = "vapeV4box";
            this.vapeV4box.Size = new System.Drawing.Size(20, 20);
            this.vapeV4box.TabIndex = 12;
            // 
            // vapeLiteBox
            // 
            this.vapeLiteBox.BaseColor = System.Drawing.SystemColors.Control;
            this.vapeLiteBox.CheckedOffColor = System.Drawing.Color.Gray;
            this.vapeLiteBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(102)))));
            this.vapeLiteBox.FillColor = System.Drawing.Color.White;
            this.vapeLiteBox.Location = new System.Drawing.Point(253, 57);
            this.vapeLiteBox.Name = "vapeLiteBox";
            this.vapeLiteBox.Size = new System.Drawing.Size(20, 20);
            this.vapeLiteBox.TabIndex = 13;
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.Transparent;
            this.log.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.log.ForeColor = System.Drawing.Color.White;
            this.log.Location = new System.Drawing.Point(63, 80);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(272, 32);
            this.log.TabIndex = 14;
            this.log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadingGif
            // 
            this.loadingGif.Image = global::Vape_Launcher.Properties.Resources.Spinner_1s_200px;
            this.loadingGif.Location = new System.Drawing.Point(155, 210);
            this.loadingGif.Name = "loadingGif";
            this.loadingGif.Size = new System.Drawing.Size(90, 90);
            this.loadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingGif.TabIndex = 15;
            this.loadingGif.TabStop = false;
            this.loadingGif.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(392, 209);
            this.Controls.Add(this.loadingGif);
            this.Controls.Add(this.log);
            this.Controls.Add(this.vapeLiteBox);
            this.Controls.Add(this.vapeV4box);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.vapeLite);
            this.Controls.Add(this.vapeV4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Vape Loader";
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vapeLite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vapeV4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox vapeV4;
        private System.Windows.Forms.PictureBox vapeLite;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Timer buttonAnimation;
        private Guna.UI.WinForms.GunaRadioButton vapeLiteBox;
        private Guna.UI.WinForms.GunaRadioButton vapeV4box;
        private Guna.UI.WinForms.GunaLabel log;
        private System.Windows.Forms.PictureBox loadingGif;
    }
}

