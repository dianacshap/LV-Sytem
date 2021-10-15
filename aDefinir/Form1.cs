using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aDefinir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           //minimizar
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnInicio_Click(object sender, EventArgs e)
        {
            
            panel2.Controls.Clear(); //para voltar a tela inicio
            panelSelecao.Top = btnInicio.Top;



        }

        private void btnCarros_Click(object sender, EventArgs e)
        {
            CadCarros cadCarros = new CadCarros();
            CadCarros carros = cadCarros;  //instanciar form
            carros.TopLevel = false; //ñ é form de topo
            carros.Dock = DockStyle.Fill; //DockStyle.fill (preencher form)
            panel2.Controls.Clear(); // limpa o painel
            panel2.Controls.Add(carros); //add o form no painel
            carros.Show();

            //cursor panel seleçao
            panelSelecao.Top = btnCarros.Top;


        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            CadServicos cadServicos = new CadServicos();
            CadServicos Servicos = cadServicos;  //instanciar form
            Servicos.TopLevel = false; //ñ é form de topo
            Servicos.Dock = DockStyle.Fill; //DockStyle.fill (preencher form)
            panel2.Controls.Clear(); // limpa o painel
            panel2.Controls.Add(Servicos); //add o form no painel
            Servicos.Show();

            //cursor panel seleçao
            panelSelecao.Top = btnServico.Top;


        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            CadAgenda agenda = new CadAgenda
            {
                TopLevel = false, //ñ é form de topo
                Dock = DockStyle.Fill //DockStyle.fill (preencher form)
            };  //instanciar form
            panel2.Controls.Clear(); // limpa o painel
            panel2.Controls.Add(agenda); //add o form no painel
            agenda.Show();

            //cursor panel seleçao
            panelSelecao.Top = btnAgenda.Top;

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            CadClientes cliente = new CadClientes
            {
                TopLevel = false, //ñ é form de topo
                Dock = DockStyle.Fill //DockStyle.fill (preencher form)
            };  //instanciar form
            panel2.Controls.Clear(); // limpa o painel
            panel2.Controls.Add(cliente); //add o form no painel
            cliente.Show();

            //cursor panel seleçao
            panelSelecao.Top = btnCliente.Top;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "LV System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void btnMinizar_Click(object sender, EventArgs e)
        {
            //minimizar
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            CadProdutos produtos = new CadProdutos
            {
                TopLevel = false, //ñ é form de topo
                Dock = DockStyle.Fill //DockStyle.fill (preencher form)
            };  //instanciar form
            panel2.Controls.Clear(); // limpa o painel
            panel2.Controls.Add(produtos); //add o form no painel
            produtos.Show();

            panelSelecao.Top = btnProdutos.Top;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Recarrega os dados
            view_Detalhes_AgendamentosTableAdapter.Fill(lvSystemDataSet.View_Detalhes_Agendamentos);
            view_Detalhes_AgendamentosBindingSource.Filter = "DataAg = '" + DateTime.Now.ToShortDateString() + "'and situacao like 'Em Andamento'";
            int QuantidadeAndamento = int.Parse(view_Detalhes_AgendamentosBindingSource.Count.ToString());
            view_Detalhes_AgendamentosBindingSource.RemoveFilter();
            view_Detalhes_AgendamentosBindingSource.Filter = "DataAg ='" + DateTime.Now.ToShortDateString() + "' and situacao like 'Agendado'";
            int QuantidadeAgendado = int.Parse(view_Detalhes_AgendamentosBindingSource.Count.ToString());
            lblEmAndamento.Text = QuantidadeAndamento.ToString();
            lblAgendado.Text = QuantidadeAgendado.ToString();
        }
    }
}
