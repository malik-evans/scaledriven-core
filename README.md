**Solution Descriptions by Project**
----

 - **Core** - Accumulative class library that supports neighboring projects.
 - **API** -  Root Rest Api serving applicaton data.
 - **Client** - Client interface
 - **Tests** - Full test project for sibling projects.

**Downloading documentation to the environment**
----

At the bottom the `.gitignore` file is a listing of necessary external documentation located in the `External.Docs` directory. It is recommended that from the project root you `cd ./External.Docs` directory before cloning external repositories (not modules) into this directory. 

```
cd ./External.Docs
git clone https://github.com/aspnet/AspNetCore.Docs.git AspNetCore.Docs
git clone https://github.com/aspnet/EntityFrameworkCore.git EntityFrameworkCore
git clone https://github.com/ngrx/platform.git ngrx
```
Keep in mind that the `External.Docs` directory can be removed from the text editor/IDE's index so as to not bother the developer.
