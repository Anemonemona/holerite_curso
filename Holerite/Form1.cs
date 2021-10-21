using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holerite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double salario, resul_total, resul_vt, resul_inss, resul_fgts, resul_ir;

            salario = double.Parse(txt_valorbrt.Text);

            //inss
            if (salario <= 1751.81) {
                resul_inss = salario * 0.08;
                lbl_inss.Text = "R$ " + resul_inss.ToString();
            } else if (salario >= 1751.82 && salario <= 2919.72) {
                resul_inss = salario * 0.09;
                lbl_inss.Text = "R$ " + resul_inss.ToString();
            } else if (salario >= 2919.73 && salario <= 5839.45) {
                resul_inss = salario * 0.11;
                lbl_inss.Text = "R$ " + resul_inss.ToString();
            } else {
                resul_inss = salario - 642.34;
                lbl_inss.Text = "R$ " + resul_inss.ToString();
            }

            //fgts
            resul_fgts = salario * 0.08;
            lbl_fgts.Text = "R$ " + resul_fgts.ToString();

            //vr 
            resul_vt = salario * 0.06;
            lbl_vt.Text = "R$ " + resul_vt.ToString();

            //ir
            if (salario <= 1903.98) {
                resul_ir = 0;
                lbl_ir.Text = "Isento";
            } else if (salario >= 1903.99 && salario <= 2826.65) {
                resul_ir = salario * 0.075 - 142.80;
                lbl_ir.Text = "R$ " + resul_ir.ToString();
            } else if (salario >= 2826.66 && salario <= 3751.05) {
                resul_ir = salario * 0.15 - 354.80;
                lbl_ir.Text = "R$ " + resul_ir.ToString();
            } else if (salario >= 3751.06 && salario <= 4664.68) {
                resul_ir = salario * 0.225 - 636.13;
                lbl_ir.Text = "R$ " + resul_ir.ToString();
            } else {
                resul_ir = salario * 0.275 - 869.36;
                lbl_ir.Text = "R$ " + resul_ir.ToString();
            }

            //salário liq
            resul_total = salario - (resul_ir + resul_fgts + resul_inss + resul_vt);
            lbl_valorliq.Text = "R$ " + resul_total.ToString();
        }
    }
}
