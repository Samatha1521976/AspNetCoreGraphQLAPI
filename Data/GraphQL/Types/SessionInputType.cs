using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace TechConference.Data.GraphQL.Types
{
    public class SessionInputType : InputObjectGraphType
    {
        public SessionInputType()
        {
            Name = "sessionInput";
            Field<NonNullGraphType<StringGraphType>>("title");
            Field<StringGraphType>("description");
            Field<NonNullGraphType<StringGraphType>>("room");
            Field<StringGraphType>("day");
            Field<NonNullGraphType<StringGraphType>>("format");

        }
    }
}
