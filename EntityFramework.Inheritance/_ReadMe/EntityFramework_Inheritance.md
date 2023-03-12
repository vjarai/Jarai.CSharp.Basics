﻿# Entity Framework Vererbung <br> (TPH - Table per Hierarchie)

- Erstellen Sie die Klasse Contact mit einigen Properties.
- Leiten Sie davon die Klassen BusinessContact und PrivateContact ab und ergänzen Sie dort weitere Eigenschaften.
- Erstellen Sie die von DbContext abgleitet Klasse DatabaseContext mit einer DbSet<Contact> Contacts Property.
- Speichern Sie einige Privat und Geschäftskontakte in der Datenbank
- Testen Sie, ob Sie Datensätze in der Datenbank lesen und ändern können.
- Wieviele Tabellen werden im SQL Server generiert?
- Woran erkennt EntityFramework den Typ des gespeicherten Contacts ("Diskriminierende Spalte")?

### Hinweis:
Sie können sich die Datenbank im installierten "SQL Server Managment Studio" anzeigen lassen.
Der Server hat standardmäßig den Namen: (localdb)\MSSQLLocalDB

### Best Practice:
Umsicherzustellen dass die Datenbankverbindung geschlossen wird, 
sollte der DatabaseContext immer in einem using Block verwendet werden.
In der Praxis werden normalerweise "kurzlebige" DatabaseContext Instanzen verwendet, 
(d.h. die Datebankverbindung bleibt nur solange geöffnet, wie unbedingt benötigt).







