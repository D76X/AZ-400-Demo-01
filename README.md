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







