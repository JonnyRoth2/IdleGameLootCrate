using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    public int curHP;

    public int maxHP;

    public int moneyGiven;

    public Image healthbarfill;

    public void Damage(){
        curHP--;
        healthbarfill.fillAmount=(float)curHP/(float)maxHP;

        if(curHP <=0){
            Dead();
        }
    }
    public void Dead(){
        
    }


}
