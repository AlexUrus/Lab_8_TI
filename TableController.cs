using Lab_3_TI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Lab_8_TI
{
    public class TableController
    {
        public string message;
        public List<FieldsForTable> inputFieldsForTable;
        public List<FieldsForTable> outputFieldsForTable;

        public TableController() 
        {
            inputFieldsForTable = new List<FieldsForTable>();
            outputFieldsForTable = new List<FieldsForTable>();
        }

        public void CreateCells(DataGrid dataGrid, string message)
        {
            inputFieldsForTable.Clear();
            foreach (char ch in message)
            {
                inputFieldsForTable.Add(new FieldsForTable(ch));
            }
            FillTable(dataGrid);
        }

        public void FillTable(DataGrid dataGrid)
        {
            var data = inputFieldsForTable.Select(f => new
            {
                Symbol = f.Symbol,
                DecCode = f.DecCode,
                BiCode = f.BiCode,
                HecaDecCode = f.HecaDecCode
            }).ToList();

            dataGrid.ItemsSource = data;
        }


    }
}
