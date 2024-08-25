using Spawner.Runtime.Args.Abstract;
using UnityEngine;

namespace Spawner.Runtime.Args
{
    /// <summary>
    /// Default spawn arguments for any spawned GameObject
    /// </summary>
    public class SpawnArgs : ASpawnArgs
    {
        public SpawnArgs(Transform parent, Vector3 position, Quaternion rotation) : base(parent, position, rotation)
        {
            // Empty
        }
    }
}