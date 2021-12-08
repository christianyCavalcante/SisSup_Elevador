using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Linq;


namespace SisSup_Elevador
{
    public class ElevadorController
	{

		private static readonly int TEMPO_ELEVADOR_ENTRE_ANDARES_EM_MOVIMENTO = 2000;
		private static readonly int TEMPO_ELEVADOR_ENTRE_ANDARES_PARADO = 5000;

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
			Logger.log("ANDAR SELECIONADO = " + andar);

			if (andar > this.andarAtual)
            {
				filaChamadas.Enqueue(new ChamadaElevador(andar, "SUBIR"));
			}	
			else if (andar < this.andarAtual)
            {
				filaChamadas.Enqueue(new ChamadaElevador(andar, "DESCER"));
			}

		}


		public void onChamarElevadorSubir(object source, EventArgs args, int andar)
		{
			Logger.log("ELEVADOR CHAMADO = " + andar + "ANDAR - SUBIR.");
			filaChamadas.Enqueue(new ChamadaElevador(andar,"SUBIR"));
		}


		public void onChamarElevadorDescer(object source, EventArgs args, int andar)
        {
			Logger.log("ELEVADOR CHAMADO = " + andar + "ANDAR - DESCER.");
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
						//subir os andares até o próximo andar da fila de chamadas
						this.alterarStatusElevador("SUBINDO");
						for (int i = this.andarAtual; i <= chamadaElevador.Andar; i++)
						{
							this.alterarAndarAtual(i);	

							//Verificar se on andar que está passando chamou também o elevador para subir
							if (this.filaChamadas.Where(x => x.Andar == i && x.Direcao == "SUBIR").Count() > 0)
                            {
								//parar o elevador
								this.alterarStatusElevador("PARADO");
								Thread.Sleep(TEMPO_ELEVADOR_ENTRE_ANDARES_PARADO);

								//remover a chamada da fila
								this.filaChamadas = new Queue<ChamadaElevador>(this.filaChamadas.Where(x => x.Andar != i || x.Direcao != "SUBIR"));

								//voltar a subir o elevador
								this.alterarStatusElevador("SUBINDO");
                            }
                            else
                            {
								Thread.Sleep(TEMPO_ELEVADOR_ENTRE_ANDARES_EM_MOVIMENTO);
							}
							
							
                        }
						
					}
					//elevador irá descer
                    else if(chamadaElevador.Andar < this.andarAtual)
					{
						//descer os andares até o próximo andar da fila de chamadas
						this.alterarStatusElevador("DESCENDO");
						for (int i = this.andarAtual; i >= chamadaElevador.Andar; i--)
						{
							this.alterarAndarAtual(i);

							//Verificar se on andar que está passando chamou também o elevador para descer
							if (this.filaChamadas.Where(x => x.Andar == i && x.Direcao == "DESCER").Count() > 0)
							{								
								//parar o elevador
								this.alterarStatusElevador("PARADO");
								Thread.Sleep(TEMPO_ELEVADOR_ENTRE_ANDARES_PARADO);

								//remover a chamada da fila
								this.filaChamadas = new Queue<ChamadaElevador>(this.filaChamadas.Where(x => x.Andar != i || x.Direcao != "DESCER"));

								//voltar a descer o elevador
								this.alterarStatusElevador("DESCENDO");
							}
							else
							{
								Thread.Sleep(TEMPO_ELEVADOR_ENTRE_ANDARES_EM_MOVIMENTO);
							}


						}
					}					

					this.alterarStatusElevador("PARADO");
					Thread.Sleep(TEMPO_ELEVADOR_ENTRE_ANDARES_PARADO);
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

