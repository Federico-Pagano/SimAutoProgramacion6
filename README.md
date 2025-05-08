# 🚗 Car Simulator - Programación 6to

Simulador básico de autoescuela desarrollado en Unity con C#.  
Este proyecto forma parte de la materia **Programación 6to año** y busca representar elementos esenciales de la conducción real.

---

## 🛢️ FuelTank.cs (Tanque de Nafta)

Este script gestiona el combustible del vehículo.

### 🔍 Funcionalidades:
- Define la capacidad máxima del tanque.
- Lleva el registro del combustible actual.
- Permite consumir nafta al moverse y recargar en estaciones.
- Informa el porcentaje restante y si queda o no combustible.

📌 Se conecta fácilmente al sistema de movimiento del auto para simular el gasto real según el uso.

---

## 📸 SpeedRadar.cs (Radar de Velocidad)

Script que simula un radar de velocidad con fotomulta.

### 🔍 Funcionalidades:
- Detecta vehículos que se acercan al radar desde una distancia configurable (20m o 50m).
- Calcula la velocidad promedio del auto al atravesar el tramo del radar.
- Si la velocidad supera el límite configurado, se genera una multa simulada.

📌 Ideal para representar control de velocidad en calles o autopistas, diferenciando zonas urbanas y de alta velocidad.

---

🧑‍💻 **Autor:** Fede  
🎓 **Curso:** 6to año – Técnico en Programación  
🧠 **Lenguaje:** C#  
🎮 **Motor:** Unity
