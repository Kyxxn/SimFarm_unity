using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldSave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "Gold : " + Score.score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
