using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace UnityBasic.Prototype2
{
    
    public class GameManager : MonoBehaviour
    {
        [Header("UI ╫ц╫╨еш")]
        public TextMeshProUGUI Score;
        public int curScore = 0;

        // Start is called before the first frame update
        void Start()
        {
            Score.text = $"Score : {curScore}";
        }

        // Update is called once per frame
        void Update()
        {
            Score.text = $"Score : {curScore}";
        }
    }
}
