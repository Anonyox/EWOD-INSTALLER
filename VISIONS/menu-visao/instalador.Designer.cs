
namespace INSTALADOR_EWOD_SERVIDOR
{
    partial class instalador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(instalador));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblconex = new System.Windows.Forms.Label();
            this.btnAlterarBanco = new System.Windows.Forms.Button();
            this.btndeslogar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btncadastroProdutos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "STATUS DA CONEXÃO : ";
            // 
            // lblconex
            // 
            this.lblconex.AutoSize = true;
            this.lblconex.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconex.ForeColor = System.Drawing.Color.Red;
            this.lblconex.Location = new System.Drawing.Point(200, 366);
            this.lblconex.Name = "lblconex";
            this.lblconex.Size = new System.Drawing.Size(66, 16);
            this.lblconex.TabIndex = 25;
            this.lblconex.Text = "OFFLINE";
            // 
            // btnAlterarBanco
            // 
            this.btnAlterarBanco.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterarBanco.BackgroundImage = global::INSTALADOR_EWOD_SERVIDOR.Properties.Resources.icone_de_configuration_et_d_outils_violet;
            this.btnAlterarBanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlterarBanco.FlatAppearance.BorderSize = 0;
            this.btnAlterarBanco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAlterarBanco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAlterarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarBanco.ForeColor = System.Drawing.Color.Black;
            this.btnAlterarBanco.Location = new System.Drawing.Point(580, 342);
            this.btnAlterarBanco.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterarBanco.Name = "btnAlterarBanco";
            this.btnAlterarBanco.Size = new System.Drawing.Size(75, 40);
            this.btnAlterarBanco.TabIndex = 27;
            this.btnAlterarBanco.UseVisualStyleBackColor = false;
            // 
            // btndeslogar
            // 
            this.btndeslogar.BackColor = System.Drawing.Color.Transparent;
            this.btndeslogar.BackgroundImage = global::INSTALADOR_EWOD_SERVIDOR.Properties.Resources.proximo;
            this.btndeslogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndeslogar.FlatAppearance.BorderSize = 0;
            this.btndeslogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btndeslogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btndeslogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeslogar.ForeColor = System.Drawing.Color.Black;
            this.btndeslogar.Location = new System.Drawing.Point(663, 342);
            this.btndeslogar.Margin = new System.Windows.Forms.Padding(4);
            this.btndeslogar.Name = "btndeslogar";
            this.btndeslogar.Size = new System.Drawing.Size(75, 40);
            this.btndeslogar.TabIndex = 26;
            this.btndeslogar.UseVisualStyleBackColor = false;
            this.btndeslogar.Click += new System.EventHandler(this.btndeslogar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::INSTALADOR_EWOD_SERVIDOR.Properties.Resources.armazenamento_de_banco_de_dados;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(389, 89);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(353, 156);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // btncadastroProdutos
            // 
            this.btncadastroProdutos.BackColor = System.Drawing.Color.Transparent;
            this.btncadastroProdutos.BackgroundImage = global::INSTALADOR_EWOD_SERVIDOR.Properties.Resources.icone_de_configuration_violette;
            this.btncadastroProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncadastroProdutos.FlatAppearance.BorderSize = 0;
            this.btncadastroProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btncadastroProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btncadastroProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastroProdutos.ForeColor = System.Drawing.Color.Black;
            this.btncadastroProdutos.Location = new System.Drawing.Point(-9, 98);
            this.btncadastroProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.btncadastroProdutos.Name = "btncadastroProdutos";
            this.btncadastroProdutos.Size = new System.Drawing.Size(353, 156);
            this.btncadastroProdutos.TabIndex = 22;
            this.btncadastroProdutos.UseVisualStyleBackColor = false;
            this.btncadastroProdutos.Click += new System.EventHandler(this.btncadastroProdutos_Click);
            this.btncadastroProdutos.MouseEnter += new System.EventHandler(this.btncadastroProdutos_MouseEnter);
            this.btncadastroProdutos.MouseLeave += new System.EventHandler(this.btncadastroProdutos_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::INSTALADOR_EWOD_SERVIDOR.Properties.Resources.e577e48f509306309f2af02b45037aba;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 27);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(717, 0);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(25, 25);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 48;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(676, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 47;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "CONFIGURAÇÕES ESTAÇÃO  ";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(488, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "CONFIGURAÇÕES SERVIDOR ";
            this.label3.Visible = false;
            // 
            // instalador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(751, 390);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAlterarBanco);
            this.Controls.Add(this.btndeslogar);
            this.Controls.Add(this.lblconex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncadastroProdutos);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "instalador";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.instalador_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncadastroProdutos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblconex;
        private System.Windows.Forms.Button btndeslogar;
        private System.Windows.Forms.Button btnAlterarBanco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

