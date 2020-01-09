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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)Div.IsChecked)
                Chia();
            else
                    if ((bool)Mod.IsChecked)
                Sodu();
            else
                        if ((bool)Mu.IsChecked)
                SoMu();
            else
                            if ((bool)CongChuoi.IsChecked)
                SoChuoi();
        }

        private void Chia()
        {
            double lhs = Double.Parse(GT1.Text);
            double rhs = Double.Parse(GT2.Text);
            double outcome = 0;

            if (rhs == 0)
                MessageBox.Show("error");
            else
            {
                outcome = lhs / rhs;
                kq.Text = outcome.ToString();
            }
        }

        private void SoChuoi()
        {
            kq.Text = GT1.Text + GT2.Text;
        }

        private void SoMu()
        {
            double lhs = Double.Parse(GT1.Text);
            double rhs = Double.Parse(GT2.Text);
            double outcome = 1;

            for (int i = 1; i <= rhs; i++)
                outcome *= lhs;

            kq.Text = outcome.ToString();
        }

        private void Sodu()
        {
            double lhs = Double.Parse(GT1.Text);
            double rhs = Double.Parse(GT2.Text);
            double outcome = 0;

            if (rhs == 0)
                MessageBox.Show("error");
            else
            {
                outcome = lhs % rhs;
                kq.Text = outcome.ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
