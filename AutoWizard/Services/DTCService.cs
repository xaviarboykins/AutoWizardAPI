using AutoWizard.Model;
using AutoWizard.Repositories;


namespace AutoWizard.Services
{
    public class DTCService
    {
        private readonly DTCRepository _dTCRepository;

        public DTCService(DTCRepository dTCRepository)
        {
            _dTCRepository = dTCRepository;
        }

        public DTCCode GetByCode(string code)
        {
            var result = _dTCRepository.GetByCode(code);
            
            return result;
        }

        public List<DTCCode> GetAll()
        {
            return _dTCRepository.GetAll();
        }
    }
}
