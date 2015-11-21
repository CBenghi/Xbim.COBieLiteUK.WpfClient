using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using XbimExchanger.IfcToCOBieLiteUK;

namespace Xbim.WpfClient
{
    /// <summary>
    /// Interaction logic for COBieLiteUkExportConfigurator.xaml
    /// </summary>
    public partial class COBieLiteUkExportConfigurator : UserControl
    {
        public COBieLiteUkExportConfigurator()
        {
            InitializeComponent();
            SetDataContext();
        }

        private void SetDataContext()
        {

            var items = new ObservableCollection<SystemExtractionMode>
            {
                SystemExtractionMode.PropertyMaps,
                SystemExtractionMode.Types
            };
            DataContext = items;
        }
    }
}
