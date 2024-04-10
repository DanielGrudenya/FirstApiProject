using _1st;
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;

namespace MyEndPoint
{
    public class MyEndpoint : Endpoint<Request, Response>
    {
        public override void Configure()
        {
            Post("/api/user/date");
            AllowAnonymous();
        }

        public override async Task HandleAsync(Request req, CancellationToken ct)
        {
            await SendAsync(new()
            {
                DateTime = req.
            }) ;
        }
    }

}
