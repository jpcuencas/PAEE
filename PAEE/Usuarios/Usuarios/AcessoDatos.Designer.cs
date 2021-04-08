namespace Usuarios
{
    partial class AcessoDatos
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
            this.btnEF = new System.Windows.Forms.Button();
            this.btnEL = new System.Windows.Forms.Button();
            this.btnNHibernate = new System.Windows.Forms.Button();
            this.btnADO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEF
            // 
            this.btnEF.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEF.Location = new System.Drawing.Point(402, 52);
            this.btnEF.Name = "btnEF";
            this.btnEF.Size = new System.Drawing.Size(110, 53);
            this.btnEF.TabIndex = 7;
            this.btnEF.Text = "Entity Framework";
            this.btnEF.UseVisualStyleBackColor = true;
            this.btnEF.Click += new System.EventHandler(this.btnEF_Click);
            // 
            // btnEL
            // 
            this.btnEL.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEL.Location = new System.Drawing.Point(275, 52);
            this.btnEL.Name = "btnEL";
            this.btnEL.Size = new System.Drawing.Size(110, 53);
            this.btnEL.TabIndex = 6;
            this.btnEL.Text = "Entrerprise Library";
            this.btnEL.UseVisualStyleBackColor = true;
            this.btnEL.Click += new System.EventHandler(this.btnEL_Click);
            // 
            // btnNHibernate
            // 
            this.btnNHibernate.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNHibernate.Location = new System.Drawing.Point(149, 52);
            this.btnNHibernate.Name = "btnNHibernate";
            this.btnNHibernate.Size = new System.Drawing.Size(110, 53);
            this.btnNHibernate.TabIndex = 5;
            this.btnNHibernate.Text = "NHibernate";
            this.btnNHibernate.UseVisualStyleBackColor = true;
            this.btnNHibernate.Click += new System.EventHandler(this.btnNHibernate_Click);
            // 
            // btnADO
            // 
            this.btnADO.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADO.Location = new System.Drawing.Point(24, 52);
            this.btnADO.Name = "btnADO";
            this.btnADO.Size = new System.Drawing.Size(110, 53);
            this.btnADO.TabIndex = 4;
            this.btnADO.Text = "ADO";
            this.btnADO.UseVisualStyleBackColor = true;
            this.btnADO.Click += new System.EventHandler(this.btnADO_Click);
            // 
            // AcessoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 161);
            this.Controls.Add(this.btnEF);
            this.Controls.Add(this.btnEL);
            this.Controls.Add(this.btnNHibernate);
            this.Controls.Add(this.btnADO);
            this.Name = "AcessoDatos";
            this.Text = "AcessoDatos";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnEF;
        internal System.Windows.Forms.Button btnEL;
        internal System.Windows.Forms.Button btnNHibernate;
        internal System.Windows.Forms.Button btnADO;
    }
}