# _Shoe Store App_

#### _A basic shoe store web app, 3/10/2016_

#### By _**Jay Whang**_

## Description

_This is a shoe store app that lists stores and brands of shoes they carry._

## Setup/Installation Requirements

* _Using Windows install Mono and make sure your .NET frameworks are up to date_
* _Download or clone the project folder from github: https://github.com/jaywhang83/csharp-coreReview4-ShoeStore.git_
* _In Powershell enter_ ```sqlcmd -S "(localdb)\mssqllocaldb"```
* _Enter the following commands to create the database_
```
CREATE DATABASE shoe_stores;
GO
USE shoe_stores;
GO
CREATE TABLE stores (id INT IDENTITY(1,1), name VARCHAR(255));
CREATE TABLE brands (id INT IDENTITY(1,1), name VARCHAR(255));
CREATE TABLE brands_stores (id INT IDENTITY(1,1), store_id INT, brand_id INT);
GO
```


* _Navigate to the project folder in Powershell and run "dnu restore"_
* _Run "dnx kestrel" to launch the local server_
* _In your web browser navigate to "localhost:5004"_

## Support and contact details

_contact me at: jaywhang83@gmail.com_

## Technologies Used

_C#, Nancy web framework, Microsoft SQL database, Razor, bootstrap, and css._

### License

_The MIT License (MIT)_

_Copyright (c) 2016 Jay Whang_

_Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE._
