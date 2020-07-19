using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Rigidbody player;

    void Update()
    {
        if (player.position.y < 0) {
            Offsets.bGameStatus = false;
        }
        if (!Offsets.bGameStatus) {
            Invoke("reload", 2);
        }
    }

    void reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Offsets.bGameStatus = true;
    }
}
