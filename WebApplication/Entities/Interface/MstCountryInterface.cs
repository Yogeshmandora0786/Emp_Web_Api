namespace WebApplication.Entities.Interface
{
    public interface MstCountryInterface
    {
        int InsertCountry(MstCountryClass mstCountryClass);
        void UpdateCountry(MstCountryClass mstCountryClass);
        void DeleteCountry(int countryid, int intErrorcode , string strErrorDesc);
        MstCountryClass SelectByIdCountry(MstCountryClass mstCountryClass);
        MstCountryClass SelectAllCountrry (int countryid);
    }
}
