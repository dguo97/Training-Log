Option Explicit
' Creates Database.accdb for the Training Log app (schema rebuilt from your design docs and the VB code).
' Usage: double-click, or: cscript create_database.vbs "C:\path\Database.accdb"
' With no argument the file is created next to this script.

Dim fso, dbPath, cat, con, stmts, i
Set fso = CreateObject("Scripting.FileSystemObject")

If WScript.Arguments.Count > 0 Then
  dbPath = WScript.Arguments(0)
Else
  dbPath = fso.BuildPath(fso.GetParentFolderName(WScript.ScriptFullName), "Database.accdb")
End If

If fso.FileExists(dbPath) Then
  WScript.Echo "Not overwriting existing file: " & dbPath
  WScript.Quit 1
End If

stmts = Array( _
  "CREATE TABLE adminpassword (ID TEXT(255) PRIMARY KEY)", _
  "CREATE TABLE persondetail (RunnerID COUNTER PRIMARY KEY, FirstName TEXT(255), SecondName TEXT(255), HouseNumber LONG, Postcode TEXT(255), PhoneNumber TEXT(255), DOB DATETIME, Weight LONG, Runnerusername TEXT(255), Runnerpassword TEXT(255))", _
  "CREATE TABLE traininginformation (RunnerID LONG, Runningtime SINGLE, RunningSpeed TEXT(255), Cyclingspeed TEXT(255), Cyclingtime SINGLE, Swimmingstyle TEXT(255), swimmingtime SINGLE, caloriesburned SINGLE, trainingNO COUNTER PRIMARY KEY, trainingdate DATETIME, CONSTRAINT fk_training_runner FOREIGN KEY (RunnerID) REFERENCES persondetail (RunnerID) ON DELETE CASCADE)", _
  "CREATE TABLE ranking (RunnerID LONG PRIMARY KEY, runnerposition LONG, Totalcaloriesburned SINGLE, Rankingofcalories LONG, Totaltimeoftraining SINGLE, Rankingoftime LONG, Rankingofpoints LONG, points LONG, lastraceposition LONG, Averageranking DOUBLE, CONSTRAINT fk_ranking_runner FOREIGN KEY (RunnerID) REFERENCES persondetail (RunnerID) ON DELETE CASCADE)" _
)

On Error Resume Next
Set cat = CreateObject("ADOX.Catalog")
cat.Create "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath & ";"
If Err.Number <> 0 Then
  WScript.Echo "Could not create the database: " & Err.Description & vbCrLf & _
    "If the ACE provider is missing or the bitness differs, install the Microsoft Access Database Engine," & vbCrLf & _
    "or run this with the other wscript/cscript (SysWOW64 = 32-bit, System32 = 64-bit)."
  WScript.Quit 1
End If

Set con = CreateObject("ADODB.Connection")
con.Open "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath & ";"
For i = 0 To UBound(stmts)
  con.Execute stmts(i)
  If Err.Number <> 0 Then
    WScript.Echo "Failed on statement " & (i + 1) & ": " & Err.Description
    con.Close
    WScript.Quit 1
  End If
Next
con.Close
WScript.Echo "Created " & dbPath
