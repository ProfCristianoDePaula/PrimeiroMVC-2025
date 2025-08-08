namespace PrimeiroMVC.Models
{
    public class Aluno
    {
        // Nome do campo de Id deve ser AlunoId para seguir a convenção de nomenclatura (Nome da Classe + Id)
        public int AlunoId { get; set; }  // Observação: AlunoId é a chave primária
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
