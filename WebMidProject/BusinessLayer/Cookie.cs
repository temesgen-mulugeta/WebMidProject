using System;
using System.Web;

namespace WebMidProject.BusinessLayer
{
    public class Cookie
    {
        HttpCookie userInfo;
        HttpResponse response;

        public Cookie(HttpResponse response)
        {
            this.response = response;
        }

        public Cookie(String email, String role, HttpResponse response) : this(response)
        {
            userInfo = new HttpCookie("userInfo");
            userInfo["email"] = $"{email}";
            userInfo["role"] = $"{role}";
            userInfo.Expires = DateTime.Now.AddDays(30);
        }



        public void AddCookie() => response.Cookies.Add(userInfo);
        public void RemoveCookie() => response.Cookies["userInfo"].Expires = DateTime.Now.AddDays(-1);



        public static CookieUserInfo GetCookieData(HttpRequest request)
        {
            var email = request.Cookies["userInfo"].Value.Substring(request.Cookies["userInfo"].Value.IndexOf('=') + 1, request.Cookies["userInfo"].Value.IndexOf('&') - 1);
            var role = request.Cookies["userInfo"].Value.Substring(request.Cookies["userInfo"].Value.IndexOf("e=") + 2);

            return new CookieUserInfo(email, role);

        }

        public static bool isUserLoggedIn(HttpRequest request) =>
            request.Cookies["userInfo"] != null &&
            request.Cookies["userInfo"].Value != String.Empty;

    }
}