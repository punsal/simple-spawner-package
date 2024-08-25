using Spawner.Runtime.Object.Args.Interface;
using UnityEngine;

namespace Spawner.Runtime.Args.Interface
{
    /// <summary>
    /// Basic spawn arguments for ISpawnableArgs types
    /// </summary>
    /// <seealso cref="ISpawnObjectArgs"/>
    public interface ISpawnArgs
    {
        bool TryGetParent(out Transform result);
        Vector3 GetPosition();
        Quaternion GetRotation();
    }
}