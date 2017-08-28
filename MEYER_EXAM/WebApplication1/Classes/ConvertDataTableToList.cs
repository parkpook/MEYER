using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication.Models;

namespace WebApplication.Classes
{
    public class ConvertDataTableToList
    {
        public SearchUserModel ConvertSeachUserInfoFromDataTableToList(DataTable dt, int rowNo)
        {
            SearchUserModel userGidHub = new SearchUserModel();
            //userGidHub.items.Id = Convert.ToInt32(dt.Rows[rowNo]["Id"]);
            //userGidHub.UserLogin = dt.Rows[rowNo]["Login"].ToString();
            //userGidHub.avatar_url = dt.Rows[rowNo]["avatar_url"].ToString();
            //userGidHub.url = dt.Rows[rowNo]["url"].ToString();
            //userGidHub.html_url = dt.Rows[rowNo]["html_url"].ToString();
            //userGidHub.following_url = dt.Rows[rowNo]["following_url"].ToString();
            //userGidHub.subscriptions_url = dt.Rows[rowNo]["subscriptions_url"].ToString();
            //userGidHub.organizations_url = dt.Rows[rowNo]["organizations_url"].ToString();
            //userGidHub.repos_url = dt.Rows[rowNo]["repos_url"].ToString();
            //userGidHub.events_url = dt.Rows[rowNo]["events_url"].ToString();
            //userGidHub.received_events_url = dt.Rows[rowNo]["received_events_url"].ToString();
            //userGidHub.type = dt.Rows[rowNo]["type"].ToString();
            //userGidHub.site_admin = dt.Rows[rowNo]["site_admin"].ToString();

            return userGidHub;
        }

        public SelectedUserModel ConvertSelectedUserInfoFromDataTableToList(DataTable dt, int rowNo)
        {
            SelectedUserModel userGidHub = new SelectedUserModel();
            //userGidHub.Id = Convert.ToInt32(dt.Rows[rowNo]["Id"]);
            //userGidHub.UserLogin = dt.Rows[rowNo]["Login"].ToString();
            //userGidHub.avatar_url = dt.Rows[rowNo]["avatar_url"].ToString();
            //userGidHub.url = dt.Rows[rowNo]["url"].ToString();
            //userGidHub.html_url = dt.Rows[rowNo]["html_url"].ToString();
            //userGidHub.following_url = dt.Rows[rowNo]["following_url"].ToString();
            //userGidHub.subscriptions_url = dt.Rows[rowNo]["subscriptions_url"].ToString();
            //userGidHub.organizations_url = dt.Rows[rowNo]["organizations_url"].ToString();
            //userGidHub.repos_url = dt.Rows[rowNo]["repos_url"].ToString();
            //userGidHub.events_url = dt.Rows[rowNo]["events_url"].ToString();
            //userGidHub.received_events_url = dt.Rows[rowNo]["received_events_url"].ToString();
            //userGidHub.type = dt.Rows[rowNo]["type"].ToString();
            //userGidHub.location = dt.Rows[rowNo]["location"].ToString();
            //userGidHub.public_repos = dt.Rows[rowNo]["public_repos"].ToString();
            //userGidHub.public_gists = dt.Rows[rowNo]["public_gists"].ToString();
            //userGidHub.followers = dt.Rows[rowNo]["followers"].ToString();
            //userGidHub.following = dt.Rows[rowNo]["following"].ToString();

            return userGidHub;
        }

        public UserRepositoryModel ConvertSelectedUserReposFromDataTableToList(DataTable dt, int rowNo)
        {
            UserRepositoryModel userGidHub = new UserRepositoryModel();
            //userGidHub.Id = Convert.ToInt32(dt.Rows[rowNo]["Id"]);
            //userGidHub.name = dt.Rows[rowNo]["name"].ToString();
            //userGidHub.full_name = dt.Rows[rowNo]["full_name"].ToString();
            //userGidHub.privates = dt.Rows[rowNo]["private"].ToString();
            //userGidHub.html_url = dt.Rows[rowNo]["html_url"].ToString();
            //userGidHub.description = dt.Rows[rowNo]["description"].ToString();
            //userGidHub.fork = dt.Rows[rowNo]["fork"].ToString();
            //userGidHub.url = dt.Rows[rowNo]["url"].ToString();
            //userGidHub.created_at = dt.Rows[rowNo]["created_at"].ToString();
            //userGidHub.updated_at = dt.Rows[rowNo]["updated_at"].ToString();
            //userGidHub.pushed_at = dt.Rows[rowNo]["pushed_at"].ToString();
            //userGidHub.homepage = dt.Rows[rowNo]["homepage"].ToString();
            //userGidHub.size = dt.Rows[rowNo]["size"].ToString();
            //userGidHub.stargazers_count = dt.Rows[rowNo]["stargazers_count"].ToString();
            //userGidHub.watchers_count = dt.Rows[rowNo]["watchers_count"].ToString();
            //userGidHub.language = dt.Rows[rowNo]["language"].ToString();
            //userGidHub.has_issues = dt.Rows[rowNo]["has_issues"].ToString();
            //userGidHub.has_projects = dt.Rows[rowNo]["has_projects"].ToString();
            //userGidHub.has_downloads = dt.Rows[rowNo]["has_downloads"].ToString();
            //userGidHub.has_wiki = dt.Rows[rowNo]["has_wiki"].ToString();
            //userGidHub.has_pages = dt.Rows[rowNo]["has_pages"].ToString();
            //userGidHub.forks_count = dt.Rows[rowNo]["forks_count"].ToString();
            //userGidHub.mirror_url = dt.Rows[rowNo]["mirror_url"].ToString();
            //userGidHub.open_issues_count = dt.Rows[rowNo]["open_issues_count"].ToString();
            //userGidHub.forks = dt.Rows[rowNo]["forks"].ToString();
            //userGidHub.open_issues = dt.Rows[rowNo]["open_issues"].ToString();
            //userGidHub.watchers = dt.Rows[rowNo]["watchers"].ToString();
            //userGidHub.default_branch = dt.Rows[rowNo]["default_branch"].ToString();
            return userGidHub;
        }
    }
}