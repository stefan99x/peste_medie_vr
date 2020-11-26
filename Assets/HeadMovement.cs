using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMovement : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //source.Play();
        var screenPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.LookAt(screenPoint);
    }
}
