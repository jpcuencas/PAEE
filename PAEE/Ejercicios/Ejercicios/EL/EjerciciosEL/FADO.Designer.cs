namespace EjerciciosADO
{
    partial class FAdo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAdo));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Resultados = new System.Windows.Forms.ColumnHeader();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnELDataSet = new System.Windows.Forms.Button();
            this.btnELDDL = new System.Windows.Forms.Button();
            this.btnELEscalar = new System.Windows.Forms.Button();
            this.btnELDataReader = new System.Windows.Forms.Button();
            this.btnELCallSP = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(644, 206);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grid";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 198);
            this.dataGridView1.TabIndex = 0;
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
            this.label2.Text = "Ejercicios ADO .NET (DA Application Block)";
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
            this.groupBox3.Controls.Add(this.btnELDataSet);
            this.groupBox3.Controls.Add(this.btnELDDL);
            this.groupBox3.Controls.Add(this.btnELEscalar);
            this.groupBox3.Controls.Add(this.btnELDataReader);
            this.groupBox3.Controls.Add(this.btnELCallSP);
            this.groupBox3.Location = new System.Drawing.Point(12, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 51);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enterprise Library";
            // 
            // btnELDataSet
            // 
            this.btnELDataSet.Location = new System.Drawing.Point(357, 18);
            this.btnELDataSet.Name = "btnELDataSet";
            this.btnELDataSet.Size = new System.Drawing.Size(123, 26);
            this.btnELDataSet.TabIndex = 5;
            this.btnELDataSet.Text = "Consulta DataSet";
            this.btnELDataSet.UseVisualStyleBackColor = true;
            this.btnELDataSet.Click += new System.EventHandler(this.btnELDataSet_Click);
            // 
            // btnELDDL
            // 
            this.btnELDDL.Location = new System.Drawing.Point(6, 18);
            this.btnELDDL.Name = "btnELDDL";
            this.btnELDDL.Size = new System.Drawing.Size(107, 26);
            this.btnELDDL.TabIndex = 4;
            this.btnELDDL.Text = "Consulta Update";
            this.btnELDDL.UseVisualStyleBackColor = true;
            this.btnELDDL.Click += new System.EventHandler(this.btnELDDL_Click);
            // 
            // btnELEscalar
            // 
            this.btnELEscalar.Location = new System.Drawing.Point(119, 18);
            this.btnELEscalar.Name = "btnELEscalar";
            this.btnELEscalar.Size = new System.Drawing.Size(119, 26);
            this.btnELEscalar.TabIndex = 3;
            this.btnELEscalar.Text = "Consulta de valor escalar";
            this.btnELEscalar.UseVisualStyleBackColor = true;
            this.btnELEscalar.Click += new System.EventHandler(this.btnELEscalar_Click);
            // 
            // btnELDataReader
            // 
            this.btnELDataReader.Location = new System.Drawing.Point(244, 18);
            this.btnELDataReader.Name = "btnELDataReader";
            this.btnELDataReader.Size = new System.Drawing.Size(107, 26);
            this.btnELDataReader.TabIndex = 2;
            this.btnELDataReader.Text = "Consulta DataReader";
            this.btnELDataReader.UseVisualStyleBackColor = true;
            this.btnELDataReader.Click += new System.EventHandler(this.btnELDataReader_Click);
            // 
            // btnELCallSP
            // 
            this.btnELCallSP.Location = new System.Drawing.Point(486, 18);
            this.btnELCallSP.Name = "btnELCallSP";
            this.btnELCallSP.Size = new System.Drawing.Size(168, 26);
            this.btnELCallSP.TabIndex = 1;
            this.btnELCallSP.Text = "Llamada a Procedimiento Almacenado";
            this.btnELCallSP.UseVisualStyleBackColor = true;
            this.btnELCallSP.Click += new System.EventHandler(this.btnELCallSP_Click);
            // 
            // FAdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 367);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Name = "FAdo";
            this.Text = "Formulario ejercicios ADO";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnELDataSet;
        private System.Windows.Forms.Button btnELDDL;
        private System.Windows.Forms.Button btnELEscalar;
        private System.Windows.Forms.Button btnELDataReader;
        private System.Windows.Forms.Button btnELCallSP;
    }
}

