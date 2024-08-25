using Spawner.Runtime.Args.Abstract;
using Spawner.Runtime.Interface;
using Spawner.Runtime.Object.Abstract;
using Spawner.Runtime.Object.Args.Abstract;
using UnityEngine;

namespace Spawner.Runtime.Abstract
{
    public abstract class AMonoSpawner : MonoBehaviour, ISpawn<AMonoSpawnObject, ASpawnObjectArgs, ASpawnArgs>
    {
        [SerializeField] private AMonoSpawnObject prefab;

        protected AMonoSpawnObject GetPrefab()
        {
            if (prefab == null)
            {
                throw new MissingReferenceException($"{name} has a missing {nameof(prefab)} reference.");
            }

            return prefab;
        }
        
        public AMonoSpawnObject Spawn(ASpawnArgs spawnArgs, ASpawnObjectArgs objectArgs)
        {
            var obj = Instantiate(prefab);
            if (spawnArgs.TryGetParent(out var parent))
            {
                obj.SetParent(parent);
            }
            obj.SetPosition(spawnArgs.GetPosition());
            obj.SetRotation(spawnArgs.GetRotation());
            obj.OnSpawn(objectArgs);
            return obj;
        }
    }
}