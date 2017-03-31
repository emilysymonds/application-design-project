namespace WindowsFormsApplication1
{
    partial class ConsolaAdministrativa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsolaAdministrativa));
            this.label1 = new System.Windows.Forms.Label();
            this.volverButton = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.verPanel = new System.Windows.Forms.Button();
            this.sim100 = new System.Windows.Forms.Label();
            this.sim2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Componentes del dron:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // volverButton
            // 
            this.volverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverButton.Location = new System.Drawing.Point(12, 319);
            this.volverButton.Name = "volverButton";
            this.volverButton.Size = new System.Drawing.Size(88, 26);
            this.volverButton.TabIndex = 199;
            this.volverButton.Text = "Volver";
            this.volverButton.UseVisualStyleBackColor = true;
            this.volverButton.Click += new System.EventHandler(this.volverButton_Click);
            // 
            // modificar
            // 
            this.modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar.Location = new System.Drawing.Point(460, 347);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(88, 26);
            this.modificar.TabIndex = 201;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Valores actuales:";
            // 
            // verPanel
            // 
            this.verPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verPanel.Location = new System.Drawing.Point(460, 315);
            this.verPanel.Name = "verPanel";
            this.verPanel.Size = new System.Drawing.Size(88, 26);
            this.verPanel.TabIndex = 200;
            this.verPanel.Text = "Ver Panel";
            this.verPanel.UseVisualStyleBackColor = true;
            this.verPanel.Click += new System.EventHandler(this.verPanel_Click);
            // 
            // sim100
            // 
            this.sim100.AutoSize = true;
            this.sim100.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sim100.Location = new System.Drawing.Point(12, 358);
            this.sim100.Name = "sim100";
            this.sim100.Size = new System.Drawing.Size(229, 15);
            this.sim100.TabIndex = 37;
            this.sim100.Text = "*Simulación automática de 76 segundos";
            // 
            // sim2
            // 
            this.sim2.AutoSize = true;
            this.sim2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sim2.Location = new System.Drawing.Point(12, 358);
            this.sim2.Name = "sim2";
            this.sim2.Size = new System.Drawing.Size(229, 15);
            this.sim2.TabIndex = 38;
            this.sim2.Text = "*Simulación automática de 44 segundos";
            // 
            // ConsolaAdministrativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 382);
            this.Controls.Add(this.sim2);
            this.Controls.Add(this.sim100);
            this.Controls.Add(this.verPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.volverButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsolaAdministrativa";
            this.Text = "Consola Administrativa";
            this.Load += new System.EventHandler(this.ConsolaAdministrativa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button verPanel;
        private System.Windows.Forms.Label sim100;
        private System.Windows.Forms.Label sim2;
    }
}