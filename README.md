# Use CDK to convert a C# class to a Lambda function!

## Summary

The code sample here demonstrates a CDK app with an instance of a stack (`CdkLabsStack`) that is used to convert .Net class libraries to Lambda functions.
The technique used here for one class can be applied to the remaining classes in your project. We are going to take one class of a .Net class library project as an example. In this repository, that will be the CSharpComponent.csproj project. We will then build a facade around it in another project, which is called LambdaLibrary.csproj here. The Facade project is then linked using code in the CdkLabsStack class of the CdkLabs.csproj project.

## Prerequisites

You will need to install/configure the following tools. The versions mentioned alongside below are what you need to use or higher.
1.	[.Net Core- v3.1](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31)
2.	[AWS CLI- v2](https://docs.aws.amazon.com/cli/latest/userguide/install-cliv2-windows.html)
3.	[VS Code](https://code.visualstudio.com/download) or [Visual Studio 2019] (https://visualstudio.microsoft.com/downloads)
4.	[AWS Toolkit for VS Code](https://docs.aws.amazon.com/toolkit-for-vscode/latest/userguide/welcome.html)
5.	[AWS Toolkit for Visual Studio](https://docs.aws.amazon.com/toolkit-for-visual-studio/latest/user-guide/setup.html)
6.	[Node (v12.18.4)](https://nodejs.org/en/download/)  – to run npm
7.	[AWS CDK Toolkit](https://docs.aws.amazon.com/cdk/latest/guide/cli.html)
8.  Create an [AWS Account](https://portal.aws.amazon.com/billing/signup#/start) and [IAM User](https://docs.aws.amazon.com/IAM/latest/UserGuide/id_users_create.html)
9.  [Configure AWS CLI](https://docs.aws.amazon.com/cli/latest/userguide/cli-chap-configure.html)


## Steps to run this sample as a Lambda function in your AWS account

1.  Install the CDK framework
    ```
    npm install -g aws-cdk
    ```
2.  Check version framework to be 1.6.2 or higher 
    ```
    cdk --version
    ```
3.  Clone this project in your working directory
4.  Navigate to the `src/` folder
5.  Create a sub folder within the `src/` folder called `lambda-bin`
6.  Now we will install the required packages. In your console prompt, you will first need to navigate to the `src/LambdaLibrary` folder and run the following commands to install all the required packages.
    ```
    dotnet add package Amazon.Lambda.Core
    Install-Package Amazon.Lambda.Serialization.SystemTextJson -Version 2.0.1
    Install-Package Amazon.Lambda.Serialization.Json -Version 1.7.0 
    Install-Package Utf8Json -Version 1.3.7
    dotnet add package Amazon.CDK.AWS.APIGateway
    ```

    Now navigate to the CdkLabs project folder and run the following to add the required package
    ```
    dotnet add package Amazon.CDK.AWS.APIGateway
    ```
7.  Double click the CdkLabs.sln file to open the project in Visual Studio

8.  Build the CSharpComponent.csproj project by right clicking on it and selecting {Build}

9.  Build the LambdaLibrary.csproj project. Navigate to the LambdaLibrary project directory in command prompt and run the following command. 
    ```
    dotnet publish /p:GenerateRuntimeConfigurationFiles=true -o ../lambda-bin
    ```
    This will create a package that is your Lambda function complete with configuration files, dependency information, etc.

10. The next three commands will need to be run from the project's root folder. This is the folder which has the _cdk.json_ file. These will prep and deploy your stack.

    `cdk synth`: Synthesizes your CDK application into a useable cloud formation template. 

    `cdk bootstrap` : If this is the first time you are deploying, you will need to boot strap your account and region to run and deploy CDK applications.

    **_Finally_**
    ```
    cdk deploy
    ```






## Security

See [CONTRIBUTING](CONTRIBUTING.md#security-issue-notifications) for more information.

## License

This library is licensed under the MIT-0 License. See the LICENSE file.

