
namespace GestaoSEGSAL
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_contagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 204);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(500, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(12, 182);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(21, 19);
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "...";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoSEGSAL.Properties.Resources.telaSplash;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 163);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_contagem
            // 
            this.lbl_contagem.AutoSize = true;
            this.lbl_contagem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contagem.Location = new System.Drawing.Point(12, 230);
            this.lbl_contagem.Name = "lbl_contagem";
            this.lbl_contagem.Size = new System.Drawing.Size(21, 19);
            this.lbl_contagem.TabIndex = 1;
            this.lbl_contagem.Text = "...";
            this.lbl_contagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 259);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_contagem);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_contagem;
    }
}