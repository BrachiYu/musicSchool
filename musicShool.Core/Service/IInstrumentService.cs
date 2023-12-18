using musicSchool.Core.Entities;
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
        Instrument GetInstrumentById(int id);
        Instrument PostInstrument(Instrument instrument);
        Instrument PutInstrument(int id, int qty);
        Instrument DeleteInstrument(int id);
    }
}
