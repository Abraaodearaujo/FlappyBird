using UnityEngine;

public class CanoInf : MonoBehaviour
{
    public float maxTime;
    private float time;
    public GameObject cano;
    GameObject canoClone;
    public float dist;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CanoSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        if(time > maxTime)
        {
            CanoSpawner();
            time = 0;
        }

        time += Time.deltaTime;
    }

    void CanoSpawner()
    {
        canoClone = Instantiate(cano);
        canoClone.transform.position = transform.position + new Vector3(0,Random.Range(dist, -dist), 0);
    }
}
