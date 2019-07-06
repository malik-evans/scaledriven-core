**Solution Descriptions by Project**
----

 - **Core** - Accumulative class library that supports neighboring projects.
 - **API** -  Root Rest Api serving application data.
 - **Client** - Client interface
 - **Tests** - Full test project for sibling projects.

**Downloading documentation to the environment**
----

At the bottom the `.gitignore` file is a listing of necessary external documentation located in the `External.Docs` directory. It is recommended that from the project root you `cd ./External.Docs` directory before cloning external repositories (not modules) into this directory.

**First time doing so** - Create the directory External.Docs  

`mkdir External.Docs`  

**Change to that directory**

`cd ./External.Docs`

Then clone needed documentation

```
mkdir External.Docs
cd ./External.Docs
git clone https://github.com/aspnet/AspNetCore.Docs.git AspNetCore.Docs
git clone https://github.com/aspnet/EntityFrameworkCore.git EntityFrameworkCore
git clone https://github.com/ngxs/store.git ngxs
git clone https://github.com/domaindrivendev/Swashbuckle.AspNetCore.git Swashbuckle.AspNetCore
cd ..
```


And update or redo as needed. May take a while to download.

Keep in mind that the `External.Docs` directory can be removed from the text editor/IDE's index so as to not bother the developer.
 
**Recommended Tools**
___
- Jetbrains Rider

**Required System Software**
___
- .Net Core
- Docker
- Angular Cli
- SwaggerCodegen
- docfx
- git
