using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace HeroGame_v0
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			button1.Left = (this.Width - button1.Width) / 2;
		}
		
		//Criando objetos do jogo
		//Tela de fundo
		public static Cenario scene = new Cenario();
		Heroi player = new Heroi();
		Label lbNivel = new Label();
		
		void Button1Click(object sender, EventArgs e)
		{
			button1.Visible = false;
			button1.Enabled = false;
			this.KeyPreview = true;
			
			//informações do cenário 
			scene.Parent = this;
			scene.Visible = true;
			scene.Width = this.Width;
			scene.Height = this.Height - 100;
			scene.Load("namekTrue1.png");
			
			lbNivel.Parent = this;
			lbNivel.Top = 530;
			lbNivel.Left = 20;
			lbNivel.Text = "Nível: " + player.nivelHeroi.ToString();
			lbNivel.Visible = true;
			
			
			
			
			//informações do personagem jogável
			player.Parent = scene;
			
		}
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			
			if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left){
				player.Esquerda();
				
			}
			
			if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right){
				player.Direita();
				
			}
			
			if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up){
				player.Cima();
				
			}
			
			if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down){
				player.Baixo();
				
			}

			if (e.KeyCode == Keys.F){
				player.NivelUp();
				lbNivel.Text = "Nível: " + player.nivelHeroi.ToString();
			}
			
			if(e.KeyCode == Keys.T){
				
				if(player.kaiokenOn = true){
					if(player.transformK != 1) 
						player.transformK = 1;
					
					if(player.transformK != 0) 
						player.transformK = 0;
				}
				
				player.Kaioken();
				
			}
						
		}
	}
}
