using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    ////Player UI
    //public Slider UIPlayerLifeBar;
    ////PlayerVariables
    //PlayerController player;

    public bool isPaused;


    //// Boss UI
    //public GameObject UIBossStats;
    //public Slider UIBossLifeSlider;
    //public Text UIBossLifeText;



    //// BossVariables
    ////public Enemy_Kamikaze bossEnemy;
    ////float KamikazeDistanceFromPlayer;



    //public CameraController mainCamera;
    void Start()
    {
        isPaused = false;
        //player = FindObjectOfType<PlayerController>();
    }
    //void Update()
    //{
    //    CheckBossLife();
    //    CheckDistanceFromPlayer();
    //    CheckPlayerLife();
    //}
    //void CheckBossLife()
    //{
    //    float bossLife = bossEnemy.life / 100;
    //    UIBossLifeSlider.value = bossLife;
    //    UIBossLifeText.text = bossEnemy.life.ToString("f0");
    //    if (bossLife <= 0)
    //    {
    //        Destroy(UIBossStats.gameObject);
    //    }
    //}
    //void CheckDistanceFromPlayer()
    //{
    //    if (UIBossStats != null)
    //    {
    //        if (bossEnemy != null)
    //            KamikazeDistanceFromPlayer = Vector3.Distance(bossEnemy.transform.position, player.transform.position);
    //        if (KamikazeDistanceFromPlayer > 5)
    //        {
    //            UIBossStats.SetActive(false);
    //        }
    //        else
    //            UIBossStats.SetActive(true);
    //    }
    //}
    //void CheckPlayerLife()
    //{
    //    UIPlayerLifeBar.value = player.life;
    //}
    //public void MoveCamera()
    //{
    //    mainCamera.Movement();
    //    player.cameraDistanceToTarget = mainCamera.distanceToTarget;
    //}

}
