using System.Windows;

namespace DemoApp
{
    public partial class MainWindow : Window
    {    
        public MainWindow()
        {
            InitializeComponent();

            ViewModel VM = new ViewModel();
            RBGrid.DataContext = VM;
            FGrid.DataContext = VM;
            CS.DataContext = VM.cs;                 
        }
    }
}
