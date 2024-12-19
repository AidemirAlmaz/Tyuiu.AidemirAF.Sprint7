namespace Tyuiu.AidemirAF.Sprint7.Project.V1
{
    partial class FormSort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxSort_AAF = new GroupBox();
            buttonReset_AAF = new Button();
            buttonQual_AAF = new Button();
            buttonFullName_AAF = new Button();
            buttonPower_AAF = new Button();
            groupBoxSort_AAF.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxSort_AAF
            // 
            groupBoxSort_AAF.Controls.Add(buttonReset_AAF);
            groupBoxSort_AAF.Controls.Add(buttonQual_AAF);
            groupBoxSort_AAF.Controls.Add(buttonFullName_AAF);
            groupBoxSort_AAF.Controls.Add(buttonPower_AAF);
            groupBoxSort_AAF.Dock = DockStyle.Fill;
            groupBoxSort_AAF.Location = new Point(0, 0);
            groupBoxSort_AAF.Name = "groupBoxSort_AAF";
            groupBoxSort_AAF.Size = new Size(329, 134);
            groupBoxSort_AAF.TabIndex = 0;
            groupBoxSort_AAF.TabStop = false;
            groupBoxSort_AAF.Text = "Отсортировать по:";
            // 
            // buttonReset_AAF
            // 
            buttonReset_AAF.BackColor = Color.IndianRed;
            buttonReset_AAF.Location = new Point(230, 93);
            buttonReset_AAF.Name = "buttonReset_AAF";
            buttonReset_AAF.Size = new Size(87, 29);
            buttonReset_AAF.TabIndex = 1;
            buttonReset_AAF.Text = "Сброс";
            buttonReset_AAF.UseVisualStyleBackColor = false;
            buttonReset_AAF.Click += buttonReset_AAF_Click;
            // 
            // buttonQual_AAF
            // 
            buttonQual_AAF.Location = new Point(12, 93);
            buttonQual_AAF.Name = "buttonQual_AAF";
            buttonQual_AAF.Size = new Size(201, 29);
            buttonQual_AAF.TabIndex = 3;
            buttonQual_AAF.Text = "Квалификации механика";
            buttonQual_AAF.UseVisualStyleBackColor = true;
            buttonQual_AAF.Click += buttonQual_AAF_Click;
            // 
            // buttonFullName_AAF
            // 
            buttonFullName_AAF.Location = new Point(12, 26);
            buttonFullName_AAF.Name = "buttonFullName_AAF";
            buttonFullName_AAF.Size = new Size(201, 29);
            buttonFullName_AAF.TabIndex = 2;
            buttonFullName_AAF.Text = "ФИО от А до Я";
            buttonFullName_AAF.UseVisualStyleBackColor = true;
            buttonFullName_AAF.Click += buttonFullName_AAF_Click;
            // 
            // buttonPower_AAF
            // 
            buttonPower_AAF.Location = new Point(12, 61);
            buttonPower_AAF.Name = "buttonPower_AAF";
            buttonPower_AAF.Size = new Size(201, 29);
            buttonPower_AAF.TabIndex = 1;
            buttonPower_AAF.Text = "Мощности машины";
            buttonPower_AAF.UseVisualStyleBackColor = true;
            buttonPower_AAF.Click += buttonPower_AAF_Click;
            // 
            // FormSort
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 134);
            Controls.Add(groupBoxSort_AAF);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormSort";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сортировка таблицы";
            groupBoxSort_AAF.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxSort_AAF;
        private Button buttonQual_AAF;
        private Button buttonFullName_AAF;
        private Button buttonPower_AAF;
        private Button buttonReset_AAF;
    }
}