using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camare : MonoBehaviour
{
    public GameObject player;
    public Camera playerCamera;
    public GameObject[] prefabBlock;
    public float gamePointer;
    public float respawn = 12;
    
    public bool defeat;


   
    void Start()
    {
        gamePointer = 5;
        defeat = false;
    }

    
    void Update()
    {
       

        while (player != null && gamePointer < player.transform.position.x + respawn)
        {
            int indiceBloque = Random.Range(0, prefabBlock.Length - 1);
            if (gamePointer < 0)
            {
                indiceBloque = 5;
            }

            GameObject Objetobloque = Instantiate(prefabBlock[indiceBloque]);
            Objetobloque.transform.SetParent(this.transform);
            Block bloque = Objetobloque.GetComponent<Block>();
            Objetobloque.transform.position = new Vector2(
                gamePointer + bloque.size / 2,
                0
                );
            gamePointer += bloque.size;



        }




    }
}
