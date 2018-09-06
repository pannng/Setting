using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class MenuManager : MonoBehaviour
    {

        public GameObject m_object;
        public GameObject childobject;


        void Start()
        {

        DetectionManager.Get().getCurrentObject += GetMenuObj;

        }


        void Update()
        {
            //m_object = DetectionManager.Get().GetCurrentGameObject();
            //childobject = m_object.transform.GetChild(0).gameObject;
        }

        public void GetMenuObj(GameObject currentobject)
        {
            m_object = currentobject;
            childobject = m_object.transform.GetChild(1).gameObject;
        }
        

        public void PresentingthisObjectMenu()
        {
            if(childobject != null)
            {
                if (!childobject.activeSelf)
                {
                     childobject.SetActive(true);
                }

                Debug.Log("This childobject menu has been active!");
            }

    }

        public void HidethisObjectMenu()
        {
            if (childobject != null)
            {
                if (childobject.activeSelf)
                {
                    childobject.SetActive(false);
                }

                Debug.Log("This childobject menu has been deactive!");
            }   
        }   
    }
