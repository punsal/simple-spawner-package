using Spawner.Runtime.Object.Args.Interface;
using UnityEngine;

namespace Spawner.Runtime.Object.Interface
{
    public interface ISpawnObject
    {
        void OnSpawn(ISpawnObjectArgs args);
        void SetParent(Transform parent);
        void SetPosition(Vector3 position);
        void SetRotation(Quaternion rotation);
    }
}