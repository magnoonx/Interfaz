namespace Interfaz
{
    partial class frm_principal
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
            splitContainer1 = new SplitContainer();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button6);
            splitContainer1.Panel2.Controls.Add(button5);
            splitContainer1.Panel2.Controls.Add(button4);
            splitContainer1.Panel2.Controls.Add(button3);
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Size = new Size(1291, 847);
            splitContainer1.SplitterDistance = 1030;
            splitContainer1.TabIndex = 0;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.Location = new Point(5, 705);
            button6.Name = "button6";
            button6.Size = new Size(249, 135);
            button6.TabIndex = 5;
            button6.Text = "Salir del Canal";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Location = new Point(3, 564);
            button5.Name = "button5";
            button5.Size = new Size(249, 135);
            button5.TabIndex = 4;
            button5.Text = "Cerrar Barrera";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(5, 423);
            button4.Name = "button4";
            button4.Size = new Size(249, 135);
            button4.TabIndex = 3;
            button4.Text = "Aperturar Barrera";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(5, 282);
            button3.Name = "button3";
            button3.Size = new Size(249, 135);
            button3.TabIndex = 2;
            button3.Text = "Autorizar Avance";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 144);
            button2.Name = "button2";
            button2.Size = new Size(249, 135);
            button2.TabIndex = 1;
            button2.Text = "Solicitar Avance";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(249, 135);
            button1.TabIndex = 0;
            button1.Text = "Ultimo Ticket";
            button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(3, 144);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1024, 555);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // frm_principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 847);
            ControlBox = false;
            Controls.Add(splitContainer1);
            Name = "frm_principal";
            Text = "Form2";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
        private Button button5;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}