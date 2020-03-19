using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Oscillator : MonoBehaviour
{
    [SerializeField] Vector3 movementVector;

    //TODO remove from inspector later
    [Range(0, 1)] [SerializeField] float movementFactor; // 0 for not moved, 1 for fully moved

    Vector3 startingPos;
    bool movingDown = true;

    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //TODO set movement factor

        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPos + offset;

        // if (movingDown)
        // {
        //     if (movementFactor < 1)
        //     {
        //         movementFactor += Time.deltaTime;
        //     }
        //     else
        //     {
        //         movingDown = false;
        //     }
        // }
        // else
        // {
        //     if (movementFactor > 0)
        //     {
        //         movementFactor -= Time.deltaTime;
        //     }
        //     else
        //     {
        //         movingDown = true;
        //     }
        // }
    }
}
