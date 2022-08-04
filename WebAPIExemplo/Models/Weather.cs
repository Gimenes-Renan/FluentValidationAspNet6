using FluentValidation;

namespace WebAPIExemplo.Models
{
    public class Weather
    {
        public int? Valor { get; set; }
        public string Nome { get; set; }
    }

    public class WeatherValidator : AbstractValidator<Weather>
    {
        public WeatherValidator()
        {
            RuleFor(x => x.Valor)
                .NotEmpty().WithMessage("Mensagem de aleluia")
                .GreaterThan(10).WithMessage("Maior que 10 mano brow");

            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("Se esse cara é vazio ou espaço");
        }
    }
}
