﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using guisfits.HealthTrack.Domain.Models;
using System.ComponentModel;

namespace guisfits.HealthTrack.Application.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public Guid Id { get; set; }

        public UsuarioViewModel()
        {
            Id = Guid.NewGuid();
            Alimentos = new List<Alimento>();
            ExerciciosFisicos = new List<ExercicioFisico>();
            PressoesArteriais = new List<PressaoArterial>();
            PesosKg = new List<Peso>();
        }

        [Required(ErrorMessage = "O campo Nome é requerido")]
        [MaxLength(30, ErrorMessage = "O tamanho máximo de caracteres é de {0}")]
        [MinLength(2, ErrorMessage = "O tamanho mínimo de caracteres é de {0")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Sobrenome é requerido")]
        [MaxLength(300, ErrorMessage = "O tamanho máximo de caracteres é de {0}")]
        [MinLength(2, ErrorMessage = "O tamanho mínimo de caracteres é de {0")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "O campo E-mail é requerido")]
        [MaxLength(300, ErrorMessage = "O tamanho máximo de caracteres é de {0}")]
        [MinLength(2, ErrorMessage = "O tamanho mínimo de caracteres é de {0")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Sexo é requerido")]
        [DisplayName("Sexo")]
        public TipoSexo Sexo { get; set; }

        [Required(ErrorMessage = "O campo Altura (m) é requerido")]
        [DisplayName("Altura (m)")]
        public double AlturaMetros { get; set; }

        [Required(ErrorMessage = "O campo Data de Nascimento é requerido")]
        [DisplayName("Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data de Nascimento em formato inválido")]
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessage = "O campos Peso Atual é requerido")]
        [DisplayName("Peso Atual")]
        public double PesoAtual { get; set; }

        [ScaffoldColumn(false)]
        public bool Excluido { get; private set; } = false;

        [ScaffoldColumn(false)]
        public virtual IList<Peso> PesosKg { get; set; }

        [ScaffoldColumn(false)]
        public virtual ICollection<Alimento> Alimentos { get; set; }

        [ScaffoldColumn(false)]
        public virtual ICollection<ExercicioFisico> ExerciciosFisicos { get; set; }

        [ScaffoldColumn(false)]
        public virtual ICollection<PressaoArterial> PressoesArteriais { get; set; }
    }
}
