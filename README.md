# _Animal Shelter API_

#### By _Ted Gold_

#### _An API that shows the ogs and cats in an animal shelter._

## Technologies Used

* _C#_
* _.Net_
* _Enitity_
* _MySQL_
* _Identity_
* _JWT_

## Description

_An API where you can access the dogs and cats in an animal shelter. The animals have species, id, name, and age. When you make a request to the Animal Shelter API, you will specify an HTTP method and a path. Additionally, you might also specify request headers and path, query, or body parameters. The API will return the response status code, response headers, and potentially a response body.

## Documentation

* _Authentication Token: Before making your first request, you must get a token for authentication. In Postman or another API caller, type in: localhost:5004/api/Users/authenticate as Post request with the following code in the body: {"Name": "[YOUR USERNAME HERE]", "Password": "[YOUR PASSWORD]"} This will return a token to use to make your requests._
* _Making your requests: To make a request, first find the HTTP method and the path for the operation that you want to use. 

The GET request: localhost:5004/api/animals if you would like to specify you can search by species, name, or minumumAge as well by adding ?[query]=[search param] to the GET request. You can also get animals by id the request is localhost:5004/api/animals/[id]

The other requests you can make are POST, PUT, and DELETE_

## Setup/Installation Requirements

* _Clone the repository using $git clone._
* _Open the project using $code ._
* _Build the project using $dotnet build._
* _Create a file called appsettings.json in the directory of your project's production folder, AnimalShelter_
* _Add this line of code to appsettings.json file:_
  {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=schedule;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
  }
* _Put your password for My SQL Workbench in the section that reads [YOUR-PASWORD-HERE]_
* _Update the database with $dotnet ef database update_
* _Run the program with $dotnet run._
* _Get an authentication token, explained above in documentation._
* _Run requests to the API in Postman or another API caller._


## Known Bugs

* _No known bugs_

## License

_MIT License_

_Copyright (c) [2022] [Ted Gold]_

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) _2022_ _Ted Gold_