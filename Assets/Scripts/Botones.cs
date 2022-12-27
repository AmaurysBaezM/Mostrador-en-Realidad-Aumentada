using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Botones : MonoBehaviour
{
    public GameObject panel, panel2;
    public TextMeshProUGUI titulo, descripcion;
    GameObject figura, robot, mascara;
    // Start is called before the first frame update
    void Start()
    {
        panel = GameObject.FindWithTag("Panel");
        panel2 = GameObject.FindWithTag("Panel");
        robot = GameObject.FindWithTag("Robot");
        figura = GameObject.FindWithTag("Figura");
        mascara = GameObject.FindWithTag("Mascara");
        panel.SetActive(false);
        
        mascara.SetActive(false);
        figura.SetActive(false);
        robot.SetActive(false);

        robot.SetActive(true);
        titulo.text = robot.name;
        descripcion.text = "Modelo de un robot de juguete, hecho para que los niños puedan usarlos sin preocupaciones de dañarse.";

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void RegresarPanel()
    {
        panel.SetActive(true);
    }

    public void Hola()
    {
        panel2.SetActive(false);
    }
    public void OcultarPanel()
    {
        panel.SetActive(false);
    }

    public void MostrarRobot()
    {
        robot.SetActive(true);
        titulo.text = robot.name;
        descripcion.text = "Modelo de un robot de juguete, hecho para que los niños puedan usarlos sin preocupaciones de dañarse.";



        figura.SetActive(false);
        mascara.SetActive(false);

    }
    public void MostrarMascara()
    {
        figura.SetActive(false);
        robot.SetActive(false);
        mascara.SetActive(true);
        titulo.text = mascara.name;
        descripcion.text = "Mascara de gato antigua, que se usaba en celebraciones y carnavales.";

    }
    public void MostrarFigura()
    {
        mascara.SetActive(false);
        figura.SetActive(true);
        titulo.text = figura.name;
        descripcion.text = "Modelo de figura de accion de un superheroe misterioso, al dia de hoy no se sabe quien era esta persona.";

        robot.SetActive(false);
    }

}
