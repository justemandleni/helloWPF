using helloWPF.Models;
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
using System.Windows.Shapes;

namespace helloWPF.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SampleDbEntities _db = new SampleDbEntities();
        public static DataGrid dataGrid;

        public MainWindow()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            dataGridDg.ItemsSource = _db.Members.ToList();
            dataGrid = dataGridDg;
        }

        private void buttonInsert_Click(object sender, RoutedEventArgs e)
        {
            InsertWindow insertWindow = new InsertWindow();
            insertWindow.ShowDialog();
        }
    }
}
