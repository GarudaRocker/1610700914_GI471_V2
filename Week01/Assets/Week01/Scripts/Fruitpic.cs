using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Fruitpic : MonoBehaviour
{
    public Sprite apple, orange, carrot, strawberry, banana;
  
    public void Update()
    {      
        if (Input.GetKeyDown(KeyCode.Return))
        {         
            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == strawberry)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = banana;
                this.gameObject.GetComponent<Image>().sprite = banana;
            }
            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == carrot)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = strawberry;
                this.gameObject.GetComponent<Image>().sprite = strawberry;
            }
            else if(this.gameObject.GetComponent<SpriteRenderer>().sprite == orange)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = carrot;
                this.gameObject.GetComponent<Image>().sprite = carrot;
            }
            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == apple)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = orange;
                this.gameObject.GetComponent<Image>().sprite = orange;
            }
            
            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == null)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = apple;
                this.gameObject.GetComponent<Image>().sprite = apple;

            }
        }
    }
}
