using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float canoSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CanoMove();
    }

    void CanoMove()
    {
        transform.position += Vector3.left * canoSpeed * Time.deltaTime;
    }
}
