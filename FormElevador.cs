using log4net;
using log4net.Config;
using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisSup_Elevador
{
    //classe que controla a interação da tela
    public partial class frmElevador : Form
    {
        
        
        private ElevadorController elevadorController;

        private Simulador simulador;
        private Task simuladorTask;        

        private CancellationTokenSource simuladorCancellationToken;

        //eventos que são utilizados pra interagir com controler
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

        //load inicial da tela, aonde são feitas as configurações iniciais
        private void Form1_Load(object sender, EventArgs e)
        {
            //inicializa o LOG
            Logger.Setup();
            Logger.log("ELEVADOR INICIADO.");

            //Inicia o elevador em modo de operação manual
            cbModoOperacaoManual.CheckState = CheckState.Checked;

            //instancio o controller
            elevadorController = new ElevadorController(this);

            //registro os eventos
            this.selecionarAndarDestinoEvent += elevadorController.onSelecionarAndarDestino;
            this.chamarElevadorSubirEvent += elevadorController.onChamarElevadorSubir;
            this.chamarElevadorDescerEvent += elevadorController.onChamarElevadorDescer;

            //iniciio a task do controller, que irá trabalhar numa thread em paralelo
            Task controllerTask = new Task(elevadorController.processarComandos);
            controllerTask.Start();

            //instancio o simulador
            simulador = new Simulador(this.elevadorController);

        }

        public void onAlterarStatusElevadorEventHandler(object source, EventArgs args, String status)
        {
            SetControlPropertyValue(labelStatus, "Text", status);
        }

        public void onAlterarAndarAtualEventHandler(object source, EventArgs args, int andarAtual)
        {
            SetControlPropertyValue(labelAndarAtual, "Text", andarAtual.ToString());
        }

        //controle do check box para modo de operação manual e automático
        private void cbModoOperacaoManual_CheckedChanged(object sender, EventArgs e)
        {

            if (cbModoOperacaoManual.CheckState == CheckState.Checked && cbModoOperacaoAutomatico.CheckState == CheckState.Checked)
            {
                cbModoOperacaoAutomatico.CheckState = CheckState.Unchecked;
                this.habilitarModoAutomatico(false);
            }
            if (cbModoOperacaoManual.CheckState == CheckState.Unchecked && cbModoOperacaoAutomatico.CheckState == CheckState.Unchecked)
            {
                cbModoOperacaoAutomatico.CheckState = CheckState.Checked;
                this.habilitarModoAutomatico(true);
            }
            
        }

        //controle do check box para modo de operação manual e automático
        private void cbModoOperacaoAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            if (cbModoOperacaoAutomatico.CheckState == CheckState.Checked && cbModoOperacaoManual.CheckState == CheckState.Checked)
            {
                cbModoOperacaoManual.CheckState = CheckState.Unchecked;
                this.habilitarModoAutomatico(true);
            }
            if (cbModoOperacaoAutomatico.CheckState == CheckState.Unchecked && cbModoOperacaoManual.CheckState == CheckState.Unchecked)
            {
                cbModoOperacaoManual.CheckState = CheckState.Checked;
                this.habilitarModoAutomatico(false);
            }   

        }

        //habilita o modo automático
        private void habilitarModoAutomatico(bool habilitar)
        {
            if (habilitar)
            {
                Logger.log("MODO DE OPERAÇÃO AUTOMÁTICO.");

                //inicializo uma task do simulador, que irá trabalhar numa thread em paralelo.
                //Crio um token de cancelamento, para quando for necessário encerrar o modo automático
                this.simuladorCancellationToken = new CancellationTokenSource();                
                this.simuladorTask = new Task(()=>simulador.simularChamadas(this.simuladorCancellationToken.Token));
                this.simuladorTask.Start();

            }
            else
            {
                Logger.log("MODO DE OPERAÇÃO MANUAL.");
                //para desabilitar a simulação, cancelo o token enviado anteriomente
                if (this.simuladorCancellationToken.Token.CanBeCanceled)
                {
                    this.simuladorCancellationToken.Cancel();
                }
            }
            //desabilito os botões de fora do elevador, quando está em modo automático
            btTerreoSubir.Enabled = !habilitar;
            bt1AndarSubir.Enabled = !habilitar;
            bt2AndarSubir.Enabled = !habilitar;
            bt3AndarSubir.Enabled = !habilitar;
            bt1AndarDescer.Enabled = !habilitar;
            bt2AndarDescer.Enabled = !habilitar;
            bt3AndarDescer.Enabled = !habilitar;
            bt4AndarDescer.Enabled = !habilitar;
            
        }


        //Painel Interno. Quando é pressionado um andar, envia o evento para o controler
        private void selecionarAndarDestino(int andar)
        {
            if (selecionarAndarDestinoEvent != null)
            {                
                selecionarAndarDestinoEvent(this, EventArgs.Empty, andar);                
            }
        }

        //Botões de subir do painel externo. Envia  o evento para o controler.
        private void chamarElevadorSubir(int andar)
        {
            if (chamarElevadorSubirEvent != null)
            {                
                chamarElevadorSubirEvent(this, EventArgs.Empty, andar);
            }
        }

        //Botões de descer do painel externo. Envia envia o evento para o controler.
        private void chamarElevadorDescer(int andar)
        {
            if (chamarElevadorDescerEvent != null)
            {                
                chamarElevadorDescerEvent(this, EventArgs.Empty, andar);
            }
        }

        //metódos de click dos botões. Tanto painel externo quanto interno.
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
