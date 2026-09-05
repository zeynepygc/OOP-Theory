# Temple Tales

A 3D walkthrough built in Unity, made as a submission challenge for Unity's **Junior Programmer** pathway, demonstrating the four pillars of object-oriented programming.

▶️ Play it here: https://play.unity.com/en/games/8cb8ac00-92f7-4e4a-9c7c-b24e6e043244/temple-tales-oop

## Overview

The player explores an Indian temple and approaches three sacred statues — **Shiva Lingam**, **Radha-Krishna**, and **Ganesh** — interacting with each to receive its blessing.

<img width="400" alt="Ekran görüntüsü 2026-08-12 173433" src="https://github.com/user-attachments/assets/f6d7e34c-c9a0-49f1-bbb0-e0515ff1d2d4" />
<img width="400" alt="Ekran görüntüsü 2026-08-12 173404" src="https://github.com/user-attachments/assets/2c9f5223-26c7-4b35-80c6-78d56700c6ff" />


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


