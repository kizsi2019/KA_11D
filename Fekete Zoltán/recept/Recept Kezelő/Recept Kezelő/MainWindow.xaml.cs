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

namespace Recept_Kezelő
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Recept_Mező_List.Items.Add("recept 1");

            foreach (var item in Recept_Mező_List.Items)
            {
                if (item is Button button)
                {
                    button.Click += Button_Click;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            string selectedData = button.Content.ToString();
            var popupWindow = new PopupWindow();
            popupWindow.Show();
        }

        private class PopupWindow
        {
            internal void Show()
            {
                throw new NotImplementedException();
            }
        }
    }
}


