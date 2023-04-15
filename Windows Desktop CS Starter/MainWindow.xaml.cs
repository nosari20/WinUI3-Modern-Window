using Microsoft.UI.Xaml;

namespace Windows_Desktop_CS_Starter
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {

   
        public MainWindow()
        {
            this.InitializeComponent();
            ModernWindow m_SetSystemBackdrop = new ModernWindow(this);
            

        }
    }
}


   

   

