
namespace T0010
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sliderSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonProcessing = new System.Windows.Forms.Button();
            this.tableInput = new System.Windows.Forms.DataGridView();
            this.tableOutput = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Входная матрица";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выходная матрица";
            // 
            // sliderSize
            // 
            this.sliderSize.Location = new System.Drawing.Point(12, 440);
            this.sliderSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.sliderSize.Name = "sliderSize";
            this.sliderSize.Size = new System.Drawing.Size(48, 20);
            this.sliderSize.TabIndex = 4;
            this.sliderSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Размер входной матрицы";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(12, 466);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(108, 23);
            this.buttonGenerate.TabIndex = 6;
            this.buttonGenerate.Text = "Сгенерировать";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonProcessing
            // 
            this.buttonProcessing.Location = new System.Drawing.Point(12, 495);
            this.buttonProcessing.Name = "buttonProcessing";
            this.buttonProcessing.Size = new System.Drawing.Size(108, 23);
            this.buttonProcessing.TabIndex = 7;
            this.buttonProcessing.Text = "Уплотнить";
            this.buttonProcessing.UseVisualStyleBackColor = true;
            this.buttonProcessing.Click += new System.EventHandler(this.buttonProcessing_Click);
            // 
            // tableInput
            // 
            this.tableInput.AllowUserToAddRows = false;
            this.tableInput.AllowUserToDeleteRows = false;
            this.tableInput.AllowUserToResizeColumns = false;
            this.tableInput.AllowUserToResizeRows = false;
            this.tableInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableInput.Location = new System.Drawing.Point(16, 30);
            this.tableInput.Name = "tableInput";
            this.tableInput.Size = new System.Drawing.Size(400, 400);
            this.tableInput.TabIndex = 8;
            // 
            // tableOutput
            // 
            this.tableOutput.AllowUserToAddRows = false;
            this.tableOutput.AllowUserToDeleteRows = false;
            this.tableOutput.AllowUserToResizeColumns = false;
            this.tableOutput.AllowUserToResizeRows = false;
            this.tableOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableOutput.Location = new System.Drawing.Point(432, 29);
            this.tableOutput.Name = "tableOutput";
            this.tableOutput.Size = new System.Drawing.Size(400, 400);
            this.tableOutput.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 661);
            this.Controls.Add(this.tableOutput);
            this.Controls.Add(this.tableInput);
            this.Controls.Add(this.buttonProcessing);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sliderSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "T 00 10 by Serov_a_p from g.3";
            ((System.ComponentModel.ISupportInitialize)(this.sliderSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sliderSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonProcessing;
        private System.Windows.Forms.DataGridView tableInput;
        private System.Windows.Forms.DataGridView tableOutput;
    }
}

