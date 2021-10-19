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
    public partial class CadProdutos : Form
    {
        public CadProdutos()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Tratamento de erro
            try
            {
                this.Validate();
                this.produtoBindingSource.EndEdit();
                produtoTableAdapter.Update(lvSystemDataSet.Produto);
                groupBox1.Enabled = false; //Bloqueia Groupbox após salvar
                MessageBox.Show("Registro Salvo");


            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.lvSystemDataSet.Produto);


        }

        private void produtoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lvSystemDataSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            produtoBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try //Tratamento de erro
            {
                if (MessageBox.Show("Confirma a exclusão do registro", "LVSystem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    produtoBindingSource.RemoveCurrent();//remove
                    produtoTableAdapter.Update(lvSystemDataSet.Produto);//salva

                }

            }
            catch (Exception)//se "ele" não conseguir aqui captura o erro 
            {
                produtoTableAdapter.Fill(lvSystemDataSet.Produto); //se não tiver esse metodo, o registro é excluido mas ainda fica no bd
                MessageBox.Show("Registro não pode ser excluido");
            }
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Tratamento de erro
            try
            {
                this.Validate();
                this.produtoBindingSource.EndEdit();
                produtoTableAdapter.Update(lvSystemDataSet.Produto);
                groupBox1.Enabled = false; //Bloqueia Groupbox após salvar
                MessageBox.Show("Registro Salvo");


            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            produtoBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.CodigoLocalizado = 0;
            FrmLocalizarProduto frmLocalizarProduto = new FrmLocalizarProduto();
            frmLocalizarProduto.ShowDialog();
            if (VariaveisGlobais.CodigoLocalizado > 0)
            {
                //Posicionar Código Localizado
                produtoBindingSource.Position = produtoBindingSource.Find("Id", VariaveisGlobais.CodigoLocalizado);
            }
        }
    }
}
