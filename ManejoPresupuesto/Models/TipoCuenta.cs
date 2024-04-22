﻿using ManejoPresupuesto.Validaciones;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class TipoCuenta/*: IValidatableObject*/
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        //[StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1}")]
        //[Display(Name = "Nombre")]
        [PrimeraLetraMayuscula]
        [Remote(action:"VerificarExisteTipoCuenta", controller:"TiposCuentas")]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (Nombre != null && Nombre.Length > 0)
        //    {
        //        var primeraLetra = Nombre[0].ToString();

        //        if (primeraLetra != primeraLetra.ToUpper())
        //        {
        //            yield return new ValidationResult("La primera letra debe ser mayuscula", new[] { nameof(Nombre)}) ;
        //        }
        //    }
        //}

        /*Pruebas de otras validaciones por defecto*/
        //[Required(ErrorMessage = "El campo {0} es requerido")]
        //[EmailAddress(ErrorMessage = "El campo debe ser un correo electronico valido")]
        //public string Email { get; set; }

        //[Range(minimum: 18, maximum: 130, ErrorMessage = "El valor debe estar entre {1} y {2}")]
        //public int Edad { get; set; }

        //[Url(ErrorMessage = "El campo debe ser una URL valida")]
        //public string URL { get; set; }

        //[CreditCard(ErrorMessage = "La tarjeta de credito no es valida")]
        //[Display(Name = "Tarjeta de Credito")]
        //public string TarjetaDeCredito { get; set; }

    }
}
