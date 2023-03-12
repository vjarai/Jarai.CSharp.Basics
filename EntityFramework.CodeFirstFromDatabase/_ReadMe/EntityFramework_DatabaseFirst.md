﻿# Entity Framework: Database First

- Erstellen Sie eine neue, leere Consolenanwendung.
- Fügen Sie dem Projekt (über Hinzufügen => Neu => Data) ein neues "ADO .NET Entity Data Model" hinzu.
- Wählen Sie als Typ "Codefirst from Database" und geben Sie die Verbindungsdaten zur Datenbank ein.
- Wählen Sie gewünschten Datenbank Tabellen aus und lassen Sie sich die zugehörigen Klassen generieren.
- Testen Sie, ob Sie Datensätze in der Datenbank lesen und ändern können.

### Hinweis:
Sie können sich die Datenbank im installierten "SQL Server Managment Studio" anzeigen lassen.
Der Server hat standardmäßig den Namen: (localdb)\MSSQLLocalDB

### Best Practice:
Umsicherzustellen dass die Datenbankverbindung geschlossen wird, 
sollte der DatabaseContext immer in einem using Block verwendet werden.
In der Praxis werden normalerweise "kurzlebige" DatabaseContext Instanzen verwendet, 
(d.h. die Datebankverbindung bleibt nur solange geöffnet, wie benötigt).







