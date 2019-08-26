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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RateAnimation1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void UIElement_OnPointerEntered(object sender, PointerRoutedEventArgs e)
        {
            // Pointer Entered
        }

        private void UIElement_OnPointerExited(object sender, PointerRoutedEventArgs e)
        {
            // Pointer Exited
        }

        private void UIElement_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            // Pointer Tapped
        }

        private void FrameworkElement_OnLoaded(object sender, RoutedEventArgs e)
        {
            // Empty
        }
    }
}
