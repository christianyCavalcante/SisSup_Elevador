using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisSup_Elevador
{
    public partial class frmElevador : Form
    {
        public frmElevador()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbModoOperacaoManual.Checked = true;
        }

        private void cbModoOperacaoManual_CheckedChanged(object sender, EventArgs e)
        {
            if(cbModoOperacaoManual.CheckState == CheckState.Checked && cbModoOperacaoAutomatico.CheckState == CheckState.Checked)
            {
                cbModoOperacaoAutomatico.CheckState = CheckState.Unchecked;
            }
            if (cbModoOperacaoManual.CheckState == CheckState.Unchecked && cbModoOperacaoAutomatico.CheckState == CheckState.Unchecked )
            {
                cbModoOperacaoAutomatico.CheckState = CheckState.Checked;
            }
        }

        private void cbModoOperacaoAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            if (cbModoOperacaoAutomatico.CheckState == CheckState.Checked && cbModoOperacaoManual.CheckState == CheckState.Checked)
            {
                cbModoOperacaoManual.CheckState = CheckState.Unchecked;
            }
            if (cbModoOperacaoAutomatico.CheckState == CheckState.Unchecked && cbModoOperacaoManual.CheckState == CheckState.Unchecked)
            {
                cbModoOperacaoManual.CheckState = CheckState.Checked;
            }
        }

        private void subir(String andar)
        {
            labelAndarAtual.Text = andar;
            labelStatus.Text = "SUBINDO";
        }

        private void descer(String andar)
        {
            labelAndarAtual.Text = andar;
            labelStatus.Text = "DESCENDO";
        }

        private void clickTerreoSubir(object sender, EventArgs e)
        {
            this.subir("T");
        }

        private void click1AndarSubir(object sender, EventArgs e)
        {
            this.subir("1");
        }

        private void click2AndarSubir(object sender, EventArgs e)
        {
            this.subir("2");
        }

        private void click3AndarSubir(object sender, EventArgs e)
        {
            this.subir("3");
        }

        private void click1AndarDescer(object sender, EventArgs e)
        {
            this.descer("1");
        }

        private void click2AndarDescer(object sender, EventArgs e)
        {
            this.descer("2");
        }

        private void click3AndarDescer(object sender, EventArgs e)
        {
            this.descer("3");
        }

        private void click4AndarDescer(object sender, EventArgs e)
        {
            this.descer("4");
        }

        private void clickTerreo(object sender, EventArgs e)
        {

        }

        private void click1Andar(object sender, EventArgs e)
        {

        }

        private void click2Andar(object sender, EventArgs e)
        {

        }

        private void click3Andar(object sender, EventArgs e)
        {

        }

        private void click4Andar(object sender, EventArgs e)
        {

        }
    }
    
}
