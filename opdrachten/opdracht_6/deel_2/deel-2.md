## Dataformaten en databanken

De Coene Bruno
18-12-2018
 
**DEEL 2: DATABANKEN**

 **- Wat is een databank**
 Een databank is een systematische collectie van data die digitaal wordt opgeslagen. De data in een database wordt georganiseerd en gestructureerd zodat werken met deze data op een vlotte manier kan verlopen.

**Soorten databanken**

 - Relationele database
 - Object database
 - Flat file database

*Relationele databank*
 - hierin wordt gebruik gemaakt van *keys* die een onderlinge relatie aanduiden tussen de data in onze database.
 - de gegevens worden opgeslagen in tabellen
 - de rijen vormen de records of soortgelijke groepen informatie
 - de kolommen houden de informatie bij die voor elk record moet worden opgeslagen
 - veel gebruikte relationele databases zijn: MySQL (in combinatie met php), Oracle, Microsoft SQL Server

*Object databasek*

 - In een object geörienteerde databank wordt zoals de naam aangeeft met objecten gewerkt
 - een andere naam voor deze databank is het semantische database model
 - eenvoudig invoegen van objecten en deze met de object geörienteerde taal op slaan in de databank
 - gebruik van tupels (rij van objecten) niet nodig, in relationele database wel
 - joins zijn niet nodig waardoor data sneller kan worden opgevraagd dan bij de relationele databank

*Flat file databank*

 - de flat file databank is een eenvoudige database vorm
 - een tweedimensionale reeks van rijen en kolommen
 - alle elementen in dezelfde kolom bevatten gelijksoortige waarden (bvb. kolom voor bedragen, kolom voor datum)
 - alle elementen in dezelfde rij zijn aan elkaar gerelateerd (bvb. rij houdt dan bij wie welk bedrag op welke dag moet betalen)
 - kolommen zullen meestal zo niet altijd beschikken over waarden van een bepaald data type (tekst, (gehele, floating) getallen ...)
