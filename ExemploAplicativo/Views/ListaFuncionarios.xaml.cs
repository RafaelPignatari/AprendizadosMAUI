using ExemploAplicativo.Models;
using ExemploAplicativo.ViewModels;

namespace ExemploAplicativo.Views;

public partial class ListaFuncionarios : ContentPage
{
	public ListaFuncionarios()
	{
		InitializeComponent();

		BindingContext = new FuncionariosViewModel();
	}

    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		var funcionario = (FuncionarioModel) e.Item;
		var detalhesFuncionario = new DetalhesFuncionarioViewModel() { Funcionario = funcionario };

		Navigation.PushAsync(new DetalhesFuncionarios() { BindingContext = detalhesFuncionario});
    }
}