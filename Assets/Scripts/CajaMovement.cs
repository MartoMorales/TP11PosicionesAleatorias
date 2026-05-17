using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    [SerializeField] private Tiempo Tiempo;

    public float Velocidad = 1f;
    public Vector3[] Posiciones = new Vector3[]
    {
        new Vector3(-11.83f, 8.71f, 0f),
        new Vector3(-13.83f, 8.71f, 0f),
        new Vector3(-9.83f, 8.71f, 0f)
    };
    private Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Tiempo.estaCorriendo == true)
        {
            rigid.MovePosition(rigid.position + Vector3.down * Velocidad * Time.fixedDeltaTime);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Colisionó con: " + col.gameObject.name + " | Tag: " + col.gameObject.tag);

        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(col.gameObject);
            Tiempo.Perder();
        }
        else if (col.gameObject.CompareTag("Floor"))
        {
            Reposicionar();
            Velocidad++;
        }
    }

    void Reposicionar()
    {
        int index = Random.Range(0, Posiciones.Length);
        rigid.velocity = Vector3.zero;
        rigid.angularVelocity = Vector3.zero;
        transform.position = Posiciones[index];
    }
}