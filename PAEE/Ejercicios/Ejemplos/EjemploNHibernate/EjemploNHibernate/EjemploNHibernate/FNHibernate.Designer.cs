namespace EjemploNHibernate
{
    partial class FNHibernate
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FNHibernate));
            this.AddActor = new System.Windows.Forms.Button();
            this.UpdateActor = new System.Windows.Forms.Button();
            this.SelectAllActores = new System.Windows.Forms.Button();
            this.listaResultados = new System.Windows.Forms.ListView();
            this.Resultados = new System.Windows.Forms.ColumnHeader();
            this.SelectFilterActores = new System.Windows.Forms.Button();
            this.DeleteActor = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddActor
            // 
            this.AddActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddActor.Location = new System.Drawing.Point(6, 19);
            this.AddActor.Name = "AddActor";
            this.AddActor.Size = new System.Drawing.Size(195, 46);
            this.AddActor.TabIndex = 0;
            this.AddActor.Text = "Insertar un nuevo Actor";
            this.AddActor.UseVisualStyleBackColor = true;
            this.AddActor.Click += new System.EventHandler(this.AddActor_Click);
            // 
            // UpdateActor
            // 
            this.UpdateActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateActor.Location = new System.Drawing.Point(6, 121);
            this.UpdateActor.Name = "UpdateActor";
            this.UpdateActor.Size = new System.Drawing.Size(195, 48);
            this.UpdateActor.TabIndex = 1;
            this.UpdateActor.Text = "Actualizar los datos de un Actor";
            this.UpdateActor.UseVisualStyleBackColor = true;
            this.UpdateActor.Click += new System.EventHandler(this.UpdateActor_Click);
            // 
            // SelectAllActores
            // 
            this.SelectAllActores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectAllActores.Location = new System.Drawing.Point(6, 10);
            this.SelectAllActores.Name = "SelectAllActores";
            this.SelectAllActores.Size = new System.Drawing.Size(183, 47);
            this.SelectAllActores.TabIndex = 2;
            this.SelectAllActores.Text = "Obtener Todos los Actores";
            this.SelectAllActores.UseVisualStyleBackColor = true;
            this.SelectAllActores.Click += new System.EventHandler(this.SelectAllActores_Click);
            // 
            // listaResultados
            // 
            this.listaResultados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Resultados});
            this.listaResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaResultados.GridLines = true;
            this.listaResultados.Location = new System.Drawing.Point(216, 78);
            this.listaResultados.Name = "listaResultados";
            this.listaResultados.Size = new System.Drawing.Size(459, 175);
            this.listaResultados.TabIndex = 3;
            this.listaResultados.UseCompatibleStateImageBehavior = false;
            this.listaResultados.View = System.Windows.Forms.View.Details;
            // 
            // Resultados
            // 
            this.Resultados.Text = "Resultados";
            this.Resultados.Width = 447;
            // 
            // SelectFilterActores
            // 
            this.SelectFilterActores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFilterActores.Location = new System.Drawing.Point(195, 12);
            this.SelectFilterActores.Name = "SelectFilterActores";
            this.SelectFilterActores.Size = new System.Drawing.Size(183, 45);
            this.SelectFilterActores.TabIndex = 4;
            this.SelectFilterActores.Text = "Obtener los actores con filtro";
            this.SelectFilterActores.UseVisualStyleBackColor = true;
            this.SelectFilterActores.Click += new System.EventHandler(this.SelectFilterActores_Click);
            // 
            // DeleteActor
            // 
            this.DeleteActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteActor.Location = new System.Drawing.Point(6, 70);
            this.DeleteActor.Name = "DeleteActor";
            this.DeleteActor.Size = new System.Drawing.Size(195, 46);
            this.DeleteActor.TabIndex = 5;
            this.DeleteActor.Text = "Borrar un Actor existente";
            this.DeleteActor.UseVisualStyleBackColor = true;
            this.DeleteActor.Click += new System.EventHandler(this.DeleteActor_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logoPictureBox.Location = new System.Drawing.Point(598, 10);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(69, 50);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.Titulo);
            this.groupBox2.Controls.Add(this.logoPictureBox);
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 68);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // Titulo
            // 
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Titulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Titulo.Location = new System.Drawing.Point(18, 23);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(254, 27);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Ejemplos de NHibernate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddActor);
            this.groupBox1.Controls.Add(this.UpdateActor);
            this.groupBox1.Controls.Add(this.DeleteActor);
            this.groupBox1.Location = new System.Drawing.Point(3, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 182);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Cerrar);
            this.groupBox3.Controls.Add(this.SelectAllActores);
            this.groupBox3.Controls.Add(this.SelectFilterActores);
            this.groupBox3.Location = new System.Drawing.Point(3, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(672, 63);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.Location = new System.Drawing.Point(483, 12);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(183, 45);
            this.Cerrar.TabIndex = 31;
            this.Cerrar.Text = "Cerrar formulario";
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // FNHibernate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 319);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listaResultados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FNHibernate";
            this.Text = "Ejemplos de NHibernate";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddActor;
        private System.Windows.Forms.Button UpdateActor;
        private System.Windows.Forms.Button SelectAllActores;
        private System.Windows.Forms.ListView listaResultados;
        private System.Windows.Forms.ColumnHeader Resultados;
        private System.Windows.Forms.Button SelectFilterActores;
        private System.Windows.Forms.Button DeleteActor;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Cerrar;
    }
}

