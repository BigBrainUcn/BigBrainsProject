using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camera : MonoBehaviour
{
    public GameObject Jugador;
    public Camera CamaraDeJuego;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CamaraDeJuego.transform.position = new Vector3(
            Jugador.transform.position.x,
            CamaraDeJuego.transform.position.y,
            CamaraDeJuego.transform.position.z
        );
        
    }
}
