namespace WindowsFormsApplication1
{
    partial class AgregarPieza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPieza));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.marcaText = new System.Windows.Forms.TextBox();
            this.modeloText = new System.Windows.Forms.TextBox();
            this.tipoPiezaCombo = new System.Windows.Forms.ComboBox();
            this.precisionText = new System.Windows.Forms.TextBox();
            this.minimoText = new System.Windows.Forms.TextBox();
            this.maximoText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tipoPiezaText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(68, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(68, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(68, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precisión:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(68, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mínimo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(68, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Max:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(68, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de pieza:";
            // 
            // marcaText
            // 
            this.marcaText.Location = new System.Drawing.Point(172, 57);
            this.marcaText.Name = "marcaText";
            this.marcaText.Size = new System.Drawing.Size(121, 20);
            this.marcaText.TabIndex = 1;
            // 
            // modeloText
            // 
            this.modeloText.Location = new System.Drawing.Point(172, 89);
            this.modeloText.Name = "modeloText";
            this.modeloText.Size = new System.Drawing.Size(121, 20);
            this.modeloText.TabIndex = 2;
            // 
            // tipoPiezaCombo
            // 
            this.tipoPiezaCombo.FormattingEnabled = true;
            this.tipoPiezaCombo.Items.AddRange(new object[] {
            "Termómetro",
            "Velocímetro",
            "Altímetro",
            "Barómetro",
            "GPS",
            "Acelerómetro"});
            this.tipoPiezaCombo.Location = new System.Drawing.Point(172, 234);
            this.tipoPiezaCombo.Name = "tipoPiezaCombo";
            this.tipoPiezaCombo.Size = new System.Drawing.Size(121, 21);
            this.tipoPiezaCombo.TabIndex = 8;
            this.tipoPiezaCombo.SelectedIndexChanged += new System.EventHandler(this.tipoPiezaCombo_SelectedIndexChanged);
            // 
            // precisionText
            // 
            this.precisionText.Location = new System.Drawing.Point(172, 128);
            this.precisionText.Name = "precisionText";
            this.precisionText.Size = new System.Drawing.Size(121, 20);
            this.precisionText.TabIndex = 3;
            // 
            // minimoText
            // 
            this.minimoText.Location = new System.Drawing.Point(172, 161);
            this.minimoText.Name = "minimoText";
            this.minimoText.Size = new System.Drawing.Size(59, 20);
            this.minimoText.TabIndex = 4;
            // 
            // maximoText
            // 
            this.maximoText.Location = new System.Drawing.Point(172, 196);
            this.maximoText.Name = "maximoText";
            this.maximoText.Size = new System.Drawing.Size(59, 20);
            this.maximoText.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nueva pieza";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(211, 289);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 26);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(71, 289);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 26);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Volver";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tipoPiezaText
            // 
            this.tipoPiezaText.Location = new System.Drawing.Point(172, 235);
            this.tipoPiezaText.Name = "tipoPiezaText";
            this.tipoPiezaText.Size = new System.Drawing.Size(121, 20);
            this.tipoPiezaText.TabIndex = 6;
            // 
            // AgregarPieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 338);
            this.Controls.Add(this.tipoPiezaText);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maximoText);
            this.Controls.Add(this.minimoText);
            this.Controls.Add(this.precisionText);
            this.Controls.Add(this.tipoPiezaCombo);
            this.Controls.Add(this.modeloText);
            this.Controls.Add(this.marcaText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarPieza";
            this.Text = "Agregar pieza";
            this.Load += new System.EventHandler(this.AgregarPieza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox marcaText;
        private System.Windows.Forms.TextBox modeloText;
        private System.Windows.Forms.ComboBox tipoPiezaCombo;
        private System.Windows.Forms.TextBox precisionText;
        private System.Windows.Forms.TextBox minimoText;
        private System.Windows.Forms.TextBox maximoText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tipoPiezaText;
    }
}