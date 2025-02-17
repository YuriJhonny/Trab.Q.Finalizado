using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace PedirProdutos
{
    public partial class Pedir: Form
    {
        // Declaração da variável para a conexão com o banco de dados
        private MySqlConnection Conexao;
        private string connectionString = "server=localhost;database=seu_banco;user=root;password=sua_senha;";


        public Pedir()
        {
            InitializeComponent();
        }

        private void PedirProduto()
        {
            // Criar uma Nova Conexão (data_source)
            Conexao = new MySqlConnection(connectionString);

            // Criar um Novo Objeto (Command, "cmd")
            MySqlCommand cmd = new MySqlCommand();

            // Conectar cmd à Conexao
            cmd.Connection = Conexao;

            // Abrir Conexao
            Conexao.Open();

            // Verificar se a Qtd é Válida (Tratamento de Erros)
            if (!int.TryParse(txtQtdPedir.Text, out int quantidade) || quantidade <= 0)
            {
                // MessageBox de Tratamento de Erros
                MessageBox.Show("Insira uma Quantidade Válida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lista com os nomes dos 13 produtos
            string[] produtos =
            {
                "Pato", "Hamburguer", "Bacon", "Alface", "Tomate", "Pão", "Queijo", "Presunto", "Ovo",
                "Sprite", "Pepsi", "Coca", "Charrua"
            };

            // Lista com as CheckBoxes correspondentes
            CheckBox[] checkBoxes =
            {
                cbPato, cbHamburguer, cbBacon, cbAlface, cbTomate, cbPao, cbQueijo, cbPresunto, cbOvo,
                cbSprite, cbPepsi, cbCoca, cbCharrua
            };

            // Criar comando SQL para inserir os pedidos
            cmd.CommandText = "INSERT INTO pedidos (produto, quantidade) VALUES (@Produto, @Quantidade)";

            for (int i = 0; i < checkBoxes.Length; i++)
            {
                if (checkBoxes[i].Checked) // Se o CheckBox estiver marcado
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Produto", produtos[i]);
                    cmd.Parameters.AddWithValue("@Quantidade", quantidade);

                    cmd.ExecuteNonQuery(); // Executar comando SQL
                }
            }

            // Fechar conexão após os pedidos
            Conexao.Close();

            // Exibir mensagem de sucesso
            MessageBox.Show("Pedido Realizado Com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            PedirProduto();
        }

        private void AtualizarList()
        {
            try
            {
                //Abrir Conexão c/ Data Base "Substituir p/ a nossa
                string data_source = "Server=localhost;Database=nome_do_banco;User ID=usuario;Password=senha;";

                // Usando "using" para garantir que a conexão será fechada corretamente
                using (MySqlConnection conexao = new MySqlConnection(data_source))
                {
                    // Abrir a conexão
                    conexao.Open();

                    // Consulta SQL para obter todos os dados da tabela de pedidos ou outra tabela
                    string sql = "SELECT * FROM pedidos";  // Altere "pedidos" caso necessário

                    // Criar o comando SQL
                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        // Executar o comando e obter os dados com o MySqlDataReader
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Limpar as linhas do DataGridView
                            dgvEstoque.Rows.Clear();

                            // Percorrer os dados do banco e adicionar no DataGridView
                            while (reader.Read())
                            {
                                // Adicionar as linhas ao DataGridView
                                dgvEstoque.Rows.Add(
                                reader["ID"].ToString(), // Coluna 1: ID
                                reader["produto"].ToString(), // Coluna 2: Produto
                                reader["quantidade"].ToString() // Coluna 3: Quantidade
                            );
                            }
                        }
                    }
                }

                // Mensagem indicando que a atualização foi bem-sucedida
                MessageBox.Show("Dados atualizados com sucesso!");
            }
            catch (Exception ex)
            {
                // Exibe qualquer erro ocorrido ao tentar atualizar os dados
                MessageBox.Show("Erro ao atualizar dados: " + ex.Message);
            }
        }

        private void Pedir_Load(object sender, EventArgs e)
        {
            AtualizarList();
        }
    }
}
