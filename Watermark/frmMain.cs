using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;


namespace Watermark
{
    public partial class frmWatermark : Form
    {
        private int iFolderCount = 0;
        private int iFilesRead = 0;
        private int iFilesConverted = 0;
        private int iFilesWatermarked = 0;
        private DateTime start = DateTime.Now;
        private readonly DateTime finish = DateTime.Now;
        private int floatx_line1 = -850;
        private int floaty_line1 = 1000;
        private int floatx_line2 = -850;
        private int floaty_line2 = 1200;
        private int fontsize = 72;
        //private int image_width;
        //private int image_height;



        public frmWatermark()
        {
            InitializeComponent();
        }

        private void cmdProcessImages_Click(object sender, EventArgs e)
        {
            
            if (txtDestino.Text.ToString() == string.Empty || txtOrigem.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Informe o PATH de Origem e Destino para processamento das imagens!", "WD5 Image Converter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (chkJPG.Checked == false && chkWatermark.Checked == false)
            { 
                MessageBox.Show("Nenhuma opção de processamento selecionada!", "WD5 Image Converter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DirectoryInfo di1 = new DirectoryInfo(txtOrigem.Text);
                DirectoryInfo di2 = new DirectoryInfo(txtDestino.Text);

                if (chkJPG.Checked == true)
                    if (di1.GetDirectories().Length == 0)
                        ConvertImagesFiles(
                            txtOrigem.Text, txtDestino.Text);
                    else
                        ConvertImagesDirs(txtOrigem.Text, txtDestino.Text);
                if (chkWatermark.Checked == true)
                    if (di2.GetDirectories().Length == 0)
                        InsertWatermarkFiles(txtDestino.Text);
                    else
                        InsertWatermarkDirs(txtDestino.Text);
            }
        }

        private void ConvertImagesDirs(
            string path_origem,
            string path_destino)
        {

            try
            {
                start = DateTime.Now;

                DirectoryInfo di = new System.IO.DirectoryInfo(path_origem);

                Cursor.Current = Cursors.WaitCursor;

                DirectoryInfo[] dirs = di.GetDirectories();

                foreach (DirectoryInfo diNext in dirs)
                {
                    string currentFolder = diNext.FullName.Replace(path_origem,path_destino).ToString();

                    iFolderCount++;

                    int iFileCount = 0;

                    foreach (System.IO.FileInfo fi in diNext.GetFiles("*.tif"))
                    {
                        iFilesRead++;
                        iFileCount++;

                        if (optChanged.Checked == true)
                        {
                            if (fi.LastWriteTime >= dtpAlterados.Value)
                            {

                                iFilesConverted++;
                                int count = 0;

                                using (Bitmap tifImage = new Bitmap(fi.FullName))
                                {
                                    count = tifImage.GetFrameCount(FrameDimension.Page);
                                    tifImage.Dispose();
                                }

                                for (int i = 0; i < count; i++)
                                {

                                    string sFile = fi.FullName.Replace(path_origem, path_destino);
                                    sFile = sFile.Substring(0, sFile.Length - 4) + "_" + i + ".jpg";

                                    using (Bitmap tifFrame = new Bitmap(fi.FullName))
                                    {
                                        tifFrame.SelectActiveFrame(FrameDimension.Page, i);

                                        if (Directory.Exists(currentFolder) == false)
                                            Directory.CreateDirectory(currentFolder);

                                        Encoder myEncoder = Encoder.Quality;
                                        EncoderParameter myEncoderParameter;
                                        EncoderParameters myEncoderParameters;
                                        ImageCodecInfo myImageCodecInfo;

                                        myEncoderParameters = new EncoderParameters(1);
                                        myEncoderParameter = new EncoderParameter(myEncoder, 5L);
                                        myEncoderParameters.Param[0] = myEncoderParameter;

                                        myImageCodecInfo = GetEncoderInfo("image/jpeg");

                                        tifFrame.Save(sFile, myImageCodecInfo, myEncoderParameters);
                                        tifFrame.Dispose();
                                    }
                                }

                            }

                        }
                        else
                        {
                            iFilesConverted++;
                            int count = 0;

                            using (Bitmap tifImage = new Bitmap(fi.FullName))
                            {
                                count = tifImage.GetFrameCount(FrameDimension.Page);
                                tifImage.Dispose();
                            }

                            for (int i = 0; i < count; i++)
                            {

                                string sFile = fi.FullName.Replace(path_origem, path_destino);
                                sFile = sFile.Substring(0, sFile.Length - 4) + "_" + i + ".jpg";

                                using (Bitmap tifFrame = new Bitmap(fi.FullName))
                                {
                                    tifFrame.SelectActiveFrame(FrameDimension.Page, i);

                                    if (Directory.Exists(currentFolder) == false)
                                        Directory.CreateDirectory(currentFolder);

                                    Encoder myEncoder = Encoder.Quality;
                                    EncoderParameter myEncoderParameter;
                                    EncoderParameters myEncoderParameters;
                                    ImageCodecInfo myImageCodecInfo;

                                    myEncoderParameters = new EncoderParameters(1);
                                    myEncoderParameter = new EncoderParameter(myEncoder, 5L);
                                    myEncoderParameters.Param[0] = myEncoderParameter;

                                    myImageCodecInfo = GetEncoderInfo("image/jpeg");

                                    tifFrame.Save(sFile, myImageCodecInfo, myEncoderParameters);
                                    tifFrame.Dispose();
                                }

                            }

                        }
                    }
                }

                Cursor.Current = Cursors.Default;

            }
            catch (OutOfMemoryException MemoryOutEx)
            {
                MessageBox.Show("Ocorreu um erro de memória durante o processamento. Este erro pode ser causado por falta de memória ou na tentativa de leitura de um arquivo de imagem corrompido. \n\nMensagem: " + MemoryOutEx.Message.ToString() + "\n\nVerifique!", "Convertendo Imagens", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu um erro durante o processamento: " + err.Message.ToString() + "! Verifique!", "Convertendo Imagens", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ConvertImagesFiles(string path_origem, string path_destino)
        {

            try
            {
                start = DateTime.Now;

                Cursor.Current = Cursors.WaitCursor;

                DirectoryInfo diNext = new DirectoryInfo(path_origem);
                
                    string currentFolder = diNext.FullName.Replace(path_origem, path_destino).ToString();

                    iFolderCount++;

                    int iFileCount = 0;

                    foreach (System.IO.FileInfo fi in diNext.GetFiles("*.tif"))
                    {
                        iFilesRead++;
                        iFileCount++;

                        if (optChanged.Checked == true)
                        {
                            if (fi.LastWriteTime >= dtpAlterados.Value)
                            {
                                iFilesConverted++;
                                int count = 0;

                                using (Bitmap tifImage = new Bitmap(fi.FullName))
                                {
                                    count = tifImage.GetFrameCount(FrameDimension.Page);
                                    tifImage.Dispose();
                                }

                                for (int i = 0; i < count; i++)
                                {

                                    string sFile = fi.FullName.Replace(path_origem, path_destino);
                                    sFile = sFile.Substring(0, sFile.Length - 4) + "_" + i + ".jpg";

                                    using (Bitmap tifFrame = new Bitmap(fi.FullName))
                                    {
                                        tifFrame.SelectActiveFrame(FrameDimension.Page, i);

                                        if (Directory.Exists(currentFolder) == false)
                                            Directory.CreateDirectory(currentFolder);

                                        Encoder myEncoder = Encoder.Quality;
                                        EncoderParameter myEncoderParameter;
                                        EncoderParameters myEncoderParameters;
                                        ImageCodecInfo myImageCodecInfo;

                                        myEncoderParameters = new EncoderParameters(1);
                                        myEncoderParameter = new EncoderParameter(myEncoder, 5L);
                                        myEncoderParameters.Param[0] = myEncoderParameter;

                                        myImageCodecInfo = GetEncoderInfo("image/jpeg");

                                        tifFrame.Save(sFile, myImageCodecInfo, myEncoderParameters);
                                        tifFrame.Dispose();
                                    }
                                }
                            }
                        }
                        else
                        {
                            iFilesConverted++;
                            int count = 0;

                            using (Bitmap tifImage = new Bitmap(fi.FullName))
                            {
                                count = tifImage.GetFrameCount(FrameDimension.Page);
                                tifImage.Dispose();
                            }
                            for (int i = 0; i < count; i++)
                            {

                                string sFile = fi.FullName.Replace(path_origem, path_destino);
                                sFile = sFile.Substring(0, sFile.Length - 4) + "_" + i + ".jpg";

                                using (Bitmap tifFrame = new Bitmap(fi.FullName))
                                {
                                    tifFrame.SelectActiveFrame(FrameDimension.Page, i);

                                    if (Directory.Exists(currentFolder) == false)
                                        Directory.CreateDirectory(currentFolder);

                                    Encoder myEncoder = Encoder.Quality;
                                    EncoderParameter myEncoderParameter;
                                    EncoderParameters myEncoderParameters;
                                    ImageCodecInfo myImageCodecInfo;

                                    myEncoderParameters = new EncoderParameters(1);
                                    myEncoderParameter = new EncoderParameter(myEncoder, 5L);
                                    myEncoderParameters.Param[0] = myEncoderParameter;

                                    myImageCodecInfo = GetEncoderInfo("image/jpeg");

                                    tifFrame.Save(sFile, myImageCodecInfo, myEncoderParameters);
                                    tifFrame.Dispose();
                                }
                                
                            }

                        }

                    }

                Cursor.Current = Cursors.Default;

            }
            catch (OutOfMemoryException MemoryOutEx)
            {
                MessageBox.Show("Ocorreu um erro de memória durante o processamento. Este erro pode ser causado por falta de memória ou na tentativa de leitura de um arquivo de imagem corrompido. \n\nMensagem: " + MemoryOutEx.Message.ToString() + "\n\nVerifique!", "Convertendo Imagens", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu um erro durante o processamento: " + err.Message.ToString() + "! Verifique!", "Convertendo Imagens", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        private void InsertWatermarkDirs(string path)
        {
            try
            {
                DirectoryInfo di = new System.IO.DirectoryInfo(path);

                Cursor.Current = Cursors.WaitCursor;

                DirectoryInfo[] dirs = di.GetDirectories();

                string sLine1 = txtLine1.Text;
                string sLine2 = txtLine2.Text;

                iFolderCount = 0;

                int iFileCount = 0;

                foreach (DirectoryInfo diNext in dirs)
                {
                    string currentFolder = diNext.FullName.ToString();

                    iFolderCount++;

                    foreach (System.IO.FileInfo fi in diNext.GetFiles("*.jpg"))
                    {
                    iFilesRead++;
                    iFileCount++;

                    if (optChanged.Checked == true)
                    {
                        if (fi.LastWriteTime >= dtpAlterados.Value)
                        {
                            iFilesWatermarked++;

                            int width = 0;
                            int height = 0;

                            using (Image img = Image.FromFile(fi.FullName.ToString()))
                            {
                                width = img.Width;
                                height = img.Height;

                                using (Bitmap baseMap = new Bitmap(width, height))
                                {
                                    using (Graphics myGraphic = Graphics.FromImage(baseMap))
                                    {
                                        using (Font fontTitle = new Font("Times New Roman", fontsize, FontStyle.Bold))
                                        {
                                            myGraphic.DrawImage(img, 0, 0, width, height);
                                            myGraphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                                            myGraphic.RotateTransform(-45);

                                            using (SolidBrush letterBrush = new SolidBrush(Color.FromArgb(100, 255, 255, 255)))
                                            {
                                                myGraphic.DrawString(sLine1, fontTitle, letterBrush, floatx_line1, floaty_line1);
                                                myGraphic.DrawString(sLine2, fontTitle, letterBrush, floatx_line2, floaty_line2);
                                            }

                                            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0)))
                                            {
                                                myGraphic.DrawString(sLine1, fontTitle, shadowBrush, floatx_line1, floaty_line1);
                                                myGraphic.DrawString(sLine2, fontTitle, shadowBrush, floatx_line2, floaty_line2);
                                            }
                                        }

                                        myGraphic.Dispose();
                                    }

                                    img.Dispose();

                                    Encoder myEncoder = Encoder.Quality;
                                    EncoderParameter myEncoderParameter;
                                    EncoderParameters myEncoderParameters;
                                    ImageCodecInfo myImageCodecInfo;

                                    myEncoderParameters = new EncoderParameters(1);
                                    myEncoderParameter = new EncoderParameter(myEncoder, 5L);
                                    myEncoderParameters.Param[0] = myEncoderParameter;

                                    myImageCodecInfo = GetEncoderInfo("image/jpeg");

                                    baseMap.Save(fi.FullName.ToString(), myImageCodecInfo, myEncoderParameters);

                                    baseMap.Dispose();
                                }
                            }

                        }
                    }
                        else
                    {
                        iFilesWatermarked++;

                        int width = 0;
                        int height = 0;

                        using (Image img = Image.FromFile(fi.FullName.ToString()))
                        {
                            width = img.Width;
                            height = img.Height;

                            using (Bitmap baseMap = new Bitmap(width, height))
                            {
                                using (Graphics myGraphic = Graphics.FromImage(baseMap))
                                {
                                    using (Font fontTitle = new Font("Times New Roman", fontsize, FontStyle.Bold))
                                    {
                                        myGraphic.DrawImage(img, 0, 0, width, height);
                                        myGraphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                                        myGraphic.RotateTransform(-45);

                                        using (SolidBrush letterBrush = new SolidBrush(Color.FromArgb(100, 255, 255, 255)))
                                        {
                                            myGraphic.DrawString(sLine1, fontTitle, letterBrush, floatx_line1, floaty_line1);
                                            myGraphic.DrawString(sLine2, fontTitle, letterBrush, floatx_line2, floaty_line2);
                                        }

                                        using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0)))
                                        {
                                            myGraphic.DrawString(sLine1, fontTitle, shadowBrush, floatx_line1, floaty_line1);
                                            myGraphic.DrawString(sLine2, fontTitle, shadowBrush, floatx_line2, floaty_line2);
                                        }
                                    }

                                    myGraphic.Dispose();
                                }

                                img.Dispose();

                                Encoder myEncoder = Encoder.Quality;
                                EncoderParameter myEncoderParameter;
                                EncoderParameters myEncoderParameters;
                                ImageCodecInfo myImageCodecInfo;

                                myEncoderParameters = new EncoderParameters(1);
                                myEncoderParameter = new EncoderParameter(myEncoder, 5L);
                                myEncoderParameters.Param[0] = myEncoderParameter;

                                myImageCodecInfo = GetEncoderInfo("image/jpeg");

                                baseMap.Save(fi.FullName.ToString(), myImageCodecInfo, myEncoderParameters);

                                baseMap.Dispose();
                            }
                        }
                    }
                 }
            }

                Cursor.Current = Cursors.Default;

                DateTime finish = DateTime.Now;

                MessageBox.Show("Conversão concluída! \nInício: [" + start.ToString() + "] \nTérmino: [" + finish.ToString() + "] \nPastas: [" + iFolderCount.ToString() + "] \nArquivos Processados: [" + iFilesRead.ToString() + "] \nArquivos Convertidos: [" + iFilesConverted.ToString() + "] \nArquivos Marcados: [" + iFilesWatermarked.ToString() + "]", "WD5 Image Converter", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (OutOfMemoryException MemoryOutEx)
            {
                MessageBox.Show("Ocorreu um erro de memória durante o processamento. Este erro pode ser causado por falta de memória ou na tentativa de leitura de um arquivo de imagem corrompido. \n\nMensagem: " + MemoryOutEx.Message.ToString() + "\n\nVerifique!", "Convertendo Imagens", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu um erro durante o processamento: \n\nMensagem: " + err.Message.ToString() + "! \n\nVerifique!", "Convertendo Imagens", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void InsertWatermarkFiles(string path)
        {

            try
            {

                Cursor.Current = Cursors.WaitCursor;

                string sLine1 = txtLine1.Text;
                string sLine2 = txtLine2.Text;

                iFolderCount = 0;

                int iFileCount = 0;

                DirectoryInfo diNext = new DirectoryInfo(path);
                
                    string currentFolder = diNext.FullName.ToString();

                    iFolderCount++;

                    foreach (System.IO.FileInfo fi in diNext.GetFiles("*.jpg"))
                    {
                        iFilesRead++;
                        iFileCount++;

                        if (optChanged.Checked == true)
                        {
                            if (fi.LastWriteTime >= dtpAlterados.Value)
                            {

                                iFilesWatermarked++;

                                int width = 0;
                                int height = 0;

                                using (Image img = Image.FromFile(fi.FullName.ToString()))
                                {
                                    width = img.Width;
                                    height = img.Height;

                                    using (Bitmap baseMap = new Bitmap(width, height))
                                    {
                                        using (Graphics myGraphic = Graphics.FromImage(baseMap))
                                        {
                                            myGraphic.DrawImage(img, 0, 0, width, height);
                                            myGraphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                                            myGraphic.RotateTransform(-45);

                                            using (Font fontTitle = new Font("Times New Roman", fontsize, FontStyle.Bold))
                                            {

                                                using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0)))
                                                {
                                                    myGraphic.DrawString(sLine1, fontTitle, shadowBrush, floatx_line1, floaty_line1);
                                                    myGraphic.DrawString(sLine2, fontTitle, shadowBrush, floatx_line2, floaty_line2);
                                                }

                                                using (SolidBrush letterBrush = new SolidBrush(Color.FromArgb(100, 255, 255, 255)))
                                                {
                                                    myGraphic.DrawString(sLine1, fontTitle, letterBrush, floatx_line1, floaty_line1);
                                                    myGraphic.DrawString(sLine2, fontTitle, letterBrush, floatx_line2, floaty_line2);
                                                }
                                            }
                                        }
                                        img.Dispose();

                                        Encoder myEncoder = Encoder.Quality;
                                        EncoderParameter myEncoderParameter;
                                        EncoderParameters myEncoderParameters;
                                        ImageCodecInfo myImageCodecInfo;

                                        myEncoderParameters = new EncoderParameters(1);
                                        myEncoderParameter = new EncoderParameter(myEncoder, 5L);
                                        myEncoderParameters.Param[0] = myEncoderParameter;

                                        myImageCodecInfo = GetEncoderInfo("image/jpeg");

                                        baseMap.Save(fi.FullName.ToString(), myImageCodecInfo, myEncoderParameters);

                                        baseMap.Dispose();
                                    }
                                }
                            }
                        }

                        else
                        {
                            iFilesWatermarked++;

                            int width = 0;
                            int height = 0;

                            using (Image img = Image.FromFile(fi.FullName.ToString()))
                            {
                                width = img.Width;
                                height = img.Height;

                                using (Bitmap baseMap = new Bitmap(width, height))
                                {
                                    using (Graphics myGraphic = Graphics.FromImage(baseMap))
                                    {
                                        myGraphic.DrawImage(img, 0, 0, width, height);
                                        myGraphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                                        myGraphic.RotateTransform(-45);

                                        using (Font fontTitle = new Font("Times New Roman", fontsize, FontStyle.Bold))
                                        {

                                            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0)))
                                            {
                                                myGraphic.DrawString(sLine1, fontTitle, shadowBrush, floatx_line1, floaty_line1);
                                                myGraphic.DrawString(sLine2, fontTitle, shadowBrush, floatx_line2, floaty_line2);
                                            }

                                            using (SolidBrush letterBrush = new SolidBrush(Color.FromArgb(100, 255, 255, 255)))
                                            {
                                                myGraphic.DrawString(sLine1, fontTitle, letterBrush, floatx_line1, floaty_line1);
                                                myGraphic.DrawString(sLine2, fontTitle, letterBrush, floatx_line2, floaty_line2);
                                            }
                                        }
                                    }
                                    img.Dispose();

                                    Encoder myEncoder = Encoder.Quality;
                                    EncoderParameter myEncoderParameter;
                                    EncoderParameters myEncoderParameters;
                                    ImageCodecInfo myImageCodecInfo;

                                    myEncoderParameters = new EncoderParameters(1);
                                    myEncoderParameter = new EncoderParameter(myEncoder, 5L);
                                    myEncoderParameters.Param[0] = myEncoderParameter;

                                    myImageCodecInfo = GetEncoderInfo("image/jpeg");

                                    baseMap.Save(fi.FullName.ToString(), myImageCodecInfo, myEncoderParameters);

                                    baseMap.Dispose();
                                }
                            }

                        }
                    }

                    Cursor.Current = Cursors.Default;

                    DateTime finish = DateTime.Now;

                    MessageBox.Show("Conversão concluída! \nInício: [" + start.ToString() + "] \nTérmino: [" + finish.ToString() + "] \nPastas: [" + iFolderCount.ToString() + "] \nArquivos Processados: [" + iFilesRead.ToString() + "] \nArquivos Convertidos: [" + iFilesConverted.ToString() + "] \nArquivos Marcados: [" + iFilesWatermarked.ToString() + "]", "WD5 Image Converter", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (OutOfMemoryException MemoryOutEx)
                {
                    MessageBox.Show("Ocorreu um erro de memória durante o processamento. Este erro pode ser causado por falta de memória ou na tentativa de leitura de um arquivo de imagem corrompido. \n\nMensagem: " + MemoryOutEx.Message.ToString() + "\n\nVerifique!", "Convertendo Imagens", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception err)
                {

                    MessageBox.Show("Ocorreu um erro durante o processamento: " + err.Message.ToString() + "! Verifique!", "Convertendo Imagens", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }


        }

        private void cmdReplicate_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;

            for (int j = 1000; j <= 130000; j += 1000)
            {

                Directory.CreateDirectory(@"c:\temp2\" + j.ToString());

                for (int i = 1; i < 1000; i++)
                {
                    File.Copy(@"c:\temp2\matricula1.tif", @"c:\temp2\" + j.ToString() + @"\mat" + i.ToString() + ".tif", true);
                }
            }

            Cursor.Current = Cursors.Default;
        }

        private void btnOrigem_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txtOrigem.Text = folderDialog.SelectedPath.ToString() + "\\";
            }
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txtDestino.Text = folderDialog.SelectedPath.ToString() + "\\";
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmWatermark_Load(object sender, EventArgs e)
        {
            dtpAlterados.Value = DateTime.Today.AddDays(-1);
        }

        private void trackQuality_Scroll(object sender, EventArgs e)
        {
            if (trackQuality.Value > 0)
            {
                decimal q = ((decimal)trackQuality.Value / 100);
                lblQualidade.Text = "Qualidade: " + trackQuality.Value.ToString() + "%";
                lblTamanho.Text = "Tamanho: " + 125 * q + " KB";
                lblDimensao.Text = "Dimensão: " + Convert.ToInt32(1417 * q).ToString() + " x " + Convert.ToInt32(1929 * q).ToString();

                floatx_line1 = Convert.ToInt32(-850 * q);
                floaty_line1 = Convert.ToInt32(1000 * q);

                floatx_line2 = Convert.ToInt32(-850 * q);
                floaty_line2 = Convert.ToInt32(1200 * q);

                fontsize = Convert.ToInt32(72 * q);

                //image_width = Convert.ToInt32(1417 * q);
                //image_height = Convert.ToInt32(1929 * q);

            }
        }
    }
}