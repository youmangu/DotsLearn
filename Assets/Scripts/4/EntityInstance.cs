using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;

public class EntityInstance : MonoBehaviour
{
    public GameObject cub;

    public int interval = 2;
    public int sum = 100;
    // Start is called before the first frame update
    void Start()
    {
        GameObjectConversionSettings settings = GameObjectConversionSettings.FromWorld(World.DefaultGameObjectInjectionWorld, null);
        Entity tempCubPrefab = GameObjectConversionUtility.ConvertGameObjectHierarchy(cub, settings);

        EntityManager manager = World.DefaultGameObjectInjectionWorld.EntityManager;
        Translation translation = new Translation();
        translation.Value.x = -interval;
        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                Entity tempCub = manager.Instantiate(tempCubPrefab);

                // Translation 是值类型，不能通过修改此方法来修改位置
                //Translation translation = manager.GetComponentObject<Translation>(tempCub);
                //translation.Value.x += 1;

                translation.Value.x += interval;
                manager.SetComponentData(tempCub, translation);

            }

            translation.Value.x = -interval;
            translation.Value.y += interval;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
