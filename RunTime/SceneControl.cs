using UnityEngine;
using UnityEngine.SceneManagement;

namespace Chou.Tools
{
    /// <summary>
    /// 場景控制.提供載入場景與退出遊戲規範
    /// </summary>

    public class SceneControl : MonoBehaviour
    {

        /// <summary>
        /// 載入場景
        /// </summary>
        /// <param name="sceneName">要載入的場景名稱</param>
        public void LoadScene(string sceneName)
        {
            //場景管理器的載入場景(場景名稱)
            SceneManager.LoadScene(sceneName);
        }


        /// <summary>
        /// 退出遊戲
        /// </summary>
        public void QuitGame()
        {
            Application.Quit();
        }
    }
}