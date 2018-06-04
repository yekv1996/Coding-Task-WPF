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

namespace DemoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ChartSurface.ChartSurface cs;
        double[] data;
        public MainWindow()
        {

            InitializeComponent();

            this.FontSizeCB.SelectionChanged += new SelectionChangedEventHandler(OnFontSizeCBChanged);
            this.FontFamilyCB.SelectionChanged += new SelectionChangedEventHandler(OnFontFamilyCBChanged);
            this.LineBrashCB.SelectionChanged += new SelectionChangedEventHandler(OnLineBrashCBChanged);
            this.LineThicknessCB.SelectionChanged += new SelectionChangedEventHandler(OnLineThicknessCBChanged);
            this.XAxisTitleTB.TextChanged += new TextChangedEventHandler(OnXAxisTitleTBChanged);
            this.YAxisTitleTB.TextChanged += new TextChangedEventHandler(OnYAxisTitleTBChanged);
            this.SinewaveRB.Checked += new RoutedEventHandler(OnTWaveRBChecked);
            this.SquarewaveRB.Checked += new RoutedEventHandler(OnTWaveRBChecked);

            cs = new ChartSurface.ChartSurface
            {
                LineData = new Double[] { 0, 6, 1, 2, 2, 4.6, 3, 3.5, 4, 1.9, 5, 3, 6, 5, 7, 9, 8, 4, 9, 2, 10, 3.5 },
                LineThickness = 2,
                LineBrush = Brushes.DarkRed,
                FontFamily = "Comic Sans MS",
                FontSize = 15,
                XAxisTitle = this.XAxisTitleTB.Text,
                YAxisTitle = this.YAxisTitleTB.Text
            };
            this.DataContext = cs;
            data = cs.LineData.ToArray();
        }

        private void OnTWaveRBChecked(object sender, RoutedEventArgs e)
        {
            if (this.SinewaveRB.IsChecked == true)
                cs.LineData = data;
            else
                cs.LineData = CreateStepLineSeries(data);
        }

        private void OnYAxisTitleTBChanged(object sender, TextChangedEventArgs e)
        {
            cs.YAxisTitle = (sender as TextBox).Text;
        }

        private void OnXAxisTitleTBChanged(object sender, TextChangedEventArgs e)
        {
            cs.XAxisTitle = (sender as TextBox).Text;
        }

        private void OnLineThicknessCBChanged(object sender, SelectionChangedEventArgs e)
        {
            cs.LineThickness = Convert.ToDouble(((sender as ComboBox).SelectedItem as ComboBoxItem).Content as string);
        }

        private void OnLineBrashCBChanged(object sender, SelectionChangedEventArgs e)
        {
            cs.LineBrush = ((sender as ComboBox).SelectedItem as TextBlock).Background as Brush;
        }

        private void OnFontFamilyCBChanged(object sender, SelectionChangedEventArgs e)
        {
            cs.FontFamily = ((sender as ComboBox).SelectedItem as ComboBoxItem).Content as string;
        }

        private void OnFontSizeCBChanged(object sender, SelectionChangedEventArgs e)
        {           
            cs.FontSize = Convert.ToDouble(((sender as ComboBox).SelectedItem as ComboBoxItem).Content as string);
        }

        double[] CreateStepLineSeries(double[] source)
        {
            List<double> returnValue = new List<double>();
            for (int i = 1; i < source.Length; i+=2)
            {
                double currentValueX = source[i - 1];
                double currentValueY = source[i];
                returnValue.Add(currentValueX);
                returnValue.Add(currentValueY);
                if (i < source.Length - 1)
                {
                    double nextValueX = source[i + 1];
                    returnValue.Add(nextValueX);
                    returnValue.Add(currentValueY);
                }
            }
            return returnValue.ToArray();
        }     
    }
}
