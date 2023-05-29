namespace Таймер
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Del = new System.Windows.Forms.Button();
            this.Stop_T = new System.Windows.Forms.Button();
            this.Zapusk_T = new System.Windows.Forms.Button();
            this.Sec_T = new System.Windows.Forms.TextBox();
            this.Min_T = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Start = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Sbros = new System.Windows.Forms.Button();
            this.Ochistit = new System.Windows.Forms.Button();
            this.Zapis = new System.Windows.Forms.Button();
            this.Zapusk_S = new System.Windows.Forms.Button();
            this.Stop_S = new System.Windows.Forms.Button();
            this.MelSec = new System.Windows.Forms.TextBox();
            this.Sec_S = new System.Windows.Forms.TextBox();
            this.Vevod = new System.Windows.Forms.TextBox();
            this.Chas = new System.Windows.Forms.TextBox();
            this.Min_S = new System.Windows.Forms.TextBox();
            this.MSec = new System.Windows.Forms.CheckBox();
            this.checkChas = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerSec = new System.Windows.Forms.Timer(this.components);
            this.timerTay = new System.Windows.Forms.Timer(this.components);
            this.timerBud = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.Del);
            this.groupBox1.Controls.Add(this.Stop_T);
            this.groupBox1.Controls.Add(this.Zapusk_T);
            this.groupBox1.Controls.Add(this.Sec_T);
            this.groupBox1.Controls.Add(this.Min_T);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(375, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Del
            // 
            this.Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Del.Location = new System.Drawing.Point(347, 68);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(67, 57);
            this.Del.TabIndex = 7;
            this.Del.Text = "Удалить";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Stop_T
            // 
            this.Stop_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stop_T.Location = new System.Drawing.Point(274, 68);
            this.Stop_T.Name = "Stop_T";
            this.Stop_T.Size = new System.Drawing.Size(67, 57);
            this.Stop_T.TabIndex = 6;
            this.Stop_T.Text = "Стоп";
            this.Stop_T.UseVisualStyleBackColor = true;
            this.Stop_T.Click += new System.EventHandler(this.Stop_T_Click);
            // 
            // Zapusk_T
            // 
            this.Zapusk_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zapusk_T.Location = new System.Drawing.Point(201, 68);
            this.Zapusk_T.Name = "Zapusk_T";
            this.Zapusk_T.Size = new System.Drawing.Size(67, 57);
            this.Zapusk_T.TabIndex = 5;
            this.Zapusk_T.Text = "Запуск";
            this.Zapusk_T.UseVisualStyleBackColor = true;
            this.Zapusk_T.Click += new System.EventHandler(this.Zapusk_T_Click);
            // 
            // Sec_T
            // 
            this.Sec_T.Location = new System.Drawing.Point(113, 105);
            this.Sec_T.Name = "Sec_T";
            this.Sec_T.Size = new System.Drawing.Size(71, 20);
            this.Sec_T.TabIndex = 4;
            this.Sec_T.Text = "0";
            // 
            // Min_T
            // 
            this.Min_T.Location = new System.Drawing.Point(113, 68);
            this.Min_T.Name = "Min_T";
            this.Min_T.Size = new System.Drawing.Size(71, 20);
            this.Min_T.TabIndex = 3;
            this.Min_T.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(18, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Минуты";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(18, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Секунды";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Таймер";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.maskedTextBox4);
            this.groupBox2.Controls.Add(this.maskedTextBox2);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.Start);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(375, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 264);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox4.Location = new System.Drawing.Point(291, 131);
            this.maskedTextBox4.Mask = "00:00:00";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 34);
            this.maskedTextBox4.TabIndex = 6;
            this.maskedTextBox4.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox2.Location = new System.Drawing.Point(291, 91);
            this.maskedTextBox2.Mask = "00:00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 34);
            this.maskedTextBox2.TabIndex = 4;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(291, 50);
            this.maskedTextBox1.Mask = "00:00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 34);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(50, 186);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(134, 52);
            this.Start.TabIndex = 2;
            this.Start.Text = "Начать";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(79, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "00:00:00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(156, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Будильник";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.Sbros);
            this.groupBox3.Controls.Add(this.Ochistit);
            this.groupBox3.Controls.Add(this.Zapis);
            this.groupBox3.Controls.Add(this.Zapusk_S);
            this.groupBox3.Controls.Add(this.Stop_S);
            this.groupBox3.Controls.Add(this.MelSec);
            this.groupBox3.Controls.Add(this.Sec_S);
            this.groupBox3.Controls.Add(this.Vevod);
            this.groupBox3.Controls.Add(this.Chas);
            this.groupBox3.Controls.Add(this.Min_S);
            this.groupBox3.Controls.Add(this.MSec);
            this.groupBox3.Controls.Add(this.checkChas);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 426);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // Sbros
            // 
            this.Sbros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sbros.Location = new System.Drawing.Point(85, 278);
            this.Sbros.Name = "Sbros";
            this.Sbros.Size = new System.Drawing.Size(75, 85);
            this.Sbros.TabIndex = 16;
            this.Sbros.Text = "Сброс";
            this.Sbros.UseVisualStyleBackColor = true;
            this.Sbros.Click += new System.EventHandler(this.Sbros_Click);
            // 
            // Ochistit
            // 
            this.Ochistit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ochistit.Location = new System.Drawing.Point(166, 322);
            this.Ochistit.Name = "Ochistit";
            this.Ochistit.Size = new System.Drawing.Size(162, 41);
            this.Ochistit.TabIndex = 15;
            this.Ochistit.Text = "Очистить";
            this.Ochistit.UseVisualStyleBackColor = true;
            this.Ochistit.Click += new System.EventHandler(this.Ochistit_Click);
            // 
            // Zapis
            // 
            this.Zapis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zapis.Location = new System.Drawing.Point(6, 278);
            this.Zapis.Name = "Zapis";
            this.Zapis.Size = new System.Drawing.Size(73, 85);
            this.Zapis.TabIndex = 14;
            this.Zapis.Text = "Запись";
            this.Zapis.UseVisualStyleBackColor = true;
            this.Zapis.Click += new System.EventHandler(this.Zapis_Click);
            // 
            // Zapusk_S
            // 
            this.Zapusk_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zapusk_S.Location = new System.Drawing.Point(6, 187);
            this.Zapusk_S.Name = "Zapusk_S";
            this.Zapusk_S.Size = new System.Drawing.Size(73, 85);
            this.Zapusk_S.TabIndex = 13;
            this.Zapusk_S.Text = "Запуск";
            this.Zapusk_S.UseVisualStyleBackColor = true;
            this.Zapusk_S.Click += new System.EventHandler(this.Zapusk_S_Click);
            // 
            // Stop_S
            // 
            this.Stop_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stop_S.Location = new System.Drawing.Point(84, 187);
            this.Stop_S.Name = "Stop_S";
            this.Stop_S.Size = new System.Drawing.Size(75, 85);
            this.Stop_S.TabIndex = 12;
            this.Stop_S.Text = "Стоп";
            this.Stop_S.UseVisualStyleBackColor = true;
            this.Stop_S.Click += new System.EventHandler(this.Stop_S_Click);
            // 
            // MelSec
            // 
            this.MelSec.Enabled = false;
            this.MelSec.Location = new System.Drawing.Point(165, 68);
            this.MelSec.Name = "MelSec";
            this.MelSec.Size = new System.Drawing.Size(122, 20);
            this.MelSec.TabIndex = 11;
            // 
            // Sec_S
            // 
            this.Sec_S.Enabled = false;
            this.Sec_S.Location = new System.Drawing.Point(165, 94);
            this.Sec_S.Name = "Sec_S";
            this.Sec_S.Size = new System.Drawing.Size(122, 20);
            this.Sec_S.TabIndex = 10;
            // 
            // Vevod
            // 
            this.Vevod.Enabled = false;
            this.Vevod.Location = new System.Drawing.Point(165, 187);
            this.Vevod.Multiline = true;
            this.Vevod.Name = "Vevod";
            this.Vevod.Size = new System.Drawing.Size(163, 129);
            this.Vevod.TabIndex = 9;
            // 
            // Chas
            // 
            this.Chas.Enabled = false;
            this.Chas.Location = new System.Drawing.Point(165, 146);
            this.Chas.Name = "Chas";
            this.Chas.Size = new System.Drawing.Size(122, 20);
            this.Chas.TabIndex = 8;
            // 
            // Min_S
            // 
            this.Min_S.Enabled = false;
            this.Min_S.Location = new System.Drawing.Point(165, 120);
            this.Min_S.Name = "Min_S";
            this.Min_S.Size = new System.Drawing.Size(122, 20);
            this.Min_S.TabIndex = 7;
            // 
            // MSec
            // 
            this.MSec.AutoSize = true;
            this.MSec.Checked = true;
            this.MSec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MSec.Location = new System.Drawing.Point(297, 123);
            this.MSec.Name = "MSec";
            this.MSec.Size = new System.Drawing.Size(58, 17);
            this.MSec.TabIndex = 6;
            this.MSec.Text = "М/сек";
            this.MSec.UseVisualStyleBackColor = true;
            // 
            // checkChas
            // 
            this.checkChas.AutoSize = true;
            this.checkChas.Checked = true;
            this.checkChas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkChas.Location = new System.Drawing.Point(297, 99);
            this.checkChas.Name = "checkChas";
            this.checkChas.Size = new System.Drawing.Size(54, 17);
            this.checkChas.TabIndex = 5;
            this.checkChas.Text = "Часы";
            this.checkChas.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Часы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Минуты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Секунды";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Миллисекунды";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Секундомер";
            // 
            // timerSec
            // 
            this.timerSec.Interval = 1;
            this.timerSec.Tick += new System.EventHandler(this.timerSec_Tick);
            // 
            // timerTay
            // 
            this.timerTay.Interval = 1000;
            this.timerTay.Tick += new System.EventHandler(this.timerTay_Tick);
            // 
            // timerBud
            // 
            this.timerBud.Tick += new System.EventHandler(this.timerBud_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Stop_T;
        private System.Windows.Forms.Button Zapusk_T;
        private System.Windows.Forms.TextBox Sec_T;
        private System.Windows.Forms.TextBox Min_T;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Sbros;
        private System.Windows.Forms.Button Ochistit;
        private System.Windows.Forms.Button Zapis;
        private System.Windows.Forms.Button Zapusk_S;
        private System.Windows.Forms.Button Stop_S;
        private System.Windows.Forms.TextBox MelSec;
        private System.Windows.Forms.TextBox Sec_S;
        private System.Windows.Forms.TextBox Vevod;
        private System.Windows.Forms.TextBox Chas;
        private System.Windows.Forms.TextBox Min_S;
        private System.Windows.Forms.CheckBox MSec;
        private System.Windows.Forms.CheckBox checkChas;
        private System.Windows.Forms.Timer timerSec;
        private System.Windows.Forms.Timer timerTay;
        private System.Windows.Forms.Timer timerBud;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

