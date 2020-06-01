namespace Zonk
{
    partial class WinForm
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
            this.btn_Again = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lb_score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Again
            // 
            this.btn_Again.Location = new System.Drawing.Point(295, 495);
            this.btn_Again.Name = "btn_Again";
            this.btn_Again.Size = new System.Drawing.Size(252, 80);
            this.btn_Again.TabIndex = 1;
            this.btn_Again.Text = "Играть ещё раз";
            this.btn_Again.UseVisualStyleBackColor = true;
            this.btn_Again.Click += new System.EventHandler(this.btn_Again_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(789, 495);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(241, 80);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Выйти";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lb_score
            // 
            this.lb_score.Location = new System.Drawing.Point(448, 262);
            this.lb_score.Name = "lb_score";
            this.lb_score.Size = new System.Drawing.Size(454, 137);
            this.lb_score.TabIndex = 3;
            this.lb_score.Text = "Ваш счет: ";
            this.lb_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1378, 749);
            this.Controls.Add(this.lb_score);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Again);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "WinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinForm";
            this.Load += new System.EventHandler(this.WinForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Again;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lb_score;
    }
}