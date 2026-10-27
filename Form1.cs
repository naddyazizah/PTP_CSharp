using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aula_1_CSharp
{
    public class Form1 : Form
    {
        public Form1()
        {
            Text = "Aula_1_CSharp";

            var botao = new Button();
            botao.Text = "Clica em mim";
            botao.AutoSize = true;
            botao.Location = new Point(50, 50);
            botao.Click += (s, e) => MessageBox.Show("Olá, Mundo!");

            Controls.Add(botao);
        }
    }
}