using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication.Classes;
using WebApplication.Models;

namespace WebApplication
{
    public partial class UserLogin : System.Web.UI.Page
    {
        //ConvertJsonStringToDataTable jDt = new ConvertJsonStringToDataTable();
        //ConvertDataTableToList helper = new ConvertDataTableToList();

        protected void Page_Load(object sender, EventArgs e)
        {
            string Login = Request.QueryString["Login"].ToString();
            hdfUserLogin.Value = Login;
            string URL = Constants.Constants.GET_USER_URL;
            URL = URL.Replace("[login]", Login);
            HttpWebRequest request = WebRequest.Create(URL) as HttpWebRequest;
            request.UserAgent = "GitHubAgent";
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string JsonString = reader.ReadToEnd();

                SelectedUserModel userInfoResult = JsonConvert.DeserializeObject<SelectedUserModel>(JsonString);

                if (userInfoResult != null)
                {
                    imgUserProfile.Src = userInfoResult.avatar_url;
                    lblUsername.Text = userInfoResult.login;
                    lblType.Text = userInfoResult.type;
                    lblLocation.Text = userInfoResult.location;
                    lblPublicRepos.Text = userInfoResult.public_repos;
                    lblPublicGists.Text = userInfoResult.public_gists;
                    lblFollowers.Text = userInfoResult.followers;
                    lblFollowing.Text = userInfoResult.following;
                    hdfUserHtmlUrl.Value = userInfoResult.html_url;
                    lnkUserGitHub.Attributes["href"] = userInfoResult.html_url;
                }

            }
        }

        protected void btnViewRepos_Click(object sender, EventArgs e)
        {
            string URL = Constants.Constants.GET_USER_REPOS_URL;
            URL = URL.Replace("[login]", hdfUserLogin.Value);
            HttpWebRequest request = WebRequest.Create(URL) as HttpWebRequest;
            request.UserAgent = "GitHubAgent";
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                String JsonString = reader.ReadToEnd();
                JsonString = JsonString.Replace("private", "privates");
                string prefix = @"{""items""" + ":";
                JsonString = prefix + JsonString + "}";
                UserRepositoryModel userRepoResult = JsonConvert.DeserializeObject<UserRepositoryModel>(JsonString);
                if (userRepoResult != null)
                {
                    gvUserRepository.DataSource = userRepoResult.items;
                    gvUserRepository.DataBind();
                    HttpContext.Current.Session["UserReposList_" + hdfUserLogin.Value] = userRepoResult.items;
                }
            }
        }


        protected void gvUserRepository_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvUserRepository.PageIndex = e.NewPageIndex;
            gvUserRepository.DataSource = HttpContext.Current.Session["UserReposList_" + hdfUserLogin.Value];
            gvUserRepository.DataBind();
        }
    }
}