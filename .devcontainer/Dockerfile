# Offizielles SQL Server Image von Microsoft verwenden
FROM mcr.microsoft.com/mssql/server:2019-latest

# Umgebungsvariablen für den SQL Server konfigurieren
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=<Dein_sicheres_Passwort>

# Port 1433 für MSSQL exponieren
EXPOSE 1433

# Die Northwind-Datenbankdatei hinzufügen
# Ersetze den Pfad "Northwind.bak" mit dem korrekten Pfad deiner Backup-Datei
# Oder lade die Datei direkt in den Build-Context.
# Beispiel: ADD ./Northwind.bak /var/opt/mssql/backup/Northwind.bak
# Für dieses Beispiel gehen wir davon aus, dass die Datei bereits im Build-Context liegt.
ADD Northwind.bak /var/opt/mssql/backup/

# Ein Startskript erstellen, um die Datenbank wiederherzustellen
COPY init_northwind.sh /usr/src/app/init_northwind.sh
RUN chmod +x /usr/src/app/init_northwind.sh

# Das Startskript ausführen, nachdem der SQL Server gestartet ist
CMD ["/bin/bash", "-c", "/usr/src/app/init_northwind.sh"]