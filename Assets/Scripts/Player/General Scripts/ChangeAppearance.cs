using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeAppearance : MonoBehaviour
{
    public Sprite[] sprites;
    public bool isInfected = false;
    public Image image;
    public float amount = 0;

    int ChangedCount =0;
    // Start is called before the first frame update
    void Start() {
        isInfected = false;
        amount = 0;
    }
    void Update() {
        image.rectTransform.sizeDelta = new Vector2(amount,20);
        
        if(isInfected == false) {
            if(amount < 100f)
                amount += 0.1f;
        } else
        {
            if (amount >= 0)
                amount-=0.2f;
        }

        if (Input.GetKeyDown(KeyCode.P) && isInfected == false) {
            if(ChangedCount == 0 && amount >= 100 || ChangedCount > 0) {
                GetComponent<SpriteRenderer>().sprite = sprites[1];
                isInfected = true;
                GetComponent<Attack>().enabled = true;
            }
        } else if (amount <= 0 && isInfected == true || Input.GetKeyDown(KeyCode.P)) {
            GetComponent<SpriteRenderer>().sprite = sprites[0];
            isInfected = false;
            GetComponent<Attack>().enabled = false;
        }
    }
}