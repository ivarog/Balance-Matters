using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextContract : MonoBehaviour
{

    [SerializeField] 
    Text letterText;

    [SerializeField]
    Text añoText;

    [SerializeField]
    GameObject si;

    [SerializeField]
    GameObject no;

    [SerializeField]
    GameObject firma;

    [SerializeField] GameObject humoFabrica;
    [SerializeField] GameObject vaporAgua;
    [SerializeField] GameObject humoFabrica2;
    [SerializeField] GameObject vaporAgua2;

    [SerializeField] GameObject sign;
    [SerializeField] Text signText;

    int contractLength;
    int actualContract = 0;
    int año = 1970;

    private void Start()
    {
        contractLength = GameMaster.todosLosContratos.Count;
        si.SetActive(false);
        no.SetActive(false);
        firma.SetActive(true);
        letterText.text = "Saludos Señor@ " + PlayerData.playerName + ":" +
            "\n\n¡Felicidades! Ahora usted es el gobernante de éste modesto pueblo." +
            "\nUsted tendrá que tomar las mejores decisiones para el desarrollo de la ciudad; ¡pero tenga cuidado! Existen 4 indicadores que deben permanecer siempre en armonía." +
            "\nSi pierde el balance y desaparece una de ellas, será destituido del cargo. " +
            "\n\n¡Buena suerte " + PlayerData.playerName + "!\n\n" +
            "\n" +
            "\n" +
            "\n";
    }

    //Aquí irá tu algoritmo perrón
    public void SelectNextContract()
    {
        // //Por ahora lo hace de manera desequilibrada para pruebas
        if (GameMaster.derrota && actualContract < contractLength)
        {
            si.SetActive(false);
            no.SetActive(false);
            firma.SetActive(true);
            firma.transform.Find("Panel").gameObject.SetActive(false);
            letterText.text = "Estimado Señor@ " + PlayerData.playerName + ":" +
                "\n\nSus intenciones fueron buenas pero no logró mantener el equilibrio, por lo cual será removido de su cargo." +
                "\n\nPero no se preocupe, tal vez pueda volver a gobernar en el futuro, cuando las cosas por aquí se calmen... Espero que para la próxima tome mejores decisiones." +
                "\n\nPor favor coloque su firma de renuncia abajo.";
        }
        else if (!GameMaster.derrota && actualContract < contractLength)
        {
            letterText.text = GameMaster.todosLosContratos[actualContract].textoContrato;
        }
        else
        {
            //Debug.Log("Ganaste!");
            si.SetActive(false);
            no.SetActive(false);
            firma.SetActive(true);
            firma.transform.Find("Panel").gameObject.SetActive(false);
            letterText.text = "Querid@ Señor@ " + PlayerData.playerName + ":" +
                "\n\n¡El pueblo alaba sus esfuerzos! Pese a todo, ha logrado mantener el equilibrio todos estos años." +
                "\n\nLa nación lo considera un modelo a elegir; sería muy egoísta de nuestra parte retenerlo aquí cuando podría hacer un bien mayor y es por eso que a partir de ahora será promovido." +
                "\n\nFirme debajo y éxito en su nuevo proyecto. ¡Lo echaremos de menos!";
        }
    }

    public void Firma()
    {
        StartCoroutine(_Firma());
        AudioManager.instance.Play("Write");    
    }

    public IEnumerator _Firma()
    {
        yield return new WaitForSeconds(2.0f);
        if (GameMaster.derrota)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
        }
        else if (actualContract == contractLength)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
        }
        else
        {
            SelectNextContract();
            si.SetActive(true);
            no.SetActive(true);
            firma.SetActive(false);
        }
    }

    public void YesDecision()
    {
        FindObjectOfType<PieGraph>().RecalculateGraph( GameMaster.todosLosContratos[actualContract].consecuenciasSi);
        TileToChange();
        sign.SetActive(true);
        signText.text = GameMaster.todosLosContratos[actualContract].textoDescriptivoSi;
        actualContract++;
        año++;
        añoText.text = año.ToString();
        AudioManager.instance.Play("Write");
    }

    public void NoDecision()
    {
        FindObjectOfType<PieGraph>().RecalculateGraph( GameMaster.todosLosContratos[actualContract].consecuenciasNo);
        sign.SetActive(true);
        signText.text = GameMaster.todosLosContratos[actualContract].textoDescriptivoNo;
        actualContract++;
        año++;
        añoText.text = año.ToString();
        AudioManager.instance.Play("Write");
    }

    public void TileToChange()
    {
        Debug.Log("Id"+GameMaster.todosLosContratos[actualContract].id);
        
        if(GameMaster.todosLosContratos[actualContract].id == 6 && GameMaster.todosLosContratos[actualContract].pasado)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Tree_E_1");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Tree_E_2");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Tree_E_3");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Tree_E_4");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 6 && GameMaster.todosLosContratos[actualContract].presente)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Tree_E_5");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Tree_E_6");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Tree_E_7");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Tree_E_8");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 6 && GameMaster.todosLosContratos[actualContract].futuro)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Tree_E_9");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Tree_E_10");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Tree_E_11");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Tree_E_12");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 10 && GameMaster.todosLosContratos[actualContract].presente)
        {
            FindObjectOfType<SetTileOnMap>().DeleteTile(new Vector3(3,1,0));
            FindObjectOfType<SetTileOnMap>().DeleteTile(new Vector3(4,-2,0));
            FindObjectOfType<SetTileOnMap>().DeleteTile(new Vector3(6,-5,0));
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 10 && GameMaster.todosLosContratos[actualContract].futuro)
        {
            FindObjectOfType<SetTileOnMap>().DeleteTile(new Vector3(3,-8,0));
            FindObjectOfType<SetTileOnMap>().DeleteTile(new Vector3(11,1,0));
            FindObjectOfType<SetTileOnMap>().DeleteTile(new Vector3(12,-5,0));
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 11 && GameMaster.todosLosContratos[actualContract].pasado)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("House_B_1");
            FindObjectOfType<SetTileOnMap>().ActivateTile("House_B_2");
            FindObjectOfType<SetTileOnMap>().ActivateTile("House_B_3");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 11 && GameMaster.todosLosContratos[actualContract].presente)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("House_B_4");
            FindObjectOfType<SetTileOnMap>().ActivateTile("House_B_5");
            FindObjectOfType<SetTileOnMap>().ActivateTile("House_B_6");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 12 && GameMaster.todosLosContratos[actualContract].pasado)
        {
            FindObjectOfType<SetTileOnMap>().DeleteTile(new Vector3(2,-1,0));
            FindObjectOfType<SetTileOnMap>().DeleteTile(new Vector3(3,-4,0));
            FindObjectOfType<SetTileOnMap>().DeleteTile(new Vector3(5,-5,0));
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 12 && GameMaster.todosLosContratos[actualContract].presente)
        {
            FindObjectOfType<SetTileOnMap>().DeleteTile(new Vector3(10,-2,0));
            FindObjectOfType<SetTileOnMap>().DeleteTile(new Vector3(10,1,0));
            FindObjectOfType<SetTileOnMap>().DeleteTile(new Vector3(13,-1,0));
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 13 && GameMaster.todosLosContratos[actualContract].pasado)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Fabrica_A_1");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Fabrica_A_2");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 13 && GameMaster.todosLosContratos[actualContract].presente)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Fabrica_A_3");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Fabrica_A_4");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 14 && GameMaster.todosLosContratos[actualContract].pasado)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Farm_A_1");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Cow_A_1");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 14 && GameMaster.todosLosContratos[actualContract].presente)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Farm_A_2");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Cheep_A_1");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 14 && GameMaster.todosLosContratos[actualContract].futuro)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Farm_A_3");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Chiken_A_1");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 18 && GameMaster.todosLosContratos[actualContract].pasado)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Fabrica_B_1");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Fabrica_B_2");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 18 && GameMaster.todosLosContratos[actualContract].presente)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Fabrica_B_3");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Fabrica_B_4");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 19 && GameMaster.todosLosContratos[actualContract].pasado)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Carrots_A_1");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Carrots_A_2");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 19 && GameMaster.todosLosContratos[actualContract].presente)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Carrots_A_3");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Carrots_A_4");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 20 && GameMaster.todosLosContratos[actualContract].pasado)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Fabrica_A_5");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Fabrica_A_6");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 21 && GameMaster.todosLosContratos[actualContract].presente)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Fabrica_A_7");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Fabrica_A_8");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 21 && GameMaster.todosLosContratos[actualContract].futuro)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Fabrica_B_5");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Fabrica_B_6");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 210 && GameMaster.todosLosContratos[actualContract].presente)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Panel_A_1");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Panel_A_2");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 210 && GameMaster.todosLosContratos[actualContract].futuro)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Panel_A_3");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Panel_A_4");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 23 && GameMaster.todosLosContratos[actualContract].presente)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Nuclear_A_1");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Nuclear_A_2");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 23 && GameMaster.todosLosContratos[actualContract].futuro)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Nuclear_A_3");
            FindObjectOfType<SetTileOnMap>().ActivateTile("Nuclear_A_4");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 25 && GameMaster.todosLosContratos[actualContract].presente)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Air_A_1");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 25 && GameMaster.todosLosContratos[actualContract].futuro)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Air_A_2");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 26 && GameMaster.todosLosContratos[actualContract].pasado)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Club_A_1");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 26 && GameMaster.todosLosContratos[actualContract].presente)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Club_A_2");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 26 && GameMaster.todosLosContratos[actualContract].futuro)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Club_A_3");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 27 && GameMaster.todosLosContratos[actualContract].pasado)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Park_A_1");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 27 && GameMaster.todosLosContratos[actualContract].presente)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Park_A_2");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 27 && GameMaster.todosLosContratos[actualContract].futuro)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Park_A_3");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 28 && GameMaster.todosLosContratos[actualContract].pasado)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Cinema_A_1");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 28 && GameMaster.todosLosContratos[actualContract].presente)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Cinema_A_2");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 28 && GameMaster.todosLosContratos[actualContract].futuro)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Cinema_A_3");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 29 && GameMaster.todosLosContratos[actualContract].pasado)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Hospital_A_1");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 29 && GameMaster.todosLosContratos[actualContract].presente)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Hospital_A_2");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 29 && GameMaster.todosLosContratos[actualContract].futuro)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Hospital_A_3");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 30 && GameMaster.todosLosContratos[actualContract].presente)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Tree_D_1");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 30 && GameMaster.todosLosContratos[actualContract].futuro)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("Tree_D_2");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 32 && GameMaster.todosLosContratos[actualContract].pasado)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("School_A_1");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 32 && GameMaster.todosLosContratos[actualContract].presente)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("School_A_2");
        }
        else if(GameMaster.todosLosContratos[actualContract].id == 32 && GameMaster.todosLosContratos[actualContract].futuro)
        {
            FindObjectOfType<SetTileOnMap>().ActivateTile("School_A_3");
        }
        
    }   

    // void FeedBackYes()
    // {
    //     sign.SetActive(true);
    //     if(GameMaster.todosLosContratos[actualContract].id == 1)
    //     {
    //         signText.text = "¡Muy bien! Ya no necesitamos quemar tanto petróleo para generar la electricidad que necesitamos";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 2)
    //     {
    //         signText.text = "Excelente, nos costará algo pero consumiremos menos energía y se quemarán menos fósiles";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 3)
    //     {
    //         signText.text = "Vaya! ahorraras dinero, pero la cuenta de la compañía de electricidad nos arruinará a todos";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 4)
    //     {
    //          signText.text = "Que bien que preguntaste antes, así la gente parece más feliz aunque vaya que costó. Además el cielo parece más azul.";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 5)
    //     {
    //          signText.text = "Vaya, el cielo parece más limpio y la ciudad tambien.";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 6)
    //     {
    //          signText.text = "Esto nos ayudará a limpiar un poco el cielo, de hecho volvimos a ver las estrellas.Nos cost mucho pero valió la pena";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 7)
    //     {
    //          signText.text = "En nuestra ciudad ya no hay basura, solo residuos y los podremos manejar mejor para que no duren mucho en nuestro planeta";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 8)
    //     {
    //          signText.text = "La gente está muy enojada pero ahora podemos respirar mejor";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 9)
    //     {
    //          signText.text = "La gente parece entender que lo importante es la funcionalidad de las cosas y no que tan bien se ven se me ocurre crear leyes para evitar el fast fashion quitar un poco de basura";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 10)
    //     {
    //          signText.text = "La gente está dejando de comprar nuevas libretas y están usando las hojas blancas que solo usaron por un lado";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 11)
    //     {
    //          signText.text = "";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 12)
    //     {
    //          signText.text = "";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 13)
    //     {
    //          signText.text = "";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 14)
    //     {
    //          signText.text = "";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 15)
    //     {
    //          signText.text = "";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 16)
    //     {
    //          signText.text = "";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 17)
    //     {
    //          signText.text = "";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 18)
    //     {
    //          signText.text = "";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 19)
    //     {
    //          signText.text = "";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 20)
    //     {
    //          signText.text = "Tenemos mucho combustóleo y saldrá rentable el negocio pero este combustible fósil es altamente contaminante";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 21)
    //     {
    //          signText.text = "Vaya este combustible es menos contaminante pero sigue siendo un combustible fósil y si se nos escapa igual es un gas de efecto invernadero";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 210)
    //     {
    //          signText.text = "Aprovechaste muy bien este espacio,cuidarás el medio ambiente pero será más costoso que una planta de combustibles fósiles// que podemos poner la opción de que se remueva gente";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 22)
    //     {
    //          signText.text = "¡Vaya! Eliminaste uno de tus grandes problemas, las emisiones de tus plantas de generación y fábricas, aparte puedes aprovechar el dióxido de carbono para otros procesos,  pero vaya que costaron";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 23)
    //     {
    //          signText.text = "Esta planta genera mucha energía con poco. Favorece el ambiente porque no emite GEI cuando genera electricidad pero la gente tiene mucho miedo. Tal vez deberías decirles que tus científicos trabajan para hacer estas plantas ultra seguras y podría ser una buena opción";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 24)
    //     {
    //          signText.text = "Parece una excelente opción, podemos usar el calor que las plantas de generación no utilizan y así ya no quemamos más combustible para el agua caliente del baño por ejemplo";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 25)
    //     {
    //          signText.text = "¡Excelente! Estas generando electricidad con energías limpias, reduciste tus emisiones, pero cuesta más que una planta generadora que quema combustibles fósiles y no hablaste con las personas que vivían ahí para llegar a un acuerdo";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 26)
    //     {
    //          signText.text = "";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 27)
    //     {
    //          signText.text = "";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 28)
    //     {
    //          signText.text = "";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 29)
    //     {
    //          signText.text = "";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 30)
    //     {
    //          signText.text = "";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 31)
    //     {
    //          signText.text = "";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 32)
    //     {
    //          signText.text = "";   
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 33)
    //     {
    //          signText.text = "";   
    //     }
    // }

    // void FeedBackNo()
    // {
    //     sign.SetActive(true);
    //     if(GameMaster.todosLosContratos[actualContract].id == 1)
    //     {
    //         signText.text = "¡Vaya! ahorraras dinero, que felicidad pero gastaras más combustoleo para generar energía.";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 2)
    //     {
    //         signText.text = "¡Vaya! ahorraras dinero, pero la cuenta de la compañía de electricidad nos arruinará a todos";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 3)
    //     {
    //         signText.text = "¡Vaya! ahorraras dinero, pero la cuenta de la compañía de electricidad nos arruinará a todos, además quemaremos más";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 4)
    //     {
    //         signText.text = "El cielo se ve cada vez más negro, nuestra economía va bien pero  la gente está tan molesta que no tiene animos de nada";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 5)
    //     {
    //         signText.text = "Pronto no habrá espacio para nosotros, la basura está llenando nuestra ciudad y el cielo se ve más negro.";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 6)
    //     {
    //         signText.text = "Cada vez hay menos sitios bonitos a dónde mirar y la ciudad se pone gris";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 7)
    //     {
    //         signText.text = "En nuestra ciudad ya no hay basura, solo residuos y los podremos manejar mejor para que no duren mucho en nuestro planet";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 8)
    //     {
    //         signText.text = "La población esta muy feliz de llevar su auto a la tiendita de la esquina pero esto cada vez esta peor nadie puede respirar";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 9)
    //     {
    //         signText.text = "Todo se ve más negro y hay más basura pero la gente se ve muy feliz con nuevo celular y vaya que estas fábricas nos están dejando dinero";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 10)
    //     {
    //         signText.text = "La gente se ve feliz con sus hojas de un blanco perfecto y de colores inimaginables, las papeleras venden mucho pero todos los proceso necesitan mucha energía que a su vez generan mucha contaminación, aunque en corto plazo nos darán mucho dinero a la larga costará más)//aumentar un poco basura, la temperatura y smoke";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 11)
    //     {
    //         signText.text = "";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 12)
    //     {
    //         signText.text = "";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 13)
    //     {
    //         signText.text = "";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 14)
    //     {
    //         signText.text = "";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 15)
    //     {
    //         signText.text = "";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 16)
    //     {
    //         signText.text = "";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 17)
    //     {
    //         signText.text = "";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 18)
    //     {
    //         signText.text = "";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 19)
    //     {
    //         signText.text = "";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 20)
    //     {
    //         signText.text = "La gente está muy feliz de no tener que tener en su nariz ese humo negro pero tenemos una empresa menos de electricidad por lo que no tenemos que vender para mantenernos.";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 21)
    //     {
    //         signText.text = "¡Vaya! Nos ahorramos dinero por ahora y tenemos menos energía porque nuestras viejas plantas están dejando de funcionar";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 210)
    //     {
    //         signText.text = "¡Vaya! Nos ahorramos dinero por ahora y tenemos menos energía porque nuestras viejas plantas están dejando de funcionar";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 22)
    //     {
    //         signText.text = "Te ahorraste dinero pero seguimos contaminando generando electricidad con combustibles fósiles";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 23)
    //     {
    //         signText.text = "¡Vaya! te ahorraste dinero pero estas dañando fuertemente el ambiente seguro que en el futuro costará mucho más.";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 24)
    //     {
    //         signText.text = "¡Vaya! te evitaste unas protestas interminables pero ya no tienes energía porque tus viejas plantas están dejando de funcionar.";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 25)
    //     {
    //         signText.text = "Está desaprovechando  la energía térmica de las plantas, tendrás que usar más combustible para generar calor que necesitas en otros procesos";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 26)
    //     {
    //         signText.text = "¡Vaya! Los habitantes del lugar dónde querías poner tu parque eólico se sienten aliviados de no perder sus casas pero tu población necesita electricidad ";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 27)
    //     {
    //         signText.text = "";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 28)
    //     {
    //         signText.text = "";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 29)
    //     {
    //         signText.text = "";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 30)
    //     {
    //         signText.text = "";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 31)
    //     {
    //         signText.text = "";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 32)
    //     {
    //         signText.text = "";
    //     }
    //     else if(GameMaster.todosLosContratos[actualContract].id == 33)
    //     {
    //         signText.text = "";
    //     }
    // }

}
