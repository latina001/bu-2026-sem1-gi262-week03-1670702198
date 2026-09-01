using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

// OOPWall aka "Demon Wall"
public class OOPWall : Identity
{
    public int Damage;
    public bool IslceWall;

    public void Start()
    {
        
    }
    public override void Hit()
    {
        mapGenerator.player.TakeDamage(Damage);
        Destroy(gameObject);
        mapGenerator.mapdata[positionX, positionY] = mapGenerator.empty;

    }
}