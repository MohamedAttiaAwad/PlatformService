using PlatformService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext AppDbContext;
        public PlatformRepo(AppDbContext appDbContext)
        {
            this.AppDbContext = appDbContext;
        }


        public void CreatePlatform(Platform platform)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            throw new NotImplementedException();
        }

        public Platform GetPlatformById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
