﻿# Entity Framework: Code First

- Erstellen Sie die Klasse Contact mit den public Properties: int Id, string Name, string Ort, ...
- Erstellen Sie eine Klasse DatabaseContext, die von DbContext abgeleitet ist. <br>
Hierzu muss das nuget Paket "Entity Framework 6" (NICHT Core) installiert sein (Manage Nuget Packages).
- Erstellen Sie in der Klasse DatabaseContext folgende public Property: ``` DbSet<Contact> Contacts ```
- Erstellen Sie in Main jeweils eine neue DatabaseContext und Contact Instanz.
- Fügen Sie den neu erstellten Contact dem DatenbankContext hinzu.
- Speichern Sie alle Änderungen mit SaveChanges() in der Datenbank.
- Testen Sie, ob Sie Datensätze in der Datenbank lesen und ändern können.
- Was versteht man unter "Persistence Ignorance"? Auf welche Klasse trifft das zu?

Hinweise
========
Sie können sich die generierte Datenbank im "SQL Server Managment Studio" anzeigen lassen.
Der Server hat standardmäßig den Namen: (localdb)\MSSQLLocalDB
Die Datenbank hat standardmäßig gleichen Namen wie das Projekt in Visual Studio.

Best Practice:
==============
Umsicherzustellen dass die Datenbankverbindung geschlossen wird, 
sollte der DatabaseContext immer in einem using Block verwendet werden.
In der Praxis werden normalerweise "kurzlebige" DatabaseContext Instanzen verwendet, 
(d.h. die Datebankverbindung bleibt nur solange geöffnet, wie benötigt).







