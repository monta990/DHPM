﻿namespace DHPM
{
    partial class escalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(escalar));
            this.dGV2 = new System.Windows.Forms.DataGridView();
            this.dGVres = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSbGenerar = new System.Windows.Forms.ToolStripButton();
            this.tSbLimpiar = new System.Windows.Forms.ToolStripButton();
            this.tSbSalir = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBColumnas = new System.Windows.Forms.TextBox();
            this.tBRenglones = new System.Windows.Forms.TextBox();
            this.tBLimInfe = new System.Windows.Forms.TextBox();
            this.tBLimSup = new System.Windows.Forms.TextBox();
            this.cBdecimales = new System.Windows.Forms.CheckBox();
            this.cBfatiga = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tBMult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVres)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV2
            // 
            this.dGV2.AllowUserToAddRows = false;
            this.dGV2.AllowUserToDeleteRows = false;
            this.dGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV2.Location = new System.Drawing.Point(307, 49);
            this.dGV2.Margin = new System.Windows.Forms.Padding(4);
            this.dGV2.Name = "dGV2";
            this.dGV2.Size = new System.Drawing.Size(300, 200);
            this.dGV2.TabIndex = 2;
            this.dGV2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dGV2_KeyPress);
            // 
            // dGVres
            // 
            this.dGVres.AllowUserToAddRows = false;
            this.dGVres.AllowUserToDeleteRows = false;
            this.dGVres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVres.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVres.Location = new System.Drawing.Point(677, 49);
            this.dGVres.Margin = new System.Windows.Forms.Padding(4);
            this.dGVres.Name = "dGVres";
            this.dGVres.Size = new System.Drawing.Size(300, 200);
            this.dGVres.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSbGenerar,
            this.tSbLimpiar,
            this.tSbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(985, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSbGenerar
            // 
            this.tSbGenerar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSbGenerar.Image = ((System.Drawing.Image)(resources.GetObject("tSbGenerar.Image")));
            this.tSbGenerar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbGenerar.Name = "tSbGenerar";
            this.tSbGenerar.Size = new System.Drawing.Size(23, 22);
            this.tSbGenerar.Text = "Generar";
            this.tSbGenerar.Click += new System.EventHandler(this.tSbGenerar_Click);
            // 
            // tSbLimpiar
            // 
            this.tSbLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSbLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("tSbLimpiar.Image")));
            this.tSbLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbLimpiar.Name = "tSbLimpiar";
            this.tSbLimpiar.Size = new System.Drawing.Size(23, 22);
            this.tSbLimpiar.Text = "Limpiar";
            this.tSbLimpiar.Click += new System.EventHandler(this.tSbLimpiar_Click);
            // 
            // tSbSalir
            // 
            this.tSbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tSbSalir.Image")));
            this.tSbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbSalir.Name = "tSbSalir";
            this.tSbSalir.Size = new System.Drawing.Size(23, 22);
            this.tSbSalir.Text = "Salir";
            this.tSbSalir.Click += new System.EventHandler(this.tSbSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(615, 120);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(54, 54);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "=";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Columnas =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Renglones =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Limite Inferior =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Limite Superior =";
            // 
            // tBColumnas
            // 
            this.tBColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBColumnas.Location = new System.Drawing.Point(170, 26);
            this.tBColumnas.Margin = new System.Windows.Forms.Padding(2);
            this.tBColumnas.Name = "tBColumnas";
            this.tBColumnas.Size = new System.Drawing.Size(86, 35);
            this.tBColumnas.TabIndex = 11;
            this.tBColumnas.Text = "3";
            // 
            // tBRenglones
            // 
            this.tBRenglones.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBRenglones.Location = new System.Drawing.Point(170, 65);
            this.tBRenglones.Margin = new System.Windows.Forms.Padding(2);
            this.tBRenglones.Name = "tBRenglones";
            this.tBRenglones.Size = new System.Drawing.Size(86, 35);
            this.tBRenglones.TabIndex = 12;
            this.tBRenglones.Text = "3";
            // 
            // tBLimInfe
            // 
            this.tBLimInfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBLimInfe.Location = new System.Drawing.Point(505, 26);
            this.tBLimInfe.Margin = new System.Windows.Forms.Padding(2);
            this.tBLimInfe.Name = "tBLimInfe";
            this.tBLimInfe.Size = new System.Drawing.Size(86, 35);
            this.tBLimInfe.TabIndex = 13;
            this.tBLimInfe.Text = "1";
            // 
            // tBLimSup
            // 
            this.tBLimSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBLimSup.Location = new System.Drawing.Point(505, 66);
            this.tBLimSup.Margin = new System.Windows.Forms.Padding(2);
            this.tBLimSup.Name = "tBLimSup";
            this.tBLimSup.Size = new System.Drawing.Size(86, 35);
            this.tBLimSup.TabIndex = 14;
            this.tBLimSup.Text = "5";
            // 
            // cBdecimales
            // 
            this.cBdecimales.AutoSize = true;
            this.cBdecimales.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBdecimales.Location = new System.Drawing.Point(5, 21);
            this.cBdecimales.Margin = new System.Windows.Forms.Padding(2);
            this.cBdecimales.Name = "cBdecimales";
            this.cBdecimales.Size = new System.Drawing.Size(229, 33);
            this.cBdecimales.TabIndex = 15;
            this.cBdecimales.Text = "Usar Decimales?";
            this.cBdecimales.UseVisualStyleBackColor = true;
            // 
            // cBfatiga
            // 
            this.cBfatiga.AutoSize = true;
            this.cBfatiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBfatiga.Location = new System.Drawing.Point(5, 51);
            this.cBfatiga.Margin = new System.Windows.Forms.Padding(2);
            this.cBfatiga.Name = "cBfatiga";
            this.cBfatiga.Size = new System.Drawing.Size(267, 62);
            this.cBfatiga.TabIndex = 16;
            this.cBfatiga.Text = "Ahorrarce la fatiga\r\n(calcular al generar)";
            this.cBfatiga.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tBColumnas);
            this.groupBox1.Controls.Add(this.tBLimSup);
            this.groupBox1.Controls.Add(this.tBRenglones);
            this.groupBox1.Controls.Add(this.tBLimInfe);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 119);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propiedades de las matrices a generar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBfatiga);
            this.groupBox2.Controls.Add(this.cBdecimales);
            this.groupBox2.Location = new System.Drawing.Point(677, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 119);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones al generar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cantidad a Multiplicar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Matriz 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(674, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Matriz Resultado";
            // 
            // tBMult
            // 
            this.tBMult.Location = new System.Drawing.Point(101, 133);
            this.tBMult.Name = "tBMult";
            this.tBMult.Size = new System.Drawing.Size(100, 22);
            this.tBMult.TabIndex = 22;
            // 
            // escalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 386);
            this.Controls.Add(this.tBMult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dGVres);
            this.Controls.Add(this.dGV2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "escalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escalar";
            ((System.ComponentModel.ISupportInitialize)(this.dGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVres)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGV2;
        private System.Windows.Forms.DataGridView dGVres;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBColumnas;
        private System.Windows.Forms.TextBox tBRenglones;
        private System.Windows.Forms.TextBox tBLimInfe;
        private System.Windows.Forms.TextBox tBLimSup;
        private System.Windows.Forms.CheckBox cBdecimales;
        private System.Windows.Forms.ToolStripButton tSbGenerar;
        private System.Windows.Forms.ToolStripButton tSbLimpiar;
        private System.Windows.Forms.ToolStripButton tSbSalir;
        private System.Windows.Forms.CheckBox cBfatiga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBMult;
    }
}