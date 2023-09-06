using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Решил выделить здоровье в отдельный класс,
// чтобы в дальнейшем можно было расширить функционал
// и добавить игроку больше здоровья

public class PlayerHealth : MonoBehaviour
{
    public LevelManager manager;

    public void GetHit()
    {
        manager.Reload();
    }
}
