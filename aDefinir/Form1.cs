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

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "LV System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
           //minimizar
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadClientes cliente = new CadClientes();  //instanciar form
            cliente.TopLevel = false; //ñ é form de topo
            cliente.Dock = DockStyle.Fill; //DockStyle.fill (preencher form)
            panelCentral.Controls.Clear(); // limpa o painel
            panelCentral.Controls.Add(cliente); //add o form no painel
            cliente.Show();

            //cursor panel seleçao
            panelSelecao.Top = btnCliente.Top;

      
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelCentral.Controls.Clear(); //para voltar a tela inicio

           


        }

        private void btnCarros_Click(object sender, EventArgs e)
        {
            CadCarros carros = new CadCarros();  //instanciar form
            carros.TopLevel = false; //ñ é form de topo
            carros.Dock = DockStyle.Fill; //DockStyle.fill (preencher form)
            panelCentral.Controls.Clear(); // limpa o painel
            panelCentral.Controls.Add(carros); //add o form no painel
            carros.Show();

            //cursor panel seleçao
            panelSelecao.Top = btnCliente.Top;


        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            CadServicos Servicos = new CadServicos();  //instanciar form
            Servicos.TopLevel = false; //ñ é form de topo
            Servicos.Dock = DockStyle.Fill; //DockStyle.fill (preencher form)
            panelCentral.Controls.Clear(); // limpa o painel
            panelCentral.Controls.Add(Servicos); //add o form no painel
            Servicos.Show();

            //cursor panel seleçao
            panelSelecao.Top = btnCliente.Top;


        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            CadAgenda agenda = new CadAgenda();  //instanciar form
            agenda.TopLevel = false; //ñ é form de topo
            agenda.Dock = DockStyle.Fill; //DockStyle.fill (preencher form)
            panelCentral.Controls.Clear(); // limpa o painel
            panelCentral.Controls.Add(agenda); //add o form no painel
            agenda.Show();

            //cursor panel seleçao
            panelSelecao.Top = btnCliente.Top;

        }
    }
}
