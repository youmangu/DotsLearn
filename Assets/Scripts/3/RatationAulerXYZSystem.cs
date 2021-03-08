using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

public class RatationAulerXYZSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref RotationEulerXYZ rotationEuler) => {
            rotationEuler.Value = new Unity.Mathematics.float3(0, 45, 0);
        }); 
    }

}
