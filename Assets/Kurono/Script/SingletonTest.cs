using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game
{
    class SingletonTest : Singleton<SingletonTest>
    {
        float SDSA = 20;
        public void Test()
        {
            Debug.Log("シングルトン！");
        }
        public void sdsa()
        {
            Debug.Log("sdsa"+SDSA);
        }
        public void Setsdsa(float s)
        {
            SDSA = s;
            Debug.Log("Set:"+SDSA);
        }
    }
    
}