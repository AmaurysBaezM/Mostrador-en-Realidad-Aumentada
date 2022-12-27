using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Slider2 : MonoBehaviour
{

    GameObject figura, robot, mascara;
    public Slider CambiarTamaño;

    // Start is called before the first frame update
    void Start()
    {
        robot = GameObject.FindWithTag("Robot");
        figura = GameObject.FindWithTag("Figura");
        mascara = GameObject.FindWithTag("Mascara");
        CambiarTamaño.onValueChanged.AddListener(delegate { TamañoEscala(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TamañoEscala()
    {
        robot = GameObject.FindWithTag("Robot");
        figura = GameObject.FindWithTag("Figura");
        mascara = GameObject.FindWithTag("Mascara");
        if (robot != null)
        {
            robot.transform.localScale = new Vector3(CambiarTamaño.value, CambiarTamaño.value, CambiarTamaño.value);

        }
        else if (figura != null)
        {
            figura.transform.localScale = new Vector3(CambiarTamaño.value, CambiarTamaño.value, CambiarTamaño.value);

        }
        else
        {
            mascara.transform.localScale = new Vector3(CambiarTamaño.value, CambiarTamaño.value, CambiarTamaño.value);

        }
        


    }
}
