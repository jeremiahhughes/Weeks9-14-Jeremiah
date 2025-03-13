using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{

    public Image image;
   public GameObject prefab;
    public Sprite mouseIsOnUs;
    public Sprite mouseIsNotOverUs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PointerOnUs()
    {
        image.sprite = mouseIsOnUs;
        Debug.Log("The mouse has entered");
    }

    public void PointerNotOnUs()
    {
        image.sprite = mouseIsNotOverUs;
        Debug.Log("The mouse is not on us");
    }

    public void SpawnPrefab()
    {
        Instantiate(prefab, Random.insideUnitCircle * 4, transform.rotation);
        Debug.Log("prefab spawned");
    }
}
