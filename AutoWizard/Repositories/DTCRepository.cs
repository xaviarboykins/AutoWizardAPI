using AutoWizard.DbContextFolder;
using AutoWizard.Model;

namespace AutoWizard.Repositories
{
    public class DTCRepository
    {
        private readonly DTCDbContext _dbContext;

        public DTCRepository(DTCDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<DTCCode> GetAll() 
        {
            var listOfCodes = _dbContext.DTCCodes.ToList();
            Console.WriteLine(listOfCodes);
            return listOfCodes;       
        }

        public DTCCode GetByCode(string code) 
        {
            var foundCode = _dbContext.DTCCodes.FirstOrDefault(c => c.Code == code);
            Console.WriteLine(foundCode);
            return foundCode;
        
        }
    }
}
