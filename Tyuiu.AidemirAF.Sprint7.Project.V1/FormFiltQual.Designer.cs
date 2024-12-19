namespace Tyuiu.AidemirAF.Sprint7.Project.V1
{
    partial class FormFiltQual
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
            groupBoxFilt_AAF = new GroupBox();
            buttonPowerOk_AAF = new Button();
            textBoxQualMechTo_AAF = new TextBox();
            buttonReset_AAF = new Button();
            textBoxQualMechFrom_AAF = new TextBox();
            labelTo_AAF = new Label();
            labelQualMech_AAF = new Label();
            labelFrom_AAF = new Label();
            groupBoxFilt_AAF.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxFilt_AAF
            // 
            groupBoxFilt_AAF.Controls.Add(buttonPowerOk_AAF);
            groupBoxFilt_AAF.Controls.Add(textBoxQualMechTo_AAF);
            groupBoxFilt_AAF.Controls.Add(buttonReset_AAF);
            groupBoxFilt_AAF.Controls.Add(textBoxQualMechFrom_AAF);
            groupBoxFilt_AAF.Controls.Add(labelTo_AAF);
            groupBoxFilt_AAF.Controls.Add(labelQualMech_AAF);
            groupBoxFilt_AAF.Controls.Add(labelFrom_AAF);
            groupBoxFilt_AAF.Dock = DockStyle.Fill;
            groupBoxFilt_AAF.Location = new Point(0, 0);
            groupBoxFilt_AAF.Name = "groupBoxFilt_AAF";
            groupBoxFilt_AAF.Size = new Size(560, 143);
            groupBoxFilt_AAF.TabIndex = 12;
            groupBoxFilt_AAF.TabStop = false;
            groupBoxFilt_AAF.Text = "Фильтровать по:";
            // 
            // buttonPowerOk_AAF
            // 
            buttonPowerOk_AAF.BackColor = Color.SeaGreen;
            buttonPowerOk_AAF.Location = new Point(452, 52);
            buttonPowerOk_AAF.Name = "buttonPowerOk_AAF";
            buttonPowerOk_AAF.Size = new Size(103, 39);
            buttonPowerOk_AAF.TabIndex = 12;
            buttonPowerOk_AAF.Text = "Применить";
            buttonPowerOk_AAF.UseVisualStyleBackColor = false;
            buttonPowerOk_AAF.Click += buttonPowerOk_AAF_Click;
            // 
            // textBoxQualMechTo_AAF
            // 
            textBoxQualMechTo_AAF.Location = new Point(315, 58);
            textBoxQualMechTo_AAF.Name = "textBoxQualMechTo_AAF";
            textBoxQualMechTo_AAF.Size = new Size(125, 27);
            textBoxQualMechTo_AAF.TabIndex = 3;
            // 
            // buttonReset_AAF
            // 
            buttonReset_AAF.BackColor = Color.IndianRed;
            buttonReset_AAF.Location = new Point(452, 97);
            buttonReset_AAF.Name = "buttonReset_AAF";
            buttonReset_AAF.Size = new Size(103, 39);
            buttonReset_AAF.TabIndex = 8;
            buttonReset_AAF.Text = "Сброс";
            buttonReset_AAF.UseVisualStyleBackColor = false;
            buttonReset_AAF.Click += buttonReset_AAF_Click;
            // 
            // textBoxQualMechFrom_AAF
            // 
            textBoxQualMechFrom_AAF.Location = new Point(82, 58);
            textBoxQualMechFrom_AAF.Name = "textBoxQualMechFrom_AAF";
            textBoxQualMechFrom_AAF.Size = new Size(125, 27);
            textBoxQualMechFrom_AAF.TabIndex = 0;
            // 
            // labelTo_AAF
            // 
            labelTo_AAF.AutoSize = true;
            labelTo_AAF.Location = new Point(232, 61);
            labelTo_AAF.Name = "labelTo_AAF";
            labelTo_AAF.Size = new Size(33, 20);
            labelTo_AAF.TabIndex = 6;
            labelTo_AAF.Text = "до :";
            // 
            // labelQualMech_AAF
            // 
            labelQualMech_AAF.AutoSize = true;
            labelQualMech_AAF.Location = new Point(12, 30);
            labelQualMech_AAF.Name = "labelQualMech_AAF";
            labelQualMech_AAF.Size = new Size(183, 20);
            labelQualMech_AAF.TabIndex = 4;
            labelQualMech_AAF.Text = "Квалификации механика";
            // 
            // labelFrom_AAF
            // 
            labelFrom_AAF.AutoSize = true;
            labelFrom_AAF.Location = new Point(12, 61);
            labelFrom_AAF.Name = "labelFrom_AAF";
            labelFrom_AAF.Size = new Size(31, 20);
            labelFrom_AAF.TabIndex = 5;
            labelFrom_AAF.Text = "от :";
            // 
            // FormFiltQual
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 143);
            Controls.Add(groupBoxFilt_AAF);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFiltQual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Фильтрация значений таблицы";
            groupBoxFilt_AAF.ResumeLayout(false);
            groupBoxFilt_AAF.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxFilt_AAF;
        private Button buttonPowerOk_AAF;
        private TextBox textBoxQualMechTo_AAF;
        private Button buttonReset_AAF;
        private TextBox textBoxQualMechFrom_AAF;
        private Label labelTo_AAF;
        private Label labelQualMech_AAF;
        private Label labelFrom_AAF;
    }
}