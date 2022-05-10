namespace DepositCalc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTerm = new System.Windows.Forms.ComboBox();
            this.checkBoxMonthly = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxBody = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.listBoxRes = new System.Windows.Forms.ListBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxTerm);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите срок депозита";
            // 
            // comboBoxTerm
            // 
            this.comboBoxTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTerm.FormattingEnabled = true;
            this.comboBoxTerm.Location = new System.Drawing.Point(6, 43);
            this.comboBoxTerm.Name = "comboBoxTerm";
            this.comboBoxTerm.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTerm.TabIndex = 5;
            // 
            // checkBoxMonthly
            // 
            this.checkBoxMonthly.AutoSize = true;
            this.checkBoxMonthly.Location = new System.Drawing.Point(22, 43);
            this.checkBoxMonthly.Name = "checkBoxMonthly";
            this.checkBoxMonthly.Size = new System.Drawing.Size(95, 19);
            this.checkBoxMonthly.TabIndex = 1;
            this.checkBoxMonthly.Text = "Ежемесячно";
            this.checkBoxMonthly.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxBody);
            this.groupBox2.Controls.Add(this.checkBoxMonthly);
            this.groupBox2.Location = new System.Drawing.Point(196, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 183);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выплата процентов";
            // 
            // checkBoxBody
            // 
            this.checkBoxBody.AutoSize = true;
            this.checkBoxBody.Location = new System.Drawing.Point(22, 96);
            this.checkBoxBody.Name = "checkBoxBody";
            this.checkBoxBody.Size = new System.Drawing.Size(120, 19);
            this.checkBoxBody.TabIndex = 2;
            this.checkBoxBody.Text = "Добавлять к телу";
            this.checkBoxBody.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxSum);
            this.groupBox3.Location = new System.Drawing.Point(12, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сумма депозита";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "грн";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(39, 44);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(100, 23);
            this.textBoxSum.TabIndex = 0;
            // 
            // listBoxRes
            // 
            this.listBoxRes.FormattingEnabled = true;
            this.listBoxRes.ItemHeight = 15;
            this.listBoxRes.Location = new System.Drawing.Point(417, 20);
            this.listBoxRes.Name = "listBoxRes";
            this.listBoxRes.Size = new System.Drawing.Size(418, 289);
            this.listBoxRes.TabIndex = 2;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(250, 218);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(150, 91);
            this.buttonCalc.TabIndex = 4;
            this.buttonCalc.Text = "Расчет";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 360);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.listBoxRes);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Депозитный калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxTerm;
        private System.Windows.Forms.CheckBox checkBoxMonthly;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxBody;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.ListBox listBoxRes;
        private System.Windows.Forms.Button buttonCalc;
    }
}
