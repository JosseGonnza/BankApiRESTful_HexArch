using FluentValidation;

namespace Application.Features.Clients.Commands.CreateClientCommand
{
    public class CreateClientCommandValidator : AbstractValidator<CreateClientRequest>
    {
        public CreateClientCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacío.")
                .MaximumLength(80).WithMessage("{PropertyName} no puede exceder de {MaxLength} caracteres.");
            
            RuleFor(p => p.LastName)
                .NotEmpty().WithMessage("Apellido no puede estar vacío.")
                .MaximumLength(80).WithMessage("Apellido no puede exceder de {MaxLength} caracteres.");

            RuleFor(p => p.DateOfBirth)
                .NotEmpty().WithMessage("Fecha de nacimiento no puede estar vacía.");
            
            RuleFor(p => p.PhoneNumber)
                .NotEmpty().WithMessage("Teléfono no puede estar vacío.")
                .Matches(@"^\d{3}-\d{3}-\d{3}$").WithMessage("Teléfono debe cumplir el formato 000-000-000.")
                .MaximumLength(11).WithMessage("Teléfono no puede exceder de {MaxLength} caracteres.");

            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("{PropertyName} no puede estar vacío.")
                .EmailAddress().WithMessage("{PropertyName} debe ser una dirección de email válida.")
                .MaximumLength(100).WithMessage("{PropertyName} no puede exceder de {MaxLength} caracteres.");

            RuleFor(p => p.Address)
                .NotEmpty().WithMessage("Dirección no puede estar vacío.")
                .MaximumLength(120).WithMessage("Dirección no puede exceder de {MaxLength} caracteres.");

        }
    }
}
