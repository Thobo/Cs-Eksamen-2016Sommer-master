using System.Windows;
using Formel1.Database.Repository;
using Formel1.Database.Entity;
using System;

namespace AdminFormel1Wpf
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnYearInsert_Click(object sender, RoutedEventArgs e)
        {
            var year = int.Parse(txtBoxYear.Text);
            var time = new DateTime(year,1, 1);

            var wpf = new WPF();
            wpf.InsertSeason(new Season { Year = time });
        }
    }
}
