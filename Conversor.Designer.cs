namespace Calculadora
{
    partial class Conversor
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
            converter = new Button();
            apagar = new Button();
            label1 = new Label();
            textBox_convert = new TextBox();
            lbl_resposta = new Label();
            SuspendLayout();
            // 
            // converter
            // 
            converter.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            converter.Location = new Point(265, 221);
            converter.Name = "converter";
            converter.Size = new Size(75, 37);
            converter.TabIndex = 0;
            converter.Text = "Converter";
            converter.UseVisualStyleBackColor = true;
            converter.Click += converter_Click;
            // 
            // apagar
            // 
            apagar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            apagar.Location = new Point(356, 221);
            apagar.Name = "apagar";
            apagar.Size = new Size(82, 37);
            apagar.TabIndex = 1;
            apagar.Text = "Limpar";
            apagar.UseVisualStyleBackColor = true;
            apagar.Click += apagar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 104);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 2;
            label1.Text = "Celsius";
            // 
            // textBox_convert
            // 
            textBox_convert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_convert.Location = new Point(265, 131);
            textBox_convert.Name = "textBox_convert";
            textBox_convert.Size = new Size(173, 29);
            textBox_convert.TabIndex = 3;
            // 
            // lbl_resposta
            // 
            lbl_resposta.AutoSize = true;
            lbl_resposta.Location = new Point(269, 179);
            lbl_resposta.Name = "lbl_resposta";
            lbl_resposta.Size = new Size(66, 17);
            lbl_resposta.TabIndex = 4;
            lbl_resposta.Text = "Resultado";
            // 
            // Conversor
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(744, 439);
            Controls.Add(lbl_resposta);
            Controls.Add(textBox_convert);
            Controls.Add(label1);
            Controls.Add(apagar);
            Controls.Add(converter);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Conversor";
            Text = "Conversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button converter;
        private Button apagar;
        private Label label1;
        private TextBox textBox_convert;
        private Label lbl_resposta;
    }
}