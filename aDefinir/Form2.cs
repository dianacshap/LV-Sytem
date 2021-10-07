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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void agendamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lvSystemDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lvSystemDataSet.Agendamento'. Você pode movê-la ou removê-la conforme necessário.
            this.agendamentoTableAdapter.Fill(this.lvSystemDataSet.Agendamento);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
           
            dataMaskedTextBox.Text = DateTime.Now.ToShortDateString();
            horaMaskedTextBox.Text = DateTime.Now.ToShortTimeString();
            totalTextBox.Text = "0.00";
           
        }
    }
}
