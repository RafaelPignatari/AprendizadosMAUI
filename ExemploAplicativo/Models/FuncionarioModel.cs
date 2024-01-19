
namespace ExemploAplicativo.Models
{
    class FuncionarioModel
    {
        public int Id { get; set; } = 1;
        public string Nome { get; set; }
        public string Email { get; set; } = "";
        public bool Ativo { get; set; }
    }
}
