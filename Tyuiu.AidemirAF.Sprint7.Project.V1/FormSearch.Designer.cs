namespace Tyuiu.AidemirAF.Sprint7.Project.V1
{
    partial class FormSearch
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
            labelSearch_AAF = new Label();
            textBoxSearch_AAF = new TextBox();
            buttonSearch_AAF = new Button();
            buttonReset_AAF = new Button();
            SuspendLayout();
            // 
            // labelSearch_AAF
            // 
            labelSearch_AAF.AutoSize = true;
            labelSearch_AAF.Location = new Point(12, 17);
            labelSearch_AAF.Name = "labelSearch_AAF";
            labelSearch_AAF.Size = new Size(135, 20);
            labelSearch_AAF.TabIndex = 0;
            labelSearch_AAF.Text = "Введите значение";
            // 
            // textBoxSearch_AAF
            // 
            textBoxSearch_AAF.Location = new Point(12, 40);
            textBoxSearch_AAF.Name = "textBoxSearch_AAF";
            textBoxSearch_AAF.Size = new Size(135, 27);
            textBoxSearch_AAF.TabIndex = 1;
            // 
            // buttonSearch_AAF
            // 
            buttonSearch_AAF.BackColor = SystemColors.MenuHighlight;
            buttonSearch_AAF.Location = new Point(242, 73);
            buttonSearch_AAF.Name = "buttonSearch_AAF";
            buttonSearch_AAF.Size = new Size(94, 29);
            buttonSearch_AAF.TabIndex = 2;
            buttonSearch_AAF.Text = "Найти";
            buttonSearch_AAF.UseVisualStyleBackColor = false;
            buttonSearch_AAF.Click += buttonSearch_AAF_Click;
            // 
            // buttonReset_AAF
            // 
            buttonReset_AAF.BackColor = Color.IndianRed;
            buttonReset_AAF.Location = new Point(12, 73);
            buttonReset_AAF.Name = "buttonReset_AAF";
            buttonReset_AAF.Size = new Size(94, 29);
            buttonReset_AAF.TabIndex = 3;
            buttonReset_AAF.Text = "Сброс";
            buttonReset_AAF.UseVisualStyleBackColor = false;
            buttonReset_AAF.Click += buttonReset_AAF_Click;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 110);
            Controls.Add(buttonReset_AAF);
            Controls.Add(buttonSearch_AAF);
            Controls.Add(textBoxSearch_AAF);
            Controls.Add(labelSearch_AAF);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Поиск значения в таблице";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSearch_AAF;
        private TextBox textBoxSearch_AAF;
        private Button buttonSearch_AAF;
        private Button buttonReset_AAF;
    }
}