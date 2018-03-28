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

namespace u2GoodTimesQuinn
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

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            
            int time = Convert.ToInt32(txtInput.Text);
            int lasttwo = time % 100;
            int vict = time - 300;
            int edmo = time - 200;
            int winn = time - 100;
            int hali = time + 100;
            int stjo = time + 130;
            if (time > 2359)
            {
                lblOutput.Content = "Invalid";
            }
            else
            {
                if (lasttwo > 60)
                {
                    lblOutput.Content = "Invalid";
                }
                if (lasttwo <= 30)
                {
                    lblOutput.Content = (time + " in Ottawa" + "\n" + vict + " in Victoria" + "\n" + edmo + " in Edmonton" + "\n" + winn + " in Winnipeg" + "\n" + time + " in Toronto" + "\n" + hali + " in Halifax" + "\n" + stjo + " in St. Johns");

                }
                else
                {
                       
                    int stjohn = time + ((lasttwo - 30) + 200) - lasttwo;
                    lblOutput.Content = (time + " in Ottawa" + "\n" + vict + " in Victoria" + "\n" + edmo + " in Edmonton" + "\n" + winn + " in Winnipeg" + "\n" + time + " in Toronto" + "\n" + hali + " in Halifax" + "\n" + stjohn + " in St. Johns");

                }
               
            }
            
            
            

            
        }
    }
}
