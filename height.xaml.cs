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

namespace SemaInterface
{
    /// <summary>
    /// Interaction logic for height.xaml
    /// </summary>
    public partial class height : UserControl
    {
        public height()
        {
            InitializeComponent();
        }

        public double pointerValue;
        public void Translate()
        {
            TranslateTransform height = new TranslateTransform();
            state.RenderTransform = height;

            value.Content = pointerValue.ToString();
        }
    }
}
