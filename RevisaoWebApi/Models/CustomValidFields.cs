﻿using RevisaoWebApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace RevisaoWebApi.Models
{
    public class CustomValidFields : ValidationAttribute
    {
        ContextDb dB = new ContextDb();

        private ValidFields typeField;

        public CustomValidFields(ValidFields type)
        {
            typeField = type;

        }
         protected override ValidationResult IsValid(object value, ValidationContext validationContext)
         {
            if(value != null)
            {
                switch (typeField)
                {
                    case ValidFields.ValidaLogin: return ValidarLogin(value, validationContext.DisplayName);
                     
                    case ValidFields.ValidaEmail:return ValidarEmail(value, validationContext.DisplayName);
                 
                    case ValidFields.ValidaSenha: return ValidarSenha(value, validationContext.DisplayName);
                    
                    case ValidFields.ValidaNome: return ValidarNome(value, validationContext.DisplayName);
                       
                    default:
                        break;
                }
            }
            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório.");
         }
        private ValidationResult ValidarEmail(object value, string displayFields)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (result)
                return ValidationResult.Success;
            return new ValidationResult($"O campo {displayFields} é inválido!");
        }

        private ValidationResult ValidarSenha(object value, string displayFields)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^(?:(?=.*?\p{N})(?=.*?[\p{S}\p{P} ])(?=.*?\p{Lu})(?=.*?\p{Ll}))[^\p{C}]{8,16}$");


            if (result)
                return ValidationResult.Success;
                return new ValidationResult($"O campo {displayFields} é inválido." +
               $"O mesmo precisa conter ao menos: \n " +
               $"1 Caractere Especial, 1 Letra Maiúscula, " +
               $"1 Número e entre 8 à 16 caracteres.");
        }

        private ValidationResult ValidarNome(object value, string displayFields)
        {
            bool result = Regex.IsMatch(value.ToString(), "^(([a-zA-Z ]|[é])*)$");

            if (result)
            return ValidationResult.Success;
            return new ValidationResult($"O campo {displayFields} é inválido!");
        }


        private ValidationResult ValidarLogin(object value, string displayFields)
        {
            Usuario user = dB.usuarios.FirstOrDefault(x => x.Login == value.ToString());

            if (user == null)
                return ValidationResult.Success;
            else
                return new ValidationResult($"Este campo {displayFields} já está cadastrado na nossa base de dados!");
        }

    }

}