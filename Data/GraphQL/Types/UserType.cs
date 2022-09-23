using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechConference.Api.Data.Entities;

namespace TechConference.Data.GraphQL.Types
{
    public class UserType :ObjectGraphType<User>
    {
        public UserType()
        {
            Field(t => t.Email);
        }
    }
}
