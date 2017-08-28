using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication.Classes;
using WebApplication.Models;

namespace WebApplication
{
    public partial class _Default : Page
    {
        //ConvertJsonStringToDataTable jDt = new ConvertJsonStringToDataTable();
        //ConvertDataTableToList helper = new ConvertDataTableToList();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                hdfGUID.Value = Guid.NewGuid().ToString();
            }
        }

        protected void GetAllUserByCriteria(string search)
        {
            string URL = Constants.Constants.GET_ALL_USER_URL;
            string QueryString = "users?q=" + search + "%20in:login";
            URL = URL.Replace("[query]", QueryString);

            HttpWebRequest request = WebRequest.Create(URL) as HttpWebRequest;
            request.UserAgent = "GitHubAgent";
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string JsonString = reader.ReadToEnd();

                SearchUserModel userResult = JsonConvert.DeserializeObject<SearchUserModel>(JsonString);
                //dt = jDt.JsonStringToDataTable(JsonString);

                if (userResult != null && userResult.items.Count > 0)
                {
                    lvResult.DataSource = userResult.items;
                    lvResult.DataBind();
                    dpListView.Visible = true;
                    HttpContext.Current.Session["UserList_" + hdfGUID.Value] = userResult.items;
                }
                else
                {
                    txtSearch.Text = string.Empty;
                    lvResult.DataSource = null;
                    lvResult.DataBind();
                    dpListView.Visible = false;
                    HttpContext.Current.Session["UserList_" + hdfGUID.Value] = null;
                }

            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                GetAllUserByCriteria(txtSearch.Text.Trim());
            }
        }

        protected void OnPagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            dpListView.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            lvResult.DataSource = HttpContext.Current.Session["UserList_" + hdfGUID.Value];
            lvResult.DataBind();
        }
    }
}
