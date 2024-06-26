using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gordijn : MonoBehaviour
{

    private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (okfwkfas.GetInstance().nein)
        {


            sprite.sortingOrder = -10000;

        }
    }
}
