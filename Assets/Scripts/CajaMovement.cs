using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CajaMovement : MonoBehaviour
{

        public float Velocidad = 0f ;
        public Vector3[] Posiciones = new Vector3[]
        {
            new Vector3 (0f, 8.71f, 0f),
            new Vector3 (-2f, 8.71f, 0f),
            new Vector3 (2f, 8.71f, 0f)
        };
        private Rigidbody rigid;

      
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -Velocidad * Time.deltaTime, 0);

      
    }
    
   void OnCollisionEnter(Collision col){
        if(col.gameObject.CompareTag("Player"))
        {
            Destroy(col.gameObject);
        }else 
        if (col.gameObject.CompareTag("Floor"))
        {
          Reposicionar();
          Velocidad++;
        }
        }
    void Reposicionar(){
        int index = Random.Range(0, Posiciones.Length);

      rigid.velocity = Vector3.zero;
      rigid.angularVelocity = Vector3.zero;

        transform.position = Posiciones[index];  
    }

    
}
