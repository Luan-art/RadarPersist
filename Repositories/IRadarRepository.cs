﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRadarRepository
    {
        public bool Inserir(List<Radar> radar);

    }
}
