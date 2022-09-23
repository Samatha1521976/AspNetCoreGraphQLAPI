using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechConference.Data.GraphQL
{
    public class TechConferenceSchema :Schema
    {
        public TechConferenceSchema(IServiceProvider resolver): base(resolver)
        {
            Query = (IObjectGraphType)resolver.GetService(typeof(TechConferenceQuery));
            Mutation = (IObjectGraphType)resolver.GetService(typeof(TechConferenceMutation));
        }
    }   
}
