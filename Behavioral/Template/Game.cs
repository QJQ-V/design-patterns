using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class Game
    {
        public abstract void Initialize();
        public abstract void StartPlay();
        public abstract void EndPlay();

        //模板
        public void Play()
        {

            //初始化游戏
            Initialize();

            //开始游戏
            StartPlay();

            //结束游戏
            EndPlay();
        }
    }
}
