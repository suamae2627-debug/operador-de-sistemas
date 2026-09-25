// Importação do namespace principal do sistema
using System;
// Importação de namespaces para trabalhar com coleções genéricas
using System.Collections.Generic;
// Importação de componentes e modelos de comportamento do Windows Forms
using System.ComponentModel;
// Importação de namespaces para manipulação de dados
using System.Data;
// Importação de namespaces para recursos gráficos e desenho (cores, imagens)
using System.Drawing;
// Importação de namespaces para consultas LINQ (manipulação de listas/dados)
using System.Linq;
// Importação de namespaces para manipulação avançada de textos e codificação
using System.Text;
// Importação de namespaces para execução de tarefas assíncronas
using System.Threading.Tasks;
// Importação do namespace principal para criação de interfaces Windows Forms
using System.Windows.Forms;

// Declaração do namespace do projeto (organizador do código)
namespace cadastro
{
    // Declaração da classe parcial do formulário de cadastro, herdando da classe Form
    public partial class Frm_Cadastro : Form
    {
        // Construtor do formulário Frm_Cadastro
        public Frm_Cadastro()
        {
            // Inicializa todos os componentes visuais desenhados na tela (botões, caixas de texto, etc.)
            InitializeComponent();
        }

        // Evento executado quando o formulário é carregado na memória
        private void Frm_Cadastro_Load(object sender, EventArgs e)
        {
            // Bloco de código vazio (sem ações configuradas ao carregar o formulário)
        }

        // Evento executado ao clicar no componente label2
        private void label2_Click(object sender, EventArgs e)
        {
            // Bloco de código vazio (sem ações configuradas para o clique da label2)
        }

        // Evento executado ao clicar no componente label4
        private void label4_Click(object sender, EventArgs e)
        {
            // Bloco de código vazio (sem ações configuradas para o clique da label4)
        }

        // Evento disparado quando o estado de seleção do RadioButton 'rad_tema1' muda
        private void rad_tema1_CheckedChanged(object sender, EventArgs e)
        {
            // Altera a imagem de fundo do formulário para a 'imagem1' armazenada nos Recursos do projeto
            this.BackgroundImage = Properties.Resources.imagem1;
        }

        // Evento disparado quando o estado de seleção do RadioButton 'rad_tema2' muda
        private void rad_tema2_CheckedChanged(object sender, EventArgs e)
        {
            // Altera a imagem de fundo do formulário para a 'imagem2' armazenada nos Recursos do projeto
            this.BackgroundImage = Properties.Resources.imagem2;
        }

        // Evento disparado quando o estado de seleção do RadioButton 'rad_tema3' muda
        private void rad_tema3_CheckedChanged(object sender, EventArgs e)
        {
            // Altera a imagem de fundo do formulário para a 'imagem4' armazenada nos Recursos do projeto
            this.BackgroundImage = Properties.Resources.imagem4;
        }

        // Evento disparado sempre que o texto dentro da caixa 'txt_Nome' é alterado
        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {
            // Bloco de código vazio (sem ações configuradas para a alteração de texto)
        }

        // Evento executado ao clicar no botão 'btn_Nome'
        private void btn_Nome_Click(object sender, EventArgs e)
        {
            // Exibe o texto digitado na caixa 'txt_Nome' dentro do rótulo 'lbl_Resultado'
            lbl_Resultado.Text = txt_Nome.Text;
        }

        // Evento executado ao clicar no botão 'btn_Sobrenome'
        private void btn_Sobrenome_Click(object sender, EventArgs e)
        {
            // Exibe o texto digitado na caixa 'txt_Sobrenome' dentro do rótulo 'lbl_Resultado'
            lbl_Resultado.Text = txt_Sobrenome.Text;
        }

        // Evento executado ao clicar no botão 'btn_Idade'
        private void btn_Idade_Click(object sender, EventArgs e)
        {
            // Exibe o texto digitado na caixa 'txt_Idade' dentro do rótulo 'lbl_Resultado'
            lbl_Resultado.Text = txt_Idade.Text;
        }

        // Evento executado ao clicar no botão 'btn_Bairro'
        private void btn_Bairro_Click(object sender, EventArgs e)
        {
            // Exibe o texto digitado na caixa 'txt_Bairro' dentro do rótulo 'lbl_Resultado'
            lbl_Resultado.Text = txt_Bairro.Text;
        }

        // Evento executado ao clicar no botão 'btn_Celular'
        private void btn_Celular_Click(object sender, EventArgs e)
        {
            // Exibe o texto digitado na caixa 'txt_Celular' dentro do rótulo 'lbl_Resultado'
            lbl_Resultado.Text = txt_Celular.Text;
        }

        // Evento executado ao clicar no botão 'btn_Email'
        private void btn_Email_Click(object sender, EventArgs e)
        {
            // Exibe o texto digitado na caixa 'txt_Email' dentro do rótulo 'lbl_Resultado'
            lbl_Resultado.Text = txt_Email.Text;
        }

        // Evento executado ao clicar no botão 'btn_DadosCompletos'
        private void btn_DadosCompletos_Click(object sender, EventArgs e)
        {
            // Junta todas as informações das caixas de texto com quebras de linha (\n) e exibe na 'lbl_Resultado'
            lbl_Resultado.Text = txt_Nome.Text + " " + txt_Sobrenome.Text + "\n" + txt_Idade.Text + "\n" + txt_Bairro.Text + "\n" + txt_Celular.Text + "\n" + txt_Email.Text;
        }

        // Evento executado ao clicar no botão 'btn_Limpar'
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            // Limpa o texto exibido no rótulo de resultado
            lbl_Resultado.Text = "";
            // Limpa o conteúdo digitado na caixa de texto do Bairro
            txt_Bairro.Clear();
            // Limpa o conteúdo digitado na caixa de texto do Celular
            txt_Celular.Clear();
            // Limpa o conteúdo digitado na caixa de texto do Nome
            txt_Nome.Clear();
            // Limpa o conteúdo digitado na caixa de texto da Idade
            txt_Idade.Clear();
            // Limpa o conteúdo digitado na caixa de texto do Sobrenome
            txt_Sobrenome.Clear();
            // Limpa o conteúdo digitado na caixa de texto do Email
            txt_Email.Clear();
        }

        // Evento executado ao clicar no botão 'btn_ativar'
        private void btn_ativar_Click(object sender, EventArgs e)
        {
            // Ativa o grupo de seleção de temas para que possa ser clicado
            grp_Temas.Enabled = true;
            // Ativa o botão de desativar os campos da tela
            btn_Desativar.Enabled = true;
            // Ativa o botão de limpar os campos
            btn_Limpar.Enabled = true;
            // Ativa o botão correspondente ao campo Nome
            btn_Nome.Enabled = true;
            // Ativa o botão correspondente ao campo Sobrenome
            btn_Sobrenome.Enabled = true;
            // Ativa o botão correspondente ao campo Idade
            btn_Idade.Enabled = true;
            // Ativa o botão correspondente ao campo Bairro
            btn_Bairro.Enabled = true;
            // Ativa o botão correspondente ao campo Celular
            btn_Celular.Enabled = true;
            // Ativa o botão correspondente ao campo Email
            btn_Email.Enabled = true;
            // Ativa o botão para exibir os dados completos
            btn_DadosCompletos.Enabled = true;
            // Ativa o rótulo descritivo de Dados Pessoais
            lbl_DadosP.Enabled = true;
            // Ativa o rótulo descritivo do campo Nome
            lbl_Nome.Enabled = true;
            // Ativa o rótulo descritivo do campo Sobrenome
            lbl_Sobrenome.Enabled = true;
            // Ativa o rótulo descritivo do campo Idade
            lbl_Idade.Enabled = true;
            // Ativa o rótulo descritivo do campo Bairro
            lbl_Bairro.Enabled = true;
            // Ativa o rótulo descritivo do campo Celular
            lbl_Celular.Enabled = true;
            // Ativa o rótulo descritivo do campo Email
            lbl_Email.Enabled = true;
            // Ativa o rótulo descritivo de Confirmação da operação
            lbl_ConfirmaçãoDa.Enabled = true;
            // Ativa o rótulo onde os resultados finais são exibidos
            lbl_Resultado.Enabled = true;
            // Permite a digitação na caixa de texto do Nome
            txt_Nome.Enabled = true;
            // Permite a digitação na caixa de texto do Sobrenome
            txt_Sobrenome.Enabled = true;
            // Permite a digitação na caixa de texto da Idade
            txt_Idade.Enabled = true;
            // Permite a digitação na caixa de texto do Bairro
            txt_Bairro.Enabled = true;
            // Permite a digitação na caixa de texto do Celular
            txt_Celular.Enabled = true;
            // Permite a digitação na caixa de texto do Email
            txt_Email.Enabled = true;
        }

        // Evento executado ao clicar no botão 'btn_Desativar'
        private void btn_Desativar_Click(object sender, EventArgs e)
        {
            // Bloqueia e acinzenta o grupo de seleção de temas
            grp_Temas.Enabled = false;
            // Bloqueia o próprio botão de desativar para evitar cliques repetidos
            btn_Desativar.Enabled = false;
            // Reativa o botão 'btn_ativar' para que o usuário possa desbloquear a tela depois
            btn_ativar.Enabled = true;
            // Bloqueia e acinzenta o botão de limpar campos
            btn_Limpar.Enabled = false;
            // Bloqueia e acinzenta o botão correspondente ao campo Nome
            btn_Nome.Enabled = false;
            // Bloqueia e acinzenta o botão correspondente ao campo Sobrenome
            btn_Sobrenome.Enabled = false;
            // Bloqueia e acinzenta o botão correspondente ao campo Idade
            btn_Idade.Enabled = false;
        }
    }
}
