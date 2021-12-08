using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SisSup_Elevador
{
    public class Simulador
    {
        private ElevadorController elevadorController;

        //CONSTANTE DE TEMPO ENTRE AS CHAMADAS DO SIMULADOR
        private const int INTEVALO_PARA_GERAR_CHAMADAS = 10000;


        private const int DESCER = 0;
        private const int SUBIR = 1;

        //EVENTOS PARA COMUNICAR AO CONTROLER AS CHAMADAS DO SIMULADOR
        public delegate void chamarElevadorSubirEventHandler(object source, EventArgs args, int andar);
        public event chamarElevadorSubirEventHandler chamarElevadorSubirEvent;

        public delegate void chamarElevadorDescerEventHandler(object source, EventArgs args, int andar);
        public event chamarElevadorDescerEventHandler chamarElevadorDescerEvent;


        public Simulador(ElevadorController elevadorController)
        {
            this.elevadorController = elevadorController;

            this.chamarElevadorSubirEvent += elevadorController.onChamarElevadorSubir;
            this.chamarElevadorDescerEvent += elevadorController.onChamarElevadorDescer;

        }

        //PROCESSO QUE FICA GERANDO CHAMADAS PSEUDO ALEATORIOAS
        public void simularChamadas(CancellationToken simuladorCancellationToken)
        {            
            Random randNum = new Random();
            while (!simuladorCancellationToken.IsCancellationRequested)
            {   
                switch (randNum.Next(0, 2))
                {
                    case DESCER:
                        
                        if (chamarElevadorDescerEvent != null)
                        {
                            chamarElevadorDescerEvent(this, EventArgs.Empty, randNum.Next(0, 5));
                        }
                        break;
                    case SUBIR:

                        if (chamarElevadorSubirEvent != null)
                        {
                            chamarElevadorSubirEvent(this, EventArgs.Empty, randNum.Next(0, 5));
                        }
                        break;
                }
                Thread.Sleep(INTEVALO_PARA_GERAR_CHAMADAS);
            }            

        }
    }
}
