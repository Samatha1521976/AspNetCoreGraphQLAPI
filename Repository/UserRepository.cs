using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechConference.Data;

namespace TechConference.Repository
{
    public class UserRepository
    {

        public TechConferenceDbContext _dbContext;
        public UserRepository(TechConferenceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool login(string email,string  password)
        {
            var user =  this._dbContext.Users.Where(u => u.Email == email && u.Password == password).FirstOrDefault();
            return user == null ? false : true;
        }
    }
}
