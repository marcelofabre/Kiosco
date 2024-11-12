using CommunityToolkit.Mvvm.Messaging;
using Firebase.Auth.Repository;
using Firebase.Auth;
using KioscoInformaticoApp.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth.Providers;
using Microsoft.Maui.Storage;

namespace KioscoInformaticoApp.ViewModels
{

        public partial class InicioSesionViewModel : ObservableObject
        
        {
            public readonly FirebaseAuthClient _clientAuth;
            private FileUserRepository _userRepository;
            private UserInfo _userInfo;
            private FirebaseCredential _firebaseCredential;

            [ObservableProperty]
            [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
            private string mail;

            [ObservableProperty]
            [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
            private string password;

            [ObservableProperty]
            private bool rememberPassword;
          

            public IRelayCommand LoginCommand { get; }
            public IRelayCommand RegisterCommand { get; }
            public InicioSesionViewModel()
            {
            _clientAuth = new FirebaseAuthClient(new FirebaseAuthConfig()
            {
                ApiKey = "AIzaSyCf5n4GEXeFsuGV3DpNdVyEdtb3_sQyX-c",
                AuthDomain = "kioscoinformatico-ec154.firebaseapp.com",
                Providers = new Firebase.Auth.Providers.FirebaseAuthProvider[]
            {
                    new EmailProvider()
            }
            });
            _userRepository = new FileUserRepository("KioscoInformatico");
            ChequearSiHayUsuarioAlmacenado();
            LoginCommand = new RelayCommand(Login, AllowLogin);
            RegisterCommand = new RelayCommand(register);
        }

        public async void register()
        {
            await Shell.Current.GoToAsync("Registrarse");
        }

        private async void ChequearSiHayUsuarioAlmacenado()
            {
                if (_userRepository.UserExists())
                {
                    (_userInfo, _firebaseCredential) = _userRepository.ReadUser();

                    var shellkiosco = (KioscoShell)App.Current.MainPage;
                    shellkiosco.EnableAppAfterLogin();
            }
            }

            public bool AllowLogin()


                {
                   return !string.IsNullOrEmpty(Mail) && !string.IsNullOrEmpty(Password);
                }

        public async void Login()
        {
            try
            {

                var userCredential = await _clientAuth.SignInWithEmailAndPasswordAsync(Mail, Password);
                if (userCredential.User.Info.IsEmailVerified == false)
                {
                    await Application.Current.MainPage.DisplayAlert("Inicio de sesión", "Debe verificar su correo electrónico", "Ok");
                    return;
                }

                if (rememberPassword)
                {
                    _userRepository.SaveUser(userCredential.User);
                }
                else
                {
                    _userRepository.DeleteUser();
                }

                var shellkiosco = (KioscoShell)App.Current.MainPage;
                shellkiosco.EnableAppAfterLogin();

            }
            catch (FirebaseAuthException error)
            {
                await Application.Current.MainPage.DisplayAlert("Inicio de sesión", "Ocurrió un problema:" + error.Reason, "Ok");

            }
            

            }
        }
}
