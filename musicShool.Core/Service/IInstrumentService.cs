﻿using musicSchool.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicShool.Core.Service
{
    public interface IInstrumentService
    {
        List<Instrument>GetAllInstruments();
    }
}