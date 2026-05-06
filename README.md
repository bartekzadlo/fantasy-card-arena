# 🎮 Fantasy Card Arena

## 📌 Opis projektu
**Fantasy Card Arena** to turowa gra PvP oparta o system kart, w której gracze rywalizują przy użyciu własnych talii jednostek. Każda karta reprezentuje jednostkę posiadającą statystyki oraz umiejętności, które wpływają na przebieg walki.

Gra skupia się na symulacji starcia dwóch graczy, gdzie kluczowe znaczenie ma strategia, kolejność zagrywania kart oraz zarządzanie polem bitwy.

---

## 🧠 Główne założenia
- Gra PvP (1 vs 1)
- System turowy
- Automatyczna walka jednostek na polu bitwy
- Losowanie i zarządzanie ręką kart
- Rozszerzalny system umiejętności

---

## 🃏 Karty
Każda karta w grze posiada:

### Statystyki:
- **Health** – punkty zdrowia
- **Damage** – obrażenia zadawane w ataku
- **Delay** – liczba tur zanim karta stanie się aktywna

### Dodatkowo:
- **Abilities** – lista umiejętności specjalnych

### Stan w grze:
- aktualne zdrowie
- licznik opóźnienia (delay)
- status aktywności

---

## 👤 Gracz
Każdy gracz posiada:
- Talię 15 kart (Deck)
- Rękę (Hand) – maksymalnie 3 karty
- Pole bitwy (Board)
- Bohatera (Hero)

---

## 🧙 Bohater (Hero)
- posiada tylko **Health**
- nie zadaje obrażeń
- może posiadać umiejętności specjalne (opcjonalnie)

---

## 🪖 Pole bitwy
- ograniczona liczba slotów
- karty ustawiane od lewej do prawej
- karty walczą z jednostką naprzeciwko lub bohaterem przeciwnika

---

## 🔄 Przebieg tury
Każda tura składa się z następujących faz:

### 1. Zagranie karty
- gracz wybiera kartę z ręki
- karta trafia na pierwsze wolne miejsce na planszy
- gracz dobiera nową kartę z talii

### 2. Aktualizacja kart
- zmniejszenie Delay wszystkich kart
- aktywacja kart po osiągnięciu 0 Delay

### 3. Umiejętności
- aktywacja efektów per turn
- wywołanie zdarzeń specjalnych

### 4. Ataki
- każda aktywna karta atakuje co turę
- cel: karta przeciwnika lub bohater

### 5. Usuwanie kart
- karty z 0 HP są usuwane z pola bitwy
- aktywacja efektów śmierci

### 6. Przesunięcie kart
- karty przesuwają się w lewo
- brak pustych slotów na planszy

---

## 🏆 Warunek zwycięstwa
Gra kończy się, gdy:
- HP bohatera jednego z graczy spadnie do 0

---

## 🧱 Architektura (CQRS)
Projekt wykorzystuje podejście CQRS:

### 🔴 Commands (modyfikacja stanu)
- `StartGameCommand`
- `PlayCardCommand`
- `EndTurnCommand`

### 🔵 Queries (odczyt danych)
- `GetGameStateQuery`

---

## 🧩 Model domenowy
Główne klasy:
- Game
- Player
- Deck
- Hand
- Board
- CardInstance
- Hero
- Ability (system strategii)

---

## ⚙️ System umiejętności
Umiejętności są implementowane jako niezależne komponenty wywoływane w odpowiednich momentach gry:
- OnTurnStart
- OnAttack
- OnDeath

Pozwala to na łatwe rozszerzanie gry o nowe efekty.

---

## 🚀 Możliwe rozszerzenia
- system many
- tryb kampanii single-player
- AI przeciwnika
- multiplayer online (SignalR)
- system rzadkości kart
- deck builder

---

## 🎯 Cel projektu
Projekt został stworzony jako:
- ćwiczenie architektury CQRS w C#
- praktyka projektowania systemów domenowych
- implementacja gry symulacyjnej

---

## 📌 Technologie
- C#
- .NET
- (opcjonalnie) Unity / WPF / Console UI

---

## 🧠 Autor
Projekt edukacyjny – system kartowy typu fantasy PvP

