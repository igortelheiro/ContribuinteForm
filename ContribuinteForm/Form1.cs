using System;
using System.Windows.Forms;
using ContribuinteForm.Model;
using ContribuinteForm.Repository;

namespace ContribuinteForm
{
    public partial class Contribuinte : Form
    {
        private readonly ContribuinteRepository _contribuinteRepository = new ContribuinteRepository();
        public Contribuinte()
        {
            InitializeComponent();
        }

        private void Contribuinte_Load(object sender, EventArgs e)
        {
            ConfigTipoPessoaSelect();
            ConfigDataGridView();
        }

        private void ConfigTipoPessoaSelect()
        {
            tipoPessoaSelect.DataSource = Enum.GetValues(typeof(TipoContribuinte));
            tipoPessoaSelect.SelectedItem = TipoContribuinte.PessoaFisica;
        }

        private void ConfigDataGridView()
        {
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            _contribuinteRepository.Add(new ContribuinteModel() { Identificacao = "Igor" });
            _contribuinteRepository.Add(new ContribuinteModel() { Identificacao = "Pedro" });

            dataGridView1.DataSource = new BindingSource(_contribuinteRepository, null);
            dataGridView1.ResetBindings();
        }

        private void identificacaoInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void tipoPessoaSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipoPessoa = (TipoContribuinte)tipoPessoaSelect.SelectedItem;
            if (tipoPessoa == TipoContribuinte.PessoaJuridica)
            {
                documentoLabel.Text = "CNPJ";
                documentoInput.Mask = "00,000,000/0000-00";
                return;
            }
            documentoLabel.Text = "CPF";
            documentoInput.Mask = "000,000,000-00";
        }

        private void documentoInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cartaoInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var newContribuinte = new ContribuinteModel
            {
                Identificacao = identificacaoInput.Text,
                TipoContribuinte = (TipoContribuinte)tipoPessoaSelect.SelectedItem,
                Documento = documentoInput.Text,
                Cartao = cartaoInput.Text
            };
            AddContribuinte(newContribuinte);
            ClearForm();
        }

        private void AddContribuinte(ContribuinteModel newContribuinte)
        {
            _contribuinteRepository.Add(newContribuinte);
            dataGridView1.ResetBindings();
        }

        private void ClearForm()
        {
            identificacaoInput.Text = string.Empty;
            tipoPessoaSelect.SelectedItem = TipoContribuinte.PessoaFisica;
            documentoInput.Text = string.Empty;
            cartaoInput.Text = string.Empty;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void RemoveContribuinte(string documentoContribuinte)
        {
            _contribuinteRepository.Delete(documentoContribuinte);
            dataGridView1.ResetBindings();
        }
    }
}
