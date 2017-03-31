namespace WindowsFormsApplication1
{
    partial class AgregarComp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarComp));
            this.titulolabel = new System.Windows.Forms.Label();
            this.complistBox = new System.Windows.Forms.ListBox();
            this.piezaslistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.crearButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.marcaText = new System.Windows.Forms.TextBox();
            this.modeloText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nuevolistBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.deletebutton1 = new System.Windows.Forms.Button();
            this.agregarCompButton = new System.Windows.Forms.Button();
            this.agregarPiezasbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulolabel
            // 
            this.titulolabel.AutoSize = true;
            this.titulolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.titulolabel.Location = new System.Drawing.Point(12, 45);
            this.titulolabel.Name = "titulolabel";
            this.titulolabel.Size = new System.Drawing.Size(338, 34);
            this.titulolabel.TabIndex = 11;
            this.titulolabel.Text = "Seleccione las piezas o componentes \r\nque formarán el nuevo componente reusable:";
            this.titulolabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // complistBox
            // 
            this.complistBox.FormattingEnabled = true;
            this.complistBox.HorizontalScrollbar = true;
            this.complistBox.Location = new System.Drawing.Point(12, 272);
            this.complistBox.Name = "complistBox";
            this.complistBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.complistBox.ScrollAlwaysVisible = true;
            this.complistBox.Size = new System.Drawing.Size(332, 134);
            this.complistBox.TabIndex = 12;
            // 
            // piezaslistBox
            // 
            this.piezaslistBox.FormattingEnabled = true;
            this.piezaslistBox.HorizontalScrollbar = true;
            this.piezaslistBox.Location = new System.Drawing.Point(12, 114);
            this.piezaslistBox.Name = "piezaslistBox";
            this.piezaslistBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.piezaslistBox.ScrollAlwaysVisible = true;
            this.piezaslistBox.Size = new System.Drawing.Size(332, 134);
            this.piezaslistBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Piezas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Componentes:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // crearButton
            // 
            this.crearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearButton.Location = new System.Drawing.Point(656, 412);
            this.crearButton.Name = "crearButton";
            this.crearButton.Size = new System.Drawing.Size(88, 26);
            this.crearButton.TabIndex = 18;
            this.crearButton.Text = "Crear\r\n";
            this.crearButton.UseVisualStyleBackColor = true;
            this.crearButton.Click += new System.EventHandler(this.crearButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Marca:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(175, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Modelo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // marcaText
            // 
            this.marcaText.Location = new System.Drawing.Point(72, 9);
            this.marcaText.Name = "marcaText";
            this.marcaText.Size = new System.Drawing.Size(97, 20);
            this.marcaText.TabIndex = 21;
            // 
            // modeloText
            // 
            this.modeloText.Location = new System.Drawing.Point(247, 9);
            this.modeloText.Name = "modeloText";
            this.modeloText.Size = new System.Drawing.Size(97, 20);
            this.modeloText.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(409, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nuevo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nuevolistBox
            // 
            this.nuevolistBox.FormattingEnabled = true;
            this.nuevolistBox.HorizontalScrollbar = true;
            this.nuevolistBox.Location = new System.Drawing.Point(412, 171);
            this.nuevolistBox.Name = "nuevolistBox";
            this.nuevolistBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nuevolistBox.ScrollAlwaysVisible = true;
            this.nuevolistBox.Size = new System.Drawing.Size(332, 134);
            this.nuevolistBox.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 26);
            this.button1.TabIndex = 26;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deletebutton1
            // 
            this.deletebutton1.Image = global::WindowsFormsApplication1.Properties.Resources._1411979194_Delete;
            this.deletebutton1.Location = new System.Drawing.Point(750, 171);
            this.deletebutton1.Name = "deletebutton1";
            this.deletebutton1.Size = new System.Drawing.Size(38, 33);
            this.deletebutton1.TabIndex = 25;
            this.deletebutton1.UseVisualStyleBackColor = true;
            this.deletebutton1.Click += new System.EventHandler(this.deletebutton1_Click);
            // 
            // agregarCompButton
            // 
            this.agregarCompButton.Image = global::WindowsFormsApplication1.Properties.Resources._1411978217_Add;
            this.agregarCompButton.Location = new System.Drawing.Point(350, 272);
            this.agregarCompButton.Name = "agregarCompButton";
            this.agregarCompButton.Size = new System.Drawing.Size(38, 33);
            this.agregarCompButton.TabIndex = 17;
            this.agregarCompButton.UseVisualStyleBackColor = true;
            this.agregarCompButton.Click += new System.EventHandler(this.agregarCompButton_Click);
            // 
            // agregarPiezasbutton
            // 
            this.agregarPiezasbutton.Image = global::WindowsFormsApplication1.Properties.Resources._1411978217_Add;
            this.agregarPiezasbutton.Location = new System.Drawing.Point(350, 114);
            this.agregarPiezasbutton.Name = "agregarPiezasbutton";
            this.agregarPiezasbutton.Size = new System.Drawing.Size(38, 33);
            this.agregarPiezasbutton.TabIndex = 16;
            this.agregarPiezasbutton.UseVisualStyleBackColor = true;
            this.agregarPiezasbutton.Click += new System.EventHandler(this.agregarPiezasbutton_Click);
            // 
            // AgregarComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deletebutton1);
            this.Controls.Add(this.nuevolistBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.modeloText);
            this.Controls.Add(this.marcaText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.crearButton);
            this.Controls.Add(this.agregarCompButton);
            this.Controls.Add(this.agregarPiezasbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.piezaslistBox);
            this.Controls.Add(this.complistBox);
            this.Controls.Add(this.titulolabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarComp";
            this.Text = "Agregar Componente";
            this.Load += new System.EventHandler(this.AgregarComp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulolabel;
        private System.Windows.Forms.ListBox complistBox;
        private System.Windows.Forms.ListBox piezaslistBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button agregarPiezasbutton;
        private System.Windows.Forms.Button agregarCompButton;
        private System.Windows.Forms.Button crearButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox marcaText;
        private System.Windows.Forms.TextBox modeloText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox nuevolistBox;
        private System.Windows.Forms.Button deletebutton1;
        private System.Windows.Forms.Button button1;
    }
}