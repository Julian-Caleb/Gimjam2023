using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    
    // Gameplay
    public GameObject cutPrefab;
    public float cutLifetime;

    private bool dragging;
    private Vector2 swipeStart;

    // Update
    void Update () {

        if (Input.GetMouseButtonDown(0)) {
            dragging = true;
            swipeStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        } else if (Input.GetMouseButtonUp(0) && dragging) {
            dragging = false;
            SpawnCut();
        }

    }

    // Cutting Prefabs
    private void SpawnCut() {

        // Identified where the swipe ended
        Vector2 swipeEnd = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Spawned the cut object
        GameObject cutInstance = Instantiate (cutPrefab, swipeStart, Quaternion.identity);
        cutInstance.GetComponent<LineRenderer>().SetPosition(0,swipeStart);
        cutInstance.GetComponent<LineRenderer>().SetPosition(1,swipeEnd);

        // Adjusted the edge collider
        Vector2[] colliderPoints = new Vector2[2];
        colliderPoints[0]= Vector2.zero;
        colliderPoints[1]= swipeEnd - swipeStart;
        cutInstance.GetComponent<EdgeCollider2D>().points = colliderPoints;

        // Scheduled the destruction of the cut object
        Destroy(cutInstance, cutLifetime);

    }

}
