using EnvWindows5.Données;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EnvWindows5
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Regions listRegion = new Regions();
        private String regionSelect;


        public MainPage()
        {
            this.InitializeComponent();
            listRegion.chargermentRegions();
            listeRegion.DataContext = listRegion;
        }

        private void listeRegion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Region tmp = (Region)listeRegion.SelectedItem;
            regionSelect = tmp.Nom;
            listeDepartements.DataContext = listRegion[regionSelect];
        }
    }
}
