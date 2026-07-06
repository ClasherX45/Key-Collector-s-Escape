using UnityEngine;

public class DropItem : MonoBehaviour
{
    public GameObject drop;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        Instantiate(drop, transform.position, drop.transform.rotation);
    }
}
