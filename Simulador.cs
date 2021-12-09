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

        //constantes para facilitar a leitura do switch case
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

        //PROCESSO DE SIMULAÇÃO, QUE FICA GERANDO CHAMADAS PSEUDO ALEATORIOAS
        public void simularChamadas(CancellationToken simuladorCancellationToken)
        {            
            //classe que irá gerar os números aleatórios
            Random randNum = new Random();

            //A TASK DO SIMULADOR FICA RODANDO ATÉ QUE O TOKEN SEJA CANCELADO (o token será cancelado quando foi ativado o modo manual)
            while (!simuladorCancellationToken.IsCancellationRequested)
            {   
                //gera de forma randomica 0 ou 1, que indicará se a chamada é para subir ou descer o elevador
                switch (randNum.Next(0, 2))
                {
                    case DESCER:
                        
                        if (chamarElevadorDescerEvent != null)
                        {
                            //chama um evento para descer o elevador, gerando o número do andar de forma randomica
                            chamarElevadorDescerEvent(this, EventArgs.Empty, randNum.Next(0, 5));
                        }
                        break;
                    case SUBIR:

                        if (chamarElevadorSubirEvent != null)
                        {
                            //chama um evento para subir o elevador, gerando o número do andar de forma randomica
                            chamarElevadorSubirEvent(this, EventArgs.Empty, randNum.Next(0, 5));
                        }
                        break;
                }
                //espera um tempo determinado até gerar a próxima chamada.
                Thread.Sleep(INTEVALO_PARA_GERAR_CHAMADAS);
            }            

        }
    }
}
