using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsarPila : MonoBehaviour
{
    ObjetosAleatorios oa;
    void Start()
    {
        oa = (ObjetosAleatorios)GameObject.FindObjectOfType(typeof(ObjetosAleatorios));
    }

    private void OnMouseDown()
    {
        Debug.Log("Pila pulsada");
        Gestiondebaterias.baterias++;
        oa.BateriaEncontrada();
        Destroy(gameObject);
    }
}
