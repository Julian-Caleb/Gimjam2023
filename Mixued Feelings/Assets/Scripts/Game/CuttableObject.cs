using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttableObject : MonoBehaviour
{

    public bool harmful;
    
    public Sprite newSprite;
    private SpriteRenderer spriteRenderer;
    
    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D (Collision2D collision) {
        if (collision.gameObject.tag == "Cut") {

            spriteRenderer.sprite = newSprite;

            GetComponent<Collider2D>().enabled = false;

            if (!harmful) {
                GameObject.Find("ScoreText").transform.GetComponent<ScoreText>().Score += 10;
            } else {
                GameObject.Find("LifeCounter").transform.GetComponent<LifeCounter>().LoseLife();
            }

        }
    }

    

}
