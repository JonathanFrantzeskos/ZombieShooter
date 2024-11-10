using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
     public static float Score=0f;
    public TMP_Text Scoretext;

    // Start is called before the first frame update
    void Start()
    {
        //Scoretext.text = "";
        Scoretext = GetComponent<TMP_Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Scoretext.text = "Score: "+ Score;
    }


}
