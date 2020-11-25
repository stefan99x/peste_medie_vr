using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementLArm : MonoBehaviour
{
    public Transform LeftArm;
    public float LeftArmSpeed;
    public float LeftArmAngle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LeftArmAngle += 0.2f * LeftArmSpeed * -Time.deltaTime;
        LeftArmAngle = Mathf.Clamp(LeftArmAngle, 0, 45f);
        LeftArm.localRotation = Quaternion.AngleAxis(LeftArmAngle, Vector3.left);   // <= rotate only on the Y axis
    }
}
