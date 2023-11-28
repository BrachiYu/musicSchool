using System;
using System.Collections.Generic;
using musicSchool.Core.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicShool.Core.Repositories
{
    public interface IInstrumentRepository
    {
        List<Instrument> GetInstruments();
    }
}
