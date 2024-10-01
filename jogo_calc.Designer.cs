namespace Calculadora
{
    partial class jogo_calc
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
            txtVisor = new TextBox();
            mais = new Button();
            menos = new Button();
            vezes = new Button();
            divisao = new Button();
            apaga = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            igual = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn0 = new Button();
            menu_conversor = new MenuStrip();
            conversorToolStripMenuItem = new ToolStripMenuItem();
            celsiusParaToolStripMenuItem = new ToolStripMenuItem();
            menu_conversor.SuspendLayout();
            SuspendLayout();
            // 
            // txtVisor
            // 
            txtVisor.Enabled = false;
            txtVisor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVisor.Location = new Point(275, 86);
            txtVisor.Name = "txtVisor";
            txtVisor.Size = new Size(201, 39);
            txtVisor.TabIndex = 0;
            // 
            // mais
            // 
            mais.BackColor = Color.LightCoral;
            mais.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mais.Location = new Point(275, 131);
            mais.Name = "mais";
            mais.Size = new Size(46, 45);
            mais.TabIndex = 1;
            mais.Text = "+";
            mais.TextAlign = ContentAlignment.TopCenter;
            mais.UseVisualStyleBackColor = false;
            mais.Click += mais_Click;
            // 
            // menos
            // 
            menos.BackColor = Color.LightCoral;
            menos.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menos.Location = new Point(326, 131);
            menos.Name = "menos";
            menos.Size = new Size(46, 45);
            menos.TabIndex = 15;
            menos.Text = "-";
            menos.TextAlign = ContentAlignment.TopCenter;
            menos.UseVisualStyleBackColor = false;
            menos.Click += menos_Click;
            // 
            // vezes
            // 
            vezes.BackColor = Color.LightCoral;
            vezes.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vezes.Location = new Point(378, 131);
            vezes.Name = "vezes";
            vezes.Size = new Size(46, 45);
            vezes.TabIndex = 16;
            vezes.Text = "*";
            vezes.TextAlign = ContentAlignment.BottomCenter;
            vezes.UseVisualStyleBackColor = false;
            vezes.Click += vezes_Click;
            // 
            // divisao
            // 
            divisao.BackColor = Color.LightCoral;
            divisao.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            divisao.Location = new Point(430, 131);
            divisao.Name = "divisao";
            divisao.Size = new Size(46, 45);
            divisao.TabIndex = 17;
            divisao.Text = "/";
            divisao.TextAlign = ContentAlignment.TopCenter;
            divisao.UseVisualStyleBackColor = false;
            divisao.Click += divisao_Click;
            // 
            // apaga
            // 
            apaga.BackColor = Color.LightCoral;
            apaga.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            apaga.Location = new Point(430, 181);
            apaga.Name = "apaga";
            apaga.Size = new Size(46, 45);
            apaga.TabIndex = 18;
            apaga.Text = "CLS";
            apaga.UseVisualStyleBackColor = false;
            apaga.Click += apaga_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.LightCoral;
            btn3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(378, 181);
            btn3.Name = "btn3";
            btn3.Size = new Size(46, 45);
            btn3.TabIndex = 19;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.LightCoral;
            btn2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(327, 181);
            btn2.Name = "btn2";
            btn2.Size = new Size(46, 45);
            btn2.TabIndex = 20;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.LightCoral;
            btn1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(275, 181);
            btn1.Name = "btn1";
            btn1.Size = new Size(46, 45);
            btn1.TabIndex = 21;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // igual
            // 
            igual.BackColor = Color.LightCoral;
            igual.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            igual.Location = new Point(430, 231);
            igual.Name = "igual";
            igual.Size = new Size(46, 141);
            igual.TabIndex = 22;
            igual.Text = "=";
            igual.UseVisualStyleBackColor = false;
            igual.Click += igual_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.LightCoral;
            btn6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(379, 231);
            btn6.Name = "btn6";
            btn6.Size = new Size(46, 45);
            btn6.TabIndex = 23;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.LightCoral;
            btn5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(327, 231);
            btn5.Name = "btn5";
            btn5.Size = new Size(46, 45);
            btn5.TabIndex = 24;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.LightCoral;
            btn4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(275, 231);
            btn4.Name = "btn4";
            btn4.Size = new Size(46, 45);
            btn4.TabIndex = 25;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.LightCoral;
            btn9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(379, 282);
            btn9.Name = "btn9";
            btn9.Size = new Size(46, 45);
            btn9.TabIndex = 26;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.LightCoral;
            btn8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(327, 282);
            btn8.Name = "btn8";
            btn8.Size = new Size(46, 45);
            btn8.TabIndex = 27;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.LightCoral;
            btn7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(275, 282);
            btn7.Name = "btn7";
            btn7.Size = new Size(46, 45);
            btn7.TabIndex = 28;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.LightCoral;
            btn0.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(275, 333);
            btn0.Name = "btn0";
            btn0.Size = new Size(150, 39);
            btn0.TabIndex = 29;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // menu_conversor
            // 
            menu_conversor.Items.AddRange(new ToolStripItem[] { conversorToolStripMenuItem });
            menu_conversor.Location = new Point(0, 0);
            menu_conversor.Name = "menu_conversor";
            menu_conversor.Size = new Size(800, 24);
            menu_conversor.TabIndex = 30;
            menu_conversor.Text = "menuStrip1";
            // 
            // conversorToolStripMenuItem
            // 
            conversorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { celsiusParaToolStripMenuItem });
            conversorToolStripMenuItem.Name = "conversorToolStripMenuItem";
            conversorToolStripMenuItem.Size = new Size(73, 20);
            conversorToolStripMenuItem.Text = "Conversor";
            // 
            // celsiusParaToolStripMenuItem
            // 
            celsiusParaToolStripMenuItem.Name = "celsiusParaToolStripMenuItem";
            celsiusParaToolStripMenuItem.Size = new Size(194, 22);
            celsiusParaToolStripMenuItem.Text = "Celsius para fahrenheit";
            celsiusParaToolStripMenuItem.Click += celsiusParaToolStripMenuItem_Click;
            // 
            // jogo_calc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(btn0);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(igual);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(apaga);
            Controls.Add(divisao);
            Controls.Add(vezes);
            Controls.Add(menos);
            Controls.Add(mais);
            Controls.Add(txtVisor);
            Controls.Add(menu_conversor);
            MainMenuStrip = menu_conversor;
            Name = "jogo_calc";
            Text = "jogo_calc";
            menu_conversor.ResumeLayout(false);
            menu_conversor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVisor;
        private Button mais;
        private Button menos;
        private Button vezes;
        private Button divisao;
        private Button apaga;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button igual;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn0;
        private MenuStrip menu_conversor;
        private ToolStripMenuItem conversorToolStripMenuItem;
        private ToolStripMenuItem celsiusParaToolStripMenuItem;
    }
}