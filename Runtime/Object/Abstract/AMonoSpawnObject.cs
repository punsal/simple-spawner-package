using Spawner.Runtime.Object.Args.Interface;
using Spawner.Runtime.Object.Interface;
using UnityEngine;

namespace Spawner.Runtime.Object.Abstract
{
    public abstract class AMonoSpawnObject : MonoBehaviour, ISpawnObject
    {
        public abstract void OnSpawn(ISpawnObjectArgs args);

        public void SetParent(Transform parent)
        {
            transform.SetParent(parent);
        }

        public void SetPosition(Vector3 position)
        {
            transform.position = position;
        }

        public void SetRotation(Quaternion rotation)
        {
            transform.rotation = rotation;
        }
    }
}