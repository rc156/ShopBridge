# Project git repository
Dear Evaluator, Greetings!
Hope you are doing well. I really appreciate your efforts for evaluating the coding task. I have completed the task to add an item to DB, Please have a look on the detailed inputs below:
#### ShopBridge
We can find the complete code on git under development branch, please refer the git url https://github.com/rc156/ShopBridge Feel free to reach on the contact details provided in signature if any issues while accessing git repository. Code is updated under different directories as below:

Backend - Contains the backend(asp.net web api) code.

DB - Database is created with table and procedures in SQL.

#### Steps to run application
Restore database using backup file provided in DB folder.
Load ShopBridge solution i.e. backend application in visual studio from the Backend\ShopBridge folder.
Change connection string in Web.config file
Run project, it will open up in new browser window say https://localhost:44357/ Lets refer this as a ApiURL, will be needing in step 3.
Run frontend application
Open visual code
Goto File => Open folder, please load frontend code from frontend\ShopBridge folder
Update the api url in frontend\ShopBridge\src\environments\environment.ts file, api url is nothing but the url we got in step 2. Only replace the URL keeping api keyword as it is.
Go to terminal, and enter below command
npm install
ng s -o => this will open new browser window with frontend application.

#### Functional flow
User can add the product using the frontend application, the browser window started in above step 3.
We can find a form under items menu where user can enter ItemName, ItemDescription, ItemPrice and select image to upload.
Form Validations are applied as per DB schema and functional cases.
Max chars and required validations on all text fields.
Min value and required validations on item price field.
When the form is valid, user can add item. Once item is added into DB, we can see list of recently added(last 5) items in the grid below.
Technical implementation
Developed application can be considered as loosely coupled stand-alone application. We can deploy such applications on same or different servers. Such environment can benefit in individual frontend or backend development/deployment and performance boost in async way. The application has two major factors, frontend which is developed using angular and backend developed using asp.net web API.

#### WebAPI startup project (ShopBridge)

This is the entry point project to which frontend application interacts directly.
All APIs can be created under ShopBridge\Controllers\api directory.
Includes single API at the moment i.e. ItemController with getAllItems() and AddItem() methods.
This project holds reference of DataContract, Helper, Managers, MasterInterface and UnityContainer libraries. Each library targets single responsibility. Lets discuss objective/benefits of each library one by one below.

#### Fields
ItemName, Description, Price, Quantity 

#### DataBase
Db Name- DB_ShopBridge

Schema Name - INV

Table Name - INV.tbItems

Procedures - INV.sp_Items_Save, INV.sp_Items_Delete, INV.sp_Items_Bind
 
#### Time Taken
R&D and Project Setup - 2 Hours

DataBase - 1 Hour

Web Api - 2 Hours

Classes - 1 Hour

Testing - 1 Hour

However, I consider some scope of improvement is there but due to current role and responsibilities could not spend much time on this for additional customization.


Looking forward to your thoughts!
