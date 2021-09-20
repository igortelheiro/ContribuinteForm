using System.Windows.Forms;

namespace ContribuinteForm
{
    partial class Contribuinte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.identificacaoLabel = new System.Windows.Forms.Label();
            this.documentoLabel = new System.Windows.Forms.Label();
            this.cartaoLabel = new System.Windows.Forms.Label();
            this.identificacaoInput = new System.Windows.Forms.TextBox();
            this.cartaoInput = new System.Windows.Forms.TextBox();
            this.documentoInput = new System.Windows.Forms.MaskedTextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.tipoPessoaSelect = new System.Windows.Forms.ComboBox();
            this.tipoPessoaLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // identificacaoLabel
            // 
            this.identificacaoLabel.AutoSize = true;
            this.identificacaoLabel.Location = new System.Drawing.Point(101, 87);
            this.identificacaoLabel.Name = "identificacaoLabel";
            this.identificacaoLabel.Size = new System.Drawing.Size(87, 17);
            this.identificacaoLabel.TabIndex = 1;
            this.identificacaoLabel.Text = "Identificação";
            // 
            // documentoLabel
            // 
            this.documentoLabel.AutoSize = true;
            this.documentoLabel.Location = new System.Drawing.Point(101, 229);
            this.documentoLabel.Name = "documentoLabel";
            this.documentoLabel.Size = new System.Drawing.Size(34, 17);
            this.documentoLabel.TabIndex = 2;
            this.documentoLabel.Text = "CPF";
            // 
            // cartaoLabel
            // 
            this.cartaoLabel.AutoSize = true;
            this.cartaoLabel.Location = new System.Drawing.Point(101, 302);
            this.cartaoLabel.Name = "cartaoLabel";
            this.cartaoLabel.Size = new System.Drawing.Size(50, 17);
            this.cartaoLabel.TabIndex = 6;
            this.cartaoLabel.Text = "Cartão";
            // 
            // identificacaoInput
            // 
            this.identificacaoInput.Location = new System.Drawing.Point(101, 106);
            this.identificacaoInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.identificacaoInput.Name = "identificacaoInput";
            this.identificacaoInput.Size = new System.Drawing.Size(233, 22);
            this.identificacaoInput.TabIndex = 0;
            // 
            // cartaoInput
            // 
            this.cartaoInput.Location = new System.Drawing.Point(101, 320);
            this.cartaoInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartaoInput.Name = "cartaoInput";
            this.cartaoInput.Size = new System.Drawing.Size(233, 22);
            this.cartaoInput.TabIndex = 7;
            // 
            // documentoInput
            // 
            this.documentoInput.BackColor = System.Drawing.SystemColors.Window;
            this.documentoInput.Location = new System.Drawing.Point(101, 248);
            this.documentoInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.documentoInput.Mask = "000,000,000-00";
            this.documentoInput.Name = "documentoInput";
            this.documentoInput.Size = new System.Drawing.Size(233, 22);
            this.documentoInput.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(150, 413);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 37);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Adicionar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(746, 413);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(99, 37);
            this.removeButton.TabIndex = 14;
            this.removeButton.Text = "Remover";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // tipoPessoaSelect
            // 
            this.tipoPessoaSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoPessoaSelect.FormattingEnabled = true;
            this.tipoPessoaSelect.Location = new System.Drawing.Point(101, 177);
            this.tipoPessoaSelect.Name = "tipoPessoaSelect";
            this.tipoPessoaSelect.Size = new System.Drawing.Size(233, 24);
            this.tipoPessoaSelect.TabIndex = 15;
            this.tipoPessoaSelect.SelectedIndexChanged += new System.EventHandler(this.tipoPessoaSelect_SelectedIndexChanged);
            // 
            // tipoPessoaLabel
            // 
            this.tipoPessoaLabel.AutoSize = true;
            this.tipoPessoaLabel.Location = new System.Drawing.Point(101, 157);
            this.tipoPessoaLabel.Name = "tipoPessoaLabel";
            this.tipoPessoaLabel.Size = new System.Drawing.Size(107, 17);
            this.tipoPessoaLabel.TabIndex = 16;
            this.tipoPessoaLabel.Text = "Tipo de Pessoa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(509, 87);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(599, 305);
            this.dataGridView1.TabIndex = 17;
            // 
            // Contribuinte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1173, 493);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tipoPessoaLabel);
            this.Controls.Add(this.tipoPessoaSelect);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cartaoInput);
            this.Controls.Add(this.cartaoLabel);
            this.Controls.Add(this.documentoLabel);
            this.Controls.Add(this.identificacaoInput);
            this.Controls.Add(this.identificacaoLabel);
            this.Controls.Add(this.documentoInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Contribuinte";
            this.Text = "Contribuinte";
            this.Load += new System.EventHandler(this.Contribuinte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label identificacaoLabel;
        private System.Windows.Forms.Label tipoPessoaLabel;
        private System.Windows.Forms.Label documentoLabel;
        private System.Windows.Forms.Label cartaoLabel;
        private System.Windows.Forms.TextBox identificacaoInput;
        private System.Windows.Forms.ComboBox tipoPessoaSelect;
        private System.Windows.Forms.MaskedTextBox documentoInput;
        private System.Windows.Forms.TextBox cartaoInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private DataGridView dataGridView1;
    }
}

