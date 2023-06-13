using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UnitsManager : MonoBehaviour
{
    public static UnitsManager Instance;
    [SerializeField]
    private List<ScriptableUnit> units;

    void Awake()
    {
        Instance = this;

        //units = Resources.LoadAll<ScriptableUnit>("Units").ToList();
        //print(units.Count);
    }

    public void SpawnHeroes()
    {
        var HeroCount = 1;
        for (int i = 0; i < HeroCount; i++)
        {
            var randomPrefab = GetRandomUnit<BaseHero>(Faction.Hero);
            var spawnedHero = Instantiate(randomPrefab);
            var randomSpawnTile = GridManager.Instance.GetHeroSpawnTile();

            randomSpawnTile.SetUnit(spawnedHero);
        }
    }

    private T GetRandomUnit<T>(Faction faction) where T : BaseUnit
    {
        return (T)units.Where(u => u.Faction == faction).OrderBy(o => Random.value).First().UnitPrefab;
    }
}
        //foreach(ScriptableUnit unit in units)
        //{
            //print($"faction {unit.Faction}"); опнькне
            //if (unit.Faction == faction)
            //{
                //return (T) unit.UnitPrefab;
            //}
        //}
        //return null;
    //}
//}
