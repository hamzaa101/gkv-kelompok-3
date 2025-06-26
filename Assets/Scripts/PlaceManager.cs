using UnityEngine;

public class PlaceManager : MonoBehaviour
{
    public GameObject[] places;

    private int currentIndex;
    void Start()
    {
        places[0].SetActive(true);
    }

    public void NextPlace()
    {
        int nextIndex;

        if (currentIndex != places.Length)
        {
            nextIndex = currentIndex + 1;
        }
        else
        {
            nextIndex = 0;
        }
           
        places[currentIndex].SetActive(false);

        places[nextIndex].SetActive(true);

        this.currentIndex = nextIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
