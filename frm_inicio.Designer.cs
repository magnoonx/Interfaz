
namespace Interfaz
{
    partial class frm_inicio
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
            button1 = new Button();
            Usuario = new TextBox();
            Clave = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(26, 309);
            button1.Name = "button1";
            button1.Size = new Size(314, 46);
            button1.TabIndex = 0;
            button1.Text = "Iniciar Sesión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Usuario
            // 
            Usuario.Location = new Point(26, 160);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(314, 27);
            Usuario.TabIndex = 1;
            Usuario.TextAlign = HorizontalAlignment.Center;
            Usuario.TextChanged += Usuario_TextChanged;
            // 
            // Clave
            // 
            Clave.Location = new Point(26, 252);
            Clave.Name = "Clave";
            Clave.PasswordChar = '*';
            Clave.Size = new Size(314, 27);
            Clave.TabIndex = 2;
            Clave.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 211);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 3;
            label1.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(112, 118);
            label2.Name = "label2";
            label2.Size = new Size(142, 28);
            label2.TabIndex = 4;
            label2.Text = "Usuario / DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(109, 23);
            label3.Name = "label3";
            label3.Size = new Size(145, 36);
            label3.TabIndex = 5;
            label3.Text = "SAFVIAL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 59);
            label4.Name = "label4";
            label4.Size = new Size(246, 20);
            label4.TabIndex = 6;
            label4.Text = "Sistema Automatizado de Flujo Vial";
            // 
            // button2
            // 
            button2.Location = new Point(26, 361);
            button2.Name = "button2";
            button2.Size = new Size(314, 47);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // frm_inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 429);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Clave);
            Controls.Add(Usuario);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frm_inicio";
            Text = "Inicio";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        private TextBox Usuario;
        private TextBox Clave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
    }
}
