using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceitaNewsAPI
{

    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
    
        }

        private async void bt_consultar_Click(object sender, EventArgs e)
        {

            var buscaCNPJ = new ReceitaNewsRest();

            var resultado = await buscaCNPJ.BuscarCNPJ(te_CNPJ.Text.ToString().Trim());

            // exibir resultado da busca ou fazer outras ações com os dados
            if (resultado.DadosRetorno != null)
            {

                te_CEP.Text = resultado.DadosRetorno.Cep;




            }

        }
    }

}
