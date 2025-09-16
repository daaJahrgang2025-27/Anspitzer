#!/bin/bash

# Warte, bis der SQL Server verfügbar ist
echo "Warte auf SQL Server..."
until /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P floerp -Q "SELECT 1" &> /dev/null
do
    sleep 1
done
echo "SQL Server ist online! ✨"

# Datenbank wiederherstellen
echo "Stelle Northwind-Datenbank wieder her..."
/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P floerp -Q "RESTORE DATABASE Northwind FROM DISK='/var/opt/mssql/backup/Northwind.bak' WITH MOVE 'Northwind' TO '/var/opt/mssql/data/Northwind.mdf', MOVE 'Northwind_log' TO '/var/opt/mssql/data/Northwind_log.ldf'"

echo "Northwind-Datenbank erfolgreich wiederhergestellt! 🎉"