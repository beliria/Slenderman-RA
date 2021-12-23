using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LookCamera : MonoBehaviour
{
    private Transform camera;
    public bool bloquearEjeY = true;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(camera);
        if (bloquearEjeY)
        {
            transform.DOLookAt(camera.position, 8, AxisConstraint.Y);
        }
        else
        {
            transform.DOLookAt(camera.position, 8);
        }
           
        //transform.rotation = new Quaternion(0, transform.rotation.y, 0, transform.rotation.w);
    }
}
