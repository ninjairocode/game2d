using UnityEngine;
using UnityEngine.SceneManagement;

namespace Utils
{
    public class LoadScene : MonoBehaviour
    {
        public void Load(int i)
        {
            SceneManager.LoadScene(i);
        }

        public void Load(string s)
        {
            SceneManager.LoadScene(s);
        }
    }
}
