using System.ComponentModel;
using System.Data;
using System.Formats.Asn1;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Tyuiu.AidemirAF.Sprint7.Project.V1.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Tyuiu.AidemirAF.Sprint7.Project.V1.Lib.DataService;

namespace Tyuiu.AidemirAF.Sprint7.Project.V1
{
    public partial class FormMain : Form
    {
        private BindingSource bindingSource;
        private DataTable dataTable;
        private DataService dataService;
        private FileSaver fileSaver;
        public FormMain()
        {
            InitializeComponent();
            InitializeDataTable();
            dataGridViewMain_AAF.DataSource = dataTable;
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridViewMain_AAF.DataSource = bindingSource;
            dataService = new DataService();
        }
        private void InitializeDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("Номер водительских прав", typeof(string));
            dataTable.Columns.Add("ФИО владельца автомобиля", typeof(string));
            dataTable.Columns.Add("Адрес владельца", typeof(string));
            dataTable.Columns.Add("Номер телефона владельца", typeof(string));
            dataTable.Columns.Add("ФИО механика", typeof(string));
            dataTable.Columns.Add("Номер телефона механика", typeof(string));
            dataTable.Columns.Add("Квалификация механика (механик разряда)", typeof(int));
            dataTable.Columns.Add("Номер автомобиля", typeof(string));
            dataTable.Columns.Add("Марка автомобиля", typeof(string));
            dataTable.Columns.Add("Мощность автомобиля (л/с)", typeof(int));
            dataTable.Columns.Add("Цвет автомобиля", typeof(string));
            dataTable.Columns.Add("Название ремонтной мастерской", typeof(string));
            dataTable.Columns.Add("Адрес мастерской", typeof(string));
            dataTable.Columns.Add("Номер телефона мастерской", typeof(string));
        }
        private void ToolStripMenuItemOpenFile_AAF_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            openFileDialog.Title = "Выберите файл с расширением Csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                DataTable csvdataTable = ReadCsvFile(filePath);
                MergeDataTables(csvdataTable);
            }
        }
        private DataTable ReadCsvFile(string filePath)
        {
            DataTable csvdataTable = new DataTable();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();
                if (line != null)
                {
                    string[] columns = line.Split(';');
                    foreach (string column in columns)
                    {
                        csvdataTable.Columns.Add(column.Trim());
                    }
                }
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(';');
                    DataRow row = csvdataTable.NewRow();
                    for (int i = 0; i < values.Length; i++)
                    {
                        row[i] = values[i].Trim();
                    }
                    csvdataTable.Rows.Add(row);
                }
            }
            return csvdataTable;
        }

        private void toolStripButtonAddData_AAF_Click(object sender, EventArgs e)
        {
            FormAddData formAddData = new FormAddData();
            {
                if (formAddData.ShowDialog() == DialogResult.OK)
                {
                    DataRow row = dataTable.NewRow();
                    row["Номер водительских прав"] = formAddData.DriverLicense;
                    row["ФИО владельца автомобиля"] = formAddData.FullName;
                    row["Адрес владельца"] = formAddData.Address;
                    row["Номер телефона владельца"] = formAddData.Phone;
                    row["ФИО механика"] = formAddData.FullNameMech;
                    row["Номер телефона механика"] = formAddData.PhoneMech;
                    row["Квалификация механика (механик разряда)"] = formAddData.QualMech;
                    row["Номер автомобиля"] = formAddData.CarNumber;
                    row["Марка автомобиля"] = formAddData.CarBrand;
                    row["Мощность автомобиля (л/с)"] = formAddData.CarPower;
                    row["Цвет автомобиля"] = formAddData.CarColor;
                    row["Название ремонтной мастерской"] = formAddData.NameWorkshop;
                    row["Адрес мастерской"] = formAddData.AddressWorkshop;
                    row["Номер телефона мастерской"] = formAddData.PhoneWorkshop;
                    dataTable.Rows.Add(row);
                }
            }
        }
        private void MergeDataTables(DataTable csvDataTable)
        {
            foreach (DataRow row in csvDataTable.Rows)
            {
                DataRow newRow = dataTable.NewRow();
                for (int i = 0; i < csvDataTable.Columns.Count; i++)
                {
                    newRow[i] = row[i];
                }
                dataTable.Rows.Add(newRow);
            }
        }
        private void ToolStripMenuItemSearch_AAF_Click(object sender, EventArgs e)
        {
            using (FormSearch searchForm = new FormSearch())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    string searchValue = searchForm.SearchValue;
                    DataTable resultTable = dataService.FileSearch(dataTable, searchValue);
                    if (resultTable.Rows.Count > 0)
                    {
                        dataGridViewMain_AAF.DataSource = resultTable;
                        HighlightCells(dataGridViewMain_AAF, searchValue);
                    }
                }
                else
                {
                    dataGridViewMain_AAF.DataSource = dataTable;
                }
            }
        }
        private void HighlightCells(DataGridView dataGridView, string searchValue)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        cell.Style.BackColor = Color.Yellow;
                    }
                }
            }
        }
        private void ToolStripMenuItemSort_AAF_Click(object sender, EventArgs e)
        {
            using (FormSort sortForm = new FormSort())
            {
                if (sortForm.ShowDialog() == DialogResult.OK)
                {
                    string sortColumn = sortForm.SortColumn;
                    ListSortDirection sortDirection = sortForm.SortDirection;
                    if (!string.IsNullOrEmpty(sortColumn))
                    {
                        DataTable sortedTable = dataService.SortData(dataTable, sortColumn, sortDirection);
                        dataGridViewMain_AAF.DataSource = sortedTable;
                    }
                    else
                    {
                        dataGridViewMain_AAF.DataSource = dataTable;
                    }
                }
            }
        }
        private void ToolStripMenuItemPower_AAF_Click(object sender, EventArgs e)
        {
            using (FormFiltPower filtForm = new FormFiltPower())
            {
                if (filtForm.ShowDialog() == DialogResult.OK)
                {
                    int minPower = filtForm.MinPower;
                    int maxPower = filtForm.MaxPower;
                    DataTable filteredTable = dataService.FilterDataByPower(dataTable, minPower, maxPower);
                    dataGridViewMain_AAF.DataSource = filteredTable;
                }
                else
                {
                    dataGridViewMain_AAF.DataSource = dataTable;
                }
            }
        }

        private void ToolStripMenuItemQual_AAF_Click(object sender, EventArgs e)
        {
            using (FormFiltQual filtForm = new FormFiltQual())
            {
                if (filtForm.ShowDialog() == DialogResult.OK)
                {
                    int minQual = filtForm.MinQual;
                    int maxQual = filtForm.MaxQual;
                    DataTable filteredTable = dataService.FilterDataByQual(dataTable, minQual, maxQual);
                    dataGridViewMain_AAF.DataSource = filteredTable;
                }
                else
                {
                    dataGridViewMain_AAF.DataSource = dataTable;
                }
            }
        }

        private void ToolStripMenuItemHelp_AAF_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }

        private void ToolStripMenuItemAbout_AAF_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private string DataGridViewToCSV(DataGridView dataGridView)
        {
            if (dataGridView == null || dataGridView.Columns.Count == 0 || dataGridView.Rows.Count == 0)
            {
                throw new InvalidOperationException("DataGridView is not initialized or empty.");
            }
            StringBuilder csv = new StringBuilder();
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column.HeaderText != null)
                {
                    csv.Append(column.HeaderText);
                }
                csv.Append(",");
            }
            csv.AppendLine();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            csv.Append(cell.Value.ToString());
                        }
                        csv.Append(",");
                    }
                    csv.AppendLine();
                }
            }
            return csv.ToString();
        }

        private void toolStripButtonSaveFile_AAF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string content = DataGridViewToCSV(dataGridViewMain_AAF);
                    bool success = fileSaver.SaveFile(filePath, content);
                    if (success)
                    {
                        MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error saving file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}