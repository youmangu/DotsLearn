using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class PrintDataSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref PrinDataCompnet printdata) =>
        {
            Debug.Log(printdata.mPrintData);
        });

    }
}
