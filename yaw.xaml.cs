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
    /// Interaction logic for yaw.xaml
    /// </summary>
    public partial class yaw : UserControl
    {
        public yaw()
        {
            InitializeComponent();
        }

        public double pointerValue;
        public void Rotate()
        {
            RotateTransform rotate = new RotateTransform(pointerValue);
            arrow.RenderTransform = rotate;
            line.RenderTransform = rotate;

            value.Content = pointerValue.ToString() + "°";
        }
    }
}
