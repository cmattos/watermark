namespace Watermark
{
    partial class frmWatermark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWatermark));
            this.cmdProcessImages = new System.Windows.Forms.Button();
            this.cmdReplicate = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDestino = new System.Windows.Forms.Button();
            this.btnOrigem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpAlterados = new System.Windows.Forms.DateTimePicker();
            this.optChanged = new System.Windows.Forms.RadioButton();
            this.optAll = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkWatermark = new System.Windows.Forms.CheckBox();
            this.chkJPG = new System.Windows.Forms.CheckBox();
            this.grpQuality = new System.Windows.Forms.GroupBox();
            this.lblDimensao = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblQualidade = new System.Windows.Forms.Label();
            this.trackQuality = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtLine1 = new System.Windows.Forms.TextBox();
            this.txtLine2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpQuality.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackQuality)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdProcessImages
            // 
            this.cmdProcessImages.Location = new System.Drawing.Point(185, 403);
            this.cmdProcessImages.Name = "cmdProcessImages";
            this.cmdProcessImages.Size = new System.Drawing.Size(72, 25);
            this.cmdProcessImages.TabIndex = 0;
            this.cmdProcessImages.Text = "Processar";
            this.cmdProcessImages.UseVisualStyleBackColor = true;
            this.cmdProcessImages.Click += new System.EventHandler(this.cmdProcessImages_Click);
            // 
            // cmdReplicate
            // 
            this.cmdReplicate.Location = new System.Drawing.Point(18, 598);
            this.cmdReplicate.Name = "cmdReplicate";
            this.cmdReplicate.Size = new System.Drawing.Size(122, 23);
            this.cmdReplicate.TabIndex = 1;
            this.cmdReplicate.Text = "Replicate Images";
            this.cmdReplicate.UseVisualStyleBackColor = true;
            this.cmdReplicate.Click += new System.EventHandler(this.cmdReplicate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDestino);
            this.groupBox2.Controls.Add(this.btnOrigem);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDestino);
            this.groupBox2.Controls.Add(this.txtOrigem);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 118);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Localização das Pastas:";
            // 
            // btnDestino
            // 
            this.btnDestino.Location = new System.Drawing.Point(275, 76);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(25, 23);
            this.btnDestino.TabIndex = 13;
            this.btnDestino.Text = "...";
            this.btnDestino.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // btnOrigem
            // 
            this.btnOrigem.Location = new System.Drawing.Point(275, 35);
            this.btnOrigem.Name = "btnOrigem";
            this.btnOrigem.Size = new System.Drawing.Size(25, 23);
            this.btnOrigem.TabIndex = 12;
            this.btnOrigem.Text = "...";
            this.btnOrigem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrigem.UseVisualStyleBackColor = true;
            this.btnOrigem.Click += new System.EventHandler(this.btnOrigem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Origem:";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(25, 77);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(250, 20);
            this.txtDestino.TabIndex = 1;
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(25, 36);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(250, 20);
            this.txtOrigem.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(263, 403);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 25);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Fechar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpAlterados);
            this.groupBox1.Controls.Add(this.optChanged);
            this.groupBox1.Controls.Add(this.optAll);
            this.groupBox1.Location = new System.Drawing.Point(14, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 102);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleção de Arquivos:";
            // 
            // dtpAlterados
            // 
            this.dtpAlterados.CustomFormat = "dddd, dd/MMM/yyyy";
            this.dtpAlterados.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAlterados.Location = new System.Drawing.Point(6, 66);
            this.dtpAlterados.Name = "dtpAlterados";
            this.dtpAlterados.Size = new System.Drawing.Size(168, 20);
            this.dtpAlterados.TabIndex = 18;
            // 
            // optChanged
            // 
            this.optChanged.AutoSize = true;
            this.optChanged.Location = new System.Drawing.Point(9, 43);
            this.optChanged.Name = "optChanged";
            this.optChanged.Size = new System.Drawing.Size(165, 17);
            this.optChanged.TabIndex = 17;
            this.optChanged.Text = "Arquivos alterados a partir de:";
            this.optChanged.UseVisualStyleBackColor = true;
            // 
            // optAll
            // 
            this.optAll.AutoSize = true;
            this.optAll.Checked = true;
            this.optAll.Location = new System.Drawing.Point(9, 20);
            this.optAll.Name = "optAll";
            this.optAll.Size = new System.Drawing.Size(99, 17);
            this.optAll.TabIndex = 16;
            this.optAll.TabStop = true;
            this.optAll.Text = "Todos Arquivos";
            this.optAll.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkWatermark);
            this.groupBox3.Controls.Add(this.chkJPG);
            this.groupBox3.Location = new System.Drawing.Point(13, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 46);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Processar:";
            // 
            // chkWatermark
            // 
            this.chkWatermark.AutoSize = true;
            this.chkWatermark.Checked = true;
            this.chkWatermark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWatermark.Location = new System.Drawing.Point(160, 19);
            this.chkWatermark.Name = "chkWatermark";
            this.chkWatermark.Size = new System.Drawing.Size(124, 17);
            this.chkWatermark.TabIndex = 1;
            this.chkWatermark.Text = "Inserir Marca D\'água";
            this.chkWatermark.UseVisualStyleBackColor = true;
            // 
            // chkJPG
            // 
            this.chkJPG.AutoSize = true;
            this.chkJPG.Checked = true;
            this.chkJPG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJPG.Location = new System.Drawing.Point(24, 19);
            this.chkJPG.Name = "chkJPG";
            this.chkJPG.Size = new System.Drawing.Size(115, 17);
            this.chkJPG.TabIndex = 0;
            this.chkJPG.Text = "Converter Imagens";
            this.chkJPG.UseVisualStyleBackColor = true;
            // 
            // grpQuality
            // 
            this.grpQuality.Controls.Add(this.lblDimensao);
            this.grpQuality.Controls.Add(this.lblTamanho);
            this.grpQuality.Controls.Add(this.lblQualidade);
            this.grpQuality.Controls.Add(this.trackQuality);
            this.grpQuality.Location = new System.Drawing.Point(204, 137);
            this.grpQuality.Name = "grpQuality";
            this.grpQuality.Size = new System.Drawing.Size(132, 102);
            this.grpQuality.TabIndex = 13;
            this.grpQuality.TabStop = false;
            this.grpQuality.Text = "Qualidade:";
            // 
            // lblDimensao
            // 
            this.lblDimensao.AutoSize = true;
            this.lblDimensao.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimensao.Location = new System.Drawing.Point(6, 85);
            this.lblDimensao.Name = "lblDimensao";
            this.lblDimensao.Size = new System.Drawing.Size(120, 13);
            this.lblDimensao.TabIndex = 3;
            this.lblDimensao.Text = "Dimensão: 1417 x 1929";
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanho.Location = new System.Drawing.Point(6, 70);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(91, 13);
            this.lblTamanho.TabIndex = 2;
            this.lblTamanho.Text = "Tamanho: 125 KB";
            // 
            // lblQualidade
            // 
            this.lblQualidade.AutoSize = true;
            this.lblQualidade.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualidade.Location = new System.Drawing.Point(6, 55);
            this.lblQualidade.Name = "lblQualidade";
            this.lblQualidade.Size = new System.Drawing.Size(91, 13);
            this.lblQualidade.TabIndex = 1;
            this.lblQualidade.Text = "Qualidade: 100%";
            // 
            // trackQuality
            // 
            this.trackQuality.Location = new System.Drawing.Point(6, 15);
            this.trackQuality.Maximum = 100;
            this.trackQuality.Name = "trackQuality";
            this.trackQuality.Size = new System.Drawing.Size(120, 45);
            this.trackQuality.SmallChange = 5;
            this.trackQuality.TabIndex = 0;
            this.trackQuality.TickFrequency = 10;
            this.trackQuality.Value = 100;
            this.trackQuality.Scroll += new System.EventHandler(this.trackQuality_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtLine2);
            this.groupBox4.Controls.Add(this.txtLine1);
            this.groupBox4.Location = new System.Drawing.Point(14, 245);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 100);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Texto da Marca d\'água:";
            // 
            // txtLine1
            // 
            this.txtLine1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLine1.Location = new System.Drawing.Point(62, 30);
            this.txtLine1.MaxLength = 25;
            this.txtLine1.Name = "txtLine1";
            this.txtLine1.Size = new System.Drawing.Size(171, 20);
            this.txtLine1.TabIndex = 0;
            this.txtLine1.Text = "* ESTE DOCUMENTO NÃO É *";
            // 
            // txtLine2
            // 
            this.txtLine2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLine2.Location = new System.Drawing.Point(62, 56);
            this.txtLine2.MaxLength = 25;
            this.txtLine2.Name = "txtLine2";
            this.txtLine2.Size = new System.Drawing.Size(171, 20);
            this.txtLine2.TabIndex = 1;
            this.txtLine2.Text = "* VÁLIDO COMO CERTIDÃO *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Linha 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Linha 2:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmWatermark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 437);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpQuality);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmdReplicate);
            this.Controls.Add(this.cmdProcessImages);
            this.MaximizeBox = false;
            this.Name = "frmWatermark";
            this.Text = "WD5 Conversor de Imagens - v1.3";
            this.Load += new System.EventHandler(this.frmWatermark_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpQuality.ResumeLayout(false);
            this.grpQuality.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackQuality)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdProcessImages;
        private System.Windows.Forms.Button cmdReplicate;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.Button btnOrigem;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optChanged;
        private System.Windows.Forms.RadioButton optAll;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkWatermark;
        private System.Windows.Forms.CheckBox chkJPG;
        private System.Windows.Forms.DateTimePicker dtpAlterados;
        private System.Windows.Forms.GroupBox grpQuality;
        private System.Windows.Forms.TrackBar trackQuality;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label lblQualidade;
        private System.Windows.Forms.Label lblDimensao;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtLine1;
        private System.Windows.Forms.TextBox txtLine2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

