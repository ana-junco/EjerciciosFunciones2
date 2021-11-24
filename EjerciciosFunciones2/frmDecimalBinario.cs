using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosFunciones2
{
    public partial class frmDecimalBinario : Form
    {
        public frmDecimalBinario()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool esNumCorrecto = int.TryParse(this.txtEntero.Text, out int numero);
            if (!esNumCorrecto)
            {
                MessageBox.Show("DEBE INGRESAR UN VALOR NUMERICO..");
                return;
            }
            if (!(numero >= 0 && numero <= 255))
            {
                MessageBox.Show("NUMERO FUERA DE RANGO...");
                return;
            }
            int[] res = binario(numero);
            // Console.WriteLine("INICIO");
            for (int i = res.Length - 1; i > 0; i--)
            {


                this.caja8.Checked = res[7] == 1 ? true : false;
                this.caja7.Checked = res[6] == 1 ? true : false;
                this.caja6.Checked = res[5] == 1 ? true : false;
                this.caja5.Checked = res[4] == 1 ? true : false;
                this.caja4.Checked = res[3] == 1 ? true : false;
                this.caja3.Checked = res[2] == 1 ? true : false;
                this.caja2.Checked = res[1] == 1 ? true : false;
                this.caja1.Checked = res[0] == 1 ? true : false;
                Console.WriteLine("{0}", res[i]);
            }

        }
        // Console.WriteLine("FIN");
        // this.checkBox1.Checked = true;
        private int[] binario(int num)
        {
            int[] bin = { 0, 0, 0, 0, 0, 0, 0, 0 };
            //int[] bin =new int [8];
            int i = 0;
            int resto = 0;
            while (num > 0)
            {
                resto = num % 2;
                bin[i++] = resto;
                num = num / 2;
                //Console.WriteLine("{0}", resto);
            }

            return bin;
        }

        private void btnBinaDeci_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (caja1.Checked) num += 1;
            if (caja2.Checked) num += 2;
            if (caja3.Checked) num += 4;
            if (caja4.Checked) num += 8;
            if (caja5.Checked) num += 16;
            if (caja6.Checked) num += 32;
            if (caja7.Checked) num += 64;
            if (caja8.Checked) num += 128;
            this.txtEntero.Text = num.ToString();

        }

        private void caja1_CheckedChanged(object sender, EventArgs e)
        {
            sumaBinarioaDecimal();
        }
        void sumaBinarioaDecimal()
        {
            int num = 0;
            if (caja1.Checked) num += 1;
            if (caja2.Checked) num += 2;
            if (caja3.Checked) num += 4;
            if (caja4.Checked) num += 8;
            if (caja5.Checked) num += 16;
            if (caja6.Checked) num += 32;
            if (caja7.Checked) num += 64;
            if (caja8.Checked) num += 128;
            this.txtEntero.Text = num.ToString();
        }
    }
}
