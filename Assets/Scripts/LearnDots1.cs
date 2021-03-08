using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class LearnDots1 : MonoBehaviour, IConvertGameObjectToEntity
{
    public float printData;
    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        dstManager.AddComponentData(entity, new PrinDataCompnet() { mPrintData = printData });
    }
}
