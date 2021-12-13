namespace Ejercicio_62
{
    partial class Simulador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_llegada_pieza = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_fundicion_B = new System.Windows.Forms.TextBox();
            this.txt_fundicion_A = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_distribucion_fundicion = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_forjado_B = new System.Windows.Forms.TextBox();
            this.txt_forjado_A = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_distribucion_forjado = new System.Windows.Forms.ComboBox();
            this.Terminado = new System.Windows.Forms.GroupBox();
            this.txt_terminado_B = new System.Windows.Forms.TextBox();
            this.txt_terminado_A = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_distribucion_terminado = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_tiempo_enfriado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_simular = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_grilla = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_tiempo_simulacion = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_desde_simular = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_hasta_simular = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_llegada_pieza)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Terminado.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grilla)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_llegada_pieza);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Llegada Pieza";
            // 
            // dgv_llegada_pieza
            // 
            this.dgv_llegada_pieza.AllowUserToAddRows = false;
            this.dgv_llegada_pieza.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_llegada_pieza.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_llegada_pieza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_llegada_pieza.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_llegada_pieza.Location = new System.Drawing.Point(6, 19);
            this.dgv_llegada_pieza.Name = "dgv_llegada_pieza";
            this.dgv_llegada_pieza.ReadOnly = true;
            this.dgv_llegada_pieza.RowHeadersVisible = false;
            this.dgv_llegada_pieza.Size = new System.Drawing.Size(391, 128);
            this.dgv_llegada_pieza.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_fundicion_B);
            this.groupBox2.Controls.Add(this.txt_fundicion_A);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cb_distribucion_fundicion);
            this.groupBox2.Location = new System.Drawing.Point(431, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fundicion";
            // 
            // txt_fundicion_B
            // 
            this.txt_fundicion_B.Location = new System.Drawing.Point(88, 69);
            this.txt_fundicion_B.Name = "txt_fundicion_B";
            this.txt_fundicion_B.Size = new System.Drawing.Size(56, 20);
            this.txt_fundicion_B.TabIndex = 5;
            // 
            // txt_fundicion_A
            // 
            this.txt_fundicion_A.Location = new System.Drawing.Point(88, 43);
            this.txt_fundicion_A.Name = "txt_fundicion_A";
            this.txt_fundicion_A.Size = new System.Drawing.Size(56, 20);
            this.txt_fundicion_A.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "A:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distribucion:";
            // 
            // cb_distribucion_fundicion
            // 
            this.cb_distribucion_fundicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cb_distribucion_fundicion.Enabled = false;
            this.cb_distribucion_fundicion.FormattingEnabled = true;
            this.cb_distribucion_fundicion.Location = new System.Drawing.Point(88, 16);
            this.cb_distribucion_fundicion.Name = "cb_distribucion_fundicion";
            this.cb_distribucion_fundicion.Size = new System.Drawing.Size(100, 20);
            this.cb_distribucion_fundicion.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_forjado_B);
            this.groupBox3.Controls.Add(this.txt_forjado_A);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cb_distribucion_forjado);
            this.groupBox3.Location = new System.Drawing.Point(634, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 98);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Forjado";
            // 
            // txt_forjado_B
            // 
            this.txt_forjado_B.Location = new System.Drawing.Point(90, 69);
            this.txt_forjado_B.Name = "txt_forjado_B";
            this.txt_forjado_B.Size = new System.Drawing.Size(56, 20);
            this.txt_forjado_B.TabIndex = 5;
            // 
            // txt_forjado_A
            // 
            this.txt_forjado_A.Location = new System.Drawing.Point(90, 43);
            this.txt_forjado_A.Name = "txt_forjado_A";
            this.txt_forjado_A.Size = new System.Drawing.Size(56, 20);
            this.txt_forjado_A.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "B:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "A:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Distribucion:";
            // 
            // cb_distribucion_forjado
            // 
            this.cb_distribucion_forjado.Enabled = false;
            this.cb_distribucion_forjado.FormattingEnabled = true;
            this.cb_distribucion_forjado.Location = new System.Drawing.Point(90, 16);
            this.cb_distribucion_forjado.Name = "cb_distribucion_forjado";
            this.cb_distribucion_forjado.Size = new System.Drawing.Size(100, 21);
            this.cb_distribucion_forjado.TabIndex = 0;
            // 
            // Terminado
            // 
            this.Terminado.Controls.Add(this.txt_terminado_B);
            this.Terminado.Controls.Add(this.txt_terminado_A);
            this.Terminado.Controls.Add(this.label7);
            this.Terminado.Controls.Add(this.label8);
            this.Terminado.Controls.Add(this.label9);
            this.Terminado.Controls.Add(this.cb_distribucion_terminado);
            this.Terminado.Location = new System.Drawing.Point(837, 12);
            this.Terminado.Name = "Terminado";
            this.Terminado.Size = new System.Drawing.Size(197, 98);
            this.Terminado.TabIndex = 7;
            this.Terminado.TabStop = false;
            this.Terminado.Text = "Terminado";
            // 
            // txt_terminado_B
            // 
            this.txt_terminado_B.Location = new System.Drawing.Point(88, 69);
            this.txt_terminado_B.Name = "txt_terminado_B";
            this.txt_terminado_B.Size = new System.Drawing.Size(56, 20);
            this.txt_terminado_B.TabIndex = 5;
            // 
            // txt_terminado_A
            // 
            this.txt_terminado_A.Location = new System.Drawing.Point(88, 43);
            this.txt_terminado_A.Name = "txt_terminado_A";
            this.txt_terminado_A.Size = new System.Drawing.Size(56, 20);
            this.txt_terminado_A.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "B:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "A:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Distribucion:";
            // 
            // cb_distribucion_terminado
            // 
            this.cb_distribucion_terminado.Enabled = false;
            this.cb_distribucion_terminado.FormattingEnabled = true;
            this.cb_distribucion_terminado.Location = new System.Drawing.Point(88, 16);
            this.cb_distribucion_terminado.Name = "cb_distribucion_terminado";
            this.cb_distribucion_terminado.Size = new System.Drawing.Size(100, 21);
            this.cb_distribucion_terminado.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_tiempo_enfriado);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(431, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(197, 48);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Enfriado";
            // 
            // txt_tiempo_enfriado
            // 
            this.txt_tiempo_enfriado.Location = new System.Drawing.Point(88, 19);
            this.txt_tiempo_enfriado.Name = "txt_tiempo_enfriado";
            this.txt_tiempo_enfriado.Size = new System.Drawing.Size(56, 20);
            this.txt_tiempo_enfriado.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tiempo:";
            // 
            // btn_simular
            // 
            this.btn_simular.Location = new System.Drawing.Point(182, 176);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(156, 100);
            this.btn_simular.TabIndex = 9;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.Btn_simular_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_grilla);
            this.panel1.Location = new System.Drawing.Point(12, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 329);
            this.panel1.TabIndex = 10;
            // 
            // dgv_grilla
            // 
            this.dgv_grilla.AllowUserToAddRows = false;
            this.dgv_grilla.AllowUserToDeleteRows = false;
            this.dgv_grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_grilla.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_grilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_grilla.Location = new System.Drawing.Point(0, 0);
            this.dgv_grilla.Name = "dgv_grilla";
            this.dgv_grilla.ReadOnly = true;
            this.dgv_grilla.Size = new System.Drawing.Size(1022, 329);
            this.dgv_grilla.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Tiempo:";
            // 
            // txt_tiempo_simulacion
            // 
            this.txt_tiempo_simulacion.Location = new System.Drawing.Point(76, 19);
            this.txt_tiempo_simulacion.Name = "txt_tiempo_simulacion";
            this.txt_tiempo_simulacion.Size = new System.Drawing.Size(64, 20);
            this.txt_tiempo_simulacion.TabIndex = 12;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_hasta_simular);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txt_desde_simular);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txt_tiempo_simulacion);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(18, 176);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(158, 100);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Simulación";
            // 
            // txt_desde_simular
            // 
            this.txt_desde_simular.Location = new System.Drawing.Point(76, 45);
            this.txt_desde_simular.Name = "txt_desde_simular";
            this.txt_desde_simular.Size = new System.Drawing.Size(64, 20);
            this.txt_desde_simular.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Desde:";
            // 
            // txt_hasta_simular
            // 
            this.txt_hasta_simular.Location = new System.Drawing.Point(76, 71);
            this.txt_hasta_simular.Name = "txt_hasta_simular";
            this.txt_hasta_simular.Size = new System.Drawing.Size(64, 20);
            this.txt_hasta_simular.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Hasta:";
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 623);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Terminado);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Simulador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 62";
            this.Load += new System.EventHandler(this.Simulador_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_llegada_pieza)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Terminado.ResumeLayout(false);
            this.Terminado.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grilla)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_llegada_pieza;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_fundicion_B;
        private System.Windows.Forms.TextBox txt_fundicion_A;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_distribucion_fundicion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_forjado_B;
        private System.Windows.Forms.TextBox txt_forjado_A;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_distribucion_forjado;
        private System.Windows.Forms.GroupBox Terminado;
        private System.Windows.Forms.TextBox txt_terminado_B;
        private System.Windows.Forms.TextBox txt_terminado_A;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_distribucion_terminado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_tiempo_enfriado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_grilla;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_tiempo_simulacion;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_hasta_simular;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_desde_simular;
        private System.Windows.Forms.Label label12;
    }
}

