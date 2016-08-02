using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using Octokit;
using Octokit.Internal;
using Octokit.Reactive;

namespace Test_lib
{
    class Program
    {
        static void Main(string[] args)
        {

            var basicAuth = new Credentials("sittipol123", "love@4484744");
            var client = new GitHubClient(new ProductHeaderValue("Research-Github-API"));
            client.Credentials = basicAuth;
            var issues =   client.Issue.GetAllForCurrent();
            int x=0;
        }
    }
}
