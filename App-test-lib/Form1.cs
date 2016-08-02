using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit.Internal;
using Octokit;

namespace App_test_lib
{
    public partial class Form1 : Form
    {
        Credentials basicAuth;
        GitHubClient client;
        public Form1()
        {
            InitializeComponent();
            basicAuth = new Credentials("sittipol123", "love@4484744");
            client = new GitHubClient(new ProductHeaderValue("Research-Github-API"));
            client.Credentials = basicAuth;
        }

        private async void  button1_Click(object sender, EventArgs e)
        {
           
            
            var issues = await client.Issue.GetAllForCurrent();

        }

        private async void button2_Click(object sender, EventArgs e)
        {
          
            var issuesForOctokit = await client.Issue.GetAllForRepository("octokit", "octokit.net");
        }
        //Get comment from pull request
        private async void button3_Click(object sender, EventArgs e)
        {

            //var pullRequestComment = await client.PullRequest.Comment.GetAll()
            IReadOnlyList<Repository> repositories = await client.Repository.GetAllForUser("sittipol123");
            IReadOnlyList<PullRequest> pulls = await client.PullRequest.GetAllForRepository(repositories.First(x => x.Name == "Research-Github-API").Id);
        }
        //Get All Respo
        private async void button4_Click(object sender, EventArgs e)
        {
            IReadOnlyList<Repository> repositories = await client.Repository.GetAllForUser("sittipol123");

        }


    }
}
