using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTOs
{
    public class UpdateFilmeDto
    {
        [Required(ErrorMessage = "O campo titulo é obrigatório.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatório.")]
        public string Diretor { get; set; }
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "Só é permitido filmes com duração de no máximo 600 minutos (10 horas).")]
        public int Duracao { get; set; }
    }
}
