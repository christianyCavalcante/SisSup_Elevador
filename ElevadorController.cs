using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;


namespace SisSup_Elevador
{
    public class ElevadorController
	{
		//private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		private static readonly int TEMPO_ELEVADOR_ENTRE_ANDARES = 2000;		

		private int andarAtual;
		private String statusElevador;
		private Queue<ChamadaElevador> filaChamadas;
		

		public delegate void alterarStatusElevadorEventHandler(object source, EventArgs args, String status);
		public event alterarStatusElevadorEventHandler alterarStatusElevadorEvent;

		public delegate void alterarAndarAtualEventHandler(object source, EventArgs args, int andarAtual);
		public event alterarAndarAtualEventHandler alterarAndarAtualEvent;

		public ElevadorController(frmElevador frmElevador)
		{
			this.filaChamadas = new Queue<ChamadaElevador>();

			this.alterarStatusElevadorEvent += frmElevador.onAlterarStatusElevadorEventHandler;
			this.alterarAndarAtualEvent += frmElevador.onAlterarAndarAtualEventHandler;
		}


		public void onSelecionarAndarDestino(object source, EventArgs args, int andar)
		{			
			if(andar > this.andarAtual)
            {
				this.onChamarElevadorSubir(source, args, andar);
            }	
			else if (andar < this.andarAtual)
            {
				this.onChamarElevadorDescer(source, args, andar);
			}

		}


		public void onChamarElevadorSubir(object source, EventArgs args, int andar)
		{			
			filaChamadas.Enqueue(new ChamadaElevador(andar,"SUBIR"));
		}


		public void onChamarElevadorDescer(object source, EventArgs args, int andar)
        {						
			filaChamadas.Enqueue(new ChamadaElevador(andar, "DESCER"));
		}

		

		private void alterarStatusElevador(String status)
        {
			this.statusElevador = status;
			if(alterarStatusElevadorEvent!= null)
            {
				alterarStatusElevadorEvent(this, EventArgs.Empty, status);
			}
        }

		private void alterarAndarAtual(int andar)
		{			
			this.andarAtual = andar;
			if (alterarAndarAtualEvent != null)
			{
				alterarAndarAtualEvent(this, EventArgs.Empty, andar);
			}
		}


		public void processarComandos()
		{
			this.alterarStatusElevador("PARADO");
			this.alterarAndarAtual(0);
			
            while (true)
            {			

				if (this.filaChamadas.Count > 0)
                {

					//pego a proxima chamada na fila
					var chamadaElevador = this.filaChamadas.Dequeue();					
					
					//o elevador irá subir
					if (chamadaElevador.Andar > this.andarAtual)
                    {
						this.alterarStatusElevador("SUBINDO");
						for(int i = this.andarAtual; i<= chamadaElevador.Andar; i++)
                        {							
							this.alterarAndarAtual(i);
							Thread.Sleep(TEMPO_ELEVADOR_ENTRE_ANDARES);
							
                        }
						
					}
					//elevador irá descer
                    else if(chamadaElevador.Andar < this.andarAtual)
					{
						this.alterarStatusElevador("DESCENDO");
						for (int i = this.andarAtual; i >= chamadaElevador.Andar; i--)
						{
							this.alterarAndarAtual(i);
							Thread.Sleep(TEMPO_ELEVADOR_ENTRE_ANDARES);
							
							
						}
					}					

					this.alterarStatusElevador("PARADO");
					
				}

				
			}		
			
		}

	}

	class ChamadaElevador
    {
        private int andar;
		private String direcao;

        public ChamadaElevador(int andar, string direcao)
        {
            this.andar = andar;
            this.direcao = direcao;
        }

        public int Andar { get => andar; set => andar = value; }
        public string Direcao { get => direcao; set => direcao = value; }

        public override string ToString()
        {
			return this.andar + " - " + this.direcao;

		}
    }

}

