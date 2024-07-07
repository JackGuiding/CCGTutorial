using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    MainContext mainContext;
    GameContext ctx;

    bool isInit;
    bool isTeardown;

    void Awake()
    {
        // Construct
        ctx = new GameContext();
        mainContext = new MainContext();

        // Inject
        mainContext.Inject(ctx);

        // Init: Load
        ctx.templateManager.LoadAll();

        // Enter: Login

        isInit = true;

    }

    float restTime;
    void Update()
    {
        if (!isInit) {
            return;
        }
        // Process Input
        var input = ctx.input;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            input.isSpawnDown = true;
        }
        else
        {
            input.isSpawnDown = false;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            input.isUnspawnDown = true;
        }
        else
        {
            input.isUnspawnDown = false;
        }

        // DoLogic
        // - Control -> Behaviour
        {
            // FixedUpdate Implementation
            float dt = Time.deltaTime;

            const float PHX_INTERVAL = 0.02f;

            restTime += dt;

            if (restTime < PHX_INTERVAL)
            {
                FixedTick(restTime);
                restTime = 0;
            }
            else
            {
                while (restTime >= PHX_INTERVAL)
                {
                    FixedTick(PHX_INTERVAL);
                    restTime -= PHX_INTERVAL;
                }
            }
        }

    }


    void FixedTick(float fixdt)
    {
        
        RoleControler.FixLogic(ctx, fixdt);
        
        Physics2D.Simulate(fixdt);

        // IsGround

        // Debug.Log("FixedTick");
    }

    void OnApplicationQuit() {
        TearDown();
    }

    void OnDestroy()
    {
        TearDown();
    }

    void TearDown()
    {
        if (isTeardown)
        {
            return;
        }
        isTeardown = true;

        ctx.templateManager.UnloadAll();
    }
}
