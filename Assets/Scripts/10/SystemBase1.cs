using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

public class SystemBase1 : SystemBase
{
    EntityQuery q;
    protected override void OnCreate()
    {
        Debug.Log("OnCreate");
    }

    protected override void OnStartRunning()
    {
        Debug.Log("OnStartRunning");
    }

    protected override void OnStopRunning()
    {
        Debug.Log("OnStopRunning");
    }

    protected override void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }

    protected override void OnUpdate()
    {
        Debug.Log("OnUpdate");
        Entities.ForEach((ref Translation t, ref PrinDataCompnet printdatap) =>
        {
            Debug.Log("======================== ");
        })
        //.WithChangeFilter<PrinDataCompnet>()
        .WithStoreEntityQueryInField(ref q)
        .WithEntityQueryOptions(EntityQueryOptions.Default)
        .Run();

        NativeArray<Entity> array = q.ToEntityArray(Allocator.TempJob);
        foreach (var e in array)
        {
            Debug.Log(EntityManager.GetName(e));
        }
    }


}
