using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScene : MonoBehaviour
{
    void Update()
    {
        if (transform.position.x < 6 && transform.position.z > 170 && transform.position.z < 190)
        {
            StaticClass.PreviousScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene("MenuScene");
        }
    }
}
