using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Leitor_Texto.View
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btLer_Click(object sender, EventArgs e)
        {
            string endereco = @"D:\a\teste.txt";

            try
            {
                if (!System.IO.File.Exists(endereco))
                {
                    throw new Exception(
                    "Arquivo teste.txt não foi localizado. "
                    );
                }
                string[] dados = new string[4];

                System.IO.StreamReader Leitor = new System.IO.StreamReader(endereco);

                lblLeitor.Items.Add(
                    "Codigo".PadRight(7) +
                    "Cliente".PadRight(40) +
                    "Cidade".PadRight(20) +
                    "pais"
                    );
                lblLeitor.Items.Add(new string('-', 80));

                while (!Leitor.EndOfStream)
                  {
                    dados = Leitor.ReadLine().Split(';');

                    lblLeitor.Items.Add(
                        dados[0].PadRight(7) +
                        dados[1].PadRight(40) +
                        dados[2].PadRight(20) +
                        dados[3]);
                        
                  }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
