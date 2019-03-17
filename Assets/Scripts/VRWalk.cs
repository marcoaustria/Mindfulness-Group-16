using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRWalk : MonoBehaviour
{
    public float speed = 3.0f;
    private CharacterController cc;
    private Transform vrCamera;

    private bool isWalking = false;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        vrCamera = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void movePlayer()
    {

    }
}
