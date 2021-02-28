﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimalMoving.Domain
{
    public interface ITableRow
    {
        int Id { get; }
        IAircraftId AircraftId { get; }
        IMoment EngineStartMoment { get; }
        bool IsPlannedMomentFeasible { get; }
    }
}
