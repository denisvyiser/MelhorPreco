﻿using MelhorPreco.BUSINESS.Interfaces;
using MelhorPreco.BUSINESS.Repositories;
using MelhorPreco.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelhorPreco.BUSINESS.Repositories
{
    public class Perfil : RepositoryBase<Entities, TB_PERFIL>, IPerfil
    {
    }
}
