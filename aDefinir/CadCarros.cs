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


        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            carrosBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try //Tratamento de erro
            {
                if (MessageBox.Show("Confirma a exclusão do registro", "LVSystem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    carrosBindingSource.RemoveCurrent();//remove
                    carrosTableAdapter.Update(lvSystemDataSet.Carros);//salva

                }

            }
            catch (Exception)//se "ele" não conseguir aqui captura o erro 
            {
                carrosTableAdapter.Fill(lvSystemDataSet.Carros); //se não tiver esse metodo, o registro é excluido mas ainda fica no bd
                MessageBox.Show("Registro não pode ser excluido");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            clientesBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Tratamento de erro
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

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            carrosBindingSource.MoveFirst();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.CodigoLocalizado = 0;
            FrmLocalizarVeiculo frmLocalizarVeiculo = new FrmLocalizarVeiculo();
            frmLocalizarVeiculo.ShowDialog();
            if (VariaveisGlobais.CodigoLocalizado > 0)
            {
                //Posicionar Código Localizado
                carrosBindingSource.Position = carrosBindingSource.Find("Id", VariaveisGlobais.CodigoLocalizado);
            }
        }
    }
}
