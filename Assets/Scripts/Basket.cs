using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    int score = 0;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float mouseX = mousePosition.x;
        mouseX = Mathf.Clamp(mouseX, -7.5f, 7.5f);
        transform.position = new Vector3(mouseX, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        scoreText.text = "Score " + score;
        Destroy(collision.gameObject);
    }
}
