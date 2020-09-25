using System.Collections.Generic;
using API.Models.Repository.IRepository;

namespace API.Models.Repository
{
    public class NationalRepository : INationalRepository
    {
        public bool CreateNationalPark(NationalPark nationalPark)
        {
            throw new System.NotImplementedException();
        }

        public NationalPark GetNationalPark(int nationalParkId)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<NationalPark> GetNationalParks()
        {
            throw new System.NotImplementedException();
        }

        public bool NationalParkExists(string name)
        {
            throw new System.NotImplementedException();
        }

        public bool NationalParkExists(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Save()
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateNationalPark(NationalPark nationalPark)
        {
            throw new System.NotImplementedException();
        }
    }
}