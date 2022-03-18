using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{

    protected override void Start()
    {
        base.Start();
        speed *= 2; 

    }


    // protected override void Update()
    // {
    //     base.Update();

    // }

}
