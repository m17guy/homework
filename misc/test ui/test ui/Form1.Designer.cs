namespace test_ui
{
    partial class back
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(back));
            this.lt = new System.Windows.Forms.Button();
            this.ht = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helthhero = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.helthvillin = new System.Windows.Forms.ProgressBar();
            this.attack = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.attack2 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.villinattack = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villinattack)).BeginInit();
            this.SuspendLayout();
            // 
            // lt
            // 
            this.lt.AccessibleName = "lt";
            this.lt.Location = new System.Drawing.Point(187, 309);
            this.lt.Name = "lt";
            this.lt.Size = new System.Drawing.Size(75, 23);
            this.lt.TabIndex = 0;
            this.lt.Text = "light attack";
            this.lt.UseVisualStyleBackColor = true;
            this.lt.Click += new System.EventHandler(this.button1_Click);
            // 
            // ht
            // 
            this.ht.Location = new System.Drawing.Point(137, 354);
            this.ht.Name = "ht";
            this.ht.Size = new System.Drawing.Size(78, 23);
            this.ht.TabIndex = 1;
            this.ht.Text = "heavy attack";
            this.ht.UseVisualStyleBackColor = true;
            this.ht.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(44, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 115);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // helthhero
            // 
            this.helthhero.Location = new System.Drawing.Point(44, 285);
            this.helthhero.Maximum = 120;
            this.helthhero.Name = "helthhero";
            this.helthhero.Size = new System.Drawing.Size(125, 23);
            this.helthhero.Step = -10;
            this.helthhero.TabIndex = 3;
            this.helthhero.Value = 120;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(542, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 115);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // helthvillin
            // 
            this.helthvillin.Location = new System.Drawing.Point(542, 276);
            this.helthvillin.Name = "helthvillin";
            this.helthvillin.Size = new System.Drawing.Size(100, 23);
            this.helthvillin.TabIndex = 5;
            this.helthvillin.Value = 100;
            // 
            // attack
            // 
            this.attack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("attack.BackgroundImage")));
            this.attack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.attack.Location = new System.Drawing.Point(158, 165);
            this.attack.Name = "attack";
            this.attack.Size = new System.Drawing.Size(57, 28);
            this.attack.TabIndex = 7;
            this.attack.TabStop = false;
            this.attack.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // attack2
            // 
            this.attack2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.attack2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("attack2.BackgroundImage")));
            this.attack2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.attack2.Location = new System.Drawing.Point(158, 181);
            this.attack2.Name = "attack2";
            this.attack2.Size = new System.Drawing.Size(100, 50);
            this.attack2.TabIndex = 8;
            this.attack2.TabStop = false;
            this.attack2.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // villinattack
            // 
            this.villinattack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("villinattack.BackgroundImage")));
            this.villinattack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.villinattack.Location = new System.Drawing.Point(478, 181);
            this.villinattack.Name = "villinattack";
            this.villinattack.Size = new System.Drawing.Size(58, 50);
            this.villinattack.TabIndex = 10;
            this.villinattack.TabStop = false;
            this.villinattack.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            this.label2.Visible = false;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // back
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.villinattack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attack2);
            this.Controls.Add(this.attack);
            this.Controls.Add(this.helthvillin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.helthhero);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ht);
            this.Controls.Add(this.lt);
            this.Name = "back";
            this.Text = "game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villinattack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lt;
        private System.Windows.Forms.Button ht;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar helthhero;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar helthvillin;
        private System.Windows.Forms.PictureBox attack;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox attack2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox villinattack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}

