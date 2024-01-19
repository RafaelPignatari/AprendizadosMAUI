using ExemploImagem.Helpers;
using System.Collections.ObjectModel;

namespace ExemploImagem;

public partial class LogView : ContentPage
{
    private ListView _listView;

    public LogView()
    {
        InitializeComponent();

        _listView = new ListView
        {
            ItemTemplate = new DataTemplate(() =>
            {
                var textCell = new TextCell();
                textCell.SetBinding(TextCell.TextProperty, ".");
                return textCell;
            })
        };

        Content = new StackLayout
        {
            Children = { _listView }
        };
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var logs = Logger.ObtemLogs();
        _listView.ItemsSource = new ObservableCollection<string>(logs);
    }
}