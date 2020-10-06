using Amazon.CDK;

namespace CdkLabs
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new CdkLabsStack(app, "CdkLabsStack");

            app.Synth();
        }
    }
}
