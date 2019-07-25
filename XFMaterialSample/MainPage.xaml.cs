using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;
using XF.Material.Forms.UI;
using XF.Material.Forms.UI.Dialogs;

namespace XFMaterialSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.On<iOS>().SetUseSafeArea(true);
            InitializeComponent();
           
        }

        async void btnDialogClicked(object sender, EventArgs args)
        {
            await MaterialDialog.Instance.AlertAsync(message: "Nome meu Github tem mais de 100 Exemplos de Xamarin.Forms",
                                    title: "Fica a dica",
                                    acknowledgementText: "EU QUERO!");
        }

        async void btnRadiobuttonClicked(object sender, EventArgs args)
        {
            var choices = new string[]
             {
                "É BOT",
                "É Magia",
                "Não Dorme é um Vampiro",
                "Só Deus Sabe"
             };

            var view = new MaterialRadioButtonGroup()
            {
                Choices = choices
            };

            bool? wasConfirmed = await MaterialDialog.Instance.ShowCustomContentAsync(view, "O Renato Groffe é onipresente?", "Duvida");
        }

        async void btnCheckBoxClicked(object sender, EventArgs args)
        {
            var jobs = new string[]
            {
                "Bertuzzi",
                "Ericson Fonseca",
                "Renato Groffe",
                "Thiago Adriano",
                "Luiz Carlos",
                "Milton Camara",
                "Andre Secco",
                "Ewerton"
            };

            var result = await MaterialDialog.Instance.SelectChoicesAsync(title: "Quem dessa galera você conhece o conteudo?",
                                                              choices: jobs);
        }
    }
}
