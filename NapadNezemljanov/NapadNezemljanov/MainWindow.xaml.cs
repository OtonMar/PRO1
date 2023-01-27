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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NapadNezemljanov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            DodajSovražnika();
        }

        private void DodajSovražnika()
        {
            ContentControl sovražnik = new ContentControl();
            sovražnik.Template = Resources["predlogaSovraznika"] as ControlTemplate;
            AnimirajSovražnika(sovražnik, 0, (int)(IgralniDel.ActualWidth - 100), "(Canvas.Left)");
            int višina = (int)(IgralniDel.ActualHeight - 100);
            AnimirajSovražnika(sovražnik, r.Next(višina), r.Next(višina), "(Canvas.Top)");
            IgralniDel.Children.Add(sovražnik);
        }

        private void AnimirajSovražnika(ContentControl sovražnik, int v1, int v2, string v3)
        {
            Storyboard zgodba = new Storyboard()
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };
        DoubleAnimation animacija = new DoubleAnimation()
        {
            From = v1,
            To = v2,
            Duration = new Duration(TimeSpan.FromSeconds(r.Next(4, 6)))
        };
        PropertyPath x = new PropertyPath(v3);
        Storyboard.SetTarget(animacija, sovražnik);
        Storyboard.SetTargetProperty(animacija, x);
        zgodba.Children.Add(animacija);
            zgodba.Begin();
        }
    }
}
