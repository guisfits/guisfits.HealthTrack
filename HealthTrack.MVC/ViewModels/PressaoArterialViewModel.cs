﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HealthTrack.MVC.ViewModels
{
    public class PressaoArterialViewModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "O campo de pressão Sistólica é requirido")]
        [DisplayName("Sistólica")]
        public float? Sistolica { get; set; }

        [Required(ErrorMessage = "O campo de pressão Diastólica é requirido")]
        [DisplayName("Diastólica")]
        public float? Diastolica { get; set; }

        [DisplayName("Status")]
        public string Status { get; set; }

        [Required(ErrorMessage = "O campo Data e Hora é requerido")]
        [DisplayName("Data e Hora")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:g}")]
        [DataType(DataType.DateTime, ErrorMessage = "Data e Hora em formato inválido")]
        public DateTime DataHora { get; set; }

        [Required(ErrorMessage = "O campo {0} é requerido")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "O campo {0} é requerido")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        [DataType(DataType.Time, ErrorMessage = "Hora em formato inválido")]
        public DateTime Hora { get; set; }

        [ScaffoldColumn(false)]
        public string UsuarioId { get; set; }

        public DateTime ObterDataCompleta()
        {
            return DateTime.Parse($"{Data.ToShortDateString()} {Hora.ToShortTimeString()}");
        }
    }
}
