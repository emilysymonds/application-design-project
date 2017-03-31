namespace WindowsFormsApplication1
{
    partial class VerComponente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerComponente));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.piezaslistBox = new System.Windows.Forms.ListBox();
            this.volverButton = new System.Windows.Forms.Button();
            this.marcalabel = new System.Windows.Forms.Label();
            this.modelolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(176, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Modelo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Marca:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Compuesto por:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // piezaslistBox
            // 
            this.piezaslistBox.FormattingEnabled = true;
            this.piezaslistBox.HorizontalScrollbar = true;
            this.piezaslistBox.Location = new System.Drawing.Point(13, 91);
            this.piezaslistBox.Name = "piezaslistBox";
            this.piezaslistBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.piezaslistBox.ScrollAlwaysVisible = true;
            this.piezaslistBox.Size = new System.Drawing.Size(332, 134);
            this.piezaslistBox.TabIndex = 29;
            // 
            // volverButton
            // 
            this.volverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverButton.Location = new System.Drawing.Point(12, 235);
            this.volverButton.Name = "volverButton";
            this.volverButton.Size = new System.Drawing.Size(88, 26);
            this.volverButton.TabIndex = 32;
            this.volverButton.Text = "Volver";
            this.volverButton.UseVisualStyleBackColor = true;
            this.volverButton.Click += new System.EventHandler(this.volverButton_Click);
            // 
            // marcalabel
            // 
            this.marcalabel.AutoSize = true;
            this.marcalabel.Location = new System.Drawing.Point(73, 16);
            this.marcalabel.Name = "marcalabel";
            this.marcalabel.Size = new System.Drawing.Size(36, 13);
            this.marcalabel.TabIndex = 33;
            this.marcalabel.Text = "marca";
            // 
            // modelolabel
            // 
            this.modelolabel.AutoSize = true;
            this.modelolabel.Location = new System.Drawing.Point(247, 16);
            this.modelolabel.Name = "modelolabel";
            this.modelolabel.Size = new System.Drawing.Size(41, 13);
            this.modelolabel.TabIndex = 34;
            this.modelolabel.Text = "modelo";
            // 
            // VerComponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 273);
            this.Controls.Add(this.modelolabel);
            this.Controls.Add(this.marcalabel);
            this.Controls.Add(this.volverButton);
            this.Controls.Add(this.piezaslistBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerComponente";
            this.Text = "Ver Componente";
            this.Load += new System.EventHandler(this.VerComponente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox piezaslistBox;
        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.Label marcalabel;
        private System.Windows.Forms.Label modelolabel;

    }
}