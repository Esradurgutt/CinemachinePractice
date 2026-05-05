using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float timer = 0f;
    public List<GameObject> cameras = new List<GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer < 3f)
        {
            ActivateCamera(0);
        }
        else if (timer < 6f)
        {
            ActivateCamera(1);
        }
        else if (timer < 9f)
        {
            ActivateCamera(2);
        }
        else if (timer < 12f)
        {
            ActivateCamera(3);
        }
        else
        {
            timer = 0f; 
        }
    }

    void ActivateCamera(int index)
    {
        for (int i = 0; i < cameras.Count; i++)
        {
            cameras[i].SetActive(i == index);
        }
    }
}