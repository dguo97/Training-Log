Option Explicit
' Sets the postcode of test runner 318 in an existing Database.accdb to the fictional AB1 2CD.
' Usage: double-click (fixes bin\Debug and bin\Release), or: cscript fix_postcode.vbs "C:\path\Database.accdb"

Const NEW_PC = "AB1 2CD"

Dim fso, here, paths, i, con, n, targets
Set fso = CreateObject("Scripting.FileSystemObject")
here = fso.GetParentFolderName(WScript.ScriptFullName)

If WScript.Arguments.Count > 0 Then
  targets = Array(WScript.Arguments(0))
Else
  targets = Array(fso.BuildPath(here, "..\src\bin\Debug\Database.accdb"), fso.BuildPath(here, "..\src\bin\Release\Database.accdb"))
End If

For i = 0 To UBound(targets)
  If fso.FileExists(targets(i)) Then
    Set con = CreateObject("ADODB.Connection")
    On Error Resume Next
    con.Open "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fso.GetAbsolutePathName(targets(i)) & ";"
    If Err.Number <> 0 Then
      WScript.Echo "Could not open " & targets(i) & ": " & Err.Description
    Else
      con.Execute "UPDATE persondetail SET Postcode = '" & NEW_PC & "' WHERE RunnerID = 318", n
      If Err.Number <> 0 Then
        WScript.Echo "Update failed for " & targets(i) & ": " & Err.Description
      Else
        WScript.Echo targets(i) & ": " & n & " record(s) updated"
      End If
      con.Close
    End If
    On Error GoTo 0
  Else
    WScript.Echo "Not found (skipped): " & targets(i)
  End If
Next
