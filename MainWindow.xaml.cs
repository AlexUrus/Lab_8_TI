using Lab_8_TI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_3_TI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window // 13) В побитовом представлении символа заменить в правом байте каждую 1 на 0
    {
        TableController tableController;
        public MainWindow()
        {
            InitializeComponent();
            tableController = new TableController();
        }
       
        private string Replace_2_With_0_InString(string message) 
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in message)
            {

                byte b = (byte)c;
                byte newByte = 0;

                for (int i = 4; i < 8; i++)
                {
                    if ((b & (1 << i)) != 0 && i != 7)
                    {
                        newByte |= (byte)(1 << i);
                    }
                }

                result.Append((char)newByte);
            }

            return result.ToString();

        }
        private void Message_TextChanged(object sender, TextChangedEventArgs e)
        {
            tableController.CreateCells(InputDataGrid, Message.Text);
            EncodeMessage.Text = Replace_2_With_0_InString(Message.Text);
            tableController.CreateCells(OutputDataGrid, EncodeMessage.Text);
        }
    }
}
