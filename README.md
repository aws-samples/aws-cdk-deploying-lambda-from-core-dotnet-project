##SampleCDKLambdaDeployment

# Welcome to your CDK C# project!

This is a sample project that demonstrates a CDK app with an instance of a stack (`CdkLabsStack`)
which contains a Lambda function and an API Gateway endpoint. This project was built using the CDK CLI with CSharp as the language of choice.

This project also deploys a rudimentary C# dotnet class library as an example to show how CDK can be used to migrate a C# class library to AWS 
as a set of Lambda functions. 

The `cdk.json` file tells the CDK Toolkit how to execute your app.

It uses the [.NET Core CLI](https://docs.microsoft.com/dotnet/articles/core/) to compile and execute your project.

## Useful commands

* `dotnet build src` compile this app
* `cdk ls`           list all stacks in the app
* `cdk synth`       emits the synthesized CloudFormation template
* `cdk deploy`      deploy this stack to your default AWS account/region
* `cdk diff`        compare deployed stack with current state
* `cdk docs`        open CDK documentation


## Security

See [CONTRIBUTING](CONTRIBUTING.md#security-issue-notifications) for more information.

## License

This library is licensed under the MIT-0 License. See the LICENSE file.

