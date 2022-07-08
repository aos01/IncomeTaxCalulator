using System;
using System.Net.Http;
using System.Windows;

namespace ITC.GUI
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

        private void bCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tInput.Text, out int income))
            {
                GetCalcualtedIncome(income);
            }
            else
            {
                tbResult.Text = $"[{tInput.Text}] is not a valid income amount.";
            }
        }

        private async void GetCalcualtedIncome(int income)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"https://localhost:7025/api/IncomeTaxCalculator/{income}");

                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    tbResult.Text = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    tbResult.Text = $"Server error code {response.StatusCode}";
                }
            }
        }
    }
}
