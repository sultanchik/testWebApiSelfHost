﻿using System;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace WebApiSelfhosting
{
    public class Service
    {
        private readonly HttpSelfHostServer server;

        public Service()
        {
            var selfHostConfiguraiton = new HttpSelfHostConfiguration("http://localhost:5555");

            selfHostConfiguraiton.MapHttpAttributeRoutes();
            
            selfHostConfiguraiton.Routes.MapHttpRoute(
                name: "DefaultApiRoute",
                routeTemplate: "api/{controller}",
                defaults: null
                );
            

            selfHostConfiguraiton.Routes.MapHttpRoute(
                name: "ApiRouteWithAction",
                routeTemplate: "api/{controller}/{action}",
                defaults: null
                );

            

            server = new HttpSelfHostServer(selfHostConfiguraiton);
        }

        public void Start()
        {
            server.OpenAsync();
        }

        public void Stop()
        {
            server.CloseAsync();
            server.Dispose();
        }

    }
}
