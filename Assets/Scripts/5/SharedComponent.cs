using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class SharedComponent : MonoBehaviour, IConvertGameObjectToEntity
{
    public GameObject cub;

    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        //dstManager.AddSharedComponentData(entity, new SharedCompoentData1() { data = 1});
    }

    //// Start is called before the first frame update
    //void Start()
    //{
    //    GameObjectConversionSettings settings = GameObjectConversionSettings.FromWorld(World.DefaultGameObjectInjectionWorld, null);
    //    Entity tempCubPrefab = GameObjectConversionUtility.ConvertGameObjectHierarchy(cub, settings);

    //    World.DefaultGameObjectInjectionWorld.EntityManager.AddSharedComponentData<SharedCompoentData1>(tempCubPrefab, new SharedCompoentData1() { data = 1 });
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
