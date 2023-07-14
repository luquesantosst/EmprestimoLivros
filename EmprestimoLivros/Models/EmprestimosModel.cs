using EmprestimoLivros.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace EmprestimoLivros.Models
{
    public class EmprestimosModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Digite o nome do Recebedor")]
        public string Recebedor { get; set; }
        [Required(ErrorMessage = "Digite o nome do Fornecedor")]
        public string Fornecedor { get; set; }
        [Required(ErrorMessage = "Digite o nome do livro")]
        public string LivroEmprestado { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Selecione um Status")]
        public StatusEmprestimo? StatusEmprestimos { get; set; } = 0;
    }
}
