namespace Homework_04
{
    class Task_01
    {
        int width;
        int height;

        public int[,] Moves { get; private set; }
        public int[,] Desk { get; set; }

        public Task_01(int h = 8, int w = 8)
        {
            this.width = w;
            this.height = h;
            this.Moves = new int[h, w];
            this.Desk = new int[h, w];
            this.FillFieldMatrixWithUnits();
        }

        public int[,] Run()
        {
            CalculateMatrix(width, height);
            return Desk;
        }

        private void CalculateMatrix(int n, int m)
        {
            for (int j = 0; j < height; j++)
            {
                Moves[0, j] = 1;
            }
            for (int i = 1; i < width; i++)
            {
                Moves[i, 0] = 1;

                for (int j = 1; j < height; j++)
                {
                    if (Desk[i, j] == 1)
                    {
                        if (Moves[i, j - 1] == 0 ^ Moves[i - 1, j] == 0)
                        {
                            Moves[i, j] = Moves[i, j - 1] + Moves[i - 1, j] + 1;
                        }
                        else
                        {
                            Moves[i, j] = Moves[i, j - 1] + Moves[i - 1, j];
                        }
                    }
                    else Moves[i, j] = 0;
                }
            }
        }

        private void FillFieldMatrixWithUnits()
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    this.Desk[i, j] = 1;
                }
            }
        }
    }
}