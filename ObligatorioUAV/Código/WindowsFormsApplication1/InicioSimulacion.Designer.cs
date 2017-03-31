namespace WindowsFormsApplication1
{
    partial class InicioSimulacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSimulacion));
            this.titulolabel1 = new System.Windows.Forms.Label();
            this.listDrones = new System.Windows.Forms.ListBox();
            this.volverbutton1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xi = new System.Windows.Forms.TextBox();
            this.yi = new System.Windows.Forms.TextBox();
            this.zi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.zf = new System.Windows.Forms.TextBox();
            this.yf = new System.Windows.Forms.TextBox();
            this.xf = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.zv = new System.Windows.Forms.TextBox();
            this.yv = new System.Windows.Forms.TextBox();
            this.xv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titulolabel1
            // 
            this.titulolabel1.AutoSize = true;
            this.titulolabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.titulolabel1.Location = new System.Drawing.Point(12, 9);
            this.titulolabel1.Name = "titulolabel1";
            this.titulolabel1.Size = new System.Drawing.Size(153, 17);
            this.titulolabel1.TabIndex = 11;
            this.titulolabel1.Text = "Seleccione un dron:";
            // 
            // listDrones
            // 
            this.listDrones.FormattingEnabled = true;
            this.listDrones.HorizontalScrollbar = true;
            this.listDrones.Location = new System.Drawing.Point(15, 38);
            this.listDrones.Name = "listDrones";
            this.listDrones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listDrones.ScrollAlwaysVisible = true;
            this.listDrones.Size = new System.Drawing.Size(372, 108);
            this.listDrones.TabIndex = 12;
            this.listDrones.SelectedIndexChanged += new System.EventHandler(this.listDrones_SelectedIndexChanged);
            // 
            // volverbutton1
            // 
            this.volverbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverbutton1.Location = new System.Drawing.Point(15, 336);
            this.volverbutton1.Name = "volverbutton1";
            this.volverbutton1.Size = new System.Drawing.Size(88, 25);
            this.volverbutton1.TabIndex = 13;
            this.volverbutton1.Text = "Volver";
            this.volverbutton1.UseVisualStyleBackColor = true;
            this.volverbutton1.Click += new System.EventHandler(this.volverbutton1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(299, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 25);
            this.button1.TabIndex = 14;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Indique coordenadas iniciales de vuelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Indique coordenadas finales de vuelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Indique vector de velocidad inicial:";
            // 
            // xi
            // 
            this.xi.Enabled = false;
            this.xi.Location = new System.Drawing.Point(259, 188);
            this.xi.Name = "xi";
            this.xi.Size = new System.Drawing.Size(26, 20);
            this.xi.TabIndex = 18;
            // 
            // yi
            // 
            this.yi.Enabled = false;
            this.yi.Location = new System.Drawing.Point(310, 188);
            this.yi.Name = "yi";
            this.yi.Size = new System.Drawing.Size(26, 20);
            this.yi.TabIndex = 21;
            // 
            // zi
            // 
            this.zi.Enabled = false;
            this.zi.Location = new System.Drawing.Point(361, 188);
            this.zi.Name = "zi";
            this.zi.Size = new System.Drawing.Size(26, 20);
            this.zi.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(342, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(342, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "z";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(291, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(240, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "x";
            // 
            // zf
            // 
            this.zf.Enabled = false;
            this.zf.Location = new System.Drawing.Point(361, 239);
            this.zf.Name = "zf";
            this.zf.Size = new System.Drawing.Size(26, 20);
            this.zf.TabIndex = 32;
            // 
            // yf
            // 
            this.yf.Enabled = false;
            this.yf.Location = new System.Drawing.Point(310, 239);
            this.yf.Name = "yf";
            this.yf.Size = new System.Drawing.Size(26, 20);
            this.yf.TabIndex = 31;
            // 
            // xf
            // 
            this.xf.Enabled = false;
            this.xf.Location = new System.Drawing.Point(259, 239);
            this.xf.Name = "xf";
            this.xf.Size = new System.Drawing.Size(26, 20);
            this.xf.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(342, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 15);
            this.label10.TabIndex = 41;
            this.label10.Text = "z";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(291, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 15);
            this.label11.TabIndex = 40;
            this.label11.Text = "y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(240, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 15);
            this.label12.TabIndex = 39;
            this.label12.Text = "x";
            // 
            // zv
            // 
            this.zv.Enabled = false;
            this.zv.Location = new System.Drawing.Point(361, 288);
            this.zv.Name = "zv";
            this.zv.Size = new System.Drawing.Size(26, 20);
            this.zv.TabIndex = 38;
            // 
            // yv
            // 
            this.yv.Enabled = false;
            this.yv.Location = new System.Drawing.Point(310, 288);
            this.yv.Name = "yv";
            this.yv.Size = new System.Drawing.Size(26, 20);
            this.yv.TabIndex = 37;
            // 
            // xv
            // 
            this.xv.Enabled = false;
            this.xv.Location = new System.Drawing.Point(259, 288);
            this.xv.Name = "xv";
            this.xv.Size = new System.Drawing.Size(26, 20);
            this.xv.TabIndex = 36;
            // 
            // InicioSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 376);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.zv);
            this.Controls.Add(this.yv);
            this.Controls.Add(this.xv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.zf);
            this.Controls.Add(this.yf);
            this.Controls.Add(this.xf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zi);
            this.Controls.Add(this.yi);
            this.Controls.Add(this.xi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.volverbutton1);
            this.Controls.Add(this.listDrones);
            this.Controls.Add(this.titulolabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioSimulacion";
            this.Text = "Inicio Simulación";
            this.Load += new System.EventHandler(this.InicioSimulacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulolabel1;
        private System.Windows.Forms.ListBox listDrones;
        private System.Windows.Forms.Button volverbutton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xi;
        private System.Windows.Forms.TextBox yi;
        private System.Windows.Forms.TextBox zi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox zf;
        private System.Windows.Forms.TextBox yf;
        private System.Windows.Forms.TextBox xf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox zv;
        private System.Windows.Forms.TextBox yv;
        private System.Windows.Forms.TextBox xv;
    }
}