
namespace Holerite
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_valorbrt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_ir = new System.Windows.Forms.Label();
            this.lbl_vt = new System.Windows.Forms.Label();
            this.lbl_fgts = new System.Windows.Forms.Label();
            this.lbl_inss = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_valorliq = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_calcular);
            this.groupBox1.Controls.Add(this.txt_valorbrt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salário Bruto";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(92, 79);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 3;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_valorbrt
            // 
            this.txt_valorbrt.Location = new System.Drawing.Point(135, 39);
            this.txt_valorbrt.Name = "txt_valorbrt";
            this.txt_valorbrt.Size = new System.Drawing.Size(100, 23);
            this.txt_valorbrt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informe o valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Holerite";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_ir);
            this.groupBox2.Controls.Add(this.lbl_vt);
            this.groupBox2.Controls.Add(this.lbl_fgts);
            this.groupBox2.Controls.Add(this.lbl_inss);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descontos";
            // 
            // lbl_ir
            // 
            this.lbl_ir.AutoSize = true;
            this.lbl_ir.Location = new System.Drawing.Point(160, 68);
            this.lbl_ir.Name = "lbl_ir";
            this.lbl_ir.Size = new System.Drawing.Size(12, 15);
            this.lbl_ir.TabIndex = 5;
            this.lbl_ir.Text = "-";
            // 
            // lbl_vt
            // 
            this.lbl_vt.AutoSize = true;
            this.lbl_vt.Location = new System.Drawing.Point(160, 37);
            this.lbl_vt.Name = "lbl_vt";
            this.lbl_vt.Size = new System.Drawing.Size(12, 15);
            this.lbl_vt.TabIndex = 6;
            this.lbl_vt.Text = "-";
            // 
            // lbl_fgts
            // 
            this.lbl_fgts.AutoSize = true;
            this.lbl_fgts.Location = new System.Drawing.Point(62, 68);
            this.lbl_fgts.Name = "lbl_fgts";
            this.lbl_fgts.Size = new System.Drawing.Size(12, 15);
            this.lbl_fgts.TabIndex = 10;
            this.lbl_fgts.Text = "-";
            // 
            // lbl_inss
            // 
            this.lbl_inss.AutoSize = true;
            this.lbl_inss.Location = new System.Drawing.Point(62, 37);
            this.lbl_inss.Name = "lbl_inss";
            this.lbl_inss.Size = new System.Drawing.Size(12, 15);
            this.lbl_inss.TabIndex = 11;
            this.lbl_inss.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "INSS : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "FGTS : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "IR : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "VT : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_valorliq);
            this.groupBox3.Location = new System.Drawing.Point(12, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 94);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salário Líquido";
            // 
            // lbl_valorliq
            // 
            this.lbl_valorliq.AutoSize = true;
            this.lbl_valorliq.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_valorliq.Location = new System.Drawing.Point(92, 42);
            this.lbl_valorliq.Name = "lbl_valorliq";
            this.lbl_valorliq.Size = new System.Drawing.Size(15, 20);
            this.lbl_valorliq.TabIndex = 4;
            this.lbl_valorliq.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 377);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_valorbrt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_ir;
        private System.Windows.Forms.Label lbl_vt;
        private System.Windows.Forms.Label lbl_fgts;
        private System.Windows.Forms.Label lbl_inss;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_valorliq;
    }
}

