namespace Entity
{
    partial class FEntity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEntity));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Resultados = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSelUser = new System.Windows.Forms.Button();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.btnUptUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 130);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 232);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(644, 206);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Resultados";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Resultados});
            this.listView1.Location = new System.Drawing.Point(3, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(635, 197);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Resultados
            // 
            this.Resultados.Text = "Resultados";
            this.Resultados.Width = 629;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.logoPictureBox);
            this.groupBox2.Location = new System.Drawing.Point(0, -5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 68);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(531, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ejercicios Entity Framework";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logoPictureBox.Location = new System.Drawing.Point(608, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(69, 50);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSelUser);
            this.groupBox3.Controls.Add(this.btnDelUser);
            this.groupBox3.Controls.Add(this.btnUptUser);
            this.groupBox3.Controls.Add(this.btnAddUser);
            this.groupBox3.Location = new System.Drawing.Point(12, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(648, 51);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enterprise Library";
            // 
            // btnSelUser
            // 
            this.btnSelUser.Location = new System.Drawing.Point(491, 19);
            this.btnSelUser.Name = "btnSelUser";
            this.btnSelUser.Size = new System.Drawing.Size(137, 23);
            this.btnSelUser.TabIndex = 3;
            this.btnSelUser.Text = "Obtener usuario";
            this.btnSelUser.UseVisualStyleBackColor = true;
            this.btnSelUser.Click += new System.EventHandler(this.btnSelUser_Click);
            // 
            // btnDelUser
            // 
            this.btnDelUser.Location = new System.Drawing.Point(327, 19);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(137, 23);
            this.btnDelUser.TabIndex = 2;
            this.btnDelUser.Text = "Borrar usuario";
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // btnUptUser
            // 
            this.btnUptUser.Location = new System.Drawing.Point(163, 19);
            this.btnUptUser.Name = "btnUptUser";
            this.btnUptUser.Size = new System.Drawing.Size(137, 23);
            this.btnUptUser.TabIndex = 1;
            this.btnUptUser.Text = "Actualizar usuario";
            this.btnUptUser.UseVisualStyleBackColor = true;
            this.btnUptUser.Click += new System.EventHandler(this.btnUptUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(7, 19);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(137, 23);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Agregar usuario";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // FNHibernate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 367);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Name = "FNHibernate";
            this.Text = "Formulario ejercicios Entity Framework";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Resultados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSelUser;
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.Button btnUptUser;
        private System.Windows.Forms.Button btnAddUser;
    }
}

