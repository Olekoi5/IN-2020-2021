using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<Card> Waist = new List<Card>();
    public Player[] Players = new Player[3];
    public Constraint c;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int k = 24;
        int s = 0;
        while (k > 0)
        {
            int i = Random.Range(0, k);
            GiveCard(Players[0].Cards, i);
            ChangePosition(Waist[i], Players[0].Slots[s]);
            k--;
            i = Random.Range(0, k);
            GiveCard(Players[1].Cards, i);
            ChangePosition(Waist[i], Players[1].Slots[s]);
            k--;
            if (c.constraint.Count <= 3)
            {
                i = Random.Range(0, k);
                GiveCard(c.constraint, i);
                ChangePosition(Waist[i], c.Slots[s]);
                k--;
            }
            i = Random.Range(0, k);
            GiveCard(Players[2].Cards, i);
            ChangePosition(Waist[i], Players[2].Slots[s]);
            k--;
            s++;
        }
    }

    private void GiveCard(List<Card> p, int i)
    {
        p.Add(Waist[i]);
        Waist.RemoveAt(i);
    }
    private void ChangePosition(Card w, Image s)
    {
        float x = s.transform.position.x - w.transform.position.x;
        float y = s.transform.position.y - w.transform.position.y;
        float z = s.transform.position.z - w.transform.position.z;
        w.transform.Translate(x, y, z);
    }
}
