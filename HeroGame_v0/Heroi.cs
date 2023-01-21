/*
 * Criado por SharpDevelop.
 * Usuário: lilih
 * Data: 01/09/2022
 * Hora: 23:20
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HeroGame_v0
{
	
	public class Heroi: Personagem
	{
		public Heroi()
		{
			imagem = "goku.gif";
			Load(imagem);
			Width = 120;
			Height = 90;
			Left = 20;
			Top = 400;
		}
		
		public bool kaiokenOn = false;
		public int transformK = 0;
		public int nivelHeroi = 1;
		public int sentido = 1;
		int contCenario = 1;
		//	int statusCenario = 1;
		
		public string imagemDir = "goku.gif";
		public string imagemEsq = "gokuRev.gif";
		public string imagemDirKaioken = "gokuKaioken.gif";
		public string imagemEsqKaioken = "gokuKaiokenRev.gif";
		
		//	public string statusGround = "True";
		//	public string statusSky = "Sky";
		
		
		
		
		
		public void Direita()
		{
			
			Left += speed;
			
			if(sentido != 1){
				sentido = 1;
				Load(imagemDir);
			}
			
			if (Left > MainForm.scene.Width - this.Width){
				Left = 0;
				contCenario++;
				if(contCenario > 3) {
					//if()
					contCenario = 1;
				}
				MainForm.scene.Load("namekTrue" + contCenario + ".png");
			}
		}
		
		
		
		
		
		
		public void Esquerda()
		{
			Left -= speed;
			if(sentido != -1){
				sentido = -1;
				Load(imagemEsq);
			}
			
			if (Left < 0){
				Left = MainForm.scene.Width - this.Width;
				contCenario--;
				if(contCenario < 1) {
					//if()
					contCenario = 3;
				}
				MainForm.scene.Load("namekTrue" + contCenario + ".png");
			}
		
		}
		
		
		
		
		
		
		
		public void Cima()
		{
			Top -= speed;
			if (Top < -20){
				Top = -20;
			}
		}
		
		
		
		
		
		
		
		
		
		
		
		
		public void Baixo()
		{
			Top += speed;
			if (Top > MainForm.scene.Height - (this.Height - 20)){
				Top = MainForm.scene.Height - (this.Height - 20);
			}
		}
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		public void NivelUp()
		{
			nivelHeroi += 1;
			
			if(nivelHeroi == 15){				
				kaiokenOn = true;
				
//				Não consegui implementar a transformação na função Kaioken, por isso carreguei a imagem ao atingir o nivel 15
				Load(imagemDirKaioken);
				MessageBox.Show("KAIOKEEEN!!!!");
			}
		}	
		
		
		
		
		
		
		
		
		
		
		
		
		public void Kaioken(){
			if(kaiokenOn == true){
				if(transformK == 1 && sentido == 1){
					Load(imagemDirKaioken);
				}
				
				if(transformK == 1 && sentido == -1){
					Load(imagemEsqKaioken);
				}
				
				if(transformK != 1 && sentido == 1){
					Load(imagemDir);
				}
				
				if(transformK != 1 && sentido == -1){
					Load(imagemEsq);
				}
			}
		}
		
		
		
		
		
		
		
	}
}
