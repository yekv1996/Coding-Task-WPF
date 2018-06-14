using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Media;

namespace DemoApp
{
    class ViewModel
    {

        double[] data;

        public bool ChartType
        {           
            set
            {
                if (value)
                    cs.LineData = Model.CreateStepLineSeries(data);
                else
                    cs.LineData = data;
            }
        }

        public IEnumerable<double> LineData
        {
            get { return cs.LineData; }
            set
            {
                cs.LineData = value;
                data = cs.LineData.ToArray();
            }
        }

        public double LineThickness
        {
            get { return cs.LineThickness; }
            set
            {
                cs.LineThickness = value;
            }
        }

        Brush[] br = new Brush[] { Brushes.Red, Brushes.Green, Brushes.Blue };        
        public int LineBrush
        {            
            set
            {
                cs.LineBrush = br[value];
            }
        }

        public string FontFamily
        {
            get { return cs.FontFamily; }
            set
            {
                cs.FontFamily = value;
            }
        }
               
        public double FontSize
        {
            get { return cs.FontSize; }
            set
            {                
                cs.FontSize = value;
            }
        }
      
        public string XAxisTitle
        {
            get { return cs.XAxisTitle; }
            set
            {                
                cs.XAxisTitle = value;
            }
        }
        
        public string YAxisTitle
        {
            get { return cs.YAxisTitle; }
            set
            {
                cs.YAxisTitle = value;
            }
        }

        public ChartSurface.ChartSurface cs { get; set; }

        public ObservableCollection<double> LineThicknessItems { get; private set; }
        public ObservableCollection<double> FontSizeItems { get; private set; }
        public ObservableCollection<string> FontFamilyItems { get; private set; }

        public ViewModel()
        {
            cs = new ChartSurface.ChartSurface();
            LineData = new Double[] { 0, 6, 1, 2, 2, 4.6, 3, 3.5, 4, 1.9, 5, 3, 6, 5, 7, 9, 8, 4, 9, 2, 10, 3.5 };
            LineThickness = 2;
            cs.LineBrush = Brushes.DarkRed;
            FontFamily = "Comic Sans MS";
            FontSize = 15;
            XAxisTitle = "xx";
            YAxisTitle = "yy";           

            LineThicknessItems = new ObservableCollection<double>
                {
                2, 4, 6
                };

            FontSizeItems = new ObservableCollection<double>
                {
                10, 12, 14
                };

            FontFamilyItems = new ObservableCollection<string>
                {
                "Arial", "Calibry", "Segoe UI"
                };
        }

    }
}
