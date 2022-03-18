using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{

    protected override void Start()
    {
        base.Start();
        jumpforce *= 2; 

    }


    // protected override void Update()
    // {
    //     base.Update();

    // }

}
