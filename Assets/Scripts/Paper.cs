using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : MonoBehaviour
{
    public float speed;
    public int valor = 1;
    public GameManager gameManager;

    private void Update(){
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            gameManager.SumarPuntos(valor);
            Destroy(this.gameObject);
        }
        
    }
}