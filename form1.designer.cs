namespace calculdoraFisica
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_f1 = new System.Windows.Forms.TextBox();
            this.txt_f2 = new System.Windows.Forms.TextBox();
            this.txt_fp = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_kg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_decF1 = new System.Windows.Forms.Button();
            this.txt_f1y = new System.Windows.Forms.TextBox();
            this.txt_f1x = new System.Windows.Forms.TextBox();
            this.btn_comF1 = new System.Windows.Forms.Button();
            this.btn_decF2 = new System.Windows.Forms.Button();
            this.txt_f2y = new System.Windows.Forms.TextBox();
            this.txt_f2x = new System.Windows.Forms.TextBox();
            this.btn_comF2 = new System.Windows.Forms.Button();
            this.btn_decFp = new System.Windows.Forms.Button();
            this.txt_fpy = new System.Windows.Forms.TextBox();
            this.txt_fpx = new System.Windows.Forms.TextBox();
            this.btn_comFp = new System.Windows.Forms.Button();
            this.txt_info = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_calcular.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_calcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_calcular.Location = new System.Drawing.Point(62, 438);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(156, 70);
            this.btn_calcular.TabIndex = 6;
            this.btn_calcular.Text = "CALCULAR";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_f1
            // 
            this.txt_f1.AccessibleName = "";
            this.txt_f1.BackColor = System.Drawing.SystemColors.Window;
            this.txt_f1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_f1.Location = new System.Drawing.Point(62, 103);
            this.txt_f1.Name = "txt_f1";
            this.txt_f1.Size = new System.Drawing.Size(100, 20);
            this.txt_f1.TabIndex = 0;
            this.txt_f1.TextChanged += new System.EventHandler(this.txt_f1_TextChanged);
            // 
            // txt_f2
            // 
            this.txt_f2.Location = new System.Drawing.Point(385, 103);
            this.txt_f2.Name = "txt_f2";
            this.txt_f2.Size = new System.Drawing.Size(100, 20);
            this.txt_f2.TabIndex = 1;
            // 
            // txt_fp
            // 
            this.txt_fp.Location = new System.Drawing.Point(236, 293);
            this.txt_fp.Name = "txt_fp";
            this.txt_fp.Size = new System.Drawing.Size(100, 20);
            this.txt_fp.TabIndex = 5;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(286, 136);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(38, 20);
            this.txt_b.TabIndex = 3;
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(232, 135);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(38, 20);
            this.txt_a.TabIndex = 2;
            // 
            // txt_kg
            // 
            this.txt_kg.Location = new System.Drawing.Point(236, 174);
            this.txt_kg.Name = "txt_kg";
            this.txt_kg.Size = new System.Drawing.Size(85, 20);
            this.txt_kg.TabIndex = 4;
            this.txt_kg.TextChanged += new System.EventHandler(this.txt_kg_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(342, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 70);
            this.button1.TabIndex = 7;
            this.button1.Text = "LIMPAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_decF1
            // 
            this.btn_decF1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_decF1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_decF1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_decF1.Location = new System.Drawing.Point(62, 138);
            this.btn_decF1.Name = "btn_decF1";
            this.btn_decF1.Size = new System.Drawing.Size(100, 30);
            this.btn_decF1.TabIndex = 21;
            this.btn_decF1.TabStop = false;
            this.btn_decF1.Text = "DECOMPOR";
            this.btn_decF1.UseVisualStyleBackColor = false;
            this.btn_decF1.Click += new System.EventHandler(this.button6_Click);
            // 
            // txt_f1y
            // 
            this.txt_f1y.Location = new System.Drawing.Point(123, 174);
            this.txt_f1y.Name = "txt_f1y";
            this.txt_f1y.Size = new System.Drawing.Size(100, 20);
            this.txt_f1y.TabIndex = 20;
            this.txt_f1y.TabStop = false;
            // 
            // txt_f1x
            // 
            this.txt_f1x.Location = new System.Drawing.Point(8, 174);
            this.txt_f1x.Name = "txt_f1x";
            this.txt_f1x.Size = new System.Drawing.Size(100, 20);
            this.txt_f1x.TabIndex = 19;
            this.txt_f1x.TabStop = false;
            // 
            // btn_comF1
            // 
            this.btn_comF1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_comF1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_comF1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_comF1.Location = new System.Drawing.Point(62, 200);
            this.btn_comF1.Name = "btn_comF1";
            this.btn_comF1.Size = new System.Drawing.Size(100, 30);
            this.btn_comF1.TabIndex = 18;
            this.btn_comF1.TabStop = false;
            this.btn_comF1.Text = "COMPOR";
            this.btn_comF1.UseVisualStyleBackColor = false;
            this.btn_comF1.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_decF2
            // 
            this.btn_decF2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_decF2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_decF2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_decF2.Location = new System.Drawing.Point(385, 138);
            this.btn_decF2.Name = "btn_decF2";
            this.btn_decF2.Size = new System.Drawing.Size(100, 30);
            this.btn_decF2.TabIndex = 25;
            this.btn_decF2.TabStop = false;
            this.btn_decF2.Text = "DECOMPOR";
            this.btn_decF2.UseVisualStyleBackColor = false;
            this.btn_decF2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_f2y
            // 
            this.txt_f2y.Location = new System.Drawing.Point(446, 174);
            this.txt_f2y.Name = "txt_f2y";
            this.txt_f2y.Size = new System.Drawing.Size(100, 20);
            this.txt_f2y.TabIndex = 24;
            this.txt_f2y.TabStop = false;
            // 
            // txt_f2x
            // 
            this.txt_f2x.Location = new System.Drawing.Point(331, 174);
            this.txt_f2x.Name = "txt_f2x";
            this.txt_f2x.Size = new System.Drawing.Size(100, 20);
            this.txt_f2x.TabIndex = 23;
            this.txt_f2x.TabStop = false;
            // 
            // btn_comF2
            // 
            this.btn_comF2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_comF2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_comF2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_comF2.Location = new System.Drawing.Point(385, 200);
            this.btn_comF2.Name = "btn_comF2";
            this.btn_comF2.Size = new System.Drawing.Size(100, 30);
            this.btn_comF2.TabIndex = 22;
            this.btn_comF2.TabStop = false;
            this.btn_comF2.Text = "COMPOR";
            this.btn_comF2.UseVisualStyleBackColor = false;
            this.btn_comF2.Click += new System.EventHandler(this.btn_comF2_Click);
            // 
            // btn_decFp
            // 
            this.btn_decFp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_decFp.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_decFp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_decFp.Location = new System.Drawing.Point(234, 322);
            this.btn_decFp.Name = "btn_decFp";
            this.btn_decFp.Size = new System.Drawing.Size(100, 30);
            this.btn_decFp.TabIndex = 29;
            this.btn_decFp.TabStop = false;
            this.btn_decFp.Text = "DECOMPOR";
            this.btn_decFp.UseVisualStyleBackColor = false;
            this.btn_decFp.Click += new System.EventHandler(this.btn_decFp_Click);
            // 
            // txt_fpy
            // 
            this.txt_fpy.Location = new System.Drawing.Point(295, 358);
            this.txt_fpy.Name = "txt_fpy";
            this.txt_fpy.Size = new System.Drawing.Size(100, 20);
            this.txt_fpy.TabIndex = 28;
            this.txt_fpy.TabStop = false;
            // 
            // txt_fpx
            // 
            this.txt_fpx.Location = new System.Drawing.Point(180, 358);
            this.txt_fpx.Name = "txt_fpx";
            this.txt_fpx.Size = new System.Drawing.Size(100, 20);
            this.txt_fpx.TabIndex = 27;
            this.txt_fpx.TabStop = false;
            // 
            // btn_comFp
            // 
            this.btn_comFp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_comFp.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_comFp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_comFp.Location = new System.Drawing.Point(234, 384);
            this.btn_comFp.Name = "btn_comFp";
            this.btn_comFp.Size = new System.Drawing.Size(100, 30);
            this.btn_comFp.TabIndex = 26;
            this.btn_comFp.TabStop = false;
            this.btn_comFp.Text = "COMPOR";
            this.btn_comFp.UseVisualStyleBackColor = false;
            this.btn_comFp.Click += new System.EventHandler(this.btn_comFp_Click);
            // 
            // txt_info
            // 
            this.txt_info.BackColor = System.Drawing.SystemColors.InfoText;
            this.txt_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_info.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_info.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_info.Location = new System.Drawing.Point(159, -1);
            this.txt_info.Multiline = true;
            this.txt_info.Name = "txt_info";
            this.txt_info.ReadOnly = true;
            this.txt_info.Size = new System.Drawing.Size(236, 17);
            this.txt_info.TabIndex = 30;
            this.txt_info.TabStop = false;
            this.txt_info.Text = "Informe os dois ângulos e uma força/massa!";
            this.txt_info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_info.TextChanged += new System.EventHandler(this.txt_info_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(558, 520);
            this.Controls.Add(this.txt_info);
            this.Controls.Add(this.btn_decFp);
            this.Controls.Add(this.txt_fpy);
            this.Controls.Add(this.txt_fpx);
            this.Controls.Add(this.btn_comFp);
            this.Controls.Add(this.btn_decF2);
            this.Controls.Add(this.txt_f2y);
            this.Controls.Add(this.txt_f2x);
            this.Controls.Add(this.btn_comF2);
            this.Controls.Add(this.btn_decF1);
            this.Controls.Add(this.txt_f1y);
            this.Controls.Add(this.txt_f1x);
            this.Controls.Add(this.btn_comF1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_kg);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_fp);
            this.Controls.Add(this.txt_f2);
            this.Controls.Add(this.txt_f1);
            this.Controls.Add(this.btn_calcular);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_f1;
        private System.Windows.Forms.TextBox txt_f2;
        private System.Windows.Forms.TextBox txt_fp;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_kg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_decF1;
        private System.Windows.Forms.TextBox txt_f1y;
        private System.Windows.Forms.TextBox txt_f1x;
        private System.Windows.Forms.Button btn_comF1;
        private System.Windows.Forms.Button btn_decF2;
        private System.Windows.Forms.TextBox txt_f2y;
        private System.Windows.Forms.TextBox txt_f2x;
        private System.Windows.Forms.Button btn_comF2;
        private System.Windows.Forms.Button btn_decFp;
        private System.Windows.Forms.TextBox txt_fpy;
        private System.Windows.Forms.TextBox txt_fpx;
        private System.Windows.Forms.Button btn_comFp;
        private System.Windows.Forms.TextBox txt_info;
    }
}

