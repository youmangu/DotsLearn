using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Jobs;
using Unity.Transforms;
using UnityEngine;

public class JobSystem : JobComponentSystem
{
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        JobHandle jobHandle = Entities.ForEach((ref RotationEulerXYZ rotation) =>
        {
            rotation.Value = new Unity.Mathematics.float3(0, 45, 0);
        }).WithBurst().Schedule(inputDeps);

        return jobHandle;
    }
}
