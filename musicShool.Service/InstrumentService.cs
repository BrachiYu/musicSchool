using musicSchool.Core.Entities;
using musicShool.Core.Repositories;
using System.Net;

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
        public Instrument GetInstrumentById(int id) {
            return _instrumentRepository.GetInstrumentById(id);
        }
        public Instrument PostInstrument(Instrument instrument) {
            instrument.id++;
            return _instrumentRepository.PostInstrument(instrument);
        }
        public Instrument PutInstrument(int id ,int qty)
        {
            return _instrumentRepository.PutInstrument(id, qty);
        }
        public Instrument DeleteInstrument(int id)
        {
            return _instrumentRepository.DeleteInstrument(id);
        }
        

    }
}