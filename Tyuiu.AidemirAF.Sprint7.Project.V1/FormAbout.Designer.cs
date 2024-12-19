namespace Tyuiu.AidemirAF.Sprint7.Project.V1
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            textBoxAbout_AAF = new TextBox();
            SuspendLayout();
            // 
            // textBoxAbout_AAF
            // 
            textBoxAbout_AAF.Dock = DockStyle.Fill;
            textBoxAbout_AAF.Location = new Point(0, 0);
            textBoxAbout_AAF.Multiline = true;
            textBoxAbout_AAF.Name = "textBoxAbout_AAF";
            textBoxAbout_AAF.Size = new Size(347, 344);
            textBoxAbout_AAF.TabIndex = 0;
            textBoxAbout_AAF.Text = resources.GetString("textBoxAbout_AAF.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 344);
            Controls.Add(textBoxAbout_AAF);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAbout_AAF;
    }
}