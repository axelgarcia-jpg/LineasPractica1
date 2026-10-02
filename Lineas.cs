using Raylib_cs;

Raylib.InitWindow(800, 600, "Lineas");

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.White);

    DrawLineDDA(100, 100, 200, 400, Color.Red);

    Raylib.EndDrawing();
}

Raylib.CloseWindow();

static void DrawLineDDA(int x1, int y1, int x2, int y2, Color color)
{
    int dx = x2 - x1;
    int dy = y2 - y1;
    int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));
    if (steps == 0) { Raylib.DrawPixel(x1, y1, color); return; }

    float x = x1, y = y1;
    float xInc = dx / (float)steps;
    float yInc = dy / (float)steps;
    for (int i = 0; i <= steps; i++) {
        Raylib.DrawPixel((int)MathF.Round(x), (int)MathF.Round(y), color);
        x += xInc; y += yInc;
    }
}

