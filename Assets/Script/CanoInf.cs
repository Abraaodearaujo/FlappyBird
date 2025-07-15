using UnityEngine;

public class CanoInf : MonoBehaviour
{
    public float maxTime;
    private float time;

    public GameObject cano; 
    GameObject canoClone;

    [Header("Configuração do Espaço entre Canos")]
    [Range(1f, 6f)]
    public float gap = 3f; 
    void Start()
    {
        CanoSpawner();
    }

    void Update()
    {
        if (time > maxTime)
        {
            CanoSpawner();
            time = 0;
        }

        time += Time.deltaTime;
    }

    void CanoSpawner()
    {
        
        canoClone = Instantiate(cano);

        
        float yOffset = Random.Range(-gap, gap);

        
        canoClone.transform.position = transform.position + new Vector3(0, yOffset, 0);
    }
}
