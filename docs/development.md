Source
-----

A standard feature implements [Functional Design]()
---
 - **Scaledriven.Core**
 - **Scaledriven.App** 
 - **Scaledriven.API**
 - **Scaledriven.Client**
 - **Scaledriven.Tests**

### Projects

- **Core**: Accumulative class library that supports neighboring projects.

- **App**: Client project

- **API**: Root Rest Api serving application data.

- **Client**: Client interface

- **Tests**: Full test project for sibling projects.


### Commits Template
```
{type}(project):<description>
```

Examples

_Default_
```
build()
```
```
build(Scaledriven.App) 
```
Commits effecting more than one scope. Sperated by comma.
```
build(Scaledriven.App, Scaledriven.Api) 
```


### Type

With the exception of a **feature** commit, a commit's prefix must be one of the following:

* **feature**: A new **feature!** see [functional design]()
* **build**: Changes that affect the build system or external dependencies (example scopes: gulp, broccoli, npm)
* **ci**: Changes to our CI configuration files and scripts
* **docs**: Documentation only changes
* **fix**: A bug fix
* **refactor**: A code change that neither fixes a bug nor adds a feature
* **style**: Changes that do not affect the meaning of the code (white-space, formatting, missing semi-colons, etc)
* **test**: Adding missing tests or correcting existing tests


**Docker**
----------

**Images**

- Api -``docker build . -t malik393/scaledriven-api -f ./Scaledriven.Api/Dockerfile``
    
- Client ``docker build . -t malik393/scaledriven-api -f ./Scaledriven.Core/Dockerfile``
