using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MyTweets.Features.Tweets
{
    public class List
    {
        public class Query : IRequest<Model>
        {
        }

        public class Model
        {
            public List<string> Tweets { get; set; }
        }

        public class QueryHandler : IRequestHandler<Query, Model>
        {
            public async Task<Model> Handle(Query request, CancellationToken cancellationToken)
            {
                return new Model
                {
                    Tweets = new List<string>
                    {
                        "One from the server",
                        "Two from the server",
                        "Three from the server",
                        "Four"
                    }
                };
            }
        }
    }
}
