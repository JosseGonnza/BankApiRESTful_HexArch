using FluentValidation;

namespace Application.Features.Clients.Commands.CreateClientCommand
{
    public class CreateClientCommandValidator : AbstractValidator<CreateClientRequest>
    {
        public CreateClientCommandValidator()
        {
            RuleFor(p => p.Nombre)
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacío.")
                .MaximumLength(80).WithMessage("{PropertyName} no puede exceder de {MaxLength} caracteres.");
            
            RuleFor(p => p.Apellido)
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacío.")
                .MaximumLength(80).WithMessage("{PropertyName} no puede exceder de {MaxLength} caracteres.");

            RuleFor(p => p.FechaNacimineto)
                .NotEmpty().WithMessage("Fecha de nacimiento no puede estar vacía.");
            
            RuleFor(p => p.Telefono)
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacío.")
                .Matches(@"^\d{3}-\d{3}-\d{3}$").WithMessage("{PropertyName} debe cumplir el formato 000-000-000.")
                .MaximumLength(9).WithMessage("{PropertyName} no puede exceder de {MaxLength} caracteres.");

            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacío.")
                .EmailAddress().WithMessage("{PropertyName} debe ser una dirección de email válida.")
                .MaximumLength(100).WithMessage("{PropertyName} no puede exceder de {MaxLength} caracteres.");

            RuleFor(p => p.Direccion)
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacío.")
                .MaximumLength(120).WithMessage("{PropertyName} no puede exceder de {MaxLength} caracteres.");

        }
    }
}
