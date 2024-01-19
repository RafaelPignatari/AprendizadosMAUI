using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExemploAplicativo.Models;
using System.Collections.ObjectModel;

namespace ExemploAplicativo.ViewModels
{
    internal partial class FuncionariosViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<FuncionarioModel> funcionarios = new();

        [ObservableProperty]
        private FuncionarioModel funcionario = new();

        [RelayCommand]
        private void Adicionar()
        {
            Funcionarios.Add(Funcionario);
            Funcionario = new FuncionarioModel();
        }
    }
}
