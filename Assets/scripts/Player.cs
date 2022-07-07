using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Movimento;
    public float Velocidade= 10;
    public float ForcaPulo= 20;
    private Rigidbody2D rig;
        // Start is called before the first frame update
    void Start()
    {
        rig=GetComponent<Rigidbody2D>();
        
    }


    // Update is called once per frame
    void Update()
    {
        Movimento=Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(Velocidade * Movimento,rig.velocity.y);
           }
}