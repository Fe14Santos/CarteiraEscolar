
namespace AplicationCarteiraEstudantil
{
    partial class EMFFS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMFFS));
            this.pnView = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxTurma = new System.Windows.Forms.TextBox();
            this.tbxSerie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxSexo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxOrigem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDestino = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gpbArquivo = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbPercetual = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.rbArquivo = new System.Windows.Forms.RadioButton();
            this.rbFormulario = new System.Windows.Forms.RadioButton();
            this.Gerar = new System.Windows.Forms.Button();
            this.btnPathSource = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnView.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpbArquivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnView
            // 
            this.pnView.BackgroundImage = global::AplicationCarteiraEstudantil.Properties.Resources.Carteira2;
            this.pnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnView.Controls.Add(this.label8);
            this.pnView.Controls.Add(this.label7);
            this.pnView.Controls.Add(this.tbxTurma);
            this.pnView.Controls.Add(this.tbxSerie);
            this.pnView.Controls.Add(this.label6);
            this.pnView.Controls.Add(this.tbxSexo);
            this.pnView.Controls.Add(this.label5);
            this.pnView.Controls.Add(this.tbxCidade);
            this.pnView.Controls.Add(this.label4);
            this.pnView.Controls.Add(this.tbxNome);
            this.pnView.Location = new System.Drawing.Point(12, 7);
            this.pnView.Name = "pnView";
            this.pnView.Size = new System.Drawing.Size(377, 529);
            this.pnView.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(144, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 14);
            this.label8.TabIndex = 9;
            this.label8.Text = "Série";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(229, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "Turmas";
            // 
            // tbxTurma
            // 
            this.tbxTurma.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.tbxTurma.ForeColor = System.Drawing.Color.DarkRed;
            this.tbxTurma.Location = new System.Drawing.Point(222, 184);
            this.tbxTurma.Name = "tbxTurma";
            this.tbxTurma.Size = new System.Drawing.Size(61, 21);
            this.tbxTurma.TabIndex = 7;
            this.tbxTurma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxSerie
            // 
            this.tbxSerie.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.tbxSerie.ForeColor = System.Drawing.Color.DarkRed;
            this.tbxSerie.Location = new System.Drawing.Point(131, 184);
            this.tbxSerie.Name = "tbxSerie";
            this.tbxSerie.Size = new System.Drawing.Size(67, 21);
            this.tbxSerie.TabIndex = 6;
            this.tbxSerie.Text = " ";
            this.tbxSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(133, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sexo";
            // 
            // tbxSexo
            // 
            this.tbxSexo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbxSexo.ForeColor = System.Drawing.Color.DarkRed;
            this.tbxSexo.Location = new System.Drawing.Point(129, 139);
            this.tbxSexo.Name = "tbxSexo";
            this.tbxSexo.Size = new System.Drawing.Size(67, 20);
            this.tbxSexo.TabIndex = 4;
            this.tbxSexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(259, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 14);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cidade/UF";
            // 
            // tbxCidade
            // 
            this.tbxCidade.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.tbxCidade.ForeColor = System.Drawing.Color.DarkRed;
            this.tbxCidade.Location = new System.Drawing.Point(239, 139);
            this.tbxCidade.Name = "tbxCidade";
            this.tbxCidade.Size = new System.Drawing.Size(108, 21);
            this.tbxCidade.TabIndex = 2;
            this.tbxCidade.Text = "SERRITA/PE";
            this.tbxCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(132, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nome Completo";
            // 
            // tbxNome
            // 
            this.tbxNome.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbxNome.ForeColor = System.Drawing.Color.DarkRed;
            this.tbxNome.Location = new System.Drawing.Point(129, 94);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(240, 20);
            this.tbxNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Origem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 30.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(76, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 49);
            this.label2.TabIndex = 7;
            this.label2.Text = "Carteira Estudantil 2023";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(417, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 53);
            this.panel1.TabIndex = 8;
            // 
            // tbxOrigem
            // 
            this.tbxOrigem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxOrigem.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.tbxOrigem.Location = new System.Drawing.Point(75, 37);
            this.tbxOrigem.Name = "tbxOrigem";
            this.tbxOrigem.Size = new System.Drawing.Size(346, 23);
            this.tbxOrigem.TabIndex = 9;
            this.tbxOrigem.Text = "F:\\Laboratório Drawing_Graphics\\files";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Destino:";
            // 
            // tbxDestino
            // 
            this.tbxDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDestino.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.tbxDestino.Location = new System.Drawing.Point(75, 88);
            this.tbxDestino.Name = "tbxDestino";
            this.tbxDestino.Size = new System.Drawing.Size(346, 23);
            this.tbxDestino.TabIndex = 11;
            this.tbxDestino.Text = "F:\\Laboratório Drawing_Graphics\\files";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAbrir.Location = new System.Drawing.Point(427, 37);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(38, 23);
            this.btnAbrir.TabIndex = 12;
            this.btnAbrir.Text = "...";
            this.btnAbrir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSalvar.Location = new System.Drawing.Point(427, 88);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(38, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "...";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gpbArquivo
            // 
            this.gpbArquivo.Controls.Add(this.label1);
            this.gpbArquivo.Controls.Add(this.btnSalvar);
            this.gpbArquivo.Controls.Add(this.tbxOrigem);
            this.gpbArquivo.Controls.Add(this.tbxDestino);
            this.gpbArquivo.Controls.Add(this.btnAbrir);
            this.gpbArquivo.Controls.Add(this.label3);
            this.gpbArquivo.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.gpbArquivo.Location = new System.Drawing.Point(423, 105);
            this.gpbArquivo.Name = "gpbArquivo";
            this.gpbArquivo.Size = new System.Drawing.Size(476, 129);
            this.gpbArquivo.TabIndex = 14;
            this.gpbArquivo.TabStop = false;
            this.gpbArquivo.Text = "Navegador";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(419, 460);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Progresso:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(519, 457);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(340, 25);
            this.progressBar1.TabIndex = 16;
            // 
            // lbPercetual
            // 
            this.lbPercetual.AutoSize = true;
            this.lbPercetual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbPercetual.Location = new System.Drawing.Point(865, 459);
            this.lbPercetual.Name = "lbPercetual";
            this.lbPercetual.Size = new System.Drawing.Size(24, 20);
            this.lbPercetual.TabIndex = 17;
            this.lbPercetual.Text = "%";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(613, 259);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(89, 36);
            this.btnIniciar.TabIndex = 19;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("French Script MT", 25.25F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(606, 501);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(298, 38);
            this.label10.TabIndex = 20;
            this.label10.Text = "By Felipe Alves dos Santos";
            // 
            // rbArquivo
            // 
            this.rbArquivo.AutoSize = true;
            this.rbArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.rbArquivo.Location = new System.Drawing.Point(423, 75);
            this.rbArquivo.Name = "rbArquivo";
            this.rbArquivo.Size = new System.Drawing.Size(120, 24);
            this.rbArquivo.TabIndex = 21;
            this.rbArquivo.TabStop = true;
            this.rbArquivo.Text = "Do Arquivo";
            this.rbArquivo.UseVisualStyleBackColor = true;
            this.rbArquivo.CheckedChanged += new System.EventHandler(this.rbArquivo_CheckedChanged);
            // 
            // rbFormulario
            // 
            this.rbFormulario.AutoSize = true;
            this.rbFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.rbFormulario.Location = new System.Drawing.Point(423, 313);
            this.rbFormulario.Name = "rbFormulario";
            this.rbFormulario.Size = new System.Drawing.Size(147, 24);
            this.rbFormulario.TabIndex = 22;
            this.rbFormulario.TabStop = true;
            this.rbFormulario.Text = "Do Formulário";
            this.rbFormulario.UseVisualStyleBackColor = true;
            this.rbFormulario.CheckedChanged += new System.EventHandler(this.rbFormulario_CheckedChanged);
            // 
            // Gerar
            // 
            this.Gerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Gerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gerar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gerar.Location = new System.Drawing.Point(613, 401);
            this.Gerar.Name = "Gerar";
            this.Gerar.Size = new System.Drawing.Size(89, 36);
            this.Gerar.TabIndex = 23;
            this.Gerar.Text = "Salvar";
            this.Gerar.UseVisualStyleBackColor = false;
            this.Gerar.Click += new System.EventHandler(this.Gerar_Click);
            // 
            // btnPathSource
            // 
            this.btnPathSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnPathSource.Location = new System.Drawing.Point(850, 361);
            this.btnPathSource.Name = "btnPathSource";
            this.btnPathSource.Size = new System.Drawing.Size(38, 23);
            this.btnPathSource.TabIndex = 26;
            this.btnPathSource.Text = "...";
            this.btnPathSource.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPathSource.UseVisualStyleBackColor = true;
            this.btnPathSource.Click += new System.EventHandler(this.btnPathSource_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(498, 361);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 23);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "F:\\Laboratório Drawing_Graphics\\files";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(429, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Destino:";
            // 
            // EMFFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 548);
            this.Controls.Add(this.btnPathSource);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Gerar);
            this.Controls.Add(this.rbFormulario);
            this.Controls.Add(this.rbArquivo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lbPercetual);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gpbArquivo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EMFFS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carteira ";
            this.Load += new System.EventHandler(this.EMFFS_Load);
            this.pnView.ResumeLayout(false);
            this.pnView.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbArquivo.ResumeLayout(false);
            this.gpbArquivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxTurma;
        private System.Windows.Forms.TextBox tbxSerie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxSexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxOrigem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDestino;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gpbArquivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbPercetual;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbArquivo;
        private System.Windows.Forms.RadioButton rbFormulario;
        private System.Windows.Forms.Button Gerar;
        private System.Windows.Forms.Button btnPathSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
    }
}

