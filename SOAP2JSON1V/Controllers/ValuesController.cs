using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml;

namespace SOAP2JSON1V.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("Add")]
        public string Add([FromUri]int a, [FromUri]int b)
        {
           //Json request
            String strRequest = @"<?xml version=""1.0"" encoding=""utf-8""?><soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/""><soap:Body><%SSS% xmlns=""http://tempuri.org/""><intA>%A%</intA><intB>%B%</intB></%SSS%></soap:Body></soap:Envelope>";
            strRequest = strRequest.Replace("%SSS%", "Add");
            strRequest = strRequest.Replace("%A%", a+"");
            strRequest = strRequest.Replace("%B%", b+"");
            
            HttpWebRequest webRequest = CreateWebRequest("http://www.dneonline.com/calculator.asmx");
            InsertSoapEnvelopeIntoWebRequest(CreateSoapEnvelope(strRequest), webRequest);

            //Request soap
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);
            asyncResult.AsyncWaitHandle.WaitOne();

            string soapResult;

            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                }
            }

            //Response from soap
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(soapResult);

            return JsonConvert.SerializeXmlNode(xmlDoc);
        }


        [HttpGet]
        [Route("Divide")]
        public string Divide([FromUri]int a, [FromUri]int b)
        {
            String strRequest = @"<?xml version=""1.0"" encoding=""utf-8""?><soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/""><soap:Body><%SSS% xmlns=""http://tempuri.org/""><intA>%A%</intA><intB>%B%</intB></%SSS%></soap:Body></soap:Envelope>";
            strRequest = strRequest.Replace("%SSS%", "Divide");
            strRequest = strRequest.Replace("%A%", a + "");
            strRequest = strRequest.Replace("%B%", b + "");

            HttpWebRequest webRequest = CreateWebRequest("http://www.dneonline.com/calculator.asmx");
            InsertSoapEnvelopeIntoWebRequest(CreateSoapEnvelope(strRequest), webRequest);

            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);
            asyncResult.AsyncWaitHandle.WaitOne();

            string soapResult;

            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                }
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(soapResult);

            return JsonConvert.SerializeXmlNode(xmlDoc);
        }

        private static HttpWebRequest CreateWebRequest(string url)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }

        private static XmlDocument CreateSoapEnvelope(String str)
        {
            XmlDocument soapEnvelopeDocument = new XmlDocument();
            soapEnvelopeDocument.LoadXml(str);
            return soapEnvelopeDocument;
        }
        [HttpGet]
        [Route("Multiply")]
        public string Multiply([FromUri]int a, [FromUri]int b)
        {
            //Json request
            String strRequest = @"<?xml version=""1.0"" encoding=""utf-8""?><soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/""><soap:Body><%SSS% xmlns=""http://tempuri.org/""><intA>%A%</intA><intB>%B%</intB></%SSS%></soap:Body></soap:Envelope>";
            strRequest = strRequest.Replace("%SSS%", "Multiply");
            strRequest = strRequest.Replace("%A%", a + "");
            strRequest = strRequest.Replace("%B%", b + "");

            HttpWebRequest webRequest = CreateWebRequest("http://www.dneonline.com/calculator.asmx");
            InsertSoapEnvelopeIntoWebRequest(CreateSoapEnvelope(strRequest), webRequest);

            //Request soap
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);
            asyncResult.AsyncWaitHandle.WaitOne();

            string soapResult;

            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                }
            }

            //Response from soap
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(soapResult);

            return JsonConvert.SerializeXmlNode(xmlDoc);
        }


        [HttpGet]
        [Route("Subtract")]
        public string Subtract([FromUri]int a, [FromUri]int b)
        {
            //Json request
            String strRequest = @"<?xml version=""1.0"" encoding=""utf-8""?><soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/""><soap:Body><%SSS% xmlns=""http://tempuri.org/""><intA>%A%</intA><intB>%B%</intB></%SSS%></soap:Body></soap:Envelope>";
            strRequest = strRequest.Replace("%SSS%", "Subtract");
            strRequest = strRequest.Replace("%A%", a + "");
            strRequest = strRequest.Replace("%B%", b + "");

            HttpWebRequest webRequest = CreateWebRequest("http://www.dneonline.com/calculator.asmx");
            InsertSoapEnvelopeIntoWebRequest(CreateSoapEnvelope(strRequest), webRequest);

            //Request soap
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);
            asyncResult.AsyncWaitHandle.WaitOne();

            string soapResult;

            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                }
            }

            //Response from soap
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(soapResult);

            return JsonConvert.SerializeXmlNode(xmlDoc);
        }



    }
}
