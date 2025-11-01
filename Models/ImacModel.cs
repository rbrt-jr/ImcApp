using System.ComponentModel.DataAnnotations;

namespace ImcApp.Models;

public class ImacModel
{
    [Required]
    [Range(1,3)]
    public double? Height { get; set; }

    [Required]
    [Range(15,180)]
    public double? Weight { get; set; }

    public DateTime CreatedAt { get; set; }= DateTime.Now;

    public double Imc => (Weight ?? 1) / ((Height ?? 1) * (Height ?? 1)) ;
}