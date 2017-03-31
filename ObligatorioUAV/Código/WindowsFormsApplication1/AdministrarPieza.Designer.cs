namespace WindowsFormsApplication1
{
    partial class AdministrarPieza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarPieza));
            this.piezaslistBox = new System.Windows.Forms.ListBox();
            this.titulolabel1 = new System.Windows.Forms.Label();
            this.volverbutton1 = new System.Windows.Forms.Button();
            this.refreshbutton = new System.Windows.Forms.Button();
            this.elimiarbutton = new System.Windows.Forms.Button();
            this.editarbutton = new System.Windows.Forms.Button();
            this.agregarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // piezaslistBox
            // 
            this.piezaslistBox.FormattingEnabled = true;
            this.piezaslistBox.HorizontalScrollbar = true;
            this.piezaslistBox.Location = new System.Drawing.Point(21, 40);
            this.piezaslistBox.Name = "piezaslistBox";
            this.piezaslistBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.piezaslistBox.ScrollAlwaysVisible = true;
            this.piezaslistBox.Size = new System.Drawing.Size(332, 160);
            this.piezaslistBox.TabIndex = 0;
            // 
            // titulolabel1
            // 
            this.titulolabel1.AutoSize = true;
            this.titulolabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.titulolabel1.Location = new System.Drawing.Point(18, 14);
            this.titulolabel1.Name = "titulolabel1";
            this.titulolabel1.Size = new System.Drawing.Size(118, 17);
            this.titulolabel1.TabIndex = 4;
            this.titulolabel1.Text = "Lista de piezas";
            // 
            // volverbutton1
            // 
            this.volverbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.volverbutton1.Location = new System.Drawing.Point(21, 207);
            this.volverbutton1.Name = "volverbutton1";
            this.volverbutton1.Size = new System.Drawing.Size(88, 26);
            this.volverbutton1.TabIndex = 7;
            this.volverbutton1.Text = "Volver";
            this.volverbutton1.UseVisualStyleBackColor = true;
            this.volverbutton1.Click += new System.EventHandler(this.volverbutton1_Click);
            // 
            // refreshbutton
            // 
            this.refreshbutton.Image = global::WindowsFormsApplication1.Properties.Resources._1411981930_Synchronize;
            this.refreshbutton.Location = new System.Drawing.Point(360, 160);
            this.refreshbutton.Name = "refreshbutton";
            this.refreshbutton.Size = new System.Drawing.Size(43, 34);
            this.refreshbutton.TabIndex = 21;
            this.refreshbutton.UseVisualStyleBackColor = true;
            this.refreshbutton.Click += new System.EventHandler(this.refreshbutton_Click);
            // 
            // elimiarbutton
            // 
            this.elimiarbutton.Image = global::WindowsFormsApplication1.Properties.Resources._1411979194_Delete;
            this.elimiarbutton.Location = new System.Drawing.Point(360, 120);
            this.elimiarbutton.Name = "elimiarbutton";
            this.elimiarbutton.Size = new System.Drawing.Size(43, 34);
            this.elimiarbutton.TabIndex = 19;
            this.elimiarbutton.UseVisualStyleBackColor = true;
            this.elimiarbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // editarbutton
            // 
            this.editarbutton.Image = global::WindowsFormsApplication1.Properties.Resources._1411979916_Pencil_24;
            this.editarbutton.Location = new System.Drawing.Point(359, 80);
            this.editarbutton.Name = "editarbutton";
            this.editarbutton.Size = new System.Drawing.Size(43, 34);
            this.editarbutton.TabIndex = 18;
            this.editarbutton.UseVisualStyleBackColor = true;
            this.editarbutton.Click += new System.EventHandler(this.editarbutton_Click);
            // 
            // agregarbutton
            // 
            this.agregarbutton.Image = global::WindowsFormsApplication1.Properties.Resources._1411978217_Add;
            this.agregarbutton.Location = new System.Drawing.Point(360, 40);
            this.agregarbutton.Name = "agregarbutton";
            this.agregarbutton.Size = new System.Drawing.Size(43, 34);
            this.agregarbutton.TabIndex = 17;
            this.agregarbutton.UseVisualStyleBackColor = true;
            this.agregarbutton.Click += new System.EventHandler(this.button5_Click);
            // 
            // AdministrarPieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 242);
            this.Controls.Add(this.refreshbutton);
            this.Controls.Add(this.elimiarbutton);
            this.Controls.Add(this.editarbutton);
            this.Controls.Add(this.agregarbutton);
            this.Controls.Add(this.volverbutton1);
            this.Controls.Add(this.titulolabel1);
            this.Controls.Add(this.piezaslistBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministrarPieza";
            this.Text = "Administrar Piezas";
            this.Load += new System.EventHandler(this.AdministrarPieza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox piezaslistBox;
        private System.Windows.Forms.Label titulolabel1;
        private System.Windows.Forms.Button volverbutton1;
        private System.Windows.Forms.Button refreshbutton;
        private System.Windows.Forms.Button elimiarbutton;
        private System.Windows.Forms.Button editarbutton;
        private System.Windows.Forms.Button agregarbutton;
    }
}