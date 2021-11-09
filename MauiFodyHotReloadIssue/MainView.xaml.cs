using Microsoft.Maui.Controls;
using Prism.Mvvm;
using System.Windows.Input;

namespace MauiFodyHotReloadIssue
{
    public partial class MainView
    {
        public MainView()
        {
            InitializeComponent();
        }
    }

    public class MainViewModel : BindableBase
    {
        public MainViewModel()
        {
            IncreaseCounter = new Command(() => Counter++);
        }

        public ICommand IncreaseCounter { get; set; }

        private int _Counter;

        public int Counter
        {
            get => _Counter;
            set => SetProperty(ref _Counter, value);
        }
    }
}
