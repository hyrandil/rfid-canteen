
Du bist ein erfahrener Full-Stack-Webentwickler. Erstelle eine komplette, lauffähige Webanwendung für eine browserbasierte Mitarbeiter-Zeiterfassung, ähnlich der Funktionalität von „timeCard 10“ (Zeiterfassung, Urlaubsplanung, Berichte, Standort der Buchungen).

Technologie-Stack:
- Backend: Node.js mit Express und TypeScript
- Frontend: React mit TypeScript (SPA), gebaut mit Vite oder Create React App
- Datenbank: PostgreSQL, angebunden über ein ORM (z.B. Prisma oder TypeORM)
- Authentifizierung: JWT-basierte Authentifizierung mit rollenbasiertem Rechtemanagement (RBAC)

Implementiere mindestens folgende Features:

1. Benutzer- und Rollenverwaltung
   - Rollen: Mitarbeiter, Teamleiter, HR, Administrator
   - Registrierung/Anlegen von Benutzern durch Administrator
   - Login/Logout, Passwort-Hashing, JWT-Token-Verwaltung
   - Middleware für Berechtigungsprüfung (z.B. nur HR/Admin dürfen Stammdaten ändern)

2. Mitarbeiter- und Personalverwaltung (Backend-API + React-UI)
   - REST-Endpoints zum Anlegen/Lesen/Aktualisieren/Löschen (CRUD) von Mitarbeitern
   - Felder: Personalnummer, Name, E-Mail, Rolle, Standort, Abteilung, Arbeitszeitmodell, Eintrittsdatum, optional Austrittsdatum
   - React-Ansichten:
     - Tabelle mit Filter/Suche
     - Detailansicht mit Formular und Validierung

3. Zeiterfassung (Kommen/Gehen-Stempelung)
   - Endpoints zum Buchen von Kommen, Gehen und Pausen (Start/Ende)
   - Speicherung von:
     - Mitarbeiter-ID
     - Zeitstempel (UTC)
     - Buchungstyp (KOMMEN, GEHEN, PAUSE_START, PAUSE_ENDE)
     - Buchungsquelle (WEB, APP, TERMINAL)
     - Optional: GPS-Position (Latitude/Longitude) als Felder in der Datenbank
   - Logik zur Berechnung von Tages-Ist-Zeit, Soll-Zeit (aus Arbeitszeitmodell) und Differenz
   - React-UI:
     - Dashboard, das den aktuellen Status anzeigt (angemeldet/abgemeldet/Pause)
     - Buttons „Kommen“, „Gehen“, „Pause starten“, „Pause beenden“
     - Monatsübersicht der Buchungen mit Summenzeile für den Monat

4. Arbeitszeitmodelle
   - Tabelle/Modelle für Arbeitszeitprofile (z.B. Sollstunden pro Wochentag, Pausenregeln)
   - Zuweisung eines Arbeitszeitprofils zu jedem Mitarbeiter
   - Logik im Backend zur Berechnung von Sollzeiten pro Tag basierend auf dem Profil

5. Urlaubs- und Abwesenheitsplanung
   - Datenmodell für Abwesenheitsanträge: Mitarbeiter, Zeitraum von/bis, Abwesenheitsart (Urlaub, Krankheit, etc.), Status (Beantragt, Genehmigt, Abgelehnt), Kommentar
   - Endpoints für:
     - Anlegen eines neuen Antrags durch Mitarbeiter
     - Auflisten der eigenen Anträge
     - Auflisten und Genehmigen/Ablehnen von Anträgen durch Teamleiter/HR
   - React-UI:
     - Formular zum Stellen eines Urlaubsantrags mit Validierung
     - Persönliche Übersicht aller Anträge mit Status
     - Team-/Abteilungs-Ansicht (Kalender oder Tabelle) für genehmigte Abwesenheiten

6. Reporting und Exporte
   - Backend-Endpunkte für:
     - Monatsbericht pro Mitarbeiter (Tage, Ist-Zeit, Soll-Zeit, Differenz)
     - Gesamte Überstundenliste pro Zeitraum
   - Möglichkeit, Daten als CSV/JSON herunterzuladen
   - Frontend-Seite „Berichte“ mit Filtermöglichkeiten (Zeitraum, Mitarbeiter, Abteilung)

7. Architektur- und Codequalität
   - Saubere Ordnerstruktur (z.B. /backend und /frontend oder Monorepo)
   - Verwendung von TypeScript-Typen im gesamten Code
   - Trennung von Schichten: Routen, Controller/Services, Datenzugriff (Repository oder ORM-Layer)
   - Beispielscripts zum Initialisieren der Datenbank (Migration/Schema)
   - Kurze README-Datei mit:
     - Setup-Anleitung (Install, Migrations, Start-Skripte)
     - Beschreibung der wichtigsten Endpunkte
     - Beispiel-Login-Daten

Liefere:
- Vollständigen Backend-Code (Express/TypeScript), inkl. package.json und Beispiel-Konfiguration für die DB-Verbindung
- Vollständigen Frontend-Code (React/TypeScript) mit Routing (z.B. react-router) und mindestens folgenden Seiten:
  - Login
  - Dashboard (Stempeln + Kurzübersicht)
  - Zeiterfassung / Monatsübersicht
  - Urlaubsanträge
  - Mitarbeiterverwaltung (nur für HR/Admin)
  - Berichte
- Beispiele für ein oder zwei Unit-Tests (z.B. für eine zentrale Service-Funktion im Backend).

Schreibe den Code so, dass er lokal mit `npm install` und `npm start` (oder `npm run dev`/`npm run server`) lauffähig ist. Kommentiere komplexere Stellen kurz, aber verständlich.
