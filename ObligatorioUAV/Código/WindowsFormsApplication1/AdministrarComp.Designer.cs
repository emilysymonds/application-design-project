namespace WindowsFormsApplication1
{
    partial class AdministrarComp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarComp));
            this.complistBox = new System.Windows.Forms.ListBox();
            this.volverbutton1 = new System.Windows.Forms.Button();
            this.titulolabel1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.eliminarbutton1 = new System.Windows.Forms.Button();
            this.modificarbutton1 = new System.Windows.Forms.Button();
            this.agregarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // complistBox
            // 
            this.complistBox.FormattingEnabled = true;
            this.complistBox.HorizontalScrollbar = true;
            this.complistBox.Location = new System.Drawing.Point(21, 40);
            this.complistBox.Name = "complistBox";
            this.complistBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.complistBox.ScrollAlwaysVisible = true;
            this.complistBox.Size = new System.Drawing.Size(332, 199);
            this.complistBox.TabIndex = 1;
            // 
            // volverbutton1
            // 
            this.volverbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverbutton1.Location = new System.Drawing.Point(21, 245);
            this.volverbutton1.Name = "volverbutton1";
            this.volverbutton1.Size = new System.Drawing.Size(88, 26);
            this.volverbutton1.TabIndex = 13;
            this.volverbutton1.Text = "Volver";
            this.volverbutton1.UseVisualStyleBackColor = true;
            this.volverbutton1.Click += new System.EventHandler(this.volverbutton1_Click);
            // 
            // titulolabel1
            // 
            this.titulolabel1.AutoSize = true;
            this.titulolabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.titulolabel1.Location = new System.Drawing.Point(18, 14);
            this.titulolabel1.Name = "titulolabel1";
            this.titulolabel1.Size = new System.Drawing.Size(243, 17);
            this.titulolabel1.TabIndex = 10;
            this.titulolabel1.Text = "Lista de componentes reusables";
            // 
            // button2
            // 
            this.button2.Image = global::WindowsFormsApplication1.Properties.Resources._1411981930_Synchronize;
            this.button2.Location = new System.Drawing.Point(359, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 34);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources._1411981572_Search;
            this.button1.Location = new System.Drawing.Point(359, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // eliminarbutton1
            // 
            this.eliminarbutton1.Image = global::WindowsFormsApplication1.Properties.Resources._1411979194_Delete;
            this.eliminarbutton1.Location = new System.Drawing.Point(359, 120);
            this.eliminarbutton1.Name = "eliminarbutton1";
            this.eliminarbutton1.Size = new System.Drawing.Size(34, 34);
            this.eliminarbutton1.TabIndex = 12;
            this.eliminarbutton1.UseVisualStyleBackColor = true;
            this.eliminarbutton1.Click += new System.EventHandler(this.eliminarbutton1_Click);
            // 
            // modificarbutton1
            // 
            this.modificarbutton1.Image = global::WindowsFormsApplication1.Properties.Resources._1411979916_Pencil_24;
            this.modificarbutton1.Location = new System.Drawing.Point(359, 80);
            this.modificarbutton1.Name = "modificarbutton1";
            this.modificarbutton1.Size = new System.Drawing.Size(34, 34);
            this.modificarbutton1.TabIndex = 11;
            this.modificarbutton1.UseVisualStyleBackColor = true;
            this.modificarbutton1.Click += new System.EventHandler(this.modificarbutton1_Click);
            // 
            // agregarbutton
            // 
            this.agregarbutton.Image = global::WindowsFormsApplication1.Properties.Resources._1411978217_Add;
            this.agregarbutton.Location = new System.Drawing.Point(359, 40);
            this.agregarbutton.Name = "agregarbutton";
            this.agregarbutton.Size = new System.Drawing.Size(34, 34);
            this.agregarbutton.TabIndex = 9;
            this.agregarbutton.UseVisualStyleBackColor = true;
            this.agregarbutton.Click += new System.EventHandler(this.agregarbutton_Click);
            // 
            // AdministrarComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 277);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.volverbutton1);
            this.Controls.Add(this.eliminarbutton1);
            this.Controls.Add(this.modificarbutton1);
            this.Controls.Add(this.titulolabel1);
            this.Controls.Add(this.agregarbutton);
            this.Controls.Add(this.complistBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministrarComp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrar Componentes";
            this.Load += new System.EventHandler(this.AdministrarComp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox complistBox;
        private System.Windows.Forms.Button volverbutton1;
        private System.Windows.Forms.Button eliminarbutton1;
        private System.Windows.Forms.Button modificarbutton1;
        private System.Windows.Forms.Label titulolabel1;
        private System.Windows.Forms.Button agregarbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}