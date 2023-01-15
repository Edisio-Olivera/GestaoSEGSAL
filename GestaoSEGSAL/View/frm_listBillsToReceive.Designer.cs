
namespace GestaoSEGSAL.View
{
    partial class frm_listBillsToReceive
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_servico = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_tituloListView = new System.Windows.Forms.Label();
            this.lvw_listaPropostaComercial = new System.Windows.Forms.ListView();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_novo);
            this.panel2.Controls.Add(this.btn_editar);
            this.panel2.Controls.Add(this.btn_cancelar);
            this.panel2.Controls.Add(this.btn_imprimir);
            this.panel2.Controls.Add(this.btn_servico);
            this.panel2.Controls.Add(this.btn_excluir);
            this.panel2.Controls.Add(this.btn_sair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1362, 70);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contas a Receber";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 30);
            this.panel1.TabIndex = 2;
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
            this.btn_editar.Location = new System.Drawing.Point(904, 3);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(66, 61);
            this.btn_editar.TabIndex = 0;
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Image = global::GestaoSEGSAL.Properties.Resources.btn_cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(976, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(66, 61);
            this.btn_cancelar.TabIndex = 0;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.Navy;
            this.btn_imprimir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Image = global::GestaoSEGSAL.Properties.Resources.btn_imprimir;
            this.btn_imprimir.Location = new System.Drawing.Point(1191, 3);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(66, 61);
            this.btn_imprimir.TabIndex = 0;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            // 
            // btn_servico
            // 
            this.btn_servico.BackColor = System.Drawing.Color.Navy;
            this.btn_servico.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_servico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_servico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_servico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_servico.Image = global::GestaoSEGSAL.Properties.Resources.btn_servico;
            this.btn_servico.Location = new System.Drawing.Point(1120, 3);
            this.btn_servico.Name = "btn_servico";
            this.btn_servico.Size = new System.Drawing.Size(66, 61);
            this.btn_servico.TabIndex = 0;
            this.btn_servico.UseVisualStyleBackColor = false;
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Navy;
            this.btn_excluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Image = global::GestaoSEGSAL.Properties.Resources.btn_deletar;
            this.btn_excluir.Location = new System.Drawing.Point(1048, 3);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(66, 61);
            this.btn_excluir.TabIndex = 0;
            this.btn_excluir.UseVisualStyleBackColor = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Red;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Image = global::GestaoSEGSAL.Properties.Resources.btn_sair;
            this.btn_sair.Location = new System.Drawing.Point(1261, 3);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(66, 61);
            this.btn_sair.TabIndex = 0;
            this.btn_sair.UseVisualStyleBackColor = false;
            // 
            // lbl_tituloListView
            // 
            this.lbl_tituloListView.AutoSize = true;
            this.lbl_tituloListView.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloListView.Location = new System.Drawing.Point(26, 246);
            this.lbl_tituloListView.Name = "lbl_tituloListView";
            this.lbl_tituloListView.Size = new System.Drawing.Size(146, 15);
            this.lbl_tituloListView.TabIndex = 7;
            this.lbl_tituloListView.Text = "Lista de Contas a Receber";
            // 
            // lvw_listaPropostaComercial
            // 
            this.lvw_listaPropostaComercial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lvw_listaPropostaComercial.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaPropostaComercial.FullRowSelect = true;
            this.lvw_listaPropostaComercial.GridLines = true;
            this.lvw_listaPropostaComercial.HideSelection = false;
            this.lvw_listaPropostaComercial.Location = new System.Drawing.Point(29, 264);
            this.lvw_listaPropostaComercial.Name = "lvw_listaPropostaComercial";
            this.lvw_listaPropostaComercial.Size = new System.Drawing.Size(1298, 408);
            this.lvw_listaPropostaComercial.TabIndex = 6;
            this.lvw_listaPropostaComercial.UseCompatibleStateImageBehavior = false;
            this.lvw_listaPropostaComercial.View = System.Windows.Forms.View.Details;
            // 
            // frm_listBillsToReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 715);
            this.Controls.Add(this.lbl_tituloListView);
            this.Controls.Add(this.lvw_listaPropostaComercial);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_listBillsToReceive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_listBillsToReceive";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_servico;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_tituloListView;
        private System.Windows.Forms.ListView lvw_listaPropostaComercial;
    }
}