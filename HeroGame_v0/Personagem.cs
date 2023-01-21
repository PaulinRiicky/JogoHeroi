/*
 * Criado por SharpDevelop.
 * Usuário: lilih
 * Data: 01/09/2022
 * Hora: 23:02
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Windows.Forms;
using System.Drawing;

namespace HeroGame_v0
{
	
	public class Personagem: PictureBox
	{
		public Personagem()
		{
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
		}
		
		public int hp = 200;
		public int atk = 2;
		public int def = 3;
		public int xp = 0;
		public int speed = 15;
		public string imagem = "";
		
	}
}
