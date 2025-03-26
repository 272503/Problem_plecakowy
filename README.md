# Problem Plecakowy (Knapsack Problem) – C#/.NET 6
Projekt realizuje klasyczny problem plecakowy (ang. Knapsack Problem) w języku C# z wykorzystaniem algorytmu zachłannego. Aplikacja dostępna jest w dwóch wersjach:

Konsolowej (Problem_plecakowy)

Graficznej (WinForms) (Aplikacja)

## Opis:

Problem polega na wybraniu przedmiotów o określonej wadze i wartości tak, aby zmaksymalizować ich łączną wartość, nie przekraczając przy tym limitu wagowego plecaka.

Zaimplementowany algorytm:

sortuje przedmioty według stosunku wartość/waga (ang. value-to-weight ratio),

dodaje je do plecaka dopóki nie zostanie przekroczona pojemność.

## Struktura projektu:

Problem_plecakowy/ - Aplikacja konsolowa │ Item.cs │ Problem.cs │ Result.cs │ Program.cs │ Problem_plecakowy.csproj │ MSTestSettings.cs

Aplikacja/ - Aplikacja graficzna (WinForms) │ Form1.cs │ Form1.Designer.cs │ Program.cs │ Aplikacja.csproj

Plecak_Test/ - Projekt testowy MSTest │ Test1.cs │ Plecak_Test.csproj

## Jak uruchomić:

### Wymagania:

.NET 8 SDK

Visual Studio 2022 lub nowszy (zalecane)

### Aplikacja konsolowa:

1. Otwórz folder Problem_plecakowy w Visual Studio lub w terminalu.

2. Uruchom projekt:

dotnet run --project Problem_plecakowy

3. Podaj dane:

 - liczbę przedmiotów

 - ziarno losowości

 - pojemność plecaka

### Aplikacja graficzna (WinForms):

1. Otwórz plik Aplikacja.csproj w Visual Studio.

2. Uruchom projekt (F5).

3. Wprowadź dane i kliknij "Run".

### Testy jednostkowe:

Projekt zawiera testy jednostkowe w frameworku MSTest:

dotnet test Plecak_Test

Testowane przypadki:

 - brak przedmiotów,

 - brak pojemności,

 - znany zestaw danych,

 - dokładne dopasowanie jednego przedmiotu,

 - poprawność wyboru i wartości.

### Przykład działania:

Wejście:

5 przedmiotów

seed: 42

pojemność: 10

Wynik: Items: 1,3,5 Total Value: 24 Total Weight: 10

## Technologie:

 - C# 10 / .NET 8

 - WinForms (dla GUI)

 - MSTest (testy jednostkowe)

Autor: Projekt stworzony przez Piotr Kosior w celach edukacyjnych.
