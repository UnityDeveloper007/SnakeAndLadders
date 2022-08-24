using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantianteBlocks : MonoBehaviour
{
    public Image Block;
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
      {  
           count++;
           
           var block = Instantiate(Block, new Vector3(0, 0, 0), Quaternion.identity);
           var txtBlock =  Instantiate(blockText, new Vector3(0, 0, 0), Quaternion.identity);
           block.transform.parent = parent.transform;
           txtBlock.transform.parent = block.transform;
           txtBlock.text = count.ToString();
           if(x % 10 == 0)
           {
              /* for (x; i >= 0; i--)
               {

               }*/
               if(x%2 == 0){
               block.GetComponent<Image>().color = new Color32(255,255,225,100);
                }else{
                block.GetComponent<Image>().color = new Color32(0,0,0,100);
                }

           }
           

         //  blockTex.text = count.ToString();
           block.name = count.ToString();
          
          
      }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
