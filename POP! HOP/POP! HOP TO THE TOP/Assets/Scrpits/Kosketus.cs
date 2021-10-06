using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kosketus : MonoBehaviour
{
    private PlayerMovement player;
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();

    }

    public void LeftArrow()
    {
        player.moveright = false;
        player.moveleft = true;

    }

    public void RightArrow()
    {
        player.moveright = true;
        player.moveleft = false;

    }
    public void PlayerJump()
    {
        player.playerjump = true;
    }
    public void ReleasePlayerJump()
    {
        player.playerjump = false;
    }
    public void ReleaseLeftArrow()
    {
        player.moveleft = false;
 

    }
    public void ReleaseRightArrow()
    {
        player.moveright = false;
    }

    void Update()
    {
        
    }
}
