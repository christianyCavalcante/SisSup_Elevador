using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisSup_Elevador
{
    public partial class frmElevador : Form
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private ElevadorController elevadorController;


        public delegate void selecionarAndarDestinoEventHandler(object source, EventArgs args, int andar);
        public event selecionarAndarDestinoEventHandler selecionarAndarDestinoEvent;

        public delegate void chamarElevadorSubirEventHandler(object source, EventArgs args, int andar);
        public event chamarElevadorSubirEventHandler chamarElevadorSubirEvent;

        public delegate void chamarElevadorDescerEventHandler(object source, EventArgs args, int andar);
        public event chamarElevadorDescerEventHandler chamarElevadorDescerEvent;

        public frmElevador()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //            BasicConfigurator.Configure();
            cbModoOperacaoManual.Checked = true;

            elevadorController = new ElevadorController(this);

            this.selecionarAndarDestinoEvent += elevadorController.onSelecionarAndarDestino;
            this.chamarElevadorSubirEvent += elevadorController.onChamarElevadorSubir;
            this.chamarElevadorDescerEvent += elevadorController.onChamarElevadorDescer;


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


        //Painel Interno. 
        private void selecionarAndarDestino(int andar)
        {
            if (selecionarAndarDestinoEvent != null)
            {
                selecionarAndarDestinoEvent(this, EventArgs.Empty, andar);
            }
        }

        //Botões de subir do painel externo
        private void chamarElevadorSubir(int andar)
        {
            if (chamarElevadorSubirEvent != null)
            {
                chamarElevadorSubirEvent(this, EventArgs.Empty, andar);
            }
        }

        //Botões de descer do painel externo
        private void chamarElevadorDescer(int andar)
        {
            if (chamarElevadorDescerEvent != null)
            {
                chamarElevadorDescerEvent(this, EventArgs.Empty, andar);
            }
        }

        private void clickTerreoSubir(object sender, EventArgs e)
        {
            this.chamarElevadorSubir(0);
        }

        private void click1AndarSubir(object sender, EventArgs e)
        {
            this.chamarElevadorSubir(1);
        }

        private void click2AndarSubir(object sender, EventArgs e)
        {
            this.chamarElevadorSubir(2);
        }

        private void click3AndarSubir(object sender, EventArgs e)
        {
            this.chamarElevadorSubir(3);
        }

        private void click1AndarDescer(object sender, EventArgs e)
        {
            this.chamarElevadorDescer(1);
        }

        private void click2AndarDescer(object sender, EventArgs e)
        {
            this.chamarElevadorDescer(2);
        }

        private void click3AndarDescer(object sender, EventArgs e)
        {
            this.chamarElevadorDescer(3);
        }

        private void click4AndarDescer(object sender, EventArgs e)
        {
            this.chamarElevadorDescer(4);
        }

        private void clickTerreo(object sender, EventArgs e)
        {
            this.selecionarAndarDestino(0);

        }

        private void click1Andar(object sender, EventArgs e)
        {
            this.selecionarAndarDestino(1);
        }

        private void click2Andar(object sender, EventArgs e)
        {
            this.selecionarAndarDestino(2);
        }

        private void click3Andar(object sender, EventArgs e)
        {
            this.selecionarAndarDestino(3);
        }

        private void click4Andar(object sender, EventArgs e)
        {
            this.selecionarAndarDestino(4);
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
