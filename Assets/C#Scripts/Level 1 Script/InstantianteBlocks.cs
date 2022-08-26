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
      for(int x=0; x <= 101; x++)
      {  
           count++;
           
         
           if(x == 10)
           {
               Debug.Log(x);
                for(int y=1; y <= 10; y++){
                    var block = Instantiate(Block, new Vector3(0, 0, 0), Quaternion.identity);
                    var txtBlock =  Instantiate(blockText, new Vector3(0, 0, 0), Quaternion.identity);
                    block.transform.parent = parent.transform;
                    txtBlock.transform.parent = block.transform;
                    txtBlock.text = y.ToString();
                      if(y%2 == 0){
                           block.GetComponent<Image>().color = new Color32(255,255,225,100);
                        }else{
                        block.GetComponent<Image>().color = new Color32(0,0,0,100);
                        }
                             block.name = y.ToString();
                 }

           }

           if(x == 20)
           {
             // int i = totaltime; i >= 0; i--
                for(int y=20; y > 10; y--){
                    var block = Instantiate(Block, new Vector3(0, 0, 0), Quaternion.identity);
                    var txtBlock =  Instantiate(blockText, new Vector3(0, 0, 0), Quaternion.identity);
                    block.transform.parent = parent.transform;
                    txtBlock.transform.parent = block.transform;
                    txtBlock.text = y.ToString();
                      if(y%2 == 0){
                           block.GetComponent<Image>().color = new Color32(255,255,225,100);
                        }else{
                        block.GetComponent<Image>().color = new Color32(0,0,0,100);
                        }
                             block.name = y.ToString();
                 }

           }
           


          if(x == 30)
           {
               Debug.Log(x);
                 for(int y=21; y <= 30; y++){
                    var block = Instantiate(Block, new Vector3(0, 0, 0), Quaternion.identity);
                    var txtBlock =  Instantiate(blockText, new Vector3(0, 0, 0), Quaternion.identity);
                    block.transform.parent = parent.transform;
                    txtBlock.transform.parent = block.transform;
                    txtBlock.text = y.ToString();
                      if(y%2 == 0){
                           block.GetComponent<Image>().color = new Color32(255,255,225,100);
                        }else{
                        block.GetComponent<Image>().color = new Color32(0,0,0,100);
                        }
                             block.name = y.ToString();
                 }

           }


           if(x == 40)
           { 
             
                     for(int y=40; y > 30; y--){
                    var block = Instantiate(Block, new Vector3(0, 0, 0), Quaternion.identity);
                    var txtBlock =  Instantiate(blockText, new Vector3(0, 0, 0), Quaternion.identity);
                    block.transform.parent = parent.transform;
                    txtBlock.transform.parent = block.transform;
                    txtBlock.text = y.ToString();
                      if(y%2 == 0){
                           block.GetComponent<Image>().color = new Color32(255,255,225,100);
                        }else{
                        block.GetComponent<Image>().color = new Color32(0,0,0,100);
                        }
                             block.name = y.ToString();
                 }
           }

            if(x == 50)
           {
                 for(int y=41; y <= 50; y++){
                    var block = Instantiate(Block, new Vector3(0, 0, 0), Quaternion.identity);
                    var txtBlock =  Instantiate(blockText, new Vector3(0, 0, 0), Quaternion.identity);
                    block.transform.parent = parent.transform;
                    txtBlock.transform.parent = block.transform;
                    txtBlock.text = y.ToString();
                      if(y%2 == 0){
                           block.GetComponent<Image>().color = new Color32(255,255,225,100);
                        }else{
                        block.GetComponent<Image>().color = new Color32(0,0,0,100);
                        }
                             block.name = y.ToString();
                 }

           }





          if(x == 60)
           { 
             
                 for(int y=60; y > 50; y--){
                    var block = Instantiate(Block, new Vector3(0, 0, 0), Quaternion.identity);
                    var txtBlock =  Instantiate(blockText, new Vector3(0, 0, 0), Quaternion.identity);
                    block.transform.parent = parent.transform;
                    txtBlock.transform.parent = block.transform;
                    txtBlock.text = y.ToString();
                      if(y%2 == 0){
                           block.GetComponent<Image>().color = new Color32(255,255,225,100);
                        }else{
                        block.GetComponent<Image>().color = new Color32(0,0,0,100);
                        }
                             block.name = y.ToString();
                 }
           }



           if(x == 70)
           {
                for(int y=61; y <= 70; y++){
                    var block = Instantiate(Block, new Vector3(0, 0, 0), Quaternion.identity);
                    var txtBlock =  Instantiate(blockText, new Vector3(0, 0, 0), Quaternion.identity);
                    block.transform.parent = parent.transform;
                    txtBlock.transform.parent = block.transform;
                    txtBlock.text = y.ToString();
                      if(y%2 == 0){
                           block.GetComponent<Image>().color = new Color32(255,255,225,100);
                        }else{
                        block.GetComponent<Image>().color = new Color32(0,0,0,100);
                        }
                             block.name = y.ToString();
                 }

           }

            if(x == 80)
           {
                for(int y=80; y > 70; y--){
                    var block = Instantiate(Block, new Vector3(0, 0, 0), Quaternion.identity);
                    var txtBlock =  Instantiate(blockText, new Vector3(0, 0, 0), Quaternion.identity);
                    block.transform.parent = parent.transform;
                    txtBlock.transform.parent = block.transform;
                    txtBlock.text = y.ToString();
                      if(y%2 == 0){
                           block.GetComponent<Image>().color = new Color32(255,255,225,100);
                        }else{
                        block.GetComponent<Image>().color = new Color32(0,0,0,100);
                        }
                             block.name = y.ToString();
                 }
            }

            if(x == 90)
           {
               for(int y=81; y <= 90; y++){
                    var block = Instantiate(Block, new Vector3(0, 0, 0), Quaternion.identity);
                    var txtBlock =  Instantiate(blockText, new Vector3(0, 0, 0), Quaternion.identity);
                    block.transform.parent = parent.transform;
                    txtBlock.transform.parent = block.transform;
                    txtBlock.text = y.ToString();
                      if(y%2 == 0){
                           block.GetComponent<Image>().color = new Color32(255,255,225,100);
                        }else{
                        block.GetComponent<Image>().color = new Color32(0,0,0,100);
                        }
                             block.name = y.ToString();
                 }

           }

           if(x == 100)
           {
                for(int y=100; y > 90; y--){
                    var block = Instantiate(Block, new Vector3(0, 0, 0), Quaternion.identity);
                    var txtBlock =  Instantiate(blockText, new Vector3(0, 0, 0), Quaternion.identity);
                    block.transform.parent = parent.transform;
                    txtBlock.transform.parent = block.transform;
                    txtBlock.text = y.ToString();
                      if(y%2 == 0){
                           block.GetComponent<Image>().color = new Color32(255,255,225,100);
                        }else{
                        block.GetComponent<Image>().color = new Color32(0,0,0,100);
                        }
                             block.name = y.ToString();
                 }
            }

            


         
         //  blockTex.text = count.ToString();
          
          
      }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
