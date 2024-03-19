using System.Collections.Generic;
using System.Windows;
using testelis;

namespace AnimalApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Zvíře> zvířata = new List<Zvíře>();
            zvířata.Add(new Pes("Vlk", 4, false, "hnědá"));
            zvířata.Add(new Kočka("Václav Doškář", 4, false, "šedá"));
            zvířata.Add(new Pták("Péro", 2, true, "žlutá", 10));
            zvířata.Add(new Had("Hrad", 0, false, "zelená", true));
            zvířata.Add(new Had("Ivan", 0, false, "zelenožlutá", false));

            animalListBox.ItemsSource = zvířata;
        }

        private void animalListBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            
        }
    }

   

    
}