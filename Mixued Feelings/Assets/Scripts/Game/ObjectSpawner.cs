// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class ObjectSpawner : MonoBehaviour
// {
//     // Prefab to spawn
//     public GameObject prefab;

//     // Time and Speed
//     public float interval;
//     public float minX, maxX, y;

//     // Sprites
//     public Sprite[] sprites;

//     // Start is called before the first frame update
//     void Start()
//     {
//         InvokeRepeating("Spawn", interval, interval);
//     }

//     private void Spawn() {
        
//         // Instantiate
//         GameObject instance = Instantiate (prefab);
//         instance.transform.position = new Vector2 (
//             Random.Range(minX, maxX),
//             y
//         );
//         // Inside Spawner
//         instance.transform.SetParent(transform);

//         // Select a sprite
//         Sprite randomSprite = sprites[Random.Range(0, sprites.Length)];
//         instance.GetComponent<SpriteRenderer>().sprite = randomSprite;

//     }
    
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    // Prefab to spawn
    public GameObject[] prefabs;

    // Time and Speed
    public float interval;
    public float minX, maxX, y;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", interval, interval);
    }

    private void Spawn()
    {
        // Select a prefab
        GameObject randomPrefab = prefabs[Random.Range(0, prefabs.Length)];
        
        // Instantiate
        GameObject instance = Instantiate(randomPrefab);
        instance.transform.position = new Vector2(
            Random.Range(minX, maxX),
            y
        );

        // Set the parent of the instantiated object to be the spawner
        instance.transform.SetParent(transform);
    }
}
