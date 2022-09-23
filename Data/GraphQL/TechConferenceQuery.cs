using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using TechConference.Repository;

namespace TechConference.Data.GraphQL
{
    public class TechConferenceQuery:ObjectGraphType
    {
        public TechConferenceQuery(SessionRepository sessionRepository)
        {
            Field<ListGraphType<SessionType>>(
                "sessions",
                resolve: context => sessionRepository.GetSessions()
                );

            Field<ListGraphType<SessionType>>(
               "sessionsByDay",
               arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "day" }),
               resolve: context =>
               {
                   var day = context.GetArgument<string>("day");
                   return sessionRepository.GetSessionsByDay(day);
               }

               );
        }
    } 
}
