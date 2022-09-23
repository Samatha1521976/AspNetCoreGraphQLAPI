using System;
using GraphQL.Types;
using TechConference.Api.Data.Entities;

namespace TechConference.Data.GraphQL
{
    public class SessionType:ObjectGraphType<Session>
    {
        public SessionType()
        {
            Field(t => t.Id);
            Field(t => t.Title);
            Field(t => t.Description);
            Field(t => t.Day);
            Field(t => t.Format);

        }
    }
}
