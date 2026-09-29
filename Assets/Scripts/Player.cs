using UnityEngine;

public class Player : MonoBehaviour
{
    //can check Unity documentation for exact runtime function execution order


    //variables
    [SerializeField] private int _num; //still shows up in Unity editor
    public float exactNum;
    public bool boo;

    public GameObject obj; //unity objects in hierarchy
    //private class GameManager gm; //calling another c# script
    [SerializeField] private Light litty;
    [SerializeField] private Light littyLight;
    private Material mesh;


    //called before start
    private void Awake()
    {
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mesh = GetComponent<Renderer>().material;

        print(_num);

        litty = GetComponent<Light>(); //gets component on the object itself
        littyLight = obj.GetComponent<Light>();
    }
    
    //not as light-weight as Update, but runs at fixed time by runtime, same across computers
    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame, depends on computer & gpu
    void Update()
    {
        print(_num + ".");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _num += 1;

            float red = Random.Range(0, 225);
            float green = Random.Range(0, 225);
            float blue = Random.Range(0, 225);
            Color randColor = new Color(red, green, blue);
            mesh.color = randColor;
        }
                
    }

    private void OnTriggerEnter(Collider other)
    {
        float red = Random.Range(0, 225);
        float green = Random.Range(0, 225);
        float blue = Random.Range(0, 225);
        Color randColor = new Color(red, green, blue);
        mesh.color = randColor;
    }
}
