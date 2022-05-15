using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RePositionWithDelay());   
    }

    IEnumerator RePositionWithDelay()
    {
        while(true){
            SetRandomPosition();
            yield return new WaitForSeconds(5f);
        }
    }

    void SetRandomPosition()
    {
        float x = 130 + Random.Range(-10.0f, 10.0f);
        float z = 125 + Random.Range(-10.0f, 10.0f);
        Debug.Log("X,Z: " + z.ToString("F2") + ", " + z.ToString("F2"));
        transform.position = new Vector3(x, 0.0f, z);
    }

}
