using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public GameObject go;
    public GameObject player;
    public GameObject lockedDoor;
    public GameObject testEnemy;
    public Timer timer;

    public Text infoTxt;
    public int step = 0;
    bool choice;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Yes()
    {
        choice = true;
    }
    private void Update()
    {
        if (choice == true)
        {
            go.SetActive(false);
            if (step == 0)
                infoTxt.text = "MOVEMENT INFORMATION: \n TRY JUMPING BY PRESSING W";
            else if (step == 1)
                infoTxt.text = "GOOD JOB!\n NOW, MOVE HORIZONTALLY BY USING D (RIGHT) AND A (LEFT)";
            else if (step == 2) 
                infoTxt.text = "PERFECT, YOU HAVE NOW LEARNED TO MOVE.\n LET'S PRESENT YOUR SPECIAL ABILITY: SHAPESHIFTING. WHEN THE CHARGE (WHITE BAR) IS READY, PRESS P TO CHANGE INTO THE FIGHTING SHAPE.\n";
            else if (step == 3)
                infoTxt.text = "You are now in the fighting shape.\n When you are in the fighting shape, you are capable of killing enemies, but also getting hurt, which is the complete opposite of Non-fighting mode.\n When this is understood, press RETURN".ToUpper();
            else if (step == 4)
            {
                infoTxt.text = "While you are in fighting mode, you can spit your lethal and rock hard venom by pressing SPACE. Try killing this guy!".ToUpper();
                testEnemy.SetActive(true);
                step = 5;
            }
            else if (step == 5)
            {
                if (testEnemy == null)
                    step = 6;
            }
            else if (step == 6)
            {
                infoTxt.text = "You are now ready to fight, go forward and enter the new room. Good luck.".ToUpper();
            }

            if (Input.GetKeyDown(KeyCode.W) && step == 0)
                step++;
            if(Input.GetKeyDown(KeyCode.D) &&step == 1 || Input.GetKeyDown(KeyCode.A) && step == 1)
                step++;
            if (Input.GetKeyDown(KeyCode.P) && step == 2)
                step++;
            if (Input.GetKey(KeyCode.Return) && step == 3)
                step++;
        }
    }

    public void No()
    {
        go.SetActive(false);
        lockedDoor.SetActive(true);
        player.transform.position = new Vector2(26, player.transform.position.y);
        Camera.main.transform.position = new Vector3(26, Camera.main.transform.position.y, Camera.main.transform.position.z);
        timer.StartTimer();
    }
}
