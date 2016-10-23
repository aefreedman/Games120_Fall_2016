using UnityEngine;

public class CreateExplosionAtMouseClickPoint : CreateExplosion
{
    public void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;
        var mouse = Input.mousePosition;
        var screen = Camera.main.ScreenToWorldPoint(mouse);
        CreateExplosionAtLocation(screen);
    }
}