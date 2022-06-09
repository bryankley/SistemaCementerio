
namespace SistemaCementerio
{
    partial class IndicadorMortalidad
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndicadorMortalidad));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_num = new System.Windows.Forms.Label();
            this.Char_Periodo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chk_todo = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Cmb_Genero = new System.Windows.Forms.ComboBox();
            this.cmb_CausaMuerte = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_lupa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_periodo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Char_Periodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(822, 378);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lbl_num);
            this.tabPage1.Controls.Add(this.Char_Periodo);
            this.tabPage1.Controls.Add(this.chk_todo);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.Cmb_Genero);
            this.tabPage1.Controls.Add(this.cmb_CausaMuerte);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.lbl_total);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btn_lupa);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.cmb_periodo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(814, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mortalidad por Periodo";
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num.Location = new System.Drawing.Point(639, 52);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(0, 20);
            this.lbl_num.TabIndex = 18;
            // 
            // Char_Periodo
            // 
            chartArea1.Name = "ChartArea1";
            this.Char_Periodo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Char_Periodo.Legends.Add(legend1);
            this.Char_Periodo.Location = new System.Drawing.Point(513, 139);
            this.Char_Periodo.Name = "Char_Periodo";
            this.Char_Periodo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Char_Periodo.Series.Add(series1);
            this.Char_Periodo.Size = new System.Drawing.Size(271, 205);
            this.Char_Periodo.TabIndex = 17;
            this.Char_Periodo.Text = "chart1";
            // 
            // chk_todo
            // 
            this.chk_todo.AutoSize = true;
            this.chk_todo.Checked = true;
            this.chk_todo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_todo.Location = new System.Drawing.Point(426, 45);
            this.chk_todo.Name = "chk_todo";
            this.chk_todo.Size = new System.Drawing.Size(85, 17);
            this.chk_todo.TabIndex = 16;
            this.chk_todo.Text = "Mostrar todo";
            this.chk_todo.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(182, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Genero:";
            // 
            // Cmb_Genero
            // 
            this.Cmb_Genero.FormattingEnabled = true;
            this.Cmb_Genero.Location = new System.Drawing.Point(248, 49);
            this.Cmb_Genero.Name = "Cmb_Genero";
            this.Cmb_Genero.Size = new System.Drawing.Size(141, 21);
            this.Cmb_Genero.TabIndex = 14;
            // 
            // cmb_CausaMuerte
            // 
            this.cmb_CausaMuerte.FormattingEnabled = true;
            this.cmb_CausaMuerte.Location = new System.Drawing.Point(248, 76);
            this.cmb_CausaMuerte.Name = "cmb_CausaMuerte";
            this.cmb_CausaMuerte.Size = new System.Drawing.Size(141, 21);
            this.cmb_CausaMuerte.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(139, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Causa de Muerte";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(591, 95);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 20);
            this.lbl_total.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(579, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 73);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(487, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Muestra  el total de fallecidos por el Año seleccionado.";
            // 
            // btn_lupa
            // 
            this.btn_lupa.Image = ((System.Drawing.Image)(resources.GetObject("btn_lupa.Image")));
            this.btn_lupa.Location = new System.Drawing.Point(410, 88);
            this.btn_lupa.Name = "btn_lupa";
            this.btn_lupa.Size = new System.Drawing.Size(33, 27);
            this.btn_lupa.TabIndex = 6;
            this.btn_lupa.UseVisualStyleBackColor = true;
            this.btn_lupa.Click += new System.EventHandler(this.btn_lupa_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(713, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 39);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_periodo
            // 
            this.cmb_periodo.FormattingEnabled = true;
            this.cmb_periodo.Location = new System.Drawing.Point(248, 112);
            this.cmb_periodo.Name = "cmb_periodo";
            this.cmb_periodo.Size = new System.Drawing.Size(141, 21);
            this.cmb_periodo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Periodo:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Indicador de Mortalidad";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(510, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Indicador por Mes y edad";
            // 
            // IndicadorMortalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "IndicadorMortalidad";
            this.Text = "Indicador de Mortalidad";
            this.Load += new System.EventHandler(this.IndicadorMortalidad_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Char_Periodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_periodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_lupa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Cmb_Genero;
        private System.Windows.Forms.ComboBox cmb_CausaMuerte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chk_todo;
        private System.Windows.Forms.DataVisualization.Charting.Chart Char_Periodo;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label label5;
    }
}

