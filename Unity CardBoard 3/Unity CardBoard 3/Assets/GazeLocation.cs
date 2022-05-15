using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GazeLocation : MonoBehaviour
{
    public Transform camera;
    private ColorBlock colors;
    private ColorBlock colorsHover;
    private int countTimer;
    private Button hitButton;

    void Start()
    {
        colorsHover = GameObject.Find("StartBtn").GetComponent<Button>().colors;
        colorsHover.normalColor = new Color(0.5980331f, 0.8396226f, 0.6175795f, 1);
        colorsHover = colorsHover;
        colors = GameObject.Find("StartBtn").GetComponent<Button>().colors;
        colors.normalColor = Color.white;
        colors = colors;
        countTimer = 0;
    }

    void Update()
    {
        Ray ray;
        RaycastHit hit;
        GameObject hitObject;

        Debug.DrawRay(camera.position, camera.rotation * Vector3.forward * 1000.0f);
        ray = new Ray(camera.position, camera.rotation * Vector3.forward);

        if (Physics.Raycast(ray, out hit))
        {
            countTimer += 1;
            hitObject = hit.collider.gameObject;

            if (hitObject.GetComponent<Button>() != null)
            {
                hitButton = hitObject.GetComponent<Button>();
                hitButton.colors = colorsHover;
            }
            else
            {
                reset();
            }

            if (countTimer >= 100)
            {
                countTimer = 0;
                hitButton.onClick.Invoke();
            }
        }
        else
        {
            reset();
        }

    }

    void reset()
    {
        if (hitButton != null)
        {
            hitButton.GetComponent<Button>().colors = colors;
            hitButton = null;
        }
        countTimer = 0;
    }

}
