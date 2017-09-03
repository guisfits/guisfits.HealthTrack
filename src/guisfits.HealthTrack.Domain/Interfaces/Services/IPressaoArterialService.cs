﻿using System;
using System.Collections.Generic;
using guisfits.HealthTrack.Domain.Models;

namespace guisfits.HealthTrack.Domain.Interfaces.Services
{
    public interface IPressaoArterialService : IEntityService<PressaoArterial>
    {
        IEnumerable<PressaoArterial> ObterTodosPorUsuario(Guid id);
    }
}
