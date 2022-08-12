namespace FormTri
{
    partial class Form1
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
            this.labelResultado = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.DataGridView();
            this.labelnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.labeltelefone = new System.Windows.Forms.Label();
            this.labelcelular = new System.Windows.Forms.Label();
            this.labelcpf = new System.Windows.Forms.Label();
            this.labelcnpj = new System.Windows.Forms.Label();
            this.labelrazaosocial = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.txtcnpj = new System.Windows.Forms.TextBox();
            this.txtrazaosocial = new System.Windows.Forms.TextBox();
            this.labelendereco = new System.Windows.Forms.Label();
            this.labelrua = new System.Windows.Forms.Label();
            this.txtrua = new System.Windows.Forms.TextBox();
            this.labelnumero = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.labelbairro = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.labelcidade = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.labelcep = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.labelcadastro = new System.Windows.Forms.Label();
            this.btnconectar = new System.Windows.Forms.Button();
            this.btncriartabela = new System.Windows.Forms.Button();
            this.btninserir = new System.Windows.Forms.Button();
            this.btnprocurar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.txtclassificacao = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.SuspendLayout();
            // 
            // labelResultado
            // 
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(12, 10);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(1046, 44);
            this.labelResultado.TabIndex = 0;
            this.labelResultado.Text = "Resultado";
            // 
            // lista
            // 
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewComboBoxColumn1,
            this.rua,
            this.numero,
            this.bairro,
            this.cidade,
            this.estado,
            this.cep});
            this.lista.Location = new System.Drawing.Point(17, 419);
            this.lista.MultiSelect = false;
            this.lista.Name = "lista";
            this.lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista.Size = new System.Drawing.Size(1633, 183);
            this.lista.TabIndex = 2;
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Location = new System.Drawing.Point(14, 91);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(38, 13);
            this.labelnome.TabIndex = 5;
            this.labelnome.Text = "Nome:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(97, 84);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(480, 20);
            this.txtnome.TabIndex = 19;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Location = new System.Drawing.Point(12, 117);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(38, 13);
            this.labelemail.TabIndex = 20;
            this.labelemail.Text = "E-mail:";
            // 
            // labeltelefone
            // 
            this.labeltelefone.AutoSize = true;
            this.labeltelefone.Location = new System.Drawing.Point(10, 143);
            this.labeltelefone.Name = "labeltelefone";
            this.labeltelefone.Size = new System.Drawing.Size(52, 13);
            this.labeltelefone.TabIndex = 21;
            this.labeltelefone.Text = "Telefone:";
            // 
            // labelcelular
            // 
            this.labelcelular.AutoSize = true;
            this.labelcelular.Location = new System.Drawing.Point(10, 169);
            this.labelcelular.Name = "labelcelular";
            this.labelcelular.Size = new System.Drawing.Size(42, 13);
            this.labelcelular.TabIndex = 22;
            this.labelcelular.Text = "Celular:";
            // 
            // labelcpf
            // 
            this.labelcpf.AutoSize = true;
            this.labelcpf.Location = new System.Drawing.Point(14, 195);
            this.labelcpf.Name = "labelcpf";
            this.labelcpf.Size = new System.Drawing.Size(30, 13);
            this.labelcpf.TabIndex = 23;
            this.labelcpf.Text = "CPF:";
            // 
            // labelcnpj
            // 
            this.labelcnpj.AutoSize = true;
            this.labelcnpj.Location = new System.Drawing.Point(15, 221);
            this.labelcnpj.Name = "labelcnpj";
            this.labelcnpj.Size = new System.Drawing.Size(37, 13);
            this.labelcnpj.TabIndex = 24;
            this.labelcnpj.Text = "CNPJ:";
            // 
            // labelrazaosocial
            // 
            this.labelrazaosocial.AutoSize = true;
            this.labelrazaosocial.Location = new System.Drawing.Point(12, 248);
            this.labelrazaosocial.Name = "labelrazaosocial";
            this.labelrazaosocial.Size = new System.Drawing.Size(73, 13);
            this.labelrazaosocial.TabIndex = 25;
            this.labelrazaosocial.Text = "Razão Social:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(97, 110);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(480, 20);
            this.txtemail.TabIndex = 27;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(97, 136);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(121, 20);
            this.txttelefone.TabIndex = 28;
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(97, 162);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(121, 20);
            this.txtcelular.TabIndex = 29;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(97, 188);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(136, 20);
            this.txtcpf.TabIndex = 30;
            // 
            // txtcnpj
            // 
            this.txtcnpj.Location = new System.Drawing.Point(97, 214);
            this.txtcnpj.Name = "txtcnpj";
            this.txtcnpj.Size = new System.Drawing.Size(169, 20);
            this.txtcnpj.TabIndex = 31;
            // 
            // txtrazaosocial
            // 
            this.txtrazaosocial.Location = new System.Drawing.Point(97, 241);
            this.txtrazaosocial.Name = "txtrazaosocial";
            this.txtrazaosocial.Size = new System.Drawing.Size(480, 20);
            this.txtrazaosocial.TabIndex = 32;
            // 
            // labelendereco
            // 
            this.labelendereco.AutoSize = true;
            this.labelendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelendereco.Location = new System.Drawing.Point(13, 288);
            this.labelendereco.Name = "labelendereco";
            this.labelendereco.Size = new System.Drawing.Size(86, 20);
            this.labelendereco.TabIndex = 33;
            this.labelendereco.Text = "Endereço";
            // 
            // labelrua
            // 
            this.labelrua.AutoSize = true;
            this.labelrua.Location = new System.Drawing.Point(15, 328);
            this.labelrua.Name = "labelrua";
            this.labelrua.Size = new System.Drawing.Size(30, 13);
            this.labelrua.TabIndex = 34;
            this.labelrua.Text = "Rua:";
            // 
            // txtrua
            // 
            this.txtrua.Location = new System.Drawing.Point(66, 321);
            this.txtrua.Name = "txtrua";
            this.txtrua.Size = new System.Drawing.Size(480, 20);
            this.txtrua.TabIndex = 35;
            // 
            // labelnumero
            // 
            this.labelnumero.AutoSize = true;
            this.labelnumero.Location = new System.Drawing.Point(565, 328);
            this.labelnumero.Name = "labelnumero";
            this.labelnumero.Size = new System.Drawing.Size(47, 13);
            this.labelnumero.TabIndex = 36;
            this.labelnumero.Text = "Número:";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(618, 321);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(114, 20);
            this.txtnumero.TabIndex = 37;
            // 
            // labelbairro
            // 
            this.labelbairro.AutoSize = true;
            this.labelbairro.Location = new System.Drawing.Point(14, 354);
            this.labelbairro.Name = "labelbairro";
            this.labelbairro.Size = new System.Drawing.Size(37, 13);
            this.labelbairro.TabIndex = 38;
            this.labelbairro.Text = "Bairro:";
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(66, 347);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(480, 20);
            this.txtbairro.TabIndex = 39;
            // 
            // labelcidade
            // 
            this.labelcidade.AutoSize = true;
            this.labelcidade.Location = new System.Drawing.Point(15, 384);
            this.labelcidade.Name = "labelcidade";
            this.labelcidade.Size = new System.Drawing.Size(43, 13);
            this.labelcidade.TabIndex = 40;
            this.labelcidade.Text = "Cidade:";
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(66, 377);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(219, 20);
            this.txtcidade.TabIndex = 41;
            // 
            // labelcep
            // 
            this.labelcep.AutoSize = true;
            this.labelcep.Location = new System.Drawing.Point(321, 380);
            this.labelcep.Name = "labelcep";
            this.labelcep.Size = new System.Drawing.Size(31, 13);
            this.labelcep.TabIndex = 42;
            this.labelcep.Text = "CEP:";
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(367, 377);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(114, 20);
            this.txtcep.TabIndex = 43;
            // 
            // labelcadastro
            // 
            this.labelcadastro.AutoSize = true;
            this.labelcadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcadastro.Location = new System.Drawing.Point(9, 54);
            this.labelcadastro.Name = "labelcadastro";
            this.labelcadastro.Size = new System.Drawing.Size(82, 20);
            this.labelcadastro.TabIndex = 44;
            this.labelcadastro.Text = "Cadastro";
            // 
            // btnconectar
            // 
            this.btnconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconectar.Location = new System.Drawing.Point(612, 84);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(120, 35);
            this.btnconectar.TabIndex = 45;
            this.btnconectar.Text = "Conectar";
            this.btnconectar.UseVisualStyleBackColor = true;
            this.btnconectar.Click += new System.EventHandler(this.btnconectar_Click);
            // 
            // btncriartabela
            // 
            this.btncriartabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncriartabela.Location = new System.Drawing.Point(754, 84);
            this.btncriartabela.Name = "btncriartabela";
            this.btncriartabela.Size = new System.Drawing.Size(120, 35);
            this.btncriartabela.TabIndex = 46;
            this.btncriartabela.Text = "Criar tabela";
            this.btncriartabela.UseVisualStyleBackColor = true;
            this.btncriartabela.Click += new System.EventHandler(this.btncriartabela_Click);
            // 
            // btninserir
            // 
            this.btninserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserir.Location = new System.Drawing.Point(612, 136);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(120, 35);
            this.btninserir.TabIndex = 47;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // btnprocurar
            // 
            this.btnprocurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprocurar.Location = new System.Drawing.Point(754, 136);
            this.btnprocurar.Name = "btnprocurar";
            this.btnprocurar.Size = new System.Drawing.Size(120, 35);
            this.btnprocurar.TabIndex = 48;
            this.btnprocurar.Text = "Procurar";
            this.btnprocurar.UseVisualStyleBackColor = true;
            this.btnprocurar.Click += new System.EventHandler(this.btnprocurar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(612, 188);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(120, 35);
            this.btnexcluir.TabIndex = 49;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(754, 188);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(120, 35);
            this.btneditar.TabIndex = 50;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txtclassificacao
            // 
            this.txtclassificacao.AutoCompleteCustomSource.AddRange(new string[] {
            "ATIVO",
            "INATIVO",
            "PREFERENCIAL"});
            this.txtclassificacao.DisplayMember = "ATIVO";
            this.txtclassificacao.FormattingEnabled = true;
            this.txtclassificacao.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO",
            "PREFERENCIAL"});
            this.txtclassificacao.Location = new System.Drawing.Point(456, 161);
            this.txtclassificacao.Name = "txtclassificacao";
            this.txtclassificacao.Size = new System.Drawing.Size(121, 21);
            this.txtclassificacao.TabIndex = 51;
            this.txtclassificacao.Text = "Classificação";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "E-MAIL";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "TELEFONE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "CELULAR";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "CNPJ";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "RAZÃO SOCIAL";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "CLASSIFI- CAÇÃO";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // rua
            // 
            this.rua.HeaderText = "RUA";
            this.rua.Name = "rua";
            // 
            // numero
            // 
            this.numero.HeaderText = "NUMERO";
            this.numero.Name = "numero";
            // 
            // bairro
            // 
            this.bairro.HeaderText = "BAIRRO";
            this.bairro.Name = "bairro";
            // 
            // cidade
            // 
            this.cidade.HeaderText = "CIDADE";
            this.cidade.Name = "cidade";
            // 
            // estado
            // 
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            // 
            // cep
            // 
            this.cep.HeaderText = "CEP";
            this.cep.Name = "cep";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Estado:";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(552, 377);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(219, 20);
            this.txtestado.TabIndex = 53;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 646);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtclassificacao);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnprocurar);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.btncriartabela);
            this.Controls.Add(this.btnconectar);
            this.Controls.Add(this.labelcadastro);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.labelcep);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.labelcidade);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.labelbairro);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.labelnumero);
            this.Controls.Add(this.txtrua);
            this.Controls.Add(this.labelrua);
            this.Controls.Add(this.labelendereco);
            this.Controls.Add(this.txtrazaosocial);
            this.Controls.Add(this.txtcnpj);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.labelrazaosocial);
            this.Controls.Add(this.labelcnpj);
            this.Controls.Add(this.labelcpf);
            this.Controls.Add(this.labelcelular);
            this.Controls.Add(this.labeltelefone);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.labelnome);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.labelResultado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labeltelefone;
        private System.Windows.Forms.Label labelcelular;
        private System.Windows.Forms.Label labelcpf;
        private System.Windows.Forms.Label labelcnpj;
        private System.Windows.Forms.Label labelrazaosocial;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.TextBox txtcnpj;
        private System.Windows.Forms.TextBox txtrazaosocial;
        private System.Windows.Forms.Label labelendereco;
        private System.Windows.Forms.Label labelrua;
        private System.Windows.Forms.TextBox txtrua;
        private System.Windows.Forms.Label labelnumero;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label labelbairro;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label labelcidade;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label labelcep;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.Label labelcadastro;
        private System.Windows.Forms.Button btnconectar;
        private System.Windows.Forms.Button btncriartabela;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Button btnprocurar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.ComboBox txtclassificacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtestado;
    }
}

