using ExemploAplicativo.ViewModels;

namespace ExemploAplicativo.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void btnFuncionario1_Clicked(object sender, EventArgs e)
    {
        var funcionarioViewModel = new DetalhesFuncionarioViewModel
        {
            Id = 1,
            Nome = "John Doe",
            Email = "",
            Ativo = true
        };

        var viewDetalhesFuncionario = new DetalhesFuncionarios();
        viewDetalhesFuncionario.BindingContext = funcionarioViewModel;

        Navigation.PushAsync(viewDetalhesFuncionario);
    }

    private void btnFuncionario2_Clicked(object sender, EventArgs e)
    {
        var funcionarioViewModel = new DetalhesFuncionarioViewModel
        {
            Id = 2,
            Nome = "John Doe",
            Email = "",
            Ativo = true
        };

        var viewDetalhesFuncionario = new DetalhesFuncionarios();
        viewDetalhesFuncionario.BindingContext = funcionarioViewModel;

        Navigation.PushAsync(viewDetalhesFuncionario);
    }

    private void btnFuncionario3_Clicked(object sender, EventArgs e)
    {
        var funcionarioViewModel = new DetalhesFuncionarioViewModel
        {
            Id = 3,
            Nome = "John Doe",
            Email = "",
            Ativo = true
        };

        var viewDetalhesFuncionario = new DetalhesFuncionarios();
        viewDetalhesFuncionario.BindingContext = funcionarioViewModel;

        Navigation.PushAsync(viewDetalhesFuncionario);
    }
}