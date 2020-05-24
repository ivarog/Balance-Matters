using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvocadorCarritos : MonoBehaviour
{
    [SerializeField] GameObject carrito;
    [SerializeField] Sprite spriteVaca;
    Vector3 initialPosition;
    float velocity;
    Sprite mysprite;

    private void Start() 
    {
        initialPosition = carrito.transform.position;    
        velocity = Random.Range(0.5f, 1f);

        mysprite = carrito.GetComponent<SpriteRenderer>().sprite;
        Color background = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        carrito.GetComponent<SpriteRenderer>().color = background;
        carrito.GetComponent<SpriteRenderer>().flipX = false;
        
    }
    
    private void Update() 
    {
        carrito.transform.Translate(Vector3.right * Time.deltaTime * velocity);
        if(carrito.transform.localPosition.x > 18f)
        {
            carrito.transform.position = initialPosition;
            velocity = Random.Range(0.5f, 1f);
            int vaca = Random.Range(1,10);
            if(vaca < 2)
            {
                carrito.GetComponent<SpriteRenderer>().sprite = spriteVaca; 
                carrito.GetComponent<SpriteRenderer>().color = Color.white;
                carrito.GetComponent<SpriteRenderer>().flipX = true;
            }
            else
            {
                carrito.GetComponent<SpriteRenderer>().sprite = mysprite;
                Color background = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
                carrito.GetComponent<SpriteRenderer>().color = background;
                carrito.GetComponent<SpriteRenderer>().flipX = false;
            }
        }
    }

}