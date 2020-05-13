using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bosshp : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject boss;
    public Image r;
    public GameObject bossstuff;

    void Start()
    {
        r.rectTransform.sizeDelta = new Vector2(boss.GetComponent<Health>().health, 25);
        GetComponent<Image>().rectTransform.sizeDelta = new Vector2(boss.GetComponent<Health>().health, 25);
        GetComponent<Image>().rectTransform.localPosition = new Vector2(GetComponent<Image>().rectTransform.localPosition.x - GetComponent<Image>().rectTransform.sizeDelta.x / 2, GetComponent<Image>().rectTransform.localPosition.y);
        r.rectTransform.localPosition = new Vector2(r.rectTransform.localPosition.x - r.rectTransform.sizeDelta.x / 2, r.rectTransform.localPosition.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (boss != null)
        {
            GetComponent<Image>().rectTransform.sizeDelta = new Vector2(boss.GetComponent<Health>().health, 25);
        }
        else
        {
            Destroy(bossstuff);
        }
    }
}
