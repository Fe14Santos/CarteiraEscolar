using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entities;

namespace Service
{
    class ImpressaoService
    {
        public void ProcessingImpressao(string nome, SerieTurma serieTurma, string targetPath, Panel pane)
        {
            string nomeArquivo = Path.Combine(GetOrCreateDirectory(targetPath, serieTurma.ToString()), $"{nome}.png");


            try
            {
                using (var bmp = new Bitmap(pane.Width, pane.Height))
                {
                    pane.DrawToBitmap(bmp, new Rectangle(0, 0, pane.Width, pane.Height));
                    bmp.Save(nomeArquivo);
                }
                // Processo de criação da imagem e salvamento concluído com sucesso
                // Resto do código aqui...


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
        private string GetOrCreateDirectory(string targetPath, string subdirectory)
        {
            string directoryPath = Path.Combine(targetPath, subdirectory);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            return directoryPath;
        }

        //public void ProcessingImpressao(string nome,SerieTurma serieTurma, string tagetpath,Panel pane)
        //{
        //    DirectoryInfo directoryInfo = new DirectoryInfo(tagetpath+"\\"+serieTurma);
        //    try
        //    {
        //        if (directoryInfo.Exists)
        //        {
        //            string nomeArquivo = directoryInfo.FullName + "\\" + nome + ".png";
        //            using (var bmp = new Bitmap(pane.Width, pane.Height))
        //            {
        //                pane.DrawToBitmap(bmp, new Rectangle(0, 0, pane.Width, pane.Height));
        //                bmp.Save(nomeArquivo);
        //            }
        //        }
        //        else
        //        {
        //            directoryInfo.Create();
        //            string nomeArquivo = directoryInfo.FullName + "\\" + nome + ".png";
        //            using (var bmp = new Bitmap(pane.Width, pane.Height))
        //            {
        //                pane.DrawToBitmap(bmp, new Rectangle(0, 0, pane.Width, pane.Height));
        //                bmp.Save(nomeArquivo);
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);                
        //    }
        //}
    }
}

