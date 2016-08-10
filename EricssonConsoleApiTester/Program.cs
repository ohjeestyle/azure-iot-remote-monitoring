﻿using System;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Web.Services.Protocols;
using EricssonConsoleApiTester.ApiStatus;
using EricssonConsoleApiTester.SubscriptionManagement;
using Microsoft.Web.Services3;
using Microsoft.Web.Services3.Security;
using Microsoft.Web.Services3.Security.Tokens;

namespace EricssonConsoleApiTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //echo tester

            var binding = new BasicHttpBinding {Security = {Mode = BasicHttpSecurityMode.Transport}};
            EndpointAddress endpointAddress = EricssonEndpointBuilder.GetAuthorizedEndpoint("https://serviceportal.telenorconnexion.com/dcpapi/ApiStatus");

            var apiStatusClient = new ApiStatusClient(binding, endpointAddress);

            try
            {
                var response1 = apiStatusClient.echo(new echo());
            }
            catch (Exception)
            {

                throw;
            }



            //sub tester - get a single sim information
            //var subscriptionManClient = new SubscriptionManagementClient();
            //subscriptionManClient.Endpoint.Address =
            //    EricssonEndpointBuilder.GetAuthorizedEndpoint(
            //        "https://serviceportal.telenorconnexion.com/dcpapi/SubscriptionManagement");

            //var response2 = subscriptionManClient.QuerySimResource(new QuerySimResource()
            //{
            //    resource = new resource()
            //    {
            //        id = "89460800000105696001",
            //        type = "icc"
            //    }

            //});


            //var response3 = subscriptionManClient.QuerySimResources(new QuerySimResources()
            //{
            //   resource = new resource()
            //   {
            //       type = "customer label",
            //       id = ""
            //   },
            //   startNumber = 0,
            //   range = "100",
            //   chunkSize = 100

            //});

        }

    }
}

