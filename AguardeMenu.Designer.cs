﻿namespace Calculadora
{
    partial class frmcalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcalculadora));
            pictureBox1 = new PictureBox();
            pgbCarregando = new ProgressBar();
            label1 = new Label();
            tmr_pbg = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mickey;
            pictureBox1.Location = new Point(239, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pgbCarregando
            // 
            pgbCarregando.Location = new Point(43, 358);
            pgbCarregando.MarqueeAnimationSpeed = 3000;
            pgbCarregando.Name = "pgbCarregando";
            pgbCarregando.Size = new Size(714, 30);
            pgbCarregando.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(332, 292);
            label1.Name = "label1";
            label1.Size = new Size(117, 32);
            label1.TabIndex = 2;
            label1.Text = "Aguarde...";
            // 
            // tmr_pbg
            // 
            tmr_pbg.Enabled = true;
            tmr_pbg.Tick += timer1_Tick;
            // 
            // frmcalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pgbCarregando);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmcalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            FormClosed += frmcalculadora_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar pgbCarregando;
        private Label label1;
        private System.Windows.Forms.Timer timer_pgb;
        private System.Windows.Forms.Timer tmr_pbg;
    }
}
