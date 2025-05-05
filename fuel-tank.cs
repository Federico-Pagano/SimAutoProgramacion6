public class FuelTank
{
    public float maxFuel = 50f; // Capacidad máxima del tanque (litros)
    public float currentFuel;   // Combustible actual

    public FuelTank()
    {
        currentFuel = maxFuel; // Empieza lleno
    }

    // Consumir combustible (por ejemplo, al acelerar)
    public void ConsumeFuel(float amount)
    {
        currentFuel -= amount;
        currentFuel = Mathf.Clamp(currentFuel, 0f, maxFuel); // Asegura que no baje de 0
    }

    // Cargar combustible
    public void Refuel(float amount)
    {
        currentFuel += amount;
        currentFuel = Mathf.Clamp(currentFuel, 0f, maxFuel);
    }

    // Obtener el porcentaje de combustible restante
    public float GetFuelPercentage()
    {
        return currentFuel / maxFuel;
    }

    // Ver si hay combustible
    public bool HasFuel()
    {
        return currentFuel > 0f;
    }
}
