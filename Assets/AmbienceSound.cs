using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AmbienceSound : MonoBehaviour
{
    [Tooltip("Area of the sound to be in")]
    public Collider[] areas;
    [Tooltip("Character to track")]
    public GameObject player;

    void Update()
    {
        Vector3 nearestPoint = Vector3.zero;
        float minDistance = float.MaxValue;

        foreach (Collider area in areas)
        {
            Vector3 point = area.ClosestPoint(player.transform.position);
            float distance = Vector3.Distance(player.transform.position, point);

            if (distance < minDistance)
            {
                minDistance = distance;
                nearestPoint = point;
            }
        }

        transform.position = nearestPoint;
    }
}
