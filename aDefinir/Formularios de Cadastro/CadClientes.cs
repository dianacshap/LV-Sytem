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
    public partial class CadClientes : Form
    {
        public CadClientes()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Tratamento de erro
            try
            {
                this.Validate();
                this.clientesBindingSource.EndEdit();
                clientesTableAdapter.Update(lvSystemDataSet.Clientes);
                groupBox1.Enabled = false; //Bloqueia Groupbox após salvar
                MessageBox.Show("Registro Salvo");
            

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");
            }

               
        }

        private void CadClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.lvSystemDataSet.Clientes);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            clientesBindingSource.AddNew(); //Adiciona novo item
            groupBox1.Enabled = true; //Desbloqueia Group Box
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clientesBindingSource.CancelEdit();
            groupBox1.Enabled = false;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try //Tratamento de erro
            {
                if (MessageBox.Show("Confirma a exclusão do registro", "LVSystem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clientesBindingSource.RemoveCurrent();//remove
                    clientesTableAdapter.Update(lvSystemDataSet.Clientes);//salva

                }

            }
            catch(Exception)//se "ele" não conseguir aqui captura o erro 
            {
                clientesTableAdapter.Fill(lvSystemDataSet.Clientes); //se não tiver esse metodo, o registro é excluido mas ainda fica no bd
                MessageBox.Show("Registro não pode ser excluido");
            }
          

        }

        private void clientesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void clientesBindingNavigator_RefreshItems_1(object sender, EventArgs e)
        {

        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.CodigoLocalizado = 0;
            FrmLocalizarCliente frmLocalizar = new FrmLocalizarCliente();
            frmLocalizar.ShowDialog();
            if (VariaveisGlobais.CodigoLocalizado > 0)
            {
                //Posicionar Código Localizado
                clientesBindingSource.Position = clientesBindingSource.Find("Id", VariaveisGlobais.CodigoLocalizado);
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            FrmRelatorio frmRelatorio = new FrmRelatorio();
            frmRelatorio.ShowDialog();
        }
    }
}
