using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_pawner : MonoBehaviour
{
    [SerializeField] public GameObject saloScore;
    public GameObject pipe;

    public float maxTime = 1;
    private float timer = 0;
    public float height;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        GameObject salo = Instantiate(saloScore);
        Destroy(salo, 1);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            GameObject salo = Instantiate(saloScore);
            salo.name = "SALO";
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            salo.transform.position = transform.position + new Vector3(this.gameObject.transform.position.x + Random.Range(0f, 2.5f), Random.Range(3f,-2.5f), - 0.01f);
            Destroy(salo, 2);
            salo.transform.Translate(new Vector2(-1,0));
            Destroy(newpipe, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    
}
