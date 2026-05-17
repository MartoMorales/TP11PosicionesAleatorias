using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Tiempo tiempo;
    public int Mov = 0;

    void Update()
    {
        if (tiempo.estaCorriendo == true)
        {
            if (Mov < 1 && Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Translate(-2, 0, 0);
                Mov++;
            }
            if (Mov > -1 && Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Translate(2, 0, 0);
                Mov--;
            }
            if (Mov == 1 && Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Translate(0, 0, 0);
            }
            if (Mov == -1 && Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Translate(0, 0, 0);
            }
            else if (tiempo.estaCorriendo == false)
            {
                transform.Translate(0, 0, 0);
            }
        }
    }
}