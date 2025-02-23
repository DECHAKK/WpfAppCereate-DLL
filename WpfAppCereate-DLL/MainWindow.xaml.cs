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
using ArarCalculateLib;

namespace WpfAppCereate_DLL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

           // Propertie
          private Area Area { get; set; }

        public MainWindow()
        {
            InitializeComponent();

              // create Object new for receive data 
            Area = new Area();

        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            double area = 0.0;
            double red  = 0.0;
              
              // value of calculate
             red = Convert.ToDouble(txtRedian.Text);
             //arar = Math.PI * red * red;

              // Asing data to area  Function from DLL file 
             area = Area.CalculateArea(red);    

             // Show result calculate 
            txtArea.Text = area.ToString();

        }
    }
}
