using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickerControll : MonoBehaviour
{
    public int money = 0;
    [SerializeField] TMP_Text label;

    public void clicker1()
    {
        money++;
        label.text = "$" + money;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
