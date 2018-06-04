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

namespace ChartSurface
{    
    public partial class ChartSurface : UserControl
    {
        public ChartSurface()
        {
            InitializeComponent();      
        }

        public static DependencyProperty LineDataProperty;
        public static DependencyProperty LineThicknessProperty;
        public static DependencyProperty LineBrushProperty;
        public static DependencyProperty FontFamilyProperty;
        public static DependencyProperty FontSizeProperty;
        public static DependencyProperty XAxisTitleProperty;
        public static DependencyProperty YAxisTitleProperty;

        static ChartSurface()
        {           
            LineDataProperty = DependencyProperty.Register("LineData", typeof(IEnumerable<double>), typeof(ChartSurface));
            LineThicknessProperty = DependencyProperty.Register("LineThickness", typeof(Double), typeof(ChartSurface));
            LineBrushProperty = DependencyProperty.Register("LineBrush", typeof(Brush), typeof(ChartSurface));
            FontFamilyProperty = DependencyProperty.Register("FontFamily", typeof(String), typeof(ChartSurface));
            FontSizeProperty = DependencyProperty.Register("FontSize", typeof(double), typeof(ChartSurface));
            XAxisTitleProperty = DependencyProperty.Register("XAxisTitle", typeof(string), typeof(ChartSurface));
            YAxisTitleProperty = DependencyProperty.Register("YAxisTitle", typeof(string), typeof(ChartSurface));

        }
    
        public IEnumerable<double> LineData
        {
            get { return (IEnumerable<double>)GetValue(LineDataProperty); }
            set { SetValue(LineDataProperty, value); }
        }
        public Double LineThickness
        {
            get { return (Double)GetValue(LineThicknessProperty); }
            set { SetValue(LineThicknessProperty, value); }
        }
        public Brush LineBrush
        {
            get { return (Brush)GetValue(LineBrushProperty); }
            set { SetValue(LineBrushProperty, value); }
        }
        public String FontFamily
        {
            get { return (String)GetValue(FontFamilyProperty); }
            set { SetValue(FontFamilyProperty, value); }
        }
        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }
        public string XAxisTitle
        {
            get { return (string)GetValue(XAxisTitleProperty); }
            set { SetValue(XAxisTitleProperty, value); }
        }
        public string YAxisTitle
        {
            get { return (string)GetValue(YAxisTitleProperty); }
            set { SetValue(YAxisTitleProperty, value); }
        }
    }

    public class DoubleIEnumerableToPointCollection : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            PointCollection p = new PointCollection();
            bool f = false;
            double x = 0;
            foreach (double cdnt in (IEnumerable<double>)value)
            {
                if (f == false)
                {
                    x = cdnt*50;
                    f = true;
                    continue;
                }
                else
                {
                    p.Add(new Point(x, cdnt*50));
                    f = false;
                }
            }
            return p;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}
