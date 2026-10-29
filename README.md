# Training Log

A Windows desktop app for a running club to record members' training, compare their performance and pick a team. It is written in VB.NET (Windows Forms) and stores its data in a Microsoft Access database.

It started life in 2015 as a school computing coursework project, so treat it as a learning project rather than production software (see [Known limitations](#known-limitations)).

## What it does

**Runners**
- Sign up and sign in with their own username and password
- View and edit their personal details
- Record running, cycling and swimming sessions; calories burned are calculated from the runner's weight against an 80 kg reference
- View, sort and delete their own sessions, and see totals (time and calories)
- Compare their results with other runners for one activity
- Use a stand-alone calories calculator

**Admin** (password protected)
- Search runners by ID or surname, view their details and training records, and delete a runner together with their records
- Add race results; points are awarded by finishing position
- Rank runners by total calories, total training time and race points, work out an average ranking, and select the best eight as the team
- See each runner's position in the last race

## Tech

- VB.NET, Windows Forms (a 2015 Visual Basic 2008 project, now opened with a current Visual Studio)
- Microsoft Access (`.accdb`) through OleDb (`Microsoft.ACE.OLEDB.12.0`)
- Windows only

## Getting started

You need:
- Visual Studio (Community is fine) with the .NET desktop development workload
- The Microsoft Access Database Engine (ACE OLEDB) if Access isn't installed. Its 32-bit or 64-bit version must match the program (the project is AnyCPU, so it runs as 64-bit on 64-bit Windows)

Steps:
1. Clone the repository. If you downloaded a zip instead, right-click it, choose **Properties** and tick **Unblock** before extracting. Otherwise Visual Studio fails with error MSB3821.
2. Run `database\setup.bat`. It creates `Database.accdb` in `src\bin\Debug` and `src\bin\Release`, loaded with test data. Run `setup.bat empty` from a command prompt for an empty database.
3. Open `src\Training Log.vbproj` in Visual Studio, then build and run (F5). If Visual Studio can't target .NET Framework 3.5, set the target framework to 4.x in the project properties.

The program looks for `Database.accdb` next to the executable.

### Test accounts (from the test data)

| Role | Username | Password |
|---|---|---|
| Runner | `faithfulstride1997` | `faithfulstride1997` |
| Runner (no training records) | `Tulsi` | `Patel` |
| Admin | n/a | `1234` |

These are for testing only.

## Repository layout

```
src/        Visual Basic project (open "Training Log.vbproj")
database/   scripts that create the Access database and load test data
docs/       coursework write-up: problem definition, design, test plan and results, evaluation
```

## Documentation

`docs/` holds the original coursework documents, from the problem definition (1.1) through design (1.x, 2.x) to the test plan, test runs and evaluation (3.x). They describe the intended design and the testing that was done.

## Known limitations

This was written as a school project and it shows. Before using anything like it for real, fix these:

- **SQL is built by joining typed text into the query string**, which allows SQL injection. It should use parameterised queries.
- **Passwords are stored in plain text** (runner passwords in the database, the admin password in a table). They should be hashed.
- **Single-user Access database**, so runners can't use the program at the same time.
- **The calorie table, running speeds and swimming styles are fixed** in the code and database.
- **No automated tests.** Testing was done by hand, as recorded in `docs/`.
- **Windows only**, and tied to the Access Database Engine.

## Licence

The code and documents are released under the [MIT Licence](LICENSE). The photo in `src/Resources/` is a third-party image and is not covered by it; check its licence before reusing it.
