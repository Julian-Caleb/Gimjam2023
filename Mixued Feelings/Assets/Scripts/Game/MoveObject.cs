using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    //Speed variables
    public float minXSpeed, maxXSpeed, minYSpeed, maxYSpeed;

    // Time variables
    public float lifetime;

    void Start() {

        // Object velocity
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (
            Random.Range(minXSpeed, maxXSpeed),
            Random.Range(minYSpeed, maxYSpeed)
        );
        
        // Destroy
        Destroy(gameObject, lifetime);
    }

}
