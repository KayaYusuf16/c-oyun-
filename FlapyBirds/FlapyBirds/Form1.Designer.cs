namespace FlapyBirds
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_top = new System.Windows.Forms.PictureBox();
            this.pictureBox_down = new System.Windows.Forms.PictureBox();
            this.pictureBox_bird = new System.Windows.Forms.PictureBox();
            this.pictureBox_bot = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_GameControl = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bot)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_top
            // 
            this.pictureBox_top.Image = global::FlapyBirds.Properties.Resources.pipedown;
            this.pictureBox_top.Location = new System.Drawing.Point(676, 2);
            this.pictureBox_top.Name = "pictureBox_top";
            this.pictureBox_top.Size = new System.Drawing.Size(127, 215);
            this.pictureBox_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_top.TabIndex = 0;
            this.pictureBox_top.TabStop = false;
            // 
            // pictureBox_down
            // 
            this.pictureBox_down.Image = global::FlapyBirds.Properties.Resources.pipe;
            this.pictureBox_down.Location = new System.Drawing.Point(455, 410);
            this.pictureBox_down.Name = "pictureBox_down";
            this.pictureBox_down.Size = new System.Drawing.Size(127, 247);
            this.pictureBox_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_down.TabIndex = 1;
            this.pictureBox_down.TabStop = false;
            this.pictureBox_down.Click += new System.EventHandler(this.pictureBox_down_Click);
            // 
            // pictureBox_bird
            // 
            this.pictureBox_bird.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_bird.Image")));
            this.pictureBox_bird.Location = new System.Drawing.Point(44, 161);
            this.pictureBox_bird.Name = "pictureBox_bird";
            this.pictureBox_bird.Size = new System.Drawing.Size(104, 75);
            this.pictureBox_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bird.TabIndex = 2;
            this.pictureBox_bird.TabStop = false;
            // 
            // pictureBox_bot
            // 
            this.pictureBox_bot.Image = global::FlapyBirds.Properties.Resources.ground;
            this.pictureBox_bot.Location = new System.Drawing.Point(-2, 654);
            this.pictureBox_bot.Name = "pictureBox_bot";
            this.pictureBox_bot.Size = new System.Drawing.Size(852, 91);
            this.pictureBox_bot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bot.TabIndex = 3;
            this.pictureBox_bot.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "SCORE:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer_GameControl
            // 
            this.timer_GameControl.Enabled = true;
            this.timer_GameControl.Interval = 20;
            this.timer_GameControl.Tick += new System.EventHandler(this.gameTimer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(851, 747);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_bot);
            this.Controls.Add(this.pictureBox_bird);
            this.Controls.Add(this.pictureBox_down);
            this.Controls.Add(this.pictureBox_top);
            this.Name = "Form1";
            this.Text = "Flapy Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_Up);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_top;
        private System.Windows.Forms.PictureBox pictureBox_down;
        private System.Windows.Forms.PictureBox pictureBox_bird;
        private System.Windows.Forms.PictureBox pictureBox_bot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_GameControl;
    }
}

