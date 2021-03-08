using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

[DisableAutoCreation]
public class TanslationComponent : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref Translation translation) => {
            translation.Value = new Unity.Mathematics.float3(1, 1, 1);
        }); 
    }

}
