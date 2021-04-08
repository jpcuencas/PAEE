namespace Calculadora
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.Punto = new System.Windows.Forms.Button();
            this.Igual = new System.Windows.Forms.Button();
            this.mas = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.Raiz = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.GroupBox();
            this.Op = new System.Windows.Forms.GroupBox();
            this.MemMenos = new System.Windows.Forms.Button();
            this.MemMas = new System.Windows.Forms.Button();
            this.MemR = new System.Windows.Forms.Button();
            this.BorrarTodo = new System.Windows.Forms.Button();
            this.Borrar1 = new System.Windows.Forms.Button();
            this.num.SuspendLayout();
            this.Op.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pantalla
            // 
            this.Pantalla.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pantalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pantalla.Location = new System.Drawing.Point(8, 15);
            this.Pantalla.Margin = new System.Windows.Forms.Padding(6);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.ReadOnly = true;
            this.Pantalla.Size = new System.Drawing.Size(428, 44);
            this.Pantalla.TabIndex = 0;
            this.Pantalla.TabStop = false;
            this.Pantalla.Tag = "Pantalla";
            this.Pantalla.Text = "0";
            this.Pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(13, 132);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(64, 46);
            this.num1.TabIndex = 1;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(83, 132);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(64, 46);
            this.num2.TabIndex = 2;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(153, 132);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(64, 46);
            this.num3.TabIndex = 3;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num4
            // 
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(153, 80);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(64, 46);
            this.num4.TabIndex = 6;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num5
            // 
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(83, 80);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(64, 46);
            this.num5.TabIndex = 5;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(13, 80);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(64, 46);
            this.num6.TabIndex = 4;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num7
            // 
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(153, 28);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(64, 46);
            this.num7.TabIndex = 9;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(83, 28);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(64, 46);
            this.num8.TabIndex = 8;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(13, 28);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(64, 46);
            this.num9.TabIndex = 7;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num0
            // 
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(13, 190);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(134, 46);
            this.num0.TabIndex = 10;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // Punto
            // 
            this.Punto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punto.Location = new System.Drawing.Point(153, 190);
            this.Punto.Name = "Punto";
            this.Punto.Size = new System.Drawing.Size(64, 46);
            this.Punto.TabIndex = 11;
            this.Punto.Text = ".";
            this.Punto.UseVisualStyleBackColor = true;
            this.Punto.Click += new System.EventHandler(this.Punto_Click);
            // 
            // Igual
            // 
            this.Igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Igual.Location = new System.Drawing.Point(8, 191);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(134, 45);
            this.Igual.TabIndex = 12;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = true;
            this.Igual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // mas
            // 
            this.mas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mas.Location = new System.Drawing.Point(78, 80);
            this.mas.Name = "mas";
            this.mas.Size = new System.Drawing.Size(64, 98);
            this.mas.TabIndex = 13;
            this.mas.Text = "+";
            this.mas.UseVisualStyleBackColor = true;
            this.mas.Click += new System.EventHandler(this.mas_Click);
            // 
            // Div
            // 
            this.Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Div.Location = new System.Drawing.Point(6, 28);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(64, 46);
            this.Div.TabIndex = 16;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Mult
            // 
            this.Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mult.Location = new System.Drawing.Point(8, 80);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(64, 46);
            this.Mult.TabIndex = 15;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // Resta
            // 
            this.Resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resta.Location = new System.Drawing.Point(8, 132);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(64, 46);
            this.Resta.TabIndex = 14;
            this.Resta.Text = "-";
            this.Resta.UseVisualStyleBackColor = true;
            this.Resta.Click += new System.EventHandler(this.Resta_Click);
            // 
            // Raiz
            // 
            this.Raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Raiz.Location = new System.Drawing.Point(78, 28);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(64, 46);
            this.Raiz.TabIndex = 17;
            this.Raiz.Text = "sqrt";
            this.Raiz.UseVisualStyleBackColor = true;
            this.Raiz.Click += new System.EventHandler(this.Raiz_Click);
            // 
            // num
            // 
            this.num.Controls.Add(this.Punto);
            this.num.Controls.Add(this.num0);
            this.num.Controls.Add(this.num7);
            this.num.Controls.Add(this.num8);
            this.num.Controls.Add(this.num9);
            this.num.Controls.Add(this.num4);
            this.num.Controls.Add(this.num5);
            this.num.Controls.Add(this.num6);
            this.num.Controls.Add(this.num3);
            this.num.Controls.Add(this.num2);
            this.num.Controls.Add(this.num1);
            this.num.Location = new System.Drawing.Point(17, 141);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(226, 244);
            this.num.TabIndex = 18;
            this.num.TabStop = false;
            this.num.Text = "Numeros";
            // 
            // Op
            // 
            this.Op.Controls.Add(this.Raiz);
            this.Op.Controls.Add(this.Div);
            this.Op.Controls.Add(this.Mult);
            this.Op.Controls.Add(this.Resta);
            this.Op.Controls.Add(this.mas);
            this.Op.Controls.Add(this.Igual);
            this.Op.Location = new System.Drawing.Point(250, 141);
            this.Op.Name = "Op";
            this.Op.Size = new System.Drawing.Size(157, 243);
            this.Op.TabIndex = 19;
            this.Op.TabStop = false;
            this.Op.Text = "Operaciones";
            // 
            // MemMenos
            // 
            this.MemMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemMenos.Location = new System.Drawing.Point(170, 80);
            this.MemMenos.Name = "MemMenos";
            this.MemMenos.Size = new System.Drawing.Size(64, 46);
            this.MemMenos.TabIndex = 22;
            this.MemMenos.Text = "M-";
            this.MemMenos.UseVisualStyleBackColor = true;
            this.MemMenos.Click += new System.EventHandler(this.MemMenos_Click);
            // 
            // MemMas
            // 
            this.MemMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemMas.Location = new System.Drawing.Point(100, 80);
            this.MemMas.Name = "MemMas";
            this.MemMas.Size = new System.Drawing.Size(64, 46);
            this.MemMas.TabIndex = 21;
            this.MemMas.Text = "M+";
            this.MemMas.UseVisualStyleBackColor = true;
            this.MemMas.Click += new System.EventHandler(this.MemMas_Click);
            // 
            // MemR
            // 
            this.MemR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemR.Location = new System.Drawing.Point(30, 80);
            this.MemR.Name = "MemR";
            this.MemR.Size = new System.Drawing.Size(64, 46);
            this.MemR.TabIndex = 20;
            this.MemR.Text = "MR";
            this.MemR.UseVisualStyleBackColor = true;
            this.MemR.Click += new System.EventHandler(this.MemR_Click);
            // 
            // BorrarTodo
            // 
            this.BorrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarTodo.Location = new System.Drawing.Point(328, 80);
            this.BorrarTodo.Name = "BorrarTodo";
            this.BorrarTodo.Size = new System.Drawing.Size(64, 46);
            this.BorrarTodo.TabIndex = 24;
            this.BorrarTodo.Text = "C";
            this.BorrarTodo.UseVisualStyleBackColor = true;
            this.BorrarTodo.Click += new System.EventHandler(this.BorrarTodo_Click);
            // 
            // Borrar1
            // 
            this.Borrar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrar1.Location = new System.Drawing.Point(258, 80);
            this.Borrar1.Name = "Borrar1";
            this.Borrar1.Size = new System.Drawing.Size(64, 46);
            this.Borrar1.TabIndex = 23;
            this.Borrar1.Text = "CE";
            this.Borrar1.UseVisualStyleBackColor = true;
            this.Borrar1.Click += new System.EventHandler(this.Borrar1_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 418);
            this.Controls.Add(this.BorrarTodo);
            this.Controls.Add(this.Borrar1);
            this.Controls.Add(this.MemMenos);
            this.Controls.Add(this.MemMas);
            this.Controls.Add(this.MemR);
            this.Controls.Add(this.Op);
            this.Controls.Add(this.num);
            this.Controls.Add(this.Pantalla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(461, 456);
            this.MinimumSize = new System.Drawing.Size(461, 456);
            this.Name = "Calculadora";
            this.Text = "Mi Calculadora";
            this.num.ResumeLayout(false);
            this.Op.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button Punto;
        private System.Windows.Forms.Button Igual;
        private System.Windows.Forms.Button mas;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Raiz;
        private System.Windows.Forms.GroupBox num;
        private System.Windows.Forms.GroupBox Op;
        private System.Windows.Forms.Button MemMenos;
        private System.Windows.Forms.Button MemMas;
        private System.Windows.Forms.Button MemR;
        private System.Windows.Forms.Button BorrarTodo;
        private System.Windows.Forms.Button Borrar1;
    }
}

