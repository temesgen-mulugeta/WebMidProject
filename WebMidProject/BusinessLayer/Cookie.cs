using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMidProject.BusinessLayer
{
    public class Cookie
    {
        HttpCookie userInfo;
        HttpResponse response;
        public Cookie (String email, HttpResponse response)
        {
            userInfo = new HttpCookie("userInfo");
            userInfo["email"] = $"{email}";
            userInfo.Expires = DateTime.Now.AddDays(30);

            this.response = response;
        }

        public void AddCookie() => response.Cookies.Add(userInfo);

        public static String GetCookieData(HttpRequest request) => request.Cookies["email"].Value;

        public static bool isUserLoggedIn(HttpRequest request) => 
            request.Cookies["userInfo"] != null && 
            request.Cookies["userInfo"].Value != String.Empty;

    }
}