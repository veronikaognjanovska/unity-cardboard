using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{
    public GameObject menuSection;
    public GameObject aboutSection;
    public GameObject exitSceneSection;

    void Start()
    {
        if (StaticClass.PreviousScene == "SampleScene")
        {
            menuSection.SetActive(false);
            aboutSection.SetActive(false);
            exitSceneSection.SetActive(true);
        }
        else
        {
            menuSection.SetActive(true);
            aboutSection.SetActive(false);
            exitSceneSection.SetActive(false);
        }
        StaticClass.PreviousScene = SceneManager.GetActiveScene().name;
    }

}
