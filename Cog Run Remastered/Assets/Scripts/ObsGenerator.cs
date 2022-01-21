using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsGenerator : MonoBehaviour
{
    [SerializeField] Transform Obstacle_1;

    private void Awake()
    {
        Instantiate(Obstacle_1, new Vector3(-0.74f, 6.29f), Quaternion.identity);
    }
}
