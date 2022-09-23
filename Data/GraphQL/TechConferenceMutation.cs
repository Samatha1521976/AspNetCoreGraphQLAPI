using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechConference.Api.Data.Entities;
using TechConference.Data.GraphQL.Types;
using TechConference.Repository;

namespace TechConference.Data.GraphQL
{
    public class TechConferenceMutation : ObjectGraphType
    {
        public TechConferenceMutation(SessionRepository sessionRepository, UserRepository userRepository)
        {
            Field<SessionType>(
            "createSession",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<SessionInputType>> { Name = "session" }),
            resolve: context =>
            {
                var session = context.GetArgument<Session>("session");
                return sessionRepository.AddSession(session);
            });

            Field<BooleanGraphType>(
            "login",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<UserInputType>> { Name = "user" }),
            resolve: context =>
            {
                var user = context.GetArgument<User>("user");
                return userRepository.login(user.Email,user.Password);
            });
      
        }
    }
}
