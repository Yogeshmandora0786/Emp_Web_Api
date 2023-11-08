using WebApplication.Entities;
using WebApplication.Entities.Interface;

namespace WebApplication.Repository
{
    public class CountryRepository : MstCountryInterface
    {
        public void DeleteCountry(int countryid, int intErrorcode, string strErrorDesc)
        {
            throw new NotImplementedException();
        }

        public int InsertCountry(MstCountryClass mstCountryClass)
        {
            throw new NotImplementedException();
        }

        public MstCountryClass SelectAllCountrry(int countryid)
        {
            throw new NotImplementedException();
        }

        public MstCountryClass SelectByIdCountry(MstCountryClass mstCountryClass)
        {
            throw new NotImplementedException();
        }

        public void UpdateCountry(MstCountryClass mstCountryClass)
        {
            throw new NotImplementedException();
        }
    }
}
