using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;

using CSharpComponent;
using CSharpComponent.Models;
using System;

namespace LambdaLibrary
{
    public class Wrappers
    {

        [LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
        public Person pocoFuncHandler(Person p)
        {
            return new SomeFunctionality().GetPersonDetails(p);
        }

        public APIGatewayProxyResponse apiGatewayPocoFuncHandler(APIGatewayProxyRequest proxyReq)
        {
            Console.WriteLine("request received: " + proxyReq.Body);

            APIGatewayProxyResponse resp = new APIGatewayProxyResponse();
            Person p = Utf8Json.JsonSerializer.Deserialize<Person>(proxyReq.Body);
            Console.WriteLine("poco object deserilized");
 
            Person retVal = new SomeFunctionality().GetPersonDetails(p);
            string strRetVal = Utf8Json.JsonSerializer.ToJsonString<Person>(retVal);
           
            Console.WriteLine("poco object serilized for return: " + strRetVal);
            return new APIGatewayProxyResponse
            {
                Body = strRetVal,
                StatusCode = 200
            };
        }
    }
}
