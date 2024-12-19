using System.Buffers;
using System.ComponentModel;
using System.Data;

namespace Tyuiu.AidemirAF.Sprint7.Project.V1.Lib
{
    public class DataService
    {
        public DataTable FileSearch(DataTable dataTable, string searchValue)
        {
            DataTable resultTable = dataTable.Clone();
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    if (row[column].ToString().Contains(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        resultTable.ImportRow(row);
                        break;
                    }
                }
            }
            return resultTable;
        }
        public DataTable SortData(DataTable dataTable, string sortColumn, ListSortDirection sortDirection)
        {
            DataView dataView = new DataView(dataTable);
            dataView.Sort = $"{sortColumn} {(sortDirection == ListSortDirection.Ascending ? "ASC" : "DESC")}";
            return dataView.ToTable();
        }
        public DataTable FilterDataByPower(DataTable dataTable, int minPower, int maxPower)
        {
            DataTable resultTable = dataTable.Clone();

            foreach (DataRow row in dataTable.Rows)
            {
                int power;
                if (Int32.TryParse(row["Мощность автомобиля (л/с)"].ToString().Split(' ')[0], out power))
                {
                    if (power >= minPower && power <= maxPower)
                    {
                        resultTable.ImportRow(row);
                    }
                }
            }

            return resultTable;
        }

        public DataTable FilterDataByQual(DataTable dataTable, int minQual, int maxQual)
        {
            DataTable resultTable = dataTable.Clone();

            foreach (DataRow row in dataTable.Rows)
            {
                int qual = Convert.ToInt32(row["Квалификация механика (механик разряда)"].ToString().Split(' ')[0]);
                if (qual >= minQual && qual <= maxQual)
                {
                    resultTable.ImportRow(row);
                }
            }

            return resultTable;
        }
        public class FileSaver
        {
            
         
        }
    }
}
