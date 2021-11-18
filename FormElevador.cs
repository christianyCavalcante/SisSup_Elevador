using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using log4net.Config;

namespace SisSup_Elevador
{
    public partial class frmElevador : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private ElevadorController elevadorController;

        public delegate void chamarElevadorSubirEventHandler(object source, EventArgs args, int andar);
        public event chamarElevadorSubirEventHandler chamarElevadorSubir;

        public delegate void chamarElevadorDescerEventHandler(object source, EventArgs args, int andar);
        public event chamarElevadorDescerEventHandler chamarElevadorDescer;

        public frmElevador()
        {
            InitializeComponent();


        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //            BasicConfigurator.Configure();
            cbModoOperacaoManual.Checked = true;

            elevadorController = new ElevadorController(this);
            this.chamarElevadorSubir += elevadorController.onChamarElevadorSubir;
            this.chamarElevadorDescer += elevadorController.onChamarElevadorDescer;

            Task controller = new Task(elevadorController.processarComandos);
            controller.Start();
        }

        public void onAlterarStatusElevadorEventHandler(object source, EventArgs args, String status)
        {
            SetControlPropertyValue(labelStatus, "Text", status);
        }

        public void onAlterarAndarAtualEventHandler(object source, EventArgs args, int andarAtual)
        {
            SetControlPropertyValue(labelAndarAtual, "Text", andarAtual.ToString());
        }

        private void cbModoOperacaoManual_CheckedChanged(object sender, EventArgs e)
        {

            if (cbModoOperacaoManual.CheckState == CheckState.Checked && cbModoOperacaoAutomatico.CheckState == CheckState.Checked)
            {
                cbModoOperacaoAutomatico.CheckState = CheckState.Unchecked;
            }
            if (cbModoOperacaoManual.CheckState == CheckState.Unchecked && cbModoOperacaoAutomatico.CheckState == CheckState.Unchecked)
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

        private void subir(int andar)
        {
            if (chamarElevadorSubir != null)
            {
                chamarElevadorSubir(this, EventArgs.Empty, andar);
            }
        }

        private void descer(int andar)
        {
            if (chamarElevadorDescer != null)
            {
                chamarElevadorDescer(this, EventArgs.Empty, andar);
            }
        }

        private void clickTerreoSubir(object sender, EventArgs e)
        {
            this.subir(0);
        }

        private void click1AndarSubir(object sender, EventArgs e)
        {

            this.subir(1);
        }

        private void click2AndarSubir(object sender, EventArgs e)
        {
            this.subir(2);
        }

        private void click3AndarSubir(object sender, EventArgs e)
        {
            this.subir(3);
        }

        private void click1AndarDescer(object sender, EventArgs e)
        {
            this.descer(1);
        }

        private void click2AndarDescer(object sender, EventArgs e)
        {
            this.descer(2);
        }

        private void click3AndarDescer(object sender, EventArgs e)
        {
            this.descer(3);
        }

        private void click4AndarDescer(object sender, EventArgs e)
        {
            this.descer(4);
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


        delegate void SetControlValueCallback(Control oControl, string propName, object propValue);
        private void SetControlPropertyValue(Control oControl, string propName, object propValue)
        {
            if (oControl.InvokeRequired)
            {
                SetControlValueCallback d = new SetControlValueCallback(SetControlPropertyValue);
                oControl.Invoke(d, new object[] { oControl, propName, propValue });
            }
            else
            {
                Type t = oControl.GetType();
                PropertyInfo[] props = t.GetProperties();
                foreach (PropertyInfo p in props)
                {
                    if (p.Name.ToUpper() == propName.ToUpper())
                    {
                        p.SetValue(oControl, propValue, null);
                    }
                }
            }
        }
    }

}
