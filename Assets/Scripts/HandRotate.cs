using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HandRotate : MonoBehaviour
{
    [Tooltip("Debug only")]
    public bool debug = false;

    public Vector3 rotationTop;
    public Vector3 rotationDown;
    public float rotationSpeed = 1.0f;
    public float rotationSpeedChange = 1.0f;
    private bool rotating = false;

    [SerializeField]bool rotateUp = false;

    private void Start()
    {
        if (debug) rotating = true;
    }

    public void StartRotate()
    {
        rotating = true;
    }

    public void StopRotate()
    {
        rotating = false;
    }

    private void Update()
    {
        if ( rotating)
        {
            if (rotateUp)
            {
                if (transform.localRotation.eulerAngles.z >= rotationTop.z)
                {
                    rotateUp = false;
                }
                else
                {
                    Vector3 targetRot = transform.localRotation.eulerAngles;
                    targetRot.z += Time.deltaTime * rotationSpeed;
                    transform.localRotation = Quaternion.Euler(targetRot);
                }
            }else if (!rotateUp)
            {
                if (transform.localRotation.eulerAngles.z <= rotationDown.z)
                {
                    rotateUp = true;
                }
                else
                {
                    Vector3 targetRot = transform.localRotation.eulerAngles;
                    targetRot.z -= Time.deltaTime * rotationSpeed;
                    transform.localRotation = Quaternion.Euler(targetRot);
                }
            }
            rotationSpeed += Time.deltaTime * rotationSpeedChange;
        }
    }
}
