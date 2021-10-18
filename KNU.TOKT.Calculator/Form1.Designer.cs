
namespace KNU.TOKT.Calculator
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExpression = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxArgument = new System.Windows.Forms.TextBox();
            this.dataGridTabulation = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonVisualize = new System.Windows.Forms.Button();
            this.chartPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTabulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPlot)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(766, 67);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(101, 38);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(903, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // textBoxExpression
            // 
            this.textBoxExpression.Location = new System.Drawing.Point(134, 73);
            this.textBoxExpression.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxExpression.Name = "textBoxExpression";
            this.textBoxExpression.Size = new System.Drawing.Size(589, 26);
            this.textBoxExpression.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "x = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "f (x) = ";
            // 
            // textBoxArgument
            // 
            this.textBoxArgument.Location = new System.Drawing.Point(134, 37);
            this.textBoxArgument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxArgument.Name = "textBoxArgument";
            this.textBoxArgument.Size = new System.Drawing.Size(135, 26);
            this.textBoxArgument.TabIndex = 5;
            // 
            // dataGridTabulation
            // 
            this.dataGridTabulation.AllowUserToAddRows = false;
            this.dataGridTabulation.AllowUserToDeleteRows = false;
            this.dataGridTabulation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTabulation.Location = new System.Drawing.Point(304, 173);
            this.dataGridTabulation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridTabulation.Name = "dataGridTabulation";
            this.dataGridTabulation.ReadOnly = true;
            this.dataGridTabulation.RowHeadersWidth = 62;
            this.dataGridTabulation.RowTemplate.Height = 33;
            this.dataGridTabulation.Size = new System.Drawing.Size(340, 313);
            this.dataGridTabulation.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "x1 = ";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(134, 173);
            this.textBoxX1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(135, 26);
            this.textBoxX1.TabIndex = 8;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(134, 220);
            this.textBoxX2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(135, 26);
            this.textBoxX2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "x2 = ";
            // 
            // buttonVisualize
            // 
            this.buttonVisualize.Location = new System.Drawing.Point(147, 268);
            this.buttonVisualize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVisualize.Name = "buttonVisualize";
            this.buttonVisualize.Size = new System.Drawing.Size(101, 38);
            this.buttonVisualize.TabIndex = 12;
            this.buttonVisualize.Text = "Visualize";
            this.buttonVisualize.UseVisualStyleBackColor = true;
            this.buttonVisualize.Click += new System.EventHandler(this.buttonVisualize_Click);
            // 
            // chartPlot
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPlot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPlot.Legends.Add(legend1);
            this.chartPlot.Location = new System.Drawing.Point(719, 175);
            this.chartPlot.Name = "chartPlot";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPlot.Series.Add(series1);
            this.chartPlot.Size = new System.Drawing.Size(326, 311);
            this.chartPlot.TabIndex = 13;
            this.chartPlot.Text = "Plot";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 526);
            this.Controls.Add(this.chartPlot);
            this.Controls.Add(this.buttonVisualize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridTabulation);
            this.Controls.Add(this.textBoxArgument);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxExpression);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalculate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTabulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxExpression;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxArgument;
        private System.Windows.Forms.DataGridView dataGridTabulation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonVisualize;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPlot;
    }
}

