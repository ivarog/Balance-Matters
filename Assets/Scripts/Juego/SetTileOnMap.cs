using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class SetTileOnMap : MonoBehaviour
{
    //Este diccionario gaurdará que tiles se sustituirán en el mapa después de una renovación
    //Su primer parametro es el el id de la construccion y el segundo en una lista que contendrá la posicion
    //y el tile a cambiar
    public Dictionary<string, ArrayList> tilesForChange;
    [SerializeField] Tilemap myTilemap;

    private void Start() 
    {
        InitDictionary();
    }

    //Inicializo el diccionario con la informacion de tiles y su colocación en el mapa
    private void InitDictionary()
    {
        tilesForChange = new Dictionary<string, ArrayList>();
        //Todo esto es un ejemplo   
        //Pregunta 6 Pasado
        AddTileToDictionary("Tree_E_1", new Vector3(0, 1, 0), "Tree_E");
        AddTileToDictionary("Tree_E_2", new Vector3(0, 2, 0), "Tree_E");
        AddTileToDictionary("Tree_E_3", new Vector3(1, 1, 0), "Tree_E");
        AddTileToDictionary("Tree_E_4", new Vector3(1, 2, 0), "Tree_E");
        //Pregunta 6 Presente
        AddTileToDictionary("Tree_E_5", new Vector3(0, -7, 0), "Tree_E");
        AddTileToDictionary("Tree_E_6", new Vector3(0, -8, 0), "Tree_E");
        AddTileToDictionary("Tree_E_7", new Vector3(1, -7, 0), "Tree_E");
        AddTileToDictionary("Tree_E_8", new Vector3(1, -8, 0), "Tree_E");
        //Pregunta 6 Futuro
        AddTileToDictionary("Tree_E_9", new Vector3(12, -7, 0), "Tree_E");
        AddTileToDictionary("Tree_E_10", new Vector3(12, -8, 0), "Tree_E");
        AddTileToDictionary("Tree_E_11", new Vector3(13, -7, 0), "Tree_E");
        AddTileToDictionary("Tree_E_12", new Vector3(13, -8, 0), "Tree_E");
        //Pregunta 11 Pasado
        AddTileToDictionary("House_B_1", new Vector3(0, -2, 0), "House_B");
        AddTileToDictionary("House_B_2", new Vector3(0, -5, 0), "House_B");
        AddTileToDictionary("House_B_3", new Vector3(5, -7, 0), "House_B");
        //Pregunta 11 Presente
        AddTileToDictionary("House_B_4", new Vector3(5, -2, 0), "House_B");
        AddTileToDictionary("House_B_5", new Vector3(8, 1, 0), "House_B");
        AddTileToDictionary("House_B_6", new Vector3(8, -1, 0), "House_B");
        //Pregunta 13 Pasado
        AddTileToDictionary("Fabrica_A_1", new Vector3(0, 4, 0), "Fabrica_A_1");
        AddTileToDictionary("Fabrica_A_2", new Vector3(1, 4, 0), "Fabrica_A_2");
        //Pregunta 13 Presente
        AddTileToDictionary("Fabrica_A_3", new Vector3(6, 4, 0), "Fabrica_A_1");
        AddTileToDictionary("Fabrica_A_4", new Vector3(7, 4, 0), "Fabrica_A_2");
        //Pregunta 14 Pasado
        AddTileToDictionary("Farm_A_1", new Vector3(5, 2, 0), "Farm_A");
        AddTileToDictionary("Cow_A_1", new Vector3(4, 2, 0), "Cow_A");
        //Pregunta 14 Presente
        AddTileToDictionary("Farm_A_3", new Vector3(10, -4, 0), "Farm_A");
        AddTileToDictionary("Cheep_A_1", new Vector3(9, -4, 0), "Cheep_A");
        //Pregunta 14 Futuro
        AddTileToDictionary("Farm_A_5", new Vector3(7, -7, 0), "Farm_A");
        AddTileToDictionary("Chiken_A_1", new Vector3(8, -7, 0), "Chiken_A");
        //Pregunta 18 Pasado
        AddTileToDictionary("Fabrica_B_1", new Vector3(3, 4, 0), "Fabrica_B_1");
        AddTileToDictionary("Fabrica_B_2", new Vector3(4, 4, 0), "Fabrica_B_2");
        //Pregunta 18 Presente
        AddTileToDictionary("Fabrica_B_3", new Vector3(9, 4, 0), "Fabrica_B_1");
        AddTileToDictionary("Fabrica_B_4", new Vector3(10, 4, 0), "Fabrica_B_2");
        //Pregunta 19 Pasado
        AddTileToDictionary("Carrots_A_1", new Vector3(10, -2, 0), "Carrots_A");
        AddTileToDictionary("Carrots_A_2", new Vector3(11, -2, 0), "Carrots_A");
        //Pregunta 19 Presente
        AddTileToDictionary("Carrots_A_3", new Vector3(12, -1, 0), "Carrots_A");
        AddTileToDictionary("Carrots_A_4", new Vector3(13, -1, 0), "Carrots_A");
        //Pregunta 20 Pasado
        AddTileToDictionary("Fabrica_A_5", new Vector3(12, 4, 0), "Fabrica_A_1");
        AddTileToDictionary("Fabrica_A_6", new Vector3(13, 4, 0), "Fabrica_A_2");
        //Pregunta 21 PRESENTE
        AddTileToDictionary("Fabrica_A_7", new Vector3(1, 5, 0), "Fabrica_A_1");
        AddTileToDictionary("Fabrica_A_8", new Vector3(2, 5, 0), "Fabrica_A_2");
        //Pregunta 21 Futuro
        AddTileToDictionary("Fabrica_B_5", new Vector3(8, 5, 0), "Fabrica_B_1");
        AddTileToDictionary("Fabrica_B_6", new Vector3(9, 5, 0), "Fabrica_B_2");
        //Pregunta 210 PRESENTE
        AddTileToDictionary("Panel_A_1", new Vector3(10, 2, 0), "Panel_A");
        AddTileToDictionary("Panel_A_2", new Vector3(11, 2, 0), "Panel_A");
        //Pregunta 210 Futuro
        AddTileToDictionary("Panel_A_3", new Vector3(12, 2, 0), "Panel_A");
        AddTileToDictionary("Panel_A_4", new Vector3(13, 2, 0), "Panel_A");
        //Pregunta 23 presente
        AddTileToDictionary("Nuclear_A_1", new Vector3(5, 5, 0), "Nuclear_A_1");
        AddTileToDictionary("Nuclear_A_2", new Vector3(6, 5, 0), "Nuclear_A_2");
        //Pregunta 23 Futuro
        AddTileToDictionary("Nuclear_A_3", new Vector3(11, 5, 0), "Nuclear_A_1");
        AddTileToDictionary("Nuclear_A_4", new Vector3(12, 5, 0), "Nuclear_A_2");
        //Pregunta 25 presente
        AddTileToDictionary("Air_A_1", new Vector3(5, 2, 0), "Air_A");
        //Pregunta 25 Futuro
        AddTileToDictionary("Air_A_2", new Vector3(10, -4, 0), "Air_A");
        //Pregunta 26 pasado
        AddTileToDictionary("Club_A_1", new Vector3(6, 1, 0), "Club_A");
        //Pregunta 26 presente
        AddTileToDictionary("Club_A_2", new Vector3(4, -4, 0), "Club_A");
        //Pregunta 26 Futuro
        AddTileToDictionary("Club_A_3", new Vector3(10, -1, 0), "Club_A");
        //Pregunta 27 pasado
        AddTileToDictionary("Park_A_1", new Vector3(6, -1, 0), "Park_A");
        //Pregunta 27 presente
        AddTileToDictionary("Park_A_2", new Vector3(8, -4, 0), "Park_A");
        //Pregunta 27 Futuro
        AddTileToDictionary("Park_A_3", new Vector3(2, -7, 0), "Park_A");
        //Pregunta 28 pasado
        AddTileToDictionary("Cinema_A_1", new Vector3(2, 1, 0), "Cinema_A");
        //Pregunta 28 presente
        AddTileToDictionary("Cinema_A_2", new Vector3(4, -1, 0), "Cinema_A");
        //Pregunta 28 Futuro
        AddTileToDictionary("Cinema_A_3", new Vector3(9, -5, 0), "Cinema_A");
        //Pregunta 29 pasado
        AddTileToDictionary("Hospital_A_1", new Vector3(1, -4, 0), "Hospital_A");
        //Pregunta 29 presente
        AddTileToDictionary("Hospital_A_2", new Vector3(3, 2, 0), "Hospital_A");
        //Pregunta 29 Futuro
        AddTileToDictionary("Hospital_A_3", new Vector3(13, -2, 0), "Hospital_A");
        //Pregunta 30 presente
        AddTileToDictionary("Tree_D_1", new Vector3(1, -2, 0), "Tree_D");
        //Pregunta 30 Futuro
        AddTileToDictionary("Tree_D_2", new Vector3(6, -4, 0), "Tree_D");
        //Pregunta 32 pasado
        AddTileToDictionary("School_A_1", new Vector3(9, 1, 0), "School_A");
        //Pregunta 32 presente
        AddTileToDictionary("School_A_2", new Vector3(2, -4, 0), "School_A");
        //Pregunta 32 Futuro
        AddTileToDictionary("School_A_3", new Vector3(3, -7, 0), "School_A");

    }

    //Activa el tile por el id colocado
    public void ActivateTile(string id)
    {   
        ArrayList data = tilesForChange[id];
        Vector3 position = (Vector3)data[0];
        Tile tile = (Tile)data[1];
        Vector3Int currentCell = myTilemap.WorldToCell(position);
        myTilemap.SetTile(currentCell, tile);
    }

    public void DeleteTile(Vector3 position)
    {
        Vector3Int currentCell = myTilemap.WorldToCell(position);
        myTilemap.SetTile(currentCell, null);
    }

    //Necesitas colocar id del tile a guardar, la posicion que tendrá en el mapa y el nombre del tile en la carpeta de recursos
    private void AddTileToDictionary(string id, Vector3 position, string tileName)
    {
        ArrayList dataTile = new ArrayList();
        dataTile.Add(position);
        dataTile.Add(Resources.Load<Tile>("Tiles/"+tileName));
        //Debug.Log(dataTile[1]);
        tilesForChange.Add(id, dataTile);
    }

}
