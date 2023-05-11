# AZ-400-Demo-01

This project is used as part 01 of the [AZ-400-DevOps-Sandbox](https://newthinkingtechnologies.visualstudio.com/AZ-400-Azure-DevOps-Sandbox)  .

The Sandbox exists in order to illustrate various possible scenarios in which Azure DevOps can be used to automate various aspect of the lifetime 
of a software project. 

In summary Azure DevOps essentially offers the following main services 

1. [Azure Boards](https://azure.microsoft.com/en-us/products/devops/boards)  
2. [Azure Repos](https://azure.microsoft.com/en-us/products/devops/repos)  
3. [Azure Pipelines](https://azure.microsoft.com/en-us/products/devops/pipelines)  
4. [Azure Test Plans](https://azure.microsoft.com/en-us/products/devops/test-plans/)  
5. [Azure Artifacts](https://azure.microsoft.com/en-us/products/devops/artifacts)  

In particular this AZ-400-Demo-01 repository on GitHup is used to explore the scenario in which the code repository does not
lie within Azure DevOps. For example, in all cases in which for a softawre project the source code cannot be held as an Azure DevOps Repo or may not be intended or desired to migrate it to an Azure DevOps Repos then obviously [Azure Repos](https://azure.microsoft.com/en-us/products/devops/repos) is not an option. Nevertheless, it is still possible to make use of some of the remaining services offered by Azure DevOps to implement some aspects of DevOps.

The AZ-400-Demo-01 is used to illustrate the following points.

1. Automation of the build process - CI [Continuos Integration]

By means of [Azure Pipelines](https://azure.microsoft.com/en-us/products/devops/pipelines) it is possible to connect the GitHub Repo [AZ-400-Demo-01](https://github.com/D76X/AZ-400-Demo-01) to the Azure Cloud infrasctructure behind Azure DevOps in order to build the source code and produce its artifacts. 

2. Automation of the deployment process - CD [Continuos Delivery]

Azure DevOps pipelines can also be used to deploy the artifacts produced by the build pipeline and stored somewhere to target environments. 
The target enviroments are those where these artifacts together with dedicated infrastructure make up the running applications and services ultimately accessed and consumed by users of.

In summary, within the [AZ-400-DevOps-Sandbox](https://newthinkingtechnologies.visualstudio.com/AZ-400-Azure-DevOps-Sandbox) the the GitHub Repo [AZ-400-Demo-01](https://github.com/D76X/AZ-400-Demo-01) is integrated only through the options 

3. [Azure Pipelines](https://azure.microsoft.com/en-us/products/devops/pipelines)  
5. [Azure Artifacts](https://azure.microsoft.com/en-us/products/devops/artifacts)  

Consequently, this implies that 

1. the management of the planning of the work i.e. issues, tasks, user stories, sprint planning, teams, etc.
2. the versioning of the source code
4. the automated testing of code and artifacts 

all lie **outside** Azure DevOps and must be implemented in some other way. For example, it is obvously known that GitHub is used to hold teh source code, while the management of teh work may either be done within GitHub with the tools available in it or some other tools of choice and eqially the 
automated testing of code and artifacts may be done on some other infrastructre i.e. on premise. 

---

# [GitFlow vs GotHub Flow](https://www.youtube.com/watch?v=gW6dFpTMk8s)  

- [Gitflow Workflow](https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow)
- [Trunk-based development flows](https://www.atlassian.com/continuous-delivery/continuous-integration/trunk-based-development)

In this project the application of Azure DevOps is explored in the context of a project developed according 
to the **GitFlow Workflow**. Despite the fact that the GitFlow Workflow is considered a **legacy workflow**,
according to modern standards, it still is popular and widespread in enterprise development and therefore,
in practice, very relevant in the software industy.

Therefore, it makes sense to learn how DevOps can be applied in conjunction to the **GitFlow Workflow** as
in many cases as a consultant, developer, software engineer or architect, etc. one might well encounter
the problem of migrating an **brown field** project managed with the **GitFlow Workflow** to **DevOps** practices.

This underatking might sometimes include also switching from managing the development with the **GitFlow Workflow**
to a more modern development flow such as any of the [Trunk-based development flows](https://www.atlassian.com/continuous-delivery/continuous-integration/trunk-based-development). However it might more often imply to at least as a first step to just adopt **DevOps** practices
while maintaining the **GitFlow Workflow** in order to minimize risk and disruption which are, of course, highly 
desirable proposition for any company that relies on the these project to generate revenue. 

The second step, that is the adoption of a **Trunk-based workflow** to replace the **GitFlow Workflow** may or
may not be implemented according to the business targets. For example, reasons for such undertaking could be
the following

- improvement of the rate of delivery of new features
- simplyfication of the flow by reducing the number of branches

However, while these benefits and gains are generally desirable they must also be balanced against the effort and the 
potential risks involved in switching to the **GitFlow Workflow** and there are cases when it might be not worth doing.
For example, there are cases when for commercial reasons and agreements an improved rate of delivery might not be 
necessary, required or even desirable thus in these cases it might not be justifiable to force the way to the 
**Trunk-based workflow** just for the promise of simplification of branch management as the in-hose team might be already
tested and tried through time and confortable with the current **GitFlow Workflow**.
 


---

## [Unit Tests, Intergation Tests and Test Coverage]

### References

#### Microsoft Learn - Run quality tests in your build pipeline by using Azure Pipelines
- [Exercise - Perform code coverage testing](https://learn.microsoft.com/en-us/training/modules/run-quality-tests-build-pipeline/6-perform-code-coverage)  

#### Udemy - AZ-400 Designing and Implementing DevOps Certification 2022

- [Run Unit Tests in an Azure Pipeline](https://www.udemy.com/course/azure100/learn/lecture/33318476#overview)  
- [Code Coverage](https://www.udemy.com/course/azure100/learn/lecture/33318488#overview)  

#### Microsoft Learn - Azure Pipelines
- [Define container jobs (YAML)](https://learn.microsoft.com/en-us/azure/devops/pipelines/process/container-phases?view=azure-devops&ns-enrollment-id=kjqkhm88o2mk1z&viewFallbackFrom=azure-devops%3Fns-enrollment-type%3DCollection)  
- [Service containers](https://learn.microsoft.com/en-us/azure/devops/pipelines/process/service-containers?view=azure-devops&tabs=yaml)  

#### [DevOps with GitHub and Azure: Implementing CI/CD with GitHub Actions](https://app.pluralsight.com/library/courses/devops-github-azure-implementing-cicd-github-actions/table-of-contents)  
- [Service Containers for Integration Tests](https://app.pluralsight.com/course-player?clipId=102ad897-c4ce-436a-8679-e5ba255aa081)  
- [Integration Testing with a SQL Database](https://app.pluralsight.com/course-player?clipId=31e0c3a1-6211-48d8-9552-5be87fb56e43)  

The following is the sequence of the **dotnet** commands to run in order to 

1- install a **dotnet-tools.json MANIFEST FILE** to  [C:\VSProjects\MyProjetcs\AZ-400-Demo-01\.config] 
2- install the tool [ReportGenerator](https://github.com/danielpalme/ReportGenerator)   
3- add the **coverlet.msbuild package** to the test project
4- run the Unit Tests in the test project locally with generation of the code coverage file **coverage.cobertura.xml** by means of the package **coverlet.msbuild package**
5- produce the HTML reports by means of the tool [ReportGenerator](https://github.com/danielpalme/ReportGenerator) from the file **coverage.cobertura.xml**  

```
cd C:\VSProjects\MyProjetcs\AZ-400-Demo-01
dotnet new tool-manifest
dotnet tool install dotnet-reportgenerator-globaltool
dotnet add BusinessLogic.Test package coverlet.msbuild
dotnet test --no-build --configuration Release /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=./TestResults/Coverage/
dotnet tool run reportgenerator -reports:./BusinessLogic.Test/TestResults/Coverage/coverage.cobertura.xml -targetdir:./CodeCoverage -reporttypes:HtmlInline_AzurePipelines
```

The ouput of the local sun should be similar to the following example.
Notice that a file named **coverage.cobertura.xml** is generated
by the **RaptorGenerator** tool in a subfolder named **TestResults** of
the first test project that is found by the tool.

```
 Passed!  - Failed:     0, Passed:     2, Skipped:     0, Total:     2, Duration: 3 ms - BusinessLogic.Test.dll (net6.0)

Calculating coverage result...
  Generating report '.\TestResults\Coverage\coverage.cobertura.xml'

+---------------+------+--------+--------+
| Module        | Line | Branch | Method |
+---------------+------+--------+--------+
| BusinessLogic | 7.4% | 0%     | 15.38% |
+---------------+------+--------+--------+

+---------+------+--------+--------+
|         | Line | Branch | Method |
+---------+------+--------+--------+
| Total   | 7.4% | 0%     | 15.38% |
+---------+------+--------+--------+
| Average | 7.4% | 0%     | 15.38% |
+---------+------+--------+--------+


Passed!  - Failed:     0, Passed:     1, Skipped:     0, Total:     1, Duration: < 1 ms - BusinessLogic.IntegrationTest.dll (net6.0)

```

---

### Run Unit Tests without Integration Tests

In first instance it is easier 

### Run Integration Tests

There are several options to run integration tests against a database in a pipeline and in general
the choice depends on the pipeline and the database used. In the following following the assumption 
will be that MS SQL Server is the database server of choice and the DevOp pipelines are either
Azure DevOps or GitHub Actions.

One option that is applicable to both Azure DevOps Pipelines and GitHub Actions is based on the usage
of [Service containers](https://learn.microsoft.com/en-us/azure/devops/pipelines/process/service-containers?view=azure-devops&tabs=yaml)  .
In particular the Service Container based on the Docker Image [Microsoft SQL Server - Ubuntu based images](https://hub.docker.com/_/microsoft-mssql-server)  .

With this setup the pipeline spins up a container within a Job and the test logic together with appropriate
configuration constructs a connection string to the MS SQL Server that runs inside the docker container
on the same pipeline.

The following are references to what is required to put in place this setup.

- [Service containers](https://learn.microsoft.com/en-us/azure/devops/pipelines/process/service-containers?view=azure-devops&tabs=yaml)  
- [Microsoft SQL Server - Ubuntu based images](https://hub.docker.com/_/microsoft-mssql-server)  
- [Integration Testing with SQL Database](https://app.pluralsight.com/course-player?clipId=31e0c3a1-6211-48d8-9552-5be87fb56e43)  
- [Service Container For Integration Testing](https://app.pluralsight.com/course-player?clipId=102ad897-c4ce-436a-8679-e5ba255aa081)   

The following are references to some troubleshooting resources related to this setup.

- [How do I get MSSQL service container working in Azure DevOps pipeline?](https://stackoverflow.com/questions/63538477/how-do-i-get-mssql-service-container-working-in-azure-devops-pipeline) 
- [Need examples using service container of sql server](https://developercommunity.visualstudio.com/t/working-examples-using-service-container-of-sql-se/1159426)  
- [Cannot connect to docker in Azure Pipelines](https://techcommunity.microsoft.com/t5/azure-devops/cannot-connect-to-docker-in-azure-pipelines/m-p/3511673)  

---

FEATURE-C

---

### Use a deployment job

[Deployment jobs](https://learn.microsoft.com/en-us/azure/devops/pipelines/process/deployment-jobs?view=azure-devops&source=docs)  
[Create and target an environment](https://learn.microsoft.com/en-us/azure/devops/pipelines/process/environments?view=azure-devops)  

that is build a pipeline all in YAML that performs the BUILD and the RELEASE..


---

### Use Deployment Environments

An environment is a collection of resources that you can target with deployments from a pipeline.
Typical examples of environment names are Dev, Test, QA, Staging, and Production.

[Azure DevOps Environments EXPLAINED](https://www.youtube.com/watch?v=gN4j65w7wIM)

 - Traceability of commits and Work Items [WIs]
 - Deployment History down to the single resource
 - Deeper Diagnostics
 - Approvals
 - Checks
 - When a pipeline targets an Environment you do not have to specify the service connections
   used by your pipeline in the pipeline itself because wih Service Connections pipelines 
   automatically conusmes the Service Connections defined in their Environments

#### Notes on Deployment Environments

Deployment Environments seems to be a feature of Azure DevOps applicable only to Deployment Jobs
that is Deployments declared as part of a YAML pipeline and therefore not applicable to the 
Classic Release Pipelines via the UI provided on the Azure DevOps Portal.

[Azure DevOps: How to make use Environments in Pipelines using classic editor?](https://stackoverflow.com/questions/64099402/azure-devops-how-to-make-use-environments-in-pipelines-using-classic-editor)  
[Deployment Groups vs Environments](https://developercommunity.visualstudio.com/t/deployment-groups-vs-environments/901600)  

---


Use Deployment Groups?
Deploy a VM?


1-add a SQL Server + Database for the WebApp-01

2-
build a pipeline that Azure SQL Table cration task or similar to create a table and insert data 
into the table

3-
Use Container Jobs for some of the build steps!


5-
Demonstrate the use of teh Azure App Service Settings Task in the Release Pipeline

This perhaps on a new Repo?

You want to build some services that can be deployed as containers on 
Azure Container Instances
Azure Kubernetes Services AKS

so that the WebApp-10 can use them..

Image-1
2-add a containerized .Net Core app with a Dockerfile in its folder use Linux LTS as base image
3-add build pipeline to build this Docker image and uploda to Azure Container Registry
4-build the Docker image on Azure on a Linux based VM Agent?

Image-2
5-build the Docker image on Azure on Agent that has Docker on it?


---

## Managing Databases with DevOps


### For Projects in which EF is used or similar ORM tools

[Entity Framework Best Practices - Should EFCore Be Your Data Access of Choice?](https://www.youtube.com/watch?v=qkJ9keBmQWo)  
[Is it possible to use Entity Framework and a Database project together?](https://stackoverflow.com/questions/58299246/is-it-possible-to-use-entity-framework-and-a-database-project-together)  
[Code-first Entity Framework 2 with Legacy Databases](https://app.pluralsight.com/library/courses/code-first-entity-framework-legacy-databases/table-of-contents)  
[Generate Entity Framework Core classes from a SQL Server database project - .dacpac file](https://erikej.github.io/efcore/sqlserver/2020/04/13/generate-efcore-classes-from-a-sql-server-database-project.html)  

### Projects in which Dapper or any thin ORM is used intead of a heavy-duty ORM such as EF

[SQL Data Tools In C# - Database Creation, Management, and Deployment in Visual Studio](https://www.youtube.com/watch?v=ijDcHGxyqE4)  
[Simple C# Data Access with Dapper and SQL - Minimal API Project Part 1](https://www.youtube.com/watch?v=dwMFg6uxQ0I)
[Simple C# Data Access with Dapper and SQL - Minimal API Project Part 2](https://www.youtube.com/watch?v=5tYSO5mAjXs)

### Example of how to use SQL DB Projects within Visual Studio and on Azure DevOps on Windows Agent and with Visual Studio build tasks

[CI/CD for SQL Databases (both SSDT and EF)- A TimCo Retail Manager Video](https://www.youtube.com/watch?v=TuHf0Ty80jA)  

### Some resources realted to the SQL Database Project and EF debate

[Is Entity Framework and Code First antithetical to SQL Server Database Project?](https://www.reddit.com/r/dotnet/comments/udaqu5/is_entity_framework_and_code_first_antithetical/)  
[Sql Server Data Tools & Entity Framework - is there any synergy here?](https://softwareengineering.stackexchange.com/questions/209815/sql-server-data-tools-entity-framework-is-there-any-synergy-here)  


### Other refernces
[EditorConfig file doesn't work in Visual Studio 2022? Here is a workaround.](https://www.youtube.com/watch?v=5f1rbw5lOsg)  

---

### Deploy Databases with ARM Templates in Azure DevOps Release Pipelines

Before we can even think of managing the lifecycle of a database we must have one. 

In some cases, for example in the familiar **Dev, Test, Staging** Environments, there may be already target databases
to which schema changes are applied by means of the some of the strategies described in the following parts of this 
document. However, in this cases the target datadase already exists and all that we rae concerned with is in fact
to perform schema and data changes.

However, there are cases when this may not be practical. For example, for developer working on a **Feature** it makes
more sense to start afresh from a new database as the possible schema changes that may be part of the feature itself 
may not be easily and safely applied to the **Dev or Test Environments** without affecting the work of others. 

Such schema changes may be unsafe for a while and therefore it would be much easier for **Feature Branches** to 
deploy a dedicated database and inject into it some test data when required.

One way to do this is to include a **ARM Template** in the **CD Pipeline for the Feature Branch** so that 
**each Feature will have its own database and test data**.


#### References

The following is a good example of how ARM Templates can be used in Azure DevOps Pipelines.

This is particularly so as it illustrates how ARM templates and corresponding paramaters can be 
maintanied in source control as JSON and can be parameterized so that the properties of the deployed
resources can be controlled by variables set in the **RELEASE PIPELINE** or the **CD Stage** of a 
**YAML pipeline**.

[Using ARM TEMPLATES In AZURE DEVOPS PIPELINE To Automatically CREATE INFRASTRUCTURE As CODE](https://www.youtube.com/watch?v=3IRwtbGlshk) 

The following is a Quickstart example that may be useful to get an idea of what the ARM template may look like.
[Quickstart: Create a single database in Azure SQL Database using an ARM template](https://learn.microsoft.com/en-us/azure/azure-sql/database/single-database-create-arm-template-quickstart?view=azuresql)

The following is the reference to all the Azure SQL ARM (and Bicep) Templates.
[Azure Resource Manager templates for Azure SQL Database & SQL Managed Instance](https://learn.microsoft.com/en-us/azure/azure-sql/database/arm-templates-content-guide?view=azuresql&tabs=single-database)  

From the link above some specific examples are more relevant than others in the context of this demo.
[Single Azure SQL Database with server-level IP firewall rules](https://github.com/Azure/azure-quickstart-templates/tree/master/quickstarts/microsoft.sql/sql-database-transparent-encryption-create)  
[Azure Web App with SQL Database](https://github.com/Azure/azure-quickstart-templates/tree/master/quickstarts/microsoft.web/web-app-sql-database)  

#### Use an ARM Template to deploy the databse for the WebApp in the CD pipeline

The following references are a good spring point for our ARM tamplate.

[Azure Web App with SQL Database](https://github.com/Azure/azure-quickstart-templates/tree/master/quickstarts/microsoft.web/web-app-sql-database)  
[Azure Resource Manager templates for App Service](https://learn.microsoft.com/en-gb/azure/app-service/samples-resource-manager-templates)  

For each Feature Branch we need to perform at least the following logical steps.

- Deploy a dedicated recource group (this has already done)
- Deploy a Azure SQL Server
- Deploy a Azure SQL Server Database to the Azure SQL Server with a service tier appropriate for work on a Feature branch
- Deploy the WebApp on condition that the deployment of the databse was successful
- Provide the WebApp with the connection string to the datase

In this specific case these this process is **represented declaratively** by meas of the **ArmTemplate**
project that is part of the `AZ-Demo-01.sln` solution. This is a `Visual Studio ARMN Template Project` and
does nothing else than providing some tooling to support the editing of the two files below. Incidentally,
the tooling provided by `Visual Studio Code` is also very handy and in some respects better or complementary
to that provided by Visual Studio. The two tools can be used together without problems shoul done wish to.

```
azuredeploy.json
azuredeploy.parameters.json
```

Within the **Feature** branch we edit these tow file in order to integhrate the steps above that we repeat for
the sake of clarity.

- Deploy a dedicated recource group (this has already done)
- Deploy a Azure SQL Server
- Deploy a Azure SQL Server Database to the Azure SQL Server with a service tier appropriate for work on a Feature branch
- Deploy the WebApp on condition that the deployment of the databse was successful
- Provide the WebApp with the connection string to the datase


---

#### How to handle the parameter replacement in the Release Pipeline

[AZ-400-Azure-DevOps-Sandbox](https://newthinkingtechnologies.visualstudio.com/AZ-400-Azure-DevOps-Sandbox)

In this project we use the **Azure DevOpps Classic Release Pipeline** to implement the release part of the pipeline for
the `AZ-400-Demo-01` build pipeline. This is one of the 2 options to implement the **CD** part of a pipeline, the other
is to integrate it in the **CD Stage** of the same YAML just after the **Build Stage**.

With this implementation in the **Pipelines Section** select **Releases**. The view displays all the so far performed 
**Releases with the correspoing Stage** and **Deployments with the correspondig Branch and Release**.
The definition of the release can be changed by means of a visual editor by clicking on the **Edit** button.
The editor displays a **Artifacts** section that lists all the **Artifacts** that may be used in the process of release.
These are static artifacts such as files or binary build artifacts that may originate by a **preceding build pipeline**.
The **preceding build pipeline** is always defined in **YAML** and mainained within the source control system. In the 
yaml of the build pipeline there are one or more tasks such as `task: PublishPipelineArtifact@1` that "publish" the 
assets for the release to be available later for any **release pipeline** that may wish tou use them in their 
**Artifacts** section.


```

- task: PublishPipelineArtifact@1
  displayName: 'publish artifacts arm templates'
  inputs:
    targetPath: '$(Pipeline.Workspace)/temparmtemplates/'
    artifact: 'armtemplates'
    publishLocation: 'pipeline'

- task: PublishPipelineArtifact@1
  displayName: 'publish artifacts webapp-01'
  inputs:    
    targetPath: '$(Build.ArtifactStagingDirectory)/WebApp-01.zip'
    #targetPath: '$(Pipeline.Workspace)/s/WebApp-01/bin/Release/net6.0/publish.zip'
    artifact: 'webapp01'
    publishLocation: 'pipeline'

```

Notice that in genearal this **decouples the release pipeline from any build pipeline** and therefore as far as the
**classical release pipeline editor** goes it makes it easier to **make available to the release pipeline artifacts
that may originate from multiple build pipelines**. This is not so easy to achieve when instaed the **CD** part of
a pipeline is integrated as a **CD Stage** right into the same yaml of the build pipeline following the **Build Stage**.

---

#### Edit the Feature Stage of the Release Pipeline

Now in the **Release Pipeline Edit** mode select the **Feature** stage to begin with as we are going to 
add a few **pipeline variables** to the release pipeline and alter or even add steps to it in order to 
account to the fact that that the ARM template has been modified and some parameters have been added to 
it in order to cater for the addition of the SQL Server and Database.

In the **Variables section** of the **Feature Stage** we see the existing variables.

```
arm_appBaseName
arm_appBaseSkuName

rel_rg_name
rel_rg_name_suffix
```

A **name convenction** has been used here where **rel_** stands for **release** and **arm_** for **ARM Template**
depending on the purpose of the variable and where it is used in the steps of the release pipeline. The variables
**arm_** are used in the **release tasks Replace Tokes in azuredeploy.paramter.json**. This tasks allow to use the
**stage value** of the **arm_variablename** to be used to replace the **arm_parametername** in the file
`azuredeploy.paramter.json` that is available as **Artifacts** to the release pipeline and that comes from the 
corresponding **Feature** branch.

The the **release tasks ARM Template deployment: Resource Group scope** then will perform the deployment via the 
**ARM (Azurre Resource Manager)** as declared by the two file below.

```
azuredeploy.json
azuredeploy.parameters.json
```

Notice the following

1-
each variable name may have a different value at each scope that is the value of `rel_rg_name` can be 
different according to the scopes **Feature, Development, QATest, QARelease, Preproduction** the **Release** scope
provides the **default values** assigned to each **release variable** these are in fact **overridden** at each
release scope as required. 

2-
some of the variables have **Settable at release time=true** checked in the far right side of the variables
editor. This is beause some of the Powershell Scripts in the steps of the release of the pipeline replace
their value programmatically. Without this the value of a **release variable** could not be changed at 
runtime when the release pipeline executes.

The list of variables must be extended at least a **Feature scope** to encompass also values to assign to the added ARM tamplate
parameters.


```
arm_sqlServerName
arm_sqlDbName
arm_sqlAdminLogin
arm_sqlAdminPassword

arm_appBaseName
arm_appBaseSkuName

rel_rg_name
rel_rg_name_suffix
```



az400demosqladmin
az_400_DemoSql_Admin_Psw


---

### Manging the Database Lifecycle with Projects on Azure DevOps

What we want to do here is to manage the database schema changes by means of .DATPAC files and Visual Studio SQL Projects.
We want to do this because Visual Studio SQL Projects are very convenient as they provide lots of tooling including refactoring 
cababilities, intellisense and also integrate with SSDS which makes it much easier and safer to perform and maintain schema chages
to DBs by producing deployable artifacts such as .DATPACS files.

However, this comes together with the problem that the same solution must then be build by an Azure Pipeline and perhaps also
on an agent that might not be a Windows based agent. In this cases while .csproj files can still be used with .Net Core as this is 
cross platform the same is not the case with .sqlproj that can only be built on Windows Agents.

However, there are ways to leave the .sqlproj projects in the solution and still produce the .DATPACS that are required to apply 
schema migrations to the target databases.

### The Problem with NuGetCommand@2 with solutions containing .sqlproj

#### Resources used to tackle this problem

The most helpful resources to solve these problem are the following.

[Build sqlproj on Azure DevOps](https://stackoverflow.com/questions/53473804/build-sqlproj-on-azure-devops) 
[Building a SQL Server project on a CI/CD pipeline](https://stackoverflow.com/questions/3980909/microsoft-webapplication-targets-was-not-found-on-the-build-server-whats-your/61292024#61292024)

These are the references to the MSBuild SDK GitHub project that makes this possible.

[MSBuild.Sdk.SqlProj](https://github.com/rr-wfm/MSBuild.Sdk.SqlProj)  
[Use MSBuild.Sdk.SqlProj to work with dacpacs cross-platform](https://dotnetflix.com/player/104)  
 
This another question to which the same answer is given as a way of confirming that it can be done.

[Build .sqlproj on Linux](https://learn.microsoft.com/en-us/answers/questions/729421/build-sqlproj-on-linux)  

This clarifies important differences between the pipeline tasks NuGetCommand@2 and DotNetCoreCLI@2

[DotNetCoreCLI restore vs NuGetCommand restore](https://stackoverflow.com/questions/66377643/dotnetcorecli-restore-vs-nugetcommand-restore)  

#### Summary of the implemented solution

-1 
A `BusinessDb.sqlproj` project was added to the solution to manage and maintain the schema of the DB.
This project can be used to manage the databse development on the local machine. For example the 
publish profilefile `BusinessDb.local.publish.xml` is used to do the deployments to the local instance
every time there is a schema change. This mechanism **employs DACPAC behind the scenes**.

-2 
A `BusienessDbLib.csproj` was added to the solution as explained by the reference [MSBuild.Sdk.SqlProj](https://github.com/rr-wfm/MSBuild.Sdk.SqlProj)  
This project can build DACPAC files from the scripts of the `BusinessDb.sqlproj` project by menas of the 
`MSBuild SDK`. Technically speaking this is a so called **SDK Project** as it makes use of a specific 
SDK. The reason why `BusienessDbLib.csproj` is added is that an Azure Pipeline based on a Linux Agent
would not be able to build the projec `BusinessDb.sqlproj` and produce the .DACPAC files required by 
a later step of the release pipeline to perform the database deployment. This is due to the fact that 
`.sqlproj` **only owrks on Windows and within Visual Studio**.

-3
We want to be able to run the **Azure DevOps pipeline on a Linux Agent** as most modern projects are 
based on `.Net` as opposed to `.Net Framework`. In these cases is possible to use the **cross platform** 
`dotnet` tool to perform the build of all the projects of a solution as `dotnet` si not only capable of
building `*.csproj` based projects but also undderstands a collection of projects by menas of a `.sln`
file **without the need for Visual Studio**. Therefore, in these cases neither a Windows OS nor an instance
of Visual Studio are required on the agent which can be then a Linuz Agent.

-4
One problem though is that in the `AZ-Demo-01.sln` we want to keep both projects 	
	- `BusinessDb.sqlproj` 
	- `BusienessDbLib.csproj` 

This has the **advantage** that on the local development machine it is possible to iterate on `BusinessDb.sqlproj`
in Visual Studio while `BusienessDbLib.csproj` is used on Azure DevOps Pipelines to build the DACPAC files.
However, with this setup in source control **there arises a problem on the Azure DevOps Pipeline** when the
pipeline task **[NuGetCommand@2](https://learn.microsoft.com/en-us/azure/devops/pipelines/tasks/reference/nuget-command-v2?view=azure-pipelines&source=docs)**  
is used to **restore the NuGet packages** before the solution is build. This task will attempt to perform a 
restore also on the `BusinessDb.sqlproj` project beacsue it is part of the `AZ-Demo-01.sln` but it fails
as this project is niot compatible with a Linux Agent and can only be build and restored by Visual Studio.

There are different ways ot tackle this porblems for example it could be thought to manage two solutions.
One references the `BusinessDb.sqlproj` while the other does not so that may be used on Azure DevOps pipelines
on Linux. 

However, there is a better way based on replacing the pipeline resotre step based on **[NuGetCommand@2]**
with one that does the same thing by means of the **Azure .Net Core CLI** which can be used on Linux.
The snipet from the pipeline below should make this clear. 

```
#- task: NuGetCommand@2
#  displayName: 'restore NuGet packages'
#  inputs:
#    command: 'restore'
#    configuration: '$(buildConfiguration)' #this does not work
#    restoreSolution: '**/*.sln'
#    --------------------------------------------------------------------------------------------------------------
#    This would also fail!   
#    #command: custom    
#    #arguments: 'restore --configuration $(buildConfiguration)' #Required when command = custom. Command and arguments.     
#    --------------------------------------------------------------------------------------------------------------
#    feedsToUse: 'select'
```
```
- task: DotNetCoreCLI@2
  displayName: 'Restore Projects'
  inputs:
    command: 'restore'
    projects: '**/*.csproj'    
    feedsToUse: 'select' 
```

There are two important thing to notice with this.  The first is that with **DotNetCoreCLI@2 + command: 'restore'**
it is is not possible to make a resotre on the `.sln` file as with **NuGetCommand@2**. However, this is not even what 
we would like to do as the `AZ-Demo-01.sln` references the `BusinessDb.sqlproj` which we want to **exclude** from
the restore step. By resoring with `projects: '**/*.csproj' ` this is easily and automatically achieved.


-5
On the Azure DevOps Pipeline the `BusienessDbLib.csproj` is capable to build and produce the **.dappac** files
as it is demontrated by the exerpted output below.

```
Writing model to /home/vsts/work/1/s/BusienessDbLib/obj/CustomRelease/netstandard2.0/BusienessDbLib.dacpac
BusienessDbLib -> /home/vsts/work/1/s/BusienessDbLib/bin/CustomRelease/netstandard2.0/BusienessDbLib.dacpac  
```

This is obtained by following the instructions in the references which are repeatede here for convenience.

[Build sqlproj on Azure DevOps](https://stackoverflow.com/questions/53473804/build-sqlproj-on-azure-devops) 
[Building a SQL Server project on a CI/CD pipeline](https://stackoverflow.com/questions/3980909/microsoft-webapplication-targets-was-not-found-on-the-build-server-whats-your/61292024#61292024)
[MSBuild.Sdk.SqlProj](https://github.com/rr-wfm/MSBuild.Sdk.SqlProj)  
[Use MSBuild.Sdk.SqlProj to work with dacpacs cross-platform](https://dotnetflix.com/player/104)  
 

```
<Project Sdk="MSBuild.Sdk.SqlProj/2.5.0">
  <PropertyGroup>
    <TargetFramework>netstandard2.0</TargetFramework>
    <SqlServerVersion>Sql140</SqlServerVersion>
    <Configurations>Debug;Release;CustomRelease</Configurations>
    <!-- For additional properties that can be set here, please refer to https://github.com/rr-wfm/MSBuild.Sdk.SqlProj#model-properties -->
  </PropertyGroup>
  <ItemGroup>
    <Content Include="..\BusinessDb\Tables\*.sql" />
    <Content Include="..\BusinessDb\StoredProcedures\*.sql" />
    <!-- link in the new .csproj to the .sql scripts in your existing database project -->
  </ItemGroup> 
  <PropertyGroup>
    <!-- Refer to https://github.com/rr-wfm/MSBuild.Sdk.SqlProj#publishing-support for supported publishing options -->
  </PropertyGroup>
</Project>
```

---

### Azure DevOps with Databases with DACPAC files

The following references lay the basis for this topic. 

[DevOps for Azure SQL](https://devblogs.microsoft.com/azure-sql/devops-for-azure-sql/?WT.mc_id=dataexposed-c9-niner) 
[Using Azure Pipelines for Azure SQL Deployments | Data Exposed](https://www.youtube.com/watch?v=G7H6HbzwAfs)  
[Getting Started with DevOps for Azure SQL | Data Exposed](https://www.youtube.com/watch?v=j7OnxOz7YDY)

In summary, there are basically two ways in which in modern project it may be possible to **manage the lifecycle** of 
databases that are used otgether woth applications.

#### IMPERATIVE APPROACHES aka [Migration-based approach](https://devblogs.microsoft.com/azure-sql/devops-for-azure-sql/?WT.mc_id=dataexposed-c9-niner#migration-based-approach)
The are some **code first** tools such as **EF Core Code First** that are used to produce scripts that may eventually be 
deployed to the target database even within the contest of an Azure DevOp Pipeline.

#### DECLARATIVE APPROACHES
The are some **desired database state tools** such as **Visual Studio SQL Projects** which can be used to manage the lifecycle 
of databases and produce deployable assets that may also be used within an Azure DevOp Pipeline.

The **Declarative Approaches** provide **several advantages** over the **Imperative Approaches** on many levels.
For example **Visual Studio SQL Projects** come with lost of assisting tooling that make it easy to perform changes to the 
database schema with safety as the project provides built-in intellisense and will not build if the schema is not consistent.
Moreover, **this approach does not force the use of a heavy-duty ORM such as Entity Framework** which is far better from the 
point of view of database general design, maintenace, safety and performance.

The following two references go in detail on why this approach is far better than relying on any ORM.

[Simple C# Data Access with Dapper and SQL - Minimal API Project Part 1](https://www.youtube.com/watch?v=dwMFg6uxQ0I)
[Simple C# Data Access with Dapper and SQL - Minimal API Project Part 2](https://www.youtube.com/watch?v=5tYSO5mAjXs)

There are also reasons why [Migration-based approach](https://devblogs.microsoft.com/azure-sql/devops-for-azure-sql/?WT.mc_id=dataexposed-c9-niner#migration-based-approach)  
may be preferred to the **declarative approach**. For example, in cases when an ORM is already in used and scheme changes
are driven via scripted migrations over which the develope and the DB admin desire to have some degree of control.
With a **declarative approach** often there is a tool such as **SSDS** that produces **artifacts such as DAVPAC**
and there may be less opportunity to control this kind of output when compared to SQL scripts that may also, perhaps, 
be edited by hand should the case be.

---

