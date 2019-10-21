using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MyTweets.Data;

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
            private readonly Store _tweetStore;

            public QueryHandler(Store tweetStore)
            {
                _tweetStore = tweetStore;
            }
            
            public async Task<Model> Handle(Query request, CancellationToken cancellationToken)
            {
                return new Model
                {
                    Tweets = _tweetStore.Tweets.Select(x=>x.Contents).ToList()
                };
            }
        }
    }
}
