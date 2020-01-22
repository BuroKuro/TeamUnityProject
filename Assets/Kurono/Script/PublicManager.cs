using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game
{
    public class PublicManager : MonoBehaviour
    {
        GameObject m_DontDestroySoundOBJ;
        GameObject m_SceneManger;
        GameObject m_GameManager;
        GameObject m_SoundManger;
        GameObject m_EnemyManager;
        GameObject m_PlayerManger;


        public void SetDontDestroySoundOBJ(GameObject obj)
        {
            Destroy(m_DontDestroySoundOBJ);
            m_DontDestroySoundOBJ = obj;
            DontDestroyOnLoad(m_DontDestroySoundOBJ);
        }

        void Start()
        {
            DontDestroyOnLoad(this.gameObject);
        }
        
    }


}
