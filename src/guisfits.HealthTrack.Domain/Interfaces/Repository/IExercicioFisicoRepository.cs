﻿using System;
using System.Collections.Generic;
using guisfits.HealthTrack.Domain.Models;

namespace guisfits.HealthTrack.Domain.Interfaces.Repository
{
    public interface IExercicioFisicoRepository : IRepository<ExercicioFisico>
    {
        IEnumerable<ExercicioFisico> ObterTodosPorUsuario(Guid id);
    }
}
