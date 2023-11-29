using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandelZombie : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject gameObject;
    [SerializeField] Transform spaown;
    private GameObject[]array12;
    bool is_zombie_found;
    int _round = 1;
    bool add_number;
    void Start()
    {
        array12 = new GameObject[100];
        round();
    }
    void round()
    {
        is_zombie_found = false;
        for (int i = 0; i < array12.Length;i++)
        {
            if (array12[i] != null)
            {
                add_number = true;
                is_zombie_found = true;
                break;
            }
        }
        if (!is_zombie_found)
        {
            for (int x = 0; x < 10 * _round; x++)
            {
                if (x != 10 * _round)
                {
                    if (add_number)
                    {
                        add_number = false;
                        _round++;
                    }
                    array12[x] = Instantiate(gameObject, spaown.position, Quaternion.identity);
                    array12[x].GetComponent<zombieController>().target = transform;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        round();
    }

}
