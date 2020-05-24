using UnityEngine;
using UnityEngine.Tilemaps;
 
 //Este archivo es de prueba, ignorar
 
public class TileTest : MonoBehaviour
{
    public Tile tile;
    public Tilemap tilemap;
 
    private Vector3Int previous;
    
    private void Start() 
    {
        Vector3Int currentCell = tilemap.WorldToCell(new Vector3(3f,0f,0f));
        tilemap.SetTile(currentCell, tile);
    }

}
