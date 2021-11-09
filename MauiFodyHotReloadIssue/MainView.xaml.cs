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

        public int Counter { get; set; }
    }
}
