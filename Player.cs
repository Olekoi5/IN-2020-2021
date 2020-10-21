using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameManager gm;
    public Text name;
    public int points;
    public List<Card> Cards = new List<Card>();
    public int rate;
    public Image[] Slots = new Image[7]; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
