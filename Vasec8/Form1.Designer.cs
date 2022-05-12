
namespace Vasec8
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridVivod = new System.Windows.Forms.DataGridView();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.hScrollBarN = new System.Windows.Forms.HScrollBar();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hScrollBarM = new System.Windows.Forms.HScrollBar();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radioButtonTabl = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxOtric = new System.Windows.Forms.CheckBox();
            this.radioButtonText = new System.Windows.Forms.RadioButton();
            this.checkBoxPoloj = new System.Windows.Forms.CheckBox();
            this.checkBoxDoub = new System.Windows.Forms.CheckBox();
            this.checkBoxInt = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVivod)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridVivod
            // 
            this.dataGridVivod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVivod.Location = new System.Drawing.Point(6, 31);
            this.dataGridVivod.Name = "dataGridVivod";
            this.dataGridVivod.RowTemplate.Height = 25;
            this.dataGridVivod.Size = new System.Drawing.Size(1027, 422);
            this.dataGridVivod.TabIndex = 0;
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(6, 31);
            this.textBoxV.Multiline = true;
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(1033, 422);
            this.textBoxV.TabIndex = 1;
            // 
            // hScrollBarN
            // 
            this.hScrollBarN.LargeChange = 1;
            this.hScrollBarN.Location = new System.Drawing.Point(6, 46);
            this.hScrollBarN.Maximum = 20;
            this.hScrollBarN.Minimum = 1;
            this.hScrollBarN.Name = "hScrollBarN";
            this.hScrollBarN.Size = new System.Drawing.Size(149, 15);
            this.hScrollBarN.TabIndex = 4;
            this.hScrollBarN.Value = 1;
            this.hScrollBarN.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarN_Scroll);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(6, 20);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.ReadOnly = true;
            this.textBoxN.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxN.Size = new System.Drawing.Size(149, 23);
            this.textBoxN.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "N";
            // 
            // hScrollBarM
            // 
            this.hScrollBarM.LargeChange = 1;
            this.hScrollBarM.Location = new System.Drawing.Point(6, 110);
            this.hScrollBarM.Maximum = 20;
            this.hScrollBarM.Minimum = 1;
            this.hScrollBarM.Name = "hScrollBarM";
            this.hScrollBarM.Size = new System.Drawing.Size(149, 15);
            this.hScrollBarM.TabIndex = 8;
            this.hScrollBarM.Value = 1;
            this.hScrollBarM.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarM_Scroll);
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(6, 84);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.ReadOnly = true;
            this.textBoxM.Size = new System.Drawing.Size(149, 23);
            this.textBoxM.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "M";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1047, 487);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radioButtonTabl);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.checkBoxOtric);
            this.tabPage1.Controls.Add(this.radioButtonText);
            this.tabPage1.Controls.Add(this.checkBoxPoloj);
            this.tabPage1.Controls.Add(this.checkBoxDoub);
            this.tabPage1.Controls.Add(this.checkBoxInt);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.hScrollBarM);
            this.tabPage1.Controls.Add(this.textBoxM);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxN);
            this.tabPage1.Controls.Add(this.hScrollBarN);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1039, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioButtonTabl
            // 
            this.radioButtonTabl.AutoSize = true;
            this.radioButtonTabl.Location = new System.Drawing.Point(335, 113);
            this.radioButtonTabl.Name = "radioButtonTabl";
            this.radioButtonTabl.Size = new System.Drawing.Size(128, 19);
            this.radioButtonTabl.TabIndex = 5;
            this.radioButtonTabl.Text = "Вывести в таблицу";
            this.radioButtonTabl.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Фильтровать ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxOtric
            // 
            this.checkBoxOtric.AutoSize = true;
            this.checkBoxOtric.Location = new System.Drawing.Point(336, 62);
            this.checkBoxOtric.Name = "checkBoxOtric";
            this.checkBoxOtric.Size = new System.Drawing.Size(113, 19);
            this.checkBoxOtric.TabIndex = 14;
            this.checkBoxOtric.Text = "Отрицательные";
            this.checkBoxOtric.UseVisualStyleBackColor = true;
            // 
            // radioButtonText
            // 
            this.radioButtonText.AutoSize = true;
            this.radioButtonText.Checked = true;
            this.radioButtonText.Location = new System.Drawing.Point(197, 110);
            this.radioButtonText.Name = "radioButtonText";
            this.radioButtonText.Size = new System.Drawing.Size(132, 19);
            this.radioButtonText.TabIndex = 4;
            this.radioButtonText.TabStop = true;
            this.radioButtonText.Text = "Вывести в тексбокс";
            this.radioButtonText.UseVisualStyleBackColor = true;
            // 
            // checkBoxPoloj
            // 
            this.checkBoxPoloj.AutoSize = true;
            this.checkBoxPoloj.Location = new System.Drawing.Point(336, 37);
            this.checkBoxPoloj.Name = "checkBoxPoloj";
            this.checkBoxPoloj.Size = new System.Drawing.Size(118, 19);
            this.checkBoxPoloj.TabIndex = 13;
            this.checkBoxPoloj.Text = "Положительные";
            this.checkBoxPoloj.UseVisualStyleBackColor = true;
            // 
            // checkBoxDoub
            // 
            this.checkBoxDoub.AutoSize = true;
            this.checkBoxDoub.Location = new System.Drawing.Point(247, 62);
            this.checkBoxDoub.Name = "checkBoxDoub";
            this.checkBoxDoub.Size = new System.Drawing.Size(82, 19);
            this.checkBoxDoub.TabIndex = 12;
            this.checkBoxDoub.Text = "Не целые ";
            this.checkBoxDoub.UseVisualStyleBackColor = true;
            // 
            // checkBoxInt
            // 
            this.checkBoxInt.AutoSize = true;
            this.checkBoxInt.Location = new System.Drawing.Point(247, 37);
            this.checkBoxInt.Name = "checkBoxInt";
            this.checkBoxInt.Size = new System.Drawing.Size(63, 19);
            this.checkBoxInt.TabIndex = 11;
            this.checkBoxInt.Text = "Целые";
            this.checkBoxInt.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridVivod);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1039, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DataGridView";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxV);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1039, 459);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TextBox";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 511);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVivod)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVivod;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.HScrollBar hScrollBarN;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hScrollBarM;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton radioButtonTabl;
        private System.Windows.Forms.RadioButton radioButtonText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxOtric;
        private System.Windows.Forms.CheckBox checkBoxPoloj;
        private System.Windows.Forms.CheckBox checkBoxDoub;
        private System.Windows.Forms.CheckBox checkBoxInt;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

