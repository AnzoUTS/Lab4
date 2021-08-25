using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    
    private int i;
    private int random;
 
    
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        random = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        //Debug.Log("random: " + random);
        Debug.Log(this.gameObject.name+":"+i); 
        if (this.gameObject.tag == "Red" && i == 100)
        {
            this.gameObject.SetActive(false);
        }

        if (this.gameObject.tag == "Blue" && i == random)
        {
            rend.enabled = false;
        }

    }
}
