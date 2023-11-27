using UnityEngine;

[System.Serializable]
public class Carga {
    public string Name;

    public GameObject Prefab;
    [Range (0f, 100f)]public float Chance =100f;

    [HideInInspector] public double _weight;
}
public class Spawner : MonoBehaviour{    
    [SerializeField] private Carga[] cargas;

    private double accumulatedWeights;
    private System.Random rand = new System.Random();


    private void Awake(){
        CalculateWeights();
    }

    private void Start(){
        for (int i = 0; i < 100; i++){
            SpawnRandom(new Vector2(Random.Range(-1f, 7f), Random.Range(-3f, 3f))); //
        }
    }

    private void SpawnRandom (Vector2 position){

        Carga randomCarga = cargas[GetRandomCargaIndex()];
        Instantiate(randomCarga.Prefab, position, Quaternion.identity, transform);

    }

    private int GetRandomCargaIndex(){
        double r = rand.NextDouble() * accumulatedWeights;
        for (int i = 0; i < cargas.Length; i++){
            if (cargas[i]._weight >= r)
                return i;
        }
        return 0;
    }

    private void CalculateWeights(){
        accumulatedWeights = 0f;
        foreach (Carga carga in cargas){
            accumulatedWeights += carga.Chance;
            carga._weight = accumulatedWeights;

        }

    }
}