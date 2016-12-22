using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto3Camadas.Code.BLL;
using Projeto3Camadas.Code.DTO;

namespace Projeto3Camadas
{
    public partial class frmCadastroCliente : Form
    {
        ClienteBLL bll = new ClienteBLL();
        ClienteDTO dto = new ClienteDTO();

        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            dto.Nome = txtNome.Text;
            dto.Email = txtEmail.Text;
 
            if (txtID.Text == "")
            {
                bll.Inserir(dto);
                MessageBox.Show("O cliente foi cadastrado com sucesso", "Inserido com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dto.Id = int.Parse(txtID.Text);
                bll.Atualizar(dto);
                MessageBox.Show("O cliente foi atualizado com sucesso", "Atualizado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            LimparTela();
            CarregarGrid();
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            dgvClientes.DataSource = bll.SelecionaTodosClientes();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void LimparTela()
        {
            txtID.Clear();
            txtNome.Clear();
            txtEmail.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {

                var result = MessageBox.Show("Deseja realmente excluir o registro selecionado?", "Exclusão Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    bll.Excluir(txtID.Text);

                    MessageBox.Show("O cliente foi excluido com sucesso", "Excluido com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparTela();
                    CarregarGrid();
                }
            }
        }
    }
}
