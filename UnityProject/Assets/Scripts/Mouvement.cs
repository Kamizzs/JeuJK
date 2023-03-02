using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour
{

    public float vitesse = 10f;
    public Rigidbody2D rb;
    public

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("right"))
        rb.velocity = new Vector2(vitesse,0);

    }
}
