using UnityEngine;
using System.Collections.Generic;

public class SpeedRadar : MonoBehaviour
{
    public float speedLimit = 60f;       // km/h
    public float detectionRange = 20f;   // Distancia antes del radar (20 o 50 metros)

    private Dictionary<GameObject, Vector3> entryPositions = new();
    private Dictionary<GameObject, float> entryTimes = new();

    private void Update()
    {
        Collider[] nearby = Physics.OverlapSphere(transform.position, detectionRange);

        foreach (Collider col in nearby)
        {
            if (col.CompareTag("Car") && !entryPositions.ContainsKey(col.gameObject))
            {
                entryPositions[col.gameObject] = col.transform.position;
                entryTimes[col.gameObject] = Time.time;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (entryPositions.ContainsKey(other.gameObject))
        {
            float distance = Vector3.Distance(entryPositions[other.gameObject], other.transform.position);
            float time = Time.time - entryTimes[other.gameObject];
            float avgSpeed = (distance / time) * 3.6f;

            if (avgSpeed > speedLimit)
            {
                Debug.Log($"¡FOTOMULTA! Promedio: {avgSpeed:F1} km/h");
            }

            entryPositions.Remove(other.gameObject);
            entryTimes.Remove(other.gameObject);
        }
    }
}
