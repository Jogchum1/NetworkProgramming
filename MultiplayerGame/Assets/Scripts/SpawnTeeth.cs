using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTeeth : MonoBehaviour
{
    public GameObject toothPrefab;
    public int toothAmount = 10;
    public int badToothNumber;


    [SerializeField]
    private List<GameObject> toothList = new List<GameObject>();
    private GameObject badTooth;
    private GameObject Tooth;

    private void Start()
    {
        for (int i = 0; i < toothAmount; i++)
        {
            Vector3 position = new Vector3(i * 2, 0, 0);
            Tooth = Instantiate(toothPrefab, position, Quaternion.identity);
            toothList.Add(Tooth);
            
        }

        badToothNumber = Random.Range(0, toothList.Count);
        badTooth = toothList[badToothNumber];
       
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                // whatever tag you are looking for on your game object
                if (hit.collider.tag == "Tooth")
                {
                    Debug.Log("---> Hit: " + toothList.IndexOf(hit.transform.gameObject));

                    if(toothList.IndexOf(hit.transform.gameObject) == badToothNumber)
                    {
                        badTooth.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                        Debug.Log("YOU LOSE");
                    }
                    else
                    {
                        hit.transform.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
                    }
                }
            }
        }
    }


}
