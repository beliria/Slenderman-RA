using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VistaSlenderman : MonoBehaviour
{
    public float tiempoMirada = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.transform.tag == "Player")
        {
            Debug.Log("Player");

        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            tiempoMirada += Time.deltaTime;
        }

        if (tiempoMirada >= 5)
        {
            SceneManager.LoadScene("Death Menu");
        }
    }
}
