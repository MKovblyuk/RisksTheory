namespace RisksTheory_lab_1
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
            this.lblForest = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblSun = new System.Windows.Forms.Label();
            this.lblRain = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.cmbForest_Sun = new System.Windows.Forms.ComboBox();
            this.cmbHome_Sun = new System.Windows.Forms.ComboBox();
            this.cmbForest_Rain = new System.Windows.Forms.ComboBox();
            this.cmbHome_Rain = new System.Windows.Forms.ComboBox();
            this.hscrSun_Probability = new System.Windows.Forms.HScrollBar();
            this.lblProbability_1 = new System.Windows.Forms.Label();
            this.lblProbability_2 = new System.Windows.Forms.Label();
            this.lblSun_Probability = new System.Windows.Forms.Label();
            this.lblRain_Probability = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblExpected_utility = new System.Windows.Forms.Label();
            this.lblForest_2 = new System.Windows.Forms.Label();
            this.lblHome_2 = new System.Windows.Forms.Label();
            this.lblForest_Utility = new System.Windows.Forms.Label();
            this.lblHome_Utility = new System.Windows.Forms.Label();
            this.lblDecision = new System.Windows.Forms.Label();
            this.lblDecision_Result = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblForest
            // 
            this.lblForest.AutoSize = true;
            this.lblForest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForest.Location = new System.Drawing.Point(347, 53);
            this.lblForest.Name = "lblForest";
            this.lblForest.Size = new System.Drawing.Size(46, 25);
            this.lblForest.TabIndex = 0;
            this.lblForest.Text = "Ліс";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHome.Location = new System.Drawing.Point(536, 53);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(71, 25);
            this.lblHome.TabIndex = 1;
            this.lblHome.Text = "Дома";
            // 
            // lblSun
            // 
            this.lblSun.AutoSize = true;
            this.lblSun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSun.Location = new System.Drawing.Point(108, 113);
            this.lblSun.Name = "lblSun";
            this.lblSun.Size = new System.Drawing.Size(80, 25);
            this.lblSun.TabIndex = 2;
            this.lblSun.Text = "Сонце";
            // 
            // lblRain
            // 
            this.lblRain.AutoSize = true;
            this.lblRain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRain.Location = new System.Drawing.Point(108, 244);
            this.lblRain.Name = "lblRain";
            this.lblRain.Size = new System.Drawing.Size(60, 25);
            this.lblRain.TabIndex = 3;
            this.lblRain.Text = "Дощ";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(991, 470);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 50;
            this.lineShape5.X2 = 706;
            this.lineShape5.Y1 = 221;
            this.lineShape5.Y2 = 220;
            this.lineShape5.Click += new System.EventHandler(this.lineShape1_Click);
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 50;
            this.lineShape4.X2 = 706;
            this.lineShape4.Y1 = 91;
            this.lineShape4.Y2 = 90;
            this.lineShape4.Click += new System.EventHandler(this.lineShape1_Click);
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 665;
            this.lineShape3.X2 = 665;
            this.lineShape3.Y1 = 30;
            this.lineShape3.Y2 = 304;
            this.lineShape3.Click += new System.EventHandler(this.lineShape1_Click);
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 262;
            this.lineShape2.X2 = 262;
            this.lineShape2.Y1 = 34;
            this.lineShape2.Y2 = 308;
            this.lineShape2.Click += new System.EventHandler(this.lineShape1_Click);
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 465;
            this.lineShape1.X2 = 465;
            this.lineShape1.Y1 = 32;
            this.lineShape1.Y2 = 306;
            this.lineShape1.Click += new System.EventHandler(this.lineShape1_Click);
            // 
            // cmbForest_Sun
            // 
            this.cmbForest_Sun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbForest_Sun.FormattingEnabled = true;
            this.cmbForest_Sun.Items.AddRange(new object[] {
            "Дуже погано",
            "Погано",
            "Посередньо",
            "Добре",
            "Дуже добре"});
            this.cmbForest_Sun.Location = new System.Drawing.Point(285, 123);
            this.cmbForest_Sun.Name = "cmbForest_Sun";
            this.cmbForest_Sun.Size = new System.Drawing.Size(163, 32);
            this.cmbForest_Sun.TabIndex = 5;
            // 
            // cmbHome_Sun
            // 
            this.cmbHome_Sun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbHome_Sun.FormattingEnabled = true;
            this.cmbHome_Sun.Items.AddRange(new object[] {
            "Дуже погано",
            "Погано",
            "Посередньо",
            "Добре",
            "Дуже добре"});
            this.cmbHome_Sun.Location = new System.Drawing.Point(485, 123);
            this.cmbHome_Sun.Name = "cmbHome_Sun";
            this.cmbHome_Sun.Size = new System.Drawing.Size(163, 32);
            this.cmbHome_Sun.TabIndex = 6;
            // 
            // cmbForest_Rain
            // 
            this.cmbForest_Rain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbForest_Rain.FormattingEnabled = true;
            this.cmbForest_Rain.Items.AddRange(new object[] {
            "Дуже погано",
            "Погано",
            "Посередньо",
            "Добре",
            "Дуже добре"});
            this.cmbForest_Rain.Location = new System.Drawing.Point(285, 244);
            this.cmbForest_Rain.Name = "cmbForest_Rain";
            this.cmbForest_Rain.Size = new System.Drawing.Size(163, 32);
            this.cmbForest_Rain.TabIndex = 7;
            // 
            // cmbHome_Rain
            // 
            this.cmbHome_Rain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbHome_Rain.FormattingEnabled = true;
            this.cmbHome_Rain.Items.AddRange(new object[] {
            "Дуже погано",
            "Погано",
            "Посередньо",
            "Добре",
            "Дуже добре"});
            this.cmbHome_Rain.Location = new System.Drawing.Point(485, 244);
            this.cmbHome_Rain.Name = "cmbHome_Rain";
            this.cmbHome_Rain.Size = new System.Drawing.Size(163, 32);
            this.cmbHome_Rain.TabIndex = 8;
            // 
            // hscrSun_Probability
            // 
            this.hscrSun_Probability.Location = new System.Drawing.Point(50, 182);
            this.hscrSun_Probability.Maximum = 109;
            this.hscrSun_Probability.Name = "hscrSun_Probability";
            this.hscrSun_Probability.Size = new System.Drawing.Size(196, 17);
            this.hscrSun_Probability.TabIndex = 9;
            this.hscrSun_Probability.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscrSun_Probability_Scroll);
            // 
            // lblProbability_1
            // 
            this.lblProbability_1.AutoSize = true;
            this.lblProbability_1.Location = new System.Drawing.Point(47, 152);
            this.lblProbability_1.Name = "lblProbability_1";
            this.lblProbability_1.Size = new System.Drawing.Size(68, 13);
            this.lblProbability_1.TabIndex = 12;
            this.lblProbability_1.Text = "Ймовірність";
            // 
            // lblProbability_2
            // 
            this.lblProbability_2.AutoSize = true;
            this.lblProbability_2.Location = new System.Drawing.Point(47, 285);
            this.lblProbability_2.Name = "lblProbability_2";
            this.lblProbability_2.Size = new System.Drawing.Size(68, 13);
            this.lblProbability_2.TabIndex = 13;
            this.lblProbability_2.Text = "Ймовірність";
            // 
            // lblSun_Probability
            // 
            this.lblSun_Probability.AutoSize = true;
            this.lblSun_Probability.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSun_Probability.Location = new System.Drawing.Point(162, 152);
            this.lblSun_Probability.Name = "lblSun_Probability";
            this.lblSun_Probability.Size = new System.Drawing.Size(30, 16);
            this.lblSun_Probability.TabIndex = 14;
            this.lblSun_Probability.Text = "0 %";
            // 
            // lblRain_Probability
            // 
            this.lblRain_Probability.AutoSize = true;
            this.lblRain_Probability.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRain_Probability.Location = new System.Drawing.Point(162, 282);
            this.lblRain_Probability.Name = "lblRain_Probability";
            this.lblRain_Probability.Size = new System.Drawing.Size(44, 16);
            this.lblRain_Probability.TabIndex = 15;
            this.lblRain_Probability.Text = "100 %";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.Location = new System.Drawing.Point(50, 383);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(213, 53);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Обчислити";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblExpected_utility
            // 
            this.lblExpected_utility.AutoSize = true;
            this.lblExpected_utility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExpected_utility.Location = new System.Drawing.Point(376, 349);
            this.lblExpected_utility.Name = "lblExpected_utility";
            this.lblExpected_utility.Size = new System.Drawing.Size(189, 20);
            this.lblExpected_utility.TabIndex = 17;
            this.lblExpected_utility.Text = "Очікувана корисність";
            // 
            // lblForest_2
            // 
            this.lblForest_2.AutoSize = true;
            this.lblForest_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForest_2.Location = new System.Drawing.Point(359, 390);
            this.lblForest_2.Name = "lblForest_2";
            this.lblForest_2.Size = new System.Drawing.Size(30, 18);
            this.lblForest_2.TabIndex = 18;
            this.lblForest_2.Text = "Ліс";
            // 
            // lblHome_2
            // 
            this.lblHome_2.AutoSize = true;
            this.lblHome_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHome_2.Location = new System.Drawing.Point(359, 428);
            this.lblHome_2.Name = "lblHome_2";
            this.lblHome_2.Size = new System.Drawing.Size(48, 18);
            this.lblHome_2.TabIndex = 19;
            this.lblHome_2.Text = "Дома";
            // 
            // lblForest_Utility
            // 
            this.lblForest_Utility.AutoSize = true;
            this.lblForest_Utility.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForest_Utility.Location = new System.Drawing.Point(515, 390);
            this.lblForest_Utility.Name = "lblForest_Utility";
            this.lblForest_Utility.Size = new System.Drawing.Size(0, 18);
            this.lblForest_Utility.TabIndex = 20;
            // 
            // lblHome_Utility
            // 
            this.lblHome_Utility.AutoSize = true;
            this.lblHome_Utility.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHome_Utility.Location = new System.Drawing.Point(515, 428);
            this.lblHome_Utility.Name = "lblHome_Utility";
            this.lblHome_Utility.Size = new System.Drawing.Size(0, 18);
            this.lblHome_Utility.TabIndex = 21;
            // 
            // lblDecision
            // 
            this.lblDecision.AutoSize = true;
            this.lblDecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDecision.Location = new System.Drawing.Point(771, 349);
            this.lblDecision.Name = "lblDecision";
            this.lblDecision.Size = new System.Drawing.Size(78, 20);
            this.lblDecision.TabIndex = 22;
            this.lblDecision.Text = "Рішення";
            // 
            // lblDecision_Result
            // 
            this.lblDecision_Result.AutoSize = true;
            this.lblDecision_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDecision_Result.Location = new System.Drawing.Point(744, 400);
            this.lblDecision_Result.Name = "lblDecision_Result";
            this.lblDecision_Result.Size = new System.Drawing.Size(0, 18);
            this.lblDecision_Result.TabIndex = 23;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(829, 59);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(141, 140);
            this.lblInfo.TabIndex = 24;
            this.lblInfo.Text = "Вага рішення\r\n\r\nДуже погано   -  0\r\nПогано             -  2\r\nПосередньо   -  4 \r\n" +
    "Добре               -  6\r\nДуже добре    -  8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 470);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblDecision_Result);
            this.Controls.Add(this.lblDecision);
            this.Controls.Add(this.lblHome_Utility);
            this.Controls.Add(this.lblForest_Utility);
            this.Controls.Add(this.lblHome_2);
            this.Controls.Add(this.lblForest_2);
            this.Controls.Add(this.lblExpected_utility);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblRain_Probability);
            this.Controls.Add(this.lblSun_Probability);
            this.Controls.Add(this.lblProbability_2);
            this.Controls.Add(this.lblProbability_1);
            this.Controls.Add(this.hscrSun_Probability);
            this.Controls.Add(this.cmbHome_Rain);
            this.Controls.Add(this.cmbForest_Rain);
            this.Controls.Add(this.cmbHome_Sun);
            this.Controls.Add(this.cmbForest_Sun);
            this.Controls.Add(this.lblRain);
            this.Controls.Add(this.lblSun);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.lblForest);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForest;
        private System.Windows.Forms.Label lblHome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblSun;
        private System.Windows.Forms.Label lblRain;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.ComboBox cmbForest_Sun;
        private System.Windows.Forms.ComboBox cmbHome_Sun;
        private System.Windows.Forms.ComboBox cmbForest_Rain;
        private System.Windows.Forms.ComboBox cmbHome_Rain;
        private System.Windows.Forms.HScrollBar hscrSun_Probability;
        private System.Windows.Forms.Label lblProbability_1;
        private System.Windows.Forms.Label lblProbability_2;
        private System.Windows.Forms.Label lblSun_Probability;
        private System.Windows.Forms.Label lblRain_Probability;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblExpected_utility;
        private System.Windows.Forms.Label lblForest_2;
        private System.Windows.Forms.Label lblHome_2;
        private System.Windows.Forms.Label lblForest_Utility;
        private System.Windows.Forms.Label lblHome_Utility;
        private System.Windows.Forms.Label lblDecision;
        private System.Windows.Forms.Label lblDecision_Result;
        private System.Windows.Forms.Label lblInfo;
    }
}

