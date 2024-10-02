﻿using System.ComponentModel.DataAnnotations;

namespace Churrasco.Validacao
{
    public class ValidacaoNome : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is null)
            {
                return new ValidationResult("Nome não pode ser null");
            }

            string nome = (string)value;

            return nome.Length >= 3 && nome.Length <= 225 ? ValidationResult.Success : new ValidationResult(ErrorMessage);
        }
    }
}