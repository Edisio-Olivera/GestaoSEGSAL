
namespace GestaoSEGSAL.View
{
    partial class frm_addInvoice
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
            this.dtp_dataEmissao = new System.Windows.Forms.DateTimePicker();
            this.txt_competencia = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_base = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_tipoNotaFiscal = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_periodo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_codigoVerificacao = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_numeroPedido = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_dataPrevisao = new System.Windows.Forms.DateTimePicker();
            this.txt_servico = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_dataEmissao
            // 
            this.dtp_dataEmissao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataEmissao.Location = new System.Drawing.Point(223, 145);
            this.dtp_dataEmissao.Name = "dtp_dataEmissao";
            this.dtp_dataEmissao.Size = new System.Drawing.Size(114, 23);
            this.dtp_dataEmissao.TabIndex = 31;
            // 
            // txt_competencia
            // 
            this.txt_competencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_competencia.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_competencia.Location = new System.Drawing.Point(343, 191);
            this.txt_competencia.Name = "txt_competencia";
            this.txt_competencia.Size = new System.Drawing.Size(106, 23);
            this.txt_competencia.TabIndex = 28;
            // 
            // txt_numero
            // 
            this.txt_numero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(121, 145);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(96, 23);
            this.txt_numero.TabIndex = 27;
            this.txt_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(41, 391);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(125, 23);
            this.txt_valor.TabIndex = 26;
            this.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(38, 145);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(77, 23);
            this.txt_id.TabIndex = 25;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Competência";
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
            this.panel2.Size = new System.Drawing.Size(1286, 70);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nota Fiscal";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data de Emissão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Número";
            // 
            // cmb_base
            // 
            this.cmb_base.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_base.FormattingEnabled = true;
            this.cmb_base.Location = new System.Drawing.Point(343, 239);
            this.cmb_base.Name = "cmb_base";
            this.cmb_base.Size = new System.Drawing.Size(299, 23);
            this.cmb_base.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(340, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Base";
            // 
            // cmb_tipoNotaFiscal
            // 
            this.cmb_tipoNotaFiscal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoNotaFiscal.FormattingEnabled = true;
            this.cmb_tipoNotaFiscal.Location = new System.Drawing.Point(38, 191);
            this.cmb_tipoNotaFiscal.Name = "cmb_tipoNotaFiscal";
            this.cmb_tipoNotaFiscal.Size = new System.Drawing.Size(299, 23);
            this.cmb_tipoNotaFiscal.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 373);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Valor (R$)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de Nota Fiscal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Id";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 30);
            this.panel1.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(442, 373);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 15);
            this.label13.TabIndex = 16;
            this.label13.Text = "Período";
            // 
            // txt_periodo
            // 
            this.txt_periodo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_periodo.Location = new System.Drawing.Point(445, 391);
            this.txt_periodo.Name = "txt_periodo";
            this.txt_periodo.Size = new System.Drawing.Size(77, 23);
            this.txt_periodo.TabIndex = 25;
            this.txt_periodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(452, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 15);
            this.label14.TabIndex = 20;
            this.label14.Text = "Código de Verificação";
            // 
            // txt_codigoVerificacao
            // 
            this.txt_codigoVerificacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_codigoVerificacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoVerificacao.Location = new System.Drawing.Point(455, 191);
            this.txt_codigoVerificacao.Name = "txt_codigoVerificacao";
            this.txt_codigoVerificacao.Size = new System.Drawing.Size(187, 23);
            this.txt_codigoVerificacao.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(645, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 15);
            this.label15.TabIndex = 20;
            this.label15.Text = "Número do Pedido";
            // 
            // txt_numeroPedido
            // 
            this.txt_numeroPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_numeroPedido.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numeroPedido.Location = new System.Drawing.Point(648, 191);
            this.txt_numeroPedido.Name = "txt_numeroPedido";
            this.txt_numeroPedido.Size = new System.Drawing.Size(151, 23);
            this.txt_numeroPedido.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(35, 221);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 15);
            this.label16.TabIndex = 12;
            this.label16.Text = "Cliente";
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(38, 239);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(299, 23);
            this.cmb_cliente.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Serviço";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(525, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Data de Previsão";
            // 
            // dtp_dataPrevisao
            // 
            this.dtp_dataPrevisao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dataPrevisao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataPrevisao.Location = new System.Drawing.Point(528, 391);
            this.dtp_dataPrevisao.Name = "dtp_dataPrevisao";
            this.dtp_dataPrevisao.Size = new System.Drawing.Size(114, 23);
            this.dtp_dataPrevisao.TabIndex = 31;
            // 
            // txt_servico
            // 
            this.txt_servico.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_servico.Location = new System.Drawing.Point(38, 288);
            this.txt_servico.Multiline = true;
            this.txt_servico.Name = "txt_servico";
            this.txt_servico.Size = new System.Drawing.Size(604, 80);
            this.txt_servico.TabIndex = 26;
            this.txt_servico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frm_addInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1286, 594);
            this.Controls.Add(this.dtp_dataPrevisao);
            this.Controls.Add(this.dtp_dataEmissao);
            this.Controls.Add(this.txt_numeroPedido);
            this.Controls.Add(this.txt_codigoVerificacao);
            this.Controls.Add(this.txt_competencia);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_servico);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_periodo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmb_base);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_tipoNotaFiscal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_addInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_addInvoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_dataEmissao;
        private System.Windows.Forms.TextBox txt_competencia;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_base;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_tipoNotaFiscal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_periodo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_codigoVerificacao;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_numeroPedido;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmb_cliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_dataPrevisao;
        private System.Windows.Forms.TextBox txt_servico;
    }
}