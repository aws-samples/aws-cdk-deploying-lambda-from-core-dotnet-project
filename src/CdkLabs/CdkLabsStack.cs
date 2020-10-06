using Amazon.CDK;
using Amazon.CDK.AWS.Lambda;
using Amazon.CDK.AWS.APIGateway;

namespace CdkLabs
{
    public class CdkLabsStack : Stack
    {
        public CdkLabsStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {

            //Lambda section
            var pocoLambdaFunction = new Function(this, "PocoLambda", new FunctionProps
            {
                Runtime = Runtime.DOTNET_CORE_3_1,
                Code = Code.FromAsset("src/lambda-bin"),
                Handler = "LambdaLibrary::LambdaLibrary.Wrappers::pocoFuncHandler",
                MemorySize = 256
            });

            var pocoApiGatewayEndpoint = new Function(this, "PocoApiGateway", new FunctionProps
            {
                Runtime = Runtime.DOTNET_CORE_3_1,
                Code = Code.FromAsset("src/lambda-bin"),
                Handler = "LambdaLibrary::LambdaLibrary.Wrappers::apiGatewayPocoFuncHandler",
                MemorySize = 256
            });

            //API Gateway section
            new LambdaRestApi(this, "PocoApiGatewayEndpoint", new LambdaRestApiProps
            {
                Handler = pocoApiGatewayEndpoint
            });
        }
    }
}
