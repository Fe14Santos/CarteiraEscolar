﻿using System;
using System.IO;
using Service;
using Entities;
using Entities.Enums;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicationCarteiraEstudantil
{
    public partial class EMFFS : Form
    {
        ImpressaoService ImpressaoService = new ImpressaoService();
        List<Alunos> alunos = new List<Alunos>();
        public EMFFS()
        {
            InitializeComponent();            
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            tbxOrigem.Text = openFileDialog1.FileName;
            string path = openFileDialog1.FileName;

           

            if (!File.Exists(path))
            {
                MessageBox.Show("Arquivo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbRegular.Checked)
            {
                using (FileStream fileStream = new FileStream(@path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {

                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        string[] line;
                        while (!streamReader.EndOfStream)
                        {
                            line = streamReader.ReadLine().Split(',');
                            Sexo sexo = (Sexo)Enum.Parse(typeof(Sexo), line[2].ToString());
                            alunos.Add(new Alunos(line[1].ToUpper(), new SerieTurma(line[0].Replace("_", " ").Substring(0, 5).ToUpper(), line[0].Substring(6).ToUpper()), sexo));
                        }
                    }
                }
            }
            if (rbIntegral.Checked)
            {
                using (FileStream fileStream = new FileStream(@path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        string[] line;
                        while (!streamReader.EndOfStream)
                        {
                            line = streamReader.ReadLine().Split(',');
                            Sexo sexo = (Sexo)Enum.Parse(typeof(Sexo), line[2].ToString());
                            alunos.Add(new Alunos(line[1].ToUpper(), new SerieTurma(line[0].Replace("_", " ").Substring(0, 10).ToUpper(), line[0].Substring(11).ToUpper()), sexo));
                        }
                    }
                }
            }
            if (rbAEE.Checked)
            {
                using (FileStream fileStream = new FileStream(@path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        string[] line;
                        while (!streamReader.EndOfStream)
                        {
                            line = streamReader.ReadLine().Split(',');
                            Sexo sexo = (Sexo)Enum.Parse(typeof(Sexo), line[2].ToString());
                            alunos.Add(new Alunos(line[1].ToUpper(), new SerieTurma(line[0].Replace("_", " ").Substring(0, 5).ToUpper(), line[0].Substring(6).ToUpper()), sexo));
                        }
                    }
                }
            }
            if (rbEJA.Checked)
            {
                using (FileStream fileStream = new FileStream(@path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        string[] line;
                        while (!streamReader.EndOfStream)
                        {
                            line = streamReader.ReadLine().Split(',');
                            Sexo sexo = (Sexo)Enum.Parse(typeof(Sexo), line[2].ToString());
                            alunos.Add(new Alunos(line[1].ToUpper(), new SerieTurma(line[0].Replace("_", " ").Substring(0, 6).ToUpper(), line[0].Substring(7).ToUpper()), sexo));
                        }
                    }
                }
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tbxDestino.Text = folderBrowserDialog1.SelectedPath;
            btnIniciar.Enabled = true;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string targetpath = @tbxDestino.Text;
            int count = 0;
            progressBar1.Maximum = alunos.Count;

            foreach (var item in alunos)
            {
                progressBar1.Value = count + 1;
                lbPercetual.Text = (progressBar1.Value / progressBar1.Maximum * 100).ToString() + "%";
                lbPercetual.Refresh();
                if (rbRegular.Checked)
                {                    
                    tbxNomeAlunoRegular.Text = item.Nome;
                    tbxSexoAlunoRegular.Text = item.Sexo.ToString();
                    tbxSerieAlunoRegular.Text = item.SerieTurmas.Serie;
                    tbxTurmasAlunoRegular.Text = item.SerieTurmas.Turma;
                    StartImpressao(item.Nome, item.SerieTurmas, targetpath, pnViewRegular);
                }
                else if (rbIntegral.Checked)
                {                 
                    tbxNomeAlunoIntegral.Text = item.Nome;
                    tbxSexoAlunoIntegral.Text = item.Sexo.ToString();
                    tbxSerieAlunoIntegral.Text = item.SerieTurmas.Serie;
                    tbxTurmasAlunoIntegral.Text = item.SerieTurmas.Turma;
                    StartImpressao(item.Nome, item.SerieTurmas, targetpath, pnViewIntegral);
                }
                else if (rbEJA.Checked)
                {                  
                    tbxNomeAlunoEJA.Text = item.Nome;
                    tbxSexoAlunoEJA.Text = item.Sexo.ToString();
                    tbxSerieAlunoEJA.Text = item.SerieTurmas.Serie;
                    tbxTurmasAlunoEJA.Text = item.SerieTurmas.Turma;
                    StartImpressao(item.Nome, item.SerieTurmas, targetpath, pnlViewEJA);
                }
                else if (rbAEE.Checked)
                {                    
                    tbxNomeAlunoAEE.Text = item.Nome;
                    tbxSexoAlunoAEE.Text = item.Sexo.ToString();
                    tbxSerieAlunoAEE.Text = item.SerieTurmas.Serie;
                    tbxTurmasAlunoAEE.Text = item.SerieTurmas.Turma;
                    StartImpressao(item.Nome, item.SerieTurmas, targetpath, pnViewAEE);
                }
                lbPercetual.Refresh();
                progressBar1.Refresh();
                count++;
            }
            MessageBox.Show("Operação Realizada Com Sucesso!!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show($"{count} Geras com Sucesso");
            ImpressaoService = new ImpressaoService();
             alunos = new List<Alunos>();
        }
        private void EMFFS_Load(object sender, EventArgs e)
        {
            btnIniciar.Enabled = false;
            rbArquivo.Checked = true;
            MessageBox.Show("Antes de Selecionar o Arquivo, Marque a Opção desejada","IMPORTANTE!!!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
        private void rbFormulario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFormulario.Checked)
            {
                gpbArquivo.Enabled = false;
                Gerar.Enabled = true;
            }
        }
        private void rbArquivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbArquivo.Checked)
            {
                gpbArquivo.Enabled = true;
                Gerar.Enabled = false;
            }
        }
        private void Gerar_Click(object sender, EventArgs e)
        {
            string targetpath = @tbxDestino.Text;

            //if (string.IsNullOrEmpty(tbxNome.Text))
            //{
            //    MessageBox.Show("O nome não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            if (string.IsNullOrEmpty(tbxSerieAlunoIntegral.Text) || string.IsNullOrEmpty(tbxTurmasAlunoIntegral.Text))
            {
                MessageBox.Show("Selecione a série/turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(targetpath))
            {
                MessageBox.Show("O caminho de destino não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ImpressaoService.ProcessingImpressao(tbxNomeAlunoIntegral.Text, new SerieTurma(tbxSerieAlunoIntegral.Text, tbxTurmasAlunoIntegral.Text), targetpath, pnViewIntegral);

        }
        private void btnPathSource_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tbxDestino.Text = folderBrowserDialog1.SelectedPath;
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }
        private void StartImpressao(string nome, SerieTurma serieTurma, string targetPath, Panel pane)
        {
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O nome não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (serieTurma == null)
            {
                MessageBox.Show("Selecione a série/turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(targetPath))
            {
                MessageBox.Show("O caminho de destino não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                ImpressaoService.ProcessingImpressao(nome, serieTurma, targetPath, pane);
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show("Diretório de destino não encontrado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Erro ao salvar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro desconhecido: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnViewAEE_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
//using System;
//using System.IO;
//using Service;
//using Entities;
//using Entities.Enums;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace AplicationCarteiraEstudantil
//{

//    public partial class EMFFS : Form
//    {
//        ImpressaoService ImpressaoService = new ImpressaoService();
//        List<Alunos> alunos = new List<Alunos>();
//        public EMFFS()
//        {
//            InitializeComponent();
//        }

//        private void btnAbrir_Click(object sender, EventArgs e)
//        {
//            openFileDialog1.ShowDialog();
//            tbxOrigem.Text = openFileDialog1.FileName;
//            string path = openFileDialog1.FileName;

//            using (FileStream fileStream = new FileStream(@path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
//            {
//                using (StreamReader streamReader = new StreamReader(fileStream))
//                {
//                    string[] line;
//                    while (!streamReader.EndOfStream)
//                    {
//                        line = streamReader.ReadLine().Split(',');
//                        Sexo sexo = (Sexo)Enum.Parse(typeof(Sexo), line[2].ToString());
//                        alunos.Add(new Alunos(line[1].ToUpper(), new SerieTurma(line[0].Replace("_", " ").Substring(0, 5).ToUpper(), line[0].Substring(6).ToUpper()), sexo));
//                    }
//                }
//            }
//        }
//        private void btnSalvar_Click(object sender, EventArgs e)
//        {
//            folderBrowserDialog1.ShowDialog();
//            tbxDestino.Text = folderBrowserDialog1.SelectedPath;
//            btnIniciar.Enabled = true;
//        }
//        private void button1_Click(object sender, EventArgs e)
//        {
//            string targetpath = @tbxDestino.Text;
//            int count = 0;
//            progressBar1.Maximum = alunos.Count;

//            foreach (var item in alunos)
//            {
//                progressBar1.Value = count + 1;
//                lbPercetual.Text = (progressBar1.Value / progressBar1.Maximum * 100).ToString() + "%";
//                tbxNome.Text = item.Nome;
//                tbxSexo.Text = item.Sexo.ToString();
//                tbxSerie.Text = item.SerieTurmas.Serie;
//                tbxTurma.Text = item.SerieTurmas.Turma;

//                StartImpressao(item.Nome, item.SerieTurmas, targetpath, pnView);
//                ///ImpressaoService.ProcessingImpressao(item.Nome, item.SerieTurmas, targetpath, pnView);

//                lbPercetual.Refresh();
//                progressBar1.Refresh();
//                count++;
//            }
//            MessageBox.Show("Operação Realizada Com Sucesso!!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }

//       private void EMFFS_Load(object sender, EventArgs e)
//        {
//            btnIniciar.Enabled = false;
//            rbArquivo.Checked = true;
//        }

//        private void rbFormulario_CheckedChanged(object sender, EventArgs e)
//        {
//            if (rbFormulario.Checked)
//            {
//                gpbArquivo.Enabled = false;
//                Gerar.Enabled = true;
//            }
//        }

//        private void rbArquivo_CheckedChanged(object sender, EventArgs e)
//        {
//            if (rbArquivo.Checked)
//            {
//                gpbArquivo.Enabled = true;
//                Gerar.Enabled = false;
//            }
//        }
//        private void Gerar_Click(object sender, EventArgs e)
//        {
//            string targetpath = @tbxDestino.Text;
//            ImpressaoService.ProcessingImpressao(tbxNome.Text, new SerieTurma(tbxSerie.Text, tbxTurma.Text), targetpath, pnView);
//        }

//        private void button1_Click_1(object sender, EventArgs e)
//        {
//            folderBrowserDialog1.ShowDialog();
//            tbxDestino.Text = folderBrowserDialog1.SelectedPath;
//            textBox1.Text = folderBrowserDialog1.SelectedPath;
//        }
//        private void StartImpressao(string nome, SerieTurma serieTurma, string targetPath, Panel pane)
//        {
//            if (string.IsNullOrEmpty(nome))
//            {
//                MessageBox.Show("O nome não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }

//            if (serieTurma == null)
//            {
//                MessageBox.Show("Selecione a série/turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }

//            if (string.IsNullOrEmpty(targetPath))
//            {
//                MessageBox.Show("O caminho de destino não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }

//            // Todas as informações necessárias estão preenchidas, iniciar a impressão
//            try
//            {
//                ImpressaoService.ProcessingImpressao(nome, serieTurma, targetPath, pane);
//            }
//            catch (DirectoryNotFoundException ex)
//            {
//                MessageBox.Show("Diretório de destino não encontrado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            catch (IOException ex)
//            {
//                MessageBox.Show("Erro ao salvar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Ocorreu um erro desconhecido: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }
//    }
//}


