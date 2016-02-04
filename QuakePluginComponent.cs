using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Novel{
    public class QuakeComponent:AbstractComponent{
        public QuakeComponent(){
            this.originalParam = new Dictionary<string,string>{
                {"x","1.5"},
                {"y","1.5"},
                {"time","5.0"}
            };
        }
        
        GameObject target = GameObject.Find("MainCamera");
        
        public override void start(){
            double x = double.Parse(this.param["x"]);
            double y = double.Parse(this.param["y"]);
            float time = float.Parse(this.param["time"]);
            iTween.ShakePosition(target, iTween.Hash("x",x, "y",y, "time",time));
            this.gameManager.nextOrder();
        }
    }
}
