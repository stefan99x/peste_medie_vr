using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMovement : MonoBehaviour
{
    public Transform Head;
    public float HeadSpeed;     // ( ͡° ͜ʖ ͡°) 
    float HeadAngle;

    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        //source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //source.Play();
        HeadAngle += Input.GetAxis("Mouse X") * HeadSpeed * -Time.deltaTime;
        HeadAngle = Mathf.Clamp(HeadAngle, 0, 30f);
        Head.localRotation = Quaternion.AngleAxis(HeadAngle, Vector3.up);   // <= rotate only on the Y axis
    }
}
