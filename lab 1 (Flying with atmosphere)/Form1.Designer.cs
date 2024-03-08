using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_1__Flying_with_atmosphere_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inputFrequency = new System.Windows.Forms.TextBox();
            this.desk = new System.Windows.Forms.Label();
            this.inputSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inputAngle = new System.Windows.Forms.TextBox();
            this.inputSpeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            chartArea3.AxisX.LabelStyle.Format = "0.0";
            chartArea3.AxisX.LineColor = System.Drawing.SystemColors.AppWorkspace;
            chartArea3.AxisX.LineWidth = 3;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            chartArea3.AxisX.Title = "Расстояние (м)";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisX.TitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            chartArea3.AxisY.LabelStyle.Format = "0.0";
            chartArea3.AxisY.LineColor = System.Drawing.SystemColors.AppWorkspace;
            chartArea3.AxisY.LineWidth = 3;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            chartArea3.AxisY.Title = "Высота (м)";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisY.TitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            chartArea3.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            legend7.Font = new System.Drawing.Font("Century Gothic", 16F);
            legend7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            legend7.IsTextAutoFit = false;
            legend7.Name = "Legend1";
            legend7.Position.Auto = false;
            legend7.Position.Height = 12F;
            legend7.Position.Width = 30F;
            legend7.Position.X = 10F;
            legend7.Position.Y = 88F;
            legend8.Alignment = System.Drawing.StringAlignment.Center;
            legend8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend8.Font = new System.Drawing.Font("Century Gothic", 16F);
            legend8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            legend8.IsTextAutoFit = false;
            legend8.Name = "Legend2";
            legend9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            legend9.Font = new System.Drawing.Font("Century Gothic", 16F);
            legend9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            legend9.IsTextAutoFit = false;
            legend9.Name = "Legend3";
            legend9.Position.Auto = false;
            legend9.Position.Height = 12F;
            legend9.Position.Width = 30F;
            legend9.Position.X = 65F;
            legend9.Position.Y = 88F;
            this.chart1.Legends.Add(legend7);
            this.chart1.Legends.Add(legend8);
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "График 1";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend2";
            series8.Name = "График 2";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend3";
            series9.Name = "График 3";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(1297, 735);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1324, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 61);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(70, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Параметры";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.panel2.Controls.Add(this.inputFrequency);
            this.panel2.Controls.Add(this.desk);
            this.panel2.Controls.Add(this.inputSize);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.inputWeight);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.inputAngle);
            this.panel2.Controls.Add(this.inputSpeed);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1324, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 350);
            this.panel2.TabIndex = 3;
            // 
            // inputFrequency
            // 
            this.inputFrequency.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.inputFrequency.Location = new System.Drawing.Point(213, 211);
            this.inputFrequency.Name = "inputFrequency";
            this.inputFrequency.Size = new System.Drawing.Size(127, 41);
            this.inputFrequency.TabIndex = 13;
            this.inputFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // desk
            // 
            this.desk.AutoSize = true;
            this.desk.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.desk.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.desk.Location = new System.Drawing.Point(3, 213);
            this.desk.Name = "desk";
            this.desk.Size = new System.Drawing.Size(128, 33);
            this.desk.TabIndex = 12;
            this.desk.Text = "Частота:";
            // 
            // inputSize
            // 
            this.inputSize.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.inputSize.Location = new System.Drawing.Point(213, 161);
            this.inputSize.Name = "inputSize";
            this.inputSize.Size = new System.Drawing.Size(127, 41);
            this.inputSize.TabIndex = 11;
            this.inputSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(3, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 33);
            this.label6.TabIndex = 10;
            this.label6.Text = "Размер тела:";
            // 
            // inputWeight
            // 
            this.inputWeight.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.inputWeight.Location = new System.Drawing.Point(213, 112);
            this.inputWeight.Name = "inputWeight";
            this.inputWeight.Size = new System.Drawing.Size(127, 41);
            this.inputWeight.TabIndex = 9;
            this.inputWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(3, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Вес тела:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.button1.Location = new System.Drawing.Point(157, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Запуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // inputAngle
            // 
            this.inputAngle.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.inputAngle.Location = new System.Drawing.Point(213, 64);
            this.inputAngle.Name = "inputAngle";
            this.inputAngle.Size = new System.Drawing.Size(127, 41);
            this.inputAngle.TabIndex = 6;
            this.inputAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputSpeed
            // 
            this.inputSpeed.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.inputSpeed.Location = new System.Drawing.Point(213, 15);
            this.inputSpeed.Name = "inputSpeed";
            this.inputSpeed.Size = new System.Drawing.Size(127, 41);
            this.inputSpeed.TabIndex = 5;
            this.inputSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(3, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Угол броска:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сила броска:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1788, 920);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox inputAngle;
        private System.Windows.Forms.TextBox inputSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputFrequency;
        private System.Windows.Forms.Label desk;
    }
}

