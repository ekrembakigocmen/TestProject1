using UnityEngine;
using UnityEngine.UI;

public class SpawnPoint : MonoBehaviour
{
    public GameObject GirlsSpawn;
    public GameObject BoySpawn;
    public GameObject[] SpawnedPlayer;
    public Text sortText;


    //Vector3 pos;


    void Start()
    {
        Initialize();
    }

    private void FixedUpdate()
    {
        Sorting(SpawnedPlayer);
    }

    private void Initialize()
    {
        GameObject Name;
        //pos = new Vector3(Random.Range(-43, -38), 0f, Random.Range(-7, 7));
        //Instantiate(GirlsSpawn, pos, Quaternion.Euler(0, 90, 0));

        Name = Instantiate(BoySpawn, new Vector3(-38, 0, 0), Quaternion.Euler(0, 90, 0));
        Name.name = "Boy";
        SpawnedPlayer[0] = Name;

        for (int i = 1; i < 11; i++)
        {
            Name = Instantiate(GirlsSpawn, new Vector3(-40 - i - 1, 0f, 8.5f - i - 1), Quaternion.Euler(0, 90, 0));
            Name.name = "Girl" + i;
            SpawnedPlayer[0 + i] = Name;
        }

    }

    void Sorting(GameObject[] unSortedList)
    {
       // GameObject boy;
        GameObject temp;
        //Array.Sort(unSortedList);
        //Array.Reverse(unSortedList);
        for (int i = 0; i < unSortedList.Length; i++)
        {
            for (int j = i + 1; j < unSortedList.Length; j++)
            {
                if (Mathf.Round(unSortedList[i].transform.position.x) < Mathf.Round(unSortedList[j].transform.position.x))
                {
                    temp = unSortedList[i];
                    unSortedList[i] = unSortedList[j];
                    unSortedList[j] = temp;
                }
            }
        }

        for (int i = 0; i < unSortedList.Length; i++)
        {
            if (unSortedList[i].name == "Boy")
            {
                int x = i + 1;
                sortText.text = x.ToString();
            }
        }







    }



}
