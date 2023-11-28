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
    }
}
