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
        Instrument GetInstrumentById(int id);
        Instrument PostInstrument(Instrument instrument);
        Instrument PutInstrument(int id ,int qty);
        Instrument DeleteInstrument(int id);
    }
}
