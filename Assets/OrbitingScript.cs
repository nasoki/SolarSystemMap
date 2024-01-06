using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitingScript : MonoBehaviour
{
    Transform orbitTransform;
    public float rotateSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        orbitTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        orbitTransform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }
}
