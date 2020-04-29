using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworkEffect : MonoBehaviour
{
    private float birthTime;
    public float lifeSpan;

    // Start is called before the first frame update
    void Start()
    {
        birthTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - birthTime > lifeSpan)
        {
            Destroy(gameObject);
        }
    }
}
