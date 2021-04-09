using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;


    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");

    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージ受けた");
        this.hp -= damage;
    }

    public void Magic()
    {
        
        
        if (this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);

        }
        else
        { 
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    
    }

}



public class Test : MonoBehaviour
{
    
    

    void Start ()
    {
        int[] points = {10, 40, 50, 70, 100};
        for (int i = 0; i < points.Length; i++)
        {
            Debug.Log(points[i]);
        }

        for (int i = 1; i <= points.Length; i++)
        {
            int j = points.Length-i;
            Debug.Log(points[j]);
        }

        Boss lastboss = new Boss();
        lastboss.Attack();
        lastboss.Defence(3);
        for (int i = 1; i <= 11; i++)
        {
            lastboss.Magic();
        }
        


    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}