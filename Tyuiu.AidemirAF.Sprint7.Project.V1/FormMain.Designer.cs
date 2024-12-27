namespace Tyuiu.AidemirAF.Sprint7.Project.V1
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            menuStrip_AAF = new MenuStrip();
            fileToolStripMenuItem_AAF = new ToolStripMenuItem();
            ToolStripMenuItemOpenFile_AAF = new ToolStripMenuItem();
            viewToolStripMenuItem_AAF = new ToolStripMenuItem();
            ToolStripMenuItemSearch_AAF = new ToolStripMenuItem();
            ToolStripMenuItemSort_AAF = new ToolStripMenuItem();
            ToolStripMenuItemFilt_AAF = new ToolStripMenuItem();
            ToolStripMenuItemPower_AAF = new ToolStripMenuItem();
            ToolStripMenuItemQual_AAF = new ToolStripMenuItem();
            helpToolStripMenuItem_AAF = new ToolStripMenuItem();
            ToolStripMenuItemHelp_AAF = new ToolStripMenuItem();
            ToolStripMenuItemAbout_AAF = new ToolStripMenuItem();
            toolStrip_AAF = new ToolStrip();
            toolStripButtonAddData_AAF = new ToolStripButton();
            toolStripButtonSaveFile_AAF = new ToolStripButton();
            dataGridViewMain_AAF = new DataGridView();
            openFileDialogTask_AAF = new OpenFileDialog();
            toolTipHint_AAF = new ToolTip(components);
            saveFileDialog_AAF = new SaveFileDialog();
            panel2 = new Panel();
            menuStrip_AAF.SuspendLayout();
            toolStrip_AAF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain_AAF).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip_AAF
            // 
            menuStrip_AAF.Font = new Font("Segoe UI", 11F);
            menuStrip_AAF.ImageScalingSize = new Size(20, 20);
            menuStrip_AAF.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem_AAF, viewToolStripMenuItem_AAF, helpToolStripMenuItem_AAF });
            menuStrip_AAF.Location = new Point(0, 0);
            menuStrip_AAF.Name = "menuStrip_AAF";
            menuStrip_AAF.Size = new Size(932, 33);
            menuStrip_AAF.TabIndex = 0;
            menuStrip_AAF.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem_AAF
            // 
            fileToolStripMenuItem_AAF.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemOpenFile_AAF });
            fileToolStripMenuItem_AAF.Name = "fileToolStripMenuItem_AAF";
            fileToolStripMenuItem_AAF.Size = new Size(71, 29);
            fileToolStripMenuItem_AAF.Text = "Файл";
            fileToolStripMenuItem_AAF.ToolTipText = "Нажмите чтобы выбрать - открыть файл";
            // 
            // ToolStripMenuItemOpenFile_AAF
            // 
            ToolStripMenuItemOpenFile_AAF.Name = "ToolStripMenuItemOpenFile_AAF";
            ToolStripMenuItemOpenFile_AAF.Size = new Size(221, 30);
            ToolStripMenuItemOpenFile_AAF.Text = "Открыть Файл";
            ToolStripMenuItemOpenFile_AAF.ToolTipText = "При нажатии выберите файл для внесения его данных в таблицу";
            ToolStripMenuItemOpenFile_AAF.Click += ToolStripMenuItemOpenFile_AAF_Click;
            // 
            // viewToolStripMenuItem_AAF
            // 
            viewToolStripMenuItem_AAF.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemSearch_AAF, ToolStripMenuItemSort_AAF, ToolStripMenuItemFilt_AAF });
            viewToolStripMenuItem_AAF.Name = "viewToolStripMenuItem_AAF";
            viewToolStripMenuItem_AAF.Size = new Size(58, 29);
            viewToolStripMenuItem_AAF.Text = "Вид";
            viewToolStripMenuItem_AAF.ToolTipText = "Нажмите чтобы выбрать : поиск, сортировку или фильтрацию";
            // 
            // ToolStripMenuItemSearch_AAF
            // 
            ToolStripMenuItemSearch_AAF.Name = "ToolStripMenuItemSearch_AAF";
            ToolStripMenuItemSearch_AAF.Size = new Size(224, 30);
            ToolStripMenuItemSearch_AAF.Text = "Поиск";
            ToolStripMenuItemSearch_AAF.ToolTipText = "Нажмите чтобы найти необходимые значения в таблице";
            ToolStripMenuItemSearch_AAF.Click += ToolStripMenuItemSearch_AAF_Click;
            // 
            // ToolStripMenuItemSort_AAF
            // 
            ToolStripMenuItemSort_AAF.Name = "ToolStripMenuItemSort_AAF";
            ToolStripMenuItemSort_AAF.Size = new Size(224, 30);
            ToolStripMenuItemSort_AAF.Text = "Сортировка";
            ToolStripMenuItemSort_AAF.ToolTipText = "Нажмите чтобы отсортировать значения таблицы";
            ToolStripMenuItemSort_AAF.Click += ToolStripMenuItemSort_AAF_Click;
            // 
            // ToolStripMenuItemFilt_AAF
            // 
            ToolStripMenuItemFilt_AAF.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemPower_AAF, ToolStripMenuItemQual_AAF });
            ToolStripMenuItemFilt_AAF.Name = "ToolStripMenuItemFilt_AAF";
            ToolStripMenuItemFilt_AAF.Size = new Size(224, 30);
            ToolStripMenuItemFilt_AAF.Text = "Фильтрация";
            // 
            // ToolStripMenuItemPower_AAF
            // 
            ToolStripMenuItemPower_AAF.Name = "ToolStripMenuItemPower_AAF";
            ToolStripMenuItemPower_AAF.Size = new Size(342, 30);
            ToolStripMenuItemPower_AAF.Text = "По мощности автомобиля";
            ToolStripMenuItemPower_AAF.ToolTipText = "Нажмите чтобы отфильтровать значения таблицы по мощности автомобиля";
            ToolStripMenuItemPower_AAF.Click += ToolStripMenuItemPower_AAF_Click;
            // 
            // ToolStripMenuItemQual_AAF
            // 
            ToolStripMenuItemQual_AAF.Name = "ToolStripMenuItemQual_AAF";
            ToolStripMenuItemQual_AAF.Size = new Size(342, 30);
            ToolStripMenuItemQual_AAF.Text = "По квалификации механика";
            ToolStripMenuItemQual_AAF.ToolTipText = "Нажмите чтобы отфильтровать значения таблицы по квалификации механика";
            ToolStripMenuItemQual_AAF.Click += ToolStripMenuItemQual_AAF_Click;
            // 
            // helpToolStripMenuItem_AAF
            // 
            helpToolStripMenuItem_AAF.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemHelp_AAF, ToolStripMenuItemAbout_AAF });
            helpToolStripMenuItem_AAF.Name = "helpToolStripMenuItem_AAF";
            helpToolStripMenuItem_AAF.Size = new Size(99, 29);
            helpToolStripMenuItem_AAF.Text = "Справка";
            helpToolStripMenuItem_AAF.ToolTipText = "Нажмите чтобы выбрать : о программе или краткое руководство пользователя";
            // 
            // ToolStripMenuItemHelp_AAF
            // 
            ToolStripMenuItemHelp_AAF.Name = "ToolStripMenuItemHelp_AAF";
            ToolStripMenuItemHelp_AAF.Size = new Size(406, 30);
            ToolStripMenuItemHelp_AAF.Text = "О программе";
            ToolStripMenuItemHelp_AAF.ToolTipText = "Выберите чтобы прочитать \"О программе\"";
            ToolStripMenuItemHelp_AAF.Click += ToolStripMenuItemHelp_AAF_Click;
            // 
            // ToolStripMenuItemAbout_AAF
            // 
            ToolStripMenuItemAbout_AAF.Name = "ToolStripMenuItemAbout_AAF";
            ToolStripMenuItemAbout_AAF.Size = new Size(406, 30);
            ToolStripMenuItemAbout_AAF.Text = "Краткое руководство пользователя";
            ToolStripMenuItemAbout_AAF.ToolTipText = "Выберите чтобы прочитать \"Краткое руководство пользователя\"";
            ToolStripMenuItemAbout_AAF.Click += ToolStripMenuItemAbout_AAF_Click;
            // 
            // toolStrip_AAF
            // 
            toolStrip_AAF.Font = new Font("Segoe UI", 10F);
            toolStrip_AAF.ImageScalingSize = new Size(20, 20);
            toolStrip_AAF.Items.AddRange(new ToolStripItem[] { toolStripButtonAddData_AAF, toolStripButtonSaveFile_AAF });
            toolStrip_AAF.Location = new Point(0, 33);
            toolStrip_AAF.Name = "toolStrip_AAF";
            toolStrip_AAF.Size = new Size(932, 33);
            toolStrip_AAF.TabIndex = 1;
            toolStrip_AAF.Text = "toolStrip1";
            // 
            // toolStripButtonAddData_AAF
            // 
            toolStripButtonAddData_AAF.AutoSize = false;
            toolStripButtonAddData_AAF.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonAddData_AAF.Image = (Image)resources.GetObject("toolStripButtonAddData_AAF.Image");
            toolStripButtonAddData_AAF.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButtonAddData_AAF.ImageTransparentColor = Color.Magenta;
            toolStripButtonAddData_AAF.Name = "toolStripButtonAddData_AAF";
            toolStripButtonAddData_AAF.Size = new Size(160, 30);
            toolStripButtonAddData_AAF.Text = "Добавить данные";
            toolStripButtonAddData_AAF.ToolTipText = "Нажмите чтобы внести свои данные в таблицу";
            toolStripButtonAddData_AAF.Click += toolStripButtonAddData_AAF_Click;
            // 
            // toolStripButtonSaveFile_AAF
            // 
            toolStripButtonSaveFile_AAF.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonSaveFile_AAF.Image = (Image)resources.GetObject("toolStripButtonSaveFile_AAF.Image");
            toolStripButtonSaveFile_AAF.ImageTransparentColor = Color.Magenta;
            toolStripButtonSaveFile_AAF.Name = "toolStripButtonSaveFile_AAF";
            toolStripButtonSaveFile_AAF.Size = new Size(162, 30);
            toolStripButtonSaveFile_AAF.Text = "Сохранить данные";
            toolStripButtonSaveFile_AAF.ToolTipText = "Нажмите чтобы сохранить файл со всеми внесенными изменениями";
            toolStripButtonSaveFile_AAF.Click += toolStripButtonSaveFile_AAF_Click;
            // 
            // dataGridViewMain_AAF
            // 
            dataGridViewMain_AAF.AllowUserToAddRows = false;
            dataGridViewMain_AAF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain_AAF.Dock = DockStyle.Fill;
            dataGridViewMain_AAF.Location = new Point(0, 0);
            dataGridViewMain_AAF.Name = "dataGridViewMain_AAF";
            dataGridViewMain_AAF.RowHeadersVisible = false;
            dataGridViewMain_AAF.RowHeadersWidth = 51;
            dataGridViewMain_AAF.Size = new Size(932, 387);
            dataGridViewMain_AAF.TabIndex = 2;
            // 
            // openFileDialogTask_AAF
            // 
            openFileDialogTask_AAF.FileName = "ProjectFile";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewMain_AAF);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(932, 387);
            panel2.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 453);
            Controls.Add(panel2);
            Controls.Add(toolStrip_AAF);
            Controls.Add(menuStrip_AAF);
            MainMenuStrip = menuStrip_AAF;
            MinimizeBox = false;
            MinimumSize = new Size(950, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Проект | Вариант 1 | Айдемир А.Ф.";
            WindowState = FormWindowState.Maximized;
            menuStrip_AAF.ResumeLayout(false);
            menuStrip_AAF.PerformLayout();
            toolStrip_AAF.ResumeLayout(false);
            toolStrip_AAF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain_AAF).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_AAF;
        private ToolStripMenuItem fileToolStripMenuItem_AAF;
        private ToolStripMenuItem viewToolStripMenuItem_AAF;
        private ToolStripMenuItem helpToolStripMenuItem_AAF;
        private ToolStrip toolStrip_AAF;
        private ToolStripButton toolStripButtonAddData_AAF;
        private ToolStripButton toolStripButtonSaveData_AAF;
        private ToolStripButton toolStripButtonLoadData_AAF;
        private DataGridView dataGridViewMain_AAF;
        private ToolStripMenuItem ToolStripMenuItemSearch_AAF;
        private ToolStripMenuItem ToolStripMenuItemSort_AAF;
        private ToolStripMenuItem ToolStripMenuItemFilt_AAF;
        private ToolStripMenuItem ToolStripMenuItemHelp_AAF;
        private ToolStripMenuItem ToolStripMenuItemAbout_AAF;
        private OpenFileDialog openFileDialogTask_AAF;
        private ToolStripMenuItem ToolStripMenuItemOpenFile_AAF;
        private ToolStripButton toolStripButtonSaveFile_AAF;
        private ToolStripMenuItem ToolStripMenuItemPower_AAF;
        private ToolStripMenuItem ToolStripMenuItemQual_AAF;
        private ToolTip toolTipHint_AAF;
        private SaveFileDialog saveFileDialog_AAF;
        private Panel panel2;
    }
}
