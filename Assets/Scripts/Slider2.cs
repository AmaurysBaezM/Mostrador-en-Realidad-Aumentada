using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Slider2 : MonoBehaviour
{

    GameObject figura, robot, mascara;
    public Slider CambiarTama�o;

    // Start is called before the first frame update
    void Start()
    {
        robot = GameObject.FindWithTag("Robot");
        figura = GameObject.FindWithTag("Figura");
        mascara = GameObject.FindWithTag("Mascara");
        CambiarTama�o.onValueChanged.AddListener(delegate { Tama�oEscala(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Tama�oEscala()
    {
        robot = GameObject.FindWithTag("Robot");
        figura = GameObject.FindWithTag("Figura");
        mascara = GameObject.FindWithTag("Mascara");
        if (robot != null)
        {
            robot.transform.localScale = new Vector3(CambiarTama�o.value, CambiarTama�o.value, CambiarTama�o.value);

        }
        else if (figura != null)
        {
            figura.transform.localScale = new Vector3(CambiarTama�o.value, CambiarTama�o.value, CambiarTama�o.value);

        }
        else
        {
            mascara.transform.localScale = new Vector3(CambiarTama�o.value, CambiarTama�o.value, CambiarTama�o.value);

        }
        


    }
}
