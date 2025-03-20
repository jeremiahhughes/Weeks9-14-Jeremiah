using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabspawn : MonoBehaviour
{
    public GameObject knife;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 0;
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
            Instantiate(knife, worldPosition, Quaternion.identity);
        }
    }
}
