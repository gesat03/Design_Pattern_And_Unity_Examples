using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShipExample
{
    public class StartStop : MonoBehaviour
    {

        //public GameObject SettingsPanel;
        public GameObject Obj;

        void Start()
        {
            SettingsPanel.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            ObjMove();
        }

        Vector3 dis;

        void ObjMove()
        {
            //dis = Vector3.Lerp(Obj.transform.localPosition, new Vector3(750, -500, 0), Time.deltaTime);
            dis = Obj.transform.localPosition - (Vector3.left * Time.deltaTime * 200);

            Obj.transform.localPosition = dis;
        }

        // Canvasdaki settings paneli buna ekle
        public GameObject SettingsPanel;

        // Settingsi açacağın düğmeye bu komutu ata
        // Aslında direk oyun timenı 0laman yeterli olacaktır
        public void OpenSettingsClick()
        {
            SettingsPanel.SetActive(true);
            Time.timeScale = 0;
        }
        // Burada da setting paneli kapattığın butona bu fonk'u ata
        public void CloseSettingsClick()
        {
            SettingsPanel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
