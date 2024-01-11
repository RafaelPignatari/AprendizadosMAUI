using ExemploAplicativo.ViewModels;

namespace ExemploAplicativo.Views;

public partial class DetalhesFuncionarios : ContentPage
{
	public DetalhesFuncionarios()
	{
		InitializeComponent();

		var viewModel = new DetalhesFuncionarioViewModel
		{
			Id = 1,
			Nome = "John Doe",
			Email = ""
		};

		BindingContext = viewModel;
	}
}