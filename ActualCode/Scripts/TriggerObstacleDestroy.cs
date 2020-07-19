using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class TriggerObstacleDestroy : MonoBehaviour
{
    public GameObject obstacle;

    private void Start()
    {
        StartCoroutine(obstacleSpawn());
    }

    float genObsPos() {
        System.Random random = new System.Random();
        //-4.23f, 4.48f
        return random.Next(-4, 4);
    }

    void spawnObstacle() {
        GameObject obs = Instantiate(obstacle) as GameObject;
        obs.transform.position = new UnityEngine.Vector3(genObsPos(), 1.015f, 45.46f);
    }

    IEnumerator obstacleSpawn() {
        while (true) { 
            yield return new WaitForSeconds(0.5f);
            spawnObstacle();
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        Destroy(collider.gameObject);
    }
}
