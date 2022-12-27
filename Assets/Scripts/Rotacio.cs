using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Rotacio : MonoBehaviour
{

    GameObject figura, robot, mascara;
    VirtualButtonBehaviour boton;
    int n = 0;

    // Start is called before the first frame update
    void Start()
    {
      

        robot = GameObject.FindWithTag("Robot");
        figura = GameObject.FindWithTag("Figura");
        mascara = GameObject.FindWithTag("Mascara");
        boton = GetComponentInChildren<VirtualButtonBehaviour>();

        boton.RegisterOnButtonPressed(PresionaBoton);
        boton.RegisterOnButtonReleased(SoltarBoton);


    }

    void PresionaBoton(VirtualButtonBehaviour b)
    {
        n = 1;
    }


    void SoltarBoton(VirtualButtonBehaviour b)
    {
        n = 2;


    }


    // Update is called once per frame
    void Update()
    {
        robot = GameObject.FindWithTag("Robot");
        figura = GameObject.FindWithTag("Figura");
        mascara = GameObject.FindWithTag("Mascara");
        if (n == 1)
        {

            if (robot != null)
            {
                robot.transform.Rotate(0f, 0f, 1f);

            }
            else if (figura != null){
                figura.transform.Rotate(0f, 0f, 1f);

            }
            else
            {
                mascara.transform.Rotate(0f, 0f, 1f);

            }


        }
        if (n == 2)
        {

            if (robot != null)
            {
                robot.transform.Rotate(0f, 0f, 0f);

            }
            else if (figura != null)
            {
                figura.transform.Rotate(0f, 0f, 0f);

            }
            else
            {
                mascara.transform.Rotate(0f, 0f, 0f);

            }
         

        }

    }
}
