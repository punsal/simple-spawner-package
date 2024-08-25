using Spawner.Runtime.Args.Interface;
using UnityEngine;

namespace Spawner.Runtime.Args.Abstract
{
    /// <summary>
    /// An abstract spawn arguments class for any spawned GameObject
    /// </summary>
    public abstract class ASpawnArgs : ISpawnArgs
    {
        private readonly Transform _parent;
        private readonly Vector3 _position;
        private readonly Quaternion _rotation;

        protected ASpawnArgs(Transform parent, Vector3 position, Quaternion rotation)
        {
            _parent = parent;
            _position = position;
            _rotation = rotation;
        }

        public bool TryGetParent(out Transform result)
        {
            result = null;
            if (_parent == null)
            {
                return false;
            }

            result = _parent;
            return true;
        }

        public Vector3 GetPosition()
        {
            return _position;
        }

        public Quaternion GetRotation()
        {
            return _rotation;
        }
    }
}