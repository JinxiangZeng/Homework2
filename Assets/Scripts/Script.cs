using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    void OnMouseDown()
    {
        Renderer renderer = GetComponent<Renderer>();
        transform.localScale = new Vector3(1f, 0.6f, 0.87f);

        GameObject[] cylinderObjects = GameObject.FindGameObjectsWithTag("Cylinder");
        foreach (GameObject cylinderObject in cylinderObjects)
        {
            Renderer cylinder = cylinderObject.GetComponent<Renderer>();
            if (cylinder.material.color != renderer.material.color)
            {
                cylinder.transform.localScale = new Vector3(1f, 0.29f, 0.87f);
            }
        }
    }
}
