﻿using System;

namespace guisfits.HealthTrack.Domain.Models
{
    public enum TipoExercicio { Caminhada, Corrida, Pedalada, Musculacao }

    public class ExercicioFisico : Entity
    {
        public TipoExercicio Tipo { get; set; }
        public string Descricao { get; set; }
        public double Calorias { get; set; }
        public DateTime DataHora { get; set; }
        public Guid UsuarioId { get; set; }

        //Para o Lazy loading do EntityFramework
        public virtual Usuario Usuario { get; set; }

        public ExercicioFisico(TipoExercicio tipo, double calorias, DateTime dataHora, string descricao = "")
        {
            this.Tipo = tipo;
            this.Descricao = descricao;
            this.Calorias = calorias;
            this.DataHora = dataHora;
        }

        public ExercicioFisico()
        {

        }

        protected override bool EhValido()
        {
            //tem que validar!!!
            return true;
        }
    }
}