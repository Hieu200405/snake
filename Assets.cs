using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CodeMonkey {
    public class Assets : MonoBehaviour {
        private static Assets _i; 
        public static Assets i {
            get { 
                if (_i == null) _i = (Instantiate(Resources.Load("CodeMonkeyAssets")) as GameObject).GetComponent<Assets>(); 
                return _i; 
            }
        }
        public Sprite s_White;

    }

}
