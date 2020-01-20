using PokemonAPI.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Controls;
using static PokemonAPI.classes.Pokemon;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PokemonAPI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "resulten")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private List<Result> _result = new List<Result>();

        public List<Result> Resulten
        {
            get { return _result; }
            set { _result = value; NotifyPropertyChanged(); }
        }

        private async void GetPokemons()
        {
            //Resulten = await PokemonWrapper.GetPokemons();
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        public MainPage()
        {
            this.InitializeComponent();
        }
    }
}
