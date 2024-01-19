using CommunityToolkit.Mvvm.ComponentModel;
using ExemploAplicativo.Models;

namespace ExemploAplicativo.ViewModels
{
    partial class DetalhesFuncionarioViewModel : ObservableObject
    {
        [ObservableProperty]
        private FuncionarioModel funcionario;
    }
}
