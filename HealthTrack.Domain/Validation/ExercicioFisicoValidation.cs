﻿using System;
using FluentValidation;
using HealthTrack.Domain.Models;

namespace HealthTrack.Domain.Validation
{
    public class ExercicioFisicoValidation : AbstractValidator<ExercicioFisico>
    {
        public ExercicioFisicoValidation()
        {
            RuleFor(c => c.DataHora)
                .LessThan(DateTime.Now).WithMessage("Data deve ser menor que a data atual")
                .GreaterThan(DateTime.Now.AddYears(-1)).WithMessage($"Ano deve ser maior que {DateTime.Now.AddYears(-1).Year}");

            RuleFor(c => c.Calorias)
                .InclusiveBetween(0, 2000).WithMessage("Calorias deve ser entre 0 a 2000");

            RuleFor(c => c.Descricao)
                .MaximumLength(200).WithMessage("Tamanho máximo de caracteres excedido");

            RuleFor(c => c.Tipo)
                .NotNull().WithMessage("Tipo de Exercício não deve ser nulo");
        }
    }
}
