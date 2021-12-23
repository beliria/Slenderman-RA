using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gestiondebaterias : MonoBehaviour
{
    public TextMeshProUGUI numbaterias;
    public static int baterias = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numbaterias.text = baterias.ToString();
    }
}
