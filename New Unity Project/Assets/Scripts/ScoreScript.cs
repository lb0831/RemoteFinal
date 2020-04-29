using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public int score;
    public AudioSource firework;
    public GameObject fireworkEffect;

    // Start is called before the first frame update
    void Start()
    {
        UpdateText();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            score++;
            UpdateText(); 
            if (score % 10 == 0)
            {
                firework.Play();


                Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                Instantiate(fireworkEffect, position, Quaternion.identity);
            }
        }
    }

    void UpdateText()
    {
        scoreText.text = "Score: " + score;
    }
}
