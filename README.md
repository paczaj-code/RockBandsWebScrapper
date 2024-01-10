# Projekt Web scrapper

Projekt zaliczeniowy dla 2 zadań
- Wzorce projektowe i dokumentowanie kodu
- Zadanie TAWZSP


## Backend  - Dotnet REST API

Backend zawiera 3 enpointy:
 - `/artistlist/{slug}` - zwracający tytuł i  listę wykonawców w podanym gatunku
 - `/artist/{slug}` -  zwracający szczegóły wbranego wykonawcy
- `/artistimage/{slug}` - zwracający zdjęcia w fomacie jpg wykonawcy

W projekcie zastosowano wzorzec projektowy **Fabryka** oraz dziedziczenie.
Dodano *annotations* do kodu.

## Frontend  - React

Dla przypomninia frontend został napisany w React TS.