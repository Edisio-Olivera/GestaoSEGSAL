
namespace GestaoSEGSAL.View
{
    partial class frm_addServiceBussinessProposal
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
            this.lbl_tituloListView = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lvw_listaServicoPropostaComercial = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_tipoServico = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_qtd = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_servico = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_valorTotal = new System.Windows.Forms.TextBox();
            this.txt_valorUnitario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_valorUnitarioErrado = new System.Windows.Forms.TextBox();
            this.txt_valorTotalErrado = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_tituloListView
            // 
            this.lbl_tituloListView.AutoSize = true;
            this.lbl_tituloListView.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloListView.Location = new System.Drawing.Point(28, 371);
            this.lbl_tituloListView.Name = "lbl_tituloListView";
            this.lbl_tituloListView.Size = new System.Drawing.Size(98, 15);
            this.lbl_tituloListView.TabIndex = 9;
            this.lbl_tituloListView.Text = "Lista de Serviços";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_novo);
            this.panel2.Controls.Add(this.btn_editar);
            this.panel2.Controls.Add(this.btn_cancelar);
            this.panel2.Controls.Add(this.btn_salvar);
            this.panel2.Controls.Add(this.btn_excluir);
            this.panel2.Controls.Add(this.btn_sair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1362, 70);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Propostas Comerciais";
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.Navy;
            this.btn_novo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Image = global::GestaoSEGSAL.Properties.Resources.btn_novo;
            this.btn_novo.Location = new System.Drawing.Point(832, 3);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(66, 61);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Navy;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Image = global::GestaoSEGSAL.Properties.Resources.btn_editar;
            this.btn_editar.Location = new System.Drawing.Point(904, 4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(66, 61);
            this.btn_editar.TabIndex = 0;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Image = global::GestaoSEGSAL.Properties.Resources.btn_cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(976, 4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(66, 61);
            this.btn_cancelar.TabIndex = 0;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Navy;
            this.btn_salvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Image = global::GestaoSEGSAL.Properties.Resources.btn_salvar;
            this.btn_salvar.Location = new System.Drawing.Point(1120, 4);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(66, 61);
            this.btn_salvar.TabIndex = 0;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Navy;
            this.btn_excluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Image = global::GestaoSEGSAL.Properties.Resources.btn_deletar;
            this.btn_excluir.Location = new System.Drawing.Point(1048, 4);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(66, 61);
            this.btn_excluir.TabIndex = 0;
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Red;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Image = global::GestaoSEGSAL.Properties.Resources.btn_sair;
            this.btn_sair.Location = new System.Drawing.Point(1261, 4);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(66, 61);
            this.btn_sair.TabIndex = 0;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lvw_listaServicoPropostaComercial
            // 
            this.lvw_listaServicoPropostaComercial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lvw_listaServicoPropostaComercial.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaServicoPropostaComercial.FullRowSelect = true;
            this.lvw_listaServicoPropostaComercial.GridLines = true;
            this.lvw_listaServicoPropostaComercial.HideSelection = false;
            this.lvw_listaServicoPropostaComercial.Location = new System.Drawing.Point(31, 389);
            this.lvw_listaServicoPropostaComercial.Name = "lvw_listaServicoPropostaComercial";
            this.lvw_listaServicoPropostaComercial.Size = new System.Drawing.Size(1298, 288);
            this.lvw_listaServicoPropostaComercial.TabIndex = 8;
            this.lvw_listaServicoPropostaComercial.UseCompatibleStateImageBehavior = false;
            this.lvw_listaServicoPropostaComercial.View = System.Windows.Forms.View.Details;
            this.lvw_listaServicoPropostaComercial.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvw_listaServicoPropostaComercial_ItemSelectionChanged);
            this.lvw_listaServicoPropostaComercial.SelectedIndexChanged += new System.EventHandler(this.lvw_listaServicoPropostaComercial_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 30);
            this.panel1.TabIndex = 6;
            // 
            // txt_titulo
            // 
            this.txt_titulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_titulo.Enabled = false;
            this.txt_titulo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulo.Location = new System.Drawing.Point(127, 43);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(740, 23);
            this.txt_titulo.TabIndex = 13;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(25, 43);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(96, 23);
            this.txt_codigo.TabIndex = 14;
            this.txt_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // txt_valor
            // 
            this.txt_valor.Enabled = false;
            this.txt_valor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(872, 43);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(125, 23);
            this.txt_valor.TabIndex = 15;
            this.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Código";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(869, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "Valor (R$)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.txt_titulo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_valor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 94);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Proposta Comercial";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_tipoServico);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_qtd);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.txt_servico);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_valorTotalErrado);
            this.groupBox2.Controls.Add(this.txt_valorTotal);
            this.groupBox2.Controls.Add(this.txt_valorUnitarioErrado);
            this.groupBox2.Controls.Add(this.txt_valorUnitario);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1023, 132);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Serviço";
            // 
            // cmb_tipoServico
            // 
            this.cmb_tipoServico.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoServico.FormattingEnabled = true;
            this.cmb_tipoServico.Location = new System.Drawing.Point(127, 43);
            this.cmb_tipoServico.Name = "cmb_tipoServico";
            this.cmb_tipoServico.Size = new System.Drawing.Size(299, 23);
            this.cmb_tipoServico.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(124, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tipo de Serviço";
            // 
            // txt_qtd
            // 
            this.txt_qtd.Enabled = false;
            this.txt_qtd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qtd.Location = new System.Drawing.Point(432, 43);
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(96, 23);
            this.txt_qtd.TabIndex = 14;
            this.txt_qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_qtd.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(25, 43);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(96, 23);
            this.txt_id.TabIndex = 14;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // txt_servico
            // 
            this.txt_servico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_servico.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_servico.Location = new System.Drawing.Point(25, 89);
            this.txt_servico.Name = "txt_servico";
            this.txt_servico.Size = new System.Drawing.Size(710, 23);
            this.txt_servico.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(869, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Valor Total(R$)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(429, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Qtd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(738, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valor Unitário(R$)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Id";
            // 
            // txt_valorTotal
            // 
            this.txt_valorTotal.Enabled = false;
            this.txt_valorTotal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorTotal.Location = new System.Drawing.Point(872, 89);
            this.txt_valorTotal.Name = "txt_valorTotal";
            this.txt_valorTotal.Size = new System.Drawing.Size(125, 23);
            this.txt_valorTotal.TabIndex = 15;
            this.txt_valorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_valorUnitario
            // 
            this.txt_valorUnitario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorUnitario.Location = new System.Drawing.Point(741, 89);
            this.txt_valorUnitario.Name = "txt_valorUnitario";
            this.txt_valorUnitario.Size = new System.Drawing.Size(125, 23);
            this.txt_valorUnitario.TabIndex = 15;
            this.txt_valorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_valorUnitario.TextChanged += new System.EventHandler(this.txt_valorUnitario_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Título";
            // 
            // txt_valorUnitarioErrado
            // 
            this.txt_valorUnitarioErrado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorUnitarioErrado.Location = new System.Drawing.Point(742, 43);
            this.txt_valorUnitarioErrado.Name = "txt_valorUnitarioErrado";
            this.txt_valorUnitarioErrado.Size = new System.Drawing.Size(125, 23);
            this.txt_valorUnitarioErrado.TabIndex = 15;
            this.txt_valorUnitarioErrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_valorUnitarioErrado.TextChanged += new System.EventHandler(this.txt_valorUnitario_TextChanged);
            // 
            // txt_valorTotalErrado
            // 
            this.txt_valorTotalErrado.Enabled = false;
            this.txt_valorTotalErrado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorTotalErrado.Location = new System.Drawing.Point(872, 43);
            this.txt_valorTotalErrado.Name = "txt_valorTotalErrado";
            this.txt_valorTotalErrado.Size = new System.Drawing.Size(125, 23);
            this.txt_valorTotalErrado.TabIndex = 15;
            this.txt_valorTotalErrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frm_addServiceBussinessProposal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 617);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_tituloListView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lvw_listaServicoPropostaComercial);
            this.Controls.Add(this.panel1);
            this.Name = "frm_addServiceBussinessProposal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_addServiceBussinessProposal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_addServiceBussinessProposal_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_tituloListView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.ListView lvw_listaServicoPropostaComercial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_servico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_valorUnitario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_tipoServico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_valorTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox txt_qtd;
        private System.Windows.Forms.TextBox txt_valorTotalErrado;
        private System.Windows.Forms.TextBox txt_valorUnitarioErrado;
    }
}