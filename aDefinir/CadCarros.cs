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
    public partial class CadCarros : Form
    {
        public CadCarros()
        {
            InitializeComponent();
            
        }




        private void carrosBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.carrosBindingSource.EndEdit();
                carrosTableAdapter.Update(lvSystemDataSet.Carros);
                groupBox1.Enabled = false; //Bloqueia Groupbox após salvar
                MessageBox.Show("Registro Salvo");


            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");
            }
        }

        private void CadCarros_Load(object sender, EventArgs e)
        {
            //TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.lvSystemDataSet.Clientes);
           // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.Carros'. Você pode movê-la ou removê-la conforme necessário.
            this.carrosTableAdapter.Fill(this.lvSystemDataSet.Carros);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            carrosBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            carrosBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

    }
}
