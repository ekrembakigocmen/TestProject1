using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    GameObject Player;
    public GameObject Wall;
   // public Camera cam;
   // public Texture2D Brush;
  //  public Vector2Int textureArea;
   // Texture2D texture;
   // bool paint = false;
    



    void Start()
    {

        // cam = GetComponent<Camera>();
        // Wall = GetComponent<GameObject>();
       // texture = new Texture2D(textureArea.x, textureArea.y, TextureFormat.ARGB32, false);
      //  Wall.GetComponent<MeshRenderer>().material.mainTexture = texture;

    }

    private void Update()
    {

      /*  if (paint)
        {
            if (Input.GetMouseButton(0))
            {
                RaycastHit hitInfo;
                if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hitInfo))
                {
                    Debug.Log(hitInfo.textureCoord);
                    Paint(hitInfo.textureCoord);

                }

            }
        }*/

    }

    private void OnCollisionEnter(Collision collision)
    {

        Player = GameObject.FindGameObjectWithTag("Player");
        Rigidbody Rb = collision.collider.GetComponent<Rigidbody>();

        if (Rb.CompareTag("Player"))
        {
            Player.GetComponent<CharacterManager>().enabled = false;
            Player.GetComponent<Rigidbody>().isKinematic = true;
            Player.GetComponent<CapsuleCollider>().enabled = false;
            Player.GetComponent<CharacterManager>().InputMove(0f);
            Player.GetComponent<Transform>().position = new Vector3(59.5f, 0, 0);
            Wall.SetActive(true);
            //paint = true;
        }
    }


   /* void Paint(Vector2 coordinate)
    {
        coordinate.x *= texture.width;//e-1 değerini tam nokta piksellere çevirdik
        coordinate.y *= texture.height;//Yani 0-1024 yaptık
        Color32[] textureC32 = texture.GetPixels32();
        Color32[] brushC32 = Brush.GetPixels32();
        texture.GetPixels32();
        //Firçanın ortasının koordinatları, kare fırça ise float da olabilir
        Vector2Int halfBrush = new Vector2Int(Brush.width / 2, Brush.height / 2);
        for (int x = 0; x < Brush.width; x++)
        {
            int xPos = x - halfBrush.x + (int)coordinate.x;
            for (int y = 0; y < Brush.height; y++)
            {
                int yPos = y - halfBrush.y + (int)coordinate.y;
                if (brushC32[x + (y * Brush.width)].a > 0f)
                {
                    int tPos =
                       xPos + //X (U) posizyonu
                        (texture.width * yPos); //Y (V) Posizyonu
                    if (brushC32[x + (y * Brush.width)].r < textureC32[tPos].r)
                        textureC32[tPos] = brushC32[x + (y * Brush.width)];

                }

            }
        }
        texture.SetPixels32(textureC32);
        texture.Apply();
    }*/
}

