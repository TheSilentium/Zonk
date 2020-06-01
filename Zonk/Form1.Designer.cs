namespace Zonk
{
    partial class Form1
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
            this.btn_throw = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_wd = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.flp_Dices = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_otobrano = new System.Windows.Forms.Label();
            this.lb_round = new System.Windows.Forms.Label();
            this.lb_round_points = new System.Windows.Forms.Label();
            this.lb_points = new System.Windows.Forms.Label();
            this.lb_test = new System.Windows.Forms.Label();
            this.flp_default = new System.Windows.Forms.FlowLayoutPanel();
            this.pB_dice_1 = new System.Windows.Forms.PictureBox();
            this.pB_dice_2 = new System.Windows.Forms.PictureBox();
            this.pB_dice_3 = new System.Windows.Forms.PictureBox();
            this.pB_dice_4 = new System.Windows.Forms.PictureBox();
            this.pB_dice_5 = new System.Windows.Forms.PictureBox();
            this.pB_dice_6 = new System.Windows.Forms.PictureBox();
            this.btn_Instructions = new System.Windows.Forms.Button();
            this.pb_test = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flp_default.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_dice_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_dice_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_dice_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_dice_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_dice_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_dice_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_throw
            // 
            this.btn_throw.BackColor = System.Drawing.SystemColors.Control;
            this.btn_throw.Location = new System.Drawing.Point(428, 443);
            this.btn_throw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_throw.Name = "btn_throw";
            this.btn_throw.Size = new System.Drawing.Size(170, 69);
            this.btn_throw.TabIndex = 10;
            this.btn_throw.Text = "бросить кости";
            this.btn_throw.UseVisualStyleBackColor = false;
            this.btn_throw.Click += new System.EventHandler(this.btn_throw_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_wd
            // 
            this.btn_wd.BackColor = System.Drawing.SystemColors.Control;
            this.btn_wd.Enabled = false;
            this.btn_wd.Location = new System.Drawing.Point(603, 443);
            this.btn_wd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_wd.Name = "btn_wd";
            this.btn_wd.Size = new System.Drawing.Size(158, 69);
            this.btn_wd.TabIndex = 11;
            this.btn_wd.Text = "записать счет";
            this.btn_wd.UseVisualStyleBackColor = false;
            this.btn_wd.Click += new System.EventHandler(this.btn_wd_Click);
            // 
            // btn_end
            // 
            this.btn_end.BackColor = System.Drawing.SystemColors.Control;
            this.btn_end.Enabled = false;
            this.btn_end.Location = new System.Drawing.Point(765, 443);
            this.btn_end.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(156, 69);
            this.btn_end.TabIndex = 12;
            this.btn_end.Text = "набор очков и переход к следующему раунду";
            this.btn_end.UseVisualStyleBackColor = false;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // flp_Dices
            // 
            this.flp_Dices.Location = new System.Drawing.Point(9, 297);
            this.flp_Dices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flp_Dices.Name = "flp_Dices";
            this.flp_Dices.Size = new System.Drawing.Size(237, 301);
            this.flp_Dices.TabIndex = 13;
            // 
            // lb_otobrano
            // 
            this.lb_otobrano.Location = new System.Drawing.Point(59, 197);
            this.lb_otobrano.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_otobrano.Name = "lb_otobrano";
            this.lb_otobrano.Size = new System.Drawing.Size(111, 19);
            this.lb_otobrano.TabIndex = 15;
            this.lb_otobrano.Text = "Отобрано: 0";
            // 
            // lb_round
            // 
            this.lb_round.Location = new System.Drawing.Point(59, 136);
            this.lb_round.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_round.Name = "lb_round";
            this.lb_round.Size = new System.Drawing.Size(111, 19);
            this.lb_round.TabIndex = 16;
            this.lb_round.Text = "Раунд: 1";
            // 
            // lb_round_points
            // 
            this.lb_round_points.Location = new System.Drawing.Point(59, 167);
            this.lb_round_points.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_round_points.Name = "lb_round_points";
            this.lb_round_points.Size = new System.Drawing.Size(113, 19);
            this.lb_round_points.TabIndex = 17;
            this.lb_round_points.Text = "Очки за раунд: 0";
            // 
            // lb_points
            // 
            this.lb_points.Location = new System.Drawing.Point(59, 106);
            this.lb_points.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_points.Name = "lb_points";
            this.lb_points.Size = new System.Drawing.Size(111, 19);
            this.lb_points.TabIndex = 18;
            this.lb_points.Text = "Всего очков: 0";
            // 
            // lb_test
            // 
            this.lb_test.AutoSize = true;
            this.lb_test.Location = new System.Drawing.Point(840, 25);
            this.lb_test.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_test.Name = "lb_test";
            this.lb_test.Size = new System.Drawing.Size(0, 13);
            this.lb_test.TabIndex = 19;
            // 
            // flp_default
            // 
            this.flp_default.Controls.Add(this.pB_dice_1);
            this.flp_default.Controls.Add(this.pB_dice_2);
            this.flp_default.Controls.Add(this.pB_dice_3);
            this.flp_default.Controls.Add(this.pB_dice_4);
            this.flp_default.Controls.Add(this.pB_dice_5);
            this.flp_default.Controls.Add(this.pB_dice_6);
            this.flp_default.Location = new System.Drawing.Point(522, 287);
            this.flp_default.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flp_default.Name = "flp_default";
            this.flp_default.Size = new System.Drawing.Size(300, 54);
            this.flp_default.TabIndex = 20;
            // 
            // pB_dice_1
            // 
            this.pB_dice_1.Image = global::Zonk.Properties.Resources._1_1;
            this.pB_dice_1.Location = new System.Drawing.Point(2, 2);
            this.pB_dice_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pB_dice_1.Name = "pB_dice_1";
            this.pB_dice_1.Size = new System.Drawing.Size(45, 49);
            this.pB_dice_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_dice_1.TabIndex = 4;
            this.pB_dice_1.TabStop = false;
            this.pB_dice_1.Tag = "dice_1";
            this.pB_dice_1.Click += new System.EventHandler(this.pB_dice_1_Click);
            // 
            // pB_dice_2
            // 
            this.pB_dice_2.Image = global::Zonk.Properties.Resources._2_1;
            this.pB_dice_2.Location = new System.Drawing.Point(51, 2);
            this.pB_dice_2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pB_dice_2.Name = "pB_dice_2";
            this.pB_dice_2.Size = new System.Drawing.Size(45, 49);
            this.pB_dice_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_dice_2.TabIndex = 5;
            this.pB_dice_2.TabStop = false;
            this.pB_dice_2.Tag = "dice_2";
            this.pB_dice_2.Click += new System.EventHandler(this.pB_dice_2_Click);
            // 
            // pB_dice_3
            // 
            this.pB_dice_3.Image = global::Zonk.Properties.Resources._3_1;
            this.pB_dice_3.Location = new System.Drawing.Point(100, 2);
            this.pB_dice_3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pB_dice_3.Name = "pB_dice_3";
            this.pB_dice_3.Size = new System.Drawing.Size(45, 49);
            this.pB_dice_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_dice_3.TabIndex = 8;
            this.pB_dice_3.TabStop = false;
            this.pB_dice_3.Tag = "dice_3";
            this.pB_dice_3.Click += new System.EventHandler(this.pB_dice_3_Click);
            // 
            // pB_dice_4
            // 
            this.pB_dice_4.Image = global::Zonk.Properties.Resources._4_1;
            this.pB_dice_4.Location = new System.Drawing.Point(149, 2);
            this.pB_dice_4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pB_dice_4.Name = "pB_dice_4";
            this.pB_dice_4.Size = new System.Drawing.Size(45, 49);
            this.pB_dice_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_dice_4.TabIndex = 9;
            this.pB_dice_4.TabStop = false;
            this.pB_dice_4.Tag = "dice_4";
            this.pB_dice_4.Click += new System.EventHandler(this.pB_dice_4_Click);
            // 
            // pB_dice_5
            // 
            this.pB_dice_5.Image = global::Zonk.Properties.Resources._5_1;
            this.pB_dice_5.Location = new System.Drawing.Point(198, 2);
            this.pB_dice_5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pB_dice_5.Name = "pB_dice_5";
            this.pB_dice_5.Size = new System.Drawing.Size(45, 49);
            this.pB_dice_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_dice_5.TabIndex = 6;
            this.pB_dice_5.TabStop = false;
            this.pB_dice_5.Tag = "dice_5";
            this.pB_dice_5.Click += new System.EventHandler(this.pB_dice_5_Click);
            // 
            // pB_dice_6
            // 
            this.pB_dice_6.Image = global::Zonk.Properties.Resources._6_1;
            this.pB_dice_6.Location = new System.Drawing.Point(247, 2);
            this.pB_dice_6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pB_dice_6.Name = "pB_dice_6";
            this.pB_dice_6.Size = new System.Drawing.Size(45, 49);
            this.pB_dice_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_dice_6.TabIndex = 7;
            this.pB_dice_6.TabStop = false;
            this.pB_dice_6.Tag = "dice_6";
            this.pB_dice_6.Click += new System.EventHandler(this.pB_dice_6_Click);
            // 
            // btn_Instructions
            // 
            this.btn_Instructions.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Instructions.Location = new System.Drawing.Point(908, 10);
            this.btn_Instructions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Instructions.Name = "btn_Instructions";
            this.btn_Instructions.Size = new System.Drawing.Size(117, 29);
            this.btn_Instructions.TabIndex = 22;
            this.btn_Instructions.Text = "Как играть?";
            this.btn_Instructions.UseVisualStyleBackColor = false;
            this.btn_Instructions.Click += new System.EventHandler(this.btn_Instructions_Click);
            // 
            // pb_test
            // 
            this.pb_test.Location = new System.Drawing.Point(1500, 44);
            this.pb_test.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_test.Name = "pb_test";
            this.pb_test.Size = new System.Drawing.Size(75, 41);
            this.pb_test.TabIndex = 21;
            this.pb_test.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Zonk.Properties.Resources.black_k;
            this.pictureBox2.Location = new System.Drawing.Point(-14, 279);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(280, 14);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zonk.Properties.Resources.black_k;
            this.pictureBox1.Location = new System.Drawing.Point(250, -11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 629);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1034, 609);
            this.Controls.Add(this.btn_Instructions);
            this.Controls.Add(this.pb_test);
            this.Controls.Add(this.flp_default);
            this.Controls.Add(this.lb_test);
            this.Controls.Add(this.lb_points);
            this.Controls.Add(this.lb_round_points);
            this.Controls.Add(this.lb_round);
            this.Controls.Add(this.lb_otobrano);
            this.Controls.Add(this.flp_Dices);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_wd);
            this.Controls.Add(this.btn_throw);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "zonk";
            this.flp_default.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pB_dice_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_dice_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_dice_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_dice_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_dice_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_dice_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pB_dice_1;
        private System.Windows.Forms.PictureBox pB_dice_2;
        private System.Windows.Forms.PictureBox pB_dice_6;
        private System.Windows.Forms.PictureBox pB_dice_5;
        private System.Windows.Forms.PictureBox pB_dice_4;
        private System.Windows.Forms.PictureBox pB_dice_3;
        private System.Windows.Forms.Button btn_throw;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_wd;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.FlowLayoutPanel flp_Dices;
        private System.Windows.Forms.Label lb_otobrano;
        private System.Windows.Forms.Label lb_round;
        private System.Windows.Forms.Label lb_round_points;
        private System.Windows.Forms.Label lb_points;
        private System.Windows.Forms.Label lb_test;
        private System.Windows.Forms.FlowLayoutPanel flp_default;
        private System.Windows.Forms.PictureBox pb_test;
        private System.Windows.Forms.Button btn_Instructions;
    }
}

