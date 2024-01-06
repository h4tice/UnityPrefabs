using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altinController : MonoBehaviour
{
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(Random.Range(7,47),18,8 );
        if(Input.GetKeyDown(KeyCode.Space))
            Instantiate(go,pos,transform.rotation);
    }
}
