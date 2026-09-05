# Temple Blessings

A 3D walkthrough built in Unity, made as a submission challenge for Unity's **Junior Programmer** pathway, demonstrating the four pillars of object-oriented programming.

## Overview

The player explores an Indian temple and approaches three sacred statues — **Shiva Lingam**, **Radha-Krishna**, and **Ganesh** — interacting with each to receive its blessing.

![Shiva Lingam blessing](Ekran_görüntüsü_2026-08-12_173404.png)
![Ganesh blessing](Ekran_görüntüsü_2026-08-12_173433.png)

## Controls

| Key | Action |
|-----|--------|
| W / S | Walk forward / backward |
| A / D | Turn left / right |
| E | Interact with a statue |

## OOP Pillars

This project was built specifically to demonstrate all four pillars of object-oriented programming:

- **Inheritance** — `ShivaLingam`, `RadhaKrishna`, and `Ganesh` all inherit from a base `TempleStatue` class.
- **Encapsulation** — Statue data (deity name, mantra) is kept in private fields and exposed only through public getters.
- **Polymorphism** — Each statue overrides `GetDisplayBlessing()` to return its own unique blessing message.
- **Abstraction** — The `Interact()` method hides the particle effects and UI message sequencing behind a single call, so calling code doesn't need to know how a blessing is actually presented.

## Built With

- **Unity** (C#)

## Author

Made by [Zeynep Yagci](https://github.com/zeynepygc) — part of learning Unity fundamentals through Unity's Junior Programmer certification path.
