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
            this.grbSqlClient = new System.Windows.Forms.GroupBox();
            this.btnSQLDataSet = new System.Windows.Forms.Button();
            this.btnSQLDDL = new System.Windows.Forms.Button();
            this.btnSQLEscalar = new System.Windows.Forms.Button();
            this.btnSQLDataReader = new System.Windows.Forms.Button();
            this.btnSQLCallSP = new System.Windows.Forms.Button();
            this.grbOleDBClient = new System.Windows.Forms.GroupBox();
            this.btnOleDbDataset = new System.Windows.Forms.Button();
            this.btnOleDBDDL = new System.Windows.Forms.Button();
            this.btnOleDBEscalar = new System.Windows.Forms.Button();
            this.btnOleDBDataReader = new System.Windows.Forms.Button();
            this.btnOleDbCallSP = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Resultados = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLanzarTx = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.lblFilasAfectadas = new System.Windows.Forms.Label();
            this.lblnumfilafectadas = new System.Windows.Forms.Label();
            this.lblnumfilTotales = new System.Windows.Forms.Label();
            this.lblFilasTotales = new System.Windows.Forms.Label();
            this.grbSqlClient.SuspendLayout();
            this.grbOleDBClient.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSqlClient
            // 
            this.grbSqlClient.Controls.Add(this.btnSQLDataSet);
            this.grbSqlClient.Controls.Add(this.btnSQLDDL);
            this.grbSqlClient.Controls.Add(this.btnSQLEscalar);
            this.grbSqlClient.Controls.Add(this.btnSQLDataReader);
            this.grbSqlClient.Controls.Add(this.btnSQLCallSP);
            this.grbSqlClient.Location = new System.Drawing.Point(12, 69);
            this.grbSqlClient.Name = "grbSqlClient";
            this.grbSqlClient.Size = new System.Drawing.Size(665, 51);
            this.grbSqlClient.TabIndex = 2;
            this.grbSqlClient.TabStop = false;
            this.grbSqlClient.Text = "SqlClient";
            // 
            // btnSQLDataSet
            // 
            this.btnSQLDataSet.Location = new System.Drawing.Point(364, 18);
            this.btnSQLDataSet.Name = "btnSQLDataSet";
            this.btnSQLDataSet.Size = new System.Drawing.Size(123, 26);
            this.btnSQLDataSet.TabIndex = 5;
            this.btnSQLDataSet.Text = "Consulta DataSet";
            this.btnSQLDataSet.UseVisualStyleBackColor = true;
            this.btnSQLDataSet.Click += new System.EventHandler(this.btnSQLDataSet_Click);
            // 
            // btnSQLDDL
            // 
            this.btnSQLDDL.Location = new System.Drawing.Point(6, 18);
            this.btnSQLDDL.Name = "btnSQLDDL";
            this.btnSQLDDL.Size = new System.Drawing.Size(107, 26);
            this.btnSQLDDL.TabIndex = 4;
            this.btnSQLDDL.Text = "Consulta Update";
            this.btnSQLDDL.UseVisualStyleBackColor = true;
            this.btnSQLDDL.Click += new System.EventHandler(this.btnSQLDDL_Click);
            // 
            // btnSQLEscalar
            // 
            this.btnSQLEscalar.Location = new System.Drawing.Point(118, 18);
            this.btnSQLEscalar.Name = "btnSQLEscalar";
            this.btnSQLEscalar.Size = new System.Drawing.Size(119, 26);
            this.btnSQLEscalar.TabIndex = 3;
            this.btnSQLEscalar.Text = "Consulta de valor escalar";
            this.btnSQLEscalar.UseVisualStyleBackColor = true;
            this.btnSQLEscalar.Click += new System.EventHandler(this.btnSQLEscalar_Click);
            // 
            // btnSQLDataReader
            // 
            this.btnSQLDataReader.Location = new System.Drawing.Point(242, 18);
            this.btnSQLDataReader.Name = "btnSQLDataReader";
            this.btnSQLDataReader.Size = new System.Drawing.Size(117, 26);
            this.btnSQLDataReader.TabIndex = 2;
            this.btnSQLDataReader.Text = "Consulta DataReader";
            this.btnSQLDataReader.UseVisualStyleBackColor = true;
            this.btnSQLDataReader.Click += new System.EventHandler(this.btnSQLDataReader_Click);
            // 
            // btnSQLCallSP
            // 
            this.btnSQLCallSP.Location = new System.Drawing.Point(491, 18);
            this.btnSQLCallSP.Name = "btnSQLCallSP";
            this.btnSQLCallSP.Size = new System.Drawing.Size(168, 26);
            this.btnSQLCallSP.TabIndex = 1;
            this.btnSQLCallSP.Text = "Llamada a Procedimiento Almacenado";
            this.btnSQLCallSP.UseVisualStyleBackColor = true;
            this.btnSQLCallSP.Click += new System.EventHandler(this.btnSQLCallSP_Click);
            // 
            // grbOleDBClient
            // 
            this.grbOleDBClient.Controls.Add(this.btnOleDbDataset);
            this.grbOleDBClient.Controls.Add(this.btnOleDBDDL);
            this.grbOleDBClient.Controls.Add(this.btnOleDBEscalar);
            this.grbOleDBClient.Controls.Add(this.btnOleDBDataReader);
            this.grbOleDBClient.Controls.Add(this.btnOleDbCallSP);
            this.grbOleDBClient.Location = new System.Drawing.Point(12, 125);
            this.grbOleDBClient.Name = "grbOleDBClient";
            this.grbOleDBClient.Size = new System.Drawing.Size(665, 50);
            this.grbOleDBClient.TabIndex = 3;
            this.grbOleDBClient.TabStop = false;
            this.grbOleDBClient.Text = "OleDb";
            // 
            // btnOleDbDataset
            // 
            this.btnOleDbDataset.Location = new System.Drawing.Point(364, 18);
            this.btnOleDbDataset.Name = "btnOleDbDataset";
            this.btnOleDbDataset.Size = new System.Drawing.Size(123, 25);
            this.btnOleDbDataset.TabIndex = 6;
            this.btnOleDbDataset.Text = "Consulta DataSet";
            this.btnOleDbDataset.UseVisualStyleBackColor = true;
            this.btnOleDbDataset.Click += new System.EventHandler(this.btnOleDbDataset_Click);
            // 
            // btnOleDBDDL
            // 
            this.btnOleDBDDL.Location = new System.Drawing.Point(6, 18);
            this.btnOleDBDDL.Name = "btnOleDBDDL";
            this.btnOleDBDDL.Size = new System.Drawing.Size(107, 25);
            this.btnOleDBDDL.TabIndex = 4;
            this.btnOleDBDDL.Text = "Consulta Update";
            this.btnOleDBDDL.UseVisualStyleBackColor = true;
            this.btnOleDBDDL.Click += new System.EventHandler(this.btnOleDBDDL_Click);
            // 
            // btnOleDBEscalar
            // 
            this.btnOleDBEscalar.Location = new System.Drawing.Point(118, 18);
            this.btnOleDBEscalar.Name = "btnOleDBEscalar";
            this.btnOleDBEscalar.Size = new System.Drawing.Size(119, 25);
            this.btnOleDBEscalar.TabIndex = 3;
            this.btnOleDBEscalar.Text = "Consulta de valor escalar";
            this.btnOleDBEscalar.UseVisualStyleBackColor = true;
            this.btnOleDBEscalar.Click += new System.EventHandler(this.btnOleDBEscalar_Click);
            // 
            // btnOleDBDataReader
            // 
            this.btnOleDBDataReader.Location = new System.Drawing.Point(242, 18);
            this.btnOleDBDataReader.Name = "btnOleDBDataReader";
            this.btnOleDBDataReader.Size = new System.Drawing.Size(117, 25);
            this.btnOleDBDataReader.TabIndex = 2;
            this.btnOleDBDataReader.Text = "Consulta DataReader";
            this.btnOleDBDataReader.UseVisualStyleBackColor = true;
            this.btnOleDBDataReader.Click += new System.EventHandler(this.btnOleDBDataReader_Click);
            // 
            // btnOleDbCallSP
            // 
            this.btnOleDbCallSP.Location = new System.Drawing.Point(491, 18);
            this.btnOleDbCallSP.Name = "btnOleDbCallSP";
            this.btnOleDbCallSP.Size = new System.Drawing.Size(168, 25);
            this.btnOleDbCallSP.TabIndex = 1;
            this.btnOleDbCallSP.Text = "Llamada a Procedimiento Almacenado";
            this.btnOleDbCallSP.UseVisualStyleBackColor = true;
            this.btnOleDbCallSP.Click += new System.EventHandler(this.btnOleDbCallSP_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 234);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(663, 232);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(655, 206);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Resultados";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Resultados});
            this.listView1.Location = new System.Drawing.Point(3, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(645, 197);
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
            this.tabPage2.Size = new System.Drawing.Size(655, 206);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grid";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLanzarTx);
            this.groupBox1.Location = new System.Drawing.Point(14, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 47);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transacciones";
            // 
            // btnLanzarTx
            // 
            this.btnLanzarTx.Location = new System.Drawing.Point(11, 16);
            this.btnLanzarTx.Name = "btnLanzarTx";
            this.btnLanzarTx.Size = new System.Drawing.Size(641, 27);
            this.btnLanzarTx.TabIndex = 1;
            this.btnLanzarTx.Text = "Lanzar Transacción";
            this.btnLanzarTx.UseVisualStyleBackColor = true;
            this.btnLanzarTx.Click += new System.EventHandler(this.btnLanzarTx_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lblnumfilTotales);
            this.groupBox2.Controls.Add(this.lblFilasTotales);
            this.groupBox2.Controls.Add(this.lblnumfilafectadas);
            this.groupBox2.Controls.Add(this.lblFilasAfectadas);
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
            this.label2.Size = new System.Drawing.Size(231, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ejercicios ADO .NET";
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
            // lblFilasAfectadas
            // 
            this.lblFilasAfectadas.AutoSize = true;
            this.lblFilasAfectadas.Location = new System.Drawing.Point(251, 34);
            this.lblFilasAfectadas.Name = "lblFilasAfectadas";
            this.lblFilasAfectadas.Size = new System.Drawing.Size(82, 13);
            this.lblFilasAfectadas.TabIndex = 2;
            this.lblFilasAfectadas.Text = "Filas Afectadas:";
            // 
            // lblnumfilafectadas
            // 
            this.lblnumfilafectadas.AutoSize = true;
            this.lblnumfilafectadas.Location = new System.Drawing.Point(339, 32);
            this.lblnumfilafectadas.Name = "lblnumfilafectadas";
            this.lblnumfilafectadas.Size = new System.Drawing.Size(0, 13);
            this.lblnumfilafectadas.TabIndex = 3;
            // 
            // lblnumfilTotales
            // 
            this.lblnumfilTotales.AutoSize = true;
            this.lblnumfilTotales.Location = new System.Drawing.Point(470, 37);
            this.lblnumfilTotales.Name = "lblnumfilTotales";
            this.lblnumfilTotales.Size = new System.Drawing.Size(0, 13);
            this.lblnumfilTotales.TabIndex = 5;
            // 
            // lblFilasTotales
            // 
            this.lblFilasTotales.AutoSize = true;
            this.lblFilasTotales.Location = new System.Drawing.Point(395, 34);
            this.lblFilasTotales.Name = "lblFilasTotales";
            this.lblFilasTotales.Size = new System.Drawing.Size(69, 13);
            this.lblFilasTotales.TabIndex = 4;
            this.lblFilasTotales.Text = "Filas Totales:";
            // 
            // FAdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grbOleDBClient);
            this.Controls.Add(this.grbSqlClient);
            this.Name = "FAdo";
            this.Text = "Formulario ejercicios ADO";
            this.grbSqlClient.ResumeLayout(false);
            this.grbOleDBClient.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSqlClient;
        private System.Windows.Forms.Button btnSQLDataReader;
        private System.Windows.Forms.Button btnSQLCallSP;
        private System.Windows.Forms.Button btnSQLEscalar;
        private System.Windows.Forms.Button btnSQLDDL;
        private System.Windows.Forms.GroupBox grbOleDBClient;
        private System.Windows.Forms.Button btnOleDBDDL;
        private System.Windows.Forms.Button btnOleDBEscalar;
        private System.Windows.Forms.Button btnOleDBDataReader;
        private System.Windows.Forms.Button btnOleDbCallSP;
        private System.Windows.Forms.Button btnSQLDataSet;
        private System.Windows.Forms.Button btnOleDbDataset;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Resultados;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLanzarTx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label lblnumfilafectadas;
        private System.Windows.Forms.Label lblFilasAfectadas;
        private System.Windows.Forms.Label lblnumfilTotales;
        private System.Windows.Forms.Label lblFilasTotales;
    }
}

