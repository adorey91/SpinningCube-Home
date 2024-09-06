using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    public int x = 90;
    public int y = 180;
    public int z = 25;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(x, y, z) * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
