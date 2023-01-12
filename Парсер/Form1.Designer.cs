namespace Парсер
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Calc = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonHistoryVisible = new System.Windows.Forms.Button();
            this.buttonHistoryClear = new System.Windows.Forms.Button();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonGO = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Rules = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Calc.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Rules.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите выражение:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Calc);
            this.tabControl1.Controls.Add(this.Rules);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 294);
            this.tabControl1.TabIndex = 3;
            // 
            // Calc
            // 
            this.Calc.Controls.Add(this.groupBox2);
            this.Calc.Controls.Add(this.buttonHistory);
            this.Calc.Controls.Add(this.textBox2);
            this.Calc.Controls.Add(this.textBox1);
            this.Calc.Controls.Add(this.labelResult);
            this.Calc.Controls.Add(this.buttonGO);
            this.Calc.Controls.Add(this.label4);
            this.Calc.Controls.Add(this.groupBox1);
            this.Calc.Controls.Add(this.radioButton2);
            this.Calc.Controls.Add(this.radioButton1);
            this.Calc.Controls.Add(this.label1);
            this.Calc.Location = new System.Drawing.Point(4, 22);
            this.Calc.Name = "Calc";
            this.Calc.Padding = new System.Windows.Forms.Padding(3);
            this.Calc.Size = new System.Drawing.Size(624, 268);
            this.Calc.TabIndex = 0;
            this.Calc.Text = "Вычислить";
            this.Calc.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonHistoryVisible);
            this.groupBox2.Controls.Add(this.buttonHistoryClear);
            this.groupBox2.Controls.Add(this.listBoxHistory);
            this.groupBox2.Location = new System.Drawing.Point(414, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 227);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // buttonHistoryVisible
            // 
            this.buttonHistoryVisible.Location = new System.Drawing.Point(6, 194);
            this.buttonHistoryVisible.Name = "buttonHistoryVisible";
            this.buttonHistoryVisible.Size = new System.Drawing.Size(173, 27);
            this.buttonHistoryVisible.TabIndex = 18;
            this.buttonHistoryVisible.Text = "Скрыть историю";
            this.buttonHistoryVisible.UseVisualStyleBackColor = true;
            this.buttonHistoryVisible.Click += new System.EventHandler(this.buttonHistoryVisible_Click);
            // 
            // buttonHistoryClear
            // 
            this.buttonHistoryClear.Location = new System.Drawing.Point(6, 163);
            this.buttonHistoryClear.Name = "buttonHistoryClear";
            this.buttonHistoryClear.Size = new System.Drawing.Size(173, 27);
            this.buttonHistoryClear.TabIndex = 17;
            this.buttonHistoryClear.Text = "Очистить историю";
            this.buttonHistoryClear.UseVisualStyleBackColor = true;
            this.buttonHistoryClear.Click += new System.EventHandler(this.buttonHistoryClear_Click);
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.Location = new System.Drawing.Point(6, 10);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(173, 147);
            this.listBoxHistory.TabIndex = 0;
            // 
            // buttonHistory
            // 
            this.buttonHistory.Location = new System.Drawing.Point(438, 15);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(128, 27);
            this.buttonHistory.TabIndex = 16;
            this.buttonHistory.Text = "Показать историю";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(276, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 26);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(6, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 26);
            this.textBox1.TabIndex = 14;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(287, 15);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "Результат:";
            // 
            // buttonGO
            // 
            this.buttonGO.Location = new System.Drawing.Point(6, 63);
            this.buttonGO.Name = "buttonGO";
            this.buttonGO.Size = new System.Drawing.Size(75, 23);
            this.buttonGO.TabIndex = 6;
            this.buttonGO.Text = "Вычислить";
            this.buttonGO.UseVisualStyleBackColor = true;
            this.buttonGO.Click += new System.EventHandler(this.buttonGO_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Работа с переменными";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelZ);
            this.groupBox1.Controls.Add(this.labelY);
            this.groupBox1.Controls.Add(this.labelX);
            this.groupBox1.Controls.Add(this.textBoxZ);
            this.groupBox1.Controls.Add(this.textBoxY);
            this.groupBox1.Controls.Add(this.textBoxX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(141, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(7, 91);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(68, 13);
            this.labelZ.TabIndex = 8;
            this.labelZ.Text = "Значение Z:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(6, 65);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(68, 13);
            this.labelY.TabIndex = 7;
            this.labelY.Text = "Значение Y:";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(6, 40);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(68, 13);
            this.labelX.TabIndex = 6;
            this.labelX.Text = "Значение X:";
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(117, 88);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(29, 20);
            this.textBoxZ.TabIndex = 5;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(117, 62);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(29, 20);
            this.textBoxY.TabIndex = 4;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(117, 36);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(29, 20);
            this.textBoxX.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Укажите значения используемых переменных:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(150, 116);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(186, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "с использованием переменных";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(150, 93);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(190, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "без использования переменных";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Rules
            // 
            this.Rules.Controls.Add(this.label5);
            this.Rules.Controls.Add(this.label2);
            this.Rules.Location = new System.Drawing.Point(4, 22);
            this.Rules.Name = "Rules";
            this.Rules.Padding = new System.Windows.Forms.Padding(3);
            this.Rules.Size = new System.Drawing.Size(624, 268);
            this.Rules.TabIndex = 1;
            this.Rules.Text = "Символы";
            this.Rules.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(600, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "В калькуляторе могут использоваться следущие символы:\r\n";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 187);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 292);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Calc.ResumeLayout(false);
            this.Calc.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Rules.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Calc;
        private System.Windows.Forms.TabPage Rules;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonGO;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.Button buttonHistoryVisible;
        private System.Windows.Forms.Button buttonHistoryClear;
    }
}

