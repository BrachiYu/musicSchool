using musicSchool.Core.Entities;
using musicShool.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicSchool.Data
{
    public class InstrumentRepository:IInstrumentRepository
    {
        private readonly DataContext _context;
        public InstrumentRepository(DataContext context)
        {
            _context = context;
        }

        public List<Instrument> GetInstruments()
        {
            return _context.InsList;
        }

        public Instrument GetInstrumentById(int id)
        {
             var i =_context.InsList.Find(e => e.id == id);
            return i;
        }

        public Instrument PostInstrument(Instrument instrument)
        {
            _context.InsList.Add(instrument);
            return instrument;
        }
        public Instrument PutInstrument(int id ,int qty)
        {
            var i=_context.InsList.Find(e => e.id == id);
            var ii = i;
            ii.qty = qty;
            _context.InsList.Remove(i);
            _context.InsList.Add(ii);
            return ii;
        }
        public Instrument DeleteInstrument(int id)
        {
            var i = _context.InsList.Find(e => e.id == id);
            if(i != null)
                _context.InsList.Remove(i);
            return i;
        }
        
    }
}
