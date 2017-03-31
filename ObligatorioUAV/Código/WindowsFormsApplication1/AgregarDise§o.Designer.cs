namespace WindowsFormsApplication1
{

    partial class AgregarDiseño
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarDiseño));
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.piezasListBox = new System.Windows.Forms.ListBox();
            this.compListBox = new System.Windows.Forms.ListBox();
            this.btnAgregarPieza = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAgregarComp = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.utilizarList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnQuitar2 = new System.Windows.Forms.Button();
            this.utilizarBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(329, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nuevo diseño";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(33, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lista de piezas disponibles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(33, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Lista de componentes disponibles:";
            // 
            // piezasListBox
            // 
            this.piezasListBox.FormattingEnabled = true;
            this.piezasListBox.HorizontalScrollbar = true;
            this.piezasListBox.Location = new System.Drawing.Point(36, 110);
            this.piezasListBox.Name = "piezasListBox";
            this.piezasListBox.ScrollAlwaysVisible = true;
            this.piezasListBox.Size = new System.Drawing.Size(291, 108);
            this.piezasListBox.TabIndex = 18;
            // 
            // compListBox
            // 
            this.compListBox.FormattingEnabled = true;
            this.compListBox.HorizontalScrollbar = true;
            this.compListBox.Location = new System.Drawing.Point(36, 250);
            this.compListBox.Name = "compListBox";
            this.compListBox.ScrollAlwaysVisible = true;
            this.compListBox.Size = new System.Drawing.Size(291, 108);
            this.compListBox.TabIndex = 19;
            // 
            // btnAgregarPieza
            // 
            this.btnAgregarPieza.Image = global::WindowsFormsApplication1.Properties.Resources._1411978217_Add;
            this.btnAgregarPieza.Location = new System.Drawing.Point(333, 110);
            this.btnAgregarPieza.Name = "btnAgregarPieza";
            this.btnAgregarPieza.Size = new System.Drawing.Size(34, 34);
            this.btnAgregarPieza.TabIndex = 20;
            this.btnAgregarPieza.UseVisualStyleBackColor = true;
            this.btnAgregarPieza.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(36, 374);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(88, 26);
            this.btnAtras.TabIndex = 21;
            this.btnAtras.Text = "Cancelar";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAgregarComp
            // 
            this.btnAgregarComp.Image = global::WindowsFormsApplication1.Properties.Resources._1411978217_Add;
            this.btnAgregarComp.Location = new System.Drawing.Point(333, 250);
            this.btnAgregarComp.Name = "btnAgregarComp";
            this.btnAgregarComp.Size = new System.Drawing.Size(34, 34);
            this.btnAgregarComp.TabIndex = 22;
            this.btnAgregarComp.UseVisualStyleBackColor = true;
            this.btnAgregarComp.Click += new System.EventHandler(this.btnAgregarComp_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Image = global::WindowsFormsApplication1.Properties.Resources._1411979194_Delete;
            this.btnQuitar.Location = new System.Drawing.Point(729, 110);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(34, 34);
            this.btnQuitar.TabIndex = 27;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // utilizarList
            // 
            this.utilizarList.FormattingEnabled = true;
            this.utilizarList.HorizontalScrollbar = true;
            this.utilizarList.Location = new System.Drawing.Point(446, 110);
            this.utilizarList.Name = "utilizarList";
            this.utilizarList.ScrollAlwaysVisible = true;
            this.utilizarList.Size = new System.Drawing.Size(277, 108);
            this.utilizarList.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(443, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Lista de piezas a utilizar:";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(675, 373);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 26);
            this.button4.TabIndex = 29;
            this.button4.Text = "Continuar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnQuitar2
            // 
            this.btnQuitar2.Image = global::WindowsFormsApplication1.Properties.Resources._1411979194_Delete;
            this.btnQuitar2.Location = new System.Drawing.Point(729, 250);
            this.btnQuitar2.Name = "btnQuitar2";
            this.btnQuitar2.Size = new System.Drawing.Size(34, 34);
            this.btnQuitar2.TabIndex = 32;
            this.btnQuitar2.UseVisualStyleBackColor = true;
            this.btnQuitar2.Click += new System.EventHandler(this.btnQuitar2_Click);
            // 
            // utilizarBox2
            // 
            this.utilizarBox2.FormattingEnabled = true;
            this.utilizarBox2.HorizontalScrollbar = true;
            this.utilizarBox2.Location = new System.Drawing.Point(446, 250);
            this.utilizarBox2.Name = "utilizarBox2";
            this.utilizarBox2.ScrollAlwaysVisible = true;
            this.utilizarBox2.Size = new System.Drawing.Size(277, 108);
            this.utilizarBox2.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(443, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Lista de componentes a utilizar:";
            // 
            // AgregarDiseño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 408);
            this.Controls.Add(this.btnQuitar2);
            this.Controls.Add(this.utilizarBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.utilizarList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgregarComp);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAgregarPieza);
            this.Controls.Add(this.compListBox);
            this.Controls.Add(this.piezasListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarDiseño";
            this.Text = "Agregar diseño";
            this.Load += new System.EventHandler(this.AgregarDiseño_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox txtNombre;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.ListBox piezasListBox;

        private System.Windows.Forms.ListBox compListBox;

        private System.Windows.Forms.Button btnAgregarPieza;

        private System.Windows.Forms.Button btnAtras;

        private System.Windows.Forms.Button btnAgregarComp;

        private System.Windows.Forms.Button btnQuitar;

        private System.Windows.Forms.ListBox utilizarList;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Button btnQuitar2;

        private System.Windows.Forms.ListBox utilizarBox2;

        private System.Windows.Forms.Label label4;

    }

}