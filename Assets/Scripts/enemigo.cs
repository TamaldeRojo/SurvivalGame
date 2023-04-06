using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    [SerializeField] private float health = 100f;


    public void recibirDmg(float dmg){
        this.health = this.health - dmg;
        
    }
}
