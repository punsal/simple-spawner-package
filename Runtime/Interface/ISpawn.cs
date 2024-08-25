using Spawner.Runtime.Args.Interface;
using Spawner.Runtime.Object.Args.Interface;
using Spawner.Runtime.Object.Interface;

namespace Spawner.Runtime.Interface
{
    public interface ISpawn<out TSpawnObject, in TSpawnObjectArgs, in TSpawnArgs> 
        where TSpawnObject : ISpawnObject 
        where TSpawnObjectArgs : ISpawnObjectArgs 
        where TSpawnArgs: ISpawnArgs
    { 
        TSpawnObject Spawn(TSpawnArgs spawnArgs, TSpawnObjectArgs objectArgs);
    }
}