using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public abstract record BookDtoForManipulation
    {
        [Required(ErrorMessage = "Başlık alanı zorunludur.")]
        [MinLength(2, ErrorMessage = "Başlık en az 2 karakterden oluşmalıdır.")]
        [MaxLength(30, ErrorMessage = "Başlık en fazla 30 karakterden oluşmalıdır.")]
        public string? Title { get; init; }
    }
}
