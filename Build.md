**Docker**
----------

**Images**

- Api 
    - Build  - ``docker build . -t malik393/scaledriven-api -f ./Scaledriven.Api/Dockerfile``
    - Container - ``docker create -p 5001:5001 --name scaledriven-api  malik393/scaledriven-api``
    
- Client
    - Build  - ``docker build . -t malik393/scaledriven-api -f ./Scaledriven.Core/Dockerfile``
    - Container - ``docker create -p 3000:3000 --name scaledriven-client  malik393/scaledriven-client``
