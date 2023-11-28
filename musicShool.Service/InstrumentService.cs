using musicSchool.Core.Entities;
using musicShool.Core.Repositories;

namespace musicShool.Service
{
    public class InstrumentService
    {
        private readonly IInstrumentRepository _instrumentRepository;
        public InstrumentService(IInstrumentRepository instrumentRepository)
        {
            _instrumentRepository = instrumentRepository;
        }
        public List<Instrument> GetAllInstruments() {
            return _instrumentRepository.GetInstruments();
        }




    }
}