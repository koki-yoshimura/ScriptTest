using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public class Boss
    {
        int mp = 53;

        public void Magic()
        {
            for (int a = 0; a < 11; a++)
            {
                if (this.mp >= 5)
                {
                    Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
                    mp -= 5;
                }

                else
                {
                    Debug.Log("MPが足りないため魔法が使えない。");
                }

            }

        }


    }
     

    // Use this for initialization
    void Start () {

        int[] array = {30, 20, 50, 10, 80};

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }


        for (int y = 4; y >= 0 ; y--)
        {
            Debug.Log(array[y]);
        }

        Boss lastboss = new Boss();
        lastboss.Magic();

    }
	
	// Update is called once per frame
	void Update () {




    }
}
