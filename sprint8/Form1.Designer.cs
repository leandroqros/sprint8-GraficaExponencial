
namespace sprint8
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.timerSegundos = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lvIzquierda = new System.Windows.Forms.ListView();
            this.clmHTimer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rtxtbTXT = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTitulo);
            this.groupBox1.Location = new System.Drawing.Point(74, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(3, 16);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(156, 24);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Start Calibration";
            // 
            // timerSegundos
            // 
            this.timerSegundos.Enabled = true;
            this.timerSegundos.Interval = 10;
            this.timerSegundos.Tick += new System.EventHandler(this.timerSegundos_Tick);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(24, 84);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(349, 343);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // lvIzquierda
            // 
            this.lvIzquierda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHTimer,
            this.clmHValor});
            this.lvIzquierda.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            this.lvIzquierda.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lvIzquierda.HideSelection = false;
            this.lvIzquierda.Location = new System.Drawing.Point(393, 84);
            this.lvIzquierda.Name = "lvIzquierda";
            this.lvIzquierda.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lvIzquierda.Size = new System.Drawing.Size(194, 343);
            this.lvIzquierda.TabIndex = 2;
            this.lvIzquierda.UseCompatibleStateImageBehavior = false;
            this.lvIzquierda.View = System.Windows.Forms.View.Details;
            // 
            // clmHTimer
            // 
            this.clmHTimer.Text = "timer";
            this.clmHTimer.Width = 70;
            // 
            // clmHValor
            // 
            this.clmHValor.Text = "valor";
            this.clmHValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmHValor.Width = 118;
            // 
            // rtxtbTXT
            // 
            this.rtxtbTXT.Location = new System.Drawing.Point(605, 84);
            this.rtxtbTXT.Name = "rtxtbTXT";
            this.rtxtbTXT.Size = new System.Drawing.Size(166, 343);
            this.rtxtbTXT.TabIndex = 6;
            this.rtxtbTXT.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxtbTXT);
            this.Controls.Add(this.lvIzquierda);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Timer timerSegundos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListView lvIzquierda;
        private System.Windows.Forms.ColumnHeader clmHTimer;
        private System.Windows.Forms.ColumnHeader clmHValor;
        private System.Windows.Forms.RichTextBox rtxtbTXT;
    }
}

