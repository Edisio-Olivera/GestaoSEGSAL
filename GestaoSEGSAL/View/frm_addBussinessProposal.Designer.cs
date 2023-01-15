
namespace GestaoSEGSAL.View
{
    partial class frm_addBussinessProposal
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.dtp_dataProposta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_base = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_observacao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_condPgto = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_formaPgto = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_cancelar);
            this.panel2.Controls.Add(this.btn_atualizar);
            this.panel2.Controls.Add(this.btn_salvar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 70);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proposta Comercial";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Image = global::GestaoSEGSAL.Properties.Resources.btn_cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(1190, 4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(66, 61);
            this.btn_cancelar.TabIndex = 0;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.Navy;
            this.btn_atualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_atualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Image = global::GestaoSEGSAL.Properties.Resources.btn_atualizar;
            this.btn_atualizar.Location = new System.Drawing.Point(1046, 3);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(66, 61);
            this.btn_atualizar.TabIndex = 0;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Navy;
            this.btn_salvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Image = global::GestaoSEGSAL.Properties.Resources.btn_salvar;
            this.btn_salvar.Location = new System.Drawing.Point(1118, 3);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(66, 61);
            this.btn_salvar.TabIndex = 0;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 30);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id";
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(38, 180);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(299, 23);
            this.cmb_cliente.TabIndex = 5;
            this.cmb_cliente.SelectedIndexChanged += new System.EventHandler(this.cmb_cliente_SelectedIndexChanged);
            this.cmb_cliente.SelectionChangeCommitted += new System.EventHandler(this.cmb_cliente_SelectionChangeCommitted);
            this.cmb_cliente.ValueMemberChanged += new System.EventHandler(this.cmb_cliente_ValueMemberChanged);
            this.cmb_cliente.SelectedValueChanged += new System.EventHandler(this.cmb_cliente_SelectedValueChanged);
            this.cmb_cliente.Click += new System.EventHandler(this.cmb_cliente_Click);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(38, 136);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(77, 23);
            this.txt_id.TabIndex = 6;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(121, 136);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(96, 23);
            this.txt_codigo.TabIndex = 6;
            this.txt_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_dataProposta
            // 
            this.dtp_dataProposta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dataProposta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataProposta.Location = new System.Drawing.Point(223, 136);
            this.dtp_dataProposta.Name = "dtp_dataProposta";
            this.dtp_dataProposta.Size = new System.Drawing.Size(114, 23);
            this.dtp_dataProposta.TabIndex = 7;
            this.dtp_dataProposta.ValueChanged += new System.EventHandler(this.dtp_dataProposta_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Título";
            // 
            // txt_titulo
            // 
            this.txt_titulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_titulo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulo.Location = new System.Drawing.Point(38, 226);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(604, 23);
            this.txt_titulo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(340, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Base";
            // 
            // cmb_base
            // 
            this.cmb_base.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_base.FormattingEnabled = true;
            this.cmb_base.Location = new System.Drawing.Point(343, 180);
            this.cmb_base.Name = "cmb_base";
            this.cmb_base.Size = new System.Drawing.Size(299, 23);
            this.cmb_base.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Descrição";
            // 
            // txt_descricao
            // 
            this.txt_descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_descricao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descricao.Location = new System.Drawing.Point(38, 272);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(604, 120);
            this.txt_descricao.TabIndex = 6;
            this.txt_descricao.TextChanged += new System.EventHandler(this.txt_descricao_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Observação";
            // 
            // txt_observacao
            // 
            this.txt_observacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_observacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_observacao.Location = new System.Drawing.Point(38, 413);
            this.txt_observacao.Multiline = true;
            this.txt_observacao.Name = "txt_observacao";
            this.txt_observacao.Size = new System.Drawing.Size(604, 120);
            this.txt_observacao.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 536);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Condição de Pgto";
            // 
            // cmb_condPgto
            // 
            this.cmb_condPgto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_condPgto.FormattingEnabled = true;
            this.cmb_condPgto.Location = new System.Drawing.Point(38, 554);
            this.cmb_condPgto.Name = "cmb_condPgto";
            this.cmb_condPgto.Size = new System.Drawing.Size(179, 23);
            this.cmb_condPgto.TabIndex = 5;
            this.cmb_condPgto.SelectedValueChanged += new System.EventHandler(this.cmb_condPgto_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(220, 536);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Forma de Pgto";
            // 
            // cmb_formaPgto
            // 
            this.cmb_formaPgto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_formaPgto.FormattingEnabled = true;
            this.cmb_formaPgto.Location = new System.Drawing.Point(223, 554);
            this.cmb_formaPgto.Name = "cmb_formaPgto";
            this.cmb_formaPgto.Size = new System.Drawing.Size(288, 23);
            this.cmb_formaPgto.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(514, 536);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Valor (R$)";
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(517, 554);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(125, 23);
            this.txt_valor.TabIndex = 6;
            this.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frm_addBussinessProposal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 630);
            this.Controls.Add(this.dtp_dataProposta);
            this.Controls.Add(this.txt_observacao);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_formaPgto);
            this.Controls.Add(this.cmb_base);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_condPgto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_addBussinessProposal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_addBussinessProposal_Load);
            this.Shown += new System.EventHandler(this.frm_addBussinessProposal_Shown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_cliente;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.DateTimePicker dtp_dataProposta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_base;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_observacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_condPgto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_formaPgto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Button btn_atualizar;
    }
}