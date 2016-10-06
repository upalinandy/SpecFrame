using Newtonsoft.Json;
using NUnit.Framework;
using SpecFrame.GoogleAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFrame.StepDefinitionFiles
{
    [Binding]
    public sealed class Api_Steps
    {
        private string googleapiurl;
        private string response;

        [Given(@"Google api that takes address and returns latitude and longitude")]
        public void GivenGoogleApiThatTakesAddressAndReturnsLatitudeAndLongitude()
        {
            googleapiurl = "http://maps.googleapis.com/maps/api/geocode/json?address=";
        }

        [When(@"The client Gets response by ""(.*)""")]
        public void WhenTheClientGetsResponseBy(string addr)
        {
            HttpClient cl = new HttpClient();

            StringBuilder sb = new StringBuilder();
            sb.Append(googleapiurl);
            sb.Append(addr);
            Uri uri = new Uri(sb.ToString());
            response = cl.GetStringAsync(uri).Result;
            //    root = JsonConvert.DeserializeObject<RootObject>(response);
            var test = response;
        }

        [Then(@"The ""(.*)"" and ""(.*)"" returned should be as expected")]
        public void ThenTheAndReturnedShouldBeAsExpected(string exp_lat, string exp_lng)
        {
            var root = JsonConvert.DeserializeObject<RootObject>(response);
            var location = root.results[0].geometry.location;
            var latitude = location.lat;
            var longitude = location.lng;
            Assert.AreEqual(location.lat.ToString(), exp_lat);
            Assert.AreEqual(location.lng.ToString(), exp_lng);
        }

    }
}
