# Car-booking-portal-ASP.net-
This is a basic car booking portal, created in VB.net using basic html with backend created in SQL Server. 

Requirements : Microsoft Visual Studio (preferably 2012),SQL SERVER MANAGEMENT STUDIO 2012,basic html,VB.net.

FRONT END
1.Extract the zipped folder TRAVELS.
Now the unzipped folder contains 2 parts ; WebaApplication4, data.bak. 
WebApplication4 folder contains the project consisting of all webforms.
2.Open MAINPAGE.aspx with Microsoft Visual Studio (preferably 2012). 
3. Run the project on your browser.

BACK END
The back end has been coded using SQL SERVER MANAGEMENT STUDIO 2012.
1.The data.bak is a backup file of the database used in the project.
2.To use this database on your system it must be RESTORED on your system.

Procedure to restore database :-
1. Open SQL SERVER MANAGEMENT STUDIO 2012.
2. Connect to server  :-
    Servername: HP\SQLEXPRESS
    Authentication : Windows Authentication
3. Connect to database engine.
4. Expand Databases,expand System Databases and select data.
5.Right-click the database, point to Tasks, and then click Restore.
6.Click the type of restore Database. This opens the corresponding restore dialog box.
7.On the General page, in the Restore source section, click From device.
8.Click the browse button for the From device text box, which opens the Specify Backup dialog box.
9.In the Select Backup device box click the Add button to open the Locate Backup File box.
10. Choose data.bak from the unzipped folder.
11.In the Backup device text box, select the device you want to use for the restore operation.

This portal has 3 modules. 
1. Userpage
2. Driver login
3. Admin login

~~~~USERPAGE~~~~
The form enables user to fill details for :-
a)Type of Travel :Within City
 Sight seeing
Inter city

b)Vehicle category:Mini
Sedan
SUV

c)Purpose of Travel : Casual
Holidaying
Business/work

d)Location :Delhi
Mumbai
Chennai
Bangalore

e)Dates:From DD/MM/YY
To DD/MM/YY (cars already booked in those dates are not allowed to be selected again)

The data from the USERPAGE.aspx form is sent to the database data ; table users.

~~~~~DRIVER~~~~~~~~~
Taxi provider can create or log in  to the portal with a username (name of owner/name of Travel Company) and a password (valid mobile number).
Taxi provider can add a new entry or view old existing entry. 
the following details have to be added in the add entry form :-

Name of car owner/company
Full Address
Mobile Number
Vehicle make : TATA/HYUNDAI/MARUTI/TOYOTA
Vehicle category : Mini/Sedan/SUV
Registration No of vehicle :
All India Permit : Yes/No

To VIEW an entry, it has to be acknowledged by the admin.
The registration number of the vehicle must be entered to view the details.
database used for taxi driver login :data , table : taxilogin
database used for taxi details :data , table : taxi

~~~~~ADMIN~~~~~~~
The admin logs in with username =admin, password = admin
Admin page opens after successful login. The registration number of the vehicle must be entered and VIEW must be clicked to view details.
Once acknowledged, the details stored in database  :data , table : adminlogin.
If details are not acknowledged, message box appears.
only when taxi details are acknowledged by admin, these details can be viewed on taxi portal.

*********************************************************************************************************************************************************************************


LICENSE

Copyright © 2016 ADITI PAUL

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
