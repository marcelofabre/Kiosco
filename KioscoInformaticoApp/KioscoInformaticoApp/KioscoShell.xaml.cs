using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp.Class;
using KioscoInformaticoApp.ViewModels;

namespace KioscoInformaticoApp
{
    public partial class KioscoShell : Shell
    {
        public KioscoShell()
        {
            InitializeComponent();
            FlyoutItemsPrincipal.IsVisible = false; // Oculta el menú lateral
        }

        //private async void OnReceiveMessage(Message mensaje)
        public void EnableAppAfterLogin()
        {
            FlyoutBehavior = FlyoutBehavior.Flyout; // Habilita el FlyOut
            FlyoutItemsPrincipal.IsVisible = true; // Muestra el menú lateral
            Shell.Current.GoToAsync("//MainPage"); // Navega a la página principal
            var viewmodel = this.BindingContext as KioscoShellViewModel;//Se obtiene el viewmodel de la vista
            viewmodel.IsUserLogout = false;//Se cambia el estado de la variable que controla el estado del usuario
        }
        public void DisableAppAfterLogin()
        {
            FlyoutBehavior = FlyoutBehavior.Disabled; // Deshabilita el FlyOut
            FlyoutItemsPrincipal.IsVisible = false; // Oculta el menú lateral
            Shell.Current.GoToAsync("//Login"); // Navega a la página de login
        }
    }
    
}
