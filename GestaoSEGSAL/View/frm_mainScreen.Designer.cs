
namespace GestaoSEGSAL.View
{
    partial class frm_mainScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recursosHumanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propostasComerciaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasFiscaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chamadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordensDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 80);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrativoToolStripMenuItem,
            this.recursosHumanosToolStripMenuItem,
            this.financeirosToolStripMenuItem,
            this.operacionalToolStripMenuItem,
            this.utilitáriosToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administrativoToolStripMenuItem
            // 
            this.administrativoToolStripMenuItem.Name = "administrativoToolStripMenuItem";
            this.administrativoToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.administrativoToolStripMenuItem.Text = "Administrativo";
            // 
            // recursosHumanosToolStripMenuItem
            // 
            this.recursosHumanosToolStripMenuItem.Name = "recursosHumanosToolStripMenuItem";
            this.recursosHumanosToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.recursosHumanosToolStripMenuItem.Text = "Recursos Humanos";
            // 
            // financeirosToolStripMenuItem
            // 
            this.financeirosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propostasComerciaisToolStripMenuItem,
            this.notasFiscaisToolStripMenuItem,
            this.contasAPagarToolStripMenuItem,
            this.contasAReceberToolStripMenuItem});
            this.financeirosToolStripMenuItem.Name = "financeirosToolStripMenuItem";
            this.financeirosToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.financeirosToolStripMenuItem.Text = "Financeiros";
            // 
            // propostasComerciaisToolStripMenuItem
            // 
            this.propostasComerciaisToolStripMenuItem.Name = "propostasComerciaisToolStripMenuItem";
            this.propostasComerciaisToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.propostasComerciaisToolStripMenuItem.Text = "Propostas Comerciais";
            this.propostasComerciaisToolStripMenuItem.Click += new System.EventHandler(this.propostasComerciaisToolStripMenuItem_Click);
            // 
            // notasFiscaisToolStripMenuItem
            // 
            this.notasFiscaisToolStripMenuItem.Name = "notasFiscaisToolStripMenuItem";
            this.notasFiscaisToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.notasFiscaisToolStripMenuItem.Text = "Notas Fiscais";
            this.notasFiscaisToolStripMenuItem.Click += new System.EventHandler(this.notasFiscaisToolStripMenuItem_Click);
            // 
            // contasAPagarToolStripMenuItem
            // 
            this.contasAPagarToolStripMenuItem.Name = "contasAPagarToolStripMenuItem";
            this.contasAPagarToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.contasAPagarToolStripMenuItem.Text = "Contas a Pagar";
            this.contasAPagarToolStripMenuItem.Click += new System.EventHandler(this.contasAPagarToolStripMenuItem_Click);
            // 
            // contasAReceberToolStripMenuItem
            // 
            this.contasAReceberToolStripMenuItem.Name = "contasAReceberToolStripMenuItem";
            this.contasAReceberToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.contasAReceberToolStripMenuItem.Text = "Contas a Receber";
            this.contasAReceberToolStripMenuItem.Click += new System.EventHandler(this.contasAReceberToolStripMenuItem_Click);
            // 
            // operacionalToolStripMenuItem
            // 
            this.operacionalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chamadosToolStripMenuItem,
            this.ordensDeServiçoToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.operacionalToolStripMenuItem.Name = "operacionalToolStripMenuItem";
            this.operacionalToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.operacionalToolStripMenuItem.Text = "Operacional";
            // 
            // chamadosToolStripMenuItem
            // 
            this.chamadosToolStripMenuItem.Name = "chamadosToolStripMenuItem";
            this.chamadosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.chamadosToolStripMenuItem.Text = "Chamados";
            this.chamadosToolStripMenuItem.Click += new System.EventHandler(this.chamadosToolStripMenuItem_Click);
            // 
            // ordensDeServiçoToolStripMenuItem
            // 
            this.ordensDeServiçoToolStripMenuItem.Name = "ordensDeServiçoToolStripMenuItem";
            this.ordensDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ordensDeServiçoToolStripMenuItem.Text = "Ordens de Serviço";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // utilitáriosToolStripMenuItem
            // 
            this.utilitáriosToolStripMenuItem.Name = "utilitáriosToolStripMenuItem";
            this.utilitáriosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.utilitáriosToolStripMenuItem.Text = "Utilitários";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GestaoSEGSAL.Properties.Resources.destaquecftv__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1234, 514);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frm_mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 618);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_mainScreen";
            this.Text = "frm_mainScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administrativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recursosHumanosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propostasComerciaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasFiscaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chamadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordensDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
    }
}