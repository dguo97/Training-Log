Option Explicit
' Loads the test data from your 3.2 Test data document into Database.accdb
' (12 runners, 10 training records, 12 ranking rows, admin password 1234).
' Run create_database.vbs first.
' Usage: double-click, or: cscript seed_test_data.vbs "C:\path\Database.accdb"

Dim fso, dbPath, con
Set fso = CreateObject("Scripting.FileSystemObject")
If WScript.Arguments.Count > 0 Then
  dbPath = WScript.Arguments(0)
Else
  dbPath = fso.BuildPath(fso.GetParentFolderName(WScript.ScriptFullName), "Database.accdb")
End If
If Not fso.FileExists(dbPath) Then
  WScript.Echo "Database not found: " & dbPath & vbCrLf & "Run create_database.vbs first."
  WScript.Quit 1
End If

Set con = CreateObject("ADODB.Connection")
On Error Resume Next
con.Open "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath & ";"
If Err.Number <> 0 Then
  WScript.Echo "Could not open the database: " & Err.Description
  WScript.Quit 1
End If

Dim n
n = 0
Sub Run(sql)
  On Error Resume Next
  con.Execute sql
  If Err.Number <> 0 Then
    WScript.Echo "Failed: " & Err.Description & vbCrLf & sql
    con.Close
    WScript.Quit 1
  End If
  n = n + 1
End Sub

Run "INSERT INTO persondetail (RunnerID, FirstName, SecondName, HouseNumber, Postcode, PhoneNumber, DOB, Weight, Runnerusername, Runnerpassword) VALUES (304, 'Tulsi', 'Patell', 175, 'RM13 6df', '07844934576', #2000-02-24#, 75, 'Tulsi', 'Patel')"
Run "INSERT INTO persondetail (RunnerID, FirstName, SecondName, HouseNumber, Postcode, PhoneNumber, DOB, Weight, Runnerusername, Runnerpassword) VALUES (305, 'Will', 'Baker', 177, 'RM4 6JV', '07434133214', #1998-07-08#, 50, 'WRB', 'Boss')"
Run "INSERT INTO persondetail (RunnerID, FirstName, SecondName, HouseNumber, Postcode, PhoneNumber, DOB, Weight, Runnerusername, Runnerpassword) VALUES (317, 'Ricky', 'Fisher', 1, 'RM3 4XX', '01708222222', #2001-12-14#, 50, 'Rixterz', ':3:3')"
Run "INSERT INTO persondetail (RunnerID, FirstName, SecondName, HouseNumber, Postcode, PhoneNumber, DOB, Weight, Runnerusername, Runnerpassword) VALUES (318, 'David', 'Guo', 9, 'AB1 2CD', '07123456789', #1997-01-16#, 75, 'faithfulstride1997', 'faithfulstride1997')"
Run "INSERT INTO persondetail (RunnerID, FirstName, SecondName, HouseNumber, Postcode, PhoneNumber, DOB, Weight, Runnerusername, Runnerpassword) VALUES (374, 'Joseph', 'Akin', 45, 'RM4 4DG', '02465626426', #1996-01-26#, 86, 'hesh15', 'gu3434')"
Run "INSERT INTO persondetail (RunnerID, FirstName, SecondName, HouseNumber, Postcode, PhoneNumber, DOB, Weight, Runnerusername, Runnerpassword) VALUES (375, 'Charlie', 'Lewin', 72, 'RM4 1BG', '04325525345', #1992-04-13#, 69, 'srh43', 'v2b34')"
Run "INSERT INTO persondetail (RunnerID, FirstName, SecondName, HouseNumber, Postcode, PhoneNumber, DOB, Weight, Runnerusername, Runnerpassword) VALUES (376, 'Tom', 'Pratt', 72, 'RM3 4GF', '04325324609', #1994-05-31#, 94, 'jd54', 'v3vbvg4')"
Run "INSERT INTO persondetail (RunnerID, FirstName, SecondName, HouseNumber, Postcode, PhoneNumber, DOB, Weight, Runnerusername, Runnerpassword) VALUES (377, 'Josh', 'Powers', 35, 'RM3 4SF', '07134132415', #1996-06-14#, 93, 'jt45', 'c4cv')"
Run "INSERT INTO persondetail (RunnerID, FirstName, SecondName, HouseNumber, Postcode, PhoneNumber, DOB, Weight, Runnerusername, Runnerpassword) VALUES (378, 'Harry', 'Hale', 45, 'RM3 2GF', '02342342423', #1994-07-27#, 83, 'rg42', '4c4gi')"
Run "INSERT INTO persondetail (RunnerID, FirstName, SecondName, HouseNumber, Postcode, PhoneNumber, DOB, Weight, Runnerusername, Runnerpassword) VALUES (379, 'Peter', 'Cruz', 68, 'RM4 4GF', '07141511515', #1998-04-25#, 83, 'bth54', 'y6y5')"
Run "INSERT INTO persondetail (RunnerID, FirstName, SecondName, HouseNumber, Postcode, PhoneNumber, DOB, Weight, Runnerusername, Runnerpassword) VALUES (380, 'Eldon', 'Ward', 39, 'IG2 4DE', '01423424324', #1996-02-03#, 64, 'ggt3', 'y4g45')"
Run "INSERT INTO persondetail (RunnerID, FirstName, SecondName, HouseNumber, Postcode, PhoneNumber, DOB, Weight, Runnerusername, Runnerpassword) VALUES (381, 'Dean', 'Knight', 51, 'RM11 9RE', '02135123684', #1996-02-16#, 72, 'gr4', 'fg4g')"
Run "INSERT INTO ranking (RunnerID, Totalcaloriesburned, Totaltimeoftraining, points) VALUES (304, 4352, 34, 76)"
Run "INSERT INTO ranking (RunnerID, Totalcaloriesburned, Totaltimeoftraining, points) VALUES (305, 4354, 24, 89)"
Run "INSERT INTO ranking (RunnerID, Totalcaloriesburned, Totaltimeoftraining, points) VALUES (317, 3453, 32, 24)"
Run "INSERT INTO ranking (RunnerID, Totalcaloriesburned, Totaltimeoftraining, points) VALUES (318, 9712, 16, 65)"
Run "INSERT INTO ranking (RunnerID, Totalcaloriesburned, Totaltimeoftraining, points) VALUES (374, 66526, 76, 45)"
Run "INSERT INTO ranking (RunnerID, Totalcaloriesburned, Totaltimeoftraining, points) VALUES (375, 3563, 45, 34)"
Run "INSERT INTO ranking (RunnerID, Totalcaloriesburned, Totaltimeoftraining, points) VALUES (376, 4534, 6, 65)"
Run "INSERT INTO ranking (RunnerID, Totalcaloriesburned, Totaltimeoftraining, points) VALUES (377, 5737, 65, 28)"
Run "INSERT INTO ranking (RunnerID, Totalcaloriesburned, Totaltimeoftraining, points) VALUES (378, 4373, 63, 25)"
Run "INSERT INTO ranking (RunnerID, Totalcaloriesburned, Totaltimeoftraining, points) VALUES (379, 3545, 51, 56)"
Run "INSERT INTO ranking (RunnerID, Totalcaloriesburned, Totaltimeoftraining, points) VALUES (380, 1123, 23, 47)"
Run "INSERT INTO ranking (RunnerID, Totalcaloriesburned, Totaltimeoftraining, points) VALUES (381, 5135, 94, 34)"
Run "INSERT INTO traininginformation (RunnerID, RunningSpeed, Runningtime, Cyclingspeed, Cyclingtime, Swimmingstyle, swimmingtime, caloriesburned, trainingNO, trainingdate) VALUES (318, '6 mph (10 minute mile)', 0.1, '7mph (8.5 minute mile)', 0.1, 'Freestyle, fast', 0.1, 138.2813, 2, #2015-03-02#)"
Run "INSERT INTO traininginformation (RunnerID, RunningSpeed, Runningtime, Cyclingspeed, Cyclingtime, Swimmingstyle, swimmingtime, caloriesburned, trainingNO, trainingdate) VALUES (318, '7mph (8.5 minute mile)', 0.1, '6 mph (10 minute mile)', 0.1, 'Freestyle, fast', 0.1, 152.1563, 11, #2015-03-02#)"
Run "INSERT INTO traininginformation (RunnerID, RunningSpeed, Runningtime, Cyclingspeed, Cyclingtime, Swimmingstyle, swimmingtime, caloriesburned, trainingNO, trainingdate) VALUES (318, NULL, 0, '6 mph (10 minute mile)', 0.1, NULL, 0, 33.1875, 23, #2015-03-31#)"
Run "INSERT INTO traininginformation (RunnerID, RunningSpeed, Runningtime, Cyclingspeed, Cyclingtime, Swimmingstyle, swimmingtime, caloriesburned, trainingNO, trainingdate) VALUES (318, '6 mph (10 minute mile)', 0.1, '6 mph (10 minute mile)', 0.1, 'Freestyle, slow', 0.1, 143.8125, 24, #2015-03-03#)"
Run "INSERT INTO traininginformation (RunnerID, RunningSpeed, Runningtime, Cyclingspeed, Cyclingtime, Swimmingstyle, swimmingtime, caloriesburned, trainingNO, trainingdate) VALUES (318, '6 mph (10 minute mile)', 0.1, NULL, 0, NULL, 0, 55.3125, 25, #2015-03-03#)"
Run "INSERT INTO traininginformation (RunnerID, RunningSpeed, Runningtime, Cyclingspeed, Cyclingtime, Swimmingstyle, swimmingtime, caloriesburned, trainingNO, trainingdate) VALUES (318, '7mph (8.5 minute mile)', 0.1, NULL, 0, NULL, 0, 63.65625, 26, #2015-03-03#)"
Run "INSERT INTO traininginformation (RunnerID, RunningSpeed, Runningtime, Cyclingspeed, Cyclingtime, Swimmingstyle, swimmingtime, caloriesburned, trainingNO, trainingdate) VALUES (318, NULL, 0, NULL, 0, 'Freestyle, fast', 0.1, 0, 27, #2015-03-03#)"
Run "INSERT INTO traininginformation (RunnerID, RunningSpeed, Runningtime, Cyclingspeed, Cyclingtime, Swimmingstyle, swimmingtime, caloriesburned, trainingNO, trainingdate) VALUES (318, NULL, 0, '8mph (7.5 minute mile)', 0.1, NULL, 0, 55.3125, 33, #2015-03-13#)"
Run "INSERT INTO traininginformation (RunnerID, RunningSpeed, Runningtime, Cyclingspeed, Cyclingtime, Swimmingstyle, swimmingtime, caloriesburned, trainingNO, trainingdate) VALUES (318, '10 mph (6 minute mile)', 5, '10 mph (6 minute mile)', 5, 'Butterfly', 5, 8850, 34, #2015-03-16#)"
Run "INSERT INTO traininginformation (RunnerID, RunningSpeed, Runningtime, Cyclingspeed, Cyclingtime, Swimmingstyle, swimmingtime, caloriesburned, trainingNO, trainingdate) VALUES (318, NULL, 0, '8mph (7.5 minute mile)', 0.4, NULL, 0, 221.25, 35, #2015-03-17#)"
Run "INSERT INTO adminpassword (ID) VALUES ('1234')"

con.Close
WScript.Echo "Inserted " & n & " records into " & dbPath
