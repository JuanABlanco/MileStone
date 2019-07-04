using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewProyectScript : MonoBehaviour
{
    public List<GameObject> Proyects;
    public GameObject ProyectPrefav, Canvas;

    public void Start()
    {
        //This initialitation needs to changes when persistency added
        Proyects.Add(gameObject);
    }

    //Method that call the proyect prefav, sort the proyect list on screen and locate the new proyect
    public void creatNewProyect()
    {
        //Sort list
        foreach (GameObject p in Proyects){
            p.transform.position =
                p.transform.position.x + 90 > Screen.width-20 ?
                    new Vector3(55, p.transform.position.y - 110, 0) :
                    p.transform.position + new Vector3(90, 0, 0);
        }

        //Instanciate prefav and add it to the list
        GameObject pro = GameObject.Instantiate(ProyectPrefav, Canvas.transform);
        pro.transform.position = new Vector3(55, 567, 0);
        Proyects.Add(pro);
    }
}
