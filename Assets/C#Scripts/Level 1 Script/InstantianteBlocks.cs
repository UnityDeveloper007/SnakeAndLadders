using System.Security.Cryptography.X509Certificates;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantianteBlocks : MonoBehaviour
{
    public Button Block;
    public GameObject parent;
    public Text blockText;
    // Start is called before the first frame update     m
    void Start()
    {
        intantiateBlock(99);
    }


    private void intantiateBlock(int counter)
    {
        int count = 0;
      for(int x=0; x <= counter; x++)
      {    count++;
           var block = Instantiate(Block, new Vector3(0, 0, 0), Quaternion.identity);
           block.transform.parent = parent.transform;
           blockText.GetComponent<Text>().text = count.ToString();
           block.name = count.ToString();
          
      }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
