using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tiempo : MonoBehaviour
{
    [SerializeField] private PlayerController PlayerController;
    [SerializeField] private CajaMovement CajaMovement;

    public TextMeshProUGUI TextoCronometro;
    public TextMeshProUGUI Perdiste;
    private float tiempoTranscurrido = 0;
    public bool estaCorriendo = false;
    [SerializeField] private Button botonEmpezar;

    void Start()
    {
        Perdiste.gameObject.SetActive(false);
        botonEmpezar.onClick.AddListener(Empezar);
    }

    void Update()
    {
        if (estaCorriendo == true)
        {
            tiempoTranscurrido += Time.deltaTime;
            Cronometro();
        }
    }

    void Cronometro()
    {
        TextoCronometro.text = "Tiempo: " + tiempoTranscurrido.ToString("f2");
    }

    public void Perder()
    {
        Perdiste.gameObject.SetActive(true);
        estaCorriendo = false;
        PlayerController.Mov = 3;
    }

    public void Empezar()
    {
        Perdiste.gameObject.SetActive(false);
        estaCorriendo = true;
        PlayerController.Mov = 0;
        tiempoTranscurrido = 0;
        botonEmpezar.gameObject.SetActive(false);
        Debug.Log(estaCorriendo);
        Debug.Log(PlayerController.Mov);
    }
}