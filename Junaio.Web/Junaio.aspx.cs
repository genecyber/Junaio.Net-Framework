using System;
using Junaio.Core;
using Junaio.Core.Model.Request;
using junaioAuthentication;

namespace Junaio.Web
{
    public partial class Junaio : System.Web.UI.Page
    {
        const double AUTH_DATE_TOLERANCE = 15; //15 minutes
        const string JUNAIO_KEY = Auth.ApiKey; //Reference to API Key

        protected void Page_Load(object sender, EventArgs e)
        {
            JunaioAuthentication junAuthenticate = new JunaioAuthentication(AUTH_DATE_TOLERANCE, JUNAIO_KEY);

            if (!junAuthenticate.checkAuthentication())
            {
                var request = new ErrorRequest(Request.Params);
                Response.Write(request.GenerateResults());
            }
            else
            {

                string path = Request.PathInfo;
                string[] pathArray = path.Split('/');

                try
                {
                        var request = RequestFactory.GenerateRequest(pathArray[2], Request.Params);
                        Response.Write(request.GenerateResults());
                }
                catch (Exception exceptions)
                {
                    Response.StatusCode = 404;
                    Response.StatusDescription = "Not found";
                    Response.Flush();
                    Response.Close();
                }
            }
        }

       
    }
}