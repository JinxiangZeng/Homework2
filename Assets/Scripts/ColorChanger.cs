using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private void OnMouseDown()
    {
        Renderer renderer = GetComponent<Renderer>();
        Color color = renderer.material.color;

        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube");

        foreach (GameObject cube in cubes )
        {
            renderer = cube.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", color);
        }
    }
}
